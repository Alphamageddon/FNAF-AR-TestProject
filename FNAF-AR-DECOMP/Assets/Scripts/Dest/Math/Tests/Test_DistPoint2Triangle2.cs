using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_DistPoint2Triangle2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Point;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V2;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_4;
            float val_5;
            float val_9;
            UnityEngine.Vector3 val_1 = this.Point.position;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            Dest.Math.Triangle2 val_3 = 0.CreateTriangle2(v0:  this.V0, v1:  this.V1, v2:  this.V2);
            val_2.x.FiguresColor();
            val_2.x.DrawTriangle(triangle: ref  new Dest.Math.Triangle2() {V0 = new UnityEngine.Vector2() {x = val_5, y = val_5}, V1 = new UnityEngine.Vector2() {x = val_5, y = val_5}, V2 = new UnityEngine.Vector2() {x = val_4, y = val_4}});
            val_2.x.ResultsColor();
            val_2.x.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            if(0f >= _TYPE_MAX_)
            {
                    val_9 = Dest.Math.Distance.SqrPoint2Triangle2(point: ref  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, triangle: ref  new Dest.Math.Triangle2() {V0 = new UnityEngine.Vector2() {x = val_5, y = val_5}, V1 = new UnityEngine.Vector2() {x = val_5, y = val_5}, V2 = new UnityEngine.Vector2() {x = val_4, y = val_4}}, closestPoint: out  new UnityEngine.Vector2() {x = 0f, y = 0f});
            }
            
            string val_8 = Dest.Math.Distance.Point2Triangle2(point: ref  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, triangle: ref  new Dest.Math.Triangle2() {V0 = new UnityEngine.Vector2() {x = val_5, y = val_5}, V1 = new UnityEngine.Vector2() {x = val_5, y = val_5}, V2 = new UnityEngine.Vector2() {x = val_4, y = val_4}}, closestPoint: out  new UnityEngine.Vector2() {x = 0f, y = 0f})(Dest.Math.Distance.Point2Triangle2(point: ref  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, triangle: ref  new Dest.Math.Triangle2() {V0 = new UnityEngine.Vector2() {x = val_5, y = val_5}, V1 = new UnityEngine.Vector2() {x = val_5, y = val_5}, V2 = new UnityEngine.Vector2() {x = val_4, y = val_4}}, closestPoint: out  new UnityEngine.Vector2() {x = 0f, y = 0f})) + " " + val_9;
            val_8.LogInfo(value:  val_8);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_DistPoint2Triangle2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
