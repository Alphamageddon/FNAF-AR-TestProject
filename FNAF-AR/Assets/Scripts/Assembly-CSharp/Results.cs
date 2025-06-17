using UnityEngine;

public class Results : Phase
{
	private bool sceneUnloaded;

	public override AttackPhase AttackPhase => AttackPhase.Results;

	protected override void EnterPhase()
	{
		Blackboard.Systems.AttackStatic.Container.ClearPhaseStaticSettings(Blackboard.EntityId);
		Blackboard.Systems.Flashlight.SetFlashlightState(setOn: false, shouldPlayAudio: false);
		Blackboard.Model.StopMoving();
		ReleaseEnvironmentAssets();
		void ReleaseEnvironmentAssets()
		{
			if (Blackboard.Systems.EncounterEnvironment == null)
			{
				sceneUnloaded = true;
			}
			else
			{
				Blackboard.Systems.EncounterEnvironment = null;
				string bundle = Blackboard.AttackProfile.Environment.Bundle;
				string asset = Blackboard.AttackProfile.Environment.Asset;
				MasterDomain.GetDomain().GameAssetManagementDomain.AssetCacheAccess.UnloadScene(bundle, asset, SceneUnloaded);
			}
		}
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

	private void SceneUnloaded()
	{
		Debug.Log("Successfully unloaded additive scene. I hope.");
		sceneUnloaded = true;
	}
}
