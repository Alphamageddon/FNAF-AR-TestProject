using UnityEngine;

namespace SharedTechAssets.Scripts.DepthHandler
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DepthPredictionStarter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera _camera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DepthObjectManager _manager;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 tmpPoint;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DepthPredictionStarter(DepthObjectManager manager, UnityEngine.Camera camera)
        {
            this._camera = camera;
            this._manager = manager;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float[] SetupForPrediction(float[] floats)
        {
            UnityEngine.Camera val_8;
            int val_9;
            var val_2 = (floats.Length < 0) ? (floats.Length + 3) : floats.Length;
            val_8 = val_2 >> 2;
            var val_4 = (val_8 << 1) + (val_2 >> 2);
            float[] val_5 = new float[0];
            if(floats.Length >= 4)
            {
                    var val_13 = 0;
                var val_12 = 0;
                var val_11 = val_8;
                do
            {
                val_9 = floats.Length;
                if(val_12 >= val_9)
            {
                    val_9 = floats.Length;
            }
            
                if((val_12 + 1) >= val_9)
            {
                    val_9 = floats.Length;
            }
            
                var val_7 = val_12 + 2;
                val_8 = this._camera;
                UnityEngine.Vector3 val_8 = val_8.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = this.tmpPoint, y = 1.139911E+09f, z = V10.16B});
                mem2[0] = val_8.x;
                var val_9 = val_13 + 1;
                mem2[0] = val_8.x;
                var val_10 = val_13 + 2;
                mem2[0] = val_8.x;
                val_11 = val_11 - 1;
                val_12 = val_12 + 4;
                val_13 = val_13 + 3;
            }
            while(val_11 != 0);
            
            }
            
            this._manager.lastSparseData = val_5;
            return (System.Single[])val_5;
        }
    
    }

}
