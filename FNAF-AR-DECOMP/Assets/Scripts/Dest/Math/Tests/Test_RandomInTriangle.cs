using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_RandomInTriangle : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3[] _points;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _previous;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ToggleToGenerate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Count;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V2;
        
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
            var val_6;
            UnityEngine.Transform val_7;
            val_6 = null;
            val_6 = null;
            this._points = new UnityEngine.Vector3[0];
            UnityEngine.Vector3 val_2 = this.V0.position;
            UnityEngine.Vector3 val_3 = this.V1.position;
            val_7 = this.V2;
            UnityEngine.Vector3 val_4 = val_7.position;
            if(this.Count < 1)
            {
                    return;
            }
            
            do
            {
                UnityEngine.Vector3 val_5 = Dest.Math.Rand.Instance.InTriangle(v0: ref  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, v1: ref  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, v2: ref  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
                var val_6 = this._points + (0 * 12);
                mem2[0] = val_5.x;
                mem2[0] = val_5.y;
                mem2[0] = val_5.z;
                val_7 = 0 + 1;
            }
            while(val_7 < this.Count);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            if(this._points != null)
            {
                    this.DrawPoints(points:  this._points, size:  0.11f);
            }
            
            UnityEngine.Vector3 val_1 = this.V0.position;
            UnityEngine.Vector3 val_2 = this.V1.position;
            this.DrawSegment(p0:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, p1:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Vector3 val_3 = this.V1.position;
            UnityEngine.Vector3 val_4 = this.V2.position;
            this.DrawSegment(p0:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, p1:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            UnityEngine.Vector3 val_5 = this.V2.position;
            UnityEngine.Vector3 val_6 = this.V0.position;
            this.DrawSegment(p0:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, p1:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_RandomInTriangle()
        {
        
        }
    
    }

}
