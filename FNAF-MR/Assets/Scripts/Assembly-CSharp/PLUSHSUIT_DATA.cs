using System;
using System.Collections.Generic;

public sealed class PLUSHSUIT_DATA
{
	public class Animatronic3D
	{
		public string Bundle { get; set; }

		public string Prefab { get; set; }

		public string MapIcon { get; set; }
	}

	public class AnimatronicNames
	{
		public string Default { get; set; }
	}

	public class AnimPlayerFacingText
	{
		public string PlushSuitDescription { get; set; }
	}

	public class ArtAssets
	{
		public Audio Audio { get; set; }

		public Animatronic3D Animatronic3D { get; set; }

		public UI UI { get; set; }

		public MangleEncounterParts MangleEncounterParts { get; set; }

		public DisruptionScreenObjects DisruptionScreenObjects { get; set; }
	}

	public class Audio
	{
		public string SoundBank { get; set; }
	}

	public class DisruptionScreenObjects
	{
		public string BundleName { get; set; }

		public string AssetName { get; set; }
	}

	public class Entry
	{
		public string Logical { get; set; }

		public AnimatronicNames AnimatronicNames { get; set; }

		public string ConcreteItemID { get; set; }

		public string SkinCategory { get; set; }

		public int SkinOrder { get; set; }

		public int Order { get; set; }

		public int UnlockedLevel { get; set; }

		public string UnavailableDisplay { get; set; }

		public Status Status { get; set; }

		public bool PlayerAcquirable { get; set; }

		public AnimPlayerFacingText AnimPlayerFacingText { get; set; }

		public ArtAssets ArtAssets { get; set; }

		public Rewards Rewards { get; set; }

		public LookAwayApproachPose LookAwayApproachPose { get; set; }

		public Environment Environment { get; set; }

		public ShockTargetBorder ShockTargetBorder { get; set; }
	}

	public class Environment
	{
		public string Bundle { get; set; }

		public string Asset { get; set; }
	}

	public class LookAwayApproachPose
	{
		public int StartPoseCount { get; set; }

		public int InChairPoseCount { get; set; }

		public int OnFloorPoseCount { get; set; }

		public int BehindDoorLeftPoseCount { get; set; }

		public int BehindDoorRightPoseCount { get; set; }

		public int BehindRubblePoseCount { get; set; }

		public int FinalPoseCount { get; set; }
	}

	public class MangleEncounterParts
	{
		public string BundleName { get; set; }

		public string AssetNames { get; set; }
	}

	public class PvPAnimatronicsAggressor
	{
		public string LootStructureId { get; set; }

		public string EventLootStructureId { get; set; }
	}

	public class PvPAnimatronicsVictim
	{
		public string LootStructureId { get; set; }

		public string EventLootStructureId { get; set; }
	}

	public class Rewards
	{
		public WanderingAnimatronics WanderingAnimatronics { get; set; }

		public PvPAnimatronicsVictim PvPAnimatronicsVictim { get; set; }

		public PvPAnimatronicsAggressor PvPAnimatronicsAggressor { get; set; }
	}

	public class Root
	{
		public List<Entry> Entries { get; set; }
	}

	public class ShockTargetBorder
	{
		public double XMin { get; set; }

		public double XMax { get; set; }

		public double YMin { get; set; }

		public double YMax { get; set; }
	}

	public class Status
	{
		public string LiveState { get; set; }

		public DateTime AvailableDate { get; set; }
	}

	public class UI
	{
		public string PlushSuitIcon { get; set; }

		public string PlushSuitSilhouetteIcon { get; set; }

		public string PortraitIcon { get; set; }

		public string PortraitIconFlat { get; set; }
	}

	public class WanderingAnimatronics
	{
		public string LootStructureId { get; set; }

		public string EventLootStructureId { get; set; }
	}
}
