using System;

[Serializable]
public class OriginData
{
	[Serializable]
	public enum OriginState
	{
		NoState = -1,
		RandomSpawn = 0,
		Lure = 1,
		EssenceEncounter = 2,
		Scavenge = 3,
		Sent = 4,
		Tutorial = 5,
		MapEntitySystem = 6,
		COUNT = 7
	}

	public OriginState originState { get; set; }

	public OriginData()
	{
		originState = OriginState.RandomSpawn;
	}

	public OriginData(OriginData originData)
	{
		originState = originData.originState;
	}

	public OriginData(OriginState originState)
	{
		this.originState = originState;
	}

	public override string ToString()
	{
		return originState.ToString();
	}
}
