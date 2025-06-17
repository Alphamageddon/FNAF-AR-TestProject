using System.Collections.Generic;

public sealed class CONFIG_DATA
{
	public class AccountOSLogin
	{
		public bool AppleLogin { get; set; }
	}

	public class Ads
	{
		public Tapjoy Tapjoy { get; set; }
	}

	public class AnimatronicAlerts
	{
		public int AnimatronicAlertPeriodSec { get; set; }

		public double AnimatronicAlertCheckChance { get; set; }

		public int AnimatronicAlertCooldownSec { get; set; }
	}

	public class AnimatronicSpawning
	{
		public int SpawnPeriod { get; set; }

		public double SpawnChance { get; set; }

		public int MapSpawnPeriod { get; set; }

		public double MapSpawnChance { get; set; }

		public int SpawnMaxDeployed { get; set; }

		public double LuredAnimatronicShieldCap { get; set; }

		public double LuredAnimatronicAttackCap { get; set; }
	}

	public class Approach
	{
		public int NumberTotalApproachNodes { get; set; }

		public int MaxTotalApproachNodes { get; set; }

		public int NumberShockablePositionsUsed { get; set; }
	}

	public class ArtAssets
	{
		public Audio Audio { get; set; }

		public UI UI { get; set; }
	}

	public class Audio
	{
		public string MusicBundle { get; set; }

		public string MusicSoundBank { get; set; }

		public string SharedBundle { get; set; }

		public string SharedSoundBank { get; set; }

		public string UIBundle { get; set; }

		public string UISoundBank { get; set; }
	}

	public class AutoWarmRestart
	{
		public TimeTrigger TimeTrigger { get; set; }
	}

	public class BatteryBehavior
	{
		public double BatteryBaseRecharge { get; set; }

		public double EssenceFlashlightDrain { get; set; }

		public int AllowedExtraBatteries { get; set; }
	}

	public class Billboard
	{
		public int ShowDuration { get; set; }

		public double HideDuration { get; set; }
	}

	public class Blackout
	{
		public int StareDurationForBlackoutNoChargeSeconds { get; set; }

		public int StareDurationForBlackoutFullChargeSeconds { get; set; }

		public int BlackoutPhaseDurationSeconds { get; set; }

		public double EmergencyLightPhaseDurationSeconds { get; set; }

		public int NoChargeEmergencyLightTimeoutSeconds { get; set; }

		public double NoChargePhaseTimeoutModifier { get; set; }
	}

	public class CloakDecloak
	{
		public double CenterOfScreenMinX { get; set; }

		public double CenterOfScreenMaxX { get; set; }

		public double CenterOfScreenMinY { get; set; }

		public double CenterOfScreenMaxY { get; set; }
	}

	public class Connections
	{
		public int Min { get; set; }

		public int Max { get; set; }
	}

	public class CpuIds
	{
		public string GoldenFreddy { get; set; }
	}

	public class DailyAlerts
	{
		public int DailyAlertPeriodSec { get; set; }

		public double DailyAlertCheckChance { get; set; }
	}

	public class DailyChallenges
	{
		public bool Enable { get; set; }

		public ResetSingleChallenge ResetSingleChallenge { get; set; }

		public string LootStructureId { get; set; }

		public string EventLootStructureId { get; set; }

		public int CostOfFazCoinsPerHourToReduceRefreshTime { get; set; }

		public int TimeInBetweenPopupRemindersInHours { get; set; }
	}

	public class DepthAPI
	{
		public bool EnableIfPreferedDevice { get; set; }
	}

	public class Detect
	{
		public int ObjectDetectionPeriod { get; set; }

		public double EssenceTrailDur { get; set; }

		public int EssenceObjectDur { get; set; }

		public double BaseDisplayChance { get; set; }

		public int HorizonBuffer { get; set; }

		public double Confidence { get; set; }

		public int OverrideCooldown { get; set; }

		public int GlobalCooldown { get; set; }

		public int CategoryCooldown { get; set; }

		public int CategoryStreakbreaker { get; set; }

		public int DistanceFromCamera { get; set; }

		public int ARObjectToEssenceDelay { get; set; }
	}

	public class Entry
	{
		public AnimatronicAlerts AnimatronicAlerts { get; set; }

		public PassiveAlerts PassiveAlerts { get; set; }

		public DailyAlerts DailyAlerts { get; set; }

		public ShockerBehavior ShockerBehavior { get; set; }

		public BatteryBehavior BatteryBehavior { get; set; }

		public AnimatronicSpawning AnimatronicSpawning { get; set; }

		public NodePlacement NodePlacement { get; set; }

		public EssenceCollection EssenceCollection { get; set; }

		public Scavenging Scavenging { get; set; }

		public Glitching Glitching { get; set; }

		public PvP PvP { get; set; }

		public Rampage Rampage { get; set; }

		public NumAnimatronics NumAnimatronics { get; set; }

		public PlayerFacingText PlayerFacingText { get; set; }

		public Workshop Workshop { get; set; }

		public ArtAssets ArtAssets { get; set; }

		public ExpressDelivery ExpressDelivery { get; set; }

		public InboxBatchLimits InboxBatchLimits { get; set; }

		public Ads Ads { get; set; }

		public DailyChallenges DailyChallenges { get; set; }

		public AutoWarmRestart AutoWarmRestart { get; set; }

		public DepthAPI DepthAPI { get; set; }

		public MapEntities MapEntities { get; set; }

		public LookAwayApproach LookAwayApproach { get; set; }

		public PhotoBooth PhotoBooth { get; set; }

		public MultiAnimatronic MultiAnimatronic { get; set; }

		public AccountOSLogin AccountOSLogin { get; set; }
	}

	public class EssenceCollection
	{
		public Detect Detect { get; set; }

		public Phantasm Phantasm { get; set; }

		public CloakDecloak CloakDecloak { get; set; }

		public GeigerCounter GeigerCounter { get; set; }

		public ParticleVacuum ParticleVacuum { get; set; }

		public Motes Motes { get; set; }

		public ThreatPills ThreatPills { get; set; }

		public ThreatCollection ThreatCollection { get; set; }
	}

	public class ExpressDelivery
	{
		public int CostFazCoins { get; set; }
	}

	public class FlickeringLights
	{
		public double LightFlickerTimeSeconds { get; set; }

		public double AverageDelayBetweenFlickersNoChargeSeconds { get; set; }

		public int AverageDelayBetweenFlickersFullChargeSeconds { get; set; }
	}

	public class GeigerCounter
	{
		public int MaxAngleDetect { get; set; }

		public double MinTickInSeconds { get; set; }

		public int MaxTickInSeconds { get; set; }
	}

	public class Glitch
	{
		public int Min { get; set; }

		public int Max { get; set; }
	}

	public class Glitching
	{
		public Glitch Glitch { get; set; }
	}

	public class InboxBatchLimits
	{
		public int MaxDelete { get; set; }

		public int MaxSetToRead { get; set; }
	}

	public class Interaction
	{
		public int JammerCost { get; set; }

		public double ScanningDuration { get; set; }

		public int PerceptionPeriod { get; set; }

		public int AggressionThreshold { get; set; }

		public double StatBarFillDurationSeconds { get; set; }

		public int PostStarBarFillDelaySeconds { get; set; }

		public int AlertMessageDurationSeconds { get; set; }

		public int LootBoxAutoOpenDelaySeconds { get; set; }
	}

	public class LookAwayApproach
	{
		public Approach Approach { get; set; }

		public FlickeringLights FlickeringLights { get; set; }

		public Blackout Blackout { get; set; }
	}

	public class MapEntities
	{
		public Interaction Interaction { get; set; }

		public Movement Movement { get; set; }

		public Server Server { get; set; }
	}

	public class Motes
	{
		public int MoteLifetime { get; set; }

		public int StartingNumberOfMotes { get; set; }

		public int MaxMotesPerEssence { get; set; }

		public double MinOrbitRadius { get; set; }

		public double MaxOrbitRadius { get; set; }

		public int SpawnTime { get; set; }

		public int MaxVisibleMotesPerEssence { get; set; }

		public int MinAngleSpeedDegrees { get; set; }

		public int MaxAngleSpeedDegrees { get; set; }

		public double MaximumDetachedSpeed { get; set; }

		public int DetachedAcceleration { get; set; }

		public int DetachedDeceleration { get; set; }

		public int MaxDegradeMultiplier { get; set; }

		public int MinDegradeMultiplier { get; set; }

		public int MaxDegradeDistance { get; set; }

		public int CollectFlushBatchTime { get; set; }

		public double CollectTimeToWaitToSeeIfMoreMotesComingIn { get; set; }
	}

	public class Movement
	{
		public int MoveNodeDuration { get; set; }

		public int BlinkDuration { get; set; }

		public double BlinkInvisibleDuration { get; set; }

		public int DesiredEntityCount { get; set; }
	}

	public class MultiAnimatronic
	{
		public int NumCpuPerEncounter { get; set; }

		public CpuIds CpuIds { get; set; }

		public Billboard Billboard { get; set; }
	}

	public class NodePlacement
	{
		public Connections Connections { get; set; }

		public int PrefNodeToNodeDist { get; set; }
	}

	public class Notifications
	{
		public string ToTargetOnFail { get; set; }

		public string ToTargetOnSucc { get; set; }

		public string ToSenderOnFail { get; set; }

		public string ToSenderOnSucc { get; set; }
	}

	public class NumAnimatronics
	{
		public int NumAnimatronicsNormal { get; set; }

		public int NumAnimatronicsMalfunctioning { get; set; }
	}

	public class ParticleVacuum
	{
		public double DetachFrequency { get; set; }

		public int MaximumDetached { get; set; }

		public double CollectDistance { get; set; }

		public double CollectDistanceMote { get; set; }

		public double CollectDistanceThreat { get; set; }

		public double CollectionScreenPointX { get; set; }

		public double CollectionScreenPointY { get; set; }
	}

	public class Parts
	{
		public int Min { get; set; }

		public int Max { get; set; }
	}

	public class PassiveAlerts
	{
		public int PassiveAlertPeriodSec { get; set; }

		public int PassiveAlertCooldownSec { get; set; }
	}

	public class Phantasm
	{
		public int Period { get; set; }

		public int Cooldown { get; set; }
	}

	public class PhotoBooth
	{
		public string UnlockId { get; set; }
	}

	public class PlayerFacingText
	{
		public string PartsDescription { get; set; }
	}

	public class PvP
	{
		public Notifications Notifications { get; set; }
	}

	public class Rampage
	{
		public int Min { get; set; }

		public int Max { get; set; }
	}

	public class ResetSingleChallenge
	{
		public int Cost { get; set; }

		public int NumberOfResetsAllowedPerCycle { get; set; }
	}

	public class Root
	{
		public List<Entry> Entries { get; set; }
	}

	public class Scavenging
	{
		public int MaxDeployed { get; set; }

		public int Period { get; set; }

		public int Malfunction { get; set; }

		public int WearAndTearChance { get; set; }

		public WearAndTearDamage WearAndTearDamage { get; set; }

		public double RareRewardChance { get; set; }

		public double PlushSuitChance { get; set; }

		public int CommonRewardChance { get; set; }

		public Parts Parts { get; set; }
	}

	public class Server
	{
		public int PopulationTimeRangeSeconds { get; set; }

		public int EntityServerLifespanHours { get; set; }

		public int EntityRetireDurationMinutes { get; set; }

		public int EntityToFarInFutureHours { get; set; }

		public int LootBoxRetireDurationMinutes { get; set; }

		public int ClientBatchedRetireEventPeriodSeconds { get; set; }
	}

	public class ShockerBehavior
	{
		public int ShockerCooldownTimer { get; set; }
	}

	public class Tapjoy
	{
		public bool IsEnabled { get; set; }

		public bool UseFinalRewardDialog { get; set; }

		public string EnabledPlacements { get; set; }

		public int AwardCap { get; set; }

		public int EntryTimeout { get; set; }

		public int MaxCurrencyAllowed { get; set; }
	}

	public class ThreatCollection
	{
		public double ThreatPercentPerThreatPill { get; set; }

		public double ConsecutiveThreatPercentMult { get; set; }

		public double DropPerSecond { get; set; }
	}

	public class ThreatPills
	{
		public int ThreatPillLifetime { get; set; }

		public int MaxThreatPillsPerEssence { get; set; }

		public double MinOrbitRadius { get; set; }

		public double MaxOrbitRadius { get; set; }

		public double SpawnTime { get; set; }

		public int MaxVisibleThreatPillsPerEssence { get; set; }

		public int MinAngleSpeedDegrees { get; set; }

		public int MaxAngleSpeedDegrees { get; set; }

		public double MaximumDetachedSpeed { get; set; }

		public int DetachedAcceleration { get; set; }

		public int DetachedDeceleration { get; set; }

		public int MaxDegradeMultiplier { get; set; }

		public int MinDegradeMultiplier { get; set; }

		public int MaxDegradeDistance { get; set; }
	}

	public class TimeTrigger
	{
		public bool BackgroundTimeTriggerEnabled { get; set; }

		public bool SessionTimeTriggerEnabled { get; set; }

		public int MaxBackgroundedTime { get; set; }

		public int MaxSessionTime { get; set; }
	}

	public class UI
	{
		public string CpuIconsBundle { get; set; }

		public string ModIconsBundle { get; set; }

		public string PlushSuitIconsBundle { get; set; }

		public string PortraitIconsBundle { get; set; }

		public string RewardIconsBundle { get; set; }

		public string StoreIconsBundle { get; set; }

		public string ShopUIIconsBundle { get; set; }

		public string OneOffScriptedIconsBundle { get; set; }

		public string DailyChallengesIconBundle { get; set; }

		public string ProfileAvatarIconBundle { get; set; }

		public string ProfileAvatarMapBundle { get; set; }

		public string EssenceRewardIconName { get; set; }

		public string PartsRewardIconName { get; set; }

		public string FazCoinsRewardIconName { get; set; }

		public string EndoskeletonSlotRewardIconName { get; set; }

		public string ModSlotRewardIconName { get; set; }

		public string CrateIconName { get; set; }

		public string PhotoboothFrameIconBundle { get; set; }

		public string PhotoboothFrameBundle { get; set; }

		public string BuffIconsBundle { get; set; }

		public string LoadoutIconsBundle { get; set; }

		public string LocalBuffRewardIconsBundle { get; set; }

		public string LocalLoadoutIconsBundle { get; set; }

		public string TrophyIconsBundle { get; set; }

		public string EncounterIconsBundle { get; set; }

		public string LookAwayIconName { get; set; }

		public string LookAtIconName { get; set; }
	}

	public class WearAndTearDamage
	{
		public int Min { get; set; }

		public int Max { get; set; }
	}

	public class Workshop
	{
		public int MaxSlots { get; set; }
	}
}
