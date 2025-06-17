using UnityEngine;

namespace PlayFab.ProfilesModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class EntityLineage : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CharacterId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GroupId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string MasterPlayerAccountId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string NamespaceId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TitleId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TitlePlayerAccountId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EntityLineage()
        {
            val_1 = new System.Object();
        }
    
    }

}
