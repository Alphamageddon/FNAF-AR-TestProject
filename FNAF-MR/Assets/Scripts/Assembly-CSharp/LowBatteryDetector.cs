public static class LowBatteryDetector
{
	private static EncounterType[] AllowedTypes;

	public static bool ShouldCharge(Blackboard blackboard)
	{
		if (blackboard.Systems == null)
		{
			return false;
		}
		if (!ShouldChargeInEncounterType(blackboard.AttackProfile.EncounterType))
		{
			return false;
		}
		if (blackboard.Systems.Battery.Charge > blackboard.AttackProfile.Battery.ShockerActivationDrain)
		{
			return false;
		}
		if (blackboard.Systems.Battery.IsExtraBatteryAvailableForUse())
		{
			return false;
		}
		if (blackboard.Systems.Battery.IsExtraBatteryActive())
		{
			return false;
		}
		return true;
	}

	private static bool ShouldChargeInEncounterType(EncounterType encounterType)
	{
		EncounterType[] allowedTypes = AllowedTypes;
		for (int i = 0; i < allowedTypes.Length; i++)
		{
			if (allowedTypes[i] == encounterType)
			{
				return true;
			}
		}
		return false;
	}

	static LowBatteryDetector()
	{
		AllowedTypes = new EncounterType[2]
		{
			EncounterType.TagTeam,
			EncounterType.Standard
		};
	}
}
