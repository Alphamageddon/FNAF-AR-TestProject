using UnityEngine;

namespace SimpleJson2
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class JsonObject : IDictionary<string, object>, ICollection<System.Collections.Generic.KeyValuePair<string, object>>, IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>, IEnumerable
    {
        // Fields
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
            this._members = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public JsonObject(System.Collections.Generic.IEqualityComparer<string> comparer)
        {
            this._members = new System.Collections.Generic.Dictionary<System.String, System.Object>(comparer:  comparer);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public object get_Item(int index)
        {
            return SimpleJson2.JsonObject.GetAtIndex(obj:  this._members, index:  index);
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
            var val_6;
            var val_7;
            val_6 = this;
            if((this._members.ContainsKey(key:  item.Value.emailUIDataHandler)) != false)
            {
                    val_6 = this._members.Item[item.Value.emailUIDataHandler];
                var val_5 = (val_6 == ) ? 1 : 0;
                return (bool)val_7;
            }
            
            val_7 = 0;
            return (bool)val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CopyTo(System.Collections.Generic.KeyValuePair<string, object>[] array, int arrayIndex)
        {
            var val_18;
            var val_19;
            System.Collections.Generic.KeyValuePair<System.String, System.Object> val_22;
            var val_23;
            var val_24;
            if(array == null)
            {
                goto label_1;
            }
            
            var val_22 = this.Count;
            val_18 = 1152921504685174784;
            val_19 = this.GetEnumerator();
            label_14:
            var val_20 = 0;
            val_20 = val_20 + 1;
            if(val_19.MoveNext() == false)
            {
                goto label_7;
            }
            
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_22 = val_19.Current;
            int val_7 = arrayIndex + 1;
            val_22 = val_22 - 1;
            array[((long)(int)(arrayIndex)) << 4] = val_22;
            array[((long)(int)(arrayIndex)) << 4] = public T System.Collections.Generic.IEnumerator<T>::get_Current();
            if(val_22 > 0)
            {
                goto label_14;
            }
            
            label_7:
            val_23 = 0;
            val_24 = 80;
            if(val_19 != null)
            {
                goto label_15;
            }
            
            goto label_20;
            label_1:
            System.ArgumentNullException val_8 = null;
            val_19 = val_8;
            val_8 = new System.ArgumentNullException(paramName:  "array");
            if(0 != 1)
            {
                goto label_19;
            }
            
            val_24 = 0;
            if(val_19 == null)
            {
                goto label_20;
            }
            
            label_15:
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_8.Dispose();
            label_20:
            if(val_24 == 80)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_19 = ???;
            val_24 = ???;
            val_22 = ???;
            val_18 = ???;
            return;
            label_19:
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
            return SimpleJson2.SimpleJson2.SerializeObject(json:  this);
        }
    
    }

}
