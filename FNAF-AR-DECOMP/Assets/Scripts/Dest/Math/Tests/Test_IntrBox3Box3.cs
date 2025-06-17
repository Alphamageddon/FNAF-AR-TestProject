using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrBox3Box3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box1;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_2;
            float val_3;
            float val_4;
            float val_5;
            float val_7;
            float val_8;
            float val_9;
            float val_10;
            Dest.Math.Box3 val_1 = 48315.CreateBox3(box:  this.Box0);
            Dest.Math.Box3 val_6 = 48315.CreateBox3(box:  this.Box1);
            bool val_11 = Dest.Math.Intersection.TestBox3Box3(box0: ref  new Dest.Math.Box3() {Center = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, Axis0 = new UnityEngine.Vector3() {x = val_5, y = val_3, z = val_3}, Axis1 = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_4}, Axis2 = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, Extents = new UnityEngine.Vector3() {x = val_2, y = val_2, z = val_2}}, box1: ref  new Dest.Math.Box3() {Center = new UnityEngine.Vector3() {x = val_10, y = val_10, z = val_10}, Axis0 = new UnityEngine.Vector3() {x = val_10, y = val_8, z = val_8}, Axis1 = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_9}, Axis2 = new UnityEngine.Vector3() {x = val_9, y = val_9, z = val_9}, Extents = new UnityEngine.Vector3() {x = val_7, y = val_7, z = val_7}});
            bool val_12 = val_11;
            val_11.FiguresColor();
            val_11.DrawBox(box: ref  new Dest.Math.Box3() {Center = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, Axis0 = new UnityEngine.Vector3() {x = val_5, y = val_3, z = val_3}, Axis1 = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_4}, Axis2 = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, Extents = new UnityEngine.Vector3() {x = val_2, y = val_2, z = val_2}});
            val_11.DrawBox(box: ref  new Dest.Math.Box3() {Center = new UnityEngine.Vector3() {x = val_10, y = val_10, z = val_10}, Axis0 = new UnityEngine.Vector3() {x = val_10, y = val_8, z = val_8}, Axis1 = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_9}, Axis2 = new UnityEngine.Vector3() {x = val_9, y = val_9, z = val_9}, Extents = new UnityEngine.Vector3() {x = val_7, y = val_7, z = val_7}});
            val_12.LogInfo(value:  val_12);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrBox3Box3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
