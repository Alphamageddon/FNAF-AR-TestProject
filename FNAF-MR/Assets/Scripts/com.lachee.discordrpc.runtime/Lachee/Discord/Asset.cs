using System;
using Lachee.Discord.Attributes;
using UnityEngine;

namespace Lachee.Discord
{
	[Serializable]
	public sealed class Asset
	{
		[CharacterLimit(256, enforce = true)]
		[Tooltip("The key or URL of the image to be displayed in the large square.")]
		public string image;

		[CharacterLimit(128, enforce = true)]
		[Tooltip("The tooltip of the image.")]
		public string tooltip;

		[Tooltip("Snowflake ID of the image.")]
		public ulong snowflake;

		public bool IsEmpty()
		{
			if (string.IsNullOrEmpty(image))
			{
				return string.IsNullOrEmpty(tooltip);
			}
			return false;
		}
	}
}
