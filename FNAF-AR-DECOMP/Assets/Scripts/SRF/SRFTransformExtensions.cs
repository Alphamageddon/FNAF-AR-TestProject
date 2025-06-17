using UnityEngine;

namespace SRF
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class SRFTransformExtensions
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Collections.Generic.IEnumerable<UnityEngine.Transform> GetChildren(UnityEngine.Transform t)
        {
            .<>1__state = -2;
            .<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
            .<>3__t = t;
            return (System.Collections.Generic.IEnumerable<UnityEngine.Transform>)new SRFTransformExtensions.<GetChildren>d__0();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ResetLocal(UnityEngine.Transform t)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            t.localPosition = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
            t.localRotation = new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w};
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            t.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.GameObject CreateChild(UnityEngine.Transform t, string name)
        {
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  name);
            val_1.transform.parent = t;
            if(val_1 != null)
            {
                    SRF.SRFTransformExtensions.ResetLocal(t:  val_1.transform);
            }
            else
            {
                    SRF.SRFTransformExtensions.ResetLocal(t:  val_1.transform);
            }
            
            val_1.gameObject.layer = t.gameObject.layer;
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetParentMaintainLocals(UnityEngine.Transform t, UnityEngine.Transform parent)
        {
            t.SetParent(parent:  parent, worldPositionStays:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetLocals(UnityEngine.Transform t, UnityEngine.Transform from)
        {
            UnityEngine.Vector3 val_1 = from.localPosition;
            t.localPosition = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            UnityEngine.Quaternion val_2 = from.localRotation;
            t.localRotation = new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w};
            UnityEngine.Vector3 val_3 = from.localScale;
            t.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Match(UnityEngine.Transform t, UnityEngine.Transform from)
        {
            UnityEngine.Vector3 val_1 = from.position;
            t.position = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            UnityEngine.Quaternion val_2 = from.rotation;
            t.rotation = new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void DestroyChildren(UnityEngine.Transform t)
        {
            var val_12;
            var val_13;
            var val_14;
            System.Collections.IEnumerator val_1 = t.GetEnumerator();
            label_21:
            var val_12 = 0;
            val_12 = val_12 + 1;
            if(val_1.MoveNext() == false)
            {
                goto label_7;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_12 = val_1.Current;
            if(val_12 != null)
            {
                    val_12 = 0;
            }
            
            UnityEngine.Object.Destroy(obj:  val_12.gameObject);
            goto label_21;
            label_7:
            val_13 = 0;
            val_14 = 57;
            if(val_1 != null)
            {
                    var val_14 = 0;
                val_14 = val_14 + 1;
                val_1.Dispose();
            }
            
            if( == 57)
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
