using System;
using System.Text;
using DiscordRPC.Exceptions;
using DiscordRPC.Helper;
using Newtonsoft.Json;

namespace DiscordRPC
{
	[Serializable]
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class BaseRichPresence
	{
		protected internal string _state;

		protected internal string _details;

		[JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
		public string State
		{
			get
			{
				return _state;
			}
			set
			{
				if (!ValidateString(value, out _state, 128, Encoding.UTF8))
				{
					throw new StringOutOfRangeException("State", 0, 128);
				}
			}
		}

		[JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
		public string Details
		{
			get
			{
				return _details;
			}
			set
			{
				if (!ValidateString(value, out _details, 128, Encoding.UTF8))
				{
					throw new StringOutOfRangeException(128);
				}
			}
		}

		[JsonProperty("timestamps", NullValueHandling = NullValueHandling.Ignore)]
		public Timestamps Timestamps { get; set; }

		[JsonProperty("assets", NullValueHandling = NullValueHandling.Ignore)]
		public Assets Assets { get; set; }

		[JsonProperty("party", NullValueHandling = NullValueHandling.Ignore)]
		public Party Party { get; set; }

		[JsonProperty("secrets", NullValueHandling = NullValueHandling.Ignore)]
		public Secrets Secrets { get; set; }

		[JsonProperty("instance", NullValueHandling = NullValueHandling.Ignore)]
		[Obsolete("This was going to be used, but was replaced by JoinSecret instead")]
		private bool Instance { get; set; }

		public bool HasTimestamps()
		{
			if (Timestamps != null)
			{
				if (!Timestamps.Start.HasValue)
				{
					return Timestamps.End.HasValue;
				}
				return true;
			}
			return false;
		}

		public bool HasAssets()
		{
			return Assets != null;
		}

		public bool HasParty()
		{
			if (Party != null)
			{
				return Party.ID != null;
			}
			return false;
		}

		public bool HasSecrets()
		{
			if (Secrets != null)
			{
				if (Secrets.JoinSecret == null)
				{
					return Secrets.SpectateSecret != null;
				}
				return true;
			}
			return false;
		}

		internal static bool ValidateString(string str, out string result, int bytes, Encoding encoding)
		{
			result = str;
			if (str == null)
			{
				return true;
			}
			string str2 = str.Trim();
			if (!str2.WithinLength(bytes, encoding))
			{
				return false;
			}
			result = str2.GetNullOrString();
			return true;
		}

		public static implicit operator bool(BaseRichPresence presesnce)
		{
			return presesnce != null;
		}

		internal virtual bool Matches(RichPresence other)
		{
			if (other == null)
			{
				return false;
			}
			if (State != other.State || Details != other.Details)
			{
				return false;
			}
			if (Timestamps != null)
			{
				if (other.Timestamps == null || other.Timestamps.StartUnixMilliseconds != Timestamps.StartUnixMilliseconds || other.Timestamps.EndUnixMilliseconds != Timestamps.EndUnixMilliseconds)
				{
					return false;
				}
			}
			else if (other.Timestamps != null)
			{
				return false;
			}
			if (Secrets != null)
			{
				if (other.Secrets == null || other.Secrets.JoinSecret != Secrets.JoinSecret || other.Secrets.MatchSecret != Secrets.MatchSecret || other.Secrets.SpectateSecret != Secrets.SpectateSecret)
				{
					return false;
				}
			}
			else if (other.Secrets != null)
			{
				return false;
			}
			if (Party != null)
			{
				if (other.Party == null || other.Party.ID != Party.ID || other.Party.Max != Party.Max || other.Party.Size != Party.Size || other.Party.Privacy != Party.Privacy)
				{
					return false;
				}
			}
			else if (other.Party != null)
			{
				return false;
			}
			if (Assets != null)
			{
				if (other.Assets == null || other.Assets.LargeImageKey != Assets.LargeImageKey || other.Assets.LargeImageText != Assets.LargeImageText || other.Assets.SmallImageKey != Assets.SmallImageKey || other.Assets.SmallImageText != Assets.SmallImageText)
				{
					return false;
				}
			}
			else if (other.Assets != null)
			{
				return false;
			}
			return Instance == other.Instance;
		}

		public RichPresence ToRichPresence()
		{
			RichPresence richPresence = new RichPresence();
			richPresence.State = State;
			richPresence.Details = Details;
			richPresence.Party = ((!HasParty()) ? Party : null);
			richPresence.Secrets = ((!HasSecrets()) ? Secrets : null);
			if (HasAssets())
			{
				richPresence.Assets = new Assets
				{
					SmallImageKey = Assets.SmallImageKey,
					SmallImageText = Assets.SmallImageText,
					LargeImageKey = Assets.LargeImageKey,
					LargeImageText = Assets.LargeImageText
				};
			}
			if (HasTimestamps())
			{
				richPresence.Timestamps = new Timestamps();
				if (Timestamps.Start.HasValue)
				{
					richPresence.Timestamps.Start = Timestamps.Start;
				}
				if (Timestamps.End.HasValue)
				{
					richPresence.Timestamps.End = Timestamps.End;
				}
			}
			return richPresence;
		}
	}
}
