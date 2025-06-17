using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_RandomRotation : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _previous;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3[] _points;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ToggleToGenerate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Samples;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Scale;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            bool val_3 = this.ToggleToGenerate;
            if(((val_3 == true) ? 1 : 0) != ((this._previous == true) ? 1 : 0))
            {
                    this.Generate();
                val_3 = this.ToggleToGenerate;
            }
            
            this._previous = val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Generate()
        {
            var val_5;
            var val_6;
            this._points = new UnityEngine.Vector3[0];
            val_5 = null;
            val_5 = null;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = Dest.Math.Vector3ex.One, y = Dest.Math.Vector3ex.Zero.__il2cppRuntimeField_10, z = Dest.Math.Vector3ex.Zero.__il2cppRuntimeField_14}, d:  this.Scale);
            if(this.Samples < 1)
            {
                    return;
            }
            
            var val_6 = 0;
            do
            {
                val_6 = null;
                val_6 = null;
                UnityEngine.Quaternion val_3 = Dest.Math.Rand.Instance.RandomRotation();
                UnityEngine.Vector3 val_4 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}, point:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
                var val_5 = this._points + (0 * 12);
                mem2[0] = val_4.x;
                mem2[0] = val_4.y;
                mem2[0] = val_4.z;
                val_6 = val_6 + 1;
            }
            while(val_6 < this.Samples);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            if(this._points == null)
            {
                    return;
            }
            
            this.DrawPoints(points:  this._points, size:  0.11f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_RandomRotation()
        {
        
        }
    
    }

}
