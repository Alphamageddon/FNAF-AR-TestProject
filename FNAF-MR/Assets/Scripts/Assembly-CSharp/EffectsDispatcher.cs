using System.Collections.Generic;
using EZCameraShake;
using UnityEngine;

public class EffectsDispatcher
{
	private LightningFxController _lightningEffect;

	private AnimatronicMaterialController _materialController;

	private EyeGlowLightController _eyeGlowController;

	private Footsteps _footsteps;

	public Dictionary<EyeColorMode, EyeColorData> _eyeOverrides { get; private set; }

	public void EffectEventReceived(AnimationEvent animationEvent)
	{
		switch (animationEvent.intParameter)
		{
		case 1000:
			if (_lightningEffect != null)
			{
				_lightningEffect.spawn = true;
			}
			break;
		case 1001:
			if (_lightningEffect != null)
			{
				_lightningEffect.spawn = false;
			}
			break;
		case 1002:
			_footsteps.TriggerFootstep();
			break;
		case 1003:
			SetEyeGlow(eyeGlowEnabled: true);
			break;
		case 1004:
			SetEyeGlow(eyeGlowEnabled: false);
			break;
		case 1005:
			SetEyeColorMode(EyeColorMode.Normal);
			break;
		case 1006:
			SetEyeColorMode(EyeColorMode.Attack);
			break;
		case 1007:
			CameraShaker.Instance.ShakeOnce(2f, 10f, 0f, 5f);
			break;
		case 1008:
			break;
		}
	}

	public void SetEyeColorMode(EyeColorMode mode)
	{
		_eyeOverrides.TryGetValue(mode, out var value);
		if (_materialController != null)
		{
			if (mode == EyeColorMode.Normal || value == null)
			{
				_materialController.SetEyeGlowIntensity(1f);
				_materialController.EndEyeColorOverride();
			}
			else
			{
				_materialController.SetEyeGlowIntensity(value.Intensity);
				if (value.HasOverride)
				{
					_materialController.StartEyeColorOverride(value.Color);
				}
			}
		}
		if (_eyeGlowController != null)
		{
			if (mode != EyeColorMode.Normal && value != null && value.HasOverride)
			{
				_eyeGlowController.StartEyeColorOverride(value.Color);
			}
			else
			{
				_eyeGlowController.EndEyeColorOverride();
			}
		}
	}

	public void SetEyeGlow(bool eyeGlowEnabled)
	{
		if (_materialController != null)
		{
			_materialController.SetEyeGlow(eyeGlowEnabled);
		}
		if (_eyeGlowController != null)
		{
			_eyeGlowController.SetEyeGlow(eyeGlowEnabled);
		}
	}

	public void SetWearAndTear(int value)
	{
		if (_materialController != null)
		{
			_materialController.wearAndTearPercentage = value;
		}
	}

	public void TriggerRepairInterpolation()
	{
		_materialController.TriggerRepairInterpolation();
	}

	public void Setup(AnimatronicModelConfig modelConfig, Footsteps footsteps, CPUData cpuData)
	{
		_lightningEffect = modelConfig.ShockLightningEffect;
		_materialController = modelConfig.AnimatronicMaterialController;
		_eyeGlowController = modelConfig.EyeGlowLightController;
		_footsteps = footsteps;
		SetEyeOverrides(cpuData);
	}

	private void SetEyeOverrides(CPUData cpuData)
	{
		if (cpuData != null)
		{
			_eyeOverrides = new Dictionary<EyeColorMode, EyeColorData>();
			if (cpuData.AttackEyes != null)
			{
				_eyeOverrides.Add(EyeColorMode.Attack, cpuData.AttackEyes);
			}
			if (cpuData.LookAtEyes != null)
			{
				_eyeOverrides.Add(EyeColorMode.LookAt, cpuData.LookAtEyes);
			}
			if (cpuData.LookAwayEyes != null)
			{
				_eyeOverrides.Add(EyeColorMode.LookAway, cpuData.LookAwayEyes);
			}
		}
	}

	public void BeginShockFxScavenging()
	{
		if (_lightningEffect != null)
		{
			_lightningEffect.spawn = true;
		}
	}

	public void StopShockFxScavenging()
	{
		if (_lightningEffect != null)
		{
			_lightningEffect.spawn = false;
		}
	}

	public void Teardown()
	{
		_footsteps = null;
		_lightningEffect = null;
		_materialController = null;
	}
}
