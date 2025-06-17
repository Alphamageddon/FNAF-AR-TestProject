using UnityEngine;

public class ScavengingResults : Phase
{
	private bool sceneUnloaded;

	public override AttackPhase AttackPhase => AttackPhase.Results;

	protected override void EnterPhase()
	{
		Blackboard.Systems.AttackStatic.Container.ClearPhaseStaticSettings(Blackboard.EntityId);
		Blackboard.Systems.Flashlight.SetFlashlightState(setOn: false, shouldPlayAudio: false);
		Blackboard.Model.StopMoving();
		ReleaseEnvironmentAssets();
	}

	protected override AttackPhase UpdatePhase()
	{
		if (sceneUnloaded)
		{
			return AttackPhase.ReadyForCleanup;
		}
		return AttackPhase.Null;
	}

	protected override void ExitPhase()
	{
		sceneUnloaded = false;
		Blackboard.Systems.Encounter.ReadyForUi();
	}

	private void ReleaseEnvironmentAssets()
	{
		if (Blackboard.Systems.ScavengingEnvironment == null)
		{
			sceneUnloaded = true;
			return;
		}
		Blackboard.Systems.ScavengingEnvironment = null;
		string bundle = Blackboard.ScavengingData.Environment.Bundle;
		string asset = Blackboard.ScavengingData.Environment.Asset;
		MasterDomain.GetDomain().GameAssetManagementDomain.AssetCacheAccess.UnloadScene(bundle, asset, SceneUnloaded);
	}

	private void SceneUnloaded()
	{
		Debug.Log("Successfully unloaded additive scene. I hope.");
		sceneUnloaded = true;
	}
}
