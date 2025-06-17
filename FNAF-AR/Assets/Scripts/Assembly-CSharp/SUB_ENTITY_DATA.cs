using System.Collections.Generic;

public sealed class SUB_ENTITY_DATA
{
	public class Activation
	{
		public string ActivationType { get; set; }

		public float ActivationCooldown { get; set; }

		public string DeactivationRequirement { get; set; }

		public float DeactivationTime { get; set; }

		public string DeactivationType { get; set; }
	}

	public class ArtAssets
	{
		public string Bundle { get; set; }

		public string Asset { get; set; }

		public string SoundBank { get; set; }
	}

	public class CircleDegreesPerSecond
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class CircleDistance
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class Effect
	{
		public string EffectRequirement { get; set; }

		public string EffectType { get; set; }

		public MinMaxDistance MinMaxDistance { get; set; }

		public MinMaxValues MinMaxValues { get; set; }

		public string ValueType { get; set; }

		public MinMaxLifetime MinMaxLifetime { get; set; }
	}

	public class EntityEffects
	{
		public Movement Movement { get; set; }

		public List<Effect> Effects { get; set; }

		public Activation Activation { get; set; }

		public Jumpscare Jumpscare { get; set; }
	}

	public class Entry
	{
		public string Logical { get; set; }

		public EntityEffects EntityEffects { get; set; }

		public ArtAssets ArtAssets { get; set; }
	}

	public class Jumpscare
	{
		public string JumpscareSource { get; set; }

		public float TimeToJumpscare { get; set; }

		public bool PauseWhileDeactivationRequirementActive { get; set; }

		public List<JumpscareEffect> JumpscareEffects { get; set; }

		public float JumpscareEffectSeconds { get; set; }
	}

	public class JumpscareEffect
	{
		public string JumpscareEffectType { get; set; }
	}

	public class MinMaxDistance
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class MinMaxLifetime
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class MinMaxValues
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class Movement
	{
		public string MovementType { get; set; }

		public float ApproachStartDistance { get; set; }

		public float ApproachEndDistance { get; set; }

		public TeleportPositions TeleportPositions { get; set; }

		public TeleportCooldown TeleportCooldown { get; set; }

		public bool HideIfMaskOff { get; set; }

		public bool FollowPlayerForward { get; set; }

		public CircleDistance CircleDistance { get; set; }

		public CircleDegreesPerSecond CircleDegreesPerSecond { get; set; }

		public StationaryDistance StationaryDistance { get; set; }

		public StationaryAngleFromCamera StationaryAngleFromCamera { get; set; }

		public bool UseWorldHeightPosition { get; set; }
	}

	public class Root
	{
		public List<Entry> Entries { get; set; }
	}

	public class StationaryDistance
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class StationaryAngleFromCamera
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}

	public class TeleportPositions
	{
		public int Min { get; set; }

		public int Max { get; set; }
	}

	public class TeleportCooldown
	{
		public float Min { get; set; }

		public float Max { get; set; }
	}
}
