using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class SROptions.IncrementAttribute : Attribute
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public readonly double Increment;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SROptions.IncrementAttribute(double increment)
    {
        this.Increment = increment;
    }

}
