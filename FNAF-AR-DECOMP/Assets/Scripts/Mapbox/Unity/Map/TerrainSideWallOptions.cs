using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class TerrainSideWallOptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool isActive;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float wallHeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Material wallMaterial;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TerrainSideWallOptions()
        {
            this.wallHeight = 10f;
        }
    
    }

}
