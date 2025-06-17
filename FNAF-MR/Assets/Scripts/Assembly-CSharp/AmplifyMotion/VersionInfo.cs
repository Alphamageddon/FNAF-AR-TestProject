using System;
using UnityEngine;

namespace AmplifyMotion
{
	[Serializable]
	public class VersionInfo
	{
		public const byte Major = 1;

		public const byte Minor = 9;

		public const byte Release = 0;

		private static string StageSuffix = "_dev001";

		private static string TrialSuffix = "";

		[SerializeField]
		private int m_major;

		[SerializeField]
		private int m_minor;

		[SerializeField]
		private int m_release;

		public int Number => m_major * 100 + m_minor * 10 + m_release;

		public static string StaticToString()
		{
			return $"{(byte)1}.{(byte)9}.{(byte)0}" + StageSuffix + TrialSuffix;
		}

		public override string ToString()
		{
			return $"{m_major}.{m_minor}.{m_release}" + StageSuffix + TrialSuffix;
		}

		private VersionInfo()
		{
			m_major = 1;
			m_minor = 9;
			m_release = 0;
		}

		private VersionInfo(byte major, byte minor, byte release)
		{
			m_major = major;
			m_minor = minor;
			m_release = release;
		}

		public static VersionInfo Current()
		{
			return new VersionInfo(1, 9, 0);
		}

		public static bool Matches(VersionInfo version)
		{
			if (1 == version.m_major && 9 == version.m_minor)
			{
				return version.m_release == 0;
			}
			return false;
		}
	}
}
