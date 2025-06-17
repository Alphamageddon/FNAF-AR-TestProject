using UnityEngine;

namespace Ibuprogames.VideoGlitchesAsset
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class VideoGlitchCorruptionDigital : VideoGlitchBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float speed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float intensity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float posterize;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int tileSize;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableSpeed = "_Speed";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableIntensity = "_Intensity";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableTileSize = "_TileSize";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variablePosterize = "_Posterize";
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Speed { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Intensity { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Posterize { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int TileSize { get; set; }
        
        // Methods
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
        public float get_Posterize()
        {
            return (float)this.posterize;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Posterize(float value)
        {
            this.posterize = UnityEngine.Mathf.Clamp01(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_TileSize()
        {
            return (int)this.tileSize;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_TileSize(int value)
        {
            this.tileSize = (value > 1) ? value : (0 + 1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return "Digital signal corruption.";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void ResetDefaultValues()
        {
            this.speed = 1f;
            this.intensity = 0.6f;
            this.posterize = 0.25f;
            this.tileSize = 128;
            mem[1152921520034913200] = 998445679;
            mem[1152921520034913144] = 1f;
            mem[1152921520034913172] = 1f;
            mem[1152921520034913204] = 1;
            mem[1152921520034913156] = ;
            mem[1152921520034913208] = 1f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void SendValuesToShader()
        {
            SetFloat(name:  "_Speed", value:  this.speed);
            SetFloat(name:  "_Intensity", value:  this.intensity);
            SetFloat(name:  "_TileSize", value:  (float)this.tileSize);
            float val_1 = 1f;
            val_1 = val_1 - this.posterize;
            SetFloat(name:  "_Posterize", value:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VideoGlitchCorruptionDigital()
        {
            this.speed = 1f;
            this.intensity = 5.510186E-41f;
            this.posterize = 0.25f;
            this.tileSize = 128;
        }
    
    }

}
