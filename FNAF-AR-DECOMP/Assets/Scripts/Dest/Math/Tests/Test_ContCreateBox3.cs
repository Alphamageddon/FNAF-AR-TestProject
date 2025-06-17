using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_ContCreateBox3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Dest.Math.Box3 _box;
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
            this.DrawBox(box: ref  new Dest.Math.Box3() {Center = new UnityEngine.Vector3() {x = this._box, y = this._box, z = this._box}, Axis0 = new UnityEngine.Vector3() {x = this._box, y = this._box, z = this._box}, Axis1 = new UnityEngine.Vector3() {x = this._box, y = this._box, z = this._box}, Axis2 = new UnityEngine.Vector3() {x = this._box, y = this._box, z = this._box}, Extents = new UnityEngine.Vector3() {x = this._box, y = this._box, z = this._box}});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            var val_5;
            var val_6;
            var val_7;
            Dest.Math.Box3 val_8;
            bool val_10 = this.ToggleToGenerate;
            if(((val_10 == true) ? 1 : 0) != ((this._previous == true) ? 1 : 0))
            {
                    UnityEngine.Vector3[] val_3 = this.GenerateRandomSet3D(setRadius:  this.GenerateRadius, countMin:  this.GenerateCountMin, countMax:  this.GenerateCountMax, coeffX:  1f, coeffY:  1f, coeffZ:  1f);
                this._points = val_3;
                Dest.Math.Box3 val_4 = Dest.Math.Box3.CreateFromPoints(points:  val_3);
                val_10 = this.ToggleToGenerate;
                mem[1152921519530343700] = val_5;
                mem[1152921519530343688] = val_6;
                mem[1152921519530343672] = val_7;
                this._box = val_8;
            }
            
            this._previous = val_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_ContCreateBox3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
