using System;
using DiscordRPC.Logging;
using Microsoft.Win32;

namespace DiscordRPC.Registry
{
	internal class WindowsUriSchemeCreator : IUriSchemeCreator
	{
		private ILogger logger;

		public WindowsUriSchemeCreator(ILogger logger)
		{
			this.logger = logger;
		}

		public bool RegisterUriScheme(UriSchemeRegister register)
		{
			if (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX)
			{
				throw new PlatformNotSupportedException("URI schemes can only be registered on Windows");
			}
			string executablePath = register.ExecutablePath;
			if (executablePath == null)
			{
				logger.Error("Failed to register application because the location was null.");
				return false;
			}
			string scheme = "discord-" + register.ApplicationID;
			string friendlyName = "Run game " + register.ApplicationID + " protocol";
			string defaultIcon = executablePath;
			string command = executablePath;
			if (register.UsingSteamApp)
			{
				string steamLocation = GetSteamLocation();
				if (steamLocation != null)
				{
					command = $"\"{steamLocation}\" steam://rungameid/{register.SteamAppID}";
				}
			}
			CreateUriScheme(scheme, friendlyName, defaultIcon, command);
			return true;
		}

		private void CreateUriScheme(string scheme, string friendlyName, string defaultIcon, string command)
		{
			using (RegistryKey registryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\Classes\\" + scheme))
			{
				registryKey.SetValue("", "URL:" + friendlyName);
				registryKey.SetValue("URL Protocol", "");
				using (RegistryKey registryKey2 = registryKey.CreateSubKey("DefaultIcon"))
				{
					registryKey2.SetValue("", defaultIcon);
				}
				using RegistryKey registryKey3 = registryKey.CreateSubKey("shell\\open\\command");
				registryKey3.SetValue("", command);
			}
			logger.Trace("Registered {0}, {1}, {2}", scheme, friendlyName, command);
		}

		public string GetSteamLocation()
		{
			using RegistryKey registryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\Valve\\Steam");
			if (registryKey == null)
			{
				return null;
			}
			return registryKey.GetValue("SteamExe") as string;
		}
	}
}
