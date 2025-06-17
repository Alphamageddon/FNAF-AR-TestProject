using System;
using UnityEngine;

namespace SRF.UI
{
	[Serializable]
	public class Style
	{
		public Color ActiveColor = Color.white;

		public Color DisabledColor = Color.white;

		public Color HoverColor = Color.white;

		public Sprite Image;

		public Color NormalColor = Color.white;

		public Style Copy()
		{
			Style style = new Style();
			style.CopyFrom(this);
			return style;
		}

		public void CopyFrom(Style style)
		{
			Image = style.Image;
			NormalColor = style.NormalColor;
			HoverColor = style.HoverColor;
			ActiveColor = style.ActiveColor;
			DisabledColor = style.DisabledColor;
		}
	}
}
