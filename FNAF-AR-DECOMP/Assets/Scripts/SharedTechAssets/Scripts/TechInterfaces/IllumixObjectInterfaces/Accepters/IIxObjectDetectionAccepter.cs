using UnityEngine;

namespace SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IIxObjectDetectionAccepter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnObjectDetectionUpdate(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[] detections); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnObjectDetectionBegin(); // 0
    
    }

}
