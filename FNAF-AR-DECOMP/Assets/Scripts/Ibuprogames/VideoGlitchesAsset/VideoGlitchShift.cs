using UnityEngine;

namespace Ibuprogames.VideoGlitchesAsset
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class VideoGlitchShift : VideoGlitchBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float amplitude;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float speed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Texture noiseTex;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableNoise = "_NoiseTex";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableAmplitude = "_Amplitude";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableSpeed = "_Speed";
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Amplitude { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Speed { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Amplitude()
        {
            return (float)this.amplitude;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Amplitude(float value)
        {
            this.amplitude = ;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Speed()
        {
            return (float)this.speed;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Speed(float value)
        {
            this.speed = ;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return "Color channels shift.";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void LoadCustomResources()
        {
            this.noiseTex = this.LoadTextureFromResources(texturePathFromResources:  "Textures/Noise256");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void ResetDefaultValues()
        {
            this.amplitude = 0.5f;
            this.speed = 0.25f;
            mem[1152921520049150512] = 998445679;
            mem[1152921520049150456] = 1065353216;
            mem[1152921520049150484] = 1065353216;
            mem[1152921520049150516] = 1;
            mem[1152921520049150468] = ;
            mem[1152921520049150520] = 1065353216;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void SendValuesToShader()
        {
            SetFloat(name:  "_Amplitude", value:  this.amplitude);
            float val_1 = 0.1f;
            val_1 = this.speed * val_1;
            SetFloat(name:  "_Speed", value:  val_1);
            SetTexture(name:  "_NoiseTex", value:  this.noiseTex);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VideoGlitchShift()
        {
            this.amplitude = 0.5f;
            this.speed = 1f;
        }
    
    }

}
