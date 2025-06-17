using System.IO;
using DiscordRPC.Logging;

namespace DiscordRPC.Registry
{
	internal class MacUriSchemeCreator : IUriSchemeCreator
	{
		private ILogger logger;

		public MacUriSchemeCreator(ILogger logger)
		{
			this.logger = logger;
		}

		public bool RegisterUriScheme(UriSchemeRegister register)
		{
			string executablePath = register.ExecutablePath;
			if (string.IsNullOrEmpty(executablePath))
			{
				logger.Error("Failed to register because the application could not be located.");
				return false;
			}
			logger.Trace("Registering Steam Command");
			string text = executablePath;
			if (register.UsingSteamApp)
			{
				text = "steam://rungameid/" + register.SteamAppID;
			}
			else
			{
				logger.Warning("This library does not fully support MacOS URI Scheme Registration.");
			}
			string text2 = "~/Library/Application Support/discord/games";
			if (!Directory.CreateDirectory(text2).Exists)
			{
				logger.Error("Failed to register because {0} does not exist", text2);
				return false;
			}
			string text3 = text2 + "/" + register.ApplicationID + ".json";
			File.WriteAllText(text3, "{ \"command\": \"" + text + "\" }");
			logger.Trace("Registered {0}, {1}", text3, text);
			return true;
		}
	}
}
