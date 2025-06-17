using UnityEngine;

namespace PlayFab.DataModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ObjectResult : PlayFabBaseModel
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
        public ObjectResult()
        {
        
        }
    
    }

}
