using UnityEngine;

namespace Ibuprogames.VideoGlitchesAsset
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class VideoGlitchSpectrumOffset : VideoGlitchBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float intensity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int steps;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableIntensity = "_Intensity";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableSteps = "_Steps";
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Intensity { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Steps { get; set; }
        
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
        public int get_Steps()
        {
            return (int)this.steps;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Steps(int value)
        {
            this.steps = (value > 3) ? value : 3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return "Spectrum offset.";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void ResetDefaultValues()
        {
            this.intensity = 0.1f;
            this.steps = 5;
            this.ResetDefaultValues();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void SendValuesToShader()
        {
            SetFloat(name:  "_Intensity", value:  this.intensity);
            SetInt(name:  "_Steps", value:  this.steps);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VideoGlitchSpectrumOffset()
        {
            this.intensity = 0.1f;
            this.steps = 5;
        }
    
    }

}
