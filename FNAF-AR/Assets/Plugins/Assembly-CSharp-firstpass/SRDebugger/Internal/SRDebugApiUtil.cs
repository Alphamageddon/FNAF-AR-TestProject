using System.Collections.Generic;
using System.IO;
using System.Net;
using SRF;

namespace SRDebugger.Internal
{
	public static class SRDebugApiUtil
	{
		public static string ParseErrorException(WebException ex)
		{
			if (ex.Response == null)
			{
				return ex.Message;
			}
			try
			{
				return ParseErrorResponse(ReadResponseStream(ex.Response));
			}
			catch
			{
				return ex.Message;
			}
		}

		public static string ParseErrorResponse(string response, string fallback = "Unexpected Response")
		{
			try
			{
				Dictionary<string, object> dictionary = (Dictionary<string, object>)Json.Deserialize(response);
				string text = "";
				text += dictionary["errorMessage"];
				if (dictionary.TryGetValue("errors", out var value) && value is IList<object>)
				{
					foreach (object item in value as IList<object>)
					{
						text += "\n";
						text += item;
					}
				}
				return text;
			}
			catch
			{
				if (response.Contains("<html>"))
				{
					return fallback;
				}
				return response;
			}
		}

		public static bool ReadResponse(HttpWebRequest request, out string result)
		{
			try
			{
				WebResponse response = request.GetResponse();
				result = ReadResponseStream(response);
				return true;
			}
			catch (WebException ex)
			{
				result = ParseErrorException(ex);
				return false;
			}
		}

		public static string ReadResponseStream(WebResponse stream)
		{
			using Stream stream2 = stream.GetResponseStream();
			using StreamReader streamReader = new StreamReader(stream2);
			return streamReader.ReadToEnd();
		}
	}
}
