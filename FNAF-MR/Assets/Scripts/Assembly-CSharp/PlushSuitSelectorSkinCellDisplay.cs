using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlushSuitSelectorSkinCellDisplay : IxItemCellDisplay<OwnedPlushSuitData>
{
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public string id;

		public PlushSuitSelectorSkinCellDisplay _003C_003E4__this;

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

	private Button _button;

	private IPlushSuitSelectionRules _rules;

	public Action<PlushSuitSelectorSkinCellDisplay> SkinCellSelected;

	public bool Valid => _rules.IsValid(_dataItem.Data.Id);

	protected override void PopulateComponents()
	{
		Type[] onlyCacheTypes = new Type[3]
		{
			typeof(Image),
			typeof(Button),
			typeof(TextMeshProUGUI)
		};
		_components.CacheComponents(_root, onlyCacheTypes);
		_iconImage = _components.TryGetComponent<Image>("IconImage");
		_selectedImage = _components.TryGetComponent<Image>("SelectedStroke");
		_button = _components.TryGetComponent<Button>("SkinButton");
		_button.onClick.AddListener(OnButtonClicked);
	}

	public override void UpdateData()
	{
	}

	public void InitializeContents(IPlushSuitSelectionRules rules, Action<PlushSuitSelectorSkinCellDisplay> callback)
	{
		_rules = rules;
		SkinCellSelected = callback;
		SetIcon();
	}

	private void SetIcon()
	{
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
		_003C_003Ec__DisplayClass10_._003C_003E4__this = this;
		_003C_003Ec__DisplayClass10_._003C_003E9__1 = _003C_003Ec__DisplayClass10_._003CSetIcon_003Eb__1;
		_003C_003Ec__DisplayClass10_.id = ((!Valid) ? _dataItem.Data.PlushSuitSilhouetteIcon : _dataItem.Data.PlushSuitIconName);
		MasterDomain.GetDomain().GameAssetManagementDomain.IconLookupAccess.GetInterfaceAsync(_003C_003Ec__DisplayClass10_._003CSetIcon_003Eb__0);
		_button.interactable = Valid;
	}

	public void SetSelected(bool selected)
	{
		_selectedImage.gameObject.SetActive(selected);
	}

	public void OnButtonClicked()
	{
		if (SkinCellSelected != null)
		{
			SkinCellSelected(this);
		}
	}

	public string GetSkinId()
	{
		if (_dataItem.Data.Id != null)
		{
			return _dataItem.Data.Id;
		}
		return "";
	}

	public override void TearDown()
	{
		SkinCellSelected = null;
		base.TearDown();
	}
}
