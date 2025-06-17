using System;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer
{
	private EventExposer _masterEventExposer;

	private AudioDomain _audioDomain;

	private AudioEventLookup _audioEventLookup;

	private readonly Dictionary<AudioMode, AudioGroup> _audioGroups;

	private Transform _safeParent;

	private Transform _cameraParent;

	private Transform _mapParent;

	private Transform _workshopParent;

	private Transform _episodicContentParent;

	private GameDisplayData _displayData;

	private SceneLookupTableAccess _sceneLookupTableAccess;

	private Action<SoundBankLoader> bankLoaderCallbacks;

	public SoundBankLoader SoundBankLoader
	{
		get
		{
			if (_audioDomain == null)
			{
				return null;
			}
			return _audioDomain.SoundBankLoader;
		}
	}

	public bool IsReady => _audioEventLookup == null;

	public void RegisterEmitter(AnimatronicAudioManager emitter, AudioMode mode)
	{
		if (_audioGroups.TryGetValue(mode, out var value))
		{
			_audioDomain.SetEmittersListener(emitter);
			value.AddEmitter(emitter);
		}
	}

	public void DeregisterEmitter(AnimatronicAudioManager emitter, AudioMode mode)
	{
		if (_audioGroups.TryGetValue(mode, out var value))
		{
			value.RemoveEmitter(emitter);
		}
	}

	public void SetGlobalMute(bool shouldMute)
	{
		if (!shouldMute)
		{
			SetAudioModeToMatchDisplayMode();
			return;
		}
		foreach (AudioMode key in _audioGroups.Keys)
		{
			_audioGroups.TryGetValue(key, out var value);
			value.SetMuteState(isMuted: true);
		}
	}

	public void SetMute(AnimatronicAudioManager emitter, bool shouldMute)
	{
		emitter.SetMute(shouldMute);
	}

	public void SetState(string group, string state)
	{
		_audioDomain.SetState(group, state);
	}

	public void RaiseGameEventForEmitter(AudioEventName name, AnimatronicAudioManager emitter)
	{
		AudioEvent audioEvent = _audioEventLookup.GetAudioEvent(name);
		if (audioEvent == null)
		{
			return;
		}
		foreach (string name2 in audioEvent.Names)
		{
			emitter.SendEvent(name2);
		}
	}

	public void RaiseGameEventForEmitterByName(string name, AnimatronicAudioManager emitter)
	{
		AudioEvent audioEventByName = _audioEventLookup.GetAudioEventByName(name);
		if (audioEventByName == null)
		{
			return;
		}
		foreach (string name2 in audioEventByName.Names)
		{
			emitter.SendEvent(name2);
		}
	}

	public void RaiseGameEventForEmitterWithOverride(AudioEventName name, string overridePrefix, AnimatronicAudioManager emitter)
	{
		AudioEvent audioEvent = _audioEventLookup.GetAudioEvent(name, overridePrefix);
		if (audioEvent == null)
		{
			RaiseGameEventForEmitter(name, emitter);
			return;
		}
		foreach (string name2 in audioEvent.Names)
		{
			emitter.SendEvent(name2);
		}
	}

	public void RaiseGameEventForMode(AudioEventName name, AudioMode mode)
	{
		if (_audioGroups.TryGetValue(mode, out var value))
		{
			RaiseGameEventForEmitter(name, value.DefaultEmitter);
		}
	}

	public void RaiseGameEventForModeByName(string name, AudioMode mode)
	{
		if (_audioGroups.TryGetValue(mode, out var value))
		{
			RaiseGameEventForEmitterByName(name, value.DefaultEmitter);
		}
	}

	public void RaiseGameEventForModeWithOverride(AudioEventName name, string overridePrefix, AudioMode mode)
	{
		if (_audioGroups[mode] == null)
		{
			Debug.LogError("Cant find audio group for mode " + mode);
		}
		else
		{
			RaiseGameEventForEmitterWithOverride(name, overridePrefix, _audioGroups[mode].DefaultEmitter);
		}
	}

	public void RaiseGameEventForModeWithOverrideByName(string name, string overridePrefix, AudioMode mode)
	{
		if (!_audioGroups.TryGetValue(mode, out var value))
		{
			return;
		}
		AudioEvent audioEventByName = _audioEventLookup.GetAudioEventByName(name, overridePrefix);
		if (audioEventByName == null)
		{
			RaiseGameEventForModeByName(name, mode);
			return;
		}
		foreach (string name2 in audioEventByName.Names)
		{
			value.DefaultEmitter.SendEvent(name2);
		}
	}

	public void SetParameterForEmitter(AudioParameterName name, float value, AnimatronicAudioManager emitter)
	{
		AudioParameter audioParameter = _audioEventLookup.GetAudioParameter(name);
		if (audioParameter != null)
		{
			emitter.SetRtpcValue(audioParameter.Name, value);
		}
	}

	public void SetParameterForMode(AudioParameterName name, float value, AudioMode mode)
	{
		if (_audioGroups.TryGetValue(mode, out var value2))
		{
			SetParameterForEmitter(name, value, value2.DefaultEmitter);
		}
	}

	private bool IsGlobalMuteOverrideEnabled()
	{
		return false;
	}

	private void GameDisplayChanged(GameDisplayData displayData)
	{
		_displayData = displayData;
		MoveListenerToSafety();
		if (_sceneLookupTableAccess != null)
		{
			_sceneLookupTableAccess.GetCameraSceneLookupTableAsync(CameraSceneLookupTableReady);
			_sceneLookupTableAccess.GetWorkshopSceneLookupTableAsync(WorkshopSceneLookupTableReady);
		}
	}

	private void MoveListenerToSafety()
	{
		_audioDomain.SetListenerParent(_safeParent);
	}

	private void SetAudioModeToMatchDisplayMode()
	{
		if (_audioDomain == null)
		{
			return;
		}
		if (_displayData == null)
		{
			MoveListenerToSafety();
			{
				foreach (AudioMode key in _audioGroups.Keys)
				{
					_audioGroups.TryGetValue(key, out var value);
					if (key == AudioMode.Global)
					{
						value.SetMuteState(isMuted: false);
					}
					else
					{
						value.SetMuteState(isMuted: true);
					}
				}
				return;
			}
		}
		switch (_displayData.currentDisplay)
		{
		case GameDisplayData.DisplayType.camera:
			_audioDomain.SetListenerParent(_cameraParent);
			{
				foreach (AudioMode key2 in _audioGroups.Keys)
				{
					_audioGroups.TryGetValue(key2, out var value5);
					switch (key2)
					{
					case AudioMode.Camera:
						value5.SetMuteState(isMuted: false);
						break;
					default:
						value5.SetMuteState(isMuted: true);
						break;
					case AudioMode.Global:
						break;
					}
				}
				return;
			}
		case GameDisplayData.DisplayType.scavengingui:
			_audioDomain.SetListenerParent(_cameraParent);
			{
				foreach (AudioMode key3 in _audioGroups.Keys)
				{
					_audioGroups.TryGetValue(key3, out var value4);
					switch (key3)
					{
					case AudioMode.Camera:
						value4.SetMuteState(isMuted: false);
						break;
					default:
						value4.SetMuteState(isMuted: true);
						break;
					case AudioMode.Global:
						break;
					}
				}
				return;
			}
		case GameDisplayData.DisplayType.map:
			_audioDomain.SetListenerParent(_workshopParent);
			{
				foreach (AudioMode key4 in _audioGroups.Keys)
				{
					_audioGroups.TryGetValue(key4, out var value3);
					switch (key4)
					{
					case AudioMode.Map:
						value3.SetMuteState(isMuted: false);
						break;
					default:
						value3.SetMuteState(isMuted: true);
						break;
					case AudioMode.Global:
						break;
					}
				}
				return;
			}
		case GameDisplayData.DisplayType.workshop:
			_audioDomain.SetListenerParent(_workshopParent);
			{
				foreach (AudioMode key5 in _audioGroups.Keys)
				{
					_audioGroups.TryGetValue(key5, out var value2);
					switch (key5)
					{
					case AudioMode.Workshop:
						value2.SetMuteState(isMuted: false);
						break;
					default:
						value2.SetMuteState(isMuted: true);
						break;
					case AudioMode.Global:
						break;
					}
				}
				return;
			}
		}
		MoveListenerToSafety();
		foreach (AudioMode key6 in _audioGroups.Keys)
		{
			_audioGroups.TryGetValue(key6, out var value6);
			if (key6 == AudioMode.Global)
			{
				value6.SetMuteState(isMuted: false);
			}
			else
			{
				value6.SetMuteState(isMuted: true);
			}
		}
	}

	public AudioPlayer(EventExposer masterEventExposer, SceneLookupTableAccess sceneLookupTableAccess, MasterDataDomain masterDataDomain)
	{
		_audioGroups = new Dictionary<AudioMode, AudioGroup>();
		_masterEventExposer = masterEventExposer;
		masterEventExposer.add_GameDisplayChange(GameDisplayChanged);
		_safeParent = sceneLookupTableAccess.transform;
		_sceneLookupTableAccess = sceneLookupTableAccess;
		if (_sceneLookupTableAccess != null)
		{
			sceneLookupTableAccess.GetCameraSceneLookupTableAsync(CameraSceneLookupTableReady);
			sceneLookupTableAccess.GetWorkshopSceneLookupTableAsync(WorkshopSceneLookupTableReady);
		}
		masterDataDomain.GetAccessToData.GetAudioDataAsync(AudioDataReady);
	}

	public void CameraSceneLookupTableReady(CameraSceneLookupTable cameraSceneLookupTable)
	{
		_cameraParent = cameraSceneLookupTable.AudioListenerParent.transform;
		SetAudioModeToMatchDisplayMode();
	}

	private void WorkshopSceneLookupTableReady(WorkshopSceneLookupTable workshopSceneLookupTable)
	{
		_workshopParent = workshopSceneLookupTable.AudioListenerParent.transform;
		SetAudioModeToMatchDisplayMode();
	}

	private void AudioDataReady(AUDIO_DATA.Root audioData)
	{
		_audioEventLookup = new AudioEventLookup(audioData);
	}

	public void Setup(AudioDomain audioDomain)
	{
		_audioDomain = audioDomain;
		CreateGroups();
		SetAudioModeToMatchDisplayMode();
		_masterEventExposer.add_PrepareForSceneUnload(MoveListenerToSafety);
	}

	private void CreateGroups()
	{
		_audioGroups.Add(AudioMode.Global, MakeNewGroup("Global", startsMuted: false));
		_audioGroups.Add(AudioMode.Camera, MakeNewGroup("Camera", startsMuted: true));
		_audioGroups.Add(AudioMode.Map, MakeNewGroup("Map", startsMuted: true));
		_audioGroups.Add(AudioMode.Workshop, MakeNewGroup("Workshop", startsMuted: true));
	}

	private AudioGroup MakeNewGroup(string name, bool startsMuted)
	{
		AnimatronicAudioManager animatronicAudioManager = _audioDomain.MakeNewEmitter(name);
		_audioDomain.SetEmittersListener(animatronicAudioManager);
		AudioGroup audioGroup = new AudioGroup(animatronicAudioManager);
		audioGroup.SetMuteState(startsMuted);
		return audioGroup;
	}

	public void Teardown()
	{
		_audioDomain = null;
		_masterEventExposer.remove_GameDisplayChange(GameDisplayChanged);
		_masterEventExposer.remove_PrepareForSceneUnload(MoveListenerToSafety);
		_masterEventExposer = null;
	}

	public void GetSoundBankLoaderAsync(Action<SoundBankLoader> callback)
	{
		if (SoundBankLoader != null)
		{
			callback?.Invoke(SoundBankLoader);
		}
		else
		{
			bankLoaderCallbacks = (Action<SoundBankLoader>)Delegate.Combine(bankLoaderCallbacks, callback);
		}
	}

	public void ReceivedSoundBankLoader()
	{
		bankLoaderCallbacks?.Invoke(SoundBankLoader);
	}
}
