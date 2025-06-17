using UnityEngine;

namespace SRDebugger.UI.Controls
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ProfilerGraphAxisLabel : SRMonoBehaviourEx
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _prevFrameTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<float> _queuedFrameTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _yPosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text Text;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Update()
        {
            this.Update();
            if((this._queuedFrameTime & 1) == 0)
            {
                    return;
            }
            
            this.SetValueInternal(frameTime:  null);
            this._queuedFrameTime = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetValue(float frameTime, float yPosition)
        {
            if(this._prevFrameTime == frameTime)
            {
                    if(this._yPosition == yPosition)
            {
                    return;
            }
            
            }
            
            this._yPosition = yPosition;
            this._queuedFrameTime = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetValueInternal(float frameTime)
        {
            var val_6;
            var val_9;
            var val_10;
            this._prevFrameTime = frameTime;
            float val_9 = 1000f;
            val_9 = frameTime * val_9;
            float val_10 = 1f;
            val_10 = val_10 / frameTime;
            object[] val_3 = new object[2];
            val_3[0] = UnityEngine.Mathf.FloorToInt(f:  val_9);
            val_3[1] = UnityEngine.Mathf.RoundToInt(f:  val_10);
            string val_4 = SRF.SRFStringExtensions.Fmt(formatString:  "{0}ms ({1}FPS)", args:  val_3);
            val_9 = this.CachedTransform;
            if(val_9 != null)
            {
                    if(null == null)
            {
                goto label_12;
            }
            
            }
            
            val_9 = 0;
            val_10 = 1;
            goto label_13;
            label_12:
            val_10 = 0;
            label_13:
            UnityEngine.Rect val_7 = val_9.rect;
            val_7.m_XMin = val_7.m_XMin * 0.5f;
            val_7.m_XMin = val_7.m_XMin + 10f;
            val_6 = 0;
            UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_7.m_XMin, y:  this._yPosition);
            val_9.anchoredPosition = new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProfilerGraphAxisLabel()
        {
        
        }
    
    }

}
