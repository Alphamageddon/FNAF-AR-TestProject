using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class SROptions.SortAttribute : Attribute
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public readonly int SortPriority;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SROptions.SortAttribute(int priority)
    {
        this.SortPriority = priority;
    }

}
