using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class ReflectionUtils.<>c__DisplayClass34_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Reflection.MethodInfo methodInfo;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ReflectionUtils.<>c__DisplayClass34_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <GetSetMethodByReflection>b__0(object source, object value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        if((mem[-1]) == 0)
        {
                val_4 = null;
            val_4 = null;
            mem2[-1] = new object[1];
        }
        
        val_5 = null;
        val_5 = null;
        mem2[0] = value;
        object val_2 = this.methodInfo.Invoke(obj:  source, parameters:  mem[-1]);
    }

}
