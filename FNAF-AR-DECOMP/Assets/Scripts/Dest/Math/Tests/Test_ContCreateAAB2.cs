using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_ContCreateAAB2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Dest.Math.AAB2 _aab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2[] _points;
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
            this._points = new UnityEngine.Vector2[0];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            this.DrawPoints(points:  this._points, size:  0.11f);
            this.DrawAAB(box: ref  new Dest.Math.AAB2() {Min = new UnityEngine.Vector2() {x = this._aab, y = this._aab}, Max = new UnityEngine.Vector2() {x = this._aab, y = this._aab}});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            bool val_5 = this.ToggleToGenerate;
            if(((val_5 == true) ? 1 : 0) != ((this._previous == true) ? 1 : 0))
            {
                    UnityEngine.Vector2[] val_3 = this.GenerateRandomSet2D(setRadius:  this.GenerateRadius, countMin:  this.GenerateCountMin, countMax:  this.GenerateCountMax, coeffX:  1f, coeffY:  1f);
                this._points = val_3;
                Dest.Math.AAB2 val_4 = Dest.Math.AAB2.CreateFromPoints(points:  val_3);
                val_5 = this.ToggleToGenerate;
                this._aab = this.GenerateRadius;
                mem[1152921519525503292] = 1f;
                mem[1152921519525503296] = 1f;
                mem[1152921519525503300] = ???;
            }
            
            this._previous = val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_ContCreateAAB2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
