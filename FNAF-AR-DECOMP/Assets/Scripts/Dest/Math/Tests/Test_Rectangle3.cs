using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_Rectangle3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P2;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P3;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_6;
            float val_7;
            float val_8;
            float val_9;
            UnityEngine.Vector3 val_1 = this.P0.position;
            UnityEngine.Vector3 val_2 = this.P1.position;
            UnityEngine.Vector3 val_3 = this.P2.position;
            UnityEngine.Vector3 val_4 = this.P3.position;
            Dest.Math.Rectangle3 val_5 = Dest.Math.Rectangle3.CreateFromCCWPoints(p0:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, p1:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, p2:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.z, z = val_4.x}, p3:  new UnityEngine.Vector3() {x = val_4.z});
            this.FiguresColor();
            this.DrawRectangle(rectangle: ref  new Dest.Math.Rectangle3() {Center = new UnityEngine.Vector3() {x = val_9, y = val_9, z = val_9}, Axis0 = new UnityEngine.Vector3() {x = val_9, y = val_8, z = val_8}, Axis1 = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_7}, Normal = new UnityEngine.Vector3() {x = val_7, y = val_7, z = val_7}, Extents = new UnityEngine.Vector2() {x = val_6, y = val_6}});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_Rectangle3()
        {
        
        }
    
    }

}
