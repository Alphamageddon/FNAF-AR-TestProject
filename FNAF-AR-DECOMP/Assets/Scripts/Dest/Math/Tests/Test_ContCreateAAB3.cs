using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_ContCreateAAB3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Dest.Math.AAB3 _aab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3[] _points;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _previous;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ToggleToGenerate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GenerateRadius;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GenerateCountMin;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GenerateCountMax;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this._points = new UnityEngine.Vector3[0];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            this.DrawPoints(points:  this._points, size:  0.11f);
            this.DrawAAB(box: ref  new Dest.Math.AAB3() {Min = new UnityEngine.Vector3() {x = this._aab, y = this._aab, z = this._aab}, Max = new UnityEngine.Vector3() {x = this._aab, y = this._aab, z = this._aab}});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            var val_5;
            Dest.Math.AAB3 val_6;
            bool val_8 = this.ToggleToGenerate;
            if(((val_8 == true) ? 1 : 0) != ((this._previous == true) ? 1 : 0))
            {
                    UnityEngine.Vector3[] val_3 = this.GenerateRandomSet3D(setRadius:  this.GenerateRadius, countMin:  this.GenerateCountMin, countMax:  this.GenerateCountMax, coeffX:  1f, coeffY:  1f, coeffZ:  1f);
                this._points = val_3;
                Dest.Math.AAB3 val_4 = Dest.Math.AAB3.CreateFromPoints(points:  val_3);
                mem[1152921519529731832] = val_5;
                val_8 = this.ToggleToGenerate;
                this._aab = val_6;
            }
            
            this._previous = val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_ContCreateAAB3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
