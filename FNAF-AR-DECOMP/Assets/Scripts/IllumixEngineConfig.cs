using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class IllumixEngineConfig : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int tileCloseThreshold;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float resolution;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int closeTimeThreshold;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float dpMinThreshold;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float dpDistanceRatioThreshold;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int tileLength;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IllumixSurfaceManager.UpdateBehaviorType updateBehaviorType;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IllumixEngineConfig()
    {
    
    }

}
