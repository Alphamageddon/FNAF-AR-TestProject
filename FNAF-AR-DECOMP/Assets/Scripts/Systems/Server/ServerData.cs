using UnityEngine;

namespace Systems.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ServerData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Server.ServerType _serverType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameSparks.Core.GSData _gsData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Server.PlayFabProxy.PFData _pfData;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IDictionary<string, object> BaseData { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string JSON { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ServerData(GameSparks.Core.GSData gsData, Systems.Server.PlayFabProxy.PFData pfData)
        {
            Systems.Server.ServerType val_2;
            val_1 = new System.Object();
            if(gsData != null)
            {
                    this._gsData = gsData;
                val_2 = 1;
            }
            else
            {
                    if(val_1 == null)
            {
                    return;
            }
            
                val_2 = 2;
                this._pfData = val_1;
            }
            
            this._serverType = val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<int> GetInt(string key)
        {
            if(this._serverType == 1)
            {
                    if(this._gsData != null)
            {
                    return this._gsData.GetInt(name:  key);
            }
            
                return this._gsData.GetInt(name:  key);
            }
            
            if(this._pfData != null)
            {
                    return this._pfData.GetInt(key:  key);
            }
            
            return this._pfData.GetInt(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetString(string key)
        {
            if(this._serverType == 1)
            {
                    if(this._gsData != null)
            {
                    return this._gsData.GetString(name:  key);
            }
            
                return this._gsData.GetString(name:  key);
            }
            
            if(this._pfData != null)
            {
                    return this._pfData.GetString(key:  key);
            }
            
            return this._pfData.GetString(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> GetDate(string key)
        {
            if(this._serverType == 1)
            {
                    if(this._gsData != null)
            {
                    return this._gsData.GetDate(name:  key);
            }
            
                return this._gsData.GetDate(name:  key);
            }
            
            if(this._pfData != null)
            {
                    return this._pfData.GetDate(key:  key);
            }
            
            return this._pfData.GetDate(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<double> GetDouble(string key)
        {
            if(this._serverType == 1)
            {
                    if(this._gsData != null)
            {
                    return this._gsData.GetDouble(name:  key);
            }
            
                return this._gsData.GetDouble(name:  key);
            }
            
            if(this._pfData != null)
            {
                    return this._pfData.GetDouble(key:  key);
            }
            
            return this._pfData.GetDouble(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<long> GetLong(string key)
        {
            if(this._serverType == 1)
            {
                    if(this._gsData != null)
            {
                    return this._gsData.GetLong(name:  key);
            }
            
                return this._gsData.GetLong(name:  key);
            }
            
            if(this._pfData != null)
            {
                    return this._pfData.GetLong(key:  key);
            }
            
            return this._pfData.GetLong(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<float> GetFloat(string key)
        {
            if(this._serverType == 1)
            {
                    if(this._gsData != null)
            {
                    return this._gsData.GetFloat(name:  key);
            }
            
                return this._gsData.GetFloat(name:  key);
            }
            
            if(this._pfData != null)
            {
                    return this._pfData.GetFloat(key:  key);
            }
            
            return this._pfData.GetFloat(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<long> GetNumber(string key)
        {
            if(this._serverType == 1)
            {
                    if(this._gsData != null)
            {
                    return this._gsData.GetNumber(name:  key);
            }
            
                return this._gsData.GetNumber(name:  key);
            }
            
            if(this._pfData != null)
            {
                    return this._pfData.GetNumber(key:  key);
            }
            
            return this._pfData.GetNumber(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> GetBoolean(string key)
        {
            var val_3;
            if(this._serverType == 1)
            {
                    val_3 = this._gsData;
                System.Nullable<System.Boolean> val_1 = val_3.GetBoolean(name:  key);
            }
            else
            {
                    val_3 = this._pfData;
                System.Nullable<System.Boolean> val_2 = val_3.GetBoolean(key:  key);
            }
            
            val_2.HasValue = val_2.HasValue & 65535;
            return (System.Nullable<System.Boolean>)val_2.HasValue;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ContainsKey(string key)
        {
            if(this._serverType == 1)
            {
                    if(this._gsData != null)
            {
                    return this._gsData.ContainsKey(key:  key);
            }
            
                return this._gsData.ContainsKey(key:  key);
            }
            
            if(this._pfData != null)
            {
                    return this._pfData.ContainsKey(key:  key);
            }
            
            return this._pfData.ContainsKey(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<int> GetIntList(string key)
        {
            if(this._serverType == 1)
            {
                    if(this._gsData != null)
            {
                    return this._gsData.GetIntList(name:  key);
            }
            
                return this._gsData.GetIntList(name:  key);
            }
            
            if(this._pfData != null)
            {
                    return this._pfData.GetIntList(key:  key);
            }
            
            return this._pfData.GetIntList(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<long> GetLongList(string key)
        {
            if(this._serverType == 1)
            {
                    if(this._gsData != null)
            {
                    return this._gsData.GetLongList(name:  key);
            }
            
                return this._gsData.GetLongList(name:  key);
            }
            
            if(this._pfData != null)
            {
                    return this._pfData.GetLongList(key:  key);
            }
            
            return this._pfData.GetLongList(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<float> GetFloatList(string key)
        {
            if(this._serverType == 1)
            {
                    if(this._gsData != null)
            {
                    return this._gsData.GetFloatList(name:  key);
            }
            
                return this._gsData.GetFloatList(name:  key);
            }
            
            if(this._pfData != null)
            {
                    return this._pfData.GetFloatList(key:  key);
            }
            
            return this._pfData.GetFloatList(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<double> GetDoubleList(string key)
        {
            if(this._serverType == 1)
            {
                    if(this._gsData != null)
            {
                    return this._gsData.GetDoubleList(name:  key);
            }
            
                return this._gsData.GetDoubleList(name:  key);
            }
            
            if(this._pfData != null)
            {
                    return this._pfData.GetDoubleList(key:  key);
            }
            
            return this._pfData.GetDoubleList(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> GetStringList(string key)
        {
            if(this._serverType == 1)
            {
                    if(this._gsData != null)
            {
                    return this._gsData.GetStringList(name:  key);
            }
            
                return this._gsData.GetStringList(name:  key);
            }
            
            if(this._pfData != null)
            {
                    return this._pfData.GetStringList(key:  key);
            }
            
            return this._pfData.GetStringList(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<bool> GetBooleanList(string key)
        {
            if(this._serverType == 1)
            {
                    if(this._gsData != null)
            {
                    return this._gsData.GetBooleanList(name:  key);
            }
            
                return this._gsData.GetBooleanList(name:  key);
            }
            
            if(this._pfData != null)
            {
                    return this._pfData.GetBooleanList(key:  key);
            }
            
            return this._pfData.GetBooleanList(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Server.ServerData GetServerData(string key)
        {
            GameSparks.Core.GSData val_4;
            Systems.Server.PlayFabProxy.PFData val_5;
            var val_6;
            Systems.Server.ServerType val_7;
            if(this._gsData != null)
            {
                    val_4 = this._gsData.GetGSData(name:  key);
            }
            else
            {
                    val_4 = 0;
            }
            
            if(this._pfData == null)
            {
                goto label_3;
            }
            
            val_5 = this._pfData.GetPFData(key:  key);
            if(val_4 != 0)
            {
                goto label_5;
            }
            
            label_7:
            if(val_5 != null)
            {
                goto label_5;
            }
            
            val_6 = 0;
            return (Systems.Server.ServerData)val_6;
            label_3:
            val_5 = 0;
            if(val_4 == 0)
            {
                goto label_7;
            }
            
            label_5:
            Systems.Server.ServerData val_3 = null;
            val_6 = val_3;
            val_3 = new Systems.Server.ServerData();
            if(val_4 != 0)
            {
                    ._gsData = val_4;
                val_7 = 1;
            }
            else
            {
                    if(val_5 == 0)
            {
                    return (Systems.Server.ServerData)val_6;
            }
            
                val_7 = 2;
                ._pfData = val_5;
            }
            
            ._serverType = val_7;
            return (Systems.Server.ServerData)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Systems.Server.ServerData> GetServerDataList(string key)
        {
            var val_14;
            var val_15;
            var val_16;
            PlayFab.Json.JsonObject val_17;
            if(this._gsData != null)
            {
                    val_14 = this._gsData.GetGSDataList(name:  key);
            }
            else
            {
                    val_14 = 0;
            }
            
            if(this._pfData == null)
            {
                goto label_3;
            }
            
            val_15 = this._pfData.GetJsonArray(key:  key);
            if(val_14 != 0)
            {
                goto label_6;
            }
            
            label_7:
            if(val_15 == null)
            {
                goto label_9;
            }
            
            goto label_6;
            label_3:
            val_15 = 0;
            if(val_14 == 0)
            {
                goto label_7;
            }
            
            label_6:
            if(this._serverType == 2)
            {
                goto label_8;
            }
            
            if(this._serverType == 1)
            {
                    int val_3 = val_14.Count;
                System.Collections.Generic.List<Systems.Server.ServerData> val_4 = null;
                val_16 = val_4;
                val_4 = new System.Collections.Generic.List<Systems.Server.ServerData>(capacity:  val_3);
                if(val_3 < 1)
            {
                    return (System.Collections.Generic.List<Systems.Server.ServerData>)val_16;
            }
            
                var val_14 = 0;
                do
            {
                GameSparks.Core.GSData val_5 = val_14.Item[0];
                if(val_5 != null)
            {
                    ._gsData = val_5;
                ._serverType = 1;
            }
            
                val_4.Add(item:  new Systems.Server.ServerData());
                val_14 = val_14 + 1;
            }
            while(val_3 != val_14);
            
                return (System.Collections.Generic.List<Systems.Server.ServerData>)val_16;
            }
            
            label_9:
            val_16 = 0;
            return (System.Collections.Generic.List<Systems.Server.ServerData>)val_16;
            label_8:
            int val_7 = val_15.Count;
            if(val_7 < 1)
            {
                    return (System.Collections.Generic.List<Systems.Server.ServerData>)val_16;
            }
            
            var val_15 = 0;
            do
            {
                val_17 = val_15.Item[0];
                if(val_17 != null)
            {
                    val_17 = 0;
            }
            
                new Systems.Server.PlayFabProxy.PFData() = new Systems.Server.PlayFabProxy.PFData(data:  val_17);
                if(new Systems.Server.PlayFabProxy.PFData() != null)
            {
                    ._pfData = new Systems.Server.PlayFabProxy.PFData();
                ._serverType = 2;
            }
            
                new System.Collections.Generic.List<Systems.Server.ServerData>(capacity:  val_7).Add(item:  new Systems.Server.ServerData());
                val_15 = val_15 + 1;
            }
            while(val_15 < val_7);
            
            return (System.Collections.Generic.List<Systems.Server.ServerData>)val_16;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IDictionary<string, object> get_BaseData()
        {
            PlayFab.Json.JsonObject val_1;
            if(this._serverType == 2)
            {
                goto label_0;
            }
            
            if(this._serverType != 1)
            {
                goto label_1;
            }
            
            if(this._gsData != null)
            {
                    return this._gsData.BaseData;
            }
            
            return this._gsData.BaseData;
            label_0:
            val_1 = this._pfData._data;
            return (System.Collections.Generic.IDictionary<System.String, System.Object>)val_1;
            label_1:
            val_1 = 0;
            return (System.Collections.Generic.IDictionary<System.String, System.Object>)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_JSON()
        {
            if(this._serverType != 2)
            {
                    if(this._serverType != 1)
            {
                    return 0;
            }
            
                if(this._gsData != null)
            {
                    return this._gsData.JSON;
            }
            
                return this._gsData.JSON;
            }
            
            if(this._pfData._data == null)
            {
                
            }
        
        }
    
    }

}
