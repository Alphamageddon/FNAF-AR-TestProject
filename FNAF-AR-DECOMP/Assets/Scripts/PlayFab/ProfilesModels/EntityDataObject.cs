using UnityEngine;

namespace PlayFab.ProfilesModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class EntityDataObject : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public object DataObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string EscapedDataObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ObjectName;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EntityDataObject()
        {
            val_1 = new System.Object();
        }
    
    }

}
