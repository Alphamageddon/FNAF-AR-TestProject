using System;
using FMODUnity;
using UnityEngine;

public class AudioDomain
{
	private enum Game_Mode
	{
		None = 0,
		Map = 1,
		Encounter = 2,
		Reward = 3,
		Camera = 4,
		Remnant = 5,
		Ad = 6,
		Store = 7,
		Inbox = 8,
		Scavenging = 9
	}

	private const string WwiseInitializerResourcesPath = "Audio/WwiseInitializer";

	private GameObject _initializerPrefab;

	private readonly Transform _domainParent;

	private StudioListener _listener;

	private AudioPlayer player;

	public SoundBankLoader SoundBankLoader;

	public bool IsReady => true;

	public AnimatronicAudioManager MakeNewEmitter(string name)
	{
		GameObject gameObject = new GameObject(name);
		gameObject.transform.parent = _listener.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localEulerAngles = Vector3.zero;
		return gameObject.AddComponent<AnimatronicAudioManager>();
	}

	public void SetEmittersListener(AnimatronicAudioManager emitter)
	{
	}

	public void SetListenerParent(Transform parent)
	{
		_listener.transform.parent = parent;
		_listener.transform.localPosition = Vector3.zero;
		_listener.transform.localEulerAngles = Vector3.zero;
	}

	public Transform GetListenerParent()
	{
		return _listener.transform.parent;
	}

	public void SetState(string group, string state)
	{
		if (state == "MaskOn")
		{
			RuntimeManager.PlayOneShot("event:/MaskState");
			RuntimeManager.StudioSystem.setParameterByName(group, 0f);
		}
		if (state == "MaskOff")
		{
			RuntimeManager.StudioSystem.setParameterByName(group, 1f);
		}
		if (group == "Game_Mode")
		{
			Game_Mode game_Mode = (Game_Mode)Enum.Parse(typeof(Game_Mode), state);
			int num = (int)game_Mode;
			Debug.Log("Setting Game_Mode to " + state + " index " + num);
			RuntimeManager.StudioSystem.setParameterByName(group, (float)game_Mode);
		}
	}

	public AudioDomain(Transform parent, AudioPlayer _player)
	{
		_domainParent = parent;
		player = _player;
	}

	public void Setup()
	{
		Transform transform = new GameObject("AudioDomain").transform;
		transform.parent = _domainParent;
		_initializerPrefab = UnityEngine.Object.Instantiate(new GameObject("Initializer"), transform);
		GameObject gameObject = new GameObject("AkAudioListener");
		_listener = gameObject.AddComponent<StudioListener>();
		RuntimeManager.SetListenerLocation(_listener.gameObject); // ?
		SetListenerParent(_domainParent);
	}

	public void AssetCacheReady(AssetCache cache)
	{
		SoundBankLoader = new SoundBankLoader(cache);
		player.ReceivedSoundBankLoader();
	}

	public void Teardown()
	{
		_listener = null;
	}
}
