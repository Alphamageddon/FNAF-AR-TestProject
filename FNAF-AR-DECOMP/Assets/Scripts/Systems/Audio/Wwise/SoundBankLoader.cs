using UnityEngine;

namespace Systems.Audio.Wwise
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SoundBankLoader : ISoundBankLoader
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ClassName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Assets.IAssetCache _assetCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string _platform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, Systems.Audio.Wwise.WwiseSoundBank> _loadedSoundBanks;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, Systems.Audio.Wwise.LoadingSoundBank> _loadingSoundBanks;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RequestSoundBank(Systems.Audio.Wwise.SoundBankRequest request)
        {
            var val_7;
            if(request == null)
            {
                goto label_1;
            }
            
            if((this._loadedSoundBanks.ContainsKey(key:  request.SoundBankName)) == false)
            {
                goto label_3;
            }
            
            if(request.Success == null)
            {
                    return;
            }
            
            request.Success.Invoke(obj:  request.SoundBankName);
            return;
            label_1:
            val_7 = null;
            val_7 = null;
            ConsoleLogger.LogError(className:  Systems.Audio.Wwise.SoundBankLoader.ClassName, functionName:  "RequestSoundBank", logString:  "SoundBankRequest is null");
            return;
            label_3:
            if((this._loadingSoundBanks.ContainsKey(key:  request.SoundBankName)) != false)
            {
                    this._loadingSoundBanks.Item[request.SoundBankName].AddRequest(request:  request);
                return;
            }
            
            Systems.Audio.Wwise.LoadingSoundBank val_6 = new Systems.Audio.Wwise.LoadingSoundBank(request:  request, onSuccess:  new System.Action<System.String, Systems.Audio.Wwise.WwiseSoundBank>(object:  this, method:  System.Void Systems.Audio.Wwise.SoundBankLoader::LoadSuccess(string soundBankName, Systems.Audio.Wwise.WwiseSoundBank loadedSoundBank)), onFailure:  new System.Action<System.String>(object:  this, method:  System.Void Systems.Audio.Wwise.SoundBankLoader::LoadFailure(string soundBankName)));
            this._loadingSoundBanks.Add(key:  request.SoundBankName, value:  val_6);
            val_6.Load(assetCache:  this._assetCache);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LoadSuccess(string soundBankName, Systems.Audio.Wwise.WwiseSoundBank loadedSoundBank)
        {
            this._loadingSoundBanks.Item[soundBankName].Teardown();
            bool val_2 = this._loadingSoundBanks.Remove(key:  soundBankName);
            this._loadedSoundBanks.Add(key:  soundBankName, value:  loadedSoundBank);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LoadFailure(string soundBankName)
        {
            this._loadingSoundBanks.Item[soundBankName].Teardown();
            bool val_2 = this._loadingSoundBanks.Remove(key:  soundBankName);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SoundBankLoader(Systems.AssetManagement.Assets.IAssetCache assetCache)
        {
            this._loadedSoundBanks = new System.Collections.Generic.Dictionary<System.String, Systems.Audio.Wwise.WwiseSoundBank>();
            this._loadingSoundBanks = new System.Collections.Generic.Dictionary<System.String, Systems.Audio.Wwise.LoadingSoundBank>();
            this._assetCache = assetCache;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            var val_4;
            var val_13;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this._loadedSoundBanks.Values.GetEnumerator();
            label_5:
            if((1621281840 & 1) == 0)
            {
                goto label_3;
            }
            
            val_4.emailUIDataHandler.Teardown();
            goto label_5;
            label_3:
            long val_6 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523407998000});
            val_13 = 0;
            this._loadedSoundBanks.Clear();
            this._loadedSoundBanks = 0;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_9 = this._loadingSoundBanks.Values.GetEnumerator();
            label_15:
            if((1621281816 & 1) == 0)
            {
                goto label_13;
            }
            
            0.emailUIDataHandler.Teardown();
            goto label_15;
            label_13:
            long val_11 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523407997976});
            this._loadingSoundBanks.Clear();
            this._loadingSoundBanks = 0;
            this._assetCache = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SoundBankLoader()
        {
            Systems.Audio.Wwise.SoundBankLoader.ClassName = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
    
    }

}
