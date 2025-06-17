using System;
using System.Text;
using DiscordRPC.Exceptions;
using Newtonsoft.Json;

namespace DiscordRPC
{
	public class Button
	{
		private string _label;

		private string _url;

		[JsonProperty("label")]
		public string Label
		{
			get
			{
				return _label;
			}
			set
			{
				if (!BaseRichPresence.ValidateString(value, out _label, 32, Encoding.UTF8))
				{
					throw new StringOutOfRangeException(32);
				}
			}
		}

		[JsonProperty("url")]
		public string Url
		{
			get
			{
				return _url;
			}
			set
			{
				if (!BaseRichPresence.ValidateString(value, out _url, 512, Encoding.UTF8))
				{
					throw new StringOutOfRangeException(512);
				}
				if (!Uri.TryCreate(_url, UriKind.Absolute, out var _))
				{
					throw new ArgumentException("Url must be a valid URI");
				}
			}
		}
	}
}
