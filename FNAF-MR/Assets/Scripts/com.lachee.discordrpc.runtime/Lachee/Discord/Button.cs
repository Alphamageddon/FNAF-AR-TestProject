using System;
using UnityEngine;

namespace Lachee.Discord
{
	[Serializable]
	public sealed class Button
	{
		[Tooltip("The label on the button to be displayed")]
		public string label;

		[Tooltip("The URL on the button to be displayed")]
		public string url;

		public bool IsEmpty()
		{
			if (string.IsNullOrEmpty(label))
			{
				return string.IsNullOrEmpty(url);
			}
			return false;
		}
	}
}
