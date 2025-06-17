using System;
using System.Text;
using DiscordRPC.Exceptions;
using Newtonsoft.Json;

namespace DiscordRPC
{
	[Serializable]
	public class Assets
	{
		private string _largeimagekey;

		private bool _islargeimagekeyexternal;

		private string _largeimagetext;

		private string _smallimagekey;

		private bool _issmallimagekeyexternal;

		private string _smallimagetext;

		private ulong? _largeimageID;

		private ulong? _smallimageID;

		[JsonProperty("large_image", NullValueHandling = NullValueHandling.Ignore)]
		public string LargeImageKey
		{
			get
			{
				return _largeimagekey;
			}
			set
			{
				if (!BaseRichPresence.ValidateString(value, out _largeimagekey, 256, Encoding.UTF8))
				{
					throw new StringOutOfRangeException(256);
				}
				_islargeimagekeyexternal = _largeimagekey?.StartsWith("mp:external/") ?? false;
				_largeimageID = null;
			}
		}

		[JsonIgnore]
		public bool IsLargeImageKeyExternal => _islargeimagekeyexternal;

		[JsonProperty("large_text", NullValueHandling = NullValueHandling.Ignore)]
		public string LargeImageText
		{
			get
			{
				return _largeimagetext;
			}
			set
			{
				if (!BaseRichPresence.ValidateString(value, out _largeimagetext, 128, Encoding.UTF8))
				{
					throw new StringOutOfRangeException(128);
				}
			}
		}

		[JsonProperty("small_image", NullValueHandling = NullValueHandling.Ignore)]
		public string SmallImageKey
		{
			get
			{
				return _smallimagekey;
			}
			set
			{
				if (!BaseRichPresence.ValidateString(value, out _smallimagekey, 256, Encoding.UTF8))
				{
					throw new StringOutOfRangeException(256);
				}
				_issmallimagekeyexternal = _smallimagekey?.StartsWith("mp:external/") ?? false;
				_smallimageID = null;
			}
		}

		[JsonIgnore]
		public bool IsSmallImageKeyExternal => _issmallimagekeyexternal;

		[JsonProperty("small_text", NullValueHandling = NullValueHandling.Ignore)]
		public string SmallImageText
		{
			get
			{
				return _smallimagetext;
			}
			set
			{
				if (!BaseRichPresence.ValidateString(value, out _smallimagetext, 128, Encoding.UTF8))
				{
					throw new StringOutOfRangeException(128);
				}
			}
		}

		[JsonIgnore]
		public ulong? LargeImageID => _largeimageID;

		[JsonIgnore]
		public ulong? SmallImageID => _smallimageID;

		internal void Merge(Assets other)
		{
			_smallimagetext = other._smallimagetext;
			_largeimagetext = other._largeimagetext;
			if (ulong.TryParse(other._largeimagekey, out var result))
			{
				_largeimageID = result;
			}
			else
			{
				_largeimagekey = other._largeimagekey;
				_largeimageID = null;
			}
			if (ulong.TryParse(other._smallimagekey, out var result2))
			{
				_smallimageID = result2;
				return;
			}
			_smallimagekey = other._smallimagekey;
			_smallimageID = null;
		}
	}
}
