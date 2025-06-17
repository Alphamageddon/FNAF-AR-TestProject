using UnityEngine;

public class SoundEffects
{
	private EventExposer _masterEventExposer;

	private AudioPlayer _audioPlayer;

	private bool _isStaticPlaying;

	private bool _isAmbGlitchesPlaying;

	private const string MaskState = "Mask";

	private const string MaskOff = "MaskOff";

	private const string MaskOn = "MaskOn";

	private void AttackDisruptionStateChanged(bool isDisruptionActive, DisruptionStyle style)
	{
		_audioPlayer.RaiseGameEventForModeWithOverride(isDisruptionActive ? AudioEventName.CameraDisruptionBegin : AudioEventName.CameraDisruptionEnd, style.ToString(), AudioMode.Camera);
	}

	private void AttackSurgeStateChanged(bool isSurgeActive, SurgeData surgeSettings)
	{
		_audioPlayer.RaiseGameEventForMode(isSurgeActive ? AudioEventName.CameraSurgeBegin : AudioEventName.CameraSurgeEnd, AudioMode.Camera);
	}

	private void FlashlightStateChanged(bool isFlashlightOn, bool shouldPlayAudio)
	{
		if (shouldPlayAudio)
		{
			_audioPlayer.RaiseGameEventForMode(isFlashlightOn ? AudioEventName.CameraFlashlightTurnedOn : AudioEventName.CameraFlashlightTurnedOff, AudioMode.Camera);
		}
	}

	private void FlashlightCooldownComplete()
	{
		_audioPlayer.RaiseGameEventForMode(AudioEventName.CameraFlashlightCooldownComplete, AudioMode.Camera);
	}

	private void FlashlightTriedToActivate()
	{
		_audioPlayer.RaiseGameEventForMode(AudioEventName.CameraFlashlightActivatedOnCooldown, AudioMode.Camera);
	}

	private void MaskForcedOff()
	{
		_audioPlayer.RaiseGameEventForMode(AudioEventName.CameraMaskForcedOff, AudioMode.Camera);
		_audioPlayer.SetState("Mask", "MaskOff");
	}

	private void MaskStateChanged(bool isMaskGoingOn, bool isMaskTransitionBeginning)
	{
		if (!isMaskGoingOn)
		{
			if (!isMaskTransitionBeginning)
			{
				_audioPlayer.RaiseGameEventForMode(AudioEventName.CameraMaskOffEnd, AudioMode.Camera);
				return;
			}
			_audioPlayer.RaiseGameEventForMode(AudioEventName.CameraMaskOffBegin, AudioMode.Camera);
			_audioPlayer.SetState("Mask", "MaskOff");
		}
		else if (!isMaskTransitionBeginning)
		{
			_audioPlayer.RaiseGameEventForMode(AudioEventName.CameraMaskOnEnd, AudioMode.Camera);
			_audioPlayer.SetState("Mask", "MaskOn");
		}
		else
		{
			_audioPlayer.RaiseGameEventForMode(AudioEventName.CameraMaskOnBegin, AudioMode.Camera);
		}
	}

	private void ShockerActivated(ShockerActivation shockerActivation)
	{
		if (shockerActivation.OnCooldown)
		{
			_audioPlayer.RaiseGameEventForMode(AudioEventName.CameraShockerActivatedOnCooldown, AudioMode.Camera);
		}
		else if (!shockerActivation.NoBattery)
		{
			_audioPlayer.RaiseGameEventForMode(shockerActivation.DidHit ? AudioEventName.CameraShockerActivatedHit : AudioEventName.CameraShockerActivatedMiss, AudioMode.Camera);
		}
		else
		{
			_audioPlayer.RaiseGameEventForMode(AudioEventName.CameraShockerActivatedNoBattery, AudioMode.Camera);
		}
	}

	private void ShockerCooldownComplete()
	{
		_audioPlayer.RaiseGameEventForMode(AudioEventName.CameraShockerCooldownComplete, AudioMode.Camera);
	}

	private void StaticSettingsUpdated(StaticSettings staticSettings)
	{
		if (_isStaticPlaying)
		{
			SetStaticStrengths(staticSettings);
			if (!(staticSettings.StaticAudioStrength > 0f))
			{
				_audioPlayer.RaiseGameEventForMode(AudioEventName.CameraStaticEnd, AudioMode.Camera);
				_isStaticPlaying = false;
			}
		}
		else if (staticSettings.StaticAudioStrength <= 0f)
		{
			if (_isStaticPlaying)
			{
				SetStaticStrengths(staticSettings);
				_audioPlayer.RaiseGameEventForMode(AudioEventName.CameraStaticEnd, AudioMode.Camera);
				_isStaticPlaying = false;
			}
		}
		else
		{
			_audioPlayer.RaiseGameEventForMode(AudioEventName.CameraStaticBegin, AudioMode.Camera);
			SetStaticStrengths(staticSettings);
			_isStaticPlaying = true;
		}
	}

	private void NewAnimatronicSpawned()
	{
		_audioPlayer.RaiseGameEventForMode(AudioEventName.MapNewAnimatronicSpawned, AudioMode.Map);
	}

	private void SetStaticStrengths(StaticSettings staticSettings)
	{
		_audioPlayer.SetParameterForMode(AudioParameterName.CameraStaticStrength, Mathf.Clamp(staticSettings.StaticAudioStrength, 0f, 1f), AudioMode.Camera);
	}

	private void AmbGlitchesBegin()
	{
		if (!_isAmbGlitchesPlaying)
		{
			_audioPlayer.RaiseGameEventForMode(AudioEventName.Tutorial_AmbGlitchesBegin, AudioMode.Global);
			_isAmbGlitchesPlaying = true;
		}
	}

	private void AmbGlitchesEnd()
	{
		_audioPlayer.RaiseGameEventForMode(AudioEventName.Tutorial_AmbGlitchesEnd, AudioMode.Global);
		_isAmbGlitchesPlaying = false;
	}

	private void HardGlitchesBegin()
	{
		_audioPlayer.RaiseGameEventForMode(AudioEventName.Tutorial_HardGlitchesBegin, AudioMode.Global);
	}

	private void PurchaseRequestAudioInvoked(bool canAfford)
	{
		if (!canAfford)
		{
			_audioPlayer.RaiseGameEventForMode(AudioEventName.Store_InvalidPurchaseTapped, AudioMode.Global);
		}
		else
		{
			_audioPlayer.RaiseGameEventForMode(AudioEventName.Store_ValidPurchaseTapped, AudioMode.Global);
		}
	}

	private void MapExpressDeliveryAudioInvoked(bool valid)
	{
		if (!valid)
		{
			_audioPlayer.RaiseGameEventForMode(AudioEventName.UIExpressDeliveryPurchasedInvalid, AudioMode.Global);
		}
		else
		{
			_audioPlayer.RaiseGameEventForMode(AudioEventName.UIExpressDeliveryPurchasedValid, AudioMode.Global);
		}
	}

	private void OnWorkshopModifyAssemblyButtonPressed(AssemblyButtonPressedPayload payload)
	{
		if (payload.ButtonType == SlotDisplayButtonType.None)
		{
			return;
		}
		if (payload.ButtonType == SlotDisplayButtonType.Mod)
		{
			if (payload.SlotState != SlotState.Locked)
			{
				_audioPlayer.RaiseGameEventForMode(AudioEventName.UIWorkshopModIconSelected, AudioMode.Global);
			}
			else
			{
				_audioPlayer.RaiseGameEventForMode(AudioEventName.UIWorkshopModIconLocked, AudioMode.Global);
			}
		}
		else
		{
			_audioPlayer.RaiseGameEventForMode(AudioEventName.UIWorkshopAnimatronicSelectionTapped, AudioMode.Global);
		}
	}

	public SoundEffects(EventExposer masterEventExposer)
	{
		_masterEventExposer = masterEventExposer;
	}

	public void Setup(AudioPlayer audioPlayer, bool localGameplay)
	{
		_audioPlayer = audioPlayer;
		_audioPlayer.GetSoundBankLoaderAsync(StartSoundEffects);
	}

	private void StartSoundEffects(SoundBankLoader loader)
	{
		SoundBankRequest soundBankRequest = new SoundBankRequest();
		soundBankRequest.SoundBankName = "Master";
		soundBankRequest.Failure = LoadFailure;
		loader.RequestSoundBank(soundBankRequest);
		SoundBankRequest soundBankRequest2 = new SoundBankRequest();
		soundBankRequest2.SoundBankName = "Master.strings";
		soundBankRequest2.Failure = LoadFailure;
		loader.RequestSoundBank(soundBankRequest2);
		SoundBankRequest soundBankRequest3 = new SoundBankRequest();
		soundBankRequest3.SoundBankName = "Shared";
		soundBankRequest3.Failure = LoadFailure;
		loader.RequestSoundBank(soundBankRequest3);
		_masterEventExposer.add_AttackDisruptionStateChanged(AttackDisruptionStateChanged);
		_masterEventExposer.add_AttackSurgeStateChanged(AttackSurgeStateChanged);
		_masterEventExposer.add_FlashlightStateChanged(FlashlightStateChanged);
		_masterEventExposer.add_FlashlightCooldownComplete(FlashlightCooldownComplete);
		_masterEventExposer.add_FlashlightTriedToActivate(FlashlightTriedToActivate);
		_masterEventExposer.add_MaskForcedOff(MaskForcedOff);
		_masterEventExposer.add_MaskStateChanged(MaskStateChanged);
		_masterEventExposer.add_NewAnimatronicSpawned(NewAnimatronicSpawned);
		_masterEventExposer.add_ShockerActivated(ShockerActivated);
		_masterEventExposer.add_ShockerCooldownComplete(ShockerCooldownComplete);
		_masterEventExposer.add_StaticSettingsUpdated(StaticSettingsUpdated);
		_masterEventExposer.add_PurchaseRequestAudioInvoked(PurchaseRequestAudioInvoked);
		_masterEventExposer.add_WorkshopModifyAssemblyButtonPressed(OnWorkshopModifyAssemblyButtonPressed);
	}

	private void LoadFailure(string soundBankName)
	{
		Debug.LogError("SoundEffects LoadFailure - Failed to load SoundBank '" + soundBankName + "'. Cannot play sound effects.");
	}

	public void Teardown()
	{
		_audioPlayer = null;
		_masterEventExposer.remove_StaticSettingsUpdated(StaticSettingsUpdated);
		_masterEventExposer.remove_ShockerCooldownComplete(ShockerCooldownComplete);
		_masterEventExposer.remove_ShockerActivated(ShockerActivated);
		_masterEventExposer.remove_MaskStateChanged(MaskStateChanged);
		_masterEventExposer.remove_MaskForcedOff(MaskForcedOff);
		_masterEventExposer.remove_FlashlightTriedToActivate(FlashlightTriedToActivate);
		_masterEventExposer.remove_FlashlightCooldownComplete(FlashlightCooldownComplete);
		_masterEventExposer.remove_FlashlightStateChanged(FlashlightStateChanged);
		_masterEventExposer.remove_NewAnimatronicSpawned(NewAnimatronicSpawned);
		_masterEventExposer.remove_AttackDisruptionStateChanged(AttackDisruptionStateChanged);
		_masterEventExposer.remove_AttackSurgeStateChanged(AttackSurgeStateChanged);
		_masterEventExposer.remove_PurchaseRequestAudioInvoked(PurchaseRequestAudioInvoked);
		_masterEventExposer.add_WorkshopModifyAssemblyButtonPressed(OnWorkshopModifyAssemblyButtonPressed);
		_masterEventExposer = null;
	}
}
