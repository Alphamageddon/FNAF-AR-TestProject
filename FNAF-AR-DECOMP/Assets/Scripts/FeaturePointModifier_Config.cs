using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class FeaturePointModifier_Config : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool logDebugDetails;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool showDebugVisuals;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float minDepth;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float maxDepth;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float maxNeighborHeightDelta;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float maxNeighborDistanceDelta;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int minCloseNeighbors;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float numFakePointsMultiplier;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.ParticleSystem pointCloudParticlePrefab;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float particleSize;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int maxPointsToShow;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool showCurrentOnly;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public FeaturePointModifier_Config()
    {
        this.minCloseNeighbors = 2;
        this.numFakePointsMultiplier = 50f;
        this.particleSize = 0.01f;
        this.maxPointsToShow = 10000;
        this.minDepth = ;
        this.maxDepth = ;
        this.maxNeighborHeightDelta = 0.1f;
        this.maxNeighborDistanceDelta = 0.2f;
        this.showCurrentOnly = true;
    }

}
