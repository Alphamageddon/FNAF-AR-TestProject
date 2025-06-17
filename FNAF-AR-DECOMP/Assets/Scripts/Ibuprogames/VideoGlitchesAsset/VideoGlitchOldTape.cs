using UnityEngine;

namespace Ibuprogames.VideoGlitchesAsset
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class VideoGlitchOldTape : VideoGlitchBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float noiseSpeed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float noiseAmplitude;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableNoiseSpeed = "_NoiseSpeed";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableNoiseAmplitude = "_NoiseAmplitude";
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Speed { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Amplitude { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Speed()
        {
            return (float)this.noiseSpeed;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Speed(float value)
        {
            this.noiseSpeed = ;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Amplitude()
        {
            return (float)this.noiseAmplitude;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Amplitude(float value)
        {
            this.noiseAmplitude = ;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return "Old video tape.";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void ResetDefaultValues()
        {
            this.noiseSpeed = 0.25f;
            this.noiseAmplitude = 1f;
            mem[1152921520038274232] = 1f;
            mem[1152921520038274260] = 1f;
            mem[1152921520038274288] = 998445679;
            mem[1152921520038274292] = 1;
            mem[1152921520038274244] = ;
            mem[1152921520038274296] = 1f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void SendValuesToShader()
        {
            float val_1 = 0.0001f;
            val_1 = this.noiseSpeed * val_1;
            SetFloat(name:  "_NoiseSpeed", value:  val_1);
            float val_2 = 101f;
            val_2 = val_2 - this.noiseAmplitude;
            val_2 = val_2 * 1000f;
            SetFloat(name:  "_NoiseAmplitude", value:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VideoGlitchOldTape()
        {
            this.noiseSpeed = 1f;
            this.noiseAmplitude = 1f;
        }
    
    }

}
