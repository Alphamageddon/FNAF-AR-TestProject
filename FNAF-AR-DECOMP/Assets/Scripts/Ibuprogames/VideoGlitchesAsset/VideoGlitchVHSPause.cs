using UnityEngine;

namespace Ibuprogames.VideoGlitchesAsset
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class VideoGlitchVHSPause : VideoGlitchBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float intensity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float noise;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Color noiseColor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableIntensity = "_Intensity";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableColorNoise = "_ColorNoise";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableNoiseColor = "_NoiseColor";
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Intensity { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Noise { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Color Color { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Intensity()
        {
            return (float)this.intensity;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Intensity(float value)
        {
            this.intensity = UnityEngine.Mathf.Clamp01(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Noise()
        {
            return (float)this.noise;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Noise(float value)
        {
            this.noise = UnityEngine.Mathf.Clamp01(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Color get_Color()
        {
            return new UnityEngine.Color() {r = this.noiseColor};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Color(UnityEngine.Color value)
        {
            this.noiseColor = value;
            mem[1152921520052295316] = value.g;
            mem[1152921520052295320] = value.b;
            mem[1152921520052295324] = value.a;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return "VHS pause noise.";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void ResetDefaultValues()
        {
            this.intensity = 1f;
            this.noise = 7.346868E-41f;
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.noiseColor = val_1;
            mem[1152921520052519428] = val_1.g;
            mem[1152921520052519432] = val_1.b;
            mem[1152921520052519436] = val_1.a;
            this.ResetDefaultValues();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void SendValuesToShader()
        {
            SetFloat(name:  "_Intensity", value:  this.intensity);
            SetFloat(name:  "_ColorNoise", value:  this.noise);
            SetColor(name:  "_NoiseColor", value:  new UnityEngine.Color() {r = this.noiseColor, g = V9.16B, b = V10.16B, a = V11.16B});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VideoGlitchVHSPause()
        {
            this.intensity = 1f;
            this.noise = 7.346868E-41f;
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.noiseColor = val_1;
            mem[1152921520052743620] = val_1.g;
            mem[1152921520052743624] = val_1.b;
            mem[1152921520052743628] = val_1.a;
        }
    
    }

}
