using UnityEngine;

namespace AppStoresSupport
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class AppStoreSetting
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string AppID;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string AppKey;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsTestMode;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AppStoreSetting()
        {
            this.AppID = "";
            this.AppKey = "";
        }
    
    }

}
