using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkEnumFlagAttribute : PropertyAttribute
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Type Type;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkEnumFlagAttribute(System.Type type)
    {
        this.Type = type;
    }

}
