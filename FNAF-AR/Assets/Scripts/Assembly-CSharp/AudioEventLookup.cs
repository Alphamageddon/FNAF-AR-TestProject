using System.Collections.Generic;
using UnityEngine;

public class AudioEventLookup
{
	private const string RtpcPrefix = "RTPC_";

	private readonly Dictionary<string, AudioEvent> _audioEvents;

	private readonly Dictionary<string, AudioParameter> _audioParameters;

	public AudioEvent GetAudioEventByName(string eventName, string animatronicId)
	{
		return GetItemFromLookup(animatronicId + "_" + eventName, _audioEvents);
	}

	public AudioEvent GetAudioEventByName(string eventName)
	{
		return GetItemFromLookup(eventName, _audioEvents);
	}

	public AudioEvent GetAudioEvent(AudioEventName name, string animatronicId)
	{
		return GetItemFromLookup($"{animatronicId}_{name}", _audioEvents);
	}

	public AudioEvent GetAudioEvent(AudioEventName name)
	{
		return GetItemFromLookup(name.ToString(), _audioEvents);
	}

	public AudioParameter GetAudioParameter(AudioParameterName name)
	{
		return GetItemFromLookup(name.ToString(), _audioParameters);
	}

	private static T GetItemFromLookup<T>(string id, IReadOnlyDictionary<string, T> lookup) where T : class
	{
		if (!lookup.ContainsKey(id))
		{
			Debug.LogError("No event or parameter for id " + id + " exists in lookup.");
			return null;
		}
		if (typeof(T) == typeof(AudioParameter))
		{
			return lookup[id];
		}
		if (typeof(T) == typeof(AudioEvent))
		{
			return lookup[id];
		}
		Debug.LogError("GetItemFromLookup is requesting type that isnt audio parameter or audio event");
		return null;
	}

	private static bool IsRtpcEntry(string gameAudioEvent)
	{
		return gameAudioEvent?.StartsWith("RTPC_") ?? false;
	}

	private static bool DoesEventNameExist(AUDIO_DATA.WwiseEventInfo eventInfo)
	{
		if (eventInfo != null)
		{
			return eventInfo.Name != null;
		}
		return false;
	}

	private void ProcessRtpcEntry(AUDIO_DATA.Entry entry)
	{
		string text = entry.GameAudioEvent.Remove(0, "RTPC_".Length);
		if (_audioParameters.ContainsKey(text))
		{
			Debug.LogError("AudioEventLookup ProcessRtpcEntry - Cannot add duplicate entry for '" + entry.GameAudioEvent + "' with id '" + text + "'");
		}
		else if (entry.WwiseAudioEvents != null && DoesEventNameExist(entry.WwiseAudioEvents.Event1))
		{
			_audioParameters.Add(text, new AudioParameter(entry.WwiseAudioEvents.Event1.Name));
		}
	}

	private void ProcessEventEntry(AUDIO_DATA.Entry entry)
	{
		if (_audioEvents.ContainsKey(entry.GameAudioEvent))
		{
			Debug.LogError("AudioEventLookup ProcessEventEntry - Cannot add duplicate entry for '" + entry.GameAudioEvent + "' with id '" + entry.GameAudioEvent + "'");
			return;
		}
		AudioEvent audioEvent = new AudioEvent();
		if (entry.WwiseAudioEvents != null)
		{
			if (entry.WwiseAudioEvents.Event1 != null)
			{
				ProcessWwiseEventInfo(entry.WwiseAudioEvents.Event1, audioEvent);
			}
			if (entry.WwiseAudioEvents.Event2 != null)
			{
				ProcessWwiseEventInfo(entry.WwiseAudioEvents.Event2, audioEvent);
			}
			if (entry.WwiseAudioEvents.Event3 != null)
			{
				ProcessWwiseEventInfo(entry.WwiseAudioEvents.Event3, audioEvent);
			}
			if (entry.WwiseAudioEvents.Event4 != null)
			{
				ProcessWwiseEventInfo(entry.WwiseAudioEvents.Event4, audioEvent);
			}
			if (entry.WwiseAudioEvents.Event5 != null)
			{
				ProcessWwiseEventInfo(entry.WwiseAudioEvents.Event5, audioEvent);
			}
		}
		if (audioEvent.Names.Count >= 1)
		{
			_audioEvents.Add(entry.GameAudioEvent, audioEvent);
		}
	}

	private static void ProcessWwiseEventInfo(AUDIO_DATA.WwiseEventInfo eventInfo, AudioEvent audioEvent)
	{
		if (!DoesEventNameExist(eventInfo))
		{
			Debug.LogError("event name is null");
		}
		else
		{
			audioEvent.Names.Add(eventInfo.Name);
		}
	}

	public AudioEventLookup(AUDIO_DATA.Root audioData)
	{
		_audioEvents = new Dictionary<string, AudioEvent>();
		_audioParameters = new Dictionary<string, AudioParameter>();
		foreach (AUDIO_DATA.Entry entry in audioData.Entries)
		{
			if (entry != null && !string.IsNullOrWhiteSpace(entry.GameAudioEvent) && entry.GameAudioEvent != "RTPC_")
			{
				if (IsRtpcEntry(entry.GameAudioEvent))
				{
					ProcessRtpcEntry(entry);
				}
				else
				{
					ProcessEventEntry(entry);
				}
			}
		}
	}
}
