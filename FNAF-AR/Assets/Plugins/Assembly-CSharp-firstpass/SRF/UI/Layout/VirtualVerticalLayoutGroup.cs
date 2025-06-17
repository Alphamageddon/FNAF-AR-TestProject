using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace SRF.UI.Layout
{
	[AddComponentMenu("SRF/UI/Layout/VerticalLayoutGroup (Virtualizing)")]
	public class VirtualVerticalLayoutGroup : LayoutGroup, IPointerClickHandler, IEventSystemHandler
	{
		[Serializable]
		public class SelectedItemChangedEvent : UnityEvent<object>
		{
		}

		[Serializable]
		private class Row
		{
			public object Data;

			public int Index;

			public RectTransform Rect;

			public StyleRoot Root;

			public IVirtualView View;
		}

		private readonly SRList<object> _itemList = new SRList<object>();

		private readonly SRList<int> _visibleItemList = new SRList<int>();

		private bool _isDirty;

		private SRList<Row> _rowCache = new SRList<Row>();

		private ScrollRect _scrollRect;

		private int _selectedIndex;

		private object _selectedItem;

		[SerializeField]
		private SelectedItemChangedEvent _selectedItemChanged;

		private int _visibleItemCount;

		private SRList<Row> _visibleRows = new SRList<Row>();

		public StyleSheet AltRowStyleSheet;

		public bool EnableSelection = true;

		public RectTransform ItemPrefab;

		public int RowPadding = 2;

		public StyleSheet RowStyleSheet;

		public StyleSheet SelectedRowStyleSheet;

		public float Spacing;

		public bool StickToBottom = true;

		private float _itemHeight = -1f;

		public SelectedItemChangedEvent SelectedItemChanged
		{
			get
			{
				return _selectedItemChanged;
			}
			set
			{
				_selectedItemChanged = value;
			}
		}

		public object SelectedItem
		{
			get
			{
				return _selectedItem;
			}
			set
			{
				if (_selectedItem != value && EnableSelection)
				{
					int num = ((value == null) ? (-1) : _itemList.IndexOf(value));
					if (value != null && num < 0)
					{
						throw new InvalidOperationException("Cannot select item not present in layout");
					}
					if (_selectedItem != null)
					{
						InvalidateItem(_selectedIndex);
					}
					_selectedItem = value;
					_selectedIndex = num;
					if (_selectedItem != null)
					{
						InvalidateItem(_selectedIndex);
					}
					SetDirty();
					if (_selectedItemChanged != null)
					{
						_selectedItemChanged.Invoke(_selectedItem);
					}
				}
			}
		}

		public override float minHeight => (float)_itemList.Count * ItemHeight + (float)base.padding.top + (float)base.padding.bottom + Spacing * (float)_itemList.Count;

		private ScrollRect ScrollRect
		{
			get
			{
				if (_scrollRect == null)
				{
					_scrollRect = GetComponentInParent<ScrollRect>();
				}
				return _scrollRect;
			}
		}

		private bool AlignBottom
		{
			get
			{
				if (base.childAlignment != TextAnchor.LowerRight && base.childAlignment != TextAnchor.LowerCenter)
				{
					return base.childAlignment == TextAnchor.LowerLeft;
				}
				return true;
			}
		}

		private bool AlignTop
		{
			get
			{
				if (base.childAlignment != TextAnchor.UpperLeft && base.childAlignment != TextAnchor.UpperCenter)
				{
					return base.childAlignment == TextAnchor.UpperRight;
				}
				return true;
			}
		}

		private float ItemHeight
		{
			get
			{
				if (_itemHeight <= 0f)
				{
					if (ItemPrefab.GetComponent(typeof(ILayoutElement)) is ILayoutElement layoutElement)
					{
						_itemHeight = layoutElement.preferredHeight;
					}
					else
					{
						_itemHeight = ItemPrefab.rect.height;
					}
					if (_itemHeight.ApproxZero())
					{
						Debug.LogWarning("[VirtualVerticalLayoutGroup] ItemPrefab must have a preferred size greater than 0");
						_itemHeight = 10f;
					}
				}
				return _itemHeight;
			}
		}

		public void OnPointerClick(PointerEventData eventData)
		{
			if (!EnableSelection)
			{
				return;
			}
			GameObject gameObject = eventData.pointerPressRaycast.gameObject;
			if (!(gameObject == null))
			{
				Vector3 position = gameObject.transform.position;
				int num = Mathf.FloorToInt(Mathf.Abs(base.rectTransform.InverseTransformPoint(position).y) / ItemHeight);
				if (num >= 0 && num < _itemList.Count)
				{
					SelectedItem = _itemList[num];
				}
				else
				{
					SelectedItem = null;
				}
			}
		}

		protected override void Awake()
		{
			base.Awake();
			ScrollRect.onValueChanged.AddListener(OnScrollRectValueChanged);
			if (ItemPrefab.GetComponent(typeof(IVirtualView)) == null)
			{
				Debug.LogWarning("[VirtualVerticalLayoutGroup] ItemPrefab does not have a component inheriting from IVirtualView, so no data binding can occur");
			}
		}

		private void OnScrollRectValueChanged(Vector2 d)
		{
			if (d.y < 0f || d.y > 1f)
			{
				_scrollRect.verticalNormalizedPosition = Mathf.Clamp01(d.y);
			}
			SetDirty();
		}

		protected override void Start()
		{
			base.Start();
			ScrollUpdate();
		}

		protected override void OnEnable()
		{
			base.OnEnable();
			SetDirty();
		}

		protected void Update()
		{
			if (!AlignBottom && !AlignTop)
			{
				Debug.LogWarning("[VirtualVerticalLayoutGroup] Only Lower or Upper alignment is supported.", this);
				base.childAlignment = TextAnchor.UpperLeft;
			}
			if (SelectedItem != null && !_itemList.Contains(SelectedItem))
			{
				SelectedItem = null;
			}
			if (_isDirty)
			{
				_isDirty = false;
				ScrollUpdate();
			}
		}

		protected void InvalidateItem(int itemIndex)
		{
			if (!_visibleItemList.Contains(itemIndex))
			{
				return;
			}
			_visibleItemList.Remove(itemIndex);
			for (int i = 0; i < _visibleRows.Count; i++)
			{
				if (_visibleRows[i].Index == itemIndex)
				{
					RecycleRow(_visibleRows[i]);
					_visibleRows.RemoveAt(i);
					break;
				}
			}
		}

		protected void RefreshIndexCache()
		{
			for (int i = 0; i < _visibleRows.Count; i++)
			{
				_visibleRows[i].Index = _itemList.IndexOf(_visibleRows[i].Data);
			}
		}

		protected void ScrollUpdate()
		{
			if (!Application.isPlaying)
			{
				return;
			}
			float y = base.rectTransform.anchoredPosition.y;
			float height = ((RectTransform)ScrollRect.transform).rect.height;
			int num = Mathf.FloorToInt(y / (ItemHeight + Spacing));
			int num2 = Mathf.CeilToInt((y + height) / (ItemHeight + Spacing));
			num -= RowPadding;
			num2 += RowPadding;
			num = Mathf.Max(0, num);
			num2 = Mathf.Min(_itemList.Count, num2);
			bool flag = false;
			for (int i = 0; i < _visibleRows.Count; i++)
			{
				Row row = _visibleRows[i];
				if (row.Index < num || row.Index > num2)
				{
					_visibleItemList.Remove(row.Index);
					_visibleRows.Remove(row);
					RecycleRow(row);
					flag = true;
				}
			}
			for (int j = num; j < num2 && j < _itemList.Count; j++)
			{
				if (!_visibleItemList.Contains(j))
				{
					Row row2 = GetRow(j);
					_visibleRows.Add(row2);
					_visibleItemList.Add(j);
					flag = true;
				}
			}
			if (flag || _visibleItemCount != _visibleRows.Count)
			{
				LayoutRebuilder.MarkLayoutForRebuild(base.rectTransform);
			}
			_visibleItemCount = _visibleRows.Count;
		}

		public override void CalculateLayoutInputVertical()
		{
			SetLayoutInputForAxis(minHeight, minHeight, -1f, 1);
		}

		public override void SetLayoutHorizontal()
		{
			float num = base.rectTransform.rect.width - (float)base.padding.left - (float)base.padding.right;
			for (int i = 0; i < _visibleRows.Count; i++)
			{
				Row row = _visibleRows[i];
				SetChildAlongAxis(row.Rect, 0, base.padding.left, num);
			}
			for (int j = 0; j < _rowCache.Count; j++)
			{
				Row row2 = _rowCache[j];
				SetChildAlongAxis(row2.Rect, 0, 0f - num - (float)base.padding.left, num);
			}
		}

		public override void SetLayoutVertical()
		{
			if (Application.isPlaying)
			{
				for (int i = 0; i < _visibleRows.Count; i++)
				{
					Row row = _visibleRows[i];
					SetChildAlongAxis(row.Rect, 1, (float)row.Index * ItemHeight + (float)base.padding.top + Spacing * (float)row.Index, ItemHeight);
				}
			}
		}

		private new void SetDirty()
		{
			base.SetDirty();
			if (IsActive())
			{
				_isDirty = true;
			}
		}

		public void AddItem(object item)
		{
			_itemList.Add(item);
			SetDirty();
			if (StickToBottom && Mathf.Approximately(ScrollRect.verticalNormalizedPosition, 0f))
			{
				ScrollRect.normalizedPosition = new Vector2(0f, 0f);
			}
		}

		public void RemoveItem(object item)
		{
			if (SelectedItem == item)
			{
				SelectedItem = null;
			}
			int itemIndex = _itemList.IndexOf(item);
			InvalidateItem(itemIndex);
			_itemList.Remove(item);
			RefreshIndexCache();
			SetDirty();
		}

		public void ClearItems()
		{
			for (int num = _visibleRows.Count - 1; num >= 0; num--)
			{
				InvalidateItem(_visibleRows[num].Index);
			}
			_itemList.Clear();
			SetDirty();
		}

		private Row GetRow(int forIndex)
		{
			if (_rowCache.Count == 0)
			{
				Row row = CreateRow();
				PopulateRow(forIndex, row);
				return row;
			}
			object obj = _itemList[forIndex];
			Row row2 = null;
			Row row3 = null;
			int num = forIndex % 2;
			for (int i = 0; i < _rowCache.Count; i++)
			{
				row2 = _rowCache[i];
				if (row2.Data == obj)
				{
					_rowCache.RemoveAt(i);
					PopulateRow(forIndex, row2);
					break;
				}
				if (row2.Index % 2 == num)
				{
					row3 = row2;
				}
				row2 = null;
			}
			if (row2 == null && row3 != null)
			{
				_rowCache.Remove(row3);
				row2 = row3;
				PopulateRow(forIndex, row2);
			}
			else if (row2 == null)
			{
				row2 = _rowCache.PopLast();
				PopulateRow(forIndex, row2);
			}
			return row2;
		}

		private void RecycleRow(Row row)
		{
			_rowCache.Add(row);
		}

		private void PopulateRow(int index, Row row)
		{
			row.Index = index;
			row.Data = _itemList[index];
			row.View.SetDataContext(_itemList[index]);
			if (RowStyleSheet != null || AltRowStyleSheet != null || SelectedRowStyleSheet != null)
			{
				if (SelectedRowStyleSheet != null && SelectedItem == row.Data)
				{
					row.Root.StyleSheet = SelectedRowStyleSheet;
				}
				else
				{
					row.Root.StyleSheet = ((index % 2 == 0) ? RowStyleSheet : AltRowStyleSheet);
				}
			}
		}

		private Row CreateRow()
		{
			Row row = new Row();
			RectTransform rectTransform = (row.Rect = SRInstantiate.Instantiate(ItemPrefab));
			row.View = rectTransform.GetComponent(typeof(IVirtualView)) as IVirtualView;
			if (RowStyleSheet != null || AltRowStyleSheet != null || SelectedRowStyleSheet != null)
			{
				row.Root = rectTransform.gameObject.GetComponentOrAdd<StyleRoot>();
				row.Root.StyleSheet = RowStyleSheet;
			}
			rectTransform.SetParent(base.rectTransform, worldPositionStays: false);
			return row;
		}
	}
}
