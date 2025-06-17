using System;
using UnityEngine;

namespace SRF.UI
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("SRF/UI/Responsive (Enable)")]
	public class ResponsiveEnable : ResponsiveBase
	{
		public enum Modes
		{
			EnableAbove = 0,
			EnableBelow = 1
		}

		[Serializable]
		public struct Entry
		{
			public Behaviour[] Components;

			public GameObject[] GameObjects;

			public Modes Mode;

			public float ThresholdHeight;

			public float ThresholdWidth;
		}

		public Entry[] Entries = new Entry[0];

		protected override void Refresh()
		{
			Rect rect = base.RectTransform.rect;
			for (int i = 0; i < Entries.Length; i++)
			{
				Entry entry = Entries[i];
				bool flag = true;
				switch (entry.Mode)
				{
				case Modes.EnableAbove:
					if (entry.ThresholdHeight > 0f)
					{
						flag = rect.height >= entry.ThresholdHeight && flag;
					}
					if (entry.ThresholdWidth > 0f)
					{
						flag = rect.width >= entry.ThresholdWidth && flag;
					}
					break;
				case Modes.EnableBelow:
					if (entry.ThresholdHeight > 0f)
					{
						flag = rect.height <= entry.ThresholdHeight && flag;
					}
					if (entry.ThresholdWidth > 0f)
					{
						flag = rect.width <= entry.ThresholdWidth && flag;
					}
					break;
				default:
					throw new IndexOutOfRangeException();
				}
				if (entry.GameObjects != null)
				{
					for (int j = 0; j < entry.GameObjects.Length; j++)
					{
						GameObject gameObject = entry.GameObjects[j];
						if (gameObject != null)
						{
							gameObject.SetActive(flag);
						}
					}
				}
				if (entry.Components == null)
				{
					continue;
				}
				for (int k = 0; k < entry.Components.Length; k++)
				{
					Behaviour behaviour = entry.Components[k];
					if (behaviour != null)
					{
						behaviour.enabled = flag;
					}
				}
			}
		}
	}
}
