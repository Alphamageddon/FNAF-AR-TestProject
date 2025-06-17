using System;
using System.Collections.Generic;
using UnityEngine;

namespace Nephasto.VideoGlitchesAsset
{
	[AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
	public sealed class EnumAttribute : PropertyAttribute
	{
		public List<string> enumNames = new List<string>();

		private Type type;

		public EnumAttribute(Type enumType)
		{
			type = enumType;
			enumNames.AddRange(Enum.GetNames(type));
		}
	}
}
