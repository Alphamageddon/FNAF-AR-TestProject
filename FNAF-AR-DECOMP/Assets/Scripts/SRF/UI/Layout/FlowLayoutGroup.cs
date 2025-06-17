using UnityEngine;

namespace SRF.UI.Layout
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FlowLayoutGroup : LayoutGroup
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.IList<UnityEngine.RectTransform> _rowList;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _layoutHeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ChildForceExpandHeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ChildForceExpandWidth;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Spacing;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected bool IsCenterAlign { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected bool IsRightAlign { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected bool IsMiddleAlign { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected bool IsLowerAlign { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected bool get_IsCenterAlign()
        {
            var val_5;
            if(this.childAlignment != 7)
            {
                    if(this.childAlignment != 4)
            {
                    return (bool)(this.childAlignment == 1) ? 1 : 0;
            }
            
            }
            
            val_5 = 1;
            return (bool)(this.childAlignment == 1) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected bool get_IsRightAlign()
        {
            var val_5;
            if(this.childAlignment != 8)
            {
                    if(this.childAlignment != 5)
            {
                    return (bool)(this.childAlignment == 2) ? 1 : 0;
            }
            
            }
            
            val_5 = 1;
            return (bool)(this.childAlignment == 2) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected bool get_IsMiddleAlign()
        {
            var val_5;
            if(this.childAlignment != 3)
            {
                    if(this.childAlignment != 5)
            {
                    return (bool)(this.childAlignment == 4) ? 1 : 0;
            }
            
            }
            
            val_5 = 1;
            return (bool)(this.childAlignment == 4) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected bool get_IsLowerAlign()
        {
            var val_5;
            if(this.childAlignment != 6)
            {
                    if(this.childAlignment != 8)
            {
                    return (bool)(this.childAlignment == 7) ? 1 : 0;
            }
            
            }
            
            val_5 = 1;
            return (bool)(this.childAlignment == 7) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void CalculateLayoutInputHorizontal()
        {
            this.CalculateLayoutInputHorizontal();
            float val_6 = (float)this.padding.left;
            val_6 = this.GetGreatestMinimumChildWidth() + val_6;
            val_6 = val_6 + (float)this.padding.right;
            this.SetLayoutInputForAxis(totalMin:  val_6, totalPreferred:  -1f, totalFlexible:  -1f, axis:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SetLayoutHorizontal()
        {
            UnityEngine.Rect val_2 = this.rectTransform.rect;
            float val_3 = this.SetLayout(width:  val_2.m_XMin, axis:  0, layoutInput:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SetLayoutVertical()
        {
            UnityEngine.Rect val_2 = this.rectTransform.rect;
            float val_3 = this.SetLayout(width:  val_2.m_XMin, axis:  1, layoutInput:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void CalculateLayoutInputVertical()
        {
            UnityEngine.Rect val_2 = this.rectTransform.rect;
            this._layoutHeight = this.SetLayout(width:  val_2.m_XMin, axis:  1, layoutInput:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float SetLayout(float width, int axis, bool layoutInput)
        {
            var val_42;
            float val_43;
            float val_44;
            float val_45;
            int val_46;
            int val_47;
            float val_49;
            UnityEngine.Rect val_2 = this.rectTransform.rect;
            UnityEngine.Rect val_4 = this.rectTransform.rect;
            float val_42 = val_4.m_XMin;
            UnityEngine.RectOffset val_10 = this.padding;
            val_42 = val_42 - (float)this.padding.left;
            if(this.IsLowerAlign != false)
            {
                    int val_11 = val_10.bottom;
            }
            
            val_42 = 0;
            float val_13 = val_42 - (float)this.padding.right;
            val_43 = (float)val_10.top;
            val_44 = 0f;
            val_45 = 0f;
            goto label_8;
            label_34:
            val_46 = val_42;
            if(this.IsLowerAlign != false)
            {
                    val_46 = this.rectChildren.Count + val_42;
            }
            
            UnityEngine.RectTransform val_18 = this.rectChildren.Item[val_46];
            val_47 = 0;
            float val_20 = UnityEngine.UI.LayoutUtility.GetPreferredSize(rect:  val_18, axis:  1);
            float val_21 = UnityEngine.Mathf.Min(a:  UnityEngine.UI.LayoutUtility.GetPreferredSize(rect:  val_18, axis:  0), b:  val_13);
            var val_43 = 0;
            val_43 = val_43 + 1;
            val_47 = 0;
            if(this._rowList.Count >= 1)
            {
                    float val_44 = this.Spacing;
                val_49 = val_45 + val_44;
            }
            
            val_44 = val_21 + val_49;
            if(val_44 > val_13)
            {
                    if(layoutInput != true)
            {
                    val_49 = val_49 - this.Spacing;
                val_47 = axis;
                this.LayoutRow(contents:  0, rowWidth:  val_49, rowHeight:  val_44, maxWidth:  val_13, xOffset:  (float)this.padding.left, yOffset:  this.CalculateRowVerticalOffset(groupHeight:  val_2.m_XMin, yOffset:  val_43, currentRowHeight:  val_44), axis:  val_47);
            }
            
                var val_45 = 0;
                val_45 = val_45 + 1;
                val_47 = 3;
                this._rowList.Clear();
                val_49 = 0f;
                val_43 = (val_44 + val_43) + this.Spacing;
            }
            
            var val_46 = 0;
            val_46 = val_46 + 1;
            val_47 = 2;
            val_45 = val_21 + val_49;
            this._rowList.Add(item:  val_4.m_XMin);
            float val_30 = (val_20 > 0f) ? (val_20) : 0f;
            val_42 = 1;
            label_8:
            if(val_42 < this.rectChildren.Count)
            {
                goto label_34;
            }
            
            if(layoutInput != true)
            {
                    this.LayoutRow(contents:  0, rowWidth:  val_45, rowHeight:  val_30, maxWidth:  val_13, xOffset:  (float)this.padding.left, yOffset:  this.CalculateRowVerticalOffset(groupHeight:  val_2.m_XMin, yOffset:  val_43, currentRowHeight:  val_30), axis:  axis);
            }
            
            var val_47 = 0;
            val_47 = val_47 + 1;
            this._rowList.Clear();
            UnityEngine.RectOffset val_38 = this.padding;
            float val_39 = val_30 + val_43;
            if(this.IsLowerAlign != false)
            {
                    int val_40 = val_38.top;
            }
            
            val_39 = val_39 + (float)val_38.bottom;
            if(axis != 1)
            {
                    return val_39;
            }
            
            if(layoutInput == false)
            {
                    return val_39;
            }
            
            this.SetLayoutInputForAxis(totalMin:  val_39, totalPreferred:  val_39, totalFlexible:  -1f, axis:  1);
            return val_39;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float CalculateRowVerticalOffset(float groupHeight, float yOffset, float currentRowHeight)
        {
            float val_4 = yOffset;
            if(this.IsLowerAlign != false)
            {
                    groupHeight = groupHeight - val_4;
                val_4 = groupHeight - currentRowHeight;
                return (float)val_4;
            }
            
            if(this.IsMiddleAlign == false)
            {
                    return (float)val_4;
            }
            
            float val_4 = this._layoutHeight;
            val_4 = val_4 * 0.5f;
            val_4 = (groupHeight * 0.5f) - val_4;
            val_4 = val_4 + val_4;
            return (float)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void LayoutRow(System.Collections.Generic.IList<UnityEngine.RectTransform> contents, float rowWidth, float rowHeight, float maxWidth, float xOffset, float yOffset, int axis)
        {
            float val_24;
            System.Collections.Generic.IList<UnityEngine.RectTransform> val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            float val_30;
            var val_31;
            int val_32;
            var val_33;
            var val_34;
            var val_35;
            float val_36;
            var val_37;
            UnityEngine.RectTransform val_38;
            var val_39;
            float val_22 = xOffset;
            val_24 = rowWidth;
            if(this.ChildForceExpandWidth == true)
            {
                goto label_3;
            }
            
            if(this.IsCenterAlign == false)
            {
                goto label_2;
            }
            
            rowWidth = maxWidth - val_24;
            rowWidth = rowWidth * 0.5f;
            label_46:
            val_22 = rowWidth + val_22;
            label_45:
            if(this.ChildForceExpandWidth == true)
            {
                goto label_3;
            }
            
            val_25 = this._rowList;
            goto label_18;
            label_2:
            if(this.ChildForceExpandWidth == false)
            {
                goto label_5;
            }
            
            label_3:
            val_26 = 0;
            val_27 = 0;
            val_25 = this._rowList;
            goto label_6;
            label_17:
            var val_25 = mem[this._rowList];
            if((mem[this._rowList] + 286) == 0)
            {
                goto label_11;
            }
            
            var val_23 = mem[this._rowList] + 176;
            var val_24 = 0;
            val_23 = val_23 + 8;
            label_10:
            if(((mem[this._rowList] + 176 + 8) + -8) == null)
            {
                goto label_9;
            }
            
            val_24 = val_24 + 1;
            val_23 = val_23 + 16;
            if(val_24 < (mem[this._rowList] + 286))
            {
                goto label_10;
            }
            
            goto label_11;
            label_9:
            val_25 = val_25 + (((mem[this._rowList] + 176 + 8)) << 4);
            val_28 = val_25 + 296;
            label_11:
            val_27 = val_27 + (((UnityEngine.UI.LayoutUtility.GetFlexibleWidth(rect:  mem[this._rowList].Item[0])) > 0f) ? 1 : 0);
            val_26 = 1;
            label_6:
            var val_28 = mem[this._rowList];
            if((mem[this._rowList] + 286) == 0)
            {
                goto label_16;
            }
            
            var val_26 = mem[this._rowList] + 176;
            var val_27 = 0;
            val_26 = val_26 + 8;
            label_15:
            if(((mem[this._rowList] + 176 + 8) + -8) == null)
            {
                goto label_14;
            }
            
            val_27 = val_27 + 1;
            val_26 = val_26 + 16;
            if(val_27 < (mem[this._rowList] + 286))
            {
                goto label_15;
            }
            
            goto label_16;
            label_14:
            val_28 = val_28 + (((mem[this._rowList] + 176 + 8)) << 4);
            val_29 = val_28 + 296;
            label_16:
            if(val_26 < mem[this._rowList].Count)
            {
                goto label_17;
            }
            
            if(val_27 < 1)
            {
                goto label_18;
            }
            
            val_30 = (maxWidth - val_24) / (float)val_27;
            goto label_19;
            label_18:
            val_30 = 0f;
            label_19:
            val_31 = 0;
            goto label_20;
            label_44:
            val_32 = val_31;
            if(this.IsLowerAlign == false)
            {
                goto label_21;
            }
            
            var val_31 = mem[this._rowList];
            if((mem[this._rowList] + 286) == 0)
            {
                goto label_23;
            }
            
            var val_29 = mem[this._rowList] + 176;
            var val_30 = 0;
            val_29 = val_29 + 8;
            label_25:
            if(((mem[this._rowList] + 176 + 8) + -8) == null)
            {
                goto label_24;
            }
            
            val_30 = val_30 + 1;
            val_29 = val_29 + 16;
            if(val_30 < (mem[this._rowList] + 286))
            {
                goto label_25;
            }
            
            label_23:
            val_33 = 0;
            goto label_26;
            label_24:
            val_31 = val_31 + (((mem[this._rowList] + 176 + 8)) << 4);
            val_34 = val_31 + 296;
            label_26:
            val_32 = mem[this._rowList].Count + val_31;
            label_21:
            var val_34 = mem[this._rowList];
            if((mem[this._rowList] + 286) == 0)
            {
                goto label_28;
            }
            
            var val_32 = mem[this._rowList] + 176;
            var val_33 = 0;
            val_32 = val_32 + 8;
            label_30:
            if(((mem[this._rowList] + 176 + 8) + -8) == null)
            {
                goto label_29;
            }
            
            val_33 = val_33 + 1;
            val_32 = val_32 + 16;
            if(val_33 < (mem[this._rowList] + 286))
            {
                goto label_30;
            }
            
            label_28:
            val_33 = 0;
            goto label_31;
            label_29:
            val_34 = val_34 + (((mem[this._rowList] + 176 + 8)) << 4);
            val_35 = val_34 + 296;
            label_31:
            T val_9 = mem[this._rowList].Item[val_32];
            float val_10 = UnityEngine.UI.LayoutUtility.GetPreferredSize(rect:  val_9, axis:  0);
            float val_15 = (this.ChildForceExpandHeight == true) ? rowHeight : UnityEngine.UI.LayoutUtility.GetPreferredSize(rect:  val_9, axis:  1);
            float val_16 = UnityEngine.Mathf.Min(a:  ((UnityEngine.UI.LayoutUtility.GetFlexibleWidth(rect:  val_9)) > 0f) ? (val_30 + val_10) : (val_10), b:  maxWidth);
            if(this.IsMiddleAlign == false)
            {
                goto label_34;
            }
            
            val_36 = (rowHeight - val_15) * 0.5f;
            goto label_35;
            label_34:
            if(this.IsLowerAlign == false)
            {
                goto label_36;
            }
            
            val_36 = rowHeight - val_15;
            label_35:
            val_36 = val_36 + yOffset;
            label_36:
            if(axis != 0)
            {
                    val_37 = 1;
                val_38 = val_9;
            }
            else
            {
                    val_38 = val_9;
                val_37 = 0;
            }
            
            this.SetChildAlongAxis(rect:  val_38, axis:  0, pos:  val_22, size:  val_16);
            float val_35 = this.Spacing;
            val_31 = 1;
            val_35 = val_16 + val_35;
            val_22 = val_22 + val_35;
            label_20:
            var val_38 = mem[this._rowList];
            if((mem[this._rowList] + 286) == 0)
            {
                goto label_43;
            }
            
            var val_36 = mem[this._rowList] + 176;
            var val_37 = 0;
            val_36 = val_36 + 8;
            label_42:
            if(((mem[this._rowList] + 176 + 8) + -8) == null)
            {
                goto label_41;
            }
            
            val_37 = val_37 + 1;
            val_36 = val_36 + 16;
            if(val_37 < (mem[this._rowList] + 286))
            {
                goto label_42;
            }
            
            goto label_43;
            label_41:
            val_38 = val_38 + (((mem[this._rowList] + 176 + 8)) << 4);
            val_39 = val_38 + 296;
            label_43:
            if(val_31 < mem[this._rowList].Count)
            {
                goto label_44;
            }
            
            return;
            label_5:
            if(this.IsRightAlign == false)
            {
                goto label_45;
            }
            
            rowWidth = maxWidth - val_24;
            goto label_46;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GetGreatestMinimumChildWidth()
        {
            var val_7;
            float val_8;
            val_7 = 0;
            val_8 = 0f;
            goto label_1;
            label_6:
            val_8 = UnityEngine.Mathf.Max(a:  UnityEngine.UI.LayoutUtility.GetMinWidth(rect:  this.rectChildren.Item[0]), b:  val_8);
            val_7 = 1;
            label_1:
            if(val_7 < this.rectChildren.Count)
            {
                goto label_6;
            }
            
            return (float)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FlowLayoutGroup()
        {
            this._rowList = new System.Collections.Generic.List<UnityEngine.RectTransform>();
        }
    
    }

}
