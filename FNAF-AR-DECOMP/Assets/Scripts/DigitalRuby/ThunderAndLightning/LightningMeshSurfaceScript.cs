using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LightningMeshSurfaceScript : LightningBoltPrefabScriptBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.MeshFilter MeshFilter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Collider MeshCollider;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DigitalRuby.ThunderAndLightning.RangeOfFloats MeshOffsetRange;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DigitalRuby.ThunderAndLightning.RangeOfIntegers PathLengthCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DigitalRuby.ThunderAndLightning.RangeOfFloats MinimumPathDistanceRange;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float MaximumPathDistance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float maximumPathDistanceSquared;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Spline;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float DistancePerSegmentHint;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<UnityEngine.Vector3> sourcePoints;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Mesh previousMesh;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DigitalRuby.ThunderAndLightning.MeshHelper meshHelper;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CheckMesh()
        {
            DigitalRuby.ThunderAndLightning.MeshHelper val_8 = 0;
            if(this.MeshFilter != 0)
            {
                    val_8 = 0;
                if(this.MeshFilter.sharedMesh != 0)
            {
                    if(this.MeshFilter.sharedMesh == this.previousMesh)
            {
                    return;
            }
            
                UnityEngine.Mesh val_6 = this.MeshFilter.sharedMesh;
                this.previousMesh = val_6;
                DigitalRuby.ThunderAndLightning.MeshHelper val_7 = null;
                val_8 = val_7;
                val_7 = new DigitalRuby.ThunderAndLightning.MeshHelper(mesh:  val_6);
            }
            
            }
            
            this.meshHelper = val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override DigitalRuby.ThunderAndLightning.LightningBoltParameters OnCreateParameters()
        {
            var val_2 = null;
            val_1.Generator = DigitalRuby.ThunderAndLightning.LightningGeneratorPath.PathGeneratorInstance;
            return (DigitalRuby.ThunderAndLightning.LightningBoltParameters)30432.OnCreateParameters();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void PopulateSourcePoints(System.Collections.Generic.List<UnityEngine.Vector3> points)
        {
            if(this.meshHelper == null)
            {
                    return;
            }
            
            this.CreateRandomLightningPath(points:  points);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CreateRandomLightningPath(System.Collections.Generic.List<UnityEngine.Vector3> points)
        {
            float val_24;
            float val_25;
            float val_26;
            float val_27;
            DigitalRuby.ThunderAndLightning.MeshHelper val_28;
            int val_29;
            int val_1 = 0;
            if(this.meshHelper == null)
            {
                    return;
            }
            
            float val_23 = this.MaximumPathDistance;
            val_23 = val_23 * val_23;
            this.maximumPathDistanceSquared = val_23;
            this.meshHelper.GenerateRandomPoint(hit: ref  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, triangleIndex: out  val_1);
            float val_2 = UnityEngine.Random.Range(min:  this.MeshOffsetRange, max:  null);
            0.targetValue = val_2;
            val_24 = V1.16B;
            val_25 = 0.targetValue;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2, y = val_24, z = V2.16B}, d:  val_25);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2, y = V1.16B, z = V2.16B}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            val_26 = UnityEngine.Random.Range(min:  this.MinimumPathDistanceRange, max:  val_5.y);
            UnityEngine.Vector3 val_8 = this.MeshFilter.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            val_27 = val_8.y;
            this.sourcePoints.Add(item:  new UnityEngine.Vector3() {x = val_8.x, y = val_27, z = val_8.z});
            val_28 = UnityEngine.Random.Range(min:  0, max:  1);
            int val_24 = UnityEngine.Random.Range(min:  this.PathLengthCount, max:  1);
            if(val_24 == 0)
            {
                    return;
            }
            
            var val_12 = (val_28 != 1) ? (-3) : 3;
            label_22:
            val_25 = val_5.x;
            val_26 = val_5.z;
            label_20:
            label_16:
            val_29 = val_1 + val_12;
            if((val_29 & 2147483648) != 0)
            {
                goto label_8;
            }
            
            val_28 = this.meshHelper.Triangles;
            if(val_29 >= val_13.Length)
            {
                goto label_11;
            }
            
            val_28 = this.meshHelper;
            val_28.GetRaycastFromTriangleIndex(triangleIndex:  val_29, hit: ref  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}});
            float val_14 = UnityEngine.Random.Range(min:  this.MeshOffsetRange, max:  val_27);
            0.targetValue = val_14;
            val_27 = val_27;
            val_24 = 0.targetValue;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14, y = val_27, z = val_8.z}, d:  val_24);
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14, y = val_27, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
            val_25 = val_17.x;
            val_26 = val_17.z;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, b:  new UnityEngine.Vector3() {x = val_25, y = val_5.y, z = val_26});
            if(val_18.x > this.maximumPathDistanceSquared)
            {
                    return;
            }
            
            if(val_18.x < (val_26 * val_26))
            {
                goto label_16;
            }
            
            val_28 = this.sourcePoints;
            UnityEngine.Vector3 val_20 = this.MeshFilter.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = val_25, y = val_17.y, z = val_26});
            val_27 = val_20.y;
            val_28.Add(item:  new UnityEngine.Vector3() {x = val_20.x, y = val_27, z = val_20.z});
            val_24 = val_24 - 1;
            float val_21 = UnityEngine.Random.Range(min:  this.MinimumPathDistanceRange, max:  val_27);
            val_21 = val_21 * val_21;
            if(val_24 != 0)
            {
                goto label_20;
            }
            
            return;
            label_11:
            val_29 = val_29;
            label_8:
            var val_22 = val_29 - val_12;
            val_24 = val_24 - 1;
            if(val_24 != 0)
            {
                goto label_22;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Start()
        {
            this.Start();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Update()
        {
            this.CheckMesh();
            this.Update();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void CreateLightningBolt(DigitalRuby.ThunderAndLightning.LightningBoltParameters parameters)
        {
            System.Collections.Generic.List<UnityEngine.Vector3> val_7;
            System.Collections.Generic.List<UnityEngine.Vector3> val_8;
            int val_9;
            if(this.meshHelper == null)
            {
                    return;
            }
            
            int val_1 = UnityEngine.Mathf.Clamp(value:  69738496, min:  1, max:  15);
            parameters.Generations = val_1;
            mem[1152921528891829904] = val_1;
            this.sourcePoints.Clear();
            val_7 = this.sourcePoints;
            if(val_7.Count < 2)
            {
                    return;
            }
            
            parameters.<Points>k__BackingField.Clear();
            if(this.Spline != false)
            {
                    if(this.sourcePoints.Count >= 4)
            {
                goto label_12;
            }
            
            }
            
            val_8 = parameters.<Points>k__BackingField;
            val_8.AddRange(collection:  this.sourcePoints);
            val_9 = 1;
            goto label_14;
            label_12:
            DigitalRuby.ThunderAndLightning.LightningSplineScript.PopulateSpline(splinePoints:  parameters.<Points>k__BackingField, sourcePoints:  this.sourcePoints, generations:  typeof(DigitalRuby.ThunderAndLightning.LightningMeshSurfaceScript).__il2cppRuntimeField_1E0>>0&0xFFFFFFFF, distancePerSegmentHit:  this.DistancePerSegmentHint, camera:  0);
            val_8 = parameters.<Points>k__BackingField.Count;
            val_9 = (val_8 - 1) / this.sourcePoints.Count;
            label_14:
            parameters.SmoothingFactor = val_9;
            this.CreateLightningBolt(p:  parameters);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LightningMeshSurfaceScript()
        {
            this.MeshOffsetRange = new DigitalRuby.ThunderAndLightning.RangeOfFloats();
            this.PathLengthCount = new DigitalRuby.ThunderAndLightning.RangeOfIntegers();
            this.MinimumPathDistanceRange = new DigitalRuby.ThunderAndLightning.RangeOfFloats();
            this.MaximumPathDistance = 2f;
            this.sourcePoints = new System.Collections.Generic.List<UnityEngine.Vector3>();
        }
    
    }

}
