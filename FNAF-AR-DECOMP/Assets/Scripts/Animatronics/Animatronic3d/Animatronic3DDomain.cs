using UnityEngine;

namespace Animatronics.Animatronic3d
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Animatronic3DDomain : AsyncInterfaceAccess<Animatronics.Animatronic3d.IAnimatronic3DDomain>, IAnimatronic3DDomain
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ClassName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CoreShaderCollectionName = "CoreAnimatronicShaderCollection";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string ShaderCollectionName = "AnimatronicShaderCollection";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string SharedCoreBundleName = "animatronics/sharedcore";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string SharedBundleName = "animatronics/shared";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string Animatronic3DPrefabName = "Animatronic3d";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _domainGameObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AssetManagement.GameAssetManagementDomain _gameAssetManagementDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Audio.GameAudioDomain _gameAudioDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Assets.IAssetCache _assetCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Audio.IAudioPlayer _audioPlayer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _localGameplay;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Animatronics.Animatronic3d.Animatronic3DPrefabLoader _animatronic3DLoader;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Shaders.ShaderCollectionInitializer _coreShaderInitializer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Shaders.ShaderCollectionInitializer _shaderInitializer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.Model.Animatronic3D _animatronic3DPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.PrefabManagement.PrefabCache _prefabCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Animatronics.Animatronic3d.CreationRequest>> _pendingCreationRequests;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override bool IsReady { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Animatronics.Animatronic3d.IAnimatronic3DDomain GetPublicInterface { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override bool get_IsReady()
        {
            if(this._prefabCache == null)
            {
                    return false;
            }
            
            return (bool)(this._audioPlayer != 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Animatronics.Animatronic3d.IAnimatronic3DDomain get_GetPublicInterface()
        {
            return (Animatronics.Animatronic3d.IAnimatronic3DDomain)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CreateAnimatronic3D(Animatronics.Animatronic3d.CreationRequest request)
        {
            Animatronics.Animatronic3d.Model.Animatronic3D val_9;
            if((this & 1) == 0)
            {
                goto label_1;
            }
            
            val_9 = this._animatronic3DPrefab;
            if(val_9 != 0)
            {
                goto label_4;
            }
            
            label_1:
            if(request != null)
            {
                    request._animatronicShadersComplete = true;
                request.TryToNotifyComplete();
                request._cpuSoundBankComplete = true;
                request.TryToNotifyComplete();
                request._plushSuitSoundBankComplete = true;
                request.TryToNotifyComplete();
            }
            else
            {
                    mem[56] = 1;
                0.TryToNotifyComplete();
                mem[58] = 1;
                0.TryToNotifyComplete();
                mem[59] = 1;
                0.TryToNotifyComplete();
            }
            
            request._animatronicGameObjectComplete = true;
            request.<Animatronic3D>k__BackingField = 0;
            request.TryToNotifyComplete();
            return;
            label_4:
            Game.ItemDefinition.Data.DataDefinitions.PlushSuitData val_2 = request.<ConfigData>k__BackingField.PlushSuitData;
            if((this._pendingCreationRequests.ContainsKey(key:  val_2.Id)) != true)
            {
                    this._pendingCreationRequests.Add(key:  val_2.Id, value:  new System.Collections.Generic.List<Animatronics.Animatronic3d.CreationRequest>());
            }
            
            this._pendingCreationRequests.Item[val_2.Id].Add(item:  request);
            request.add_OnRequestComplete(value:  new System.Action<Animatronics.Animatronic3d.CreationRequest>(object:  this, method:  System.Void Animatronics.Animatronic3d.Animatronic3DDomain::CreationRequestComplete(Animatronics.Animatronic3d.CreationRequest request)));
            request.LoadAnimatronicShaders(assetCache:  this._assetCache);
            request.LoadCpuSoundBank(audioPlayer:  this._audioPlayer);
            request.LoadPlushSuitSoundBank(audioPlayer:  this._audioPlayer);
            this._prefabCache.RequestAnimatronicModelContainer(configData:  request.<ConfigData>k__BackingField, onSuccess:  new System.Action<Animatronics.Animatronic3d.PrefabManagement.AnimatronicModelContainer>(object:  this, method:  System.Void Animatronics.Animatronic3d.Animatronic3DDomain::PrefabLoadSuccess(Animatronics.Animatronic3d.PrefabManagement.AnimatronicModelContainer animatronicModelContainer)), onFailure:  new System.Action<System.String>(object:  this, method:  System.Void Animatronics.Animatronic3d.Animatronic3DDomain::PrefabLoadFailure(string plushSuitId)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CreateMapIcon(AnimatronicEntity.AnimatronicConfigData configData, System.Action<Animatronics.Animatronic3d.PrefabManagement.MapIconContainer> onSuccess, System.Action<string> onFailure)
        {
            if((this & 1) == 0)
            {
                    onFailure.Invoke(obj:  "Prefab Cache not ready yet");
            }
            
            this._prefabCache.RequestMapIconContainer(configData:  configData, onSuccess:  onSuccess, onFailure:  onFailure);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PrefabLoadSuccess(Animatronics.Animatronic3d.PrefabManagement.AnimatronicModelContainer animatronicModelContainer)
        {
            Animatronics.Animatronic3d.PrefabManagement.AnimatronicModelContainer val_7;
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<Animatronics.Animatronic3d.CreationRequest>> val_8;
            val_7 = animatronicModelContainer;
            val_8 = this._pendingCreationRequests;
            if((val_8.ContainsKey(key:  animatronicModelContainer.<Id>k__BackingField)) == false)
            {
                    return;
            }
            
            List.Enumerator<T> val_3 = this._pendingCreationRequests.Item[animatronicModelContainer.<Id>k__BackingField].GetEnumerator();
            val_8 = 1152921525053045472;
            label_7:
            if(((-1028614792) & 1) == 0)
            {
                goto label_6;
            }
            
            this.ConstructAnimatronic3D(request:  0.emailUIDataHandler, animatronicModelContainer:  val_7);
            goto label_7;
            label_6:
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525053068664});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PrefabLoadFailure(string plushSuitId)
        {
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<Animatronics.Animatronic3d.CreationRequest>> val_8;
            string val_9;
            var val_10;
            val_8 = this._pendingCreationRequests;
            if((val_8.ContainsKey(key:  plushSuitId)) == false)
            {
                goto label_2;
            }
            
            val_9 = this._pendingCreationRequests.Item[plushSuitId];
            List.Enumerator<T> val_3 = val_9.GetEnumerator();
            val_8 = 1152921525053046496;
            label_7:
            if(((-1028440904) & 1) == 0)
            {
                goto label_5;
            }
            
            mem2[0] = 1;
            val_4._emailIdsToBeDeletedOnServer = 0;
            0.emailUIDataHandler.TryToNotifyComplete();
            goto label_7;
            label_2:
            val_10 = null;
            val_10 = null;
            val_9 = "Received a PrefabLoadFailure callback for an animatronic \'" + plushSuitId + "\' with no associated CreationRequest";
            ConsoleLogger.LogError(className:  Animatronics.Animatronic3d.Animatronic3DDomain.Animatronic3DPrefabName, functionName:  "PrefabLoadFailure", logString:  val_9);
            return;
            label_5:
            long val_6 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525053242552});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ConstructAnimatronic3D(Animatronics.Animatronic3d.CreationRequest request, Animatronics.Animatronic3d.PrefabManagement.AnimatronicModelContainer animatronicModelContainer)
        {
            UnityEngine.Transform val_4;
            if((request.<Parent>k__BackingField) != 0)
            {
                    val_4 = request.<Parent>k__BackingField;
            }
            else
            {
                    val_4 = this._domainGameObject.transform;
            }
            
            Animatronics.Animatronic3d.Model.Animatronic3D val_3 = UnityEngine.Object.Instantiate<Animatronics.Animatronic3d.Model.Animatronic3D>(original:  this._animatronic3DPrefab, parent:  val_4);
            val_3._audioPlayer = this._audioPlayer;
            val_3.SetModelConfig(prefab:  animatronicModelContainer.<Prefab>k__BackingField);
            request._animatronicGameObjectComplete = true;
            request.<Animatronic3D>k__BackingField = val_3;
            request.TryToNotifyComplete();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreationRequestComplete(Animatronics.Animatronic3d.CreationRequest request)
        {
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<Animatronics.Animatronic3d.CreationRequest>> val_4;
            System.Action<Animatronics.Animatronic3d.CreationRequest> val_1 = new System.Action<Animatronics.Animatronic3d.CreationRequest>(object:  this, method:  System.Void Animatronics.Animatronic3d.Animatronic3DDomain::CreationRequestComplete(Animatronics.Animatronic3d.CreationRequest request));
            if(request != null)
            {
                    request.remove_OnRequestComplete(value:  val_1);
                val_4 = this._pendingCreationRequests;
            }
            else
            {
                    0.remove_OnRequestComplete(value:  val_1);
                val_4 = this._pendingCreationRequests;
            }
            
            Game.ItemDefinition.Data.DataDefinitions.PlushSuitData val_2 = request.<ConfigData>k__BackingField.PlushSuitData;
            bool val_3 = val_4.Remove(key:  val_2.Id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronic3DDomain(UnityEngine.Transform parent, Master.EventExposer masterEventExposer, Game.AssetManagement.GameAssetManagementDomain gameAssetManagementDomain, Game.Audio.GameAudioDomain gameAudioDomain)
        {
            this._animatronic3DLoader = new Animatronics.Animatronic3d.Animatronic3DPrefabLoader();
            this._pendingCreationRequests = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<Animatronics.Animatronic3d.CreationRequest>>();
            UnityEngine.GameObject val_3 = new UnityEngine.GameObject(name:  "Animatronic3D");
            this._domainGameObject = val_3;
            val_3.transform.parent = parent;
            this._masterEventExposer = masterEventExposer;
            this._gameAssetManagementDomain = gameAssetManagementDomain;
            this._gameAudioDomain = gameAudioDomain;
            masterEventExposer.add_LocalGameplayAssetsReady(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Animatronics.Animatronic3d.Animatronic3DDomain::LocalGameplayAssetsReady(int failedAssetCount)));
            this._masterEventExposer.add_LocalGameplayEnded(value:  new System.Action(object:  this, method:  System.Void Animatronics.Animatronic3d.Animatronic3DDomain::LocalGameplayEnded()));
            this._masterEventExposer.add_AssetBundleDownloadSegmentsAllComplete(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Animatronics.Animatronic3d.Animatronic3DDomain::AssetBundleDownloadSegmentsAllComplete(int failedAssetCount)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._masterEventExposer.remove_AssetBundleDownloadSegmentsAllComplete(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Animatronics.Animatronic3d.Animatronic3DDomain::AssetBundleDownloadSegmentsAllComplete(int failedAssetCount)));
            this._masterEventExposer.remove_LocalGameplayEnded(value:  new System.Action(object:  this, method:  System.Void Animatronics.Animatronic3d.Animatronic3DDomain::LocalGameplayEnded()));
            this._masterEventExposer.remove_LocalGameplayAssetsReady(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Animatronics.Animatronic3d.Animatronic3DDomain::LocalGameplayAssetsReady(int failedAssetCount)));
            this._pendingCreationRequests.Clear();
            this._pendingCreationRequests = 0;
            this._animatronic3DPrefab = 0;
            if(this._prefabCache != null)
            {
                    this._prefabCache.Teardown();
            }
            
            this._prefabCache = 0;
            if(this._shaderInitializer != null)
            {
                    this._shaderInitializer.Teardown();
            }
            
            this._shaderInitializer = 0;
            this._animatronic3DLoader._completeCallback = 0;
            this._assetCache = 0;
            this._gameAssetManagementDomain = 0;
            this._domainGameObject = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LocalGameplayAssetsReady(int failedAssetCount)
        {
            this._masterEventExposer.remove_LocalGameplayAssetsReady(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Animatronics.Animatronic3d.Animatronic3DDomain::LocalGameplayAssetsReady(int failedAssetCount)));
            this.PrepareForUse(localGameplay:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LocalGameplayEnded()
        {
            this._masterEventExposer.remove_LocalGameplayEnded(value:  new System.Action(object:  this, method:  System.Void Animatronics.Animatronic3d.Animatronic3DDomain::LocalGameplayEnded()));
            this._prefabCache.Teardown();
            this._prefabCache = 0;
            if(this._shaderInitializer != null)
            {
                    this._shaderInitializer.Teardown();
            }
            
            this._shaderInitializer = 0;
            this._animatronic3DLoader._completeCallback = 0;
            this._assetCache = 0;
            this._audioPlayer = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AssetBundleDownloadSegmentsAllComplete(int failedAssetCount)
        {
            this._masterEventExposer.remove_AssetBundleDownloadSegmentsAllComplete(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Animatronics.Animatronic3d.Animatronic3DDomain::AssetBundleDownloadSegmentsAllComplete(int failedAssetCount)));
            this._masterEventExposer.remove_LocalGameplayEnded(value:  new System.Action(object:  this, method:  System.Void Animatronics.Animatronic3d.Animatronic3DDomain::LocalGameplayEnded()));
            this._masterEventExposer.remove_LocalGameplayAssetsReady(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Animatronics.Animatronic3d.Animatronic3DDomain::LocalGameplayAssetsReady(int failedAssetCount)));
            this.PrepareForUse(localGameplay:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PrepareForUse(bool localGameplay)
        {
            this._localGameplay = localGameplay;
            this._gameAssetManagementDomain.AssetCacheAccess.GetInterfaceAsync(callback:  new System.Action<Systems.AssetManagement.Assets.IAssetCache>(object:  this, method:  System.Void Animatronics.Animatronic3d.Animatronic3DDomain::AssetCacheReady(Systems.AssetManagement.Assets.IAssetCache assetCache)));
            this._gameAudioDomain.AudioPlayer.GetInterfaceAsync(callback:  new System.Action<Game.Audio.IAudioPlayer>(object:  this, method:  System.Void Animatronics.Animatronic3d.Animatronic3DDomain::AudioPlayerReady(Game.Audio.IAudioPlayer audioPlayer)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AssetCacheReady(Systems.AssetManagement.Assets.IAssetCache assetCache)
        {
            System.Action val_6;
            this._assetCache = assetCache;
            this._animatronic3DLoader.Load(assetCache:  assetCache, bundleName:  "animatronics/sharedcore", prefabName:  "Animatronic3d", completeCallback:  new System.Action<Animatronics.Animatronic3d.Model.Animatronic3D>(object:  this, method:  System.Void Animatronics.Animatronic3d.Animatronic3DDomain::Animatronic3DPrefabLoaderComplete(Animatronics.Animatronic3d.Model.Animatronic3D animatronic3DPrefab)));
            System.Action val_2 = null;
            val_6 = val_2;
            val_2 = new System.Action(object:  this, method:  System.Void Animatronics.Animatronic3d.Animatronic3DDomain::CoreShaderCollectionInitializerFinished());
            this._coreShaderInitializer = new Systems.AssetManagement.Shaders.ShaderCollectionInitializer(assetCache:  this._assetCache, bundleName:  "animatronics/sharedcore", shaderCollectionName:  "CoreAnimatronicShaderCollection", forceLoad:  true, onFinished:  val_2);
            if(this._localGameplay == true)
            {
                    return;
            }
            
            System.Action val_4 = null;
            val_6 = val_4;
            val_4 = new System.Action(object:  this, method:  System.Void Animatronics.Animatronic3d.Animatronic3DDomain::ShaderCollectionInitializerFinished());
            this._shaderInitializer = new Systems.AssetManagement.Shaders.ShaderCollectionInitializer(assetCache:  this._assetCache, bundleName:  "animatronics/shared", shaderCollectionName:  "AnimatronicShaderCollection", forceLoad:  true, onFinished:  val_4);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AudioPlayerReady(Game.Audio.IAudioPlayer audioPlayer)
        {
            this._audioPlayer = audioPlayer;
            this.TryToDispatchPublicInterface();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Animatronic3DPrefabLoaderComplete(Animatronics.Animatronic3d.Model.Animatronic3D animatronic3DPrefab)
        {
            var val_3;
            if(animatronic3DPrefab != 0)
            {
                    this._animatronic3DPrefab = animatronic3DPrefab;
                this.FinishInitialization();
                return;
            }
            
            val_3 = null;
            val_3 = null;
            ConsoleLogger.LogError(className:  Animatronics.Animatronic3d.Animatronic3DDomain.Animatronic3DPrefabName, functionName:  "Animatronic3DPrefabLoaderFinished", logString:  "Animatronic3d Prefab could not be loaded. " + Animatronics.Animatronic3d.Animatronic3DDomain.Animatronic3DPrefabName + " will not be able to function.");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CoreShaderCollectionInitializerFinished()
        {
            var val_3;
            if(this._coreShaderInitializer != null)
            {
                    if(this._coreShaderInitializer.ShadersReady != false)
            {
                    this.FinishInitialization();
                return;
            }
            
            }
            
            val_3 = null;
            val_3 = null;
            ConsoleLogger.LogError(className:  Animatronics.Animatronic3d.Animatronic3DDomain.Animatronic3DPrefabName, functionName:  "CoreShaderCollectionInitializerFinished", logString:  "Core shaders could not be initialized. " + Animatronics.Animatronic3d.Animatronic3DDomain.Animatronic3DPrefabName + " will not be able to function.");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ShaderCollectionInitializerFinished()
        {
            var val_3;
            if(this._shaderInitializer != null)
            {
                    if(this._shaderInitializer.ShadersReady != false)
            {
                    this.FinishInitialization();
                return;
            }
            
            }
            
            val_3 = null;
            val_3 = null;
            ConsoleLogger.LogError(className:  Animatronics.Animatronic3d.Animatronic3DDomain.Animatronic3DPrefabName, functionName:  "ShaderCollectionInitializerFinished", logString:  "Shaders could not be initialized. " + Animatronics.Animatronic3d.Animatronic3DDomain.Animatronic3DPrefabName + " will not be able to function.");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FinishInitialization()
        {
            if(this._animatronic3DPrefab == 0)
            {
                    return;
            }
            
            if(this._coreShaderInitializer.ShadersReady == false)
            {
                    return;
            }
            
            if(this._localGameplay != true)
            {
                    if(this._shaderInitializer.ShadersReady == false)
            {
                    return;
            }
            
            }
            
            this.SetupPrefabCache();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetupPrefabCache()
        {
            Animatronics.Animatronic3d.PrefabManagement.PrefabCache val_1 = new Animatronics.Animatronic3d.PrefabManagement.PrefabCache();
            this._prefabCache = val_1;
            val_1.Setup(assetCache:  this._assetCache);
            this.TryToDispatchPublicInterface();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Animatronic3DDomain()
        {
            Animatronics.Animatronic3d.Animatronic3DDomain.Animatronic3DPrefabName = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
    
    }

}
