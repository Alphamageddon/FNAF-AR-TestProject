using UnityEngine;

namespace Systems.Server.PlayFabProxy
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PFData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Json.JsonObject _data;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<int> _intList;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<long> _longList;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<float> _floatList;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<double> _doubleList;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<string> _stringList;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<bool> _boolList;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IDictionary<string, object> BaseData { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PFData()
        {
            this._intList = new System.Collections.Generic.List<System.Int32>();
            this._longList = new System.Collections.Generic.List<System.Int64>();
            this._floatList = new System.Collections.Generic.List<System.Single>();
            this._doubleList = new System.Collections.Generic.List<System.Double>();
            this._stringList = new System.Collections.Generic.List<System.String>();
            this._boolList = new System.Collections.Generic.List<System.Boolean>();
            this._data = new PlayFab.Json.JsonObject();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PFData(PlayFab.Json.JsonObject data)
        {
            this._intList = new System.Collections.Generic.List<System.Int32>();
            this._longList = new System.Collections.Generic.List<System.Int64>();
            this._floatList = new System.Collections.Generic.List<System.Single>();
            this._doubleList = new System.Collections.Generic.List<System.Double>();
            this._stringList = new System.Collections.Generic.List<System.String>();
            this._boolList = new System.Collections.Generic.List<System.Boolean>();
            this._data = data;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IDictionary<string, object> get_BaseData()
        {
            return (System.Collections.Generic.IDictionary<System.String, System.Object>)this._data;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ToString()
        {
            if(this._data == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<int> GetInt(string key)
        {
            if((Facebook.Unity.Utilities.TryGetValue<System.Nullable<System.Int64>>(dictionary:  this._data, key:  key, value: out  new System.Nullable<System.Int64>() {HasValue = false})) != false)
            {
                    if(( & 1) == 0)
            {
                    return 0;
            }
            
                GameUI.EmailUIDataHandler val_2 = 0.emailUIDataHandler;
                return 0;
            }
            
            if(((Facebook.Unity.Utilities.TryGetValue<System.Nullable<System.UInt64>>(dictionary:  this._data, key:  key, value: out  new System.Nullable<System.UInt64>() {HasValue = false})) != false) && ((1565210960 & 1) != 0))
            {
                    GameUI.EmailUIDataHandler val_4 = 0.emailUIDataHandler;
                return 0;
            }
            
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetString(string key)
        {
            string val_1 = 0;
            bool val_2 = Facebook.Unity.Utilities.TryGetValue<System.String>(dictionary:  this._data, key:  key, value: out  val_1);
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> GetDate(string key)
        {
            bool val_1 = Facebook.Unity.Utilities.TryGetValue<System.Nullable<System.DateTime>>(dictionary:  this._data, key:  key, value: out  new System.Nullable<System.DateTime>() {HasValue = false});
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<double> GetDouble(string key)
        {
            string val_7;
            var val_8;
            val_7 = key;
            if((Facebook.Unity.Utilities.TryGetValue<System.Nullable<System.Double>>(dictionary:  this._data, key:  val_7, value: out  new System.Nullable<System.Double>() {HasValue = false})) != false)
            {
                    return 0;
            }
            
            if((Facebook.Unity.Utilities.TryGetValue<System.Nullable<System.UInt64>>(dictionary:  this._data, key:  key, value: out  new System.Nullable<System.UInt64>() {HasValue = false})) != false)
            {
                    val_7 = public System.Boolean System.Nullable<System.UInt64>::get_HasValue();
                if(( & 1) == 0)
            {
                    return 0;
            }
            
                GameUI.EmailUIDataHandler val_3 = 0.emailUIDataHandler;
                val_8 = 1152921517653605712;
                return 0;
            }
            
            val_7 = key;
            if((Facebook.Unity.Utilities.TryGetValue<System.Nullable<System.Int64>>(dictionary:  this._data, key:  val_7, value: out  new System.Nullable<System.Int64>() {HasValue = false})) == false)
            {
                    return 0;
            }
            
            val_7 = public System.Boolean System.Nullable<System.Int64>::get_HasValue();
            if((1565626800 & 1) != 0)
            {
                    GameUI.EmailUIDataHandler val_5 = 0.emailUIDataHandler;
                val_8 = 1152921517653605712;
                return 0;
            }
            
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<long> GetLong(string key)
        {
            string val_7;
            var val_8;
            val_7 = key;
            if((Facebook.Unity.Utilities.TryGetValue<System.Nullable<System.Int64>>(dictionary:  this._data, key:  val_7, value: out  new System.Nullable<System.Int64>() {HasValue = false})) != false)
            {
                    return 0;
            }
            
            if((Facebook.Unity.Utilities.TryGetValue<System.Nullable<System.Double>>(dictionary:  this._data, key:  key, value: out  new System.Nullable<System.Double>() {HasValue = false})) != false)
            {
                    val_7 = public System.Boolean System.Nullable<System.Double>::get_HasValue();
                if(( & 1) == 0)
            {
                    return 0;
            }
            
                val_8 = 1152921517578355296;
                val_7 = (long)0.South;
                return 0;
            }
            
            val_7 = key;
            if((Facebook.Unity.Utilities.TryGetValue<System.Nullable<System.UInt64>>(dictionary:  this._data, key:  val_7, value: out  new System.Nullable<System.UInt64>() {HasValue = false})) == false)
            {
                    return 0;
            }
            
            val_7 = public System.Boolean System.Nullable<System.UInt64>::get_HasValue();
            if((1565783856 & 1) != 0)
            {
                    val_8 = 1152921517578355296;
                val_7 = 0.emailUIDataHandler;
                return 0;
            }
            
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<float> GetFloat(string key)
        {
            var val_10;
            if((Facebook.Unity.Utilities.TryGetValue<System.Nullable<System.Single>>(dictionary:  this._data, key:  key, value: out  new System.Nullable<System.Single>() {HasValue = false})) != false)
            {
                    return 0;
            }
            
            if((Facebook.Unity.Utilities.TryGetValue<System.Nullable<System.UInt64>>(dictionary:  this._data, key:  key, value: out  new System.Nullable<System.UInt64>() {HasValue = false})) != false)
            {
                    if(( & 1) == 0)
            {
                    return 0;
            }
            
                GameUI.EmailUIDataHandler val_3 = 0.emailUIDataHandler;
                val_10 = 1152921517588977632;
                return 0;
            }
            
            if((Facebook.Unity.Utilities.TryGetValue<System.Nullable<System.Double>>(dictionary:  this._data, key:  key, value: out  new System.Nullable<System.Double>() {HasValue = false})) != false)
            {
                    if((1565946016 & 1) == 0)
            {
                    return 0;
            }
            
                double val_5 = 0.South;
                val_10 = 1152921517588977632;
                return 0;
            }
            
            if(((Facebook.Unity.Utilities.TryGetValue<System.Nullable<System.Int64>>(dictionary:  this._data, key:  key, value: out  new System.Nullable<System.Int64>() {HasValue = false})) == false) || ((1565946032 & 1) == 0))
            {
                    return 0;
            }
            
            GameUI.EmailUIDataHandler val_7 = 0.emailUIDataHandler;
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<long> GetNumber(string key)
        {
            string val_7;
            var val_8;
            val_7 = key;
            if((Facebook.Unity.Utilities.TryGetValue<System.Nullable<System.Int64>>(dictionary:  this._data, key:  val_7, value: out  new System.Nullable<System.Int64>() {HasValue = false})) != false)
            {
                    return 0;
            }
            
            if((Facebook.Unity.Utilities.TryGetValue<System.Nullable<System.UInt64>>(dictionary:  this._data, key:  key, value: out  new System.Nullable<System.UInt64>() {HasValue = false})) != false)
            {
                    val_7 = public System.Boolean System.Nullable<System.UInt64>::get_HasValue();
                if(( & 1) == 0)
            {
                    return 0;
            }
            
                val_8 = 1152921517578355296;
                val_7 = 0.emailUIDataHandler;
                return 0;
            }
            
            val_7 = key;
            if((Facebook.Unity.Utilities.TryGetValue<System.Nullable<System.Double>>(dictionary:  this._data, key:  val_7, value: out  new System.Nullable<System.Double>() {HasValue = false})) == false)
            {
                    return 0;
            }
            
            val_7 = public System.Boolean System.Nullable<System.Double>::get_HasValue();
            if((1566107184 & 1) != 0)
            {
                    val_8 = 1152921517578355296;
                val_7 = (long)0.South;
                return 0;
            }
            
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> GetBoolean(string key)
        {
            return (System.Nullable<System.Boolean>)((Facebook.Unity.Utilities.TryGetValue<System.Nullable<System.Boolean>>(dictionary:  this._data, key:  key, value: out  new System.Nullable<System.Boolean>() {HasValue = false})) != true) ? 0 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ContainsKey(string key)
        {
            if(this._data != null)
            {
                    return this._data.ContainsKey(key:  key);
            }
            
            return this._data.ContainsKey(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<int> GetIntList(string key)
        {
            System.Collections.Generic.List<System.Int32> val_6;
            var val_7;
            val_6 = 0;
            if((Facebook.Unity.Utilities.TryGetValue<PlayFab.Json.JsonArray>(dictionary:  this._data, key:  key, value: out  0)) == false)
            {
                    return val_6;
            }
            
            this._intList.Clear();
            int val_3 = val_1.Count;
            this._intList.Capacity = val_3;
            val_7 = 0;
            goto label_5;
            label_9:
            object val_4 = val_1.Item[0];
            val_3.Add(item:  20819968);
            val_7 = 1;
            label_5:
            val_6 = this._intList;
            if(val_7 < val_1.Count)
            {
                goto label_9;
            }
            
            return val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<long> GetLongList(string key)
        {
            System.Collections.Generic.List<System.Int64> val_6;
            var val_7;
            val_6 = 0;
            if((Facebook.Unity.Utilities.TryGetValue<PlayFab.Json.JsonArray>(dictionary:  this._data, key:  key, value: out  0)) == false)
            {
                    return val_6;
            }
            
            this._longList.Clear();
            int val_3 = val_1.Count;
            this._longList.Capacity = val_3;
            val_7 = 0;
            goto label_5;
            label_9:
            object val_4 = val_1.Item[0];
            val_3.Add(item:  null);
            val_7 = 1;
            label_5:
            val_6 = this._longList;
            if(val_7 < val_1.Count)
            {
                goto label_9;
            }
            
            return val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<float> GetFloatList(string key)
        {
            System.Collections.Generic.List<System.Single> val_6;
            var val_7;
            val_6 = 0;
            if((Facebook.Unity.Utilities.TryGetValue<PlayFab.Json.JsonArray>(dictionary:  this._data, key:  key, value: out  0)) == false)
            {
                    return val_6;
            }
            
            this._floatList.Clear();
            int val_3 = val_1.Count;
            this._floatList.Capacity = val_3;
            val_7 = 0;
            goto label_5;
            label_9:
            object val_4 = val_1.Item[0];
            val_3.Add(item:  3.484009E-38f);
            val_7 = 1;
            label_5:
            val_6 = this._floatList;
            if(val_7 < val_1.Count)
            {
                goto label_9;
            }
            
            return val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<double> GetDoubleList(string key)
        {
            System.Collections.Generic.List<System.Double> val_6;
            var val_7;
            val_6 = 0;
            if((Facebook.Unity.Utilities.TryGetValue<PlayFab.Json.JsonArray>(dictionary:  this._data, key:  key, value: out  0)) == false)
            {
                    return val_6;
            }
            
            this._doubleList.Clear();
            int val_3 = val_1.Count;
            this._doubleList.Capacity = val_3;
            val_7 = 0;
            goto label_5;
            label_9:
            object val_4 = val_1.Item[0];
            val_3.Add(item:  1.28822975987486E-231);
            val_7 = 1;
            label_5:
            val_6 = this._doubleList;
            if(val_7 < val_1.Count)
            {
                goto label_9;
            }
            
            return val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> GetStringList(string key)
        {
            System.Collections.Generic.List<System.String> val_7;
            var val_8;
            string val_9;
            val_7 = 0;
            if((Facebook.Unity.Utilities.TryGetValue<PlayFab.Json.JsonArray>(dictionary:  this._data, key:  key, value: out  0)) == false)
            {
                    return val_7;
            }
            
            this._stringList.Clear();
            int val_3 = val_1.Count;
            this._stringList.Capacity = val_3;
            val_8 = 0;
            goto label_5;
            label_13:
            val_9 = val_1.Item[0];
            if(val_3 == 0)
            {
                goto label_7;
            }
            
            if(val_9 != null)
            {
                goto label_8;
            }
            
            goto label_11;
            label_7:
            if(val_9 == null)
            {
                goto label_11;
            }
            
            label_8:
            if(null != null)
            {
                    val_9 = 0;
            }
            
            label_11:
            val_3.Add(item:  val_9);
            val_8 = 1;
            label_5:
            val_7 = this._stringList;
            if(val_8 < val_1.Count)
            {
                goto label_13;
            }
            
            return val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<bool> GetBooleanList(string key)
        {
            System.Collections.Generic.List<System.Boolean> val_6;
            var val_7;
            val_6 = 0;
            if((Facebook.Unity.Utilities.TryGetValue<PlayFab.Json.JsonArray>(dictionary:  this._data, key:  key, value: out  0)) == false)
            {
                    return val_6;
            }
            
            this._boolList.Clear();
            int val_3 = val_1.Count;
            this._boolList.Capacity = val_3;
            val_7 = 0;
            goto label_5;
            label_9:
            object val_4 = val_1.Item[0];
            val_3.Add(item:  false);
            val_7 = 1;
            label_5:
            val_6 = this._boolList;
            if(val_7 < val_1.Count)
            {
                goto label_9;
            }
            
            return val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Server.PlayFabProxy.PFData GetPFData(string key)
        {
            string val_7;
            var val_8;
            PlayFab.Json.JsonObject val_9;
            val_7 = key;
            PlayFab.Json.JsonObject val_1 = 0;
            PlayFab.ClientModels.ScriptExecutionError val_3 = 0;
            if((val_1 != 0) && ((Facebook.Unity.Utilities.TryGetValue<PlayFab.Json.JsonObject>(dictionary:  this._data, key:  val_7, value: out  val_1)) != false))
            {
                    val_8 = new Systems.Server.PlayFabProxy.PFData();
                val_9 = val_1;
            }
            else
            {
                    val_8 = 0;
                if(val_3 == 0)
            {
                    return (Systems.Server.PlayFabProxy.PFData)val_8;
            }
            
                if((Facebook.Unity.Utilities.TryGetValue<PlayFab.ClientModels.ScriptExecutionError>(dictionary:  this._data, key:  val_7, value: out  val_3)) == false)
            {
                    return (Systems.Server.PlayFabProxy.PFData)val_8;
            }
            
                PlayFab.Json.JsonObject val_5 = null;
                val_7 = val_5;
                val_5 = new PlayFab.Json.JsonObject();
                val_5.Add(key:  "Error", value:  11993091);
                val_5.Add(key:  "Message", value:  15026800);
                val_5.Add(key:  "StackTrace", value:  64);
                Systems.Server.PlayFabProxy.PFData val_6 = null;
                val_8 = val_6;
                val_9 = val_7;
            }
            
            val_6 = new Systems.Server.PlayFabProxy.PFData(data:  val_5);
            return (Systems.Server.PlayFabProxy.PFData)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.Json.JsonArray GetJsonArray(string key)
        {
            PlayFab.Json.JsonArray val_1 = 0;
            bool val_2 = Facebook.Unity.Utilities.TryGetValue<PlayFab.Json.JsonArray>(dictionary:  this._data, key:  key, value: out  val_1);
            return val_1;
        }
    
    }

}
