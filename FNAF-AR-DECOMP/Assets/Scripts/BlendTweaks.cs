using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public static class BlendTweaks
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float ComputeBlendFromSharpnessPerTick(float current, float target, float sharpnessPerTick, float referenceFramerate, float deltaTime)
    {
        float val_2 = referenceFramerate * deltaTime;
        sharpnessPerTick = 1f - (1f - sharpnessPerTick);
        return UnityEngine.Mathf.Lerp(a:  current, b:  target, t:  sharpnessPerTick);
    }

}
