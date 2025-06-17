using UnityEngine;

public class PlayerNoiseMeterData
{
	public readonly float NoiseToJumpScare;

	public readonly float NoiseDecayPerTick;

	public readonly float RotationScale;

	public readonly float RotationExponent;

	public readonly Vector3 PositionScale;

	public readonly Vector3 PositionExponent;

	public PlayerNoiseMeterData(ATTACK_DATA.PlayerNoiseMeter rawSettings)
	{
		NoiseToJumpScare = rawSettings.NoiseToJumpScare;
		NoiseDecayPerTick = rawSettings.NoiseDecayPerTick;
		RotationScale = rawSettings.RotationScale;
		RotationExponent = rawSettings.RotationExponent;
		PositionScale = new Vector3(rawSettings.PositionScaleX, rawSettings.PositionScaleY, rawSettings.PositionScaleZ);
		PositionExponent = new Vector3(rawSettings.PositionExponentX, rawSettings.PositionExponentY, rawSettings.PositionExponentZ);
	}
}
