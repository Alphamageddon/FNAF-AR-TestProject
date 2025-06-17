using UnityEngine;

namespace Systems.Ads
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AdProviderManager
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Systems.Ads.TapjoyAds.ITapjoyManager _tapjoyManagerInterface;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Systems.Ads.TapjoyAds.TapjoyManager _tapjoyManager;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Systems.Ads.TapjoyAds.TapjoyConfig _tapjoyConfig;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Systems.Ads.TapjoyAds.ITapjoyManager> _startupCallback;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AdProviderManager(Systems.Ads.TapjoyAds.TapjoyConfig tapjoyConfig)
        {
            this._tapjoyConfig = tapjoyConfig;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void StartTapjoy(string tapjoyUserId, System.Action<Systems.Ads.TapjoyAds.ITapjoyManager> callback)
        {
            string val_4;
            object val_5;
            Systems.Ads.TapjoyAds.ITapjoyManager val_6;
            var val_7;
            Systems.Ads.TapjoyAds.TapjoyConfig val_8;
            val_4 = tapjoyUserId;
            val_5 = this;
            val_6 = Systems.Ads.AdProviderManager._tapjoyManagerInterface;
            if(val_6 == null)
            {
                goto label_1;
            }
            
            if(callback == null)
            {
                    return;
            }
            
            val_7 = 1152921523462942016;
            goto label_3;
            label_1:
            if(this._startupCallback == null)
            {
                goto label_4;
            }
            
            if(callback == null)
            {
                    return;
            }
            
            val_7 = 1152921523462942016;
            val_6 = 0;
            label_3:
            callback.Invoke(obj:  val_6);
            return;
            label_4:
            this._startupCallback = callback;
            Systems.Ads.TapjoyAds.TapjoyManagerCreationParams val_1 = new Systems.Ads.TapjoyAds.TapjoyManagerCreationParams();
            if(val_1 != null)
            {
                    .UserId = val_4;
                val_8 = this._tapjoyConfig;
            }
            else
            {
                    mem[16] = val_4;
                val_8 = this._tapjoyConfig;
            }
            
            .Config = val_8;
            System.Action val_2 = null;
            val_4 = val_2;
            val_2 = new System.Action(object:  this, method:  System.Void Systems.Ads.AdProviderManager::TapjoyConnected());
            .ConnectedCallback = val_4;
            Systems.Ads.TapjoyAds.TapjoyManager val_3 = null;
            val_5 = val_3;
            val_3 = new Systems.Ads.TapjoyAds.TapjoyManager(creationParams:  val_1);
            Systems.Ads.AdProviderManager._tapjoyManager = val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TapjoyConnected()
        {
            Systems.Ads.AdProviderManager._tapjoyManagerInterface = Systems.Ads.AdProviderManager._tapjoyManager;
            if(this._startupCallback != null)
            {
                    this._startupCallback.Invoke(obj:  Systems.Ads.AdProviderManager._tapjoyManagerInterface);
            }
            
            this._startupCallback = 0;
        }
    
    }

}
