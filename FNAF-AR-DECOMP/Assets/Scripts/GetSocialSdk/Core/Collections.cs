using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class Collections
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool DictionaryEquals<TKey, TValue>(System.Collections.Generic.Dictionary<TKey, TValue> self, System.Collections.Generic.Dictionary<TKey, TValue> other)
        {
            var val_2;
            if(self == other)
            {
                    val_2 = self ^ 1;
                return (bool)val_2 & 1;
            }
            
            val_2 = 0;
            return (bool)val_2 & 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ListEquals<T>(System.Collections.Generic.List<T> self, System.Collections.Generic.List<T> other)
        {
            var val_2;
            mem2[0] = other;
            if(self == (__RuntimeMethodHiddenParam + 48 + 16))
            {
                    val_2 = self ^ 1;
                return (bool)val_2 & 1;
            }
            
            val_2 = 0;
            return (bool)val_2 & 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool Texture2DEquals(UnityEngine.Texture2D self, UnityEngine.Texture2D other)
        {
            var val_8;
            if(self == other)
            {
                    val_8 = 1;
                return (bool)val_8;
            }
            
            if(self != 0)
            {
                    if(other != 0)
            {
                    return GetSocialSdk.Core.Collections.ListEquals<UnityEngine.Color>(self:  System.Linq.Enumerable.ToList<UnityEngine.Color>(source:  self.GetPixels()), other:  System.Linq.Enumerable.ToList<UnityEngine.Color>(source:  other.GetPixels()));
            }
            
            }
            
            val_8 = 0;
            return (bool)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AddAll<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> container, System.Collections.Generic.IDictionary<TKey, TValue> items)
        {
            var val_9;
            var val_12;
            var val_13;
            var val_8 = 0;
            val_8 = val_8 + 1;
            label_25:
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_9 = public System.Boolean System.Collections.IEnumerator::MoveNext();
            if(items.MoveNext() == false)
            {
                goto label_12;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_9 = __RuntimeMethodHiddenParam + 48 + 8;
            GameUI.EmailUIDataHandler val_5 = items.emailUIDataHandler;
            var val_11 = 0;
            val_11 = val_11 + 1;
            goto label_25;
            label_12:
            val_12 = 0;
            val_13 = 56;
            if(items == null)
            {
                
            }
            else
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                items.Dispose();
            }
            
            if( == 56)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AddAll<T>(System.Collections.Generic.ICollection<T> container, System.Collections.Generic.IEnumerable<T> items)
        {
            var val_14;
            var val_16;
            var val_18;
            var val_21;
            var val_22;
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_14 = 0;
            val_16 = items;
            label_25:
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_14 = 0;
            val_18 = public System.Boolean System.Collections.IEnumerator::MoveNext();
            if(val_16.MoveNext() == false)
            {
                goto label_12;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_18 = __RuntimeMethodHiddenParam + 48 + 8;
            val_14 = 0;
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_14 = 2;
            goto label_25;
            label_12:
            val_21 = 0;
            val_22 = 43;
            if(val_16 == null)
            {
                
            }
            else
            {
                    var val_19 = 0;
                val_19 = val_19 + 1;
                val_16.Dispose();
            }
            
            if( == 43)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_16 = ???;
            val_22 = ???;
        }
    
    }

}
