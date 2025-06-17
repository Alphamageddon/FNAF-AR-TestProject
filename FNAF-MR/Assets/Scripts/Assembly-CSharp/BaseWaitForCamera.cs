public abstract class BaseWaitForCamera : Phase
{
	public override AttackPhase AttackPhase => AttackPhase.WaitForCamera;

	protected void RunSharedEnterPhase()
	{
		Blackboard.Systems.AttackStatic.Container.ClearPhaseStaticSettings(Blackboard.EntityId);
		Blackboard.Model.SetTransformOverrideMode(TransformOverrider.Mode.AttackLocal);
		Blackboard.Model.SetFootstepConfig(Blackboard.AttackProfile.Footsteps.Walk, Blackboard.AttackProfile.Footsteps.Run);
		Blackboard.Model.Teleport(0f, 10000f, faceCamera: false);
	}

	protected void RunSharedExitPhase()
	{
		if (!Blackboard.AttackProfile.AttackUIData.UseSwapper)
		{
			Blackboard.Systems.NoiseMechanic.StartSystem(Blackboard.AttackProfile.AttackUIData, Blackboard.AttackProfile.NoiseMeter, Blackboard);
		}
	}

	private void RunSwapperSharedExitPhase()
	{
		Blackboard.Systems.NoiseMechanic.StartSystem(Blackboard.AttackProfile.AttackUIData, Blackboard.AttackProfile.NoiseMeter, Blackboard);
	}
}
