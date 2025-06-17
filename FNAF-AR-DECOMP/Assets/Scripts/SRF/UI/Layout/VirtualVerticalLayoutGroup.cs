using UnityEngine;

namespace SRF.UI.Layout
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class VirtualVerticalLayoutGroup : LayoutGroup, IPointerClickHandler, IEventSystemHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly SRF.SRList<object> _itemList;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly SRF.SRList<int> _visibleItemList;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isDirty;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRF.SRList<SRF.UI.Layout.VirtualVerticalLayoutGroup.Row> _rowCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.ScrollRect _scrollRect;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _selectedIndex;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private object _selectedItem;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRF.UI.Layout.VirtualVerticalLayoutGroup.SelectedItemChangedEvent _selectedItemChanged;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _visibleItemCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRF.SRList<SRF.UI.Layout.VirtualVerticalLayoutGroup.Row> _visibleRows;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.UI.StyleSheet AltRowStyleSheet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool EnableSelection;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.RectTransform ItemPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int RowPadding;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.UI.StyleSheet RowStyleSheet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.UI.StyleSheet SelectedRowStyleSheet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Spacing;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool StickToBottom;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _itemHeight;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.UI.Layout.VirtualVerticalLayoutGroup.SelectedItemChangedEvent SelectedItemChanged { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public object SelectedItem { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override float minHeight { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.ScrollRect ScrollRect { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool AlignBottom { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool AlignTop { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float ItemHeight { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.UI.Layout.VirtualVerticalLayoutGroup.SelectedItemChangedEvent get_SelectedItemChanged()
        {
            return (SelectedItemChangedEvent)this._selectedItemChanged;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_SelectedItemChanged(SRF.UI.Layout.VirtualVerticalLayoutGroup.SelectedItemChangedEvent value)
        {
            this._selectedItemChanged = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public object get_SelectedItem()
        {
            return (object)this._selectedItem;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_SelectedItem(object value)
        {
            if(this._selectedItem == value)
            {
                    return;
            }
            
            if(this.EnableSelection == false)
            {
                    return;
            }
            
            if(value == null)
            {
                goto label_3;
            }
            
            int val_1 = this._itemList.IndexOf(item:  value);
            if((val_1 & 2147483648) != 0)
            {
                goto label_5;
            }
            
            if(this._selectedItem == null)
            {
                goto label_11;
            }
            
            label_10:
            this.InvalidateItem(itemIndex:  this._selectedIndex);
            label_11:
            this._selectedItem = value;
            this._selectedIndex = val_1;
            if(value != null)
            {
                    this.InvalidateItem(itemIndex:  val_1);
            }
            
            this.SetDirty();
            if(this.IsActive() != false)
            {
                    this._isDirty = true;
            }
            
            if(this._selectedItemChanged == null)
            {
                    return;
            }
            
            this._selectedItemChanged.Invoke(arg0:  this._selectedItem);
            return;
            label_3:
            if(this._selectedItem != null)
            {
                goto label_10;
            }
            
            goto label_11;
            label_5:
            System.InvalidOperationException val_3 = new System.InvalidOperationException(message:  "Cannot select item not present in layout");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override float get_minHeight()
        {
            float val_9 = (float)this._itemList.Count;
            val_9 = this.ItemHeight * val_9;
            val_9 = val_9 + (float)this.padding.top;
            val_9 = val_9 + (float)this.padding.bottom;
            val_9 = val_9 + (this.Spacing * (float)this._itemList.Count);
            return (float)val_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
        {
            object val_12;
            if(this.EnableSelection == false)
            {
                    return;
            }
            
            UnityEngine.EventSystems.RaycastResult val_1 = eventData.pointerPressRaycast;
            GameUI.EmailUIDataHandler val_2 = emailUIDataHandler;
            if(val_2 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_5 = val_2.transform.position;
            UnityEngine.Vector3 val_7 = this.rectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            float val_8 = this.ItemHeight;
            val_8 = System.Math.Abs(val_7.y) / val_8;
            int val_9 = UnityEngine.Mathf.FloorToInt(f:  val_8);
            if(((val_9 & 2147483648) == 0) && (val_9 < this._itemList.Count))
            {
                    val_12 = this._itemList.Item[val_9];
            }
            else
            {
                    val_12 = 0;
            }
            
            this.SelectedItem = val_12;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Awake()
        {
            this.Awake();
            this.ScrollRect.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<UnityEngine.Vector2>(object:  this, method:  System.Void SRF.UI.Layout.VirtualVerticalLayoutGroup::OnScrollRectValueChanged(UnityEngine.Vector2 d)));
            if((this.ItemPrefab.GetComponent(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != 0)
            {
                    return;
            }
            
            UnityEngine.Debug.LogWarning(message:  "[VirtualVerticalLayoutGroup] ItemPrefab does not have a component inheriting from IVirtualView, so no data binding can occur");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnScrollRectValueChanged(UnityEngine.Vector2 d)
        {
            if(d.y >= 0)
            {
                    if(d.y <= 1f)
            {
                goto label_2;
            }
            
            }
            
            this._scrollRect.verticalNormalizedPosition = UnityEngine.Mathf.Clamp01(value:  d.y);
            label_2:
            this.SetDirty();
            if(this.IsActive() == false)
            {
                    return;
            }
            
            this._isDirty = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Start()
        {
            this.Start();
            this.ScrollUpdate();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnEnable()
        {
            this.OnEnable();
            this.SetDirty();
            if(this.IsActive() == false)
            {
                    return;
            }
            
            this._isDirty = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void Update()
        {
            if(this.AlignBottom != true)
            {
                    if(this.AlignTop != true)
            {
                    UnityEngine.Debug.LogWarning(message:  "[VirtualVerticalLayoutGroup] Only Lower or Upper alignment is supported.", context:  this);
                this.childAlignment = 0;
            }
            
            }
            
            if(this._selectedItem != null)
            {
                    if((this._itemList.Contains(item:  this._selectedItem)) != true)
            {
                    this.SelectedItem = 0;
            }
            
            }
            
            if(this._isDirty == false)
            {
                    return;
            }
            
            this._isDirty = false;
            this.ScrollUpdate();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void InvalidateItem(int itemIndex)
        {
            SRF.SRList<System.Int32> val_6 = this._visibleItemList;
            if((val_6.Contains(item:  itemIndex)) == false)
            {
                    return;
            }
            
            bool val_2 = this._visibleItemList.Remove(item:  itemIndex);
            val_6 = 0;
            goto label_4;
            label_9:
            Row val_3 = this._visibleRows.Item[0];
            if(val_3.Index == itemIndex)
            {
                goto label_7;
            }
            
            val_6 = 1;
            label_4:
            if(val_6 < this._visibleRows.Count)
            {
                goto label_9;
            }
            
            return;
            label_7:
            this.RecycleRow(row:  this._visibleRows.Item[0]);
            this._visibleRows.RemoveAt(index:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void RefreshIndexCache()
        {
            goto label_1;
            label_8:
            Row val_1 = this._visibleRows.Item[0];
            Row val_2 = this._visibleRows.Item[0];
            0 = 1;
            val_1.Index = this._itemList.IndexOf(item:  val_2.Data);
            label_1:
            if(0 < this._visibleRows.Count)
            {
                goto label_8;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void ScrollUpdate()
        {
            var val_28;
            var val_29;
            int val_30;
            var val_31;
            var val_32;
            SRF.SRList<Row> val_33;
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_3 = this.rectTransform.anchoredPosition;
            val_28 = this.ScrollRect.transform;
            if(val_28 == null)
            {
                goto label_4;
            }
            
            if(null == null)
            {
                goto label_7;
            }
            
            val_28 = 0;
            goto label_7;
            label_4:
            label_7:
            UnityEngine.Rect val_7 = val_28.rect;
            float val_8 = this.ItemHeight;
            val_8 = val_8 + this.Spacing;
            val_8 = val_3.y / val_8;
            float val_10 = this.ItemHeight;
            val_10 = val_10 + this.Spacing;
            val_10 = (val_3.y + val_7.m_XMin) / val_10;
            int val_28 = UnityEngine.Mathf.Max(a:  0, b:  (UnityEngine.Mathf.FloorToInt(f:  val_8)) - this.RowPadding);
            val_29 = 1152921520775040544;
            val_30 = UnityEngine.Mathf.Min(a:  this._itemList.Count, b:  this.RowPadding + (UnityEngine.Mathf.CeilToInt(f:  val_10)));
            val_31 = 0;
            val_32 = 0;
            goto label_11;
            label_19:
            Row val_18 = this._visibleRows.Item[0];
            if(val_18.Index >= val_28)
            {
                    if(val_18.Index <= val_30)
            {
                goto label_15;
            }
            
            }
            
            bool val_19 = this._visibleItemList.Remove(item:  val_18.Index);
            bool val_20 = this._visibleRows.Remove(item:  val_18);
            this.RecycleRow(row:  val_18);
            val_32 = 1;
            label_15:
            val_31 = 1;
            label_11:
            val_33 = this._visibleRows;
            if(val_31 < val_33.Count)
            {
                goto label_19;
            }
            
            if(val_28 >= val_30)
            {
                goto label_22;
            }
            
            val_29 = 1152921520775422240;
            label_27:
            if(val_28 >= this._itemList.Count)
            {
                goto label_22;
            }
            
            if((this._visibleItemList.Contains(item:  val_28)) != true)
            {
                    val_33 = this._visibleRows;
                val_33.Add(item:  this.GetRow(forIndex:  val_28));
                this._visibleItemList.Add(item:  val_28);
                val_32 = 1;
            }
            
            val_28 = val_28 + 1;
            if(val_28 < val_30)
            {
                goto label_27;
            }
            
            label_22:
            if((val_32 & 1) != 0)
            {
                goto label_28;
            }
            
            val_30 = this._visibleItemCount;
            if(val_30 == this._visibleRows.Count)
            {
                goto label_30;
            }
            
            label_28:
            UnityEngine.UI.LayoutRebuilder.MarkLayoutForRebuild(rect:  this.rectTransform);
            label_30:
            this._visibleItemCount = this._visibleRows.Count;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void CalculateLayoutInputVertical()
        {
            this.SetLayoutInputForAxis(totalMin:  V0.16B, totalPreferred:  V0.16B, totalFlexible:  -1f, axis:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SetLayoutHorizontal()
        {
            var val_15;
            var val_16;
            UnityEngine.Rect val_2 = this.rectTransform.rect;
            float val_16 = val_2.m_XMin;
            float val_15 = (float)this.padding.left;
            val_15 = val_16 - val_15;
            val_15 = 0;
            val_16 = val_15 - (float)this.padding.right;
            goto label_4;
            label_9:
            Row val_7 = this._visibleRows.Item[0];
            this.SetChildAlongAxis(rect:  val_7.Rect, axis:  0, pos:  (float)this.padding.left, size:  val_16);
            val_15 = 1;
            label_4:
            if(val_15 < this._visibleRows.Count)
            {
                goto label_9;
            }
            
            val_16 = 0;
            goto label_10;
            label_15:
            Row val_11 = this._rowCache.Item[0];
            float val_17 = (float)this.padding.left;
            val_17 = (-val_16) - val_17;
            this.SetChildAlongAxis(rect:  val_11.Rect, axis:  0, pos:  val_17, size:  val_16);
            val_16 = 1;
            label_10:
            if(val_16 < this._rowCache.Count)
            {
                goto label_15;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SetLayoutVertical()
        {
            var val_9;
            UnityEngine.RectTransform val_10;
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            val_9 = 0;
            goto label_2;
            label_8:
            if(this._visibleRows.Item[0] != null)
            {
                    val_10 = val_2.Rect;
            }
            else
            {
                    val_10 = 64;
            }
            
            float val_9 = (float)val_2.Index;
            val_9 = this.ItemHeight * val_9;
            val_9 = val_9 + (float)this.padding.top;
            val_9 = val_9 + (this.Spacing * (float)val_2.Index);
            this.SetChildAlongAxis(rect:  val_10, axis:  1, pos:  val_9, size:  this.ItemHeight);
            val_9 = 1;
            label_2:
            if(val_9 < this._visibleRows.Count)
            {
                goto label_8;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetDirty()
        {
            this.SetDirty();
            if(this.IsActive() == false)
            {
                    return;
            }
            
            this._isDirty = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddItem(object item)
        {
            this._itemList.Add(item:  item);
            this.SetDirty();
            if(this.IsActive() != false)
            {
                    this._isDirty = true;
            }
            
            if(this.StickToBottom == false)
            {
                    return;
            }
            
            if((UnityEngine.Mathf.Approximately(a:  this.ScrollRect.verticalNormalizedPosition, b:  0f)) == false)
            {
                    return;
            }
            
            this = this.ScrollRect;
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  0f, y:  0f);
            this.normalizedPosition = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveItem(object item)
        {
            if(this._selectedItem == item)
            {
                    this.SelectedItem = 0;
            }
            
            this.InvalidateItem(itemIndex:  this._itemList.IndexOf(item:  item));
            bool val_2 = this._itemList.Remove(item:  item);
            this.RefreshIndexCache();
            this.SetDirty();
            if(this.IsActive() == false)
            {
                    return;
            }
            
            this._isDirty = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClearItems()
        {
            SRF.SRList<Row> val_4 = this._visibleRows;
            val_4 = val_4.Count - 1;
            if((val_4 & 2147483648) == 0)
            {
                    do
            {
                Row val_2 = this._visibleRows.Item[val_4];
                this.InvalidateItem(itemIndex:  val_2.Index);
                val_4 = val_4 - 1;
            }
            while((val_4 & 2147483648) == 0);
            
            }
            
            this._itemList.Clear();
            this.SetDirty();
            if(this.IsActive() == false)
            {
                    return;
            }
            
            this._isDirty = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.ScrollRect get_ScrollRect()
        {
            UnityEngine.UI.ScrollRect val_3;
            if(this._scrollRect == 0)
            {
                    this._scrollRect = this.GetComponentInParent<UnityEngine.UI.ScrollRect>();
                return val_3;
            }
            
            val_3 = this._scrollRect;
            return val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool get_AlignBottom()
        {
            var val_5;
            if(this.childAlignment != 8)
            {
                    if(this.childAlignment != 7)
            {
                    return (bool)(this.childAlignment == 6) ? 1 : 0;
            }
            
            }
            
            val_5 = 1;
            return (bool)(this.childAlignment == 6) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool get_AlignTop()
        {
            var val_5;
            if(this.childAlignment != 0)
            {
                    if(this.childAlignment == 1)
            {
                    return (bool)val_5;
            }
            
                var val_4 = (this.childAlignment == 2) ? 1 : 0;
                return (bool)val_5;
            }
            
            val_5 = 1;
            return (bool)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float get_ItemHeight()
        {
            var val_7;
            if(this._itemHeight > 0f)
            {
                    return (float)this._itemHeight;
            }
            
            UnityEngine.Component val_2 = this.ItemPrefab.GetComponent(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            if(val_2 == null)
            {
                goto label_5;
            }
            
            var val_7 = 0;
            val_7 = val_7 + 1;
            goto label_9;
            label_5:
            UnityEngine.Rect val_3 = this.ItemPrefab.rect;
            val_7;
            goto label_11;
            label_9:
            val_7 = val_2;
            float val_5 = val_7.preferredHeight;
            label_11:
            this._itemHeight = val_5;
            if((SRF.SRFFloatExtensions.ApproxZero(f:  val_5)) == false)
            {
                    return (float)this._itemHeight;
            }
            
            UnityEngine.Debug.LogWarning(message:  "[VirtualVerticalLayoutGroup] ItemPrefab must have a preferred size greater than 0");
            this._itemHeight = 10f;
            return (float)this._itemHeight;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRF.UI.Layout.VirtualVerticalLayoutGroup.Row GetRow(int forIndex)
        {
            var val_12;
            Row val_13;
            if(this._rowCache.Count == 0)
            {
                goto label_2;
            }
            
            var val_3 = (forIndex < 0) ? (forIndex + 1) : forIndex;
            val_3 = val_3 & 4294967294;
            val_12 = 0;
            val_13 = 0;
            goto label_4;
            label_9:
            Row val_5 = this._rowCache.Item[0];
            if(val_5.Data == this._itemList.Item[forIndex])
            {
                goto label_7;
            }
            
            int val_12 = val_5.Index;
            val_12 = 1;
            var val_6 = (val_12 < 0) ? (val_12 + 1) : (val_12);
            val_6 = val_6 & 4294967294;
            val_12 = val_12 - val_6;
            Row val_7 = (val_12 == (forIndex - val_3)) ? (val_5) : (val_13);
            label_4:
            if(val_12 < this._rowCache.Count)
            {
                goto label_9;
            }
            
            if(val_7 == 0)
            {
                goto label_10;
            }
            
            bool val_9 = this._rowCache.Remove(item:  val_7);
            goto label_12;
            label_2:
            Row val_10 = this.CreateRow();
            goto label_13;
            label_7:
            this._rowCache.RemoveAt(index:  0);
            this.PopulateRow(index:  forIndex, row:  val_5);
            val_13 = val_5;
            return val_13;
            label_10:
            label_13:
            val_13 = SRF.SRFIListExtensions.PopLast<Row>(list:  this._rowCache);
            label_12:
            this.PopulateRow(index:  forIndex, row:  val_13);
            return val_13;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RecycleRow(SRF.UI.Layout.VirtualVerticalLayoutGroup.Row row)
        {
            this._rowCache.Add(item:  row);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PopulateRow(int index, SRF.UI.Layout.VirtualVerticalLayoutGroup.Row row)
        {
            var val_9;
            row.Index = index;
            row.Data = this._itemList.Item[index];
            val_9 = public System.Object SRF.SRList<System.Object>::get_Item(int index);
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_9 = 0;
            row.View.SetDataContext(data:  this._itemList.Item[index]);
            if(this.RowStyleSheet == 0)
            {
                    if(this.AltRowStyleSheet == 0)
            {
                    if(this.SelectedRowStyleSheet == 0)
            {
                    return;
            }
            
            }
            
            }
            
            if(this.SelectedRowStyleSheet != 0)
            {
                    if(this._selectedItem == row.Data)
            {
                goto label_22;
            }
            
            }
            
            if(row.Root == null)
            {
                goto label_24;
            }
            
            label_25:
            row.Root.StyleSheet = ((index & 1) != 0) ? (this.RowStyleSheet) : this.AltRowStyleSheet;
            return;
            label_22:
            if(row.Root != null)
            {
                goto label_25;
            }
            
            label_24:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRF.UI.Layout.VirtualVerticalLayoutGroup.Row CreateRow()
        {
            UnityEngine.RectTransform val_2 = SRInstantiate.Instantiate<UnityEngine.RectTransform>(prefab:  this.ItemPrefab);
            .Rect = val_2;
            .View = val_2.GetComponent(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            if(this.RowStyleSheet == 0)
            {
                    if(this.AltRowStyleSheet == 0)
            {
                    if(this.SelectedRowStyleSheet == 0)
            {
                goto label_13;
            }
            
            }
            
            }
            
            .Root = SRF.SRFGameObjectExtensions.GetComponentOrAdd<SRF.UI.StyleRoot>(obj:  val_2.gameObject);
            val_9.StyleSheet = this.RowStyleSheet;
            label_13:
            val_2.SetParent(parent:  this.rectTransform, worldPositionStays:  false);
            return (Row)new VirtualVerticalLayoutGroup.Row();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VirtualVerticalLayoutGroup()
        {
            this._itemList = new SRF.SRList<System.Object>();
            this._visibleItemList = new SRF.SRList<System.Int32>();
            this._rowCache = new SRF.SRList<Row>();
            this._visibleRows = new SRF.SRList<Row>();
            this.EnableSelection = true;
            this.RowPadding = 2;
            this.StickToBottom = true;
            this._itemHeight = -1f;
        }
    
    }

}
