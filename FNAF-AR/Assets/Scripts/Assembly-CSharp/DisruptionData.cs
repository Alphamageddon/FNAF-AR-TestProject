using System;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class DisruptionData
{
	public const string DISRUPTION_CHANCE = "ChanceToDisrupt";

	public const string DISRUPTION_CHANCE_MODIFIER = "ChanceToDisruptModifier";

	public const string CANCEL_DURATION = "CancelDuration";

	public readonly DisruptionStyle Style;

	public readonly RangeData Seconds;

	public readonly RandomChanceData ActivationChance;

	public float RampTime;

	public readonly float CancelTime;

	public readonly DisruptionCancelAction CancelAction;

	public readonly RangeData ShakeMagnitude;

	public readonly float ShakeGraceTime;

	public readonly DisruptionUiTarget UITarget;

	public readonly RangeData UITargetRange;

	public readonly float ScreenObjectAnimationSpeed;

	public readonly float[] ScreenObjectAnimationDurations;

	public readonly RangeData ScreenObjectCooldown;

	private float ParseFloatFixRussianMangle(string value)
	{
		if (!float.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out var result))
		{
			Debug.LogError("NullOrtonException - SHITS FUCKED.");
		}
		return result;
	}

	public DisruptionData(ATTACK_DATA.Disruption rawSettings)
	{
		Style = (DisruptionStyle)Enum.Parse(typeof(DisruptionStyle), rawSettings.Settings.Style);
		if (rawSettings.Settings.Cooldown != null)
		{
			Seconds = new RangeData(rawSettings.Settings.Cooldown.Min, rawSettings.Settings.Cooldown.Max);
		}
		if (rawSettings.Settings.Activation != null)
		{
			ActivationChance = new RandomChanceData(rawSettings.Settings.Activation.Chance, rawSettings.Settings.Activation.Modifier);
		}
		if (rawSettings.Settings != null)
		{
			RampTime = rawSettings.Settings.RampTime;
			CancelTime = rawSettings.Settings.CancelTime;
			CancelAction = (DisruptionCancelAction)Enum.Parse(typeof(DisruptionCancelAction), rawSettings.Settings.CancelAction);
		}
		if (rawSettings.Shake != null)
		{
			ShakeMagnitude = new RangeData(rawSettings.Shake.ShakeMagnitude.Min, rawSettings.Shake.ShakeMagnitude.Max);
			ShakeGraceTime = rawSettings.Shake.ShakeGraceTime;
		}
		if (rawSettings.UITarget.UITargetType != null)
		{
			UITarget = (DisruptionUiTarget)Enum.Parse(typeof(DisruptionUiTarget), rawSettings.UITarget.UITargetType);
		}
		if (rawSettings.UITarget.UITargetRange != null)
		{
			UITargetRange = new RangeData(rawSettings.UITarget.UITargetRange.Min, rawSettings.UITarget.UITargetRange.Max);
		}
		if (rawSettings.ScreenObjects != null)
		{
			ScreenObjectAnimationSpeed = rawSettings.ScreenObjects.AnimationSpeed;
			ScreenObjectAnimationDurations = Array.ConvertAll(rawSettings.ScreenObjects.AnimationDurations.Split(','), ParseFloatFixRussianMangle);
			ScreenObjectCooldown = new RangeData(rawSettings.ScreenObjects.Cooldown.Min, rawSettings.ScreenObjects.Cooldown.Max);
		}
	}

	public DisruptionData(DisruptionData disruption, Dictionary<string, float> mods)
	{
		Style = disruption.Style;
		Seconds = disruption.Seconds;
		if (disruption.ActivationChance != null)
		{
			ActivationChance = new RandomChanceData(disruption.ActivationChance, "ChanceToDisrupt", "ChanceToDisruptModifier", mods);
		}
		RampTime = disruption.RampTime;
		CancelTime = FloatHelper.ApplyModifier(disruption.CancelTime, "CancelDuration", mods);
		CancelAction = disruption.CancelAction;
		ShakeMagnitude = disruption.ShakeMagnitude;
		ShakeGraceTime = disruption.ShakeGraceTime;
		UITarget = disruption.UITarget;
		UITargetRange = disruption.UITargetRange;
		ScreenObjectAnimationSpeed = disruption.ScreenObjectAnimationSpeed;
		ScreenObjectAnimationDurations = disruption.ScreenObjectAnimationDurations;
		ScreenObjectCooldown = disruption.ScreenObjectCooldown;
	}

	public DisruptionData(DisruptionData disruptionToCopy)
	{
		Style = disruptionToCopy.Style;
		Seconds = new RangeData(disruptionToCopy.Seconds.Min, disruptionToCopy.Seconds.Max);
		if (disruptionToCopy.ActivationChance != null)
		{
			ActivationChance = new RandomChanceData(disruptionToCopy.ActivationChance.Chance, disruptionToCopy.ActivationChance.Modifier);
		}
		RampTime = disruptionToCopy.RampTime;
		CancelTime = disruptionToCopy.CancelTime;
		CancelAction = disruptionToCopy.CancelAction;
		if (disruptionToCopy.ShakeMagnitude != null)
		{
			ShakeMagnitude = new RangeData(disruptionToCopy.ShakeMagnitude.Min, disruptionToCopy.ShakeMagnitude.Max);
		}
		ShakeGraceTime = disruptionToCopy.ShakeGraceTime;
		UITarget = disruptionToCopy.UITarget;
		if (disruptionToCopy.UITargetRange != null)
		{
			UITargetRange = new RangeData(disruptionToCopy.UITargetRange.Min, disruptionToCopy.UITargetRange.Max);
		}
		ScreenObjectAnimationSpeed = disruptionToCopy.ScreenObjectAnimationSpeed;
		if (disruptionToCopy.ScreenObjectAnimationDurations != null)
		{
			Array.Copy(disruptionToCopy.ScreenObjectAnimationDurations, ScreenObjectAnimationDurations, disruptionToCopy.ScreenObjectAnimationDurations.Length);
		}
		if (disruptionToCopy.ScreenObjectCooldown != null)
		{
			ScreenObjectCooldown = new RangeData(disruptionToCopy.ScreenObjectCooldown.Min, disruptionToCopy.ScreenObjectCooldown.Max);
		}
	}

	public override string ToString()
	{
		return $"{{\"ActivationChance\":{ActivationChance},\"CancelTime\":{CancelTime}}}";
	}
}
