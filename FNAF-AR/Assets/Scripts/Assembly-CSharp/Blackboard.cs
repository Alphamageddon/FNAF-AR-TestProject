using UnityEngine;

public class Blackboard
{
	public AttackPhase Phase { get; set; }

	public bool IsAttackPhaseInactive => (Phase == AttackPhase.Shutdown) | (Phase == AttackPhase.InitialPause);

	public int NumShocksRemaining { get; set; }

	public bool InShockableWindow { get; set; }

	public bool HasDefeatedAllAnimatronics => NumAnimatronicsRemaining < 1;

	public int NumAnimatronicsRemaining { get; set; }

	public AnimatronicDefeatedCallback OnAnimatronicDefeated { get; set; }

	public HasAnimatronicToActivate HasAnimatronicToActivate { get; set; }

	public ActivateNextAnimatronic ActivateNextAnimatronic { get; set; }

	public string EntityId { get; set; }

	public Animatronic3D Model { get; set; }

	public AttackAnimatronicExternalSystems Systems { get; set; }

	public bool IsExpressDelivery { get; set; }

	public StaticConfig StaticConfig { get; set; }

	public AttackProfile AttackProfile { get; set; }

	public PlushSuitData PlushSuitData { get; set; }

	public HaywireGlobalState HaywireState { get; set; }

	public SlashGlobalState SlashState { get; set; }

	public ScavengingGlobalState ScavengingState { get; set; }

	public bool HasEnteredCameraMode { get; set; }

	public float SignedAngleFromCamera { get; set; }

	public float AbsoluteAngleFromCamera { get; set; }

	public float DistanceFromCamera { get; set; }

	public bool IsAABBOnScreen { get; set; }

	public bool IsOnScreen { get; set; }

	public int DroppedObjectsCollected { get; set; }

	public bool ForceCharge { get; set; }

	public bool ForceJumpscare { get; set; }

	public bool ForceFrontalCharge { get; set; }

	public bool ResetPausePhaseChangeGroup { get; set; }

	public bool FreezeStaticAngle { get; set; }

	public Vector3 FrozenStaticPosition { get; set; }

	public bool ShouldCheckForDirectionChange { get; set; }

	public bool ShockedDuringHaywire { get; set; }

	public bool ShockedDuringSlash { get; set; }

	public bool ForceCircleAfterPause { get; set; }

	public bool PhantomOverloadRequested { get; set; }

	public bool PhantomRepositionRequested { get; set; }

	public EncounterType EncounterType { get; set; }

	public ScavengingAttackProfile ScavengingAttackProfile { get; set; }

	public bool IsScavenging { get; set; }

	public ScavengingData ScavengingData { get; set; }

	public bool ShockedDuringScavenging { get; set; }

	public void Teardown()
	{
		HaywireState = null;
		SlashState = null;
		ScavengingState = null;
		Model = null;
		Systems = null;
		StaticConfig = null;
		AttackProfile = null;
		ScavengingAttackProfile = null;
	}
}
