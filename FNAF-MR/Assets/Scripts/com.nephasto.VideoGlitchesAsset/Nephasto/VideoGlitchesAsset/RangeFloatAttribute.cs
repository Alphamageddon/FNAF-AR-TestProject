using System;
using UnityEngine;

namespace Nephasto.VideoGlitchesAsset
{
	[AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
	public sealed class RangeFloatAttribute : PropertyAttribute
	{
		public readonly float min;

		public readonly float max;

		public readonly float reset;

		public RangeFloatAttribute(float min, float max)
			: this(min, max, min)
		{
		}

		public RangeFloatAttribute(float min, float max, float reset)
		{
			this.min = min;
			this.max = max;
			this.reset = reset;
		}
	}
}
