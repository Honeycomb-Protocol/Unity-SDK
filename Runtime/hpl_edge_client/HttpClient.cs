#if UNITY_EDITOR || UNITY_STANDALONE || UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL || UNITY_MONO
#define UNITY
    using UnityEngine;
    using UnityEngine.Networking;
    using Solana.Unity.Rpc.Utilities;
#else
#endif
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;



#if UNITY
namespace HplEdgeClient.Client
{
    public static class HplHttpClient
    {
        public static async Task<HttpResponseMessage> SendAsyncRequest(HttpClient httpClient, HttpRequestMessage httpReq)
        {
            if (RuntimePlatforms.IsWebGL() || (RuntimePlatforms.IsAndroid() && RuntimePlatforms.IsMono()))
            {
                return await SendUnityWebRequest((httpClient.BaseAddress != null) ? httpClient.BaseAddress : httpReq.RequestUri, httpReq);
            }

            return await httpClient.SendAsync(httpReq).ConfigureAwait(continueOnCapturedContext: false);
        }

        private static async Task<HttpResponseMessage> SendUnityWebRequest(Uri uri, HttpRequestMessage httpReq)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                using UnityWebRequest request = new UnityWebRequest(uri, httpReq.Method.ToString());
                if (httpReq.Content != null)
                {
                    UnityWebRequest unityWebRequest = request;
                    unityWebRequest.uploadHandler = new UploadHandlerRaw(await httpReq.Content.ReadAsByteArrayAsync());
                    request.SetRequestHeader("Content-Type", "application/json");
                    if (httpReq.Headers.Authorization != null)
                    {
                        request.SetRequestHeader("Authorization", httpReq.Headers.Authorization.ToString());
                    }
                }

                request.downloadHandler = new DownloadHandlerBuffer();
                if (await SendRequest(request) == UnityWebRequest.Result.Success)
                {
                    response.StatusCode = HttpStatusCode.OK;
                    response.Content = new ByteArrayContent(Encoding.UTF8.GetBytes(request.downloadHandler.text));
                }
                else
                {
                    response.StatusCode = HttpStatusCode.ExpectationFailed;
                }
            }
            catch (Exception ex)
            {
                response.Content = new StringContent("Error: " + ex.Message);
                response.StatusCode = HttpStatusCode.ExpectationFailed;
            }

            return response;
        }

        private static Task<UnityWebRequest.Result> SendRequest(UnityWebRequest request)
        {
            TaskCompletionSource<UnityWebRequest.Result> sendRequestTask = new TaskCompletionSource<UnityWebRequest.Result>();
            try
            {
                UnityWebRequestAsyncOperation op = request.SendWebRequest();
                if (request.isDone)
                {
                    sendRequestTask.SetResult(request.result);
                }
                else
                {
                    op.completed += delegate (AsyncOperation asyncOp)
                    {
                        if (op.webRequest.error != null || request.error != null)
                        {
                            sendRequestTask.SetException(new HttpRequestException((op.webRequest.error == null) ? op.webRequest.error : request.error));
                        }
                        else
                        {
                            sendRequestTask.SetResult(((UnityWebRequestAsyncOperation)asyncOp).webRequest.result);
                        }
                    };
                }
            }
            catch (Exception exception)
            {
                sendRequestTask.TrySetException(exception);
            }

            return sendRequestTask.Task;
        }
    }
}

#else
namespace HplEdgeClient.Client
{
    public static class HplHttpClient
    {
        // Default implementation for .NET or other non-Unity environments
        private async Task<HttpResponseMessage> SendAsyncRequest(HttpClient httpClient, HttpRequestMessage httpReq)
        {
            return await httpClient.SendAsync(httpReq).ConfigureAwait(false);
        }
    }
}
#endif