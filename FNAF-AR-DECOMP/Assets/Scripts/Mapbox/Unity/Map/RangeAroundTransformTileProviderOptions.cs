using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class RangeAroundTransformTileProviderOptions : ITileProviderOptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform targetTransform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int visibleBuffer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int disposeBuffer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetOptions(UnityEngine.Transform tgtTransform, int visibleRange, int disposeRange)
        {
            this.targetTransform = tgtTransform;
            this.visibleBuffer = visibleRange;
            this.disposeBuffer = disposeRange;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RangeAroundTransformTileProviderOptions()
        {
        
        }
    
    }

}
