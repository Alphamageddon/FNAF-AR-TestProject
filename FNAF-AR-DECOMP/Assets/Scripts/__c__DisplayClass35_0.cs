using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class ReflectionUtils.<>c__DisplayClass35_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Reflection.FieldInfo fieldInfo;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ReflectionUtils.<>c__DisplayClass35_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <GetSetMethodByReflection>b__0(object source, object value)
    {
        this.fieldInfo.SetValue(obj:  source, value:  value);
    }

}
