using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class SROptions.NumberRangeAttribute : Attribute
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public readonly double Max;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public readonly double Min;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SROptions.NumberRangeAttribute(double min, double max)
    {
        this.Max = max;
        this.Min = min;
    }

}
