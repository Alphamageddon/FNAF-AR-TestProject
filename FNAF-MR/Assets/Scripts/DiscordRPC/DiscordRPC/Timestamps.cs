using System;
using Newtonsoft.Json;

namespace DiscordRPC
{
	[Serializable]
	public class Timestamps
	{
		public static Timestamps Now => new Timestamps(DateTime.UtcNow);

		[JsonIgnore]
		public DateTime? Start { get; set; }

		[JsonIgnore]
		public DateTime? End { get; set; }

		[JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)]
		public ulong? StartUnixMilliseconds
		{
			get
			{
				if (!Start.HasValue)
				{
					return null;
				}
				return ToUnixMilliseconds(Start.Value);
			}
			set
			{
				Start = (value.HasValue ? new DateTime?(FromUnixMilliseconds(value.Value)) : ((DateTime?)null));
			}
		}

		[JsonProperty("end", NullValueHandling = NullValueHandling.Ignore)]
		public ulong? EndUnixMilliseconds
		{
			get
			{
				if (!End.HasValue)
				{
					return null;
				}
				return ToUnixMilliseconds(End.Value);
			}
			set
			{
				End = (value.HasValue ? new DateTime?(FromUnixMilliseconds(value.Value)) : ((DateTime?)null));
			}
		}

		public static Timestamps FromTimeSpan(double seconds)
		{
			return FromTimeSpan(TimeSpan.FromSeconds(seconds));
		}

		public static Timestamps FromTimeSpan(TimeSpan timespan)
		{
			return new Timestamps
			{
				Start = DateTime.UtcNow,
				End = DateTime.UtcNow + timespan
			};
		}

		public Timestamps()
		{
			Start = null;
			End = null;
		}

		public Timestamps(DateTime start)
		{
			Start = start;
			End = null;
		}

		public Timestamps(DateTime start, DateTime end)
		{
			Start = start;
			End = end;
		}

		public static DateTime FromUnixMilliseconds(ulong unixTime)
		{
			return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(Convert.ToDouble(unixTime));
		}

		public static ulong ToUnixMilliseconds(DateTime date)
		{
			DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			return Convert.ToUInt64((date - dateTime).TotalMilliseconds);
		}
	}
}
