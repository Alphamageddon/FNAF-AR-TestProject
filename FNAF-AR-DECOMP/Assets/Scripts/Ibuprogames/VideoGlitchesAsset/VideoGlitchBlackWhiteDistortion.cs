using UnityEngine;

namespace Ibuprogames.VideoGlitchesAsset
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class VideoGlitchBlackWhiteDistortion : VideoGlitchBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float distortionSteps;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float distortionAmountMinLimit;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float distortionAmountMaxLimit;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float distortionSpeed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float distortionAmount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableDistortionSteps = "_DistortionSteps";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableDistortionAmount = "_DistortionAmount";
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Steps { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float MinLimit { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float MaxLimit { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Speed { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Steps()
        {
            return (float)this.distortionSteps;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Steps(float value)
        {
            this.distortionSteps = UnityEngine.Mathf.Clamp(value:  value, min:  1f, max:  10f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_MinLimit()
        {
            return (float)this.distortionAmountMinLimit;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_MinLimit(float value)
        {
            this.distortionAmountMinLimit = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  360f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_MaxLimit()
        {
            return (float)this.distortionAmountMaxLimit;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_MaxLimit(float value)
        {
            this.distortionAmountMaxLimit = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  360f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Speed()
        {
            return (float)this.distortionSpeed;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Speed(float value)
        {
            this.distortionSpeed = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  10f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return "Black and white with analog distortion.";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void ResetDefaultValues()
        {
            this.distortionAmount = 340f;
            this.distortionSteps = ;
            this.distortionAmountMinLimit = ;
            this.distortionAmountMaxLimit = 360f;
            this.distortionSpeed = 1f;
            mem[1152921520029382064] = 998445679;
            mem[1152921520029382008] = 1065353216;
            mem[1152921520029382036] = 1065353216;
            mem[1152921520029382068] = 1;
            mem[1152921520029382020] = ;
            mem[1152921520029382072] = 1065353216;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void SendValuesToShader()
        {
            float val_2;
            SetFloat(name:  "_DistortionSteps", value:  this.distortionSteps);
            val_2 = this.distortionAmount;
            if(val_2 > this.distortionAmountMaxLimit)
            {
                    this.distortionAmount = this.distortionAmountMinLimit;
                val_2 = this.distortionAmountMinLimit;
            }
            else
            {
                    if(val_2 < 0)
            {
                    val_2 = this.distortionAmountMaxLimit;
                this.distortionAmount = this.distortionAmountMaxLimit;
            }
            
            }
            
            if(this.distortionSpeed > 0f)
            {
                    float val_1 = UnityEngine.Time.deltaTime;
                val_1 = val_1 * this.distortionSpeed;
                val_2 = val_2 + val_1;
                this.distortionAmount = val_2;
            }
            
            this.SetFloat(name:  "_DistortionAmount", value:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VideoGlitchBlackWhiteDistortion()
        {
            this.distortionAmount = 340f;
            this.distortionSteps = ;
            this.distortionAmountMinLimit = ;
            this.distortionAmountMaxLimit = 360f;
            this.distortionSpeed = 1f;
        }
    
    }

}
