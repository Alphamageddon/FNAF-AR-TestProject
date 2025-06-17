using UnityEngine;

namespace Game.Audio
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GameAudioDomain
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string InitSoundBankName = "Init";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform _parent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.SceneLookupTableAccess _sceneLookupTableAccess;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AssetManagement.GameAssetManagementDomain _gameAssetManagementDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.MasterData.MasterDataDomain _masterDataDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Audio.AudioDomain _audioDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Audio.IAudioDomain _audioDomainInterface;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _localGameplay;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Audio.AudioPlayer _audioPlayer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _wasReset;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Audio.Music _music;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Audio.SoundEffects _soundEffects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _audioPlayerIsReady;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Utilities.AsyncInterfaceAccess<Game.Audio.IAudioPlayer> AudioPlayer { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Utilities.AsyncInterfaceAccess<Game.Audio.IAudioPlayer> get_AudioPlayer()
        {
            return (Utilities.AsyncInterfaceAccess<Game.Audio.IAudioPlayer>)this._audioPlayer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameAudioDomain(UnityEngine.Transform parent, Master.EventExposer masterEventExposer, Master.SceneLookupTableAccess sceneLookupTableAccess, Game.AssetManagement.GameAssetManagementDomain gameAssetManagementDomain, Game.MasterData.MasterDataDomain masterDataDomain)
        {
            val_1 = new System.Object();
            this._parent = parent;
            this._masterEventExposer = val_1;
            this._sceneLookupTableAccess = sceneLookupTableAccess;
            this._gameAssetManagementDomain = gameAssetManagementDomain;
            this._masterDataDomain = masterDataDomain;
            this.Setup();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup()
        {
            this._audioDomain = new Systems.Audio.AudioDomain(parent:  this._parent);
            this._audioPlayer = new Game.Audio.AudioPlayer(masterEventExposer:  this._masterEventExposer, sceneLookupTableAccess:  this._sceneLookupTableAccess, masterDataDomain:  this._masterDataDomain);
            this._music = new Game.Audio.Music(masterEventExposer:  this._masterEventExposer);
            ._masterEventExposer = this._masterEventExposer;
            this._soundEffects = new Game.Audio.SoundEffects();
            this._masterEventExposer.add_LocalGameplayAssetsReady(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Game.Audio.GameAudioDomain::LocalGameplayAssetsReady(int failedAssetCount)));
            this._masterEventExposer.add_LocalGameplayEnded(value:  new System.Action(object:  this, method:  System.Void Game.Audio.GameAudioDomain::LocalGameplayEnded()));
            this._masterEventExposer.add_AssetBundleDownloadSegmentsAllComplete(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Game.Audio.GameAudioDomain::AssetBundleDownloadSegmentsAllComplete(int failedAssetCount)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._soundEffects.Teardown();
            this._soundEffects = 0;
            this._music.Teardown();
            this._music = 0;
            this._audioPlayer.Teardown();
            this._audioPlayer = 0;
            this._audioDomain.Teardown();
            this._audioDomain = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LocalGameplayAssetsReady(int failedAssetCount)
        {
            this._masterEventExposer.remove_LocalGameplayAssetsReady(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Game.Audio.GameAudioDomain::LocalGameplayAssetsReady(int failedAssetCount)));
            this._localGameplay = true;
            this._audioDomain.Setup();
            System.Action<Systems.Audio.IAudioDomain> val_2 = new System.Action<Systems.Audio.IAudioDomain>(object:  this, method:  System.Void Game.Audio.GameAudioDomain::AudioDomainReady(Systems.Audio.IAudioDomain audioDomain));
            this._audioDomain.GetInterfaceAsync(callback:  null);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LocalGameplayEnded()
        {
            this._masterEventExposer.remove_LocalGameplayEnded(value:  new System.Action(object:  this, method:  System.Void Game.Audio.GameAudioDomain::LocalGameplayEnded()));
            this._wasReset = true;
            if(this._soundEffects != null)
            {
                    this._soundEffects.Teardown();
            }
            
            ._masterEventExposer = this._masterEventExposer;
            this._soundEffects = new Game.Audio.SoundEffects();
            this._music.Reset();
            if(this._audioPlayer.SoundBankLoader == null)
            {
                    return;
            }
            
            this._audioDomain.ClearSoundbanks();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AssetBundleDownloadSegmentsAllComplete(int failedAssetCount)
        {
            System.Action<Systems.AssetManagement.Assets.IAssetCache> val_7;
            this._masterEventExposer.remove_AssetBundleDownloadSegmentsAllComplete(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Game.Audio.GameAudioDomain::AssetBundleDownloadSegmentsAllComplete(int failedAssetCount)));
            this._masterEventExposer.remove_LocalGameplayEnded(value:  new System.Action(object:  this, method:  System.Void Game.Audio.GameAudioDomain::LocalGameplayEnded()));
            this._masterEventExposer.remove_LocalGameplayAssetsReady(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Game.Audio.GameAudioDomain::LocalGameplayAssetsReady(int failedAssetCount)));
            this._localGameplay = false;
            if(this._audioDomainInterface != null)
            {
                    val_7 = null;
                val_7 = new System.Action<Systems.AssetManagement.Assets.IAssetCache>(object:  this, method:  System.Void Game.Audio.GameAudioDomain::AssetCacheReady(Systems.AssetManagement.Assets.IAssetCache assetCache));
                this._gameAssetManagementDomain.AssetCacheAccess.GetInterfaceAsync(callback:  null);
                return;
            }
            
            this._audioDomain.Setup();
            val_7 = null;
            val_7 = new System.Action<Systems.Audio.IAudioDomain>(object:  this, method:  System.Void Game.Audio.GameAudioDomain::AudioDomainReady(Systems.Audio.IAudioDomain audioDomain));
            this._audioDomain.GetInterfaceAsync(callback:  null);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AudioDomainReady(Systems.Audio.IAudioDomain audioDomain)
        {
            this._audioDomainInterface = audioDomain;
            this._gameAssetManagementDomain.AssetCacheAccess.GetInterfaceAsync(callback:  new System.Action<Systems.AssetManagement.Assets.IAssetCache>(object:  this, method:  System.Void Game.Audio.GameAudioDomain::AssetCacheReady(Systems.AssetManagement.Assets.IAssetCache assetCache)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AssetCacheReady(Systems.AssetManagement.Assets.IAssetCache assetCache)
        {
            IntPtr val_6;
            var val_7;
            System.Action<System.String> val_9;
            this._audioDomain.SetAssetCache(assetCache:  assetCache);
            .SoundBankName = "Init";
            System.Action<System.String> val_3 = null;
            val_6 = System.Void Game.Audio.GameAudioDomain::<AssetCacheReady>b__23_0(string soundBankName);
            val_3 = new System.Action<System.String>(object:  this, method:  val_6);
            .Success = val_3;
            val_7 = null;
            val_7 = null;
            val_9 = GameAudioDomain.<>c.<>9__23_1;
            if(val_9 == null)
            {
                    System.Action<System.String> val_4 = null;
                val_9 = val_4;
                val_6 = System.Void GameAudioDomain.<>c::<AssetCacheReady>b__23_1(string soundBankName);
                val_4 = new System.Action<System.String>(object:  GameAudioDomain.<>c.__il2cppRuntimeField_static_fields, method:  val_6);
                GameAudioDomain.<>c.<>9__23_1 = val_9;
            }
            
            .Failure = val_9;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_6 = 0;
            this._audioDomain.SoundBankLoader.RequestSoundBank(request:  new Systems.Audio.Wwise.SoundBankRequest());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AudioPlayerReady(Game.Audio.IAudioPlayer audioPlayer)
        {
            IntPtr val_13;
            var val_15;
            System.Action<System.String> val_17;
            System.Action<System.String> val_19;
            IntPtr val_21;
            Systems.Audio.Wwise.SoundBankRequest val_22;
            var val_23;
            var val_25;
            System.Action<System.String> val_27;
            System.Action<System.String> val_29;
            this._music.Setup(audioPlayer:  audioPlayer);
            this._soundEffects.Setup(audioPlayer:  audioPlayer, localGameplay:  (this._localGameplay == true) ? 1 : 0);
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_13 = 0;
            .SoundBankName = "UI";
            val_15 = null;
            val_15 = null;
            val_17 = GameAudioDomain.<>c.<>9__24_0;
            if(val_17 == null)
            {
                    System.Action<System.String> val_5 = null;
                val_17 = val_5;
                val_13 = System.Void GameAudioDomain.<>c::<AudioPlayerReady>b__24_0(string soundBankName);
                val_5 = new System.Action<System.String>(object:  GameAudioDomain.<>c.__il2cppRuntimeField_static_fields, method:  val_13);
                val_15 = null;
                GameAudioDomain.<>c.<>9__24_0 = val_17;
            }
            
            .Success = val_17;
            val_15 = null;
            val_19 = GameAudioDomain.<>c.<>9__24_1;
            if(val_19 == null)
            {
                    System.Action<System.String> val_6 = null;
                val_19 = val_6;
                val_13 = System.Void GameAudioDomain.<>c::<AudioPlayerReady>b__24_1(string soundBankName);
                val_6 = new System.Action<System.String>(object:  GameAudioDomain.<>c.__il2cppRuntimeField_static_fields, method:  val_13);
                GameAudioDomain.<>c.<>9__24_1 = val_19;
            }
            
            .Failure = val_19;
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_13 = 0;
            val_21 = public System.Void Systems.Audio.Wwise.ISoundBankLoader::RequestSoundBank(Systems.Audio.Wwise.SoundBankRequest request);
            audioPlayer.SoundBankLoader.RequestSoundBank(request:  new Systems.Audio.Wwise.SoundBankRequest());
            val_22 = 1152921505261690880;
            val_23 = null;
            val_23 = null;
            if((UnityEngine.PlayerPrefs.HasKey(key:  Game.Server.TutorialDataResponseHandler.IgnoreFTUEVO)) != true)
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                val_21 = 0;
                Systems.Audio.Wwise.SoundBankRequest val_11 = null;
                val_22 = val_11;
                val_11 = new Systems.Audio.Wwise.SoundBankRequest();
                .SoundBankName = "VO";
                val_25 = null;
                val_25 = null;
                val_27 = GameAudioDomain.<>c.<>9__24_2;
                if(val_27 == null)
            {
                    System.Action<System.String> val_12 = null;
                val_27 = val_12;
                val_21 = System.Void GameAudioDomain.<>c::<AudioPlayerReady>b__24_2(string soundBankName);
                val_12 = new System.Action<System.String>(object:  GameAudioDomain.<>c.__il2cppRuntimeField_static_fields, method:  val_21);
                val_25 = null;
                GameAudioDomain.<>c.<>9__24_2 = val_27;
            }
            
                .Success = val_27;
                val_25 = null;
                val_29 = GameAudioDomain.<>c.<>9__24_3;
                if(val_29 == null)
            {
                    System.Action<System.String> val_13 = null;
                val_29 = val_13;
                val_21 = System.Void GameAudioDomain.<>c::<AudioPlayerReady>b__24_3(string soundBankName);
                val_13 = new System.Action<System.String>(object:  GameAudioDomain.<>c.__il2cppRuntimeField_static_fields, method:  val_21);
                GameAudioDomain.<>c.<>9__24_3 = val_29;
            }
            
                .Failure = val_29;
                var val_18 = 0;
                val_18 = val_18 + 1;
                val_21 = 0;
                audioPlayer.SoundBankLoader.RequestSoundBank(request:  val_11);
            }
            
            this._audioPlayerIsReady = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsAudioPlayerReady()
        {
            return (bool)this._audioPlayerIsReady;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <AssetCacheReady>b__23_0(string soundBankName)
        {
            if(this._wasReset != true)
            {
                    this._audioPlayer.Setup(audioDomain:  this._audioDomain);
            }
            
            this._audioPlayer.GetInterfaceAsync(callback:  new System.Action<Game.Audio.IAudioPlayer>(object:  this, method:  System.Void Game.Audio.GameAudioDomain::AudioPlayerReady(Game.Audio.IAudioPlayer audioPlayer)));
        }
    
    }

}
