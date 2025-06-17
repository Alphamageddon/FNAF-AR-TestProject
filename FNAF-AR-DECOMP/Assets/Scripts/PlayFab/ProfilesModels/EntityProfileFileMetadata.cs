using UnityEngine;

namespace PlayFab.ProfilesModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class EntityProfileFileMetadata : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Checksum;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string FileName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTime LastModified;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Size;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EntityProfileFileMetadata()
        {
            val_1 = new System.Object();
        }
    
    }

}
