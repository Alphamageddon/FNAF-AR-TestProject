using UnityEngine;

namespace PlayFab.ProfilesModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class EntityProfileBody : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string AvatarUrl;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTime Created;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DisplayName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ProfilesModels.EntityKey Entity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string EntityChain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, PlayFab.ProfilesModels.EntityProfileFileMetadata> Files;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Language;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string LeaderboardMetadata;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ProfilesModels.EntityLineage Lineage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, PlayFab.ProfilesModels.EntityDataObject> Objects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ProfilesModels.EntityPermissionStatement> Permissions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, PlayFab.ProfilesModels.EntityStatisticValue> Statistics;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int VersionNumber;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EntityProfileBody()
        {
            val_1 = new System.Object();
        }
    
    }

}
