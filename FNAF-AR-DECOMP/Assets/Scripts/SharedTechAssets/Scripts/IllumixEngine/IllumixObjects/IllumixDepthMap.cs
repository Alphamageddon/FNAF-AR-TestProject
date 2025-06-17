using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixObjects
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IllumixDepthMap
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double[] DepthMap;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Width;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Height;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Matrix4x4 CameraTransform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Matrix4x4 ProjectionMatrix;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsLandscape;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Position;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IllumixDepthMap(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update(double[] depth, bool isLandscape, UnityEngine.Matrix4x4 cameraTransform, UnityEngine.Matrix4x4 projectionMatrix, int position)
        {
            this.DepthMap = depth;
            this.IsLandscape = isLandscape;
            mem[1152921523141896432] = cameraTransform.m02;
            mem[1152921523141896448] = cameraTransform.m03;
            this.CameraTransform = cameraTransform.m00;
            mem[1152921523141896416] = cameraTransform.m01;
            this.Position = position;
            mem[1152921523141896496] = projectionMatrix.m02;
            mem[1152921523141896512] = projectionMatrix.m03;
            this.ProjectionMatrix = projectionMatrix.m00;
            mem[1152921523141896480] = projectionMatrix.m01;
        }
    
    }

}
