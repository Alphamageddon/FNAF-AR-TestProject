using UnityEngine;

public class GameAudioDomain
{
	private const string InitSoundBankName = "Init";

	private Transform _parent;

	private EventExposer _masterEventExposer;

	private SceneLookupTableAccess _sceneLookupTableAccess;

	private MasterDataDomain _masterDataDomain;

	private AudioDomain _audioDomain;

	private bool _localGameplay;

	private AudioPlayer _audioPlayer;

	private bool _wasReset;

	private Music _music;

	private SoundEffects _soundEffects;

	private bool _audioPlayerIsReady;

	public AudioPlayer AudioPlayer => _audioPlayer;

	public GameAudioDomain(Transform parent, EventExposer masterEventExposer, SceneLookupTableAccess sceneLookupTableAccess, MasterDataDomain masterDataDomain)
	{
		_masterEventExposer = masterEventExposer;
		_sceneLookupTableAccess = sceneLookupTableAccess;
		_parent = parent;
		_masterDataDomain = masterDataDomain;
		_audioPlayer = new AudioPlayer(_masterEventExposer, _sceneLookupTableAccess, _masterDataDomain);
		_audioDomain = new AudioDomain(parent, _audioPlayer);
		_audioDomain.Setup();
		_audioPlayer.Setup(_audioDomain);
		_music = new Music(_masterEventExposer);
		_music.Setup(_audioPlayer);
		_soundEffects = new SoundEffects(_masterEventExposer);
		_soundEffects.Setup(_audioPlayer, localGameplay: false);
	}

	public void Setup(GameAssetManagementDomain gameAssetManagementDomain)
	{
		gameAssetManagementDomain.AssetCacheAccess.GetInterfaceAsync(_audioDomain.AssetCacheReady);
	}

	public void Teardown()
	{
		_soundEffects.Teardown();
		_soundEffects = null;
		_music.Teardown();
		_music = null;
		_audioPlayer.Teardown();
		_audioPlayer = null;
		_audioDomain.Teardown();
		_audioDomain = null;
	}
}
