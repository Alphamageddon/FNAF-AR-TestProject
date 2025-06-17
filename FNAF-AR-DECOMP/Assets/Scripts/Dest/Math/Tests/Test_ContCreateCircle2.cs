using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_ContCreateCircle2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Dest.Math.Circle2 _circle0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Dest.Math.Circle2 _circle1;
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
            UnityEngine.Color val_1 = UnityEngine.Color.red;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
            0.DrawCircle(circle: ref  new Dest.Math.Circle2() {Center = new UnityEngine.Vector2() {x = this._circle0, y = this._circle0}, Radius = this._circle0});
            UnityEngine.Color val_2 = UnityEngine.Color.blue;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
            0.DrawCircle(circle: ref  new Dest.Math.Circle2() {Center = new UnityEngine.Vector2() {x = this._circle1, y = this._circle1}, Radius = this._circle1});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            bool val_6 = this.ToggleToGenerate;
            if(((val_6 == true) ? 1 : 0) != ((this._previous == true) ? 1 : 0))
            {
                    UnityEngine.Vector2[] val_3 = this.GenerateRandomSet2D(setRadius:  this.GenerateRadius, countMin:  this.GenerateCountMin, countMax:  this.GenerateCountMax, coeffX:  1f, coeffY:  1f);
                this._points = val_3;
                Dest.Math.Circle2 val_4 = Dest.Math.Circle2.CreateFromPointsAAB(points:  val_3);
                this._circle0 = this.GenerateRadius;
                mem[1152921519526755612] = 1f;
                mem[1152921519526755616] = 1f;
                Dest.Math.Circle2 val_5 = Dest.Math.Circle2.CreateFromPointsAverage(points:  this._points);
                val_6 = this.ToggleToGenerate;
                this._circle1 = this.GenerateRadius;
                mem[1152921519526755624] = 1f;
                mem[1152921519526755628] = 1f;
            }
            
            this._previous = val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_ContCreateCircle2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
