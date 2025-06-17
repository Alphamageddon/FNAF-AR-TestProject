using System;
using System.Text;
using DiscordRPC;
using Lachee.Discord.Attributes;
using UnityEngine;

namespace Lachee.Discord
{
	[Serializable]
	public sealed class Party
	{
		[CharacterLimit(128)]
		[Tooltip("The unique ID of the party. Leave empty for no party.")]
		public string identifer;

		[Tooltip("The current size of the party.")]
		public int size;

		[Tooltip("The max size of the party.  Cannot be smaller than size.")]
		public int maxSize;

		public Party(string id, int size, int max)
		{
			identifer = id;
			this.size = size;
			maxSize = max;
		}

		public Party()
		{
		}

		public bool IsEmpty()
		{
			if (size > 0 && maxSize > 0)
			{
				return string.IsNullOrEmpty(identifer);
			}
			return true;
		}

		public Party(DiscordRPC.Party party)
		{
			identifer = party.ID;
			size = party.Size;
			maxSize = party.Max;
		}

		public DiscordRPC.Party ToRichParty()
		{
			if (string.IsNullOrEmpty(identifer))
			{
				return null;
			}
			return new DiscordRPC.Party
			{
				ID = identifer,
				Max = maxSize,
				Size = size
			};
		}

		public static string GenerateRandomIdentifer()
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < 128; i++)
			{
				if (i > 0 && i % 16 == 0)
				{
					stringBuilder.Append("-");
					continue;
				}
				char value = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"[UnityEngine.Random.Range(0, "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".Length)];
				stringBuilder.Append(value);
			}
			return stringBuilder.ToString();
		}
	}
}
