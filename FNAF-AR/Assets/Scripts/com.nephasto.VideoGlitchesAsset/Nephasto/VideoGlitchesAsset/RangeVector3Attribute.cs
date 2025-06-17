using System;
using UnityEngine;

namespace Nephasto.VideoGlitchesAsset
{
	[AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
	public sealed class RangeVector3Attribute : PropertyAttribute
	{
		public readonly Vector3 min;

		public readonly Vector3 max;

		public readonly Vector3 reset;

		public RangeVector3Attribute(float minMag, float maxMag)
			: this(minMag, maxMag, minMag)
		{
		}

		public RangeVector3Attribute(float minMag, float maxMag, float resetMag)
		{
			min = new Vector3(minMag, minMag, minMag);
			max = new Vector3(maxMag, maxMag, maxMag);
			reset = new Vector3(resetMag, resetMag, resetMag);
		}
	}
}
