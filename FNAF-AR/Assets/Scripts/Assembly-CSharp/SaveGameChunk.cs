using System;

[Serializable]
public class SaveGameChunk
{
	public string entityId { get; set; }

	public StateData stateData { get; set; }

	public OriginData originData { get; set; }

	public AttackSequenceData AttackSequenceData { get; set; }

	public EndoskeletonData endoskeletonData { get; set; }

	public RewardDataV3 rewardDataV3 { get; set; }

	public int wearAndTear { get; set; }
}
