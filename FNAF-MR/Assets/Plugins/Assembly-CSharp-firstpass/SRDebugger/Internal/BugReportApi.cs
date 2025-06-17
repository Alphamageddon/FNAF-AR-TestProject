using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using SRDebugger.Services;
using SRF;
using UnityEngine;

namespace SRDebugger.Internal
{
	public class BugReportApi
	{
		private readonly string _apiKey;

		private readonly BugReport _bugReport;

		private bool _isBusy;

		private WWW _www;

		public bool IsComplete { get; private set; }

		public bool WasSuccessful { get; private set; }

		public string ErrorMessage { get; private set; }

		public float Progress
		{
			get
			{
				if (_www == null)
				{
					return 0f;
				}
				return Mathf.Clamp01(_www.progress + _www.uploadProgress);
			}
		}

		public BugReportApi(BugReport report, string apiKey)
		{
			_bugReport = report;
			_apiKey = apiKey;
		}

		public IEnumerator Submit()
		{
			if (_isBusy)
			{
				throw new InvalidOperationException("BugReportApi is already sending a bug report");
			}
			_isBusy = true;
			ErrorMessage = "";
			IsComplete = false;
			WasSuccessful = false;
			_www = null;
			try
			{
				string s = BuildJsonRequest(_bugReport);
				byte[] bytes = Encoding.UTF8.GetBytes(s);
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				dictionary["Content-Type"] = "application/json";
				dictionary["Accept"] = "application/json";
				dictionary["Method"] = "POST";
				dictionary["X-ApiKey"] = _apiKey;
				_www = new WWW("http://srdebugger.stompyrobot.uk/report/submit", bytes, dictionary);
			}
			catch (Exception ex)
			{
				ErrorMessage = ex.Message;
			}
			if (_www == null)
			{
				SetCompletionState(wasSuccessful: false);
				yield break;
			}
			yield return _www;
			if (!string.IsNullOrEmpty(_www.error))
			{
				ErrorMessage = _www.error;
				SetCompletionState(wasSuccessful: false);
				yield break;
			}
			if (!_www.responseHeaders.ContainsKey("X-STATUS"))
			{
				ErrorMessage = "Completion State Unknown";
				SetCompletionState(wasSuccessful: false);
				yield break;
			}
			string text = _www.responseHeaders["X-STATUS"];
			if (!text.Contains("200"))
			{
				ErrorMessage = SRDebugApiUtil.ParseErrorResponse(_www.text, text);
				SetCompletionState(wasSuccessful: false);
			}
			else
			{
				SetCompletionState(wasSuccessful: true);
			}
		}

		private void SetCompletionState(bool wasSuccessful)
		{
			_bugReport.ScreenshotData = null;
			WasSuccessful = wasSuccessful;
			IsComplete = true;
			_isBusy = false;
			if (!wasSuccessful)
			{
				Debug.LogError("Bug Reporter Error: " + ErrorMessage);
			}
		}

		private static string BuildJsonRequest(BugReport report)
		{
			Hashtable hashtable = new Hashtable();
			hashtable.Add("userEmail", report.Email);
			hashtable.Add("userDescription", report.UserDescription);
			hashtable.Add("console", CreateConsoleDump());
			hashtable.Add("systemInformation", report.SystemInformation);
			if (report.ScreenshotData != null)
			{
				hashtable.Add("screenshot", Convert.ToBase64String(report.ScreenshotData));
			}
			return Json.Serialize(hashtable);
		}

		private static IList<IList<string>> CreateConsoleDump()
		{
			List<IList<string>> list = new List<IList<string>>();
			foreach (ConsoleEntry entry in Service.Console.Entries)
			{
				List<string> list2 = new List<string>();
				list2.Add(entry.LogType.ToString());
				list2.Add(entry.Message);
				list2.Add(entry.StackTrace);
				if (entry.Count > 1)
				{
					list2.Add(entry.Count.ToString());
				}
				list.Add(list2);
			}
			return list;
		}
	}
}
