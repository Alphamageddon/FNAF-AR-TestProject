using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixObjects
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxSemanticVoxel : IllumixSurfaceObject
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int objectCounter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float SideLength;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticInfo Prediction;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxSemanticVoxel(UnityEngine.Vector3 center, float sideLength, string label, int labelId, float confidence)
        {
            null = null;
            SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVoxel.objectCounter = SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVoxel.objectCounter + 1;
            string val_2 = "SBC" + SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVoxel.objectCounter;
            this.SideLength = sideLength;
            this.Prediction = label;
            mem[1152921523145392680] = confidence;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static IxSemanticVoxel()
        {
        
        }
    
    }

}
