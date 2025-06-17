using UnityEngine;

namespace Ibuprogames.VideoGlitchesAsset
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class VideoGlitchRadialAberration : VideoGlitchBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2 focus;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int samples;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float blur;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float falloff;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableFocus = "_Focus";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableSamples = "_Samples";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableBlur = "_Blur";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableFalloff = "_Falloff";
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector2 Focus { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Samples { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Blur { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Falloff { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector2 get_Focus()
        {
            return new UnityEngine.Vector2() {x = this.focus};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Focus(UnityEngine.Vector2 value)
        {
            this.focus = value;
            mem[1152921520046565452] = value.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Samples()
        {
            return (int)this.samples;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Samples(int value)
        {
            this.samples = (value > 1) ? value : (0 + 1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Blur()
        {
            return (float)this.blur;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Blur(float value)
        {
            this.blur = UnityEngine.Mathf.Clamp01(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Falloff()
        {
            return (float)this.falloff;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Falloff(float value)
        {
            this.falloff = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  5f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return "Radial color aberration.";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void ResetDefaultValues()
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  0.5f, y:  0.5f);
            this.samples = 15;
            this.blur = 0.25f;
            this.falloff = 3f;
            mem[1152921520047461536] = 998445679;
            mem[1152921520047461540] = 1;
            mem[1152921520047461480] = 1065353216;
            mem[1152921520047461508] = 1065353216;
            this.focus = val_1.x;
            mem[1152921520047461580] = val_1.y;
            mem[1152921520047461492] = ;
            mem[1152921520047461544] = 1065353216;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void SendValuesToShader()
        {
            UnityEngine.Vector4 val_1 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector2() {x = this.focus, y = V8.16B});
            SetVector(name:  "_Focus", value:  new UnityEngine.Vector4() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w});
            SetInt(name:  "_Samples", value:  this.samples);
            SetFloat(name:  "_Blur", value:  this.blur);
            SetFloat(name:  "_Falloff", value:  this.falloff);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VideoGlitchRadialAberration()
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  0.5f, y:  0.5f);
            mem[1152921520047685932] = val_1.y;
            this.samples = 15;
            this.focus = val_1.x;
            this.blur = 0.25f;
            this.falloff = 3f;
        }
    
    }

}
