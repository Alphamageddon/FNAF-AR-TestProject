using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrAAB3AAB3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box0_Point0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box0_Point1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box1_Point0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box1_Point1;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_2;
            float val_3;
            float val_5;
            float val_6;
            Dest.Math.AAB3 val_1 = 48311.CreateAAB3(point0:  this.Box0_Point0, point1:  this.Box0_Point1);
            Dest.Math.AAB3 val_4 = 48311.CreateAAB3(point0:  this.Box1_Point0, point1:  this.Box1_Point1);
            bool val_7 = Dest.Math.Intersection.FindAAB3AAB3(box0: ref  new Dest.Math.AAB3() {Min = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Max = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}}, box1: ref  new Dest.Math.AAB3() {Min = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, Max = new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_5}}, intersection: out  new Dest.Math.AAB3() {Min = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Max = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}});
            val_7.FiguresColor();
            val_7.DrawAAB(box: ref  new Dest.Math.AAB3() {Min = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Max = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}});
            val_7.DrawAAB(box: ref  new Dest.Math.AAB3() {Min = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, Max = new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_5}});
            if(val_7 != false)
            {
                    val_7.ResultsColor();
                val_7.DrawAAB(box: ref  new Dest.Math.AAB3() {Min = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Max = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}});
            }
            
            val_3 = val_7;
            val_3.LogInfo(value:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrAAB3AAB3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
