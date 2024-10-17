#if UNITY_EDITOR || UNITY_STANDALONE || UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL || UNITY_MONO
#define UNITY
using UnityEngine;
using UnityEngine.Networking;
#else
#endif

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace HplEdgeClient.Client
{
  public class GraphQLClient
  {
    private static readonly HttpClient httpClient = new HttpClient(); // Singleton HttpClient for efficiency
    private string url;

    [JsonObject(MemberSerialization.OptOut)]
    private class GraphQLQuery<T>
    {
      [JsonProperty("query")]
      public string Query;
      [JsonProperty("variables")]
      public T Variables;
      public GraphQLQuery(string query, T variables)
      {

        // string jsonVariables = JsonConvert.SerializeObject(variables, new JsonSerializerSettings
        // {
        //   NullValueHandling = NullValueHandling.Ignore // Ignore null values in variables
        // });
        // Debug.LogFormat("jsonVariables, {0}", jsonVariables);

        Query = query;
        Variables = variables;
        // Variables = JObject.Parse(jsonVariables);
      }
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

    // Conditionally compile the HttpClient.SendAsyncRequest based on the runtime
    public async Task<GraphQLQueryResult<T>> Query<T, V>(string query, V variables, string authToken = null)
    {
      try
      {
        var fullQuery = new GraphQLQuery<V>(query, variables);
        // {
        //   Query = query,
        //   Variables = variables
        // };

        var serializerSettings = new JsonSerializerSettings
        {
          NullValueHandling = NullValueHandling.Ignore,
          Converters = new List<JsonConverter>
          {
            new Newtonsoft.Json.Converters.StringEnumConverter()
          }
        };

        string jsonContent = JsonConvert.SerializeObject(fullQuery, serializerSettings);
        Debug.LogFormat("jsonContent, {0}", jsonContent);

        var httpReq = new HttpRequestMessage(HttpMethod.Post, url)
        {
          Content = new StringContent(jsonContent, Encoding.UTF8, "application/json")
        };
        Debug.LogFormat("httpReq, {0}", httpReq?.ToString());
        // Add the authorization header if the token is provided
        if (!string.IsNullOrEmpty(authToken))
        {
          httpReq.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", authToken);
        }
        Debug.Log(httpReq?.ToString());

        var httpResp = await HplHttpClient.SendAsyncRequest(httpClient, httpReq);
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