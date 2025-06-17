using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_CatmullRom3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _prevCreate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Create;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Dest.Math.Tests.Test_CatmullRom3.CreateType Type;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            this._prevCreate = this.Create;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            if(((this._prevCreate == true) ? 1 : 0) == ((this.Create == true) ? 1 : 0))
            {
                goto label_4;
            }
            
            if(this.Type == 1)
            {
                goto label_1;
            }
            
            if(this.Type != 0)
            {
                goto label_2;
            }
            
            Dest.Math.CatmullRomSpline3 val_3 = Dest.Math.CatmullRomSpline3.Create();
            goto label_4;
            label_1:
            this.CreateChildren();
            goto label_4;
            label_2:
            this.CreateSpiral();
            label_4:
            this._prevCreate = this.Create;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateEmpty()
        {
            Dest.Math.CatmullRomSpline3 val_1 = Dest.Math.CatmullRomSpline3.Create();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateChildren()
        {
            UnityEngine.Transform val_1 = this.transform;
            int val_2 = val_1.childCount;
            UnityEngine.Vector3[] val_3 = new UnityEngine.Vector3[0];
            if(val_2 >= 1)
            {
                    var val_9 = 0;
                do
            {
                UnityEngine.Vector3 val_5 = val_1.GetChild(index:  0).position;
                UnityEngine.Vector2 val_6 = Dest.Math.Vector3ex.ToVector2XY(vector:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
                UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
                val_9 = val_9 + 1;
                mem2[0] = val_7.x;
                mem2[0] = val_7.y;
                mem2[0] = val_7.z;
            }
            while(val_2 != val_9);
            
            }
            
            Dest.Math.CatmullRomSpline3 val_8 = Dest.Math.CatmullRomSpline3.Create(points:  val_3, type:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateSpiral()
        {
            Dest.Math.CatmullRomSpline3 val_1 = Dest.Math.CatmullRomSpline3.Create();
            var val_7 = 0;
            do
            {
                float val_2 = 0f * 0.1f;
                float val_3 = val_2 * val_2;
                float val_4 = val_2 * 0.5f;
                float val_5 = val_2 * val_2;
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(d:  0.5f, a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_7 = val_7 + 1;
            }
            while(val_7 != 1000);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_CatmullRom3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
