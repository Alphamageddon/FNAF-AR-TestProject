using UnityEngine;

namespace SharedTechAssets.Scripts.TechInterfaces.Accepters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IRawDepthMapAccepter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Add(int width, int height); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Update(double[] depthMap, bool isLandscape, UnityEngine.Matrix4x4 cameraTransform, UnityEngine.Matrix4x4 projectionMatrix, int position); // 0
    
    }

}
