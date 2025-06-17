using UnityEngine;

namespace Systems.Audio.Wwise
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class WwiseSoundBank
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ClassName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const long AK_BANK_PLATFORM_DATA_ALIGNMENT = 16;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const long AK_BANK_PLATFORM_DATA_ALIGNMENT_MASK = 15;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> _onSuccess;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> _onFailure;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private IntPtr _inMemoryBankPtr;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Runtime.InteropServices.GCHandle _pinnedArray;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _bankName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private uint _bankId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Systems.AssetManagement.Assets.IAssetCache assetCache, string bankName, System.Action<string> onSuccess, System.Action<string> onFailure)
        {
            this._bankName = bankName;
            this._onSuccess = onSuccess;
            this._onFailure = onFailure;
            string val_1 = bankName + ".bytes";
            string val_3 = "audio/"("audio/") + bankName.ToLower();
            System.Action<UnityEngine.TextAsset> val_4 = new System.Action<UnityEngine.TextAsset>(object:  this, method:  System.Void Systems.Audio.Wwise.WwiseSoundBank::LoadSuccess(UnityEngine.TextAsset loadedFile));
            System.Action val_5 = new System.Action(object:  this, method:  System.Void Systems.Audio.Wwise.WwiseSoundBank::LoadFailure());
            var val_7 = 0;
            val_7 = val_7 + 1;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(assetCache, typeof(public System.Void Systems.AssetManagement.Assets.IAssetCache::LoadAssetAsync<UnityEngine.TextAsset>(string assetName, string bundleName, System.Action<T> onSuccess, System.Action onFailure).__il2cppRuntimeField_18), slot: 0) + 8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LoadSuccess(UnityEngine.TextAsset loadedFile)
        {
            if((AkSoundEngine.LoadBank(in_pInMemoryBankPtr:  this._inMemoryBankPtr, in_uInMemoryBankSize:  this.AllocateAlignedBuffer(data:  loadedFile.bytes), out_bankID: out  this._bankId)) == 1)
            {
                    if(this._onSuccess != null)
            {
                    this._onSuccess.Invoke(obj:  this._bankName);
            }
            
                this._onSuccess = 0;
                mem[1152921523409578792] = 0;
                return;
            }
            
            if(this._onFailure != null)
            {
                    this._onFailure.Invoke(obj:  this._bankName);
            }
            
            this._onSuccess = 0;
            this._onFailure = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LoadFailure()
        {
            if(this._onFailure != null)
            {
                    this._onFailure.Invoke(obj:  this._bankName);
            }
            
            this._onSuccess = 0;
            this._onFailure = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ClearCallbacks()
        {
            this._onSuccess = 0;
            this._onFailure = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._onSuccess = 0;
            this._onFailure = 0;
            if((System.IntPtr.op_Equality(value1:  this._inMemoryBankPtr, value2:  0)) == true)
            {
                    return;
            }
            
            if((AkSoundEngine.UnloadBank(in_bankID:  this._bankId, in_pInMemoryBankPtr:  this._inMemoryBankPtr)) != 1)
            {
                    return;
            }
            
            this = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private uint AllocateAlignedBuffer(byte[] data)
        {
            var val_13;
            System.Runtime.InteropServices.GCHandle val_1 = System.Runtime.InteropServices.GCHandle.Alloc(value:  data, type:  3);
            this._pinnedArray = val_1;
            this._inMemoryBankPtr = 1152921523410166072;
            if((this._inMemoryBankPtr.ToInt64() & 15) == 0)
            {
                    return (uint)data.Length;
            }
            
            int val_4 = data.Length + 16;
            byte[] val_5 = new byte[0];
            System.Runtime.InteropServices.GCHandle val_6 = System.Runtime.InteropServices.GCHandle.Alloc(value:  val_5, type:  3);
            if((val_6.handle.emailUIDataHandler & 15) != null)
            {
                    GameUI.EmailUIDataHandler val_12 = val_6.handle.emailUIDataHandler;
                val_12 = (val_12 + 15) & (-16);
                val_6.handle.emailUIDataHandler = val_12;
                val_13 = val_12 - val_6.handle.emailUIDataHandler;
            }
            else
            {
                    val_13 = 0;
            }
            
            System.Array.Copy(sourceArray:  data, sourceIndex:  0, destinationArray:  val_5, destinationIndex:  0, length:  data.Length);
            mem[1152921523410166064] = val_6.handle;
            this._pinnedArray = val_6;
            return (uint)data.Length;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WwiseSoundBank()
        {
            this._inMemoryBankPtr = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static WwiseSoundBank()
        {
            Systems.Audio.Wwise.WwiseSoundBank.AK_BANK_PLATFORM_DATA_ALIGNMENT_MASK = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
    
    }

}
