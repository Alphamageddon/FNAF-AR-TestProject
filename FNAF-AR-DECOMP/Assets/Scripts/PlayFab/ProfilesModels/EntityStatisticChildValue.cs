using UnityEngine;

namespace PlayFab.ProfilesModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class EntityStatisticChildValue : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ChildName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Metadata;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Value;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EntityStatisticChildValue()
        {
            val_1 = new System.Object();
        }
    
    }

}
