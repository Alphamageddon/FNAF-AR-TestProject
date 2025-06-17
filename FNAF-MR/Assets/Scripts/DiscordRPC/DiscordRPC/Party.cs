using System;
using DiscordRPC.Helper;
using Newtonsoft.Json;

namespace DiscordRPC
{
	[Serializable]
	public class Party
	{
		public enum PrivacySetting
		{
			Private = 0,
			Public = 1
		}

		private string _partyid;

		[JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
		public string ID
		{
			get
			{
				return _partyid;
			}
			set
			{
				_partyid = value.GetNullOrString();
			}
		}

		[JsonIgnore]
		public int Size { get; set; }

		[JsonIgnore]
		public int Max { get; set; }

		[JsonProperty("privacy", NullValueHandling = NullValueHandling.Include, DefaultValueHandling = DefaultValueHandling.Include)]
		public PrivacySetting Privacy { get; set; }

		[JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
		private int[] _size
		{
			get
			{
				int num = Math.Max(1, Size);
				return new int[2]
				{
					num,
					Math.Max(num, Max)
				};
			}
			set
			{
				if (value.Length != 2)
				{
					Size = 0;
					Max = 0;
				}
				else
				{
					Size = value[0];
					Max = value[1];
				}
			}
		}
	}
}
