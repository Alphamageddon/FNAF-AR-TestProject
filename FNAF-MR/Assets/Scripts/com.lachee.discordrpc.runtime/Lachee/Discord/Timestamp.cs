using System;
using UnityEngine;

namespace Lachee.Discord
{
	[Serializable]
	public sealed class Timestamp
	{
		public static readonly Timestamp Invalid = new Timestamp(0L);

		[Tooltip("Unix Epoch Timestamp")]
		public long timestamp;

		public Timestamp()
			: this(DateTime.UtcNow)
		{
		}

		public Timestamp(DateTime time)
			: this(ToUnixMilliseconds(DateTime.UtcNow))
		{
		}

		public Timestamp(long timestamp)
		{
			this.timestamp = timestamp;
		}

		public Timestamp(float time)
		{
			TimeSpan timeSpan = TimeSpan.FromSeconds(time - Time.realtimeSinceStartup);
			timestamp = ToUnixMilliseconds(DateTime.UtcNow + timeSpan);
		}

		public DateTime GetDateTime()
		{
			return FromUnixMilliseconds(timestamp);
		}

		public float GetTime()
		{
			TimeSpan timeSpan = GetDateTime() - DateTime.UtcNow;
			return Time.realtimeSinceStartup + (float)timeSpan.TotalSeconds;
		}

		public bool IsValid()
		{
			return timestamp > 0;
		}

		public Timestamp AddSeconds(int seconds)
		{
			timestamp += seconds;
			return this;
		}

		public Timestamp AddMinutes(int minutes)
		{
			return AddSeconds(minutes * 60);
		}

		public Timestamp AddMinutes(float minutes)
		{
			int num = Mathf.FloorToInt(minutes);
			int seconds = Mathf.RoundToInt((minutes - (float)num) * 60f);
			return AddMinutes(num).AddSeconds(seconds);
		}

		public Timestamp AddHours(int hours)
		{
			return AddMinutes(hours * 60);
		}

		public Timestamp AddHours(float hours)
		{
			int num = Mathf.FloorToInt(hours);
			float minutes = (hours - (float)num) * 60f;
			return AddHours(num).AddMinutes(minutes);
		}

		public static implicit operator long(Timestamp stamp)
		{
			return stamp.timestamp;
		}

		public static implicit operator float(Timestamp stamp)
		{
			return stamp.GetTime();
		}

		public static implicit operator DateTime(Timestamp stamp)
		{
			return stamp.GetDateTime();
		}

		public static implicit operator Timestamp(long time)
		{
			return new Timestamp(time);
		}

		public static implicit operator Timestamp(DateTime time)
		{
			return new Timestamp(time);
		}

		public static implicit operator Timestamp(float time)
		{
			return new Timestamp(time);
		}

		public static DateTime FromUnixMilliseconds(long unixTime)
		{
			return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(Convert.ToDouble(unixTime));
		}

		public static long ToUnixMilliseconds(DateTime date)
		{
			DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			return Convert.ToInt64((date - dateTime).TotalMilliseconds);
		}
	}
}
