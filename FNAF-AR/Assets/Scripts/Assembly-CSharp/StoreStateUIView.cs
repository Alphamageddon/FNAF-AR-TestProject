using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class StoreStateUIView : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public StoreCell carouselItem;

		internal void _003CPopulateCarouselSection_003Eb__0(Sprite icon)
		{
			carouselItem.SetSprite(icon);
		}
	}

	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public StoreCell cell;

		internal void _003CAddItemsToStoreSection_003Eb__0(Sprite icon)
		{
			cell.SetSprite(icon);
		}
	}

	[SerializeField]
	private StoreStateUIActions storeStateUIActions;

	[SerializeField]
	private StoreCell storeCellPrefab;

	[SerializeField]
	private StoreSection storeSectionPrefab;

	[SerializeField]
	private StoreCell CarouselBannerPrefab;

	[SerializeField]
	private Transform StoreSectionParent;

	[SerializeField]
	private ScrollRect StoreScrollRect;

	public const string SCROLL_TARGET_DEFAULT = "None";

	public const string SCROLL_TARGET_DEVICE = "Device";

	public const string SCROLL_TARGET_FAZCOINS = "FazCoins";

	public const string SCROLL_TARGET_LURE = "Lure";

	public const string SCROLL_TARGET_MINIPACK = "MiniPack";

	public const string SCROLL_TARGET_PACK = "Pack";

	public const string SCROLL_TARGET_BUFF = "Buff";

	private GameUIDomain _uiDomain;

	private StoreDomain _storeDomain;

	private EventExposer _eventExposer;

	private Dictionary<string, StoreSection> _storeSectionsByType;

	private Dictionary<string, List<StoreDisplayData>> _sortedDisplayItems;

	public void CreateStoreSections()
	{
		if (_storeSectionsByType == null)
		{
			_storeSectionsByType = new Dictionary<string, StoreSection>();
		}
		else
		{
			foreach (StoreSection value in _storeSectionsByType.Values)
			{
				value.Reset();
				UnityEngine.Object.Destroy(value.gameObject);
			}
		}
		foreach (StoreSectionData sectionDatum in _storeDomain.StoreContainer.SectionData)
		{
			_storeSectionsByType[sectionDatum.Logical] = CreateSection(sectionDatum);
		}
	}

	private StoreSection CreateSection(StoreSectionData data)
	{
		StoreSection storeSection = UnityEngine.Object.Instantiate(storeSectionPrefab, StoreSectionParent);
		storeSection.SetData(data, _storeDomain);
		return storeSection;
	}

	private void ResetSections()
	{
		Debug.LogError("resetting sections");
		foreach (StoreSection value in _storeSectionsByType.Values)
		{
			value.Reset();
		}
	}

	public void IconsLoaded()
	{
		PopulateStore();
	}

	public void PopulateStore()
	{
		if (_storeDomain.Icons.IconsReady())
		{
			PopulateStoreItems();
		}
	}

	private void PopulateStoreItems()
	{
		SortDisplayItems();
		ResetSections();
		Debug.LogError("populating store items");
		foreach (StoreSectionData sectionDatum in _storeDomain.StoreContainer.SectionData)
		{
			if (!_sortedDisplayItems.ContainsKey(sectionDatum.Logical))
			{
				continue;
			}
			List<StoreDisplayData> list = _sortedDisplayItems[sectionDatum.Logical];
			if (sectionDatum.Type != StoreSectionData.DisplayType.Carousel && sectionDatum.Type == StoreSectionData.DisplayType.Main)
			{
				list.OrderBy((StoreDisplayData x) => x.storeData.Order);
				PopulateMainSection(sectionDatum.Logical, list);
			}
		}
	}

	private void PopulateMainSection(string key, List<StoreDisplayData> items)
	{
		if (_storeSectionsByType.ContainsKey(key) && _sortedDisplayItems.ContainsKey(key))
		{
			AddItemsToStoreSection(_storeSectionsByType[key], items);
		}
	}

	private void PopulateCarouselSection(List<StoreDisplayData> items)
	{
		foreach (StoreDisplayData item in items)
		{
			_003C_003Ec__DisplayClass26_0 _003C_003Ec__DisplayClass26_ = new _003C_003Ec__DisplayClass26_0();
			_003C_003Ec__DisplayClass26_.carouselItem = UnityEngine.Object.Instantiate(CarouselBannerPrefab);
			_storeDomain.Icons.GetStoreIcon(item.storeData.ArtRef, _003C_003Ec__DisplayClass26_._003CPopulateCarouselSection_003Eb__0);
			StoreCellData storeCellData = new StoreCellData();
			storeCellData.OnClickedDelegate = OnStoreButtonClicked;
			storeCellData.displayData = item;
			_003C_003Ec__DisplayClass26_.carouselItem.SetData(storeCellData);
		}
	}

	private void SortDisplayItems()
	{
		_sortedDisplayItems.Clear();
		foreach (StoreDisplayData value in _storeDomain.StoreContainer.DisplayItems.Values)
		{
			if (!_sortedDisplayItems.ContainsKey(value.storeData.StoreSection))
			{
				_sortedDisplayItems[value.storeData.StoreSection] = new List<StoreDisplayData>();
			}
			_sortedDisplayItems[value.storeData.StoreSection].Add(value);
		}
	}

	private void AddItemsToStoreSection(StoreSection section, List<StoreDisplayData> displayData)
	{
		foreach (StoreDisplayData displayDatum in displayData)
		{
			_003C_003Ec__DisplayClass28_0 _003C_003Ec__DisplayClass28_ = new _003C_003Ec__DisplayClass28_0();
			_003C_003Ec__DisplayClass28_.cell = UnityEngine.Object.Instantiate(storeCellPrefab);
			_storeDomain.Icons.GetStoreIcon(displayDatum.storeData.ArtRef, _003C_003Ec__DisplayClass28_._003CAddItemsToStoreSection_003Eb__0);
			StoreCellData storeCellData = new StoreCellData();
			storeCellData.OnClickedDelegate = OnStoreButtonClicked;
			storeCellData.displayData = displayDatum;
			_003C_003Ec__DisplayClass28_.cell.SetData(storeCellData);
			section.AddItem(displayDatum.shortCode, _003C_003Ec__DisplayClass28_.cell);
		}
	}

	public void OnStoreButtonClicked(StoreCell cell)
	{
		if (!HandleSpecialTypes(cell))
		{
			storeStateUIActions.ShowPurchaseDialog(cell);
		}
	}

	public void OnStoreDataUpdated()
	{
		PopulateStore();
	}

	public void OnPurchaseError(string error)
	{
		PopulateStore();
	}

	private bool HandleSpecialTypes(StoreCell cell)
	{
		if (cell.Data.storeData.ActionType == "url")
		{
			Application.OpenURL(cell.Data.storeData.ActionPayload);
			return true;
		}
		return false;
	}

	private IEnumerator DelayByFrames(int frames, Action action)
	{
		int framesLeft = frames;
		while (framesLeft > 0)
		{
			framesLeft--;
			yield return null;
		}
		action();
	}

	private void HandleScrollTarget()
	{
		_uiDomain.ResetStoreScrollSettings();
		if (ShouldScroll(_uiDomain.GameUIData.storeScrollSection, _uiDomain.GameUIData.storeScrollItem))
		{
			if (_uiDomain.GameUIData.storeScrollSection == "Carousel")
			{
				ScrollToCarouselItem(_uiDomain.GameUIData.storeScrollItem);
			}
			else
			{
				ScrollToSection(_uiDomain.GameUIData.storeScrollSection, _uiDomain.GameUIData.storeScrollItem);
			}
		}
	}

	private void ScrollToCarouselItem(string itemId)
	{
	}

	private bool ShouldScroll(string section, string item)
	{
		if (section == "None")
		{
			return !string.IsNullOrEmpty(item);
		}
		return true;
	}

	private void ScrollToSection(string sectionType, string itemType)
	{
		if (_storeSectionsByType.ContainsKey(sectionType) && !(_storeSectionsByType[sectionType] == null))
		{
			ScrollToRectTransform(StoreScrollRect, _storeSectionsByType[sectionType], itemType);
		}
	}

	private void ScrollToRectTransform(ScrollRect scrollRect, StoreSection section, string storeItem)
	{
		StoreCell cell = section.GetCell(storeItem);
		if (!(cell == null))
		{
			Vector2 snapToPositionToBringChildIntoView = GetSnapToPositionToBringChildIntoView(scrollRect, section.GetRectTransform(), cell.GetCellTransform());
			scrollRect.content.localPosition = new Vector3
			{
				x = scrollRect.content.localPosition.x,
				y = snapToPositionToBringChildIntoView.y,
				z = scrollRect.content.localPosition.z
			};
			OnStoreButtonClicked(cell);
			Canvas.ForceUpdateCanvases();
		}
	}

	private static Vector2 GetSnapToPositionToBringChildIntoView(ScrollRect scrollRect, RectTransform sectionTransform, RectTransform itemTransform)
	{
		Canvas.ForceUpdateCanvases();
		Vector2 vector = scrollRect.viewport.localPosition;
		Vector2 vector2 = sectionTransform.localPosition;
		Vector2 vector3 = itemTransform.localPosition;
		return new Vector2(0f - (vector.x + vector2.x + vector3.x), 0f - (vector.y + vector2.y + vector3.y));
	}

	private void OnEnable()
	{
		MasterDomain domain = MasterDomain.GetDomain();
		_storeDomain = domain.StoreDomain;
		_eventExposer = domain.eventExposer;
		_uiDomain = domain.GameUIDomain;
		_sortedDisplayItems = new Dictionary<string, List<StoreDisplayData>>();
		CreateStoreSections();
		PopulateStore();
		_eventExposer.OnStoreOpened();
		StoreDomain storeDomain = _storeDomain;
		storeDomain.IconsLoaded = (Action)Delegate.Combine(storeDomain.IconsLoaded, new Action(IconsLoaded));
		StoreDomain storeDomain2 = _storeDomain;
		storeDomain2.PurchaseErrorCallback = (Action<string>)Delegate.Combine(storeDomain2.PurchaseErrorCallback, new Action<string>(OnPurchaseError));
		_storeDomain.RequestVirtualGoods();
	}

	private void Start()
	{
	}

	private void OnDisable()
	{
		StoreDomain storeDomain = _storeDomain;
		storeDomain.IconsLoaded = (Action)Delegate.Remove(storeDomain.IconsLoaded, new Action(IconsLoaded));
		StoreDomain storeDomain2 = _storeDomain;
		storeDomain2.PurchaseErrorCallback = (Action<string>)Delegate.Remove(storeDomain2.PurchaseErrorCallback, new Action<string>(OnPurchaseError));
		_eventExposer.OnStoreClosed();
	}
}
