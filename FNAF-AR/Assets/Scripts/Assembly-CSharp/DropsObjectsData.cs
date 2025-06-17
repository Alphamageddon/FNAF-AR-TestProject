using System;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class DropsObjectsData
{
	public readonly RangeData CooldownSeconds;

	public readonly RangeData FallbackSeconds;

	public readonly List<AttackPhase> BlacklistedPhases;

	public readonly DropsObjectsMechanic.SpawnType SpawnType;

	public readonly string TemplateBundleName;

	public readonly string TemplateAssetName;

	public readonly string ObjectBundleName;

	public readonly string[] ObjectAssetNames;

	public readonly RangeData AllowedAngle;

	public readonly RangeData AllowedDistance;

	public readonly RangeData FallbackHeightOffset;

	public readonly int MaxConcurrentObjects;

	public readonly DropsObjectsMechanic.DropsObjectUiTarget UITarget;

	public readonly RangeData UITargetRange;

	public readonly float UITargetDuration;

	public readonly int DropCount;

	public readonly float[] DropDurations;

	public readonly int CollectCountForSuccess;

	public readonly DropsObjectsMechanic.SuccessAction SuccessAction;

	public readonly DropsObjectsMechanic.FailureAction FailureAction;

	private float ParseFloatFixRussianMangle(string value)
	{
		if (!float.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out var result))
		{
			Debug.LogError("NullOrtonException - SHITS FUCKED.");
		}
		return result;
	}

	public DropsObjectsData(ATTACK_DATA.DropsObjects rawSettings)
	{
		if (rawSettings.Spawn.Cooldown != null)
		{
			CooldownSeconds = new RangeData(rawSettings.Spawn.Cooldown.Min, rawSettings.Spawn.Cooldown.Max);
			FallbackSeconds = new RangeData(rawSettings.Spawn.Fallback.Min, rawSettings.Spawn.Fallback.Max);
		}
		if (rawSettings.Spawn.BlacklistedPhases != null)
		{
			BlacklistedPhases = new List<AttackPhase>();
			string[] array = rawSettings.Spawn.BlacklistedPhases.Split(',');
			foreach (string value in array)
			{
				BlacklistedPhases.Add((AttackPhase)Enum.Parse(typeof(AttackPhase), value));
			}
			SpawnType = (DropsObjectsMechanic.SpawnType)Enum.Parse(typeof(DropsObjectsMechanic.SpawnType), rawSettings.Spawn.SpawnType);
			TemplateBundleName = rawSettings.Spawn.TemplateBundleName;
			TemplateAssetName = rawSettings.Spawn.TemplateAssetName;
			ObjectBundleName = "This is an unused feature.";
			ObjectAssetNames = new string[0];
		}
		if (rawSettings.Spawn.AllowedAngle != null)
		{
			AllowedAngle = new RangeData(rawSettings.Spawn.AllowedAngle.Min, rawSettings.Spawn.AllowedAngle.Max);
		}
		if (rawSettings.Spawn.Distance != null)
		{
			AllowedDistance = new RangeData(rawSettings.Spawn.Distance.Min, rawSettings.Spawn.Distance.Max);
		}
		if (rawSettings.Spawn.HeightOffset != null)
		{
			FallbackHeightOffset = new RangeData(rawSettings.Spawn.HeightOffset.Min, rawSettings.Spawn.HeightOffset.Max);
		}
		if (rawSettings.Spawn != null)
		{
			MaxConcurrentObjects = rawSettings.Spawn.MaxConcurrentObjects;
		}
		if (rawSettings.UITarget != null)
		{
			if (rawSettings.UITarget.UITargetType != null)
			{
				UITarget = (DropsObjectsMechanic.DropsObjectUiTarget)Enum.Parse(typeof(DropsObjectsMechanic.DropsObjectUiTarget), rawSettings.UITarget.UITargetType);
			}
			if (rawSettings.UITarget.UITargetRange != null)
			{
				UITargetRange = new RangeData(rawSettings.UITarget.UITargetRange.Min, rawSettings.UITarget.UITargetRange.Max);
			}
			UITargetDuration = rawSettings.UITarget.UITargetDuration;
		}
		if (rawSettings.Duration != null)
		{
			DropCount = rawSettings.Duration.DropCount;
			if (rawSettings.Duration.DropDurations != null)
			{
				DropDurations = Array.ConvertAll(rawSettings.Duration.DropDurations.Split(','), ParseFloatFixRussianMangle);
			}
		}
		if (rawSettings.OnSuccess != null)
		{
			CollectCountForSuccess = rawSettings.OnSuccess.CollectCount;
			if (rawSettings.OnSuccess.SuccessAction != null)
			{
				SuccessAction = (DropsObjectsMechanic.SuccessAction)Enum.Parse(typeof(DropsObjectsMechanic.SuccessAction), rawSettings.OnSuccess.SuccessAction);
			}
		}
		if (rawSettings.OnFailure != null && rawSettings.OnFailure.FailureAction != null)
		{
			FailureAction = (DropsObjectsMechanic.FailureAction)Enum.Parse(typeof(DropsObjectsMechanic.FailureAction), rawSettings.OnFailure.FailureAction);
		}
	}
}
