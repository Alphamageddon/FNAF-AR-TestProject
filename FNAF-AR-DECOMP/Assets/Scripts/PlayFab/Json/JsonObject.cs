using UnityEngine;

namespace PlayFab.Json
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class JsonObject : IDictionary<string, object>, ICollection<System.Collections.Generic.KeyValuePair<string, object>>, IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>, IEnumerable
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int DICTIONARY_DEFAULT_SIZE = 16;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Dictionary<string, object> _members;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public object Item { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.ICollection<string> Keys { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.ICollection<object> Values { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public object Item { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Count { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsReadOnly { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public JsonObject()
        {
            this._members = new System.Collections.Generic.Dictionary<System.String, System.Object>(capacity:  16);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public JsonObject(System.Collections.Generic.IEqualityComparer<string> comparer)
        {
            this._members = new System.Collections.Generic.Dictionary<System.String, System.Object>(comparer:  comparer);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public object get_Item(int index)
        {
            return PlayFab.Json.JsonObject.GetAtIndex(obj:  this._members, index:  index);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static object GetAtIndex(System.Collections.Generic.IDictionary<string, object> obj, int index)
        {
            var val_8;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            val_8 = obj;
            if(val_8 == null)
            {
                goto label_1;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            if(val_8.Count <= index)
            {
                goto label_6;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_8 = val_8.GetEnumerator();
            var val_16 = 0;
            label_22:
            var val_14 = 0;
            val_14 = val_14 + 1;
            if(val_8.MoveNext() == false)
            {
                goto label_16;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            T val_8 = val_8.Current;
            val_16 = val_16 + 1;
            if(val_16 != index)
            {
                goto label_22;
            }
            
            val_13 = ;
            val_14 = 0;
            val_15 = 92;
            if(val_8 != null)
            {
                goto label_25;
            }
            
            goto label_31;
            label_16:
            val_14 = 0;
            val_13 = 0;
            val_15 = 90;
            if(val_8 != null)
            {
                goto label_25;
            }
            
            goto label_31;
            label_1:
            System.ArgumentNullException val_9 = null;
            val_16 = val_9;
            val_9 = new System.ArgumentNullException(paramName:  "obj");
            goto label_29;
            label_6:
            System.ArgumentOutOfRangeException val_10 = null;
            val_16 = val_10;
            val_10 = new System.ArgumentOutOfRangeException(paramName:  "index");
            label_29:
            if(0 != 1)
            {
                goto label_30;
            }
            
            val_13 = 0;
            val_15 = 0;
            if(val_8 == null)
            {
                goto label_31;
            }
            
            label_25:
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_8.Dispose();
            label_31:
            if(val_15 != 90)
            {
                    if(val_15 == 92)
            {
                    return (object)val_13;
            }
            
            }
            
            val_13 = 0;
            return (object)val_13;
            label_30:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Add(string key, object value)
        {
            this._members.Add(key:  key, value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ContainsKey(string key)
        {
            if(this._members != null)
            {
                    return this._members.ContainsKey(key:  key);
            }
            
            return this._members.ContainsKey(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.ICollection<string> get_Keys()
        {
            if(this._members != null)
            {
                    return this._members.Keys;
            }
            
            return this._members.Keys;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Remove(string key)
        {
            if(this._members != null)
            {
                    return this._members.Remove(key:  key);
            }
            
            return this._members.Remove(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool TryGetValue(string key, out object value)
        {
            if(this._members != null)
            {
                    return this._members.TryGetValue(key:  key, value: out  object val_1 = value);
            }
            
            return this._members.TryGetValue(key:  key, value: out  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.ICollection<object> get_Values()
        {
            if(this._members != null)
            {
                    return this._members.Values;
            }
            
            return this._members.Values;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public object get_Item(string key)
        {
            if(this._members != null)
            {
                    return this._members.Item[key];
            }
            
            return this._members.Item[key];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Item(string key, object value)
        {
            this._members.set_Item(key:  key, value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Add(System.Collections.Generic.KeyValuePair<string, object> item)
        {
            this._members.Add(key:  item.Value.emailUIDataHandler, value:  item.Value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Clear()
        {
            this._members.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Contains(System.Collections.Generic.KeyValuePair<string, object> item)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_5;
            var val_6;
            object val_2 = 0;
            val_5 = this._members;
            if((val_5.TryGetValue(key:  item.Value.emailUIDataHandler, value: out  val_2)) != false)
            {
                    val_5 = val_2;
                var val_4 = (val_5 == (-372255312)) ? 1 : 0;
                return (bool)val_6;
            }
            
            val_6 = 0;
            return (bool)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CopyTo(System.Collections.Generic.KeyValuePair<string, object>[] array, int arrayIndex)
        {
            var val_8;
            var val_9;
            val_8 = array;
            val_9 = this;
            if(val_8 == null)
            {
                goto label_1;
            }
            
            val_9 = this.Count;
            Dictionary.Enumerator<TKey, TValue> val_2 = this._members.GetEnumerator();
            label_5:
            if(((-372089112) & 1) == 0)
            {
                goto label_3;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_3 = 0.trackableId;
            int val_4 = arrayIndex + 1;
            val_9 = val_9 - 1;
            val_8[((long)(int)(arrayIndex)) << 4] = val_3.m_SubId1;
            val_8[((long)(int)(arrayIndex)) << 4] = val_3.m_SubId2;
            if(val_9 > 0)
            {
                goto label_5;
            }
            
            label_3:
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525709594344});
            return;
            label_1:
            System.ArgumentNullException val_6 = new System.ArgumentNullException(paramName:  "array");
            if(0 == 1)
            {
                    long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525709594344});
                if(null == null)
            {
                    return;
            }
            
                return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Count()
        {
            if(this._members != null)
            {
                    return this._members.Count;
            }
            
            return this._members.Count;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsReadOnly()
        {
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Remove(System.Collections.Generic.KeyValuePair<string, object> item)
        {
            return (bool)this._members.Remove(key:  item.Value.emailUIDataHandler);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> GetEnumerator()
        {
            var val_4;
            Dictionary.Enumerator<TKey, TValue> val_1 = this._members.GetEnumerator();
            return (System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Object>>)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            var val_4;
            Dictionary.Enumerator<TKey, TValue> val_1 = this._members.GetEnumerator();
            return (System.Collections.IEnumerator)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return PlayFab.Json.PlayFabSimpleJson.SerializeObject(json:  this._members, jsonSerializerStrategy:  0);
        }
    
    }

}
