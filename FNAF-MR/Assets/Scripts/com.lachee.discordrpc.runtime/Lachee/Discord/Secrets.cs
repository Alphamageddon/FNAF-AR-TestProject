using System;
using DiscordRPC;
using Lachee.Discord.Attributes;
using UnityEngine;

namespace Lachee.Discord
{
	[Serializable]
	public struct Secrets
	{
		[CharacterLimit(128)]
		[Tooltip("The secret data that will tell the client how to connect to the game to play. This could be a unique identifier for a fancy match maker or player id, lobby id, etc.")]
		public string joinSecret;

		[CharacterLimit(128)]
		[Tooltip("The secret data that will tell the client how to connect to the game to spectate. This could be a unique identifier for a fancy match maker or player id, lobby id, etc.")]
		public string spectateSecret;

		public Secrets(DiscordRPC.Secrets secrets)
		{
			joinSecret = secrets.JoinSecret;
			spectateSecret = secrets.SpectateSecret;
		}

		public bool IsEmpty()
		{
			if (string.IsNullOrEmpty(joinSecret))
			{
				return string.IsNullOrEmpty(spectateSecret);
			}
			return false;
		}

		public DiscordRPC.Secrets ToRichSecrets()
		{
			if (IsEmpty())
			{
				return null;
			}
			return new DiscordRPC.Secrets
			{
				JoinSecret = joinSecret,
				SpectateSecret = spectateSecret
			};
		}
	}
}
