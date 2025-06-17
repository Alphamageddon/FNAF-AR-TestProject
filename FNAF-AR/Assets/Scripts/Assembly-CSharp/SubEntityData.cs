using System.Collections.Generic;

public class SubEntityData
{
	public enum SubEntityMovementType
	{
		Circle = 1,
		CircleTeleportApproach = 2,
		Approach = 3,
		Stationary = 4
	}

	public enum SubEntityEffectRequirement
	{
		Lifetime = 1,
		Distance = 2
	}

	public enum SubEntityEffectType
	{
		DisruptionStrength = 1,
		DegreesPerSecond = 2,
		FootstepSpeedScalar = 3,
		ChargeSeconds = 4,
		ShearModifier = 5
	}

	public enum SubEntityEffectValueType
	{
		Additive = 1,
		Multiply = 2,
		Override = 3
	}

	public enum SubEntityActivationType
	{
		Automatic = 1,
		FlashlightOn = 2
	}

	public enum SubEntityDeactivationRequirement
	{
		Automatic = 1,
		FlashlightLookAt = 2,
		MaskOnLookAt = 3,
		FlashlightOff = 4,
		Glimpse = 5
	}

	public enum SubEntityDeactivationType
	{
		Instant = 1,
		TeleportDistance = 2
	}

	public enum SubEntityJumpscareSource
	{
		None = 1,
		Lifetime = 2,
		LookAt = 3
	}

	public enum SubEntityJumpscareEffectType
	{
		DisableFlashlight = 1,
		InvertScreen = 2,
		DisableShocker = 3
	}

	public readonly string Logical;

	public readonly SubEntityMovement Movement;

	public readonly List<SubEntityEffect> Effects = new List<SubEntityEffect>();

	public readonly SubEntityActivation Activation;

	public readonly SubEntityJumpscare Jumpscare;

	public readonly string Bundle;

	public readonly string Asset;

	public readonly string SoundBank;

	public SubEntityData(SUB_ENTITY_DATA.Entry rawSettings)
	{
		Logical = rawSettings.Logical;
		Movement = new SubEntityMovement(rawSettings.EntityEffects.Movement);
		foreach (SUB_ENTITY_DATA.Effect effect in rawSettings.EntityEffects.Effects)
		{
			Effects.Add(new SubEntityEffect(effect));
		}
		Activation = new SubEntityActivation(rawSettings.EntityEffects.Activation);
		Jumpscare = new SubEntityJumpscare(rawSettings.EntityEffects.Jumpscare);
		Bundle = rawSettings.ArtAssets.Bundle;
		Asset = rawSettings.ArtAssets.Asset;
		SoundBank = rawSettings.ArtAssets.SoundBank;
	}
}
