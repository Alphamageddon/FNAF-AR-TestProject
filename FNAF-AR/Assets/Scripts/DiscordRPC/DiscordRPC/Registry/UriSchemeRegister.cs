using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using DiscordRPC.Logging;

namespace DiscordRPC.Registry
{
	internal class UriSchemeRegister
	{
		private ILogger _logger;

		public string ApplicationID { get; set; }

		public string SteamAppID { get; set; }

		public bool UsingSteamApp
		{
			get
			{
				if (!string.IsNullOrEmpty(SteamAppID))
				{
					return SteamAppID != "";
				}
				return false;
			}
		}

		public string ExecutablePath { get; set; }

		public UriSchemeRegister(ILogger logger, string applicationID, string steamAppID = null, string executable = null)
		{
			_logger = logger;
			ApplicationID = applicationID.Trim();
			SteamAppID = steamAppID?.Trim();
			ExecutablePath = executable ?? GetApplicationLocation();
		}

		public bool RegisterUriScheme()
		{
			IUriSchemeCreator uriSchemeCreator = null;
			switch (Environment.OSVersion.Platform)
			{
			case PlatformID.Win32S:
			case PlatformID.Win32Windows:
			case PlatformID.Win32NT:
			case PlatformID.WinCE:
				_logger.Trace("Creating Windows Scheme Creator");
				uriSchemeCreator = new WindowsUriSchemeCreator(_logger);
				break;
			case PlatformID.Unix:
				if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
				{
					_logger.Trace("Creating MacOSX Scheme Creator");
					uriSchemeCreator = new MacUriSchemeCreator(_logger);
				}
				else
				{
					_logger.Trace("Creating Unix Scheme Creator");
					uriSchemeCreator = new UnixUriSchemeCreator(_logger);
				}
				break;
			default:
				_logger.Error("Unkown Platform: {0}", Environment.OSVersion.Platform);
				throw new PlatformNotSupportedException("Platform does not support registration.");
			}
			if (uriSchemeCreator.RegisterUriScheme(this))
			{
				_logger.Info("URI scheme registered.");
				return true;
			}
			return false;
		}

		public static string GetApplicationLocation()
		{
			return Process.GetCurrentProcess().MainModule.FileName;
		}
	}
}
