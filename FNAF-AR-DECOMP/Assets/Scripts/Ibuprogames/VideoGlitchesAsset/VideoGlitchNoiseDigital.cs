using UnityEngine;

namespace Ibuprogames.VideoGlitchesAsset
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class VideoGlitchNoiseDigital : VideoGlitchBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float threshold;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float maxOffset;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float thresholdYUV;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableThreshold = "_Threshold";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableMaxOffset = "_MaxOffset";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableThresholdYUV = "_ThresholdYUV";
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Threshold { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float MaxOffset { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ThresholdYUV { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Threshold()
        {
            return (float)this.threshold;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Threshold(float value)
        {
            this.threshold = UnityEngine.Mathf.Clamp01(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_MaxOffset()
        {
            return (float)this.maxOffset;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_MaxOffset(float value)
        {
            this.maxOffset = UnityEngine.Mathf.Clamp01(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_ThresholdYUV()
        {
            return (float)this.thresholdYUV;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ThresholdYUV(float value)
        {
            this.thresholdYUV = UnityEngine.Mathf.Clamp01(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return "Digital noise.";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void ResetDefaultValues()
        {
            this.thresholdYUV = 0.5f;
            this.threshold = 0.1f;
            this.maxOffset = 0.1f;
            mem[1152921520037377984] = 998445679;
            mem[1152921520037377928] = 1065353216;
            mem[1152921520037377956] = 1065353216;
            mem[1152921520037377988] = 1;
            mem[1152921520037377940] = ;
            mem[1152921520037377992] = 1065353216;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void SendValuesToShader()
        {
            SetFloat(name:  "_Threshold", value:  this.threshold);
            SetFloat(name:  "_MaxOffset", value:  this.maxOffset);
            SetFloat(name:  "_ThresholdYUV", value:  this.thresholdYUV);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VideoGlitchNoiseDigital()
        {
            this.threshold = 0.1f;
            this.maxOffset = 7.346868E-41f;
            this.thresholdYUV = 0.5f;
        }
    
    }

}
