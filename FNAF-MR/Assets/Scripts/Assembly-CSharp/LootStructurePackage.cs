public class LootStructurePackage
{
	public CrateEligibilityData Eligibility;

	public string LootPackage;

	public LootStructurePackage(LOOT_STRUCTURE_DATA.lootPackage rawLootPackageData)
	{
		if (rawLootPackageData != null)
		{
			if (rawLootPackageData.Eligibility != null)
			{
				Eligibility = new CrateEligibilityData(rawLootPackageData.Eligibility);
			}
			if (rawLootPackageData.LootPackage != null)
			{
				LootPackage = rawLootPackageData.LootPackage;
			}
		}
	}
}
