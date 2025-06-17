using UnityEngine;

namespace SharedTechAssets.Scripts.TSDF2
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class TSDF_Config2 : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SharedTechAssets.Scripts.TSDF2.TSDF_Config2.TSDF_Properties props;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float updateTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SharedTechAssets.Scripts.TSDF2.TSDF_Config2.WeightSystem weightSystem;
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
        public int blockSize;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool showParticles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.ParticleSystem pointCloudParticlePrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool showTimeOutput;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int timeToDecay;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TSDF_Config2()
        {
        
        }
    
    }

}
