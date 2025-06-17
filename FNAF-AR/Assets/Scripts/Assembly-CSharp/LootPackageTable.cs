public class LootPackageTable
{
	public string Table;

	public int Rolls;

	public float ProcRate;

	public LootPackageTable(LOOT_PACKAGE_DATA.table rawTableData)
	{
		if (rawTableData != null)
		{
			if (rawTableData.Table == null)
			{
				Table = rawTableData.Table;
			}
			Rolls = rawTableData.Rolls;
			ProcRate = (float)rawTableData.ProcRate;
		}
	}
}
