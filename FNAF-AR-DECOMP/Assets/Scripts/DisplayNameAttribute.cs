using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class SROptions.DisplayNameAttribute : Attribute
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public readonly string Name;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SROptions.DisplayNameAttribute(string name)
    {
        this.Name = name;
    }

}
