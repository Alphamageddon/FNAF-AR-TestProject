using System.Collections.Generic;

public class RewardDataV3
{
	public List<RewardItem> modRewardList;

	public List<RewardItem> currencyRewardList;

	public Dictionary<string, List<RewardItem>> animatronicRewardTable;

	public List<RewardItem> cpuRewardList;

	public int essenceOnLoss;

	public RewardDataV3()
	{
		modRewardList = new List<RewardItem>();
		currencyRewardList = new List<RewardItem>();
		animatronicRewardTable = new Dictionary<string, List<RewardItem>>();
		cpuRewardList = new List<RewardItem>();
	}

	public RewardDataV3(RewardDataV3 rewardDataV3)
	{
		modRewardList = new List<RewardItem>();
		currencyRewardList = new List<RewardItem>();
		animatronicRewardTable = new Dictionary<string, List<RewardItem>>();
		cpuRewardList = new List<RewardItem>();
		foreach (RewardItem modReward in rewardDataV3.modRewardList)
		{
			modRewardList.Add(modReward);
		}
		foreach (RewardItem currencyReward in rewardDataV3.currencyRewardList)
		{
			currencyRewardList.Add(currencyReward);
		}
		foreach (RewardItem cpuReward in rewardDataV3.cpuRewardList)
		{
			cpuRewardList.Add(cpuReward);
		}
		foreach (string key in rewardDataV3.animatronicRewardTable.Keys)
		{
			animatronicRewardTable.Add(key, rewardDataV3.animatronicRewardTable[key]);
		}
		essenceOnLoss = rewardDataV3.essenceOnLoss;
	}
}
