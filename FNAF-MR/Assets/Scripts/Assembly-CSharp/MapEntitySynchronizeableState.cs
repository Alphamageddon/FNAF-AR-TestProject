using System.Collections.Generic;

public class MapEntitySynchronizeableState
{
	public int aggression;

	public int perception;

	public int durability;

	public int attack;

	public string entityId { get; set; }

	public MapEntityType entityClass { get; set; }

	public long spawnTimeStamp { get; set; }

	public long removeTimeStamp { get; set; }

	public long onScreenDuration { get; set; }

	public RevealedBy revealedBy { get; set; }

	public bool isRevealed => revealedBy != RevealedBy.None;

	public MapEntityHistory history { get; set; }

	public Dictionary<string, string> parts { get; set; }

	public int legacyEssence { get; set; }

	public Dictionary<string, float> remnantSpawnWeights { get; set; }

	public RewardDataV3 rewards { get; set; }

	public string lootStructureId { get; set; }

	public bool IsLegacy()
	{
		return true;
	}
}
