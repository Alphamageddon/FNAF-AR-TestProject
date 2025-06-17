using UnityEngine;

namespace PlayFab.GroupsModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class EntityWithLineage : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.GroupsModels.EntityKey Key;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, PlayFab.GroupsModels.EntityKey> Lineage;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EntityWithLineage()
        {
        
        }
    
    }

}
