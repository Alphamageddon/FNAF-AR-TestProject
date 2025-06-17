using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
[Serializable]
public class TSDF_Config : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TSDF_Config.TSDF_Properties props;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TSDF_Config.TSDF_Properties coarse_props;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float updateTime;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TSDF_Config.WeightSystem weightSystem;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int maxWeight;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float weightThreshold;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool useMask;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool disableFeaturePoints;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool useBlockMask;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int maxCoordsToUpdate;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int blockSize;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float thresholdTileLayerRatio;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float thresholdTileDropLayerRatio;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float thresholdSmoothLayerRatio;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float thresholdSmoothDropLayerRatio;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float thresholdColumnRatio;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float thresholdColumnDropRatio;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int changesToUpdateSmoothLayer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool showColumns;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool smoothEnableRemoval;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool smoothAddFilter;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float distanceThreshold;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float particleSize;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool hideMesh;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool showParticles;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.ParticleSystem pointCloudParticlePrefab;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject meshPrefab;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool showTimeOutput;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TSDF_Config()
    {
    
    }

}
