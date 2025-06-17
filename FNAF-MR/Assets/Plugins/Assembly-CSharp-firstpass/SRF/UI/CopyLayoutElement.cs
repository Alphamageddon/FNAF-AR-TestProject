using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SRF.UI
{
	[RequireComponent(typeof(RectTransform))]
	[ExecuteInEditMode]
	[AddComponentMenu("SRF/UI/Copy Layout Element")]
	public class CopyLayoutElement : UIBehaviour, ILayoutElement
	{
		public bool CopyMinHeight;

		public bool CopyMinWidth;

		public bool CopyPreferredHeight;

		public bool CopyPreferredWidth;

		public RectTransform CopySource;

		public float PaddingMinHeight;

		public float PaddingMinWidth;

		public float PaddingPreferredHeight;

		public float PaddingPreferredWidth;

		public float preferredWidth
		{
			get
			{
				if (!CopyPreferredWidth || CopySource == null || !IsActive())
				{
					return -1f;
				}
				return LayoutUtility.GetPreferredWidth(CopySource) + PaddingPreferredWidth;
			}
		}

		public float preferredHeight
		{
			get
			{
				if (!CopyPreferredHeight || CopySource == null || !IsActive())
				{
					return -1f;
				}
				return LayoutUtility.GetPreferredHeight(CopySource) + PaddingPreferredHeight;
			}
		}

		public float minWidth
		{
			get
			{
				if (!CopyMinWidth || CopySource == null || !IsActive())
				{
					return -1f;
				}
				return LayoutUtility.GetMinWidth(CopySource) + PaddingMinWidth;
			}
		}

		public float minHeight
		{
			get
			{
				if (!CopyMinHeight || CopySource == null || !IsActive())
				{
					return -1f;
				}
				return LayoutUtility.GetMinHeight(CopySource) + PaddingMinHeight;
			}
		}

		public int layoutPriority => 2;

		public float flexibleHeight => -1f;

		public float flexibleWidth => -1f;

		public void CalculateLayoutInputHorizontal()
		{
		}

		public void CalculateLayoutInputVertical()
		{
		}
	}
}
