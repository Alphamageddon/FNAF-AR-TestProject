using UnityEngine;

namespace SRF.Helpers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class SRReflection
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetPropertyValue(object obj, System.Reflection.PropertyInfo p, object value)
        {
            object[] val_2 = new object[1];
            if(val_2 == null)
            {
                goto label_2;
            }
            
            if(value != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(value == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_2[0] = value;
            object val_3 = p.GetSetMethod().Invoke(obj:  obj, parameters:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static object GetPropertyValue(object obj, System.Reflection.PropertyInfo p)
        {
            System.Reflection.MethodInfo val_1 = p.GetGetMethod();
            if(val_1 != null)
            {
                    return val_1.Invoke(obj:  obj, parameters:  0);
            }
            
            return val_1.Invoke(obj:  obj, parameters:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static T GetAttribute<T>(System.Reflection.MemberInfo t)
        {
            var val_4;
            System.Attribute val_2 = System.Attribute.GetCustomAttribute(element:  t, attributeType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}));
            if(val_2 != null)
            {
                    val_4 = val_2;
                if(val_4 != null)
            {
                    return (SRF.ImportAttribute)val_4;
            }
            
            }
            
            val_4 = 0;
            return (SRF.ImportAttribute)val_4;
        }
    
    }

}
