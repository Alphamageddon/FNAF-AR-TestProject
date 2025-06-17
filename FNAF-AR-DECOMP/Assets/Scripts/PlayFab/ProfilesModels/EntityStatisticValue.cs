using UnityEngine;

namespace PlayFab.ProfilesModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class EntityStatisticValue : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, PlayFab.ProfilesModels.EntityStatisticChildValue> ChildStatistics;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Metadata;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Name;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<int> Value;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Version;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EntityStatisticValue()
        {
            val_1 = new System.Object();
        }
    
    }

}
