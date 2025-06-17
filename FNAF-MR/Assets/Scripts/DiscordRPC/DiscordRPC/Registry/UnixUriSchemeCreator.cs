using System;
using System.Diagnostics;
using System.IO;
using DiscordRPC.Logging;

namespace DiscordRPC.Registry
{
	internal class UnixUriSchemeCreator : IUriSchemeCreator
	{
		private ILogger logger;

		public UnixUriSchemeCreator(ILogger logger)
		{
			this.logger = logger;
		}

		public bool RegisterUriScheme(UriSchemeRegister register)
		{
			string environmentVariable = Environment.GetEnvironmentVariable("HOME");
			if (string.IsNullOrEmpty(environmentVariable))
			{
				logger.Error("Failed to register because the HOME variable was not set.");
				return false;
			}
			string executablePath = register.ExecutablePath;
			if (string.IsNullOrEmpty(executablePath))
			{
				logger.Error("Failed to register because the application was not located.");
				return false;
			}
			string text = null;
			text = ((!register.UsingSteamApp) ? executablePath : ("xdg-open steam://rungameid/" + register.SteamAppID));
			string text2 = $"[Desktop Entry]\r\nName=Game {register.ApplicationID}\r\nExec={text} %u\r\nType=Application\r\nNoDisplay=true\r\nCategories=Discord;Games;\r\nMimeType=x-scheme-handler/discord-{register.ApplicationID}";
			string text3 = "/discord-" + register.ApplicationID + ".desktop";
			string text4 = environmentVariable + "/.local/share/applications";
			if (!Directory.CreateDirectory(text4).Exists)
			{
				logger.Error("Failed to register because {0} does not exist", text4);
				return false;
			}
			File.WriteAllText(text4 + text3, text2);
			if (!RegisterMime(register.ApplicationID))
			{
				logger.Error("Failed to register because the Mime failed.");
				return false;
			}
			logger.Trace("Registered {0}, {1}, {2}", text4 + text3, text2, text);
			return true;
		}

		private bool RegisterMime(string appid)
		{
			string arguments = string.Format("default discord-{0}.desktop x-scheme-handler/discord-{0}", appid);
			Process process = Process.Start("xdg-mime", arguments);
			process.WaitForExit();
			return process.ExitCode >= 0;
		}
	}
}
