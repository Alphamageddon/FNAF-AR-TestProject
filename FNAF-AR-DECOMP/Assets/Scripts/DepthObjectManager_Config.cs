using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class DepthObjectManager_Config : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Transform spherePrefab;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Transform filteredSpherePrefab;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.ParticleSystem pointCloudParticlePrefab;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.UI.Button button;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DepthObjectManager.Representation representation;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool filterLargeTriangles;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float particleSize;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int downsampleRate;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float depthModelIgnoreBoundary;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int updateFrequency;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool onlyOneMap;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool filterNearFP;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int radius;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool showSpheres;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool enableDepthMap;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float fpDeviationThreshold;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool computeFPDirection;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool useCPUOnly;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool shouldDownloadModel;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DepthObjectManager_Config()
    {
        this.particleSize = 0.05f;
        this.downsampleRate = 8;
        this.radius = 5;
    }

}
