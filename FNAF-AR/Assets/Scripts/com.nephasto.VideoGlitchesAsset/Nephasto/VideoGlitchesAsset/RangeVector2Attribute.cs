using System;
using UnityEngine;

namespace Nephasto.VideoGlitchesAsset
{
	[AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
	public sealed class RangeVector2Attribute : PropertyAttribute
	{
		public readonly Vector2 min;

		public readonly Vector2 max;

		public readonly Vector2 reset;

		public RangeVector2Attribute(float minMag, float maxMag)
			: this(minMag, maxMag, minMag)
		{
		}

		public RangeVector2Attribute(float minMag, float maxMag, float resetMag)
		{
			min = new Vector2(minMag, minMag);
			max = new Vector2(maxMag, maxMag);
			reset = new Vector2(resetMag, resetMag);
		}
	}
}
