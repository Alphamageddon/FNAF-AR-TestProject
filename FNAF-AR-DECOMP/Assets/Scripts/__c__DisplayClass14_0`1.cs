using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class JniUtils.<>c__DisplayClass14_0<T>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.AndroidJavaObject javaList;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public JniUtils.<>c__DisplayClass14_0<T>()
    {
        if(this != null)
        {
                return;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <ToJavaList>b__0(T item)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(item != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(item == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = item;
        bool val_2 = GetSocialSdk.Core.JniExtensionMethods.CallBool(ajo:  this, methodName:  "add", args:  val_1);
    }

}
