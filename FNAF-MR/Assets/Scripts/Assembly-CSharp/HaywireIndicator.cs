using System.Collections.Generic;
using UnityEngine;

public class HaywireIndicator
{
	public enum IndicatorVisibility
	{
		Never = -1,
		Always = 0,
		AlwaysHaywire = 1,
		AnimatronicOnScreen = 2
	}

	public enum HaywireIndicateType
	{
		LookAway = 0,
		LookAt = 1
	}

	private IndicatorVisibility visibility;

	private HaywireIndicateType type;

	private AttackAnimatronicExternalSystems systems;

	private Sprite currentIndicatorImage;

	private bool Available;

	private bool InHaywire;

	private bool HaywireOnScreen;

	private Dictionary<HaywireIndicateType, Sprite> indicatorSprites;

	public void Setup(AttackAnimatronicExternalSystems _systems)
	{
		systems = _systems;
		MasterDomain.GetDomain().MasterDataDomain.GetAccessToData.GetConfigDataEntryAsync(ConfigDataReady);
	}

	private void ConfigDataReady(CONFIG_DATA.Root data)
	{
		if (indicatorSprites != null)
		{
			indicatorSprites.Clear();
			indicatorSprites = null;
		}
		indicatorSprites = new Dictionary<HaywireIndicateType, Sprite>();
		IconLookup iconLookupAccess = MasterDomain.GetDomain().GameAssetManagementDomain.IconLookupAccess;
		iconLookupAccess.GetIcon(IconGroup.Encounter, data.Entries[0].ArtAssets.UI.LookAwayIconName, LookAwayIconReady);
		iconLookupAccess.GetIcon(IconGroup.Encounter, data.Entries[0].ArtAssets.UI.LookAtIconName, LookAtIconReady);
	}

	private void LookAwayIconReady(Sprite sprite)
	{
		indicatorSprites.Add(HaywireIndicateType.LookAway, sprite);
	}

	private void LookAtIconReady(Sprite sprite)
	{
		indicatorSprites.Add(HaywireIndicateType.LookAt, sprite);
	}

	public bool ShouldShow()
	{
		if (!Available)
		{
			return false;
		}
		switch (visibility)
		{
		case IndicatorVisibility.Always:
			return true;
		case IndicatorVisibility.AlwaysHaywire:
			return InHaywire;
		case IndicatorVisibility.AnimatronicOnScreen:
			if (InHaywire)
			{
				return HaywireOnScreen;
			}
			return false;
		default:
			return false;
		}
	}

	public Sprite CurrentSprite()
	{
		return currentIndicatorImage;
	}

	public void SetVisibilityType(IndicatorVisibility type)
	{
		visibility = type;
		Available = false;
		if (PlayerPrefs.HasKey("HaywireIndicators") && PlayerPrefs.GetInt("HaywireIndicators") == 1)
		{
			Available = true;
		}
	}

	public void Update()
	{
		if (Available && indicatorSprites != null && indicatorSprites.ContainsKey(type))
		{
			currentIndicatorImage = indicatorSprites[type];
		}
	}

	public void SetHaywireInformation(bool onScreen, bool inHaywire, HaywireIndicateType haywireType)
	{
		InHaywire = inHaywire;
		HaywireOnScreen = onScreen;
		type = haywireType;
	}

	public void Reset()
	{
		Available = false;
		InHaywire = false;
		HaywireOnScreen = false;
		currentIndicatorImage = null;
		visibility = IndicatorVisibility.Never;
	}

	public void TearDown()
	{
		Reset();
		systems = null;
	}
}
