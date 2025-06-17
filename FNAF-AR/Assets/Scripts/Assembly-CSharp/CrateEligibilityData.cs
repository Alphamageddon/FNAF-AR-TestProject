using System;

public class CrateEligibilityData
{
	public enum EligibilityType
	{
		PlayerLevel = 0,
		PlayerMaskLevel = 1,
		PlayerGatherLevel = 2,
		PlayerConstructionLevel = 3,
		AnimatronicConstructionLevel = 4,
		AnimatronicAugmentLevel = 5,
		AnimatronicPerception = 6,
		AnimatronicAggression = 7,
		AnimatronicGatherRate = 8,
		AnimatronicStrength = 9,
		AnimatronicPieceRequirement = 10,
		StartDate = 11,
		EndDate = 12,
		Default = 13,
		TotalRemnant = 14,
		WearAndTear = 15,
		AnimatronicLogical = 16
	}

	public enum EligibilityOperator
	{
		GreaterThan = 0,
		LessThan = 1,
		Range = 2,
		Equals = 3,
		EqualsString = 4,
		None = 5
	}

	public readonly EligibilityType Type;

	public readonly EligibilityOperator Operator;

	public readonly string StringValue;

	public readonly int NumberValue;

	public readonly int RangeMin;

	public readonly int RangeMax;

	public CrateEligibilityData(LOOT_STRUCTURE_DATA.Eligibility rawEligibilityData)
	{
		if (rawEligibilityData != null)
		{
			if (rawEligibilityData.LimitId != null)
			{
				Type = GetTypeFromString(rawEligibilityData.LimitId);
			}
			if (rawEligibilityData.Operator != null)
			{
				Operator = GetOperatorFromString(rawEligibilityData.Operator);
			}
			RangeMin = rawEligibilityData.RangeMin;
			RangeMax = rawEligibilityData.RangeMax;
			NumberValue = rawEligibilityData.NumberValue;
			StringValue = ((rawEligibilityData.StringValue == null) ? "" : rawEligibilityData.StringValue);
		}
	}

	public EligibilityType GetTypeFromString(string typeString)
	{
		if (Enum.TryParse<EligibilityType>(typeString, out var result))
		{
			return result;
		}
		return EligibilityType.Default;
	}

	public EligibilityOperator GetOperatorFromString(string operatorString)
	{
		if (Enum.TryParse<EligibilityOperator>(operatorString, out var result))
		{
			return result;
		}
		return EligibilityOperator.None;
	}
}
