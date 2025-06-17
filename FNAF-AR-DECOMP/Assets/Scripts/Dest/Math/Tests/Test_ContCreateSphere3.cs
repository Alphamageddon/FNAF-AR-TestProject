using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_ContCreateSphere3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Dest.Math.Sphere3 _sphere0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Dest.Math.Sphere3 _sphere1;
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
            UnityEngine.Color val_1 = UnityEngine.Color.red;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
            UnityEngine.Gizmos.DrawWireSphere(center:  new UnityEngine.Vector3() {x = this._sphere0, y = val_1.g, z = val_1.b}, radius:  val_1.a);
            UnityEngine.Color val_2 = UnityEngine.Color.blue;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
            UnityEngine.Gizmos.DrawWireSphere(center:  new UnityEngine.Vector3() {x = this._sphere1, y = val_2.g, z = val_2.b}, radius:  val_2.a);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            bool val_6 = this.ToggleToGenerate;
            if(((val_6 == true) ? 1 : 0) != ((this._previous == true) ? 1 : 0))
            {
                    UnityEngine.Vector3[] val_3 = this.GenerateRandomSet3D(setRadius:  this.GenerateRadius, countMin:  this.GenerateCountMin, countMax:  this.GenerateCountMax, coeffX:  1f, coeffY:  1f, coeffZ:  1f);
                this._points = val_3;
                Dest.Math.Sphere3 val_4 = Dest.Math.Sphere3.CreateFromPointsAAB(points:  val_3);
                this._sphere0 = this.GenerateRadius;
                mem[1152921519531575532] = 1f;
                mem[1152921519531575536] = 1f;
                mem[1152921519531575540] = 1f;
                Dest.Math.Sphere3 val_5 = Dest.Math.Sphere3.CreateFromPointsAverage(points:  this._points);
                val_6 = this.ToggleToGenerate;
                this._sphere1 = this.GenerateRadius;
                mem[1152921519531575548] = 1f;
                mem[1152921519531575552] = 1f;
                mem[1152921519531575556] = 1f;
            }
            
            this._previous = val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_ContCreateSphere3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
