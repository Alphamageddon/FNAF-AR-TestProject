using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ElevationRequiredOptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool addCollider;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float exaggerationFactor;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ElevationRequiredOptions()
        {
            this.exaggerationFactor = 1f;
        }
    
    }

}
