using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SRF.UI.Layout
{
	[AddComponentMenu("SRF/UI/Layout/Flow Layout Group")]
	public class FlowLayoutGroup : LayoutGroup
	{
		private readonly IList<RectTransform> _rowList = new List<RectTransform>();

		private float _layoutHeight;

		public bool ChildForceExpandHeight;

		public bool ChildForceExpandWidth;

		public float Spacing;

		protected bool IsCenterAlign
		{
			get
			{
				if (base.childAlignment != TextAnchor.LowerCenter && base.childAlignment != TextAnchor.MiddleCenter)
				{
					return base.childAlignment == TextAnchor.UpperCenter;
				}
				return true;
			}
		}

		protected bool IsRightAlign
		{
			get
			{
				if (base.childAlignment != TextAnchor.LowerRight && base.childAlignment != TextAnchor.MiddleRight)
				{
					return base.childAlignment == TextAnchor.UpperRight;
				}
				return true;
			}
		}

		protected bool IsMiddleAlign
		{
			get
			{
				if (base.childAlignment != TextAnchor.MiddleLeft && base.childAlignment != TextAnchor.MiddleRight)
				{
					return base.childAlignment == TextAnchor.MiddleCenter;
				}
				return true;
			}
		}

		protected bool IsLowerAlign
		{
			get
			{
				if (base.childAlignment != TextAnchor.LowerLeft && base.childAlignment != TextAnchor.LowerRight)
				{
					return base.childAlignment == TextAnchor.LowerCenter;
				}
				return true;
			}
		}

		public override void CalculateLayoutInputHorizontal()
		{
			base.CalculateLayoutInputHorizontal();
			float totalMin = GetGreatestMinimumChildWidth() + (float)base.padding.left + (float)base.padding.right;
			SetLayoutInputForAxis(totalMin, -1f, -1f, 0);
		}

		public override void SetLayoutHorizontal()
		{
			SetLayout(base.rectTransform.rect.width, 0, layoutInput: false);
		}

		public override void SetLayoutVertical()
		{
			SetLayout(base.rectTransform.rect.width, 1, layoutInput: false);
		}

		public override void CalculateLayoutInputVertical()
		{
			_layoutHeight = SetLayout(base.rectTransform.rect.width, 1, layoutInput: true);
		}

		public float SetLayout(float width, int axis, bool layoutInput)
		{
			float height = base.rectTransform.rect.height;
			float num = base.rectTransform.rect.width - (float)base.padding.left - (float)base.padding.right;
			float num2 = (IsLowerAlign ? ((float)base.padding.bottom) : ((float)base.padding.top));
			float num3 = 0f;
			float num4 = 0f;
			for (int i = 0; i < base.rectChildren.Count; i++)
			{
				int index = (IsLowerAlign ? (base.rectChildren.Count - 1 - i) : i);
				RectTransform rectTransform = base.rectChildren[index];
				float preferredSize = LayoutUtility.GetPreferredSize(rectTransform, 0);
				float preferredSize2 = LayoutUtility.GetPreferredSize(rectTransform, 1);
				preferredSize = Mathf.Min(preferredSize, num);
				if (_rowList.Count > 0)
				{
					num3 += Spacing;
				}
				if (num3 + preferredSize > num)
				{
					num3 -= Spacing;
					if (!layoutInput)
					{
						float yOffset = CalculateRowVerticalOffset(height, num2, num4);
						LayoutRow(_rowList, num3, num4, num, base.padding.left, yOffset, axis);
					}
					_rowList.Clear();
					num2 += num4;
					num2 += Spacing;
					num4 = 0f;
					num3 = 0f;
				}
				num3 += preferredSize;
				_rowList.Add(rectTransform);
				if (preferredSize2 > num4)
				{
					num4 = preferredSize2;
				}
			}
			if (!layoutInput)
			{
				float yOffset2 = CalculateRowVerticalOffset(height, num2, num4);
				LayoutRow(_rowList, num3, num4, num, base.padding.left, yOffset2, axis);
			}
			_rowList.Clear();
			num2 += num4;
			num2 += (float)(IsLowerAlign ? base.padding.top : base.padding.bottom);
			if (layoutInput && axis == 1)
			{
				SetLayoutInputForAxis(num2, num2, -1f, axis);
			}
			return num2;
		}

		private float CalculateRowVerticalOffset(float groupHeight, float yOffset, float currentRowHeight)
		{
			if (IsLowerAlign)
			{
				return groupHeight - yOffset - currentRowHeight;
			}
			if (IsMiddleAlign)
			{
				return groupHeight * 0.5f - _layoutHeight * 0.5f + yOffset;
			}
			return yOffset;
		}

		protected void LayoutRow(IList<RectTransform> contents, float rowWidth, float rowHeight, float maxWidth, float xOffset, float yOffset, int axis)
		{
			float num = xOffset;
			if (!ChildForceExpandWidth && IsCenterAlign)
			{
				num += (maxWidth - rowWidth) * 0.5f;
			}
			else if (!ChildForceExpandWidth && IsRightAlign)
			{
				num += maxWidth - rowWidth;
			}
			float num2 = 0f;
			if (ChildForceExpandWidth)
			{
				int num3 = 0;
				for (int i = 0; i < _rowList.Count; i++)
				{
					if (LayoutUtility.GetFlexibleWidth(_rowList[i]) > 0f)
					{
						num3++;
					}
				}
				if (num3 > 0)
				{
					num2 = (maxWidth - rowWidth) / (float)num3;
				}
			}
			for (int j = 0; j < _rowList.Count; j++)
			{
				int index = (IsLowerAlign ? (_rowList.Count - 1 - j) : j);
				RectTransform rect = _rowList[index];
				float num4 = LayoutUtility.GetPreferredSize(rect, 0);
				if (LayoutUtility.GetFlexibleWidth(rect) > 0f)
				{
					num4 += num2;
				}
				float num5 = LayoutUtility.GetPreferredSize(rect, 1);
				if (ChildForceExpandHeight)
				{
					num5 = rowHeight;
				}
				num4 = Mathf.Min(num4, maxWidth);
				float num6 = yOffset;
				if (IsMiddleAlign)
				{
					num6 += (rowHeight - num5) * 0.5f;
				}
				else if (IsLowerAlign)
				{
					num6 += rowHeight - num5;
				}
				if (axis == 0)
				{
					SetChildAlongAxis(rect, 0, num, num4);
				}
				else
				{
					SetChildAlongAxis(rect, 1, num6, num5);
				}
				num += num4 + Spacing;
			}
		}

		public float GetGreatestMinimumChildWidth()
		{
			float num = 0f;
			for (int i = 0; i < base.rectChildren.Count; i++)
			{
				num = Mathf.Max(LayoutUtility.GetMinWidth(base.rectChildren[i]), num);
			}
			return num;
		}
	}
}
