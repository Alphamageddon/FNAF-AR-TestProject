using System;
using Newtonsoft.Json;

namespace DiscordRPC
{
	public class User
	{
		public enum AvatarFormat
		{
			PNG = 0,
			JPEG = 1,
			WebP = 2,
			GIF = 3
		}

		public enum AvatarSize
		{
			x16 = 0x10,
			x32 = 0x20,
			x64 = 0x40,
			x128 = 0x80,
			x256 = 0x100,
			x512 = 0x200,
			x1024 = 0x400,
			x2048 = 0x800
		}

		[Flags]
		public enum Flag
		{
			None = 0,
			Employee = 1,
			Partner = 2,
			HypeSquad = 4,
			BugHunter = 8,
			HouseBravery = 0x40,
			HouseBrilliance = 0x80,
			HouseBalance = 0x100,
			EarlySupporter = 0x200,
			TeamUser = 0x400
		}

		public enum PremiumType
		{
			None = 0,
			NitroClassic = 1,
			Nitro = 2
		}

		[JsonProperty("id")]
		public ulong ID { get; private set; }

		[JsonProperty("username")]
		public string Username { get; private set; }

		[JsonProperty("discriminator")]
		[Obsolete("Discord no longer uses discriminators.")]
		public int Discriminator { get; private set; }

		[JsonProperty("global_name")]
		public string DisplayName { get; private set; }

		[JsonProperty("avatar")]
		public string Avatar { get; private set; }

		[JsonProperty("flags", NullValueHandling = NullValueHandling.Ignore)]
		public Flag Flags { get; private set; }

		[JsonProperty("premium_type", NullValueHandling = NullValueHandling.Ignore)]
		public PremiumType Premium { get; private set; }

		public string CdnEndpoint { get; private set; }

		internal User()
		{
			CdnEndpoint = "cdn.discordapp.com";
		}

		internal void SetConfiguration(Configuration configuration)
		{
			CdnEndpoint = configuration.CdnHost;
		}

		public string GetAvatarURL(AvatarFormat format)
		{
			return GetAvatarURL(format, AvatarSize.x128);
		}

		public string GetAvatarURL(AvatarFormat format, AvatarSize size)
		{
			string text = $"/avatars/{ID}/{Avatar}";
			if (string.IsNullOrEmpty(Avatar))
			{
				if (format != AvatarFormat.PNG)
				{
					throw new BadImageFormatException("The user has no avatar and the requested format " + format.ToString() + " is not supported. (Only supports PNG).");
				}
				int num = (int)((ID >> 22) % 6);
				if (Discriminator > 0)
				{
					num = Discriminator % 5;
				}
				text = $"/embed/avatars/{num}";
			}
			return $"https://{CdnEndpoint}{text}{GetAvatarExtension(format)}?size={(int)size}";
		}

		public string GetAvatarExtension(AvatarFormat format)
		{
			return "." + format.ToString().ToLowerInvariant();
		}

		public override string ToString()
		{
			if (!string.IsNullOrEmpty(DisplayName))
			{
				return DisplayName;
			}
			if (Discriminator != 0)
			{
				return Username + "#" + Discriminator.ToString("D4");
			}
			return Username;
		}
	}
}
