using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class CameraBoundsTileProviderOptions : ITileProviderOptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Camera camera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int visibleBuffer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int disposeBuffer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetOptions(UnityEngine.Camera mapCamera, int visibleRange, int disposeRange, float updateTimeInterval)
        {
            this.camera = mapCamera;
            this.visibleBuffer = visibleRange;
            this.disposeBuffer = disposeRange;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CameraBoundsTileProviderOptions()
        {
        
        }
    
    }

}
