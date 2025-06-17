using UnityEngine;

namespace Systems.Audio.Wwise
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LoadingSoundBank
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string _soundBankName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Systems.Audio.Wwise.SoundBankRequest> _pendingRequests;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Audio.Wwise.WwiseSoundBank _loadingSoundBank;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string, Systems.Audio.Wwise.WwiseSoundBank> _onSuccess;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> _onFailure;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LoadingSoundBank(Systems.Audio.Wwise.SoundBankRequest request, System.Action<string, Systems.Audio.Wwise.WwiseSoundBank> onSuccess, System.Action<string> onFailure)
        {
            this._pendingRequests = new System.Collections.Generic.List<Systems.Audio.Wwise.SoundBankRequest>();
            this._soundBankName = request.SoundBankName;
            this._pendingRequests.Add(item:  request);
            this._onSuccess = onSuccess;
            this._onFailure = onFailure;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddRequest(Systems.Audio.Wwise.SoundBankRequest request)
        {
            this._pendingRequests.Add(item:  request);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Load(Systems.AssetManagement.Assets.IAssetCache assetCache)
        {
            Systems.Audio.Wwise.WwiseSoundBank val_1 = new Systems.Audio.Wwise.WwiseSoundBank();
            this._loadingSoundBank = val_1;
            val_1.Setup(assetCache:  assetCache, bankName:  this._soundBankName, onSuccess:  new System.Action<System.String>(object:  this, method:  System.Void Systems.Audio.Wwise.LoadingSoundBank::LoadSuccess(string soundBankName)), onFailure:  new System.Action<System.String>(object:  this, method:  System.Void Systems.Audio.Wwise.LoadingSoundBank::LoadFailure(string soundBankName)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LoadSuccess(string soundBankName)
        {
            List.Enumerator<T> val_1 = this._pendingRequests.GetEnumerator();
            label_5:
            if((1622151496 & 1) == 0)
            {
                goto label_2;
            }
            
            if((0.emailUIDataHandler == null) || (val_2._serverGameUIDataModel == null))
            {
                goto label_5;
            }
            
            val_2._serverGameUIDataModel.Invoke(obj:  this._soundBankName);
            goto label_5;
            label_2:
            long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523408867656});
            if(this._onSuccess == null)
            {
                    return;
            }
            
            this._onSuccess.Invoke(arg1:  this._soundBankName, arg2:  this._loadingSoundBank);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LoadFailure(string soundBankName)
        {
            List.Enumerator<T> val_1 = this._pendingRequests.GetEnumerator();
            label_5:
            if((1622333128 & 1) == 0)
            {
                goto label_2;
            }
            
            if((0.emailUIDataHandler == null) || (val_2._emailDatas == null))
            {
                goto label_5;
            }
            
            val_2._emailDatas.Invoke(obj:  this._soundBankName);
            goto label_5;
            label_2:
            long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523409049288});
            if(this._onFailure == null)
            {
                    return;
            }
            
            this._onFailure.Invoke(obj:  this._soundBankName);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._pendingRequests.Clear();
            this._pendingRequests = 0;
            mem[1152921523409211288] = 0;
        }
    
    }

}
