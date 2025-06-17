using System;
using UnityEngine;
using UnityEngine.UI;

namespace SRF.UI
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("SRF/UI/Responsive (Enable)")]
	public class ResponsiveResize : ResponsiveBase
	{
		[Serializable]
		public struct Element
		{
			[Serializable]
			public struct SizeDefinition
			{
				[Tooltip("Width to apply when over the threshold width")]
				public float ElementWidth;

				[Tooltip("Threshold over which this width will take effect")]
				public float ThresholdWidth;
			}

			public SizeDefinition[] SizeDefinitions;

			public RectTransform Target;
		}

		public Element[] Elements = new Element[0];

		protected override void Refresh()
		{
			Rect rect = base.RectTransform.rect;
			for (int i = 0; i < Elements.Length; i++)
			{
				Element element = Elements[i];
				if (element.Target == null)
				{
					continue;
				}
				float num = float.MinValue;
				float num2 = -1f;
				for (int j = 0; j < element.SizeDefinitions.Length; j++)
				{
					Element.SizeDefinition sizeDefinition = element.SizeDefinitions[j];
					if (sizeDefinition.ThresholdWidth <= rect.width && sizeDefinition.ThresholdWidth > num)
					{
						num = sizeDefinition.ThresholdWidth;
						num2 = sizeDefinition.ElementWidth;
					}
				}
				if (num2 > 0f)
				{
					element.Target.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2);
					LayoutElement component = element.Target.GetComponent<LayoutElement>();
					if (component != null)
					{
						component.preferredWidth = num2;
					}
				}
			}
		}
	}
}
