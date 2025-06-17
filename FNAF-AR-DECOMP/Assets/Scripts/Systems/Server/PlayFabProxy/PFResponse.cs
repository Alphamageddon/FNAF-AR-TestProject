using UnityEngine;

namespace Systems.Server.PlayFabProxy
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PFResponse
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Server.PlayFabProxy.PFData ScriptData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Server.PlayFabProxy.PFData Errors;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string RequestId;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string JSONString { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IDictionary<string, object> JSONData { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasErrors { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Server.PlayFabProxy.PFData BaseData { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PFResponse(string requestId, Systems.Server.PlayFabProxy.PFData responseData)
        {
            val_1 = new System.Object();
            this.RequestId = requestId;
            if(val_1 != null)
            {
                    this.ScriptData = val_1.GetPFData(key:  "scriptData");
            }
            else
            {
                    this.ScriptData = 0.GetPFData(key:  "scriptData");
            }
            
            this.Errors = val_1.GetPFData(key:  "scriptError");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_JSONString()
        {
            if(this.ScriptData == null)
            {
                    return 0;
            }
            
            if(this.ScriptData._data == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IDictionary<string, object> get_JSONData()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HasErrors()
        {
            PlayFab.Json.JsonObject val_4;
            var val_6;
            val_4 = this;
            if(this.Errors != null)
            {
                    if((this.Errors.GetPFData(key:  "Error")) != null)
            {
                    val_4 = val_1._data;
                var val_5 = 0;
                val_5 = val_5 + 1;
                return (bool)(val_4.Count != 0) ? 1 : 0;
            }
            
            }
            
            val_6 = 0;
            return (bool)(val_4.Count != 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Server.PlayFabProxy.PFData get_BaseData()
        {
            return (Systems.Server.PlayFabProxy.PFData)this.ScriptData;
        }
    
    }

}
