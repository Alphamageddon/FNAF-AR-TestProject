using UnityEngine;

namespace PlayFab.ProfilesModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class EntityKey : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Id;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Type;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EntityKey()
        {
            val_1 = new System.Object();
        }
    
    }

}
