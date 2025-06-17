using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_ContCreateBox2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Dest.Math.Box2 _box;
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
            this.DrawBox(box: ref  new Dest.Math.Box2() {Center = new UnityEngine.Vector2() {x = this._box, y = this._box}, Axis0 = new UnityEngine.Vector2() {x = this._box, y = this._box}, Axis1 = new UnityEngine.Vector2() {x = this._box, y = this._box}, Extents = new UnityEngine.Vector2() {x = this._box, y = this._box}});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            var val_5;
            Dest.Math.Box2 val_6;
            bool val_8 = this.ToggleToGenerate;
            if(((val_8 == true) ? 1 : 0) != ((this._previous == true) ? 1 : 0))
            {
                    UnityEngine.Vector2[] val_3 = this.GenerateRandomSet2D(setRadius:  this.GenerateRadius, countMin:  this.GenerateCountMin, countMax:  this.GenerateCountMax, coeffX:  1f, coeffY:  1f);
                this._points = val_3;
                Dest.Math.Box2 val_4 = Dest.Math.Box2.CreateFromPoints(points:  val_3);
                val_8 = this.ToggleToGenerate;
                mem[1152921519526111032] = val_5;
                this._box = val_6;
            }
            
            this._previous = val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_ContCreateBox2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
