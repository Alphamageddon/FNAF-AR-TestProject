using UnityEngine;

namespace Ibuprogames.VideoGlitchesAsset
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class VideoGlitchBrokenCamera : VideoGlitchBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float malfunction;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float noise;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float distortionIntensity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float distortionSpeed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableMalfunction = "_Malfunction";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableNoise = "_Noise";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableDistortionIntensity = "_DistortionIntensity";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableDistortionSpeed = "_DistortionSpeed";
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Malfunction { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Noise { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float DistortionIntensity { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float DistortionSpeed { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Malfunction()
        {
            return (float)this.malfunction;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Malfunction(float value)
        {
            this.malfunction = UnityEngine.Mathf.Clamp01(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Noise()
        {
            return (float)this.noise;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Noise(float value)
        {
            this.noise = ;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_DistortionIntensity()
        {
            return (float)this.distortionIntensity;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_DistortionIntensity(float value)
        {
            this.distortionIntensity = ;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_DistortionSpeed()
        {
            return (float)this.distortionSpeed;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_DistortionSpeed(float value)
        {
            this.distortionSpeed = ;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return "Broken camera.";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void ResetDefaultValues()
        {
            mem[1152921520030726328] = 1065353216;
            mem[1152921520030726356] = 1065353216;
            mem[1152921520030726384] = 998445679;
            mem[1152921520030726388] = 1;
            this.malfunction = ;
            this.noise = ;
            this.distortionIntensity = 0.3f;
            this.distortionSpeed = 0.1f;
            mem[1152921520030726340] = ;
            mem[1152921520030726392] = 1065353216;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void SendValuesToShader()
        {
            float val_1 = this.malfunction + this.malfunction;
            val_1 = val_1 + (-1f);
            SetFloat(name:  "_Malfunction", value:  val_1);
            float val_4 = 0.025f;
            val_4 = this.noise * val_4;
            SetFloat(name:  "_Noise", value:  val_4);
            SetFloat(name:  "_DistortionIntensity", value:  this.distortionIntensity * 0.1f);
            SetFloat(name:  "_DistortionSpeed", value:  this.distortionSpeed * 0.1f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VideoGlitchBrokenCamera()
        {
            this.malfunction = ;
            this.noise = ;
            this.distortionIntensity = 0.3f;
            this.distortionSpeed = 0.1f;
        }
    
    }

}
