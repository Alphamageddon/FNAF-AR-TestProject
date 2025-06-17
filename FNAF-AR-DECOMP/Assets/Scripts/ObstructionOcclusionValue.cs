using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
protected class AkObstructionOcclusion.ObstructionOcclusionValue
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float currentValue;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float targetValue;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Update(float fadeRate)
    {
        var val_7;
        if((UnityEngine.Mathf.Approximately(a:  this.targetValue, b:  this.currentValue)) != false)
        {
                val_7 = 0;
            return (bool)val_7;
        }
        
        float val_4 = UnityEngine.Time.deltaTime;
        val_4 = ((UnityEngine.Mathf.Sign(f:  this.targetValue - this.currentValue)) * fadeRate) * val_4;
        val_4 = this.currentValue + val_4;
        this.currentValue = val_4;
        val_7 = 1;
        this.currentValue = UnityEngine.Mathf.Clamp(value:  val_4, min:  0f, max:  1f);
        return (bool)val_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkObstructionOcclusion.ObstructionOcclusionValue()
    {
    
    }

}
