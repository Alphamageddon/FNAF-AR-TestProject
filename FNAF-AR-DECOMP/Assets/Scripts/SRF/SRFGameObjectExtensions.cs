using UnityEngine;

namespace SRF
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class SRFGameObjectExtensions
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static T GetIComponent<T>(UnityEngine.GameObject t)
        {
            var val_4;
            UnityEngine.Component val_2 = t.GetComponent(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}));
            if(val_2 != null)
            {
                    val_4 = val_2;
                if(val_4 != null)
            {
                    return (object)val_4;
            }
            
            }
            
            val_4 = 0;
            return (object)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static T GetComponentOrAdd<T>(UnityEngine.GameObject obj)
        {
            var val_7;
            UnityEngine.Object val_8;
            val_7 = __RuntimeMethodHiddenParam;
            val_8 = obj;
            if(val_8 != 0)
            {
                    return (SRF.UI.StyleRoot)val_8;
            }
            
            val_7 = ???;
            val_8 = ???;
            goto __RuntimeMethodHiddenParam + 48 + 16;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void RemoveComponentIfExists<T>(UnityEngine.GameObject obj)
        {
            if(obj == 0)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  obj);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void RemoveComponentsIfExists<T>(UnityEngine.GameObject obj)
        {
            var val_1 = 0;
            if(obj != null)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool EnableComponentIfExists<T>(UnityEngine.GameObject obj, bool enable = True)
        {
            var val_3;
            if(obj == 0)
            {
                    val_3 = 0;
                return (bool)val_3;
            }
            
            obj.enabled = enable;
            val_3 = 1;
            return (bool)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetLayerRecursive(UnityEngine.GameObject o, int layer)
        {
            SRF.SRFGameObjectExtensions.SetLayerInternal(t:  o.transform, layer:  layer);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void SetLayerInternal(UnityEngine.Transform t, int layer)
        {
            var val_10;
            var val_11;
            t.gameObject.layer = layer;
            System.Collections.IEnumerator val_2 = t.GetEnumerator();
            label_19:
            var val_10 = 0;
            val_10 = val_10 + 1;
            if(val_2.MoveNext() == false)
            {
                goto label_9;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            if(val_2.Current == null)
            {
                goto label_19;
            }
            
            goto label_19;
            label_9:
            val_10 = 0;
            val_11 = 65;
            if(val_2 != null)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                val_2.Dispose();
            }
            
            if( == 65)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
        
        }
    
    }

}
