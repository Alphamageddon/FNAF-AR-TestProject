using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LightningSplineScript : LightningBoltPathScriptBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int MaxSplineGenerations = 15;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float DistancePerSegmentHint;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<UnityEngine.Vector3> prevSourcePoints;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<UnityEngine.Vector3> sourcePoints;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.Vector3> savedSplinePoints;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int previousGenerations;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float previousDistancePerSegment;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool SourceChanged()
        {
            System.Collections.Generic.List<UnityEngine.Vector3> val_7;
            var val_8;
            val_7 = this.prevSourcePoints;
            if(this.sourcePoints.Count != val_7.Count)
            {
                goto label_3;
            }
            
            var val_7 = 0;
            label_10:
            val_7 = this.sourcePoints;
            if(val_7 >= val_7.Count)
            {
                goto label_5;
            }
            
            UnityEngine.Vector3 val_4 = this.sourcePoints.Item[0];
            val_7 = this.prevSourcePoints;
            UnityEngine.Vector3 val_5 = val_7.Item[0];
            val_7 = val_7 + 1;
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, rhs:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z})) == false)
            {
                goto label_10;
            }
            
            label_3:
            val_8 = 1;
            return (bool)val_8;
            label_5:
            val_8 = 0;
            return (bool)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Start()
        {
            this.Start();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Update()
        {
            this.Update();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void CreateLightningBolt(DigitalRuby.ThunderAndLightning.LightningBoltParameters parameters)
        {
            object val_3;
            System.Collections.Generic.List<UnityEngine.Vector3> val_22;
            object val_23;
            var val_24;
            var val_25;
            var val_26;
            int val_27;
            float val_28;
            float val_29;
            val_23 = parameters;
            if(true == 0)
            {
                    return;
            }
            
            this.sourcePoints.Clear();
            List.Enumerator<T> val_1 = this.sourcePoints.GetEnumerator();
            val_24 = 1152921519696153536;
            label_11:
            if(((-1484084656) & 1) == 0)
            {
                goto label_4;
            }
            
            GameUI.EmailUIDataHandler val_4 = val_3.emailUIDataHandler;
            if(val_4 == 0)
            {
                goto label_11;
            }
            
            UnityEngine.Vector3 val_7 = val_4.transform.position;
            this.sourcePoints.Add(item:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            goto label_11;
            label_4:
            val_25 = 0;
            val_26 = 98;
            long val_8 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921528892566096});
            val_22 = this.sourcePoints;
            if(val_22.Count <= 3)
            {
                goto label_22;
            }
            
            int val_10 = UnityEngine.Mathf.Clamp(value:  val_22, min:  1, max:  15);
            if(val_23 == null)
            {
                goto label_25;
            }
            
            val_23.Generations = val_10;
            mem[1152921528892578624] = val_10;
            goto label_26;
            label_22:
            val_3 = 4;
            val_23 = "To create spline lightning, you need a lightning path with at least " + val_3 + " points.";
            UnityEngine.Debug.LogError(message:  val_23);
            return;
            label_25:
            0.Generations = val_10;
            mem[1152921528892578624] = val_10;
            label_26:
            val_23.Points.Clear();
            val_28 = this.previousDistancePerSegment;
            val_29 = this.DistancePerSegmentHint;
            if(this.previousDistancePerSegment != this.DistancePerSegmentHint)
            {
                goto label_32;
            }
            
            if(this.SourceChanged() == false)
            {
                goto label_33;
            }
            
            goto label_35;
            label_32:
            val_27 = this.previousGenerations;
            label_35:
            this.previousGenerations = val_27;
            mem2[0] = val_29;
            DigitalRuby.ThunderAndLightning.LightningSplineScript.PopulateSpline(splinePoints:  val_23.Points, sourcePoints:  this.sourcePoints, generations:  0, distancePerSegmentHit:  val_29, camera:  0);
            this.prevSourcePoints.Clear();
            val_24 = 1152921518938346256;
            this.prevSourcePoints.AddRange(collection:  this.sourcePoints);
            this.savedSplinePoints.Clear();
            label_49:
            this.savedSplinePoints.AddRange(collection:  val_23.Points);
            val_22 = val_23.Points.Count;
            int val_19 = val_22 - 1;
            val_19 = val_19 / this.sourcePoints.Count;
            parameters.SmoothingFactor = val_19;
            this.CreateLightningBolt(p:  val_23);
            return;
            label_33:
            if(val_23.Points != null)
            {
                goto label_49;
            }
            
            goto label_49;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override DigitalRuby.ThunderAndLightning.LightningBoltParameters OnCreateParameters()
        {
            var val_2 = null;
            val_1.Generator = DigitalRuby.ThunderAndLightning.LightningGeneratorPath.PathGeneratorInstance;
            return (DigitalRuby.ThunderAndLightning.LightningBoltParameters)DigitalRuby.ThunderAndLightning.LightningBoltParameters.GetOrCreateParameters();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Trigger(System.Collections.Generic.List<UnityEngine.Vector3> points, bool spline)
        {
            int val_13;
            if(points.Count < 2)
            {
                    return;
            }
            
            mem[1152921528892925504] = UnityEngine.Mathf.Clamp(value:  "The index is equal to or greater than the length of the array, or the number of elements in the dictionary is greater than the available space from index to the end of the destination array.", min:  1, max:  15);
            DigitalRuby.ThunderAndLightning.LightningBoltParameters val_3 = this.CreateParameters();
            val_3.Points.Clear();
            if(spline != false)
            {
                    if(points.Count >= 4)
            {
                goto label_9;
            }
            
            }
            
            val_3.Points.AddRange(collection:  points);
            val_13 = 1;
            goto label_13;
            label_9:
            if(val_3 != null)
            {
                    DigitalRuby.ThunderAndLightning.LightningSplineScript.PopulateSpline(splinePoints:  val_3.Points, sourcePoints:  points, generations:  15, distancePerSegmentHit:  this.DistancePerSegmentHint, camera:  0);
            }
            else
            {
                    DigitalRuby.ThunderAndLightning.LightningSplineScript.PopulateSpline(splinePoints:  0.Points, sourcePoints:  points, generations:  15, distancePerSegmentHit:  this.DistancePerSegmentHint, camera:  0);
            }
            
            val_13 = (val_3.Points.Count - 1) / points.Count;
            label_13:
            val_3.SmoothingFactor = val_13;
            this.CreateLightningBolt(p:  val_3);
            this.CreateLightningBoltsNow();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void PopulateSpline(System.Collections.Generic.List<UnityEngine.Vector3> splinePoints, System.Collections.Generic.List<UnityEngine.Vector3> sourcePoints, int generations, float distancePerSegmentHit, UnityEngine.Camera camera)
        {
            float val_9;
            splinePoints.Clear();
            if(camera != 0)
            {
                    val_9 = camera.orthographic;
            }
            else
            {
                    val_9 = 0f;
            }
            
            DigitalRuby.ThunderAndLightning.PathGenerator.splineEpsilon = val_9;
            if(distancePerSegmentHit > 0f)
            {
                    float val_8 = (float)generations;
                val_8 = distancePerSegmentHit / val_8;
                bool val_3 = DigitalRuby.ThunderAndLightning.PathGenerator.CreateSplineWithSegmentDistance(path:  splinePoints, points:  sourcePoints, distancePerSegment:  val_8, closePath:  false);
                return;
            }
            
            bool val_7 = DigitalRuby.ThunderAndLightning.PathGenerator.CreateSpline(path:  splinePoints, points:  sourcePoints, numberOfSegments:  (generations * generations) * sourcePoints.Count, closePath:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LightningSplineScript()
        {
            this.DistancePerSegmentHint = 0.1f;
            UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[1];
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            val_1[0] = val_2;
            val_1[0] = val_2.y;
            val_1[1] = val_2.z;
            this.prevSourcePoints = new System.Collections.Generic.List<UnityEngine.Vector3>(collection:  val_1);
            this.sourcePoints = new System.Collections.Generic.List<UnityEngine.Vector3>();
            this.savedSplinePoints = new System.Collections.Generic.List<UnityEngine.Vector3>();
            this.previousGenerations = 0;
            this.previousDistancePerSegment = -1.007812f;
        }
    
    }

}
