using UnityEngine;

namespace Game.MasterData
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class KeyValueAccess
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, ProtoData.KEY_VALUE_DATA.Types.ENTRY> _map;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(ProtoData.KEY_VALUE_DATA kvd)
        {
            var val_20;
            var val_21;
            var val_24;
            var val_25;
            this._map = new System.Collections.Generic.Dictionary<System.String, ENTRY>(capacity:  kvd.Entries.Count);
            val_20 = 1152921504689487872;
            val_21 = kvd.Entries.GetEnumerator();
            label_18:
            var val_22 = 0;
            val_22 = val_22 + 1;
            if(val_21.MoveNext() == false)
            {
                goto label_10;
            }
            
            var val_23 = 0;
            val_23 = val_23 + 1;
            T val_9 = val_21.Current;
            this._map.Add(key:  val_9.Logical, value:  val_9);
            goto label_18;
            label_10:
            val_24 = 0;
            val_25 = 81;
            if(val_21 == null)
            {
                
            }
            else
            {
                    var val_24 = 0;
                val_24 = val_24 + 1;
                val_21.Dispose();
            }
            
            if( == 81)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_21 = ???;
            val_25 = ???;
            val_20 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetString(string key, string fallback)
        {
            if((this._map.TryGetValue(key:  key, value: out  0)) == false)
            {
                    return (string)fallback;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_1.StringValue)) == true)
            {
                    return (string)fallback;
            }
            
            fallback = val_1.StringValue;
            return (string)fallback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetInt(string key, int fallback)
        {
            if((this._map.TryGetValue(key:  key, value: out  0)) == false)
            {
                    return fallback;
            }
            
            fallback = (int)val_1.NumberValue;
            return fallback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GetFloat(string key, float fallback)
        {
            float val_4;
            string val_5;
            val_4 = fallback;
            val_5 = key;
            ENTRY val_1 = 0;
            if((this._map.TryGetValue(key:  val_5, value: out  val_1)) == false)
            {
                    return val_4;
            }
            
            val_5 = val_1;
            val_4 = (float)val_5.NumberValue;
            return val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool GetBool(string key, bool fallback)
        {
            if((this._map.TryGetValue(key:  key, value: out  0)) != false)
            {
                    bool val_3 = val_1.BooleanValue;
                fallback = val_3;
            }
            
            val_3 = fallback;
            return (bool)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public KeyValueAccess()
        {
        
        }
    
    }

}
