using UnityEngine;

namespace CodingJar
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class TransformEx
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void DestroyChildren(UnityEngine.Transform transform)
        {
            var val_6;
            if(transform == 0)
            {
                    return;
            }
            
            val_6 = 0;
            goto label_4;
            label_12:
            UnityEngine.Transform val_2 = transform.GetChild(index:  0);
            val_2.gameObject.SetActive(value:  false);
            UnityEngine.Object.Destroy(obj:  val_2.gameObject);
            val_6 = 1;
            label_4:
            if(val_6 < transform.childCount)
            {
                goto label_12;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string FullPath(UnityEngine.Transform transform)
        {
            UnityEngine.Transform val_8 = transform;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            goto label_1;
            label_8:
            string val_2 = val_8.name;
            if(val_1 != null)
            {
                    System.Text.StringBuilder val_3 = val_1.Insert(index:  0, value:  val_2);
            }
            else
            {
                    System.Text.StringBuilder val_4 = val_1.Insert(index:  0, value:  val_2);
            }
            
            System.Text.StringBuilder val_5 = val_1.Insert(index:  0, value:  '/');
            val_8 = val_8.parent;
            label_1:
            if(val_8 != 0)
            {
                goto label_8;
            }
            
            if(val_1 == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string GetPathRelativeTo(UnityEngine.Transform transform, UnityEngine.Transform parent)
        {
            var val_7;
            if(transform == parent)
            {
                    val_7 = "";
                return (string)val_7;
            }
            
            val_7 = CodingJar.TransformEx.FullPath(transform:  transform);
            if((transform.IsChildOf(parent:  parent)) == false)
            {
                    return (string)val_7;
            }
            
            return val_7.Substring(startIndex:  (CodingJar.TransformEx.FullPath(transform:  parent).Length) + 1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static T FindInParents<T>(UnityEngine.Transform transform, bool bIncludeSelf = True)
        {
            UnityEngine.Object val_4;
            UnityEngine.Object val_5;
            val_4 = transform;
            if(bIncludeSelf == true)
            {
                goto label_1;
            }
            
            label_9:
            val_4 = val_4.parent;
            label_1:
            val_5 = 0;
            if(val_4 == 0)
            {
                    return (object)val_5;
            }
            
            val_5 = val_4;
            if((UnityEngine.Object.op_Implicit(exists:  val_5)) == false)
            {
                goto label_9;
            }
            
            return (object)val_5;
        }
    
    }

}
