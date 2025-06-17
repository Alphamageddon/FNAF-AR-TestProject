using UnityEngine;

namespace AppStoresSupport
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class AppStoreSettings : ScriptableObject
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string UnityClientID;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string UnityClientKey;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string UnityClientRSAPublicKey;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AppStoresSupport.AppStoreSetting XiaomiAppStoreSetting;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Store.AppInfo getAppInfo()
        {
            string val_3;
            UnityEngine.Store.AppInfo val_1 = new UnityEngine.Store.AppInfo();
            if(val_1 != null)
            {
                    val_1.clientId = this.UnityClientID;
                val_3 = this.UnityClientKey;
            }
            else
            {
                    val_1.clientId = this.UnityClientID;
                val_3 = this.UnityClientKey;
            }
            
            val_1.clientKey = val_3;
            val_1.appId = this.XiaomiAppStoreSetting.AppID;
            val_1.appKey = this.XiaomiAppStoreSetting.AppKey;
            val_1.debug = (this.XiaomiAppStoreSetting.IsTestMode == true) ? 1 : 0;
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AppStoreSettings()
        {
            this.UnityClientID = "";
            this.UnityClientKey = "";
            this.UnityClientRSAPublicKey = "";
            this.XiaomiAppStoreSetting = new AppStoresSupport.AppStoreSetting();
        }
    
    }

}
