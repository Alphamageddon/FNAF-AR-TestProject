using Newtonsoft.Json;

namespace DiscordRPC
{
	public sealed class RichPresence : BaseRichPresence
	{
		[JsonProperty("buttons", NullValueHandling = NullValueHandling.Ignore)]
		public Button[] Buttons { get; set; }

		public bool HasButtons()
		{
			if (Buttons != null)
			{
				return Buttons.Length != 0;
			}
			return false;
		}

		public RichPresence WithState(string state)
		{
			base.State = state;
			return this;
		}

		public RichPresence WithDetails(string details)
		{
			base.Details = details;
			return this;
		}

		public RichPresence WithTimestamps(Timestamps timestamps)
		{
			base.Timestamps = timestamps;
			return this;
		}

		public RichPresence WithAssets(Assets assets)
		{
			base.Assets = assets;
			return this;
		}

		public RichPresence WithParty(Party party)
		{
			base.Party = party;
			return this;
		}

		public RichPresence WithSecrets(Secrets secrets)
		{
			base.Secrets = secrets;
			return this;
		}

		public RichPresence Clone()
		{
			return new RichPresence
			{
				State = ((_state != null) ? (_state.Clone() as string) : null),
				Details = ((_details != null) ? (_details.Clone() as string) : null),
				Buttons = ((!HasButtons()) ? null : (Buttons.Clone() as Button[])),
				Secrets = ((!HasSecrets()) ? null : new Secrets
				{
					JoinSecret = ((base.Secrets.JoinSecret != null) ? (base.Secrets.JoinSecret.Clone() as string) : null),
					SpectateSecret = ((base.Secrets.SpectateSecret != null) ? (base.Secrets.SpectateSecret.Clone() as string) : null)
				}),
				Timestamps = ((!HasTimestamps()) ? null : new Timestamps
				{
					Start = base.Timestamps.Start,
					End = base.Timestamps.End
				}),
				Assets = ((!HasAssets()) ? null : new Assets
				{
					LargeImageKey = ((base.Assets.LargeImageKey != null) ? (base.Assets.LargeImageKey.Clone() as string) : null),
					LargeImageText = ((base.Assets.LargeImageText != null) ? (base.Assets.LargeImageText.Clone() as string) : null),
					SmallImageKey = ((base.Assets.SmallImageKey != null) ? (base.Assets.SmallImageKey.Clone() as string) : null),
					SmallImageText = ((base.Assets.SmallImageText != null) ? (base.Assets.SmallImageText.Clone() as string) : null)
				}),
				Party = ((!HasParty()) ? null : new Party
				{
					ID = base.Party.ID,
					Size = base.Party.Size,
					Max = base.Party.Max,
					Privacy = base.Party.Privacy
				})
			};
		}

		internal RichPresence Merge(BaseRichPresence presence)
		{
			_state = presence.State;
			_details = presence.Details;
			base.Party = presence.Party;
			base.Timestamps = presence.Timestamps;
			base.Secrets = presence.Secrets;
			if (presence.HasAssets())
			{
				if (!HasAssets())
				{
					base.Assets = presence.Assets;
				}
				else
				{
					base.Assets.Merge(presence.Assets);
				}
			}
			else
			{
				base.Assets = null;
			}
			return this;
		}

		internal override bool Matches(RichPresence other)
		{
			if (!base.Matches(other))
			{
				return false;
			}
			if ((Buttons == null) ^ (other.Buttons == null))
			{
				return false;
			}
			if (Buttons != null)
			{
				if (Buttons.Length != other.Buttons.Length)
				{
					return false;
				}
				for (int i = 0; i < Buttons.Length; i++)
				{
					Button button = Buttons[i];
					Button button2 = other.Buttons[i];
					if (button.Label != button2.Label || button.Url != button2.Url)
					{
						return false;
					}
				}
			}
			return true;
		}

		public static implicit operator bool(RichPresence presesnce)
		{
			return presesnce != null;
		}
	}
}
