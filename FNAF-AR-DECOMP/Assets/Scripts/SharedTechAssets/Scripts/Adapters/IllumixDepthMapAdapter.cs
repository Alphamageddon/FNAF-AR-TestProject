using UnityEngine;

namespace SharedTechAssets.Scripts.Adapters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IllumixDepthMapAdapter : IRawDepthMapAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters.IIllumixDepthMapAccepter _accepter;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters.IIllumixDepthMapAccepter accepter)
        {
            this._accepter = accepter;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Add(int width, int height)
        {
            int val_3;
            SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixDepthMap val_1 = null;
            val_3 = height;
            val_1 = new SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixDepthMap(width:  width, height:  val_3);
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = 0;
            this._accepter.Add(map:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update(double[] depthMap, bool isOrientation, UnityEngine.Matrix4x4 cameraTransform, UnityEngine.Matrix4x4 projectionMatrix, int position)
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            isOrientation = isOrientation;
            this._accepter.GetMap().Update(depth:  depthMap, isLandscape:  isOrientation, cameraTransform:  new UnityEngine.Matrix4x4() {m00 = cameraTransform.m00, m01 = cameraTransform.m01, m02 = cameraTransform.m02, m03 = cameraTransform.m03}, projectionMatrix:  new UnityEngine.Matrix4x4() {m00 = projectionMatrix.m00, m01 = projectionMatrix.m01, m02 = projectionMatrix.m02, m03 = projectionMatrix.m03}, position:  position);
            var val_5 = 0;
            val_5 = val_5 + 1;
            this._accepter.UpdateMap();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IllumixDepthMapAdapter()
        {
        
        }
    
    }

}
