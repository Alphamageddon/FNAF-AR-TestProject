using UnityEngine;
using UnityEngine.UI;

namespace SRF.UI
{
	[RequireComponent(typeof(RectTransform))]
	[ExecuteInEditMode]
	[AddComponentMenu("SRF/UI/Copy Preferred Size")]
	public class CopyPreferredSize : LayoutElement
	{
		public RectTransform CopySource;

		public float PaddingHeight;

		public float PaddingWidth;

		public override float preferredWidth
		{
			get
			{
				if (CopySource == null || !IsActive())
				{
					return -1f;
				}
				return LayoutUtility.GetPreferredWidth(CopySource) + PaddingWidth;
			}
		}

		public override float preferredHeight
		{
			get
			{
				if (CopySource == null || !IsActive())
				{
					return -1f;
				}
				return LayoutUtility.GetPreferredHeight(CopySource) + PaddingHeight;
			}
		}

		public override int layoutPriority => 2;
	}
}
