using System.Collections.Generic;

public sealed class ATTACK_DATA
{
	public class Activation
	{
		public float Chance { get; set; }

		public float Modifier { get; set; }
	}

	public class AlgorithmWeights
	{
		public int Nearest { get; set; }

		public int Median { get; set; }

		public int Furthest { get; set; }

		public int Oldest { get; set; }

		public int Newest { get; set; }

		public int Random { get; set; }
	}

	public class AllowedAngle
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class AnimatronicNoiseMeter
	{
		public float ViewingAngle { get; set; }

		public float TimeToJumpScare { get; set; }

		public float TimerDecayPerTick { get; set; }
	}

	public class AngleFromCamera
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class AutoShutdown
	{
		public string ShutdownType { get; set; }

		public int CountTrigger { get; set; }
	}

	public class Base
	{
		public float BaseDrain { get; set; }
	}

	public class Battery
	{
		public Base Base { get; set; }

		public Flashlight Flashlight { get; set; }

		public Shocker Shocker { get; set; }

		public Haywire Haywire { get; set; }
	}

	public class CameraShake
	{
		public float Magnitude { get; set; }

		public int Roughness { get; set; }

		public float FadeIn { get; set; }

		public float FadeOut { get; set; }
	}

	public class ChangeSpeed
	{
		public float Chance { get; set; }
	}

	public class Charge
	{
		public float Chance { get; set; }

		public float Modifier { get; set; }

		public Seconds Seconds { get; set; }

		public ShockWindow ShockWindow { get; set; }

		public float ShockWindowLimit { get; set; }

		public JumpscareChance JumpscareChance { get; set; }

		public JumpscareDelayTime JumpscareDelayTime { get; set; }

		public SkipJumpscareChance SkipJumpscareChance { get; set; }

		public string DeflectionAction { get; set; }

		public bool ForceCircleAfterPause { get; set; }

		public AutoShutdown AutoShutdown { get; set; }

		public bool DeflectionMustStartDuringCharge { get; set; }

		public TriggerPercent TriggerPercent { get; set; }

		public int AllowedHalfAngle { get; set; }

		public bool AddToMax { get; set; }

		public bool UseMax { get; set; }

		public GoToPause GoToPause { get; set; }

		public bool TeleportToCamera { get; set; }

		public Activation Activation { get; set; }

		public GoToCircle GoToCircle { get; set; }
	}

	public class ChargeBushingSettings
	{
		public int MaxChargeValue { get; set; }

		public InitialCharge InitialCharge { get; set; }

		public TargetChargeMin TargetChargeMin { get; set; }

		public TargetChargeMax TargetChargeMax { get; set; }

		public ToleranceAngle ToleranceAngle { get; set; }

		public FillRatePerSecond FillRatePerSecond { get; set; }

		public DecayRatePerSecond DecayRatePerSecond { get; set; }

		public NumLightsPerMeter NumLightsPerMeter { get; set; }

		public NumBrokenLightsPerMeter NumBrokenLightsPerMeter { get; set; }
	}

	public class Circle
	{
		public Seconds Seconds { get; set; }

		public DegreesPerSecond DegreesPerSecond { get; set; }

		public FootstepSpeedScalar FootstepSpeedScalar { get; set; }

		public NextPhase NextPhase { get; set; }

		public ChangeSpeed ChangeSpeed { get; set; }

		public TriggerPercent TriggerPercent { get; set; }

		public float Chance { get; set; }

		public Activation Activation { get; set; }

		public int AllowedHalfAngle { get; set; }

		public bool AddToMax { get; set; }

		public bool UseMax { get; set; }

		public GoToPause GoToPause { get; set; }

		public bool ForceCircleAfterPause { get; set; }

		public bool TeleportToCamera { get; set; }

		public GoToCircle GoToCircle { get; set; }
	}

	public class CloakDelayTime
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class Cooldown
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class Count
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class DecayRatePerSecond
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class DegreesPerSecond
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class Disruption
	{
		public Settings Settings { get; set; }

		public Shake Shake { get; set; }

		public UITarget UITarget { get; set; }

		public ScreenObjects ScreenObjects { get; set; }
	}

	public class Distance
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class DistanceFromCamera
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class DropsObjects
	{
		public Spawn Spawn { get; set; }

		public OnSuccess OnSuccess { get; set; }

		public OnFailure OnFailure { get; set; }

		public UITarget UITarget { get; set; }

		public Duration Duration { get; set; }
	}

	public class Duration
	{
		public int DropCount { get; set; }

		public string DropDurations { get; set; }
	}

	public class EncounterBurnTime
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class Entry
	{
		public string Logical { get; set; }

		public string EncounterType { get; set; }

		public string EnrageType { get; set; }

		public float WaitForCameraTime { get; set; }

		public float OfflineExpireTime { get; set; }

		public UI UI { get; set; }

		public IntroScreen IntroScreen { get; set; }

		public TeleportReposition TeleportReposition { get; set; }

		public InitialPause InitialPause { get; set; }

		public Circle Circle { get; set; }

		public Pause Pause { get; set; }

		public Glimpse Glimpse { get; set; }

		public Charge Charge { get; set; }

		public Jumpscare Jumpscare { get; set; }

		public Haywire Haywire { get; set; }

		public Disruption Disruption { get; set; }

		public Surge Surge { get; set; }

		public VisibilityAlterEffect VisibilityAlterEffect { get; set; }

		public DropsObjects DropsObjects { get; set; }

		public Battery Battery { get; set; }

		public float ShockerCooldownSeconds { get; set; }

		public string StaticProfile { get; set; }

		public Footsteps Footsteps { get; set; }

		public int NumShocksToDefeat { get; set; }

		public NoiseMeterSettings NoiseMeterSettings { get; set; }

		public LookAwayApproach LookAwayApproach { get; set; }

		public ChargeBushingSettings ChargeBushingSettings { get; set; }

		public PhantomWalk PhantomWalk { get; set; }

		public PhantomOverload PhantomOverload { get; set; }

		public PhantomPause PhantomPause { get; set; }

		public PhantomSettings PhantomSettings { get; set; }

		public EncounterTriggerSettings EncounterTriggerSettings { get; set; }

		public Environment Environment { get; set; }

		public AttackDataSlash Slash { get; set; }
	}

	public class Environment
	{
		public string Bundle { get; set; }

		public string Asset { get; set; }
	}

	public class ExpireTime
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class EncounterTriggerSettings
	{
		public string PreShutdownAction { get; set; }

		public string ShutdownAction { get; set; }

		public string DamagedAction { get; set; }

		public string SlashedAction { get; set; }
	}

	public class Fallback
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class FillRatePerSecond
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class Flashlight
	{
		public float ActivationDrain { get; set; }

		public float ActiveDrain { get; set; }
	}

	public class FlashlightDisableTime
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class Footsteps
	{
		public Walk Walk { get; set; }

		public Run Run { get; set; }
	}

	public class FootstepSpeedScalar
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class Glimpse
	{
		public float Chance { get; set; }

		public Cooldown Cooldown { get; set; }

		public Distance Distance { get; set; }

		public CloakDelayTime CloakDelayTime { get; set; }

		public ExpireTime ExpireTime { get; set; }

		public HalfAngleDeadZone HalfAngleDeadZone { get; set; }

		public HalfAngleTeleport HalfAngleTeleport { get; set; }

		public PhaseDuration PhaseDuration { get; set; }

		public RepositionDelay RepositionDelay { get; set; }
	}

	public class GoToCircle
	{
		public float Chance { get; set; }
	}

	public class GoToPause
	{
		public float Chance { get; set; }
	}

	public class HalfAngle
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class HalfAngleDeadZone
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class HalfAngleTeleport
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class Haywire
	{
		public HaywireSettings Settings { get; set; }

		public Circle Circle { get; set; }

		public Pause Pause { get; set; }

		public Charge Charge { get; set; }

		public Multiwire Multiwire { get; set; }

		public float ShockDrain { get; set; }
	}

	public class HeightOffset
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class HiddenTime
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class InitialCharge
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class InitialPause
	{
		public Seconds Seconds { get; set; }
	}

	public class IntroScreen
	{
		public string Bundle;

		public string Asset;

		public string Page1Loc;

		public string Page2Loc;

		public string Page3Loc;

		public string Page4Loc;
	}

	public class Jumpscare
	{
		public string VibrationType { get; set; }
	}

	public class JumpscareChance
	{
		public float Modifier { get; set; }

		public float Chance { get; set; }
	}

	public class JumpscareDelayTime
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class LocateTime
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class LookAwayApproach
	{
		public int ApproachSpeed { get; set; }

		public int StareDurationForBlackoutNoChargeSeconds { get; set; }

		public int StareDurationForBlackoutFullChargeSeconds { get; set; }
	}

	public class LookChangeTriggerPercent
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class ContinuousChangeTriggerInterval
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class Multiwire
	{
		public Count Count { get; set; }

		public HalfAngle HalfAngle { get; set; }

		public LocateTime LocateTime { get; set; }

		public HiddenTime HiddenTime { get; set; }
	}

	public class Multislash
	{
		public Count Count { get; set; }

		public HalfAngle HalfAngle { get; set; }

		public LocateTime LocateTime { get; set; }

		public HiddenTime HiddenTime { get; set; }
	}

	public class NextPhase
	{
		public Pause Pause { get; set; }

		public Circle Circle { get; set; }

		public Charge Charge { get; set; }

		public Glimpse Glimpse { get; set; }
	}

	public class NoiseMeterSettings
	{
		public PlayerNoiseMeter PlayerNoiseMeter { get; set; }

		public AnimatronicNoiseMeter AnimatronicNoiseMeter { get; set; }
	}

	public class NumBrokenLightsPerMeter
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class NumLightsPerMeter
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class OnFailure
	{
		public string FailureAction { get; set; }
	}

	public class OnSuccess
	{
		public string SuccessAction { get; set; }

		public int CollectCount { get; set; }
	}

	public class Pause
	{
		public float Chance { get; set; }

		public Seconds Seconds { get; set; }

		public bool UseGlimpse { get; set; }

		public NextPhase NextPhase { get; set; }

		public Activation Activation { get; set; }

		public TriggerPercent TriggerPercent { get; set; }

		public int AllowedHalfAngle { get; set; }

		public bool AddToMax { get; set; }

		public bool UseMax { get; set; }

		public GoToPause GoToPause { get; set; }

		public bool ForceCircleAfterPause { get; set; }

		public bool TeleportToCamera { get; set; }

		public GoToCircle GoToCircle { get; set; }
	}

	public class PhantomOverload
	{
		public ReactionTime ReactionTime { get; set; }

		public FlashlightDisableTime FlashlightDisableTime { get; set; }
	}

	public class PhantomPause
	{
		public Seconds Seconds { get; set; }
	}

	public class PhantomSettings
	{
		public bool UseGlobalMovement { get; set; }

		public bool AndroidOcclusionEnabled { get; set; }

		public bool AndroidOcclusionBlocksFlashlight { get; set; }
	}

	public class PhantomWalk
	{
		public EncounterBurnTime EncounterBurnTime { get; set; }

		public PhaseBurnTime PhaseBurnTime { get; set; }

		public bool ShouldHaywire { get; set; }
	}

	public class PhaseBurnTime
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class PhaseDuration
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class PlayerNoiseMeter
	{
		public float NoiseToJumpScare { get; set; }

		public float NoiseDecayPerTick { get; set; }

		public float RotationScale { get; set; }

		public int RotationExponent { get; set; }

		public int PositionExponentX { get; set; }

		public int PositionExponentY { get; set; }

		public int PositionExponentZ { get; set; }

		public int PositionScaleX { get; set; }

		public int PositionScaleY { get; set; }

		public int PositionScaleZ { get; set; }
	}

	public class ReactionTime
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class RepositionDelay
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class Root
	{
		public List<Entry> Entries { get; set; }
	}

	public class Run
	{
		public float EffectDelay { get; set; }

		public string VibrationType { get; set; }

		public CameraShake CameraShake { get; set; }
	}

	public class ScreenObjects
	{
		public int AnimationSpeed { get; set; }

		public string AnimationDurations { get; set; }

		public Cooldown Cooldown { get; set; }
	}

	public class Seconds
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class Settings
	{
		public Seconds Seconds { get; set; }

		public bool ShockCausesAttack { get; set; }

		public bool ShockCausesJumpscare { get; set; }

		public string RequiredMaskState { get; set; }

		public ShouldLookAway ShouldLookAway { get; set; }

		public float LookTime { get; set; }

		public Cooldown Cooldown { get; set; }

		public int MaxCount { get; set; }

		public ShouldLookAt ShouldLookAt { get; set; }

		public ShouldLookAtThenAway ShouldLookAtThenAway { get; set; }

		public LookChangeTriggerPercent LookChangeTriggerPercent { get; set; }

		public string Style { get; set; }

		public Activation Activation { get; set; }

		public float RampTime { get; set; }

		public float CancelTime { get; set; }

		public string CancelAction { get; set; }

		public float BatteryDrainRateBase { get; set; }

		public float BatteryDrainRateCancel { get; set; }

		public float BlinkDuration { get; set; }

		public float MaskLightFadeTime { get; set; }

		public string HapticCue { get; set; }

		public bool WhileCircling { get; set; }

		public bool WhilePaused { get; set; }

		public float YOffset { get; set; }

		public int Distance { get; set; }
	}

	public class HaywireSettings
	{
		public Seconds Seconds { get; set; }

		public bool ShockCausesAttack { get; set; }

		public bool ShockCausesJumpscare { get; set; }

		public bool CoverEyes { get; set; }

		public string RequiredMaskState { get; set; }

		public ShouldLookAway ShouldLookAway { get; set; }

		public float LookTime { get; set; }

		public int Cooldown { get; set; }

		public int MaxCount { get; set; }

		public ShouldLookAt ShouldLookAt { get; set; }

		public ShouldLookAtThenAway ShouldLookAtThenAway { get; set; }

		public ShouldLookContinuous ShouldLookContinuous { get; set; }

		public LookChangeTriggerPercent LookChangeTriggerPercent { get; set; }

		public ContinuousChangeTriggerInterval ContinuousChangeTriggerInterval { get; set; }

		public string Style { get; set; }

		public Activation Activation { get; set; }

		public float RampTime { get; set; }

		public float CancelTime { get; set; }

		public string CancelAction { get; set; }

		public float BatteryDrainRateBase { get; set; }

		public float BatteryDrainRateCancel { get; set; }

		public float BlinkDuration { get; set; }

		public float MaskLightFadeTime { get; set; }

		public string HapticCue { get; set; }

		public bool WhileCircling { get; set; }

		public bool WhilePaused { get; set; }

		public float YOffset { get; set; }

		public int Distance { get; set; }
	}

	public class SlashSettings
	{
		public float Seconds { get; set; }

		public int Cooldown { get; set; }

		public int MaxCount { get; set; }
	}

	public class Shake
	{
		public ShakeMagnitude ShakeMagnitude { get; set; }

		public float ShakeGraceTime { get; set; }
	}

	public class ShakeMagnitude
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class Shocker
	{
		public float ActivationDrain { get; set; }

		public float ActiveDrain { get; set; }
	}

	public class ShockWindow
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class ShouldLookAt
	{
		public float Chance { get; set; }
	}

	public class ShouldLookAtThenAway
	{
		public float Chance { get; set; }

		public float Modifier { get; set; }
	}

	public class ShouldLookAway
	{
		public float Chance { get; set; }
	}

	public class ShouldLookContinuous
	{
		public float Chance { get; set; }
	}

	public class SkipJumpscareChance
	{
		public float Modifier { get; set; }

		public float Chance { get; set; }
	}

	public class AttackDataSlash
	{
		public SlashSettings Settings { get; set; }

		public Circle Circle { get; set; }

		public Pause Pause { get; set; }

		public Multislash Multislash { get; set; }
	}

	public class Spawn
	{
		public string SpawnType { get; set; }

		public AlgorithmWeights AlgorithmWeights { get; set; }

		public Cooldown Cooldown { get; set; }

		public Fallback Fallback { get; set; }

		public string BlacklistedPhases { get; set; }

		public string TemplateBundleName { get; set; }

		public string TemplateAssetName { get; set; }

		public AllowedAngle AllowedAngle { get; set; }

		public Distance Distance { get; set; }

		public HeightOffset HeightOffset { get; set; }

		public int MaxConcurrentObjects { get; set; }
	}

	public class Surge
	{
		public Settings Settings { get; set; }
	}

	public class TargetChargeMin
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class TargetChargeMax
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class TeleportReposition
	{
		public AngleFromCamera AngleFromCamera { get; set; }

		public DistanceFromCamera DistanceFromCamera { get; set; }
	}

	public class ToleranceAngle
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class TriggerPercent
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class UI
	{
		public bool UseShocker { get; set; }

		public bool UseFlashlight { get; set; }

		public bool UseMask { get; set; }

		public bool ShowRemnant { get; set; }

		public bool ShowCollection { get; set; }

		public bool UsePlayerNoiseMeter { get; set; }

		public bool UseAnimatronicNoiseMeter { get; set; }

		public bool UseContinuousShocker { get; set; }

		public bool UseSwapper { get; set; }

		public bool ShowBillboard { get; set; }
	}

	public class UITarget
	{
		public string UITargetType { get; set; }

		public UITargetRange UITargetRange { get; set; }

		public float UITargetDuration { get; set; }
	}

	public class UITargetRange
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class VisibilityAlterEffect
	{
		public Settings Settings { get; set; }
	}

	public class Walk
	{
		public float EffectDelay { get; set; }

		public string VibrationType { get; set; }

		public CameraShake CameraShake { get; set; }
	}
}
