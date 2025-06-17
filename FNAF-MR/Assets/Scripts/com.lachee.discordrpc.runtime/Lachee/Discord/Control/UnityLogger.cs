using DiscordRPC.Logging;
using UnityEngine;

namespace Lachee.Discord.Control
{
	public sealed class UnityLogger : DiscordRPC.Logging.ILogger
	{
		public LogLevel Level { get; set; }

		public void Trace(string message, params object[] args)
		{
			if (Level <= LogLevel.Trace)
			{
				Debug.Log("<IPC TRACE> " + ((args.Length != 0) ? string.Format(message, args) : message));
			}
		}

		public void Info(string message, params object[] args)
		{
			if (Level <= LogLevel.Info)
			{
				Debug.Log("<IPC> " + ((args.Length != 0) ? string.Format(message, args) : message));
			}
		}

		public void Warning(string message, params object[] args)
		{
			if (Level <= LogLevel.Warning)
			{
				Debug.LogWarning("<IPC> " + ((args.Length != 0) ? string.Format(message, args) : message));
			}
		}

		public void Error(string message, params object[] args)
		{
			if (Level <= LogLevel.Error)
			{
				Debug.LogError("<IPC> " + ((args.Length != 0) ? string.Format(message, args) : message));
			}
		}
	}
}
