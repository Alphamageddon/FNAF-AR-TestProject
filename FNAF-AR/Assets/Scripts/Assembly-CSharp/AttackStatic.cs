using System.Collections.Generic;
using UnityEngine;

public class AttackStatic
{
	private EventExposer _masterEventExposer;

	private ModifiedGlitchShader _glitchShader;

	private bool _isFlashlightOn;

	private float _angleStrength;

	private float _shear;

	private float _audio;

	public StaticConfigs Configs { get; set; }

	public StaticContainer Container { get; set; }

	private void FlashlightStateChanged(bool isFlashlightOn, bool shouldPlayAudio)
	{
		_isFlashlightOn = isFlashlightOn;
	}

	private void ResetUpdateValues()
	{
		_angleStrength = -1f;
		_shear = 0f;
		_audio = 0f;
	}

	private void CalculateUpdateValues()
	{
		foreach (StaticSource value in Container.StaticSources.Values)
		{
			CalculateAngleStrength(value);
			AddAdditiveStrengths(value);
		}
	}

	private void CalculateAngleStrength(StaticSource staticSource)
	{
		if (staticSource.AngleStrength != null && staticSource.BaseEffects != null)
		{
			_shear = staticSource.BaseAngleStrength.GetAngleStrength(staticSource.Angle) * staticSource.BaseEffects.GetModifiedShear(staticSource.ShearModifier);
			_audio = staticSource.BaseAngleStrength.GetAngleStrength(staticSource.Angle) * staticSource.BaseEffects.GetModifiedAudio(staticSource.ShearModifier);
		}
		else
		{
			_shear = 0f;
			_audio = 0f;
		}
		if (!_isFlashlightOn)
		{
			if (staticSource.AngleStrength != null)
			{
				_angleStrength = Mathf.Max(staticSource.AngleStrength.GetAngleStrength(staticSource.Angle), 0f);
			}
			else
			{
				_angleStrength = 0f;
			}
			if (staticSource.Effects != null)
			{
				_shear = Mathf.Max(_shear, _angleStrength * staticSource.Effects.GetModifiedShear(staticSource.ShearModifier));
				_audio = Mathf.Max(_audio, _angleStrength * staticSource.Effects.GetModifiedAudio(staticSource.ShearModifier));
			}
		}
		else
		{
			if (staticSource.AngleStrength != null)
			{
				_angleStrength = staticSource.FlashlightAngleStrength.GetAngleStrength(staticSource.Angle);
			}
			else
			{
				_angleStrength = -1f;
			}
			if (staticSource.FlashlightEffects != null)
			{
				_shear = Mathf.Max(_shear, _angleStrength * staticSource.FlashlightEffects.GetModifiedShear(staticSource.ShearModifier));
				_audio = Mathf.Max(_audio, _angleStrength * staticSource.FlashlightEffects.GetModifiedAudio(staticSource.ShearModifier));
			}
		}
	}

	private void AddAdditiveStrengths(StaticSource staticSource)
	{
		List<AdditiveSource> list = new List<AdditiveSource>(staticSource.AdditiveSources);
		foreach (AdditiveSource item in list)
		{
			int index = list.IndexOf(item);
			if (item.Strength.HasEnded(Time.time))
			{
				float num = (item.IsPositional ? _angleStrength : 1f);
				float num2 = num * item.Strength.GetStrength(Time.time) * item.EffectSettings.GetModifiedShear(staticSource.ShearModifier);
				_shear += num2;
				float num3 = num * item.Strength.GetStrength(Time.time) * item.EffectSettings.GetModifiedAudio(staticSource.ShearModifier);
				_audio += num3;
			}
			else
			{
				staticSource.AdditiveSources.RemoveAt(index);
			}
		}
	}

	private void ApplyUpdateValues()
	{
		if (!(_glitchShader == null))
		{
			_glitchShader.ShearStrength = _shear;
			StaticSettings staticSettings = new StaticSettings();
			staticSettings.StaticAudioStrength = Mathf.Clamp(_audio, 0f, 1f);
			_masterEventExposer.OnStaticSettingsUpdated(staticSettings);
		}
	}

	public AttackStatic(EventExposer masterEventExposer, MasterDataDomain masterDataDomain)
	{
		_masterEventExposer = masterEventExposer;
		Configs = new StaticConfigs(masterDataDomain);
		Container = new StaticContainer();
		_masterEventExposer.add_FlashlightStateChanged(FlashlightStateChanged);
	}

	public void Setup(ModifiedGlitchShader glitchShader)
	{
		_glitchShader = glitchShader;
	}

	public void Teardown()
	{
		_masterEventExposer.remove_FlashlightStateChanged(FlashlightStateChanged);
		Configs = null;
		_masterEventExposer = null;
	}

	public void Update()
	{
		ResetUpdateValues();
		CalculateUpdateValues();
		ApplyUpdateValues();
	}
}
