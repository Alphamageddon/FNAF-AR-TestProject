using UnityEngine;

namespace Ibuprogames.VideoGlitchesAsset
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class VideoGlitchNoiseAnalog : VideoGlitchBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float stripesSize;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int barsCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float distortion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float noiseIntensity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableStripesSize = "_StripesSize";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableBarsCount = "_BarsCount";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableDistortion = "_Distortion";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableNoiseIntensity = "_NoiseIntensity";
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float StripesSize { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int BarsCount { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Distortion { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Noise { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_StripesSize()
        {
            return (float)this.stripesSize;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_StripesSize(float value)
        {
            this.stripesSize = UnityEngine.Mathf.Clamp01(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_BarsCount()
        {
            return (int)this.barsCount;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_BarsCount(int value)
        {
            this.barsCount = value & (~(value >> 31));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Distortion()
        {
            return (float)this.distortion;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Distortion(float value)
        {
            this.distortion = UnityEngine.Mathf.Clamp01(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Noise()
        {
            return (float)this.noiseIntensity;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Noise(float value)
        {
            this.noiseIntensity = UnityEngine.Mathf.Clamp01(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return "Analog noise.";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void ResetDefaultValues()
        {
            this.stripesSize = 0.25f;
            this.barsCount = 10;
            mem[1152921520036257584] = 998445679;
            this.distortion = 0.1f;
            this.noiseIntensity = 0.2f;
            mem[1152921520036257528] = 1065353216;
            mem[1152921520036257556] = 1065353216;
            mem[1152921520036257588] = 1;
            mem[1152921520036257540] = ;
            mem[1152921520036257592] = 1065353216;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void SendValuesToShader()
        {
            SetFloat(name:  "_StripesSize", value:  this.stripesSize);
            SetFloat(name:  "_BarsCount", value:  (float)this.barsCount);
            SetFloat(name:  "_Distortion", value:  this.distortion);
            float val_1 = 0.05f;
            val_1 = this.noiseIntensity * val_1;
            SetFloat(name:  "_NoiseIntensity", value:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VideoGlitchNoiseAnalog()
        {
            this.stripesSize = 0.25f;
            this.barsCount = 10;
            this.distortion = 0.25f;
            this.noiseIntensity = 7.346868E-41f;
        }
    
    }

}
