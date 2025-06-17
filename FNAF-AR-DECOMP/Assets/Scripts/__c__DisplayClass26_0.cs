using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class ReflectionUtils.<>c__DisplayClass26_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Reflection.ConstructorInfo constructorInfo;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ReflectionUtils.<>c__DisplayClass26_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal object <GetConstructorByReflection>b__0(object[] args)
    {
        if(this.constructorInfo != null)
        {
                return this.constructorInfo.Invoke(parameters:  args);
        }
        
        return this.constructorInfo.Invoke(parameters:  args);
    }

}
