using System.Collections.Generic;
using UnityEngine;

public class AudioGroup
{
	private readonly HashSet<AnimatronicAudioManager> _emitters;

	private float _volume;

	private bool _isMuted;

	public AnimatronicAudioManager DefaultEmitter { get; set; }

	public void AddEmitter(AnimatronicAudioManager emitter)
	{
		if (!_emitters.Contains(emitter))
		{
			_emitters.Add(emitter);
			UpdateEmitterVolume(emitter);
		}
	}

	public void RemoveEmitter(AnimatronicAudioManager emitter)
	{
		if (_emitters.Contains(emitter))
		{
			_emitters.Remove(emitter);
		}
	}

	public void SetVolume(float volume)
	{
		_volume = Mathf.Clamp(volume, 0f, 1f);
		UpdateGroupVolume();
	}

	public void SetMuteState(bool isMuted)
	{
		_isMuted = isMuted;
		UpdateGroupVolume();
	}

	private void UpdateGroupVolume()
	{
		foreach (AnimatronicAudioManager emitter in _emitters)
		{
			UpdateEmitterVolume(emitter);
		}
	}

	private void UpdateEmitterVolume(AnimatronicAudioManager emitter)
	{
		if (!(emitter == null))
		{
			emitter.SetVolume(_volume);
			emitter.SetMute(_isMuted);
		}
	}

	public AudioGroup(AnimatronicAudioManager defaultEmitter)
	{
		_emitters = new HashSet<AnimatronicAudioManager>();
		_volume = 1f;
		DefaultEmitter = defaultEmitter;
		AddEmitter(defaultEmitter);
	}

	public void Teardown()
	{
		_emitters.Clear();
		DefaultEmitter = null;
	}
}
