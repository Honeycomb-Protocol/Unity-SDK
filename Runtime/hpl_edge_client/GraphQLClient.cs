using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HplEdgeClient.Client
{
  public class GraphQLClient
  {
    private static readonly HttpClient httpClient = new HttpClient(); // Singleton HttpClient for efficiency
    private string url;

    private class GraphQLQuery<T>
    {
      public string query { get; set; }
      public T variables { get; set; }
      public string operationName { get; set; }
    }

    public class GraphQLQueryResult<T>
    {
      public string Raw { get; }
      public T Data { get; }
      public Exception Exception { get; }

      public GraphQLQueryResult(string text, Exception ex = null)
      {
        Raw = text;
        Exception = ex;

        if (!string.IsNullOrEmpty(text))
        {
          try
          {
            var response = JObject.Parse(text);

            if (response.ContainsKey("errors"))
            {
              Exception = new Exception(response["errors"].ToString());
            }
            else if (response.ContainsKey("data"))
            {
              Data = response["data"].ToObject<T>();
            }
            else
            {
              Exception ??= new Exception("No data in response");
            }
          }
          catch (JsonException jsonEx)
          {
            Exception = jsonEx;
          }
        }
        else
        {
          Exception = new Exception("Empty or null response text");
        }
      }

      public T GetData()
      {
        if (Exception != null)
        {
          throw Exception;
        }
        return Data;
      }
    }

    public GraphQLClient(string url)
    {
      this.url = url;
    }

    public void Initialize(string url)
    {
      this.url = url;
    }

    // Conditionally compile the SendAsyncRequest based on the runtime
#if UNITY_EDITOR || UNITY_STANDALONE || UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL
    // Unity-specific implementation using CrossHttpClient
    private Task<HttpResponseMessage> SendAsyncRequest(HttpClient httpClient, HttpRequestMessage httpReq)
    {
      return Solana.Unity.Rpc.Core.Http.CrossHttpClient.SendAsyncRequest(httpClient, httpReq); // Unity-specific HttpClient wrapper
    }
#else
    // Default implementation for .NET or other non-Unity environments
    private async Task<HttpResponseMessage> SendAsyncRequest(HttpClient httpClient, HttpRequestMessage httpReq)
    {
      return await httpClient.SendAsync(httpReq).ConfigureAwait(false);
    }
#endif
    public async Task<GraphQLQueryResult<T>> Query<T, V>(string query, V variables, string authToken = null)
    {
      try
      {
        var fullQuery = new GraphQLQuery<V>
        {
          query = query,
          variables = variables
        };

        string jsonContent = JsonConvert.SerializeObject(fullQuery, new JsonSerializerSettings
        {
          NullValueHandling = NullValueHandling.Ignore // Ignore null values in variables
        });

        var httpReq = new HttpRequestMessage(HttpMethod.Post, url)
        {
          Content = new StringContent(jsonContent, Encoding.UTF8, "application/json")
        };

        // Add the authorization header if the token is provided
        if (!string.IsNullOrEmpty(authToken))
        {
          httpReq.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", authToken);
        }

        var httpResp = await SendAsyncRequest(httpClient, httpReq);
        string json = await httpResp.Content?.ReadAsStringAsync(); // Safeguard against null content

        return string.IsNullOrEmpty(json)
            ? new GraphQLQueryResult<T>(null, new Exception("No JSON response"))
            : new GraphQLQueryResult<T>(json);
      }
      catch (Exception ex)
      {
        return new GraphQLQueryResult<T>(null, ex); // Return exception in the result
      }
    }
  }
}