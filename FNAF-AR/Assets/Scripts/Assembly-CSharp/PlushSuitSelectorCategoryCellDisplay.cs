using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlushSuitSelectorCategoryCellDisplay : IxItemCellDisplay<SkinCategoryData>
{
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public string id;

		public PlushSuitSelectorCategoryCellDisplay _003C_003E4__this;

		public Action<Sprite> _003C_003E9__1;

		internal void _003CSetIcon_003Eb__0(IconLookup iconLookup)
		{
			iconLookup.GetIcon(IconGroup.PlushSuit, id, _003C_003E9__1);
		}

		internal void _003CSetIcon_003Eb__1(Sprite sprite)
		{
			_003C_003E4__this._iconImage.sprite = sprite;
		}
	}

	private Image _iconImage;

	private Image _selectedImage;

	private Image _skinIcon;

	private Image _lockedImage;

	private Button _button;

	private TextMeshProUGUI _nameText;

	private TextMeshProUGUI _skinNumText;

	private TextMeshProUGUI _lockedLevelText;

	private int _currentIndex;

	private int _numOwned;

	private IPlushSuitSelectionRules _rules;

	public Action<PlushSuitSelectorCategoryCellDisplay> CategoryCellSelected;

	protected override void PopulateComponents()
	{
		Type[] onlyCacheTypes = new Type[3]
		{
			typeof(Image),
			typeof(Button),
			typeof(TextMeshProUGUI)
		};
		_components.CacheComponents(_root, onlyCacheTypes);
		_iconImage = _components.TryGetComponent<Image>("SuitImage");
		_selectedImage = _components.TryGetComponent<Image>("SelectedStroke");
		_skinIcon = _components.TryGetComponent<Image>("SkinIcon");
		_button = _components.TryGetComponent<Button>("SkinButton");
		_nameText = _components.TryGetComponent<TextMeshProUGUI>("NameText");
		_skinNumText = _components.TryGetComponent<TextMeshProUGUI>("SkinNumText");
		_lockedImage = _components.TryGetComponent<Image>("LockedPlushsuitIcon");
		_lockedLevelText = _components.TryGetComponent<TextMeshProUGUI>("LockedLevelText");
		_button.onClick.AddListener(OnButtonClicked);
	}

	public override void UpdateData()
	{
	}

	public void InitializeContents(IPlushSuitSelectionRules rules, Action<PlushSuitSelectorCategoryCellDisplay> callback)
	{
		_rules = rules;
		CategoryCellSelected = callback;
		_currentIndex = -1;
		InitializeOwnershipData();
		SetDisplayData();
	}

	private void InitializeOwnershipData()
	{
		foreach (OwnedPlushSuitData datum in _dataItem.Data)
		{
			if (datum.Owned && _rules.IsValid(datum.Data.Id))
			{
				_numOwned++;
				if (_currentIndex == -1)
				{
					_currentIndex = _dataItem.Data.IndexOf(datum);
				}
			}
		}
		if (_currentIndex == -1)
		{
			_currentIndex = 0;
		}
	}

	private void SetDisplayData()
	{
		SetIcon();
		_skinNumText.text = _numOwned.ToString();
		bool flag = _dataItem.Data[_currentIndex].Owned && _rules.IsValid(_dataItem.Data[_currentIndex].Data.Id);
		_skinIcon.gameObject.SetActive(flag);
		OwnedPlushSuitData ownedPlushSuitData = _dataItem.Data[_currentIndex];
		_nameText.text = MasterDomain.GetDomain().LocalizationDomain.Localization.GetLocalizedString(ownedPlushSuitData.Data.AnimatronicName, ownedPlushSuitData.Data.AnimatronicName);
		if (ownedPlushSuitData.Data.UnavailableDisplay == PlushSuitData.UnavailableDisplayType.Hide)
		{
			_root.SetActive(value: false);
			_lockedImage.gameObject.SetActive(flag);
			_lockedLevelText.gameObject.SetActive(value: false);
		}
		else if (ownedPlushSuitData.Data.UnavailableDisplay == PlushSuitData.UnavailableDisplayType.Silhouette)
		{
			_lockedImage.gameObject.SetActive(value: false);
			_lockedLevelText.gameObject.SetActive(value: false);
		}
		else if (ownedPlushSuitData.Data.UnavailableDisplay == PlushSuitData.UnavailableDisplayType.UnlockLevel)
		{
			_lockedImage.gameObject.SetActive(!flag);
			_lockedLevelText.gameObject.SetActive(!flag);
			_lockedLevelText.text = $"{ownedPlushSuitData.LockedLevelText} {ownedPlushSuitData.Data.UnlockedLevel}";
		}
	}

	private void SetIcon()
	{
		Debug.Log("IS SUIT " + _dataItem.Data[_currentIndex].Data.Id + " ON A DIFFERENT SLOT? - " + !_rules.IsValid(_dataItem.Data[_currentIndex].Data.Id));
		_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
		_003C_003Ec__DisplayClass17_._003C_003E4__this = this;
		_003C_003Ec__DisplayClass17_._003C_003E9__1 = _003C_003Ec__DisplayClass17_._003CSetIcon_003Eb__1;
		if (_dataItem.Data[_currentIndex].Owned && _rules.IsValid(_dataItem.Data[_currentIndex].Data.Id))
		{
			_003C_003Ec__DisplayClass17_.id = _dataItem.Data[_currentIndex].Data.PlushSuitIconName;
		}
		else
		{
			_003C_003Ec__DisplayClass17_.id = _dataItem.Data[_currentIndex].Data.PlushSuitSilhouetteIcon;
		}
		MasterDomain.GetDomain().GameAssetManagementDomain.IconLookupAccess.GetInterfaceAsync(_003C_003Ec__DisplayClass17_._003CSetIcon_003Eb__0);
		_button.interactable = _dataItem.Data[_currentIndex].Owned && _rules.IsValid(_dataItem.Data[_currentIndex].Data.Id);
	}

	public void SetSelected(bool selected)
	{
		_selectedImage.gameObject.SetActive(selected);
	}

	public void OnButtonClicked()
	{
		if (CategoryCellSelected != null)
		{
			CategoryCellSelected(this);
		}
	}

	public string GetAnimatronicId()
	{
		if (_dataItem.Data[_currentIndex].Owned && _currentIndex < _dataItem.Data.Count)
		{
			return _dataItem.Data[_currentIndex].Data.Id;
		}
		return "";
	}

	public SkinCategoryData GetData()
	{
		return _dataItem;
	}

	public int GetNumOwned()
	{
		return _numOwned;
	}

	public int GetCurrentIndex()
	{
		return _currentIndex;
	}

	public void UpdateCategoryIcon(string skinId)
	{
		foreach (OwnedPlushSuitData datum in _dataItem.Data)
		{
			if (datum.Data.Id == skinId)
			{
				_currentIndex = _dataItem.Data.IndexOf(datum);
				SetDisplayData();
				break;
			}
		}
	}

	public override void TearDown()
	{
		Debug.LogError("category item cell torn down!");
		CategoryCellSelected = null;
		base.TearDown();
	}

	public PlushSuitSelectorCategoryCellDisplay()
	{
		_currentIndex = 0;
	}
}
