using UnityEngine;

namespace Systems.Audio
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AudioDomain : AsyncInterfaceAccess<Systems.Audio.IAudioDomain>, IAudioDomain
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string WwiseInitializerResourcesPath = "Audio/WwiseInitializer";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly UnityEngine.GameObject _initializerPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly UnityEngine.Transform _domainParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Assets.IAssetCache _assetCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Audio.Wwise.SoundBankLoader _soundBankLoader;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AkAudioListener _listener;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Audio.Wwise.ISoundBankLoader SoundBankLoader { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override bool IsReady { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Systems.Audio.IAudioDomain GetPublicInterface { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Audio.Wwise.ISoundBankLoader get_SoundBankLoader()
        {
            return (Systems.Audio.Wwise.ISoundBankLoader)this._soundBankLoader;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override bool get_IsReady()
        {
            return AkSoundEngine.IsInitialized();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Systems.Audio.IAudioDomain get_GetPublicInterface()
        {
            return (Systems.Audio.IAudioDomain)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Audio.Components.AkAudioEmitter MakeNewEmitter(string name)
        {
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  name);
            UnityEngine.Transform val_2 = val_1.transform;
            val_2.parent = this._listener.transform;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            val_2.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            val_2.localEulerAngles = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            AkGameObj val_6 = val_1.AddComponent<AkGameObj>();
            if(val_6 != null)
            {
                    val_6.isEnvironmentAware = false;
            }
            else
            {
                    mem[32] = 0;
            }
            
            val_6.SetUseDefaultListeners(useDefault:  true);
            if(val_1 != null)
            {
                    return val_1.AddComponent<Systems.Audio.Components.AkAudioEmitter>();
            }
            
            return val_1.AddComponent<Systems.Audio.Components.AkAudioEmitter>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetEmittersListener(Systems.Audio.Components.AkAudioEmitter emitter)
        {
            emitter.SetListener(akAudioListener:  this._listener);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetListenerParent(UnityEngine.Transform parent)
        {
            UnityEngine.Transform val_1 = this._listener.transform;
            val_1.parent = parent;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            val_1.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            val_1.localEulerAngles = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetState(string group, string state)
        {
            AKRESULT val_1 = AkSoundEngine.SetState(in_pszStateGroup:  group, in_pszState:  state);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AudioDomain(UnityEngine.Transform parent)
        {
            this._domainParent = parent;
            this._initializerPrefab = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Audio/WwiseInitializer");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup()
        {
            UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this._initializerPrefab, parent:  new UnityEngine.GameObject(name:  "AudioDomain").transform);
            UnityEngine.GameObject val_4 = new UnityEngine.GameObject(name:  "AkAudioListener");
            AkGameObj val_5 = val_4.AddComponent<AkGameObj>();
            if(val_5 != null)
            {
                    val_5.isEnvironmentAware = false;
            }
            else
            {
                    mem[32] = 0;
            }
            
            val_5.SetUseDefaultListeners(useDefault:  true);
            AkAudioListener val_6 = val_4.AddComponent<AkAudioListener>();
            this._listener = val_6;
            val_6.SetIsDefaultListener(isDefault:  true);
            this.SetListenerParent(parent:  this._domainParent);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAssetCache(Systems.AssetManagement.Assets.IAssetCache assetCache)
        {
            this._assetCache = assetCache;
            this._soundBankLoader = new Systems.Audio.Wwise.SoundBankLoader(assetCache:  assetCache);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClearSoundbanks()
        {
            if(this._soundBankLoader != null)
            {
                    this._soundBankLoader.Teardown();
            }
            
            this._soundBankLoader = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._listener = 0;
            if(this._soundBankLoader != null)
            {
                    this._soundBankLoader.Teardown();
            }
            
            this._soundBankLoader = 0;
        }
    
    }

}
