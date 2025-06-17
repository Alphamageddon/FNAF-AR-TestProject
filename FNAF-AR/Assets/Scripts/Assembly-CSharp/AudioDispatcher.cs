using System;
using UnityEngine;

public class AudioDispatcher
{
	private string _cpuSoundBankName;

	private string _plushSuitSoundBankName;

	private AudioPlayer _audioPlayer;

	private AnimatronicAudioManager _emitter;

	private AudioMode _audioMode;

	public void RaiseGameEventAnimatronic(AudioEventName eventName, bool useCpu)
	{
		_audioPlayer.RaiseGameEventForEmitterWithOverride(eventName, useCpu ? _cpuSoundBankName : _plushSuitSoundBankName, _emitter);
	}

	public void RaiseGameEventAnimatronic(AudioEventName eventName, string prefix)
	{
		if (!string.IsNullOrWhiteSpace(prefix))
		{
			_audioPlayer.RaiseGameEventForEmitterWithOverride(eventName, prefix, _emitter);
		}
		else
		{
			_audioPlayer.RaiseGameEventForEmitter(eventName, _emitter);
		}
	}

	public void RaiseGameEventCamera(AudioEventName eventName, bool useCpu)
	{
		_audioPlayer.RaiseGameEventForModeWithOverride(eventName, useCpu ? _cpuSoundBankName : _plushSuitSoundBankName, AudioMode.Camera);
	}

	public void RaiseGameEventCamera(AudioEventName eventName, string prefix)
	{
		if (!string.IsNullOrWhiteSpace(prefix))
		{
			_audioPlayer.RaiseGameEventForModeWithOverride(eventName, prefix, AudioMode.Camera);
		}
		else
		{
			_audioPlayer.RaiseGameEventForMode(eventName, AudioMode.Camera);
		}
	}

	public void RaiseGameEventGlobal(AudioEventName eventName, bool useCpu)
	{
		_audioPlayer.RaiseGameEventForModeWithOverride(eventName, useCpu ? _cpuSoundBankName : _plushSuitSoundBankName, AudioMode.Global);
	}

	public void RaiseGameEventGlobal(AudioEventName eventName, string prefix)
	{
		if (!string.IsNullOrWhiteSpace(prefix))
		{
			_audioPlayer.RaiseGameEventForModeWithOverride(eventName, prefix, AudioMode.Global);
		}
		else
		{
			_audioPlayer.RaiseGameEventForMode(eventName, AudioMode.Global);
		}
	}

	public void RaiseEventFromCpu(AudioEventName eventName)
	{
		_audioPlayer.RaiseGameEventForEmitterWithOverride(eventName, _cpuSoundBankName, _emitter);
	}

	public void RaiseEventFromPlushSuit(AudioEventName eventName)
	{
		_audioPlayer.RaiseGameEventForEmitterWithOverride(eventName, _plushSuitSoundBankName, _emitter);
	}

	public void SetParameterAnimatronic(AudioParameterName parameterName, float value)
	{
		_audioPlayer.SetParameterForEmitter(parameterName, value, _emitter);
	}

	public void SetState(AudioStateGroupName groupName, AudioStateName stateName)
	{
		_audioPlayer.SetState(groupName.ToString(), stateName.ToString());
	}

	public void SetMute(bool shouldMute)
	{
		_audioPlayer.SetMute(_emitter, shouldMute);
	}

	public void SoundEventReceived(AnimationEvent animationEvent)
	{
		AudioEventName result = AudioEventName.None;
		if (animationEvent.intParameter == 3000 && Enum.TryParse<AudioEventName>(animationEvent.stringParameter, out result))
		{
			_audioPlayer.RaiseGameEventForEmitterWithOverride(result, _plushSuitSoundBankName, _emitter);
		}
	}

	public void Setup(string cpuSoundBankName, string plushSuitSoundBankName, AudioPlayer audioPlayer, AnimatronicAudioManager akAudioEmitter, AudioMode audioMode)
	{
		_cpuSoundBankName = cpuSoundBankName;
		_plushSuitSoundBankName = plushSuitSoundBankName;
		_audioPlayer = audioPlayer;
		_emitter = akAudioEmitter;
		_audioMode = audioMode;
		_audioPlayer.RegisterEmitter(akAudioEmitter, audioMode);
	}

	public void Teardown()
	{
		_audioPlayer.DeregisterEmitter(_emitter, _audioMode);
		_audioPlayer = null;
		_emitter = null;
	}
}
