using UnityEngine;

namespace SRDebugger.UI.Other
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LoadingSpinnerBehaviour : SRMonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _dt;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int FrameCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float SpinDuration;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            var val_6;
            float val_7;
            float val_8;
            val_6 = this;
            float val_1 = UnityEngine.Time.unscaledDeltaTime;
            val_1 = this._dt + val_1;
            this._dt = val_1;
            UnityEngine.Quaternion val_3 = this.CachedTransform.localRotation;
            int val_6 = this.FrameCount;
            val_7 = val_3.x;
            float val_8 = this._dt;
            val_8 = val_3.z;
            val_6 = this.SpinDuration / (float)val_6;
            if(val_8 <= val_6)
            {
                    return;
            }
            
            float val_7 = 360f;
            val_7 = val_7 / (float)val_6;
            do
            {
                val_8 = val_8 - val_6;
                val_8 = val_8 - val_7;
            }
            while(val_8 > val_6);
            
            this._dt = val_8;
            val_6 = this.CachedTransform;
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.Euler(x:  val_7, y:  val_3.y, z:  val_8);
            val_7 = val_5.x;
            val_8 = val_5.z;
            val_6.localRotation = new UnityEngine.Quaternion() {x = val_7, y = val_5.y, z = val_8, w = val_5.w};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LoadingSpinnerBehaviour()
        {
            this.FrameCount = 12;
            this.SpinDuration = 7.346868E-41f;
        }
    
    }

}
