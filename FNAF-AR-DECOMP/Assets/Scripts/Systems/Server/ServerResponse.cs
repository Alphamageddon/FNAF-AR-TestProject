using UnityEngine;

namespace Systems.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ServerResponse
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Server.ServerType _serverType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameSparks.Core.GSTypedResponse _gsResponse;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Server.PlayFabProxy.PFResponse _pfResponse;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string JSONString { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IDictionary<string, object> JSONData { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Server.ServerData ScriptData { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasErrors { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Server.ServerData Errors { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string RequestId { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Server.ServerData BaseData { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ServerResponse(GameSparks.Core.GSTypedResponse gsResponse, Systems.Server.PlayFabProxy.PFResponse pfResponse)
        {
            Systems.Server.ServerType val_2;
            val_1 = new System.Object();
            if(gsResponse != null)
            {
                    this._gsResponse = gsResponse;
                val_2 = 1;
            }
            else
            {
                    if(val_1 == null)
            {
                    return;
            }
            
                val_2 = 2;
                this._pfResponse = val_1;
            }
            
            this._serverType = val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_JSONString()
        {
            if(this._serverType == 1)
            {
                    if(this._gsResponse != null)
            {
                    return this._gsResponse.JSONString;
            }
            
                return this._gsResponse.JSONString;
            }
            
            if(this._pfResponse != null)
            {
                    return this._pfResponse.JSONString;
            }
            
            return this._pfResponse.JSONString;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IDictionary<string, object> get_JSONData()
        {
            if(this._serverType == 1)
            {
                    if(this._gsResponse != null)
            {
                    return this._gsResponse.JSONData;
            }
            
                return this._gsResponse.JSONData;
            }
            
            if(this._pfResponse != null)
            {
                    return 0;
            }
            
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Server.ServerData get_ScriptData()
        {
            var val_5;
            Systems.Server.ServerType val_6;
            if(this._serverType == 2)
            {
                goto label_1;
            }
            
            if((this._serverType != 1) || (this._gsResponse.ScriptData == null))
            {
                goto label_9;
            }
            
            GameSparks.Core.GSData val_2 = this._gsResponse.ScriptData;
            Systems.Server.ServerData val_3 = null;
            val_5 = val_3;
            val_3 = new Systems.Server.ServerData();
            if(val_2 == null)
            {
                    return (Systems.Server.ServerData)val_5;
            }
            
            ._gsData = val_2;
            val_6 = 1;
            goto label_7;
            label_1:
            if(this._pfResponse.ScriptData == null)
            {
                goto label_9;
            }
            
            Systems.Server.ServerData val_4 = null;
            val_5 = val_4;
            val_4 = new Systems.Server.ServerData();
            if(this._pfResponse.ScriptData == null)
            {
                    return (Systems.Server.ServerData)val_5;
            }
            
            val_6 = 2;
            ._pfData = this._pfResponse.ScriptData;
            label_7:
            ._serverType = val_6;
            return (Systems.Server.ServerData)val_5;
            label_9:
            val_5 = 0;
            return (Systems.Server.ServerData)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HasErrors()
        {
            if(this._serverType == 1)
            {
                    if(this._gsResponse != null)
            {
                    return this._gsResponse.HasErrors;
            }
            
                return this._gsResponse.HasErrors;
            }
            
            if(this._pfResponse != null)
            {
                    return this._pfResponse.HasErrors;
            }
            
            return this._pfResponse.HasErrors;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Server.ServerData get_Errors()
        {
            var val_4;
            Systems.Server.ServerType val_5;
            if(this._serverType == 1)
            {
                    GameSparks.Core.GSData val_1 = this._gsResponse.Errors;
                Systems.Server.ServerData val_2 = null;
                val_4 = val_2;
                val_2 = new Systems.Server.ServerData();
                if(val_1 == null)
            {
                    return (Systems.Server.ServerData)val_4;
            }
            
                val_5 = 1;
                ._gsData = val_1;
            }
            else
            {
                    Systems.Server.ServerData val_3 = null;
                val_4 = val_3;
                val_3 = new Systems.Server.ServerData();
                if(this._pfResponse.Errors == null)
            {
                    return (Systems.Server.ServerData)val_4;
            }
            
                ._pfData = this._pfResponse.Errors;
                val_5 = 2;
            }
            
            ._serverType = val_5;
            return (Systems.Server.ServerData)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_RequestId()
        {
            if(this._serverType == 1)
            {
                    if(this._gsResponse != null)
            {
                    return this._gsResponse.RequestId;
            }
            
                return this._gsResponse.RequestId;
            }
            
            if(this._pfResponse != null)
            {
                    return (string)this._pfResponse.RequestId;
            }
            
            return (string)this._pfResponse.RequestId;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Server.ServerData get_BaseData()
        {
            var val_4;
            Systems.Server.ServerType val_5;
            if(this._serverType == 1)
            {
                    GameSparks.Core.GSData val_1 = this._gsResponse.BaseData;
                Systems.Server.ServerData val_2 = null;
                val_4 = val_2;
                val_2 = new Systems.Server.ServerData();
                if(val_1 == null)
            {
                    return (Systems.Server.ServerData)val_4;
            }
            
                val_5 = 1;
                ._gsData = val_1;
            }
            else
            {
                    Systems.Server.ServerData val_3 = null;
                val_4 = val_3;
                val_3 = new Systems.Server.ServerData();
                if(this._pfResponse.ScriptData == null)
            {
                    return (Systems.Server.ServerData)val_4;
            }
            
                ._pfData = this._pfResponse.ScriptData;
                val_5 = 2;
            }
            
            ._serverType = val_5;
            return (Systems.Server.ServerData)val_4;
        }
    
    }

}
