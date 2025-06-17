using UnityEngine;

namespace Ibuprogames.VideoGlitchesAsset
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class VideoGlitchBrokenScreen : VideoGlitchBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2 impact;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int splits;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float splitThreshold;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Color splitColor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float distortion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableCenter = "_Center";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableSplits = "_Splits";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableSplitThreshold = "_SplitThreshold";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableSplitColor = "_SplitColor";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableDistortion = "_Distortion";
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector2 Impact { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Splits { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Threshold { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Color Color { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Distortion { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector2 get_Impact()
        {
            return new UnityEngine.Vector2() {x = this.impact};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Impact(UnityEngine.Vector2 value)
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.ClampMagnitude(vector:  new UnityEngine.Vector2() {x = value.x, y = value.y}, maxLength:  1f);
            this.impact = val_1;
            mem[1152921520031174748] = val_1.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Splits()
        {
            return (int)this.splits;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Splits(int value)
        {
            this.splits = (value > 2) ? value : 2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Threshold()
        {
            return (float)this.splitThreshold;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Threshold(float value)
        {
            this.splitThreshold = UnityEngine.Mathf.Clamp01(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Color get_Color()
        {
            return new UnityEngine.Color() {r = this.splitColor};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Color(UnityEngine.Color value)
        {
            this.splitColor = value;
            mem[1152921520031846764] = value.g;
            mem[1152921520031846768] = value.b;
            mem[1152921520031846772] = value.a;
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
        public override string ToString()
        {
            return "Broken screen (simulated).";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void ResetDefaultValues()
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            this.impact = val_1;
            mem[1152921520032294876] = val_1.y;
            this.splits = 25;
            this.splitThreshold = 1f;
            UnityEngine.Color val_2 = UnityEngine.Color.gray;
            this.distortion = 0.2f;
            this.splitColor = val_2;
            mem[1152921520032294892] = val_2.g;
            mem[1152921520032294832] = 998445679;
            mem[1152921520032294896] = val_2.b;
            mem[1152921520032294900] = val_2.a;
            mem[1152921520032294776] = 1f;
            mem[1152921520032294804] = 1f;
            mem[1152921520032294836] = 1;
            mem[1152921520032294788] = ;
            mem[1152921520032294840] = 1f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void SendValuesToShader()
        {
            UnityEngine.Vector4 val_1 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector2() {x = this.impact, y = V8.16B});
            SetVector(name:  "_Center", value:  new UnityEngine.Vector4() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w});
            SetInt(name:  "_Splits", value:  this.splits);
            SetFloat(name:  "_SplitThreshold", value:  this.splitThreshold);
            SetColor(name:  "_SplitColor", value:  new UnityEngine.Color() {r = this.splitColor, g = val_1.y, b = val_1.z, a = val_1.w});
            float val_2 = 0.1f;
            val_2 = this.distortion * val_2;
            SetFloat(name:  "_Distortion", value:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VideoGlitchBrokenScreen()
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            this.impact = val_1;
            mem[1152921520032519372] = val_1.y;
            this.splits = 25;
            this.splitThreshold = 1f;
            UnityEngine.Color val_2 = UnityEngine.Color.gray;
            this.splitColor = val_2;
            mem[1152921520032519388] = val_2.g;
            mem[1152921520032519392] = val_2.b;
            mem[1152921520032519396] = val_2.a;
            this.distortion = 0.2f;
        }
    
    }

}
