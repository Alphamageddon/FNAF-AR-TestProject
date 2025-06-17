using System;
using DiscordRPC;
using Lachee.Discord.Attributes;
using UnityEngine;

namespace Lachee.Discord
{
	[Serializable]
	public sealed class Presence
	{
		[Header("Basic Details")]
		[CharacterLimit(128)]
		[Tooltip("The details about the game")]
		public string details = "Playing a game";

		[CharacterLimit(128)]
		[Tooltip("The current state of the game (In Game, In Menu). It appears next to the party size.")]
		public string state = "In Game";

		[Header("Time Details")]
		[Tooltip("The time the game started. Leave as 0 if the game has not yet started.")]
		public Timestamp startTime = 0L;

		[Tooltip("Time the game will end. Leave as 0 to ignore it.")]
		public Timestamp endTime = 0L;

		[Header("Presentation Details")]
		[Tooltip("The images used for the presence")]
		public Asset smallAsset;

		public Asset largeAsset;

		[Header("Button Details")]
		[Tooltip("The buttons used for the presence")]
		public Button[] buttons;

		[Header("Party Details")]
		[Tooltip("The current party. Identifier must not be empty")]
		public Party party = new Party("", 0, 0);

		[Tooltip("The current secrets for the join / spectate feature.")]
		public Secrets secrets;

		public Presence()
		{
		}

		public Presence(BaseRichPresence presence)
		{
			if (presence != null)
			{
				state = presence.State;
				details = presence.Details;
				party = (presence.HasParty() ? new Party(presence.Party) : new Party());
				secrets = (presence.HasSecrets() ? new Secrets(presence.Secrets) : default(Secrets));
				if (presence.HasAssets())
				{
					smallAsset = new Asset
					{
						image = presence.Assets.SmallImageKey,
						tooltip = presence.Assets.SmallImageText,
						snowflake = (presence.Assets.SmallImageID ?? 0)
					};
					largeAsset = new Asset
					{
						image = presence.Assets.LargeImageKey,
						tooltip = presence.Assets.LargeImageText,
						snowflake = (presence.Assets.LargeImageID ?? 0)
					};
				}
				else
				{
					smallAsset = new Asset();
					largeAsset = new Asset();
				}
				if (presence.HasTimestamps())
				{
					startTime = (presence.Timestamps.Start.HasValue ? new Timestamp((long)presence.Timestamps.StartUnixMilliseconds.Value) : Timestamp.Invalid);
					endTime = (presence.Timestamps.End.HasValue ? new Timestamp((long)presence.Timestamps.EndUnixMilliseconds.Value) : Timestamp.Invalid);
				}
			}
			else
			{
				state = "";
				details = "";
				party = new Party();
				secrets = default(Secrets);
				smallAsset = new Asset();
				largeAsset = new Asset();
				startTime = Timestamp.Invalid;
				endTime = Timestamp.Invalid;
			}
			buttons = new Button[0];
		}

		public Presence(RichPresence presence)
			: this((BaseRichPresence)presence)
		{
			if (presence == null)
			{
				return;
			}
			if (presence.HasButtons())
			{
				buttons = new Button[presence.Buttons.Length];
				for (int i = 0; i < presence.Buttons.Length; i++)
				{
					buttons[i] = new Button
					{
						label = presence.Buttons[i].Label,
						url = presence.Buttons[i].Url
					};
				}
			}
			else
			{
				buttons = new Button[0];
			}
		}

		public RichPresence ToRichPresence()
		{
			RichPresence richPresence = new RichPresence();
			richPresence.State = state;
			richPresence.Details = details;
			richPresence.Party = ((!party.IsEmpty()) ? party.ToRichParty() : null);
			richPresence.Secrets = ((!secrets.IsEmpty()) ? secrets.ToRichSecrets() : null);
			if ((smallAsset != null && !smallAsset.IsEmpty()) || (largeAsset != null && !largeAsset.IsEmpty()))
			{
				richPresence.Assets = new Assets
				{
					SmallImageKey = smallAsset.image,
					SmallImageText = smallAsset.tooltip,
					LargeImageKey = largeAsset.image,
					LargeImageText = largeAsset.tooltip
				};
			}
			if (startTime.IsValid() || endTime.IsValid())
			{
				richPresence.Timestamps = new Timestamps();
				if (startTime.IsValid())
				{
					richPresence.Timestamps.Start = startTime.GetDateTime();
				}
				if (endTime.IsValid())
				{
					richPresence.Timestamps.End = endTime.GetDateTime();
				}
			}
			if (buttons.Length != 0)
			{
				richPresence.Buttons = new DiscordRPC.Button[buttons.Length];
				for (int i = 0; i < buttons.Length; i++)
				{
					richPresence.Buttons[i] = new DiscordRPC.Button
					{
						Label = buttons[i].label,
						Url = buttons[i].url
					};
				}
			}
			return richPresence;
		}

		public static explicit operator RichPresence(Presence presence)
		{
			return presence.ToRichPresence();
		}

		public static explicit operator Presence(RichPresence presence)
		{
			return new Presence(presence);
		}
	}
}
