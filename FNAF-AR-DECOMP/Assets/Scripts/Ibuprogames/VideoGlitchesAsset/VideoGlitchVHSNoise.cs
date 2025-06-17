using UnityEngine;

namespace Ibuprogames.VideoGlitchesAsset
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class VideoGlitchVHSNoise : VideoGlitchBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float speed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float intensity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float size;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Color color;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableSpeed = "_Speed";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableIntensity = "_Intensity";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableSize = "_Size";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableColor = "_Color";
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Speed { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Intensity { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Size { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Color Color { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Speed()
        {
            return (float)this.speed;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Speed(float value)
        {
            this.speed = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Intensity()
        {
            return (float)this.intensity;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Intensity(float value)
        {
            this.intensity = ;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Size()
        {
            return (float)this.size;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Size(float value)
        {
            this.size = ;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Color get_Color()
        {
            return new UnityEngine.Color() {r = this.color};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Color(UnityEngine.Color value)
        {
            this.color = value;
            mem[1152921520051175144] = value.g;
            mem[1152921520051175148] = value.b;
            mem[1152921520051175152] = value.a;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return "VHS noise.";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void ResetDefaultValues()
        {
            this.speed = 2f;
            this.intensity = 5.510186E-41f;
            this.size = 0.25f;
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.color = val_1;
            mem[1152921520051399240] = val_1.g;
            mem[1152921520051399244] = val_1.b;
            mem[1152921520051399248] = val_1.a;
            this.ResetDefaultValues();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void SendValuesToShader()
        {
            SetFloat(name:  "_Speed", value:  this.speed);
            SetFloat(name:  "_Intensity", value:  this.intensity);
            float val_1 = 1000f;
            val_1 = this.size * val_1;
            SetFloat(name:  "_Size", value:  val_1);
            SetColor(name:  "_Color", value:  new UnityEngine.Color() {r = this.color, g = V9.16B, b = V10.16B, a = V11.16B});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VideoGlitchVHSNoise()
        {
            this.speed = 2f;
            this.intensity = 5.510186E-41f;
            this.size = 0.25f;
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.color = val_1;
            mem[1152921520051623320] = val_1.g;
            mem[1152921520051623324] = val_1.b;
            mem[1152921520051623328] = val_1.a;
        }
    
    }

}
