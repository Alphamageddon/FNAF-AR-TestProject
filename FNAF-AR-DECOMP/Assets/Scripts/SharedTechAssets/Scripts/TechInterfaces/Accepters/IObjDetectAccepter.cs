using UnityEngine;

namespace SharedTechAssets.Scripts.TechInterfaces.Accepters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IObjDetectAccepter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnDetectionUpdateEvent(string[] objects, float[] minX, float[] minY, float[] maxX, float[] maxY, float[] confidences); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnDetectionBeganEvent(); // 0
    
    }

}
