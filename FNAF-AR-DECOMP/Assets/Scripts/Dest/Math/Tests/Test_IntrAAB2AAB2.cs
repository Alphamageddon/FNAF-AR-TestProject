using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrAAB2AAB2 : Test_Base
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
            Dest.Math.AAB2 val_1 = 48309.CreateAAB2(point0:  this.Box0_Point0, point1:  this.Box0_Point1);
            Dest.Math.AAB2 val_2 = val_1.Min.x.CreateAAB2(point0:  this.Box1_Point0, point1:  this.Box1_Point1);
            bool val_3 = Dest.Math.Intersection.FindAAB2AAB2(box0: ref  new Dest.Math.AAB2() {Min = new UnityEngine.Vector2() {x = ???, y = ???}, Max = new UnityEngine.Vector2() {x = ???, y = ???}}, box1: ref  new Dest.Math.AAB2() {Min = new UnityEngine.Vector2() {x = ???, y = ???}, Max = new UnityEngine.Vector2() {x = ???, y = ???}}, intersection: out  new Dest.Math.AAB2() {Min = new UnityEngine.Vector2() {x = 0f, y = 0f}, Max = new UnityEngine.Vector2() {x = 0f, y = 0f}});
            bool val_4 = val_3;
            UnityEngine.Color val_5 = UnityEngine.Color.gray;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
            0.DrawAAB(box: ref  new Dest.Math.AAB2() {Min = new UnityEngine.Vector2() {x = ???, y = ???}, Max = new UnityEngine.Vector2() {x = ???, y = ???}});
            0.DrawAAB(box: ref  new Dest.Math.AAB2() {Min = new UnityEngine.Vector2() {x = ???, y = ???}, Max = new UnityEngine.Vector2() {x = ???, y = ???}});
            if(val_3 != false)
            {
                    0.ResultsColor();
                0.DrawAAB(box: ref  new Dest.Math.AAB2() {Min = new UnityEngine.Vector2() {x = 0f, y = 0f}, Max = new UnityEngine.Vector2() {x = 0f, y = 0f}});
            }
            
            val_4.LogInfo(value:  val_4);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrAAB2AAB2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
