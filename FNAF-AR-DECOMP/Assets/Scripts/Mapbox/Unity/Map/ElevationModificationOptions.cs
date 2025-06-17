using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ElevationModificationOptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int sampleCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool useRelativeHeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float earthRadius;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ElevationModificationOptions()
        {
            this.sampleCount = 10;
            this.earthRadius = 1000f;
        }
    
    }

}
