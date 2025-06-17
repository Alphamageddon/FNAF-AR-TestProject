using System;

public class PlushSuitData
{
	public enum UnavailableDisplayType
	{
		Hide = 0,
		UnlockLevel = 1,
		Silhouette = 2
	}

	public readonly string Id;

	public readonly string AnimatronicName;

	public readonly string Description;

	public readonly int UnlockedLevel;

	public readonly bool Enabled;

	public readonly string SoundBankName;

	public readonly string AnimatronicAssetBundle;

	public readonly string AnimatronicPrefab;

	public readonly string MapIconPrefab;

	public readonly string PlushSuitIconName;

	public readonly string PortraitIconName;

	public readonly string PortraitIconFlatName;

	public readonly string PlushSuitSilhouetteIcon;

	public readonly bool PlayerAcquirable;

	public readonly string SkinCategory;

	public readonly int SkinOrder;

	public readonly UnavailableDisplayType UnavailableDisplay;

	public readonly string MangleEncounterBundleName;

	public readonly string[] MangleEncounterAssetNames;

	public readonly string DisruptionScreenObjectBundleName;

	public readonly string DisruptionScreenObjectAssetName;

	public readonly LookAwayApproachPoseData LookAwayApproachPose;

	public readonly string ConcreteItemId;

	public readonly Environment Environment;

	public readonly ShockTargetBorderData ShockTargetBorder;

	public PlushSuitData(PLUSHSUIT_DATA.Entry rawSettings)
	{
		Id = rawSettings.Logical;
		AnimatronicName = rawSettings.AnimatronicNames.Default;
		if (rawSettings.AnimPlayerFacingText != null && rawSettings.AnimPlayerFacingText.PlushSuitDescription != null)
		{
			Description = rawSettings.AnimPlayerFacingText.PlushSuitDescription;
		}
		UnlockedLevel = rawSettings.UnlockedLevel;
		if (rawSettings.Status != null && rawSettings.Status.LiveState != null)
		{
			Enabled = !(rawSettings.Status.LiveState == "State_Inactive");
		}
		SoundBankName = rawSettings.ArtAssets.Audio.SoundBank;
		AnimatronicAssetBundle = rawSettings.ArtAssets.Animatronic3D.Bundle;
		AnimatronicPrefab = rawSettings.ArtAssets.Animatronic3D.Prefab;
		if (rawSettings.ArtAssets.Animatronic3D.MapIcon != null)
		{
			MapIconPrefab = rawSettings.ArtAssets.Animatronic3D.MapIcon;
		}
		if (rawSettings.ArtAssets.UI != null)
		{
			if (rawSettings.ArtAssets.UI.PlushSuitIcon != null)
			{
				PlushSuitIconName = rawSettings.ArtAssets.UI.PlushSuitIcon;
			}
			if (rawSettings.ArtAssets.UI.PortraitIcon != null)
			{
				PortraitIconName = rawSettings.ArtAssets.UI.PortraitIcon;
			}
			if (rawSettings.ArtAssets.UI.PortraitIconFlat != null)
			{
				PortraitIconFlatName = rawSettings.ArtAssets.UI.PortraitIconFlat;
			}
			if (rawSettings.ArtAssets.UI.PlushSuitSilhouetteIcon != null)
			{
				PlushSuitSilhouetteIcon = rawSettings.ArtAssets.UI.PlushSuitSilhouetteIcon;
			}
		}
		if (rawSettings.SkinCategory != null)
		{
			SkinCategory = rawSettings.SkinCategory;
		}
		PlayerAcquirable = rawSettings.PlayerAcquirable;
		SkinOrder = rawSettings.SkinOrder;
		if (rawSettings.UnavailableDisplay != null)
		{
			UnavailableDisplay = (UnavailableDisplayType)Enum.Parse(typeof(UnavailableDisplayType), rawSettings.UnavailableDisplay);
		}
		if (rawSettings.ArtAssets.MangleEncounterParts != null)
		{
			MangleEncounterBundleName = rawSettings.ArtAssets.MangleEncounterParts.BundleName;
			MangleEncounterAssetNames = rawSettings.ArtAssets.MangleEncounterParts.AssetNames.Split(',');
		}
		if (rawSettings.ArtAssets.DisruptionScreenObjects != null)
		{
			DisruptionScreenObjectBundleName = rawSettings.ArtAssets.DisruptionScreenObjects.BundleName;
			DisruptionScreenObjectAssetName = rawSettings.ArtAssets.DisruptionScreenObjects.AssetName;
		}
		if (rawSettings.LookAwayApproachPose != null)
		{
			LookAwayApproachPose = new LookAwayApproachPoseData(rawSettings.LookAwayApproachPose);
		}
		if (rawSettings.ConcreteItemID != null)
		{
			ConcreteItemId = rawSettings.ConcreteItemID;
		}
		if (rawSettings.Environment != null)
		{
			Environment = new Environment(rawSettings.Environment);
		}
		if (rawSettings.ShockTargetBorder != null)
		{
			ShockTargetBorder = new ShockTargetBorderData(rawSettings.ShockTargetBorder);
		}
	}
}
