using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using PlayFab.SharedModels;
using UnityEngine;
using UnityEngine.Networking;

namespace PlayFab.Internal
{
	public class PlayFabUnityHttp : ITransportPlugin, IPlayFabPlugin
	{
		private bool _isInitialized;

		private readonly int _pendingWwwMessages;

		public bool IsInitialized => _isInitialized;

		public void Initialize()
		{
			_isInitialized = true;
		}

		public void Update()
		{
		}

		public void OnDestroy()
		{
		}

		public void SimpleGetCall(string fullUrl, Action<byte[]> successCallback, Action<string> errorCallback)
		{
			SingletonMonoBehaviour<PlayFabHttp>.instance.StartCoroutine(SimpleCallCoroutine("get", fullUrl, null, successCallback, errorCallback));
		}

		public void SimplePutCall(string fullUrl, byte[] payload, Action<byte[]> successCallback, Action<string> errorCallback)
		{
			SingletonMonoBehaviour<PlayFabHttp>.instance.StartCoroutine(SimpleCallCoroutine("put", fullUrl, payload, successCallback, errorCallback));
		}

		public void SimplePostCall(string fullUrl, byte[] payload, Action<byte[]> successCallback, Action<string> errorCallback)
		{
			SingletonMonoBehaviour<PlayFabHttp>.instance.StartCoroutine(SimpleCallCoroutine("post", fullUrl, payload, successCallback, errorCallback));
		}

		private static IEnumerator SimpleCallCoroutine(string method, string fullUrl, byte[] payload, Action<byte[]> successCallback, Action<string> errorCallback)
		{
			if (payload == null)
			{
				using (UnityWebRequest www = UnityWebRequest.Get(fullUrl))
				{
					yield return www.SendWebRequest();
					if (!string.IsNullOrEmpty(www.error))
					{
						errorCallback(www.error);
					}
					else
					{
						successCallback(www.downloadHandler.data);
					}
				}
				yield break;
			}
			UnityWebRequest www2;
			if (method == "put")
			{
				www2 = UnityWebRequest.Put(fullUrl, payload);
			}
			else
			{
				www2 = new UnityWebRequest(fullUrl, "POST");
				www2.uploadHandler = new UploadHandlerRaw(payload);
				www2.downloadHandler = new DownloadHandlerBuffer();
				www2.SetRequestHeader("Content-Type", "application/json");
			}
			yield return www2.SendWebRequest();
			if (www2.result == UnityWebRequest.Result.ConnectionError || www2.result == UnityWebRequest.Result.ProtocolError)
			{
				errorCallback(www2.error);
			}
			else
			{
				successCallback(www2.downloadHandler.data);
			}
			www2.Dispose();
		}

		public void MakeApiCall(object reqContainerObj)
		{
			CallRequestContainer callRequestContainer = (CallRequestContainer)reqContainerObj;
			callRequestContainer.RequestHeaders["Content-Type"] = "application/json";
			SingletonMonoBehaviour<PlayFabHttp>.instance.StartCoroutine(Post(callRequestContainer));
		}

		private IEnumerator Post(CallRequestContainer reqContainer)
		{
			UnityWebRequest www = new UnityWebRequest(reqContainer.FullUrl)
			{
				uploadHandler = new UploadHandlerRaw(reqContainer.Payload),
				downloadHandler = new DownloadHandlerBuffer(),
				method = "POST"
			};
			foreach (KeyValuePair<string, string> requestHeader in reqContainer.RequestHeaders)
			{
				if (!string.IsNullOrEmpty(requestHeader.Key) && !string.IsNullOrEmpty(requestHeader.Value))
				{
					www.SetRequestHeader(requestHeader.Key, requestHeader.Value);
				}
				else
				{
					Debug.LogWarning("Null header: " + requestHeader.Key + " = " + requestHeader.Value);
				}
			}
			yield return www.SendWebRequest();
			if (!string.IsNullOrEmpty(www.error))
			{
				OnError(www.error, reqContainer);
			}
			else
			{
				try
				{
					byte[] data = www.downloadHandler.data;
					string response = Encoding.UTF8.GetString(data, 0, data.Length);
					OnResponse(response, reqContainer);
				}
				catch (Exception ex)
				{
					OnError("Unhandled error in PlayFabUnityHttp: " + ex, reqContainer);
				}
			}
			www.Dispose();
		}

		public int GetPendingMessages()
		{
			return _pendingWwwMessages;
		}

		public void OnResponse(string response, CallRequestContainer reqContainer)
		{
			try
			{
				ISerializerPlugin plugin = PluginManager.GetPlugin<ISerializerPlugin>(PluginContract.PlayFab_Serializer);
				HttpResponseObject httpResponseObject = plugin.DeserializeObject<HttpResponseObject>(response);
				if (httpResponseObject.code == 200)
				{
					reqContainer.JsonResponse = plugin.SerializeObject(httpResponseObject.data);
					reqContainer.DeserializeResultJson();
					reqContainer.ApiResult.Request = reqContainer.ApiRequest;
					reqContainer.ApiResult.CustomData = reqContainer.CustomData;
					SingletonMonoBehaviour<PlayFabHttp>.instance.OnPlayFabApiResult(reqContainer);
					PlayFabDeviceUtil.OnPlayFabLogin(reqContainer.ApiResult, reqContainer.settings, reqContainer.instanceApi);
					try
					{
						PlayFabHttp.SendEvent(reqContainer.ApiEndpoint, reqContainer.ApiRequest, reqContainer.ApiResult, ApiProcessingEventType.Post);
					}
					catch (Exception exception)
					{
						Debug.LogException(exception);
					}
					try
					{
						reqContainer.InvokeSuccessCallback();
						return;
					}
					catch (Exception exception2)
					{
						Debug.LogException(exception2);
						return;
					}
				}
				if (reqContainer.ErrorCallback != null)
				{
					reqContainer.Error = PlayFabHttp.GeneratePlayFabError(reqContainer.ApiEndpoint, response, reqContainer.CustomData);
					PlayFabHttp.SendErrorEvent(reqContainer.ApiRequest, reqContainer.Error);
					reqContainer.ErrorCallback(reqContainer.Error);
				}
			}
			catch (Exception exception3)
			{
				Debug.LogException(exception3);
			}
		}

		public void OnError(string error, CallRequestContainer reqContainer)
		{
			reqContainer.JsonResponse = error;
			if (reqContainer.ErrorCallback != null)
			{
				reqContainer.Error = PlayFabHttp.GeneratePlayFabError(reqContainer.ApiEndpoint, reqContainer.JsonResponse, reqContainer.CustomData);
				PlayFabHttp.SendErrorEvent(reqContainer.ApiRequest, reqContainer.Error);
				reqContainer.ErrorCallback(reqContainer.Error);
			}
		}
	}
}
