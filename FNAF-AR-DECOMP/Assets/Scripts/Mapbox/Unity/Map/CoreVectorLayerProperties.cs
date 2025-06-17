using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class CoreVectorLayerProperties
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string sourceId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool isActive;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string sublayerName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.VectorPrimitiveType geometryType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string layerName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool snapToTerrain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool combineMeshes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float lineWidth;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CoreVectorLayerProperties()
        {
            this.isActive = true;
            this.geometryType = 2;
            this.sublayerName = "untitled";
            this.snapToTerrain = true;
            this.lineWidth = 1f;
            this.layerName = "layerName";
        }
    
    }

}
