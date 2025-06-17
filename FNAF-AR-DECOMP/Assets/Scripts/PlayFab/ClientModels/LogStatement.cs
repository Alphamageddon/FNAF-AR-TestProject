using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class LogStatement : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public object Data;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Level;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Message;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LogStatement()
        {
        
        }
    
    }

}
