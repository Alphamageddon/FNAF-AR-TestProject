using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IntroScreenDisplay : IxDisplay
{
	private IntroScreen.IntroScreenDialogData data;

	private MasterDomain _masterDomain;

	private RectTransform cardsParent;

	private GameObject objectToRelease;

	private AssetCache assetCache;

	private Button startButton;

	private RectTransform loadingIcon;

	private Button nextCardButton;

	public IntroScreenDisplay(PrefabInstance instance)
		: base(instance)
	{
	}

	public void Setup(IntroScreen.IntroScreenDialogData dialogData)
	{
		data = dialogData;
		TryCallHookups();
		_masterDomain.GameAssetManagementDomain.AssetCacheAccess.GetInterfaceAsync(AssetCacheReceived);
	}

	private void AssetCacheReceived(AssetCache cache)
	{
		assetCache = cache;
		if (data.attackProfile != null)
		{
			cache.LoadAsset<GameObject>(data.attackProfile.IntroScreen.Bundle, data.attackProfile.IntroScreen.Asset, IntroAssetLoaded, IntroAssetFailed);
		}
		else if (data.scavengingAttackProfile != null)
		{
			cache.LoadAsset<GameObject>(data.scavengingAttackProfile.IntroScreen.Bundle, data.scavengingAttackProfile.IntroScreen.Asset, IntroAssetLoaded, IntroAssetFailed);
		}
		else
		{
			Debug.LogError("No available bundle/asset info for Intro Screen display.");
		}
	}

	private void IntroAssetFailed()
	{
		Debug.LogError("Intro load asset failed");
	}

	private void IntroAssetLoaded(GameObject obj)
	{
		objectToRelease = obj;
		UnityEngine.Object.Instantiate(obj, cardsParent).GetComponent<IntroScreenBehavior>().Activate(nextCardButton);
		nextCardButton.enabled = true;
	}

	protected override void CacheAndPopulateComponents()
	{
		Type[] onlyCacheTypes = new Type[4]
		{
			typeof(RectTransform),
			typeof(TextMeshProUGUI),
			typeof(Image),
			typeof(Button)
		};
		_components.CacheComponents(_root, onlyCacheTypes);
		_masterDomain = MasterDomain.GetDomain();
		cardsParent = _components.TryGetComponent<RectTransform>("CardsParent");
		startButton = _components.TryGetComponent<Button>("CTA1");
		nextCardButton = _components.TryGetComponent<Button>("NextCardButton");
		loadingIcon = _components.TryGetComponent<RectTransform>("LoadingIcon");
		TryCallHookups();
	}

	private void TryCallHookups()
	{
		if (!(startButton == null) && !(loadingIcon == null) && data != null)
		{
			data.hookupsCallback(startButton, loadingIcon.gameObject);
		}
	}

	public override void Teardown()
	{
		_masterDomain = null;
		data = null;
		assetCache.ReleaseAsset(objectToRelease);
		assetCache = null;
		base.Teardown();
	}
}
