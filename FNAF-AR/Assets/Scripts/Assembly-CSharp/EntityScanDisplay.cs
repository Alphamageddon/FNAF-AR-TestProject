using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EntityScanDisplay : IxDisplay
{
	private const string LKEY_SCAN_TEXT = "map_interaction_scanning";

	private EventExposer _eventExposer;

	private Action _onCompleteCallback;

	private AssetCache _assetCache;

	private Button _fullScreenButton;

	private Image _scanImageFrame;

	private TextMeshPro _scanningText;

	public EntityScanDisplay(PrefabInstance instance)
		: base(instance)
	{
	}

	public void Setup(Action onCompleteCallback)
	{
		_onCompleteCallback = onCompleteCallback;
		_scanningText.text = LocalizationDomain.Instance.Localization.GetLocalizedString("map_interaction_scanning", "Scanning... (unlocalized)");
		MasterDomain.GetDomain().MasterDataDomain.GetAccessToData.GetConfigDataEntryAsync(OnMasterDataConfigEntryLoaded);
	}

	public override void Teardown()
	{
		base.Teardown();
		_onCompleteCallback = null;
		_fullScreenButton = null;
	}

	protected override void CacheAndPopulateComponents()
	{
		Type[] onlyCacheTypes = new Type[3]
		{
			typeof(Button),
			typeof(Image),
			typeof(TextMeshPro)
		};
		_components.CacheComponents(_root, onlyCacheTypes);
		_fullScreenButton = _components.TryGetComponent<Button>("FullScreenButton");
		_fullScreenButton.onClick.AddListener(OnFullScreenClicked);
		_fullScreenButton.interactable = false;
		_scanImageFrame = _components.TryGetComponent<Image>("Animation");
		_scanningText = _components.TryGetComponent<TextMeshPro>("Text");
	}

	private void OnMasterDataConfigEntryLoaded(CONFIG_DATA.Root e)
	{
		CoroutineHelper.StartCoroutine(WaitToDismiss((float)e.Entries[0].MapEntities.Interaction.ScanningDuration));
	}

	private IEnumerator WaitToDismiss(float seconds)
	{
		yield return new WaitForSeconds(seconds);
		if (_onCompleteCallback != null)
		{
			_onCompleteCallback();
		}
		ForceClose();
		yield return null;
	}

	private void OnFullScreenClicked()
	{
	}
}
