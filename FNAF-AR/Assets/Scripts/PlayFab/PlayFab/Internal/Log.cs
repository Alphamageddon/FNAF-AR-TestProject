using System;
using UnityEngine;

namespace PlayFab.Internal
{
	[Obsolete("This logging utility has been deprecated. Use UnityEngine.Debug.Log")]
	public static class Log
	{
		[Obsolete("Debug is deprecated.")]
		public static void Debug(string text, params object[] args)
		{
			if ((PlayFabSettings.LogLevel & PlayFabLogLevel.Debug) != PlayFabLogLevel.None)
			{
				UnityEngine.Debug.Log(PlayFabUtil.timeStamp + " DEBUG: " + PlayFabUtil.Format(text, args));
			}
		}

		[Obsolete("Info is deprecated.")]
		public static void Info(string text, params object[] args)
		{
			if ((PlayFabSettings.LogLevel & PlayFabLogLevel.Info) != PlayFabLogLevel.None)
			{
				UnityEngine.Debug.Log(PlayFabUtil.timeStamp + " INFO: " + PlayFabUtil.Format(text, args));
			}
		}

		[Obsolete("Warning is deprecated.")]
		public static void Warning(string text, params object[] args)
		{
			if ((PlayFabSettings.LogLevel & PlayFabLogLevel.Warning) != PlayFabLogLevel.None)
			{
				UnityEngine.Debug.LogWarning(PlayFabUtil.timeStamp + " WARNING: " + PlayFabUtil.Format(text, args));
			}
		}

		[Obsolete("Error is deprecated.")]
		public static void Error(string text, params object[] args)
		{
			if ((PlayFabSettings.LogLevel & PlayFabLogLevel.Error) != PlayFabLogLevel.None)
			{
				UnityEngine.Debug.LogError(PlayFabUtil.timeStamp + " ERROR: " + PlayFabUtil.Format(text, args));
			}
		}
	}
}
