using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class LayerPerformanceOptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool isEnabled;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int entityPerCoroutine;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LayerPerformanceOptions()
        {
            this.isEnabled = true;
            this.entityPerCoroutine = 20;
        }
    
    }

}
