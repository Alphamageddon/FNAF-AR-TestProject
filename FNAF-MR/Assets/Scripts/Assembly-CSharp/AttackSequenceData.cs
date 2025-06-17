using System;

[Serializable]
public class AttackSequenceData
{
	public long encounterStartTime { get; set; }

	public bool attackSequenceComplete { get; set; }

	public float accumulatedOfflineTime { get; set; }

	public AttackSequenceData()
	{
		attackSequenceComplete = false;
		encounterStartTime = 0L;
	}

	public AttackSequenceData(AttackSequenceData attackSequenceData)
	{
		attackSequenceComplete = attackSequenceData.attackSequenceComplete;
		encounterStartTime = attackSequenceData.encounterStartTime;
	}

	public AttackSequenceData(bool attackSequenceComplete, long encounterStartTime)
	{
		this.attackSequenceComplete = attackSequenceComplete;
		this.encounterStartTime = encounterStartTime;
	}

	public override string ToString()
	{
		return attackSequenceComplete.ToString() + encounterStartTime;
	}
}
