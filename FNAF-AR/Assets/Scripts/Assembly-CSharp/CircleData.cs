using System.Collections.Generic;

public class CircleData
{
	public const string CIRCLE_SPEED = "CircleSpeed";

	public readonly RangeData Seconds;

	public RangeData DegreesPerSecond;

	public RangeData FootstepSpeedScalar;

	public readonly RandomChanceData ChangeSpeedChance;

	public readonly RangeData TriggerPercent;

	public readonly RandomChanceData CircleChance;

	public readonly RandomChanceData ChargeChance;

	public readonly RandomChanceData PauseChance;

	public CircleData(ATTACK_DATA.Circle rawSettings)
	{
		if (rawSettings.Seconds != null)
		{
			Seconds = new RangeData(rawSettings.Seconds.Min, rawSettings.Seconds.Max);
		}
		if (rawSettings.DegreesPerSecond != null)
		{
			DegreesPerSecond = new RangeData(rawSettings.DegreesPerSecond.Min, rawSettings.DegreesPerSecond.Max);
		}
		if (rawSettings.FootstepSpeedScalar != null)
		{
			FootstepSpeedScalar = new RangeData(rawSettings.FootstepSpeedScalar.Min, rawSettings.FootstepSpeedScalar.Max);
		}
		if (rawSettings.ChangeSpeed != null)
		{
			ChangeSpeedChance = new RandomChanceData(rawSettings.ChangeSpeed.Chance, 0f);
		}
		if (rawSettings.TriggerPercent != null)
		{
			TriggerPercent = new RangeData(rawSettings.TriggerPercent.Min, rawSettings.TriggerPercent.Max);
		}
		if (rawSettings.NextPhase.Circle != null)
		{
			CircleChance = new RandomChanceData(rawSettings.NextPhase.Circle.Chance, 0f);
		}
		if (rawSettings.NextPhase.Charge != null)
		{
			ChargeChance = new RandomChanceData(rawSettings.NextPhase.Charge.Chance, rawSettings.NextPhase.Charge.Modifier);
		}
		if (rawSettings.NextPhase.Pause != null)
		{
			PauseChance = new RandomChanceData(rawSettings.NextPhase.Pause.Chance, 0f);
		}
	}

	public CircleData(CircleData circle, Dictionary<string, float> mods)
	{
		Seconds = circle.Seconds;
		DegreesPerSecond = new RangeData(circle.DegreesPerSecond, "CircleSpeed", mods);
		FootstepSpeedScalar = circle.FootstepSpeedScalar;
		ChangeSpeedChance = circle.ChangeSpeedChance;
		TriggerPercent = circle.TriggerPercent;
		CircleChance = circle.CircleChance;
		ChargeChance = circle.ChargeChance;
		PauseChance = circle.PauseChance;
	}

	public CircleData(CircleData circleToCopy)
	{
		Seconds = new RangeData(circleToCopy.Seconds.Min, circleToCopy.Seconds.Max);
		DegreesPerSecond = new RangeData(circleToCopy.DegreesPerSecond.Min, circleToCopy.DegreesPerSecond.Max);
		FootstepSpeedScalar = new RangeData(circleToCopy.FootstepSpeedScalar.Min, circleToCopy.FootstepSpeedScalar.Max);
		if (circleToCopy.ChangeSpeedChance != null)
		{
			ChangeSpeedChance = new RandomChanceData(circleToCopy.ChangeSpeedChance.Chance, 0f);
		}
		if (circleToCopy.TriggerPercent != null)
		{
			TriggerPercent = new RangeData(circleToCopy.TriggerPercent.Min, circleToCopy.TriggerPercent.Max);
		}
		if (circleToCopy.CircleChance != null)
		{
			CircleChance = new RandomChanceData(circleToCopy.CircleChance.Chance, circleToCopy.CircleChance.Modifier);
		}
		if (circleToCopy.ChargeChance != null)
		{
			ChargeChance = new RandomChanceData(circleToCopy.ChargeChance.Chance, circleToCopy.ChargeChance.Modifier);
		}
		if (circleToCopy.PauseChance != null)
		{
			PauseChance = new RandomChanceData(circleToCopy.PauseChance.Chance, circleToCopy.PauseChance.Modifier);
		}
	}

	public override string ToString()
	{
		return $"{{\"DegreesPerSecond\":{DegreesPerSecond}}}";
	}
}
