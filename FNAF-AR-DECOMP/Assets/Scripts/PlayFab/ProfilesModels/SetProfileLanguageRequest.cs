using UnityEngine;

namespace PlayFab.ProfilesModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class SetProfileLanguageRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ProfilesModels.EntityKey Entity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<int> ExpectedVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Language;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SetProfileLanguageRequest()
        {
            val_1 = new System.Object();
        }
    
    }

}
