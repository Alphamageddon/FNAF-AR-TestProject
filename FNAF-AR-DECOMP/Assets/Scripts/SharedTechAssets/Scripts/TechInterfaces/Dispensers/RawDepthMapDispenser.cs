using UnityEngine;

namespace SharedTechAssets.Scripts.TechInterfaces.Dispensers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RawDepthMapDispenser
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IRawDepthMapAccepter> _accepters;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAccepters(System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IRawDepthMapAccepter> accepters)
        {
            this._accepters = accepters;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddAccepter(SharedTechAssets.Scripts.TechInterfaces.Accepters.IRawDepthMapAccepter accepter)
        {
            this._accepters.Add(item:  accepter);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendAddEvent(int w, int h)
        {
            goto label_1;
            label_9:
            var val_4 = 0;
            val_4 = val_4 + 1;
            this._accepters.Item[0].Add(width:  w, height:  h);
            0 = 1;
            label_1:
            if(0 < this._accepters.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendUpdateEvent(double[] depth, bool isLandscape, UnityEngine.Matrix4x4 cameraTransform, UnityEngine.Matrix4x4 projectionMatrix, int position)
        {
            var val_6;
            var val_7;
            val_6 = 1152921523056251728;
            val_7 = 0;
            goto label_1;
            label_9:
            var val_5 = 0;
            val_5 = val_5 + 1;
            this._accepters.Item[0].Update(depthMap:  depth, isLandscape:  isLandscape, cameraTransform:  new UnityEngine.Matrix4x4() {m00 = cameraTransform.m00, m01 = cameraTransform.m01, m02 = cameraTransform.m02, m03 = cameraTransform.m03}, projectionMatrix:  new UnityEngine.Matrix4x4() {m00 = projectionMatrix.m00, m01 = projectionMatrix.m01, m02 = projectionMatrix.m02, m03 = projectionMatrix.m03}, position:  position);
            val_7 = 1;
            label_1:
            if(val_7 < this._accepters.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RawDepthMapDispenser()
        {
            this._accepters = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IRawDepthMapAccepter>();
        }
    
    }

}
