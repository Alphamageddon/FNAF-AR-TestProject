using System;
using System.Collections.Generic;

public class GameUIMasterDataConnector
{
	private MODCATEGORIES_DATA.Root MODCATEGORIES_MASTER_DATA;

	public Dictionary<ModCategory, int> ModCategorySortWeights { get; set; }

	private MasterDataDomain _masterDataDomain { get; }

	public GameUIMasterDataConnector(MasterDataDomain masterDataDomain)
	{
		ModCategorySortWeights = new Dictionary<ModCategory, int>();
		_masterDataDomain = masterDataDomain;
		masterDataDomain.GetAccessToData.GetModCategoryDataAsync(ReceivedMasterData);
	}

	private void ReceivedMasterData(MODCATEGORIES_DATA.Root alertData)
	{
		MODCATEGORIES_MASTER_DATA = alertData;
		FixupModCetgorySortOrder();
	}

	private void FixupFromMasterData()
	{
		FixupModCetgorySortOrder();
	}

	private void FixupModCetgorySortOrder()
	{
		foreach (MODCATEGORIES_DATA.Entry entry in MODCATEGORIES_MASTER_DATA.Entries)
		{
			ModCategory key = (ModCategory)Enum.Parse(typeof(ModCategory), entry.ModCatLogical);
			ModCategorySortWeights.Add(key, entry.Order);
		}
	}
}
