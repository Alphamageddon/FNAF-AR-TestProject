using UnityEngine;

namespace PlayFab.DataModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class SetObject : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public object DataObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> DeleteObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string EscapedDataObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ObjectName;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SetObject()
        {
        
        }
    
    }

}
