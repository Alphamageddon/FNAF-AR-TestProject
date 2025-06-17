using UnityEngine;

namespace DigitalRuby.LightningBolt
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LightningBoltScript : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject StartObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 StartPosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject EndObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 EndPosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Generations;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Duration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float timer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ChaosFactor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ManualMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Rows;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Columns;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DigitalRuby.LightningBolt.LightningBoltAnimationMode AnimationMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Random RandomGenerator;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.LineRenderer lineRenderer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.Vector3, UnityEngine.Vector3>> segments;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int startIndex;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2 size;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2[] offsets;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int animationOffsetIndex;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int animationPingPongDirection;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool orthographic;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetPerpendicularVector(ref UnityEngine.Vector3 directionNormalized, out UnityEngine.Vector3 side)
        {
            float val_9;
            float val_10;
            float val_11;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_9 = directionNormalized.x;
            val_10 = directionNormalized.y;
            val_11 = directionNormalized.z;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_9, y = val_10, z = val_11}, rhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})) != false)
            {
                    UnityEngine.Vector3 val_3 = UnityEngine.Vector3.right;
            }
            else
            {
                    float val_8 = System.Math.Abs(directionNormalized.y);
                float val_9 = System.Math.Abs(directionNormalized.z);
                if((System.Math.Abs(directionNormalized.x) >= val_8) && (val_8 >= val_9))
            {
                    val_11 = 1f;
                val_9 = (-(directionNormalized.y + directionNormalized.z)) / directionNormalized.x;
                val_10 = val_11;
            }
            else
            {
                    if(val_8 < val_9)
            {
                    val_10 = 1f;
                val_11 = (-(directionNormalized.x + directionNormalized.y)) / directionNormalized.z;
                val_9 = val_10;
            }
            else
            {
                    val_11 = 1f;
                val_10 = (-(directionNormalized.x + directionNormalized.z)) / directionNormalized.y;
                val_9 = val_11;
            }
            
            }
            
            }
            
            side.x = val_9;
            side.y = val_10;
            side.z = val_11;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GenerateLightningBolt(UnityEngine.Vector3 start, UnityEngine.Vector3 end, int generation, int totalGenerations, float offsetAmount)
        {
            float val_8;
            System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.Vector3, UnityEngine.Vector3>> val_13;
            int val_14;
            float val_15;
            float val_16;
            float val_17;
            float val_18;
            float val_20;
            float val_21;
            float val_22;
            int val_23;
            val_14 = generation;
            val_15 = end.z;
            val_16 = end.y;
            val_17 = end.x;
            val_18 = start.z;
            if(val_14 > 8)
            {
                    return;
            }
            
            if(this.orthographic != false)
            {
                    val_15 = UnityEngine.Mathf.Min(a:  val_18, b:  val_15);
                val_18 = val_15;
            }
            
            val_13 = this.segments;
            val_20 = start.y;
            val_21 = val_18;
            val_13.Add(item:  new System.Collections.Generic.KeyValuePair<UnityEngine.Vector3, UnityEngine.Vector3>() {Value = new UnityEngine.Vector3() {x = 9.260733E-33f, y = 2.524356E-29f, z = 9.23325E-33f}});
            if(val_14 == 0)
            {
                    return;
            }
            
            val_22 = offsetAmount;
            if(val_22 <= 0f)
            {
                    val_21 = val_15;
                UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_17, y = val_16, z = val_21}, b:  new UnityEngine.Vector3() {x = start.x, y = start.y, z = val_18});
                val_20 = this.ChaosFactor;
                val_22 = val_2.x * val_20;
            }
            
            int val_12 = this.startIndex;
            do
            {
                val_23 = this.segments;
                int val_4 = val_23.Count;
                this.startIndex = val_4;
                if(val_12 < val_4)
            {
                    do
            {
                System.Collections.Generic.KeyValuePair<UnityEngine.Vector3, UnityEngine.Vector3> val_5 = this.segments.Item[val_12];
                val_18 = val_20;
                System.Collections.Generic.KeyValuePair<UnityEngine.Vector3, UnityEngine.Vector3> val_6 = this.segments.Item[val_12];
                val_17 = val_2.z;
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 0f, y = val_18, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_8, y = val_20, z = val_17});
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  0.5f);
                this.RandomVector(start: ref  new UnityEngine.Vector3() {x = 0f, y = val_18, z = val_2.z}, end: ref  new UnityEngine.Vector3() {x = val_8, y = val_20, z = val_17}, offsetAmount:  val_22, result: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_16 = val_11.z;
                this.segments.Add(item:  new System.Collections.Generic.KeyValuePair<UnityEngine.Vector3, UnityEngine.Vector3>() {Value = new UnityEngine.Vector3() {x = 9.260733E-33f, y = 2.524356E-29f, z = 9.23325E-33f}});
                this.segments.Add(item:  new System.Collections.Generic.KeyValuePair<UnityEngine.Vector3, UnityEngine.Vector3>() {Value = new UnityEngine.Vector3() {x = 9.260733E-33f, y = 2.524356E-29f, z = 9.23325E-33f}});
                val_23 = this.startIndex;
                val_12 = val_12 + 1;
            }
            while(val_12 < val_23);
            
            }
            
                float val_13 = val_22;
                val_14 = val_14 - 1;
                val_13 = val_13 * 0.5f;
                val_13 = val_23;
            }
            while(val_14 > 1);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RandomVector(ref UnityEngine.Vector3 start, ref UnityEngine.Vector3 end, float offsetAmount, out UnityEngine.Vector3 result)
        {
            System.Random val_7;
            float val_11;
            float val_12;
            float val_13;
            float val_14;
            val_7 = 1152921526253877456;
            if(this.orthographic != false)
            {
                    UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = end.x, y = end.y, z = end.z}, b:  new UnityEngine.Vector3() {x = start.x, y = start.y, z = start.z});
                float val_7 = (float)-val_1.y;
                val_11 = 0f;
                val_12 = 0f;
                val_13 = 0f;
                val_7 = val_7 * offsetAmount;
                val_7 = val_7 + val_7;
                val_14 = val_7 - offsetAmount;
            }
            else
            {
                    UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = end.x, y = end.y, z = end.z}, b:  new UnityEngine.Vector3() {x = start.x, y = start.y, z = start.z});
                val_2.x.GetPerpendicularVector(directionNormalized: ref  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, side: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_7 = this.RandomGenerator;
                float val_8 = (float)val_2.x;
                val_8 = val_8 + 0.1f;
                val_11 = (float)val_2.x * 360f;
                val_12 = val_2.x;
                val_13 = val_2.y;
                val_14 = val_8 * offsetAmount;
                UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.AngleAxis(angle:  val_11, axis:  new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_2.z});
                UnityEngine.Vector3 val_5 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            }
            
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  val_14);
            result.x = val_6.x;
            result.y = val_6.y;
            result.z = val_6.z;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SelectOffsetFromAnimationMode()
        {
            UnityEngine.Vector2[] val_5;
            int val_6;
            var val_7;
            UnityEngine.Vector2 val_8;
            UnityEngine.Vector2 val_9;
            if(this.AnimationMode == 3)
            {
                goto label_0;
            }
            
            if(this.AnimationMode == 2)
            {
                goto label_1;
            }
            
            if(this.AnimationMode == 0)
            {
                goto label_16;
            }
            
            val_5 = this.offsets;
            if(val_5 == null)
            {
                goto label_3;
            }
            
            label_29:
            val_6 = this.RandomGenerator;
            if((val_6 & 2147483648) == 0)
            {
                goto label_23;
            }
            
            goto label_16;
            label_0:
            val_6 = this.animationOffsetIndex;
            val_5 = this.animationPingPongDirection + val_6;
            this.animationOffsetIndex = val_5;
            if(val_5 >= this.offsets.Length)
            {
                goto label_8;
            }
            
            if((this.animationOffsetIndex & 2147483648) == 0)
            {
                goto label_13;
            }
            
            this.animationOffsetIndex = 4294967297;
            this.animationPingPongDirection = 1;
            if((val_6 & 2147483648) == 0)
            {
                goto label_23;
            }
            
            goto label_16;
            label_1:
            val_6 = this.animationOffsetIndex;
            val_5 = val_6 + 1;
            this.animationOffsetIndex = val_5;
            if(val_5 >= this.offsets.Length)
            {
                    this.animationOffsetIndex = 0;
            }
            
            label_13:
            if((val_6 & 2147483648) != 0)
            {
                goto label_16;
            }
            
            label_23:
            val_5 = this.offsets;
            if(val_6 >= this.offsets.Length)
            {
                goto label_16;
            }
            
            val_5 = this.offsets;
            val_7 = this.lineRenderer.material;
            val_8 = val_5[(long)val_6];
            val_9 = val_5[(long)val_6];
            if(val_7 != null)
            {
                goto label_27;
            }
            
            goto label_21;
            label_8:
            val_5 = this.offsets;
            int val_3 = this.offsets.Length;
            val_3 = val_3 - 2;
            this.animationOffsetIndex = val_3;
            this.animationPingPongDirection = 0;
            if((val_6 & 2147483648) == 0)
            {
                goto label_23;
            }
            
            label_16:
            val_7 = this.lineRenderer.material;
            val_8 = this.offsets[0];
            val_9 = this.offsets[0];
            if(val_7 != null)
            {
                goto label_27;
            }
            
            label_21:
            label_27:
            val_7.mainTextureOffset = new UnityEngine.Vector2() {x = val_8, y = val_9};
            return;
            label_3:
            if(this.RandomGenerator != null)
            {
                goto label_29;
            }
            
            goto label_29;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateLineRenderer()
        {
            float val_4;
            UnityEngine.LineRenderer val_9;
            float val_10;
            var val_11;
            System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.Vector3, UnityEngine.Vector3>> val_9 = this.segments;
            int val_8 = this.startIndex;
            val_9 = this.lineRenderer;
            val_8 = val_9.Count - val_8;
            val_9 = val_8 + 1;
            val_9.positionCount = val_9;
            if(val_9 < 1)
            {
                    return;
            }
            
            val_9 = this.segments;
            System.Collections.Generic.KeyValuePair<UnityEngine.Vector3, UnityEngine.Vector3> val_2 = val_9.Item[this.startIndex];
            val_10 = val_4;
            this.lineRenderer.SetPosition(index:  0, position:  new UnityEngine.Vector3() {x = val_10, y = V1.16B, z = V2.16B});
            val_11 = 0;
            goto label_6;
            label_10:
            val_9 = this.lineRenderer;
            System.Collections.Generic.KeyValuePair<UnityEngine.Vector3, UnityEngine.Vector3> val_5 = this.segments.Item[this.startIndex];
            val_10 = val_4;
            val_9.SetPosition(index:  1, position:  new UnityEngine.Vector3() {x = val_10, y = V1.16B, z = V2.16B});
            val_11 = 1;
            label_6:
            if((this.startIndex + val_11) < this.segments.Count)
            {
                goto label_10;
            }
            
            this.segments.Clear();
            this.SelectOffsetFromAnimationMode();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            bool val_6;
            if(UnityEngine.Camera.main == 0)
            {
                goto label_3;
            }
            
            val_6 = UnityEngine.Camera.main.orthographic;
            if(this != null)
            {
                goto label_7;
            }
            
            goto label_6;
            label_3:
            val_6 = false;
            if(this != null)
            {
                goto label_7;
            }
            
            label_6:
            label_7:
            this.orthographic = val_6;
            UnityEngine.LineRenderer val_5 = this.GetComponent<UnityEngine.LineRenderer>();
            this.lineRenderer = val_5;
            val_5.positionCount = 0;
            this.UpdateFromMaterialChange();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            bool val_6;
            if(UnityEngine.Camera.main == 0)
            {
                goto label_3;
            }
            
            val_6 = UnityEngine.Camera.main.orthographic;
            if(this != null)
            {
                goto label_7;
            }
            
            goto label_6;
            label_3:
            val_6 = false;
            if(this != null)
            {
                goto label_7;
            }
            
            label_6:
            label_7:
            this.orthographic = val_6;
            if(this.timer <= 0f)
            {
                    if(this.ManualMode != false)
            {
                    this.timer = this.Duration;
                this.lineRenderer.positionCount = 0;
            }
            else
            {
                    this.Trigger();
            }
            
            }
            
            float val_5 = UnityEngine.Time.deltaTime;
            val_5 = this.timer - val_5;
            this.timer = val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Trigger()
        {
            float val_10;
            float val_12;
            UnityEngine.Vector3 val_13;
            float val_14;
            float val_15;
            UnityEngine.Vector3 val_16;
            val_10 = this.timer;
            val_12 = this.Duration + (UnityEngine.Mathf.Min(a:  0f, b:  val_10));
            this.timer = val_12;
            if(this.StartObject == 0)
            {
                    val_13 = this.StartPosition;
            }
            else
            {
                    UnityEngine.Vector3 val_4 = this.StartObject.transform.position;
                val_16 = this.StartPosition;
                val_12 = val_4.x;
                val_10 = val_4.y;
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12, y = val_10, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_16, y = V11.16B, z = V10.16B});
                val_13 = val_5.x;
                val_14 = val_5.y;
                val_15 = val_5.z;
            }
            
            if(this.EndObject == 0)
            {
                
            }
            else
            {
                    UnityEngine.Vector3 val_8 = this.EndObject.transform.position;
                val_16 = val_8.y;
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_16, z = val_8.z}, b:  new UnityEngine.Vector3() {x = this.EndPosition, y = V14.16B, z = val_4.z});
                val_13 = val_13;
            }
            
            this.startIndex = 0;
            this.GenerateLightningBolt(start:  new UnityEngine.Vector3() {x = val_13, y = val_14, z = val_15}, end:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, generation:  this.Generations, totalGenerations:  0, offsetAmount:  0f);
            this.UpdateLineRenderer();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateFromMaterialChange()
        {
            UnityEngine.Vector2 val_7;
            int val_8;
            int val_9;
            float val_7 = (float)this.Columns;
            float val_8 = (float)this.Rows;
            val_7 = 1f / val_7;
            val_8 = 1f / val_8;
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  val_7, y:  val_8);
            this.size = val_1.x;
            mem[1152921526255321480] = val_1.y;
            val_7 = this.size;
            this.lineRenderer.material.mainTextureScale = new UnityEngine.Vector2() {x = val_7, y = V9.16B};
            int val_3 = this.Columns * this.Rows;
            val_8 = this.Rows;
            this.offsets = new UnityEngine.Vector2[0];
            if(val_8 < 1)
            {
                    return;
            }
            
            val_9 = this.Columns;
            var val_12 = 0;
            do
            {
                if(val_9 >= 1)
            {
                    var val_11 = 0;
                val_7 = 0f;
                do
            {
                float val_9 = 0f;
                val_9 = val_9 / (float)val_9;
                float val_10 = (float)val_8;
                val_10 = val_7 / val_10;
                UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_9, y:  val_10);
                this.offsets[(long)val_11 + (val_12 * val_9)] = val_5.x;
                this.offsets[(long)val_11 + (val_12 * val_9)] = val_5.y;
                val_8 = this.Rows;
                val_9 = this.Columns;
                val_11 = val_11 + 1;
            }
            while(val_11 < val_9);
            
            }
            
                val_12 = val_12 + 1;
            }
            while(val_12 < val_8);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LightningBoltScript()
        {
            this.Generations = 6;
            this.Duration = 7.346868E-41f;
            this.ChaosFactor = 0.15f;
            this.Rows = 1;
            this.Columns = 1;
            this.AnimationMode = 3;
            this.RandomGenerator = new System.Random();
            this.segments = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.Vector3, UnityEngine.Vector3>>();
            this.animationPingPongDirection = 1;
        }
    
    }

}
