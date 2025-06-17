using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
protected class SplineBase.ArcLengthParametrization
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float[] sSample;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float[] tSample;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float[] tsSlope;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float L;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float GetApproximateTimeParameter(float s)
    {
        if(s <= 0f)
        {
                return 1f;
        }
        
        if(this.L <= s)
        {
                return 1f;
        }
        
        int val_1 = System.Array.BinarySearch<System.Single>(array:  this.sSample, value:  s);
        this = this.sSample;
        float val_5 = this[(long)0 - 1];
        val_5 = s - val_5;
        val_5 = this.tsSlope[0] * val_5;
        val_5 = (this.tSample[(long)0 - 1]) + val_5;
        return 1f;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SplineBase.ArcLengthParametrization()
    {
    
    }

}
