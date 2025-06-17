using System;
using UnityEngine;

namespace Nephasto.VideoGlitchesAsset
{
	[AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
	public sealed class RangeIntAttribute : PropertyAttribute
	{
		public readonly int min;

		public readonly int max;

		public readonly int reset;

		public RangeIntAttribute(int min, int max)
			: this(min, max, min)
		{
		}

		public RangeIntAttribute(int min, int max, int reset)
		{
			this.min = min;
			this.max = max;
			this.reset = reset;
		}
	}
}
