using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_OverlappedStep : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _timer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Readme;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Time;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform[] AnimatedObjects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Left;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Middle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Right;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Overlap;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Dest.Math.Tests.Test_OverlappedStep.InOutTypes LeftType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Dest.Math.Tests.Test_OverlappedStep.InOutTypes RightType;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this._timer = 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float EvalInOut(float value, Dest.Math.Tests.Test_OverlappedStep.InOutTypes type)
        {
            if((type - 1) > 3)
            {
                    return (float)value;
            }
            
            var val_2 = 52957180 + ((type - 1)) << 2;
            val_2 = val_2 + 52957180;
            goto (52957180 + ((type - 1)) << 2 + 52957180);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            var val_12;
            float val_13;
            float val_14;
            var val_15;
            UnityEngine.Transform[] val_16;
            var val_17;
            float val_14 = this._timer;
            val_12 = 0;
            val_13 = this.Time * 0.5f;
            if(val_14 >= 0)
            {
                goto label_1;
            }
            
            goto label_2;
            label_13:
            UnityEngine.Vector3 val_5 = this.AnimatedObjects[0].position;
            val_14 = val_5.y;
            val_13 = UnityEngine.Mathf.Lerp(a:  this.Left, b:  this.Middle, t:  this.EvalInOut(value:  Dest.Math.Mathfex.EvalOverlappedStep(x:  val_14 / val_13, overlap:  this.Overlap, objectIndex:  0, objectCount:  this.AnimatedObjects.Length), type:  this.LeftType));
            this.AnimatedObjects[0].position = new UnityEngine.Vector3() {x = val_13, y = val_14, z = val_5.z};
            val_15 = 1;
            label_2:
            val_16 = this.AnimatedObjects;
            if(val_15 < this.AnimatedObjects.Length)
            {
                goto label_13;
            }
            
            goto label_14;
            label_1:
            val_14 = val_14 - val_13;
            goto label_15;
            label_26:
            UnityEngine.Vector3 val_10 = this.AnimatedObjects[0].position;
            val_14 = val_10.y;
            val_13 = UnityEngine.Mathf.Lerp(a:  this.Middle, b:  this.Right, t:  this.EvalInOut(value:  Dest.Math.Mathfex.EvalOverlappedStep(x:  val_14 / val_13, overlap:  this.Overlap, objectIndex:  0, objectCount:  this.AnimatedObjects.Length), type:  this.RightType));
            this.AnimatedObjects[0].position = new UnityEngine.Vector3() {x = val_13, y = val_14, z = val_10.z};
            val_17 = 1;
            label_15:
            val_16 = this.AnimatedObjects;
            if(val_17 < this.AnimatedObjects.Length)
            {
                goto label_26;
            }
            
            label_14:
            float val_11 = UnityEngine.Time.deltaTime;
            val_11 = this._timer + val_11;
            this._timer = val_11;
            if(val_11 <= this.Time)
            {
                    return;
            }
            
            val_11 = val_11 - this.Time;
            this._timer = val_11;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_OverlappedStep()
        {
            this.LeftType = 3;
            this.Readme = "Press Play To Launch";
        }
    
    }

}
