using UnityEngine;

public class ScavengingEntityBuilder
{
	public ScavengingEntity CreateEntityFromState(ScavengingEntitySynchronizeableState synchronizeableState)
	{
		ScavengingEntity scavengingEntity = new ScavengingEntity(synchronizeableState, synchronizeOnServer: true);
		scavengingEntity.LocalSpawnTime = Time.time;
		scavengingEntity.LocalRemoveTime = Time.time + (float)synchronizeableState.onScreenDuration;
		Debug.Log(scavengingEntity.LocalSpawnTime + " - " + scavengingEntity.LocalRemoveTime + " - " + synchronizeableState.onScreenDuration);
		return scavengingEntity;
	}

	public void UpdateExistingEntityState(ScavengingEntity entity, ScavengingEntitySynchronizeableState synchronizeableState)
	{
		entity.SynchronizeableState = synchronizeableState;
	}
}
