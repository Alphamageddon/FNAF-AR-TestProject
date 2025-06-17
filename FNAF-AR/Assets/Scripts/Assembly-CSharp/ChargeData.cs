using System;
using System.Collections.Generic;
using UnityEngine;

public class ChargeData
{
	public const string REMNANT_SHOCK_WINDOW = "RemnantShockWindow";

	public RangeData Seconds;

	public readonly RangeData ShockWindow;

	public readonly float ShockWindowLimit;

	public readonly RandomChanceData JumpscareChance;

	public readonly RangeData JumpscareDelayTime;

	public readonly RandomChanceData SkipJumpscareChance;

	public readonly ChargeDeflectionAction DeflectionAction;

	public readonly bool DeflectionMustStartDuringCharge;

	public readonly bool ForceCircleAfterPause;

	public readonly AutoShutdownType AutoShutdownType;

	public readonly int AutoShutdownCountTrigger;

	public ChargeData(ATTACK_DATA.Charge rawSettings)
	{
		if (rawSettings.Seconds != null)
		{
			Seconds = new RangeData(rawSettings.Seconds.Min, rawSettings.Seconds.Max);
		}
		if (rawSettings.ShockWindow != null)
		{
			ShockWindow = new RangeData(rawSettings.ShockWindow.Min, rawSettings.ShockWindow.Max);
		}
		ShockWindowLimit = rawSettings.ShockWindowLimit;
		if (rawSettings.JumpscareChance != null)
		{
			JumpscareChance = new RandomChanceData(rawSettings.JumpscareChance.Chance, rawSettings.JumpscareChance.Modifier);
		}
		if (rawSettings.JumpscareDelayTime != null)
		{
			JumpscareDelayTime = new RangeData(rawSettings.JumpscareDelayTime.Min, rawSettings.JumpscareDelayTime.Max);
		}
		if (rawSettings.SkipJumpscareChance != null)
		{
			SkipJumpscareChance = new RandomChanceData(rawSettings.SkipJumpscareChance.Chance, rawSettings.SkipJumpscareChance.Modifier);
		}
		DeflectionAction = (ChargeDeflectionAction)Enum.Parse(typeof(ChargeDeflectionAction), rawSettings.DeflectionAction);
		DeflectionMustStartDuringCharge = rawSettings.DeflectionMustStartDuringCharge;
		ForceCircleAfterPause = rawSettings.ForceCircleAfterPause;
		if (rawSettings.AutoShutdown != null)
		{
			AutoShutdownType = (AutoShutdownType)Enum.Parse(typeof(AutoShutdownType), rawSettings.AutoShutdown.ShutdownType);
			AutoShutdownCountTrigger = rawSettings.AutoShutdown.CountTrigger;
		}
	}

	public ChargeData(ChargeData charge, Dictionary<string, float> mods)
	{
		Seconds = charge.Seconds;
		ShockWindowLimit = charge.ShockWindowLimit;
		if (mods.ContainsKey("RemnantShockWindow"))
		{
			ShockWindow = BuildShockWindow(charge.ShockWindow.Min + mods["RemnantShockWindow"], charge.ShockWindow.Max + mods["RemnantShockWindow"], ShockWindowLimit);
		}
		else
		{
			ShockWindow = new RangeData(charge.ShockWindow.Min, charge.ShockWindow.Max);
		}
		JumpscareChance = charge.JumpscareChance;
		JumpscareDelayTime = charge.JumpscareDelayTime;
		SkipJumpscareChance = charge.SkipJumpscareChance;
		DeflectionAction = charge.DeflectionAction;
		DeflectionMustStartDuringCharge = charge.DeflectionMustStartDuringCharge;
		ForceCircleAfterPause = charge.ForceCircleAfterPause;
		AutoShutdownType = charge.AutoShutdownType;
		AutoShutdownCountTrigger = charge.AutoShutdownCountTrigger;
	}

	public ChargeData(ChargeData chargeToCopy)
	{
		if (chargeToCopy.Seconds != null)
		{
			Seconds = new RangeData(chargeToCopy.Seconds.Min, chargeToCopy.Seconds.Max);
		}
		ShockWindowLimit = chargeToCopy.ShockWindowLimit;
		if (chargeToCopy.ShockWindow != null)
		{
			ShockWindow = new RangeData(chargeToCopy.ShockWindow.Min, chargeToCopy.ShockWindow.Max);
		}
		if (chargeToCopy.JumpscareChance != null)
		{
			JumpscareChance = new RandomChanceData(chargeToCopy.JumpscareChance.Chance, chargeToCopy.JumpscareChance.Modifier);
		}
		if (chargeToCopy.JumpscareDelayTime != null)
		{
			JumpscareDelayTime = new RangeData(chargeToCopy.JumpscareDelayTime.Min, chargeToCopy.JumpscareDelayTime.Max);
		}
		if (chargeToCopy.SkipJumpscareChance != null)
		{
			SkipJumpscareChance = new RandomChanceData(chargeToCopy.SkipJumpscareChance.Chance, chargeToCopy.SkipJumpscareChance.Modifier);
		}
		DeflectionAction = chargeToCopy.DeflectionAction;
		DeflectionMustStartDuringCharge = chargeToCopy.DeflectionMustStartDuringCharge;
		ForceCircleAfterPause = chargeToCopy.ForceCircleAfterPause;
		AutoShutdownType = chargeToCopy.AutoShutdownType;
		AutoShutdownCountTrigger = chargeToCopy.AutoShutdownCountTrigger;
	}

	private static RangeData BuildShockWindow(float min, float max, float shockWindowLimit)
	{
		return new RangeData(Mathf.Min(min, shockWindowLimit), Mathf.Min(max, shockWindowLimit));
	}
}
