public class ResultsDataModel
{
	private MasterDomain masterDomain;

	public bool resultDirty { get; set; }

	public EncounterResult encounterResult { get; set; }

	public RewardDataV3 rewardDataV3 { get; set; }

	public ResultsDataModel(MasterDomain masterDomain)
	{
		this.masterDomain = masterDomain;
	}

	public void SetEncounterResult(EncounterResult result, RewardDataV3 rewardDataV3)
	{
		resultDirty = true;
		encounterResult = result;
		this.rewardDataV3 = rewardDataV3;
	}

	public void CleanEncounterResult()
	{
		rewardDataV3 = null;
		resultDirty = false;
	}
}
