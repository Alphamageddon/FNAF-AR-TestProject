using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LightningBolt
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int MaximumLightCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int MaximumLightsPerBatch;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float <MinimumDelay>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <HasGlow>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DigitalRuby.ThunderAndLightning.CameraMode <CameraMode>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.DateTime startTimeOffset;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DigitalRuby.ThunderAndLightning.LightningBoltDependencies dependencies;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float elapsedTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float lifeTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float maxLifeTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool hasLight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float timeSinceLevelLoad;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<DigitalRuby.ThunderAndLightning.LightningBoltSegmentGroup> segmentGroups;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<DigitalRuby.ThunderAndLightning.LightningBoltSegmentGroup> segmentGroupsWithLight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<DigitalRuby.ThunderAndLightning.LightningBolt.LineRendererMesh> activeLineRenderers;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int lightCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly System.Collections.Generic.List<DigitalRuby.ThunderAndLightning.LightningBolt.LineRendererMesh> lineRendererCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly System.Collections.Generic.List<DigitalRuby.ThunderAndLightning.LightningBoltSegmentGroup> groupCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly System.Collections.Generic.List<UnityEngine.Light> lightCache;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float MinimumDelay { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasGlow { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsActive { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DigitalRuby.ThunderAndLightning.CameraMode CameraMode { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_MinimumDelay()
        {
            return (float)this.<MinimumDelay>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_MinimumDelay(float value)
        {
            this.<MinimumDelay>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HasGlow()
        {
            return (bool)this.<HasGlow>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_HasGlow(bool value)
        {
            this.<HasGlow>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsActive()
        {
            return (bool)(this.elapsedTime < 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DigitalRuby.ThunderAndLightning.CameraMode get_CameraMode()
        {
            return (DigitalRuby.ThunderAndLightning.CameraMode)this.<CameraMode>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_CameraMode(DigitalRuby.ThunderAndLightning.CameraMode value)
        {
            this.<CameraMode>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LightningBolt()
        {
            this.segmentGroups = new System.Collections.Generic.List<DigitalRuby.ThunderAndLightning.LightningBoltSegmentGroup>();
            this.segmentGroupsWithLight = new System.Collections.Generic.List<DigitalRuby.ThunderAndLightning.LightningBoltSegmentGroup>();
            this.activeLineRenderers = new System.Collections.Generic.List<LineRendererMesh>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetupLightningBolt(DigitalRuby.ThunderAndLightning.LightningBoltDependencies dependencies)
        {
            object val_7;
            if(dependencies == null)
            {
                goto label_7;
            }
            
            var val_7 = 0;
            val_7 = val_7 + 1;
            if(dependencies.Parameters.Count == 0)
            {
                goto label_7;
            }
            
            if(this.dependencies == null)
            {
                goto label_8;
            }
            
            val_7 = "This lightning bolt is already in use!";
            goto label_11;
            label_7:
            val_7 = "Lightning bolt dependencies must not be null";
            label_11:
            UnityEngine.Debug.LogError(message:  val_7);
            return;
            label_8:
            this.dependencies = dependencies;
            this.<CameraMode>k__BackingField = dependencies.CameraMode;
            this.timeSinceLevelLoad = DigitalRuby.ThunderAndLightning.LightningBoltScript.TimeSinceStart;
            this.CheckForGlow(parameters:  dependencies.Parameters);
            this.<MinimumDelay>k__BackingField = -1.175494E-38f;
            if(dependencies.ThreadState != null)
            {
                    System.DateTime val_4 = System.DateTime.UtcNow;
                this.startTimeOffset = val_4;
                bool val_6 = dependencies.ThreadState.AddActionForBackgroundThread(action:  new System.Action(object:  this, method:  System.Void DigitalRuby.ThunderAndLightning.LightningBolt::ProcessAllLightningParameters()));
                return;
            }
            
            this.ProcessAllLightningParameters();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Update()
        {
            var val_2;
            float val_1 = DigitalRuby.ThunderAndLightning.LightningBoltScript.DeltaTime;
            val_1 = this.elapsedTime + val_1;
            this.elapsedTime = val_1;
            if(val_1 > this.maxLifeTime)
            {
                    val_2 = 0;
                return (bool)val_2;
            }
            
            if(this.hasLight != false)
            {
                    this.UpdateLights();
            }
            
            val_2 = 1;
            return (bool)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Cleanup()
        {
            var val_3;
            var val_14;
            var val_22;
            var val_23;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            List.Enumerator<T> val_1 = this.segmentGroupsWithLight.GetEnumerator();
            val_22 = 0;
            val_23 = 0;
            label_18:
            if((182301472 & 1) == 0)
            {
                goto label_19;
            }
            
            GameUI.EmailUIDataHandler val_4 = val_3.emailUIDataHandler;
            List.Enumerator<T> val_5 = X23.GetEnumerator();
            label_6:
            if((182301440 & 1) == 0)
            {
                goto label_7;
            }
            
            this.CleanupLight(l:  val_3.emailUIDataHandler);
            goto label_6;
            label_7:
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526263984896});
            if(((76 == 0) ? 76 : 76) != 76)
            {
                goto label_10;
            }
            
            if(val_4 != null)
            {
                goto label_16;
            }
            
            goto label_15;
            label_10:
            if( == 0)
            {
                goto label_13;
            }
            
            if(val_4 != null)
            {
                goto label_16;
            }
            
            goto label_15;
            label_13:
            if(val_4 != null)
            {
                goto label_16;
            }
            
            label_15:
            label_16:
            val_4.Clear();
            goto label_18;
            label_19:
            long val_9 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526263984928});
            if(((76 == 0) ? 112 : 76) == 112)
            {
                
            }
            else
            {
                    if( != 0)
            {
                    val_25 = 0;
            }
            
            }
            
            val_26 = null;
            val_26 = null;
            bool val_11 = false;
            System.Threading.Monitor.Enter(obj:  DigitalRuby.ThunderAndLightning.LightningBolt.groupCache, lockTaken: ref  val_11);
            List.Enumerator<T> val_12 = this.segmentGroups.GetEnumerator();
            label_36:
            if((182301472 & 1) == 0)
            {
                goto label_37;
            }
            
            val_27 = null;
            val_27 = null;
            DigitalRuby.ThunderAndLightning.LightningBolt.groupCache.Add(item:  val_14.emailUIDataHandler);
            goto label_36;
            label_37:
            long val_16 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526263984928});
            if(( != 0) && (((203 == 0) ? 203 : 203) != 203))
            {
                    val_25 = 0;
            }
            
            if(val_11 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  DigitalRuby.ThunderAndLightning.LightningBolt.groupCache);
            }
            
            if(((203 == 0) ? 203 : 203) == 203)
            {
                
            }
            else
            {
                    if( != 0)
            {
                    val_25 = 0;
            }
            
            }
            
            mem[1152921526263997109] = 0;
            this.elapsedTime = 0f;
            this.lifeTime = 0f;
            if(this.dependencies != null)
            {
                    this.dependencies.ReturnToCache.Invoke(obj:  this.dependencies);
                this.dependencies = 0;
            }
            
            List.Enumerator<T> val_19 = this.activeLineRenderers.GetEnumerator();
            do
            {
                label_60:
                if((182301408 & 1) == 0)
            {
                goto label_61;
            }
            
                GameUI.EmailUIDataHandler val_20 = 0.emailUIDataHandler;
            }
            while(val_20 == null);
            
            val_20.Reset();
            val_28 = null;
            val_28 = null;
            DigitalRuby.ThunderAndLightning.LightningBolt.lineRendererCache.Add(item:  val_20);
            goto label_60;
            label_61:
            long val_21 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526263984864});
            this.segmentGroups.Clear();
            this.segmentGroupsWithLight.Clear();
            this.activeLineRenderers.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DigitalRuby.ThunderAndLightning.LightningBoltSegmentGroup AddGroup()
        {
            var val_7;
            var val_8;
            var val_9;
            DigitalRuby.ThunderAndLightning.LightningBoltSegmentGroup val_10;
            val_7 = null;
            val_7 = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  DigitalRuby.ThunderAndLightning.LightningBolt.groupCache, lockTaken: ref  val_1);
            val_8 = null;
            val_8 = null;
            if(DigitalRuby.ThunderAndLightning.LightningBolt.groupCache.Count != 0)
            {
                    val_9 = null;
                val_9 = null;
                int val_4 = DigitalRuby.ThunderAndLightning.LightningBolt.groupCache.Count - 1;
                val_10 = DigitalRuby.ThunderAndLightning.LightningBolt.groupCache.Item[val_4];
                val_10.Reset();
                DigitalRuby.ThunderAndLightning.LightningBolt.groupCache.RemoveAt(index:  val_4);
            }
            else
            {
                    val_10 = new DigitalRuby.ThunderAndLightning.LightningBoltSegmentGroup();
                val_10 = new DigitalRuby.ThunderAndLightning.LightningBoltSegmentGroup();
            }
            
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  DigitalRuby.ThunderAndLightning.LightningBolt.groupCache);
            }
            
            this.segmentGroups.Add(item:  new DigitalRuby.ThunderAndLightning.LightningBoltSegmentGroup());
            return val_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ClearCache()
        {
            var val_3;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            val_14 = null;
            val_14 = null;
            List.Enumerator<T> val_1 = DigitalRuby.ThunderAndLightning.LightningBolt.lineRendererCache.GetEnumerator();
            label_8:
            if((182622784 & 1) == 0)
            {
                goto label_4;
            }
            
            if(val_3.emailUIDataHandler == null)
            {
                goto label_8;
            }
            
            UnityEngine.Object.Destroy(obj:  val_4._masterDomain);
            goto label_8;
            label_4:
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526264306240});
            val_15 = null;
            val_15 = null;
            List.Enumerator<T> val_7 = DigitalRuby.ThunderAndLightning.LightningBolt.lightCache.GetEnumerator();
            label_23:
            if((182622752 & 1) == 0)
            {
                goto label_16;
            }
            
            GameUI.EmailUIDataHandler val_8 = val_3.emailUIDataHandler;
            if(val_8 == 0)
            {
                goto label_23;
            }
            
            UnityEngine.Object.Destroy(obj:  val_8.gameObject);
            goto label_23;
            label_16:
            val_16 = 0;
            long val_11 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526264306208});
            if(((126 == 0) ? 126 : 126) == 126)
            {
                
            }
            else
            {
                    if( != 0)
            {
                    val_16 = 0;
            }
            
            }
            
            val_17 = null;
            val_17 = null;
            DigitalRuby.ThunderAndLightning.LightningBolt.lineRendererCache.Clear();
            DigitalRuby.ThunderAndLightning.LightningBolt.lightCache.Clear();
            bool val_13 = false;
            System.Threading.Monitor.Enter(obj:  DigitalRuby.ThunderAndLightning.LightningBolt.groupCache, lockTaken: ref  val_13);
            val_18 = null;
            val_18 = null;
            DigitalRuby.ThunderAndLightning.LightningBolt.groupCache.Clear();
            if(val_13 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  DigitalRuby.ThunderAndLightning.LightningBolt.groupCache);
            }
            
            if(val_16 == 0)
            {
                    return;
            }
            
            if(189 == 0)
            {
                    return;
            }
            
            if(189 == 189)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CleanupLight(UnityEngine.Light l)
        {
            UnityEngine.Object val_3;
            var val_4;
            val_3 = l;
            if(val_3 == 0)
            {
                    return;
            }
            
            this.dependencies.LightRemoved.Invoke(obj:  val_3);
            val_4 = null;
            val_4 = null;
            DigitalRuby.ThunderAndLightning.LightningBolt.lightCache.Add(item:  val_3);
            val_3 = val_3.gameObject;
            val_3.SetActive(value:  false);
            int val_3 = DigitalRuby.ThunderAndLightning.LightningBolt.lightCount;
            val_3 = val_3 - 1;
            DigitalRuby.ThunderAndLightning.LightningBolt.lightCount = val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EnableLineRenderer(DigitalRuby.ThunderAndLightning.LightningBolt.LineRendererMesh lineRenderer, int tag)
        {
            if(lineRenderer == null)
            {
                    return;
            }
            
            if((lineRenderer.<GameObject>k__BackingField) == 0)
            {
                    return;
            }
            
            if((lineRenderer.<Tag>k__BackingField) != tag)
            {
                    return;
            }
            
            if(this.elapsedTime >= 0)
            {
                    return;
            }
            
            lineRenderer.PopulateMesh();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator EnableLastRendererCoRoutine()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new LightningBolt.<EnableLastRendererCoRoutine>d__39();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DigitalRuby.ThunderAndLightning.LightningBolt.LineRendererMesh GetOrCreateLineRenderer()
        {
            var val_16;
            var val_17;
            float val_18;
            float val_19;
            UnityEngine.MeshRenderer val_20;
            int val_21;
            label_13:
            val_16 = null;
            val_16 = null;
            if(DigitalRuby.ThunderAndLightning.LightningBolt.lineRendererCache.Count == 0)
            {
                goto label_4;
            }
            
            val_17 = null;
            val_17 = null;
            int val_3 = DigitalRuby.ThunderAndLightning.LightningBolt.lineRendererCache.Count - 1;
            LineRendererMesh val_4 = DigitalRuby.ThunderAndLightning.LightningBolt.lineRendererCache.Item[val_3];
            DigitalRuby.ThunderAndLightning.LightningBolt.lineRendererCache.RemoveAt(index:  val_3);
            if((val_4 == null) || ((val_4.<Transform>k__BackingField) == 0))
            {
                goto label_13;
            }
            
            label_36:
            val_4.<Transform>k__BackingField.parent = 0;
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.identity;
            val_4.<Transform>k__BackingField.rotation = new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w};
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            val_4.<Transform>k__BackingField.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            val_4.<Transform>k__BackingField.parent = this.dependencies.Parent.transform;
            val_4.<GameObject>k__BackingField.layer = this.dependencies.Parent.layer;
            UnityEngine.Transform val_10 = val_4.<GameObject>k__BackingField.transform;
            if(this.dependencies.UseWorldSpace == false)
            {
                goto label_30;
            }
            
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
            val_18 = val_11.x;
            val_19 = val_11.z;
            val_10.position = new UnityEngine.Vector3() {x = val_18, y = val_11.y, z = val_19};
            goto label_34;
            label_4:
            if(new LightningBolt.LineRendererMesh() != null)
            {
                goto label_36;
            }
            
            goto label_36;
            label_30:
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.zero;
            val_18 = val_13.x;
            val_19 = val_13.z;
            val_10.localPosition = new UnityEngine.Vector3() {x = val_18, y = val_13.y, z = val_19};
            label_34:
            val_4.Material = ((this.<HasGlow>k__BackingField) == true) ? this.dependencies.LightningMaterialMesh : this.dependencies.LightningMaterialMeshNoGlow;
            if((System.String.IsNullOrEmpty(value:  this.dependencies.SortLayerName)) != false)
            {
                    val_4.meshRenderer.sortingLayerName = 0;
                val_20 = val_4.meshRenderer;
                val_21 = 0;
            }
            else
            {
                    val_4.meshRenderer.sortingLayerName = this.dependencies.SortLayerName;
                val_20 = val_4.meshRenderer;
                val_21 = this.dependencies.SortOrderInLayer;
            }
            
            val_20.sortingOrder = val_21;
            this.activeLineRenderers.Add(item:  val_4);
            return val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RenderGroup(DigitalRuby.ThunderAndLightning.LightningBoltSegmentGroup group, DigitalRuby.ThunderAndLightning.LightningBoltParameters p)
        {
            float val_19;
            float val_20;
            float val_21;
            float val_24;
            float val_25;
            float val_26;
            float val_34;
            float val_35;
            var val_36;
            float val_37;
            float val_38;
            var val_39;
            float val_40;
            float val_41;
            float val_42;
            var val_43;
            float val_45;
            int val_46;
            System.Collections.Generic.List<DigitalRuby.ThunderAndLightning.LightningBoltSegment> val_47;
            .<>4__this = this;
            if(group.SegmentCount == 0)
            {
                    return;
            }
            
            if(this.dependencies.ThreadState != null)
            {
                    System.DateTime val_3 = System.DateTime.UtcNow;
                System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_3.dateData}, d2:  new System.DateTime() {dateData = this.startTimeOffset});
                val_34 = (float)val_4._ticks.TotalSeconds;
            }
            else
            {
                    val_34 = 0f;
            }
            
            if(group != null)
            {
                    val_35 = group.PeakStart;
                val_36 = group + 32;
                val_37 = group + 32 + -4;
                val_38 = mem[group + 32 + 4];
                val_38 = group + 32 + 4;
            }
            else
            {
                    val_37 = 0f;
                val_35 = 8.96831E-44f;
                val_36 = 36;
                val_38 = 0f;
            }
            
            float val_33 = group.LifeTime;
            float val_6 = this.timeSinceLevelLoad + val_37;
            val_6 = val_34 + val_6;
            float val_7 = val_6 + val_35;
            float val_8 = val_38 + val_6;
            val_33 = val_6 + val_33;
            float val_37 = group.LineWidth;
            val_39 = null;
            val_39 = null;
            System.Collections.Generic.List<DigitalRuby.ThunderAndLightning.LightningBoltSegment> val_34 = group.Segments;
            val_40 = DigitalRuby.ThunderAndLightning.LightningBoltParameters.Scale;
            val_34 = val_34.Count - group.StartIndex;
            float val_35 = p.growthMultiplier;
            val_41 = (float)val_34;
            val_42 = 0f;
            if(val_35 > 0f)
            {
                    val_42 = group.LifeTime / val_41;
                val_35 = val_42 * val_35;
            }
            
            val_43 = 1152921526264822208;
            if(this.activeLineRenderers.Count == 0)
            {
                goto label_18;
            }
            
            if(this.activeLineRenderers == null)
            {
                goto label_19;
            }
            
            val_43 = this.activeLineRenderers.Count;
            goto label_20;
            label_18:
            LineRendererMesh val_12 = this.GetOrCreateLineRenderer();
            goto label_21;
            label_19:
            val_43 = 0.Count;
            label_20:
            LineRendererMesh val_15 = this.activeLineRenderers.Item[val_43 - 1];
            label_21:
            .currentLineRenderer = val_15;
            if((val_15.PrepareForLines(lineCount:  val_34)) == false)
            {
                goto label_23;
            }
            
            label_41:
            label_42:
            float val_36 = 0.5f;
            val_36 = val_37 * val_36;
            val_37 = val_36 * val_40;
            val_43 = 1152921526265199424;
            DigitalRuby.ThunderAndLightning.LightningBoltSegment val_18 = group.Segments.Item[group.StartIndex];
            DigitalRuby.ThunderAndLightning.LightningBoltSegment val_23 = group.Segments.Item[group.StartIndex];
            val_38 = 0f;
            val_41 = val_37;
            val_45 = p.GlowWidthMultiplier;
            val_40 = p.Intensity;
            int val_38 = val_41;
            val_38 = (val_37 - (val_37 * group.EndWidthMultiplier)) / val_38;
            (LightningBolt.<>c__DisplayClass41_0)[1152921526265335168].currentLineRenderer.BeginLine(start:  new UnityEngine.Vector3() {x = val_19, y = val_20, z = val_21}, end:  new UnityEngine.Vector3() {x = val_24, y = val_25, z = val_26}, radius:  val_41, color:  new UnityEngine.Color32() {r = group.Color, g = group.Color, b = group.Color, a = group.Color}, colorIntensity:  val_40, fadeLifeTime:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = val_45, w = p.GlowIntensity}, glowWidthModifier:  null, glowIntensity:  null);
            float val_44 = val_41;
            val_46 = group.StartIndex + 1;
            goto label_27;
            label_33:
            if(p.growthMultiplier < 0)
            {
                    float val_41 = val_35;
                float val_39 = 0f;
                float val_40 = 8.96831E-44f;
                float val_42 = 0f;
                float val_43 = group.LifeTime;
                val_39 = val_41 + val_39;
                val_40 = val_6 + val_40;
                val_41 = val_6 + val_39;
                val_42 = val_6 + val_42;
                val_40 = val_39 + val_40;
                val_43 = val_6 + val_43;
            }
            
            DigitalRuby.ThunderAndLightning.LightningBoltSegment val_27 = group.Segments.Item[val_46];
            val_44 = val_44 - val_38;
            DigitalRuby.ThunderAndLightning.LightningBoltSegment val_28 = group.Segments.Item[val_46];
            val_40 = 0f;
            val_38 = 0f;
            val_45 = p.GlowIntensity;
            val_41 = p.Intensity;
            (LightningBolt.<>c__DisplayClass41_0)[1152921526265335168].currentLineRenderer.AppendLine(start:  new UnityEngine.Vector3() {x = val_19, y = val_20, z = val_21}, end:  new UnityEngine.Vector3() {x = val_24, y = val_25, z = val_26}, radius:  val_44, color:  new UnityEngine.Color32() {r = group.Color, g = group.Color, b = group.Color, a = group.Color}, colorIntensity:  val_41, fadeLifeTime:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = p.GlowWidthMultiplier, w = val_45}, glowWidthModifier:  null, glowIntensity:  null);
            val_46 = val_46 + 1;
            label_27:
            val_47 = group.Segments;
            if(val_46 < val_47.Count)
            {
                goto label_33;
            }
            
            return;
            label_23:
            val_47 = (LightningBolt.<>c__DisplayClass41_0)[1152921526265335168].currentLineRenderer;
            if(((LightningBolt.<>c__DisplayClass41_0)[1152921526265335168].currentLineRenderer.<CustomTransform>k__BackingField) != null)
            {
                    return;
            }
            
            if(this.dependencies.ThreadState == null)
            {
                goto label_38;
            }
            
            bool val_31 = this.dependencies.ThreadState.AddActionForMainThread(action:  new System.Action(object:  new LightningBolt.<>c__DisplayClass41_0(), method:  System.Void LightningBolt.<>c__DisplayClass41_0::<RenderGroup>b__0()), waitForAction:  true);
            goto label_41;
            label_38:
            this.EnableCurrentLineRenderer();
            .currentLineRenderer = this.GetOrCreateLineRenderer();
            goto label_42;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.IEnumerator NotifyBolt(DigitalRuby.ThunderAndLightning.LightningBoltDependencies dependencies, DigitalRuby.ThunderAndLightning.LightningBoltParameters p, UnityEngine.Transform transform, UnityEngine.Vector3 start, UnityEngine.Vector3 end)
        {
            LightningBolt.<NotifyBolt>d__42 val_1 = new LightningBolt.<NotifyBolt>d__42();
            .<>1__state = 0;
            if(val_1 != null)
            {
                    .p = p;
                .dependencies = dependencies;
                .transform = transform;
            }
            else
            {
                    mem[40] = dependencies;
                mem[32] = p;
                mem[72] = transform;
            }
            
            .start = start;
            mem[1152921526265586356] = start.y;
            mem[1152921526265586360] = start.z;
            .end = end;
            mem[1152921526265586368] = end.y;
            mem[1152921526265586372] = end.z;
            return (System.Collections.IEnumerator)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessParameters(DigitalRuby.ThunderAndLightning.LightningBoltParameters p, DigitalRuby.ThunderAndLightning.RangeOfFloats delay, DigitalRuby.ThunderAndLightning.LightningBoltDependencies depends)
        {
            var val_21;
            float val_23;
            var val_24;
            float val_25;
            UnityEngine.Vector3 val_27;
            System.Single[] val_28;
            int val_29;
            var val_30;
            var val_31;
            val_21 = depends;
            float val_1 = UnityEngine.Mathf.Min(a:  delay.Minimum, b:  this.<MinimumDelay>k__BackingField);
            this.<MinimumDelay>k__BackingField = val_1;
            if(p != null)
            {
                    val_23 = val_1;
            }
            else
            {
                    val_23 = val_1;
            }
            
            p.delaySeconds = val_23;
            val_24 = null;
            if(depends.LevelOfDetailDistance <= UnityEngine.Mathf.Epsilon)
            {
                goto label_6;
            }
            
            if((p.<Points>k__BackingField.Count) >= 2)
            {
                goto label_8;
            }
            
            float val_3 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = depends.CameraPos, y = this.<MinimumDelay>k__BackingField, z = val_23}, b:  new UnityEngine.Vector3() {x = p.Start, y = V11.16B, z = V12.16B});
            val_27 = depends.CameraPos;
            val_28 = new float[1];
            goto label_11;
            label_6:
            val_29 = p.GenerationWhereForksStopSubtractor;
            goto label_12;
            label_8:
            UnityEngine.Vector3 val_5 = p.<Points>k__BackingField.Item[0];
            val_25 = val_5.y;
            float val_6 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = depends.CameraPos, y = this.<MinimumDelay>k__BackingField, z = val_23}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_25, z = val_5.z});
            float[] val_7 = new float[1];
            val_28 = val_7;
            if((p.<Points>k__BackingField) != null)
            {
                    val_30 = p.<Points>k__BackingField.Count;
            }
            else
            {
                    val_30 = p.<Points>k__BackingField.Count;
            }
            
            UnityEngine.Vector3 val_11 = p.<Points>k__BackingField.Item[val_30 - 1];
            val_27 = depends.CameraPos;
            label_11:
            val_28[0] = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_27, y = this.<MinimumDelay>k__BackingField, z = depends.CameraPos}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            float val_13 = UnityEngine.Mathf.Min(values:  val_7);
            val_13 = val_13 / depends.LevelOfDetailDistance;
            int val_21 = (int)val_13;
            val_21 = UnityEngine.Mathf.Min(a:  8, b:  val_21);
            val_21 = p.generations - val_21;
            p.Generations = UnityEngine.Mathf.Max(a:  1, b:  val_21);
            val_29 = UnityEngine.Mathf.Clamp(value:  p.GenerationWhereForksStopSubtractor - val_21, min:  0, max:  8);
            p.GenerationWhereForksStopSubtractor = val_29;
            val_24 = null;
            label_12:
            val_29 = p.generations - val_29;
            p.generationWhereForksStop = val_29;
            float val_19 = UnityEngine.Mathf.Max(a:  p.LifeTime + p.delaySeconds, b:  this.lifeTime);
            this.lifeTime = val_19;
            this.maxLifeTime = UnityEngine.Mathf.Max(a:  val_19, b:  this.maxLifeTime);
            float val_22 = p.Forkedness;
            val_22 = val_22 * (float)p.generations;
            p.forkednessCalculated = p.generations;
            if(p.generations < 1)
            {
                    return;
            }
            
            if(p.Generator == null)
            {
                    val_21 = 1152921505338900480;
                val_31 = null;
                val_31 = null;
                p.Generator = DigitalRuby.ThunderAndLightning.LightningGenerator.GeneratorInstance;
            }
            
            0.GenerateLightningBolt(bolt:  this, p:  p, start: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, end: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            p.Start = 0;
            mem2[0] = 0f;
            p.End = 0;
            mem2[0] = 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessAllLightningParameters()
        {
            var val_31;
            float val_37;
            float val_38;
            var val_39;
            var val_40;
            LightningBolt.<>c__DisplayClass44_0 val_41;
            var val_43;
            var val_44;
            var val_47;
            var val_48;
            UnityEngine.Transform val_49;
            var val_50;
            var val_51;
            val_31 = null;
            val_31 = null;
            var val_35 = 0;
            val_35 = val_35 + 1;
            var val_36 = 0;
            val_36 = val_36 + 1;
            System.Collections.Generic.List<System.Int32> val_7 = new System.Collections.Generic.List<System.Int32>(capacity:  this.dependencies.Parameters.Count + 1);
            var val_37 = 0;
            val_37 = val_37 + 1;
            System.Collections.Generic.IEnumerator<T> val_10 = this.dependencies.Parameters.GetEnumerator();
            label_36:
            var val_38 = 0;
            val_38 = val_38 + 1;
            if(val_10.MoveNext() == false)
            {
                goto label_26;
            }
            
            var val_39 = 0;
            val_39 = val_39 + 1;
            T val_14 = val_10.Current;
            if(val_14 != 0)
            {
                    val_37 = (val_14 + 112 + 4) + (val_14 + 112);
                val_38 = (val_14 + 112) + (val_14 + 120);
            }
            else
            {
                    val_37 = 0f + (9.18355E-41f);
                val_38 = (1.401298E-45f) + (9.18355E-41f);
            }
            
            mem2[0] = DigitalRuby.ThunderAndLightning.LightningBolt.MaximumLightsPerBatch / this.dependencies.Parameters.Count;
            val_7.Add(item:  this.segmentGroups.Count);
            this.ProcessParameters(p:  val_14, delay:  new DigitalRuby.ThunderAndLightning.RangeOfFloats() {Minimum = val_37, Maximum = val_38}, depends:  this.dependencies);
            goto label_36;
            label_26:
            val_39 = 0;
            val_40 = 210;
            val_41 = new LightningBolt.<>c__DisplayClass44_0();
            if(val_10 == null)
            {
                
            }
            else
            {
                    var val_40 = 0;
                val_40 = val_40 + 1;
                val_10.Dispose();
            }
            
            if( == 210)
            {
                    val_40 = 0;
            }
            else
            {
                    if( != false)
            {
                    val_39 = 0;
            }
            
            }
            
            val_7.Add(item:  this.segmentGroups.Count);
            if( != null)
            {
                    val_43 = ;
                .dependenciesRef = this.dependencies;
            }
            else
            {
                    val_43 = 16;
                mem[16] = this.dependencies;
            }
            
            var val_43 = this.dependencies + 104;
            if((this.dependencies + 104 + 286) == 0)
            {
                goto label_66;
            }
            
            var val_41 = this.dependencies + 104 + 176;
            var val_42 = 0;
            val_41 = val_41 + 8;
            label_65:
            if(((this.dependencies + 104 + 176 + 8) + -8) == null)
            {
                goto label_64;
            }
            
            val_42 = val_42 + 1;
            val_41 = val_41 + 16;
            if(val_42 < (this.dependencies + 104 + 286))
            {
                goto label_65;
            }
            
            goto label_66;
            label_64:
            val_43 = val_43 + (((this.dependencies + 104 + 176 + 8)) << 4);
            val_44 = val_43 + 296;
            label_66:
            System.Collections.Generic.IEnumerator<T> val_18 = this.dependencies + 104.GetEnumerator();
            int val_46 = 0;
            label_122:
            var val_44 = 0;
            val_44 = val_44 + 1;
            if(val_18.MoveNext() == false)
            {
                goto label_72;
            }
            
            new LightningBolt.<>c__DisplayClass44_1() = new System.Object();
            .CS$<>8__locals1 = ;
            var val_45 = 0;
            val_45 = val_45 + 1;
            .parameters = val_18.Current;
            new LightningBolt.<>c__DisplayClass44_2() = new System.Object();
            if((new LightningBolt.<>c__DisplayClass44_2()) != null)
            {
                    val_47 = new LightningBolt.<>c__DisplayClass44_2();
                .CS$<>8__locals2 = new LightningBolt.<>c__DisplayClass44_1();
            }
            else
            {
                    mem[24] = new LightningBolt.<>c__DisplayClass44_1();
                val_47 = 24;
            }
            
            val_46 = val_46 + 1;
            UnityEngine.Transform val_27 = this.RenderLightningBolt(quality:  val_23.quality, generations:  1123685424, startGroupIndex:  val_7.Item[0], endGroupIndex:  val_7.Item[val_46], parameters:  .parameters);
            if((new LightningBolt.<>c__DisplayClass44_2()) != null)
            {
                    val_48 = new LightningBolt.<>c__DisplayClass44_2();
                .transform = val_27;
            }
            else
            {
                    mem[16] = val_27;
                val_48 = 16;
            }
            
            if(this.dependencies.ThreadState == null)
            {
                goto label_96;
            }
            
            new System.Action() = new System.Action(object:  new LightningBolt.<>c__DisplayClass44_2(), method:  System.Void LightningBolt.<>c__DisplayClass44_2::<ProcessAllLightningParameters>b__0());
            bool val_29 = this.dependencies.ThreadState.AddActionForMainThread(action:  new System.Action(), waitForAction:  false);
            goto label_122;
            label_96:
            if((new LightningBolt.<>c__DisplayClass44_2()) != null)
            {
                
            }
            else
            {
                    val_49 = mem[16];
            }
            
            UnityEngine.Coroutine val_31 = this.dependencies.StartCoroutine.Invoke(arg:  DigitalRuby.ThunderAndLightning.LightningBolt.NotifyBolt(dependencies:  .dependenciesRef, p:  .parameters, transform:  val_49, start:  new UnityEngine.Vector3() {x = val_23.Start, y = mem[val_23 + 48 + 4], z = mem[val_23 + 56]}, end:  new UnityEngine.Vector3() {x = val_23.End, y = mem[val_23 + 60 + 4], z = mem[val_23 + 68]}));
            goto label_122;
            label_72:
            val_50 = val_39;
            val_51 = 584;
            if(val_18 == null)
            {
                
            }
            else
            {
                    var val_47 = 0;
                val_47 = val_47 + 1;
                val_18.Dispose();
            }
            
            if(this.dependencies.ThreadState != null)
            {
                    bool val_34 = this.dependencies.ThreadState.AddActionForMainThread(action:  new System.Action(object:  this, method:  System.Void DigitalRuby.ThunderAndLightning.LightningBolt::EnableCurrentLineRendererFromThread()), waitForAction:  false);
                return;
            }
            
            this.EnableCurrentLineRenderer();
            this.dependencies.AddActiveBolt.Invoke(obj:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EnableCurrentLineRendererFromThread()
        {
            this.EnableCurrentLineRenderer();
            this.dependencies.ThreadState = 0;
            this.dependencies.AddActiveBolt.Invoke(obj:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EnableCurrentLineRenderer()
        {
            var val_12;
            var val_13;
            if(this.activeLineRenderers.Count == 0)
            {
                    return;
            }
            
            if((this.<MinimumDelay>k__BackingField) > 0f)
            {
                    UnityEngine.Coroutine val_3 = this.dependencies.StartCoroutine.Invoke(arg:  this.EnableLastRendererCoRoutine());
                return;
            }
            
            if(this.activeLineRenderers != null)
            {
                    val_12 = this.activeLineRenderers.Count;
            }
            else
            {
                    val_12 = 0.Count;
            }
            
            if(this.activeLineRenderers != null)
            {
                    val_13 = this.activeLineRenderers.Count;
            }
            else
            {
                    val_13 = 0.Count;
            }
            
            LineRendererMesh val_11 = this.activeLineRenderers.Item[val_13 - 1];
            this.EnableLineRenderer(lineRenderer:  this.activeLineRenderers.Item[val_12 - 1], tag:  val_11.<Tag>k__BackingField);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RenderParticleSystems(UnityEngine.Vector3 start, UnityEngine.Vector3 end, float trunkWidth, float lifeTime, float delaySeconds)
        {
            DigitalRuby.ThunderAndLightning.LightningBoltDependencies val_8;
            DigitalRuby.ThunderAndLightning.LightningBoltDependencies val_9;
            if(trunkWidth <= 0f)
            {
                    return;
            }
            
            if(this.dependencies.OriginParticleSystem == 0)
            {
                goto label_5;
            }
            
            val_8 = this.dependencies;
            if(this.dependencies != null)
            {
                goto label_6;
            }
            
            val_8 = this.dependencies;
            if(val_8 == null)
            {
                goto label_14;
            }
            
            label_6:
            UnityEngine.Coroutine val_3 = this.dependencies.StartCoroutine.Invoke(arg:  this.GenerateParticleCoRoutine(p:  this.dependencies.OriginParticleSystem, pos:  new UnityEngine.Vector3() {x = start.x, y = start.y, z = start.z}, delay:  delaySeconds));
            label_5:
            if(this.dependencies.DestParticleSystem == 0)
            {
                    return;
            }
            
            val_9 = this.dependencies;
            if(this.dependencies != null)
            {
                goto label_13;
            }
            
            val_9 = this.dependencies;
            if(val_9 == null)
            {
                goto label_14;
            }
            
            label_13:
            float val_8 = 0.8f;
            val_8 = lifeTime * val_8;
            UnityEngine.Coroutine val_7 = this.dependencies.StartCoroutine.Invoke(arg:  this.GenerateParticleCoRoutine(p:  this.dependencies.DestParticleSystem, pos:  new UnityEngine.Vector3() {x = end.x, y = end.y, z = end.z}, delay:  val_8 + delaySeconds));
            return;
            label_14:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform RenderLightningBolt(DigitalRuby.ThunderAndLightning.LightningBoltQualitySetting quality, int generations, int startGroupIndex, int endGroupIndex, DigitalRuby.ThunderAndLightning.LightningBoltParameters parameters)
        {
            UnityEngine.Vector3 val_11;
            var val_12;
            var val_13;
            UnityEngine.Vector3 val_18;
            var val_19;
            var val_20;
            var val_43;
            var val_44;
            var val_45;
            DigitalRuby.ThunderAndLightning.LightningLightParameters val_46;
            float val_48;
            var val_49;
            System.Collections.Generic.List<DigitalRuby.ThunderAndLightning.LightningBoltSegment> val_50;
            var val_51;
            var val_52;
            var val_53;
            LightningBolt.LineRendererMesh val_54;
            UnityEngine.Vector3 val_56;
            UnityEngine.Vector3 val_58;
            LightningBolt.<>c__DisplayClass48_0 val_1 = new LightningBolt.<>c__DisplayClass48_0();
            if(val_1 != null)
            {
                    val_43 = val_1;
                .parameters = parameters;
                val_44 = 1152921526266969328;
                mem[1152921526266969296] = this;
                mem[1152921526266969344] = startGroupIndex;
            }
            else
            {
                    mem[16] = this;
                val_43 = 48;
                mem[48] = parameters;
                val_44 = 64;
                mem[64] = startGroupIndex;
            }
            
            .quality = quality;
            if(this.segmentGroups.Count == 0)
            {
                    return 0;
            }
            
            if(val_44 >= this.segmentGroups.Count)
            {
                    return 0;
            }
            
            val_45 = this.segmentGroups;
            if(val_45.Count < endGroupIndex)
            {
                    return 0;
            }
            
            if(mem[48] == 0)
            {
                    val_45 = 0;
            }
            
            val_46 = mem[parameters + 224];
            val_46 = parameters + 224;
            .lp = val_46;
            if(val_46 == 0)
            {
                goto label_20;
            }
            
            if(((parameters + 224 + 32) > 0f) && ((parameters + 224 + 44) >= 0.01f))
            {
                    if((parameters + 224 + 36) >= (1E-07f))
            {
                goto label_13;
            }
            
            }
            
            val_46 = 0;
            label_49:
            bool val_5 = (this.hasLight == true) ? 1 : 0;
            val_5 = val_5 | val_46;
            this.hasLight = val_5;
            if(val_5 != 1)
            {
                goto label_14;
            }
            
            if(((LightningBolt.<>c__DisplayClass48_0)[1152921526266969280].lp) == null)
            {
                    val_45 = 0;
            }
            
            if(((0 & 2) != 0) && (496 == 0))
            {
                    val_45 = null;
            }
            
            (LightningBolt.<>c__DisplayClass48_0)[1152921526266969280].lp.LightPercent = UnityEngine.Mathf.Clamp(value:  (LightningBolt.<>c__DisplayClass48_0)[1152921526266969280].lp.LightPercent, min:  UnityEngine.Mathf.Epsilon, max:  1f);
            if(((LightningBolt.<>c__DisplayClass48_0)[1152921526266969280].lp) == null)
            {
                goto label_18;
            }
            
            val_48 = UnityEngine.Mathf.Clamp(value:  (LightningBolt.<>c__DisplayClass48_0)[1152921526266969280].lp.LightShadowPercent, min:  0f, max:  1f);
            goto label_19;
            label_14:
            .lp = 0;
            goto label_20;
            label_18:
            val_48 = UnityEngine.Mathf.Clamp(value:  (LightningBolt.<>c__DisplayClass48_0)[1152921526266969280].lp.LightShadowPercent, min:  0f, max:  1f);
            label_19:
            mem2[0] = val_48;
            label_20:
            DigitalRuby.ThunderAndLightning.LightningBoltSegmentGroup val_9 = this.segmentGroups.Item[mem[64]];
            if(val_9 != null)
            {
                    val_49 = val_9;
                val_50 = val_9.Segments;
            }
            else
            {
                    val_49 = 56;
                val_50 = 4194311;
            }
            
            DigitalRuby.ThunderAndLightning.LightningBoltSegment val_10 = val_50.Item[val_9.StartIndex];
            .start = val_11;
            mem[1152921526266969308] = val_12;
            mem[1152921526266969312] = val_13;
            DigitalRuby.ThunderAndLightning.LightningBoltSegment val_17 = val_49.Item[(val_9.StartIndex + val_9.SegmentCount) - 1];
            .end = val_18;
            mem[1152921526266969320] = val_19;
            mem[1152921526266969324] = val_20;
            mem2[0] = UnityEngine.Mathf.Clamp(value:  parameters + 192, min:  0f, max:  0.5f);
            if((parameters + 96) == 0)
            {
                goto label_36;
            }
            
            LightningBolt.<>c__DisplayClass48_1 val_22 = new LightningBolt.<>c__DisplayClass48_1();
            .CS$<>8__locals1 = val_1;
            if(this.activeLineRenderers.Count == 0)
            {
                goto label_38;
            }
            
            if(this.activeLineRenderers != null)
            {
                    val_51 = this.activeLineRenderers.Count;
            }
            else
            {
                    val_51 = 0.Count;
            }
            
            if((this.activeLineRenderers.Item[val_51 - 1].Empty) == false)
            {
                goto label_38;
            }
            
            if(this.activeLineRenderers == null)
            {
                goto label_39;
            }
            
            val_52 = this.activeLineRenderers.Count;
            goto label_40;
            label_38:
            val_53 = val_22;
            .currentLineRenderer = 0;
            label_50:
            if(this.dependencies.ThreadState == null)
            {
                goto label_42;
            }
            
            bool val_31 = this.dependencies.ThreadState.AddActionForMainThread(action:  new System.Action(object:  val_22, method:  System.Void LightningBolt.<>c__DisplayClass48_1::<RenderLightningBolt>b__1()), waitForAction:  true);
            val_54 = .currentLineRenderer;
            if(val_54 != null)
            {
                goto label_47;
            }
            
            return 0;
            label_42:
            this.EnableCurrentLineRenderer();
            val_54 = this.GetOrCreateLineRenderer();
            mem[1152921526267014288] = val_54;
            if(val_54 != null)
            {
                goto label_47;
            }
            
            return 0;
            label_13:
            var val_33 = ((parameters + 224 + 64) > 0.01f) ? 1 : 0;
            goto label_49;
            label_39:
            val_52 = 0.Count;
            label_40:
            val_54 = this.activeLineRenderers.Item[val_52 - 1];
            val_53 = val_22;
            .currentLineRenderer = val_54;
            if(val_54 == null)
            {
                goto label_50;
            }
            
            label_47:
            val_36.<CustomTransform>k__BackingField = (LightningBolt.<>c__DisplayClass48_1)[1152921526267014272].CS$<>8__locals1.parameters.CustomTransform;
            label_36:
            int val_47 = mem[64];
            if(val_47 < endGroupIndex)
            {
                    do
            {
                val_37.Delay = parameters + 28;
                val_37.LifeTime = parameters + 108;
                float val_43 = parameters + 108;
                float val_45 = val_37.LifeTime;
                float val_38 = (parameters + 192) * val_43;
                val_43 = val_45 - val_38;
                val_37.PeakStart = val_38;
                val_37.PeakEnd = val_43;
                float val_39 = val_38 * (parameters + 196);
                val_37.PeakStart = val_39;
                val_38 = val_43 - val_38;
                float val_44 = parameters + 200;
                val_44 = val_38 * val_44;
                val_38 = val_39 + val_44;
                val_37.PeakEnd = val_38;
                val_45 = val_45 - val_43;
                float val_46 = parameters + 204;
                val_46 = val_45 * val_46;
                val_46 = val_38 + val_46;
                val_37.LifeTime = val_46;
                if(val_1 != null)
            {
                    val_37.LightParameters = (LightningBolt.<>c__DisplayClass48_0)[1152921526266969280].lp;
            }
            else
            {
                    val_37.LightParameters = (LightningBolt.<>c__DisplayClass48_0)[1152921526266969280].lp;
            }
            
                this.RenderGroup(group:  this.segmentGroups.Item[val_47], p:  mem[48]);
                val_47 = val_47 + 1;
            }
            while(endGroupIndex != val_47);
            
            }
            
            if(this.dependencies.ThreadState != null)
            {
                    bool val_41 = this.dependencies.ThreadState.AddActionForMainThread(action:  new System.Action(object:  val_1, method:  System.Void LightningBolt.<>c__DisplayClass48_0::<RenderLightningBolt>b__0()), waitForAction:  false);
                return 0;
            }
            
            if(val_1 != null)
            {
                    val_56 = (LightningBolt.<>c__DisplayClass48_0)[1152921526266969280].start;
                val_58 = (LightningBolt.<>c__DisplayClass48_0)[1152921526266969280].end;
            }
            else
            {
                    val_56 = (LightningBolt.<>c__DisplayClass48_0)[1152921526266969280].start;
                val_58 = (LightningBolt.<>c__DisplayClass48_0)[1152921526266969280].end;
            }
            
            this.RenderParticleSystems(start:  new UnityEngine.Vector3() {x = val_56, y = val_43, z = val_38}, end:  new UnityEngine.Vector3() {x = val_58, y = V12.16B, z = V13.16B}, trunkWidth:  parameters + 132, lifeTime:  parameters + 108, delaySeconds:  parameters + 28);
            if(((LightningBolt.<>c__DisplayClass48_0)[1152921526266969280].lp) == null)
            {
                    return 0;
            }
            
            this.CreateLightsForGroup(group:  this.segmentGroups.Item[mem[64]], lp:  (LightningBolt.<>c__DisplayClass48_0)[1152921526266969280].lp, quality:  (LightningBolt.<>c__DisplayClass48_0)[1152921526266969280].quality, maxLights:  parameters + 32);
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateLightsForGroup(DigitalRuby.ThunderAndLightning.LightningBoltSegmentGroup group, DigitalRuby.ThunderAndLightning.LightningLightParameters lp, DigitalRuby.ThunderAndLightning.LightningBoltQualitySetting quality, int maxLights)
        {
            int val_26;
            var val_27;
            float val_28;
            float val_29;
            float val_30;
            var val_31;
            float val_32;
            float val_33;
            val_26 = quality;
            val_27 = null;
            val_27 = null;
            if(DigitalRuby.ThunderAndLightning.LightningBolt.lightCount == DigitalRuby.ThunderAndLightning.LightningBolt.MaximumLightCount)
            {
                    return;
            }
            
            if(maxLights < 1)
            {
                    return;
            }
            
            if(lp != null)
            {
                    val_28 = group.PeakStart;
                val_29 = (this.lifeTime - group.PeakEnd) * lp.FadeOutMultiplier;
                val_30 = (group.PeakEnd - val_28) * lp.FadeFullyLitMultiplier;
            }
            else
            {
                    val_29 = (this.lifeTime - group.PeakEnd) * lp.FadeOutMultiplier;
                val_28 = group.PeakStart;
                float val_4 = group.PeakEnd - group.PeakStart;
                val_30 = val_4 * 0f;
            }
            
            float val_23 = lp.FadeInMultiplier;
            val_23 = val_28 * val_23;
            val_23 = val_30 + val_23;
            val_29 = val_29 + val_23;
            val_4 = group.Delay + val_29;
            this.maxLifeTime = UnityEngine.Mathf.Max(a:  this.maxLifeTime, b:  val_4);
            this.segmentGroupsWithLight.Add(item:  group);
            int val_6 = group.SegmentCount;
            if(val_26 != 1)
            {
                goto label_11;
            }
            
            int val_7 = UnityEngine.QualitySettings.GetQualityLevel();
            val_31 = null;
            val_31 = null;
            if((DigitalRuby.ThunderAndLightning.LightningBoltParameters.QualityMaximums.TryGetValue(key:  val_7, value: out  0)) == false)
            {
                goto label_15;
            }
            
            val_32 = UnityEngine.Mathf.Min(a:  lp.LightPercent, b:  val_8.MaximumLightPercent);
            val_33 = UnityEngine.Mathf.Min(a:  lp.LightShadowPercent, b:  val_8.MaximumShadowPercent);
            goto label_20;
            label_15:
            UnityEngine.Debug.LogError(message:  "Unable to read lightning quality for level " + val_7.ToString());
            label_11:
            val_32 = lp.LightPercent;
            val_33 = lp.LightShadowPercent;
            label_20:
            float val_24 = (float)val_6;
            val_24 = val_32 * val_24;
            int val_25 = UnityEngine.Mathf.Min(a:  maxLights, b:  (int)val_24);
            int val_28 = UnityEngine.Mathf.Max(a:  1, b:  val_25);
            val_25 = val_6 / val_28;
            int val_18 = UnityEngine.Mathf.Max(a:  1, b:  val_25);
            float val_26 = (float)val_28;
            val_26 = val_33 * val_26;
            val_26 = val_28 - (int)val_26;
            float val_27 = 0.5f;
            val_27 = (float)val_18 * val_27;
            val_28 = group.StartIndex + (int)val_27;
            do
            {
                if(val_28 >= group.Segments.Count)
            {
                    return;
            }
            
                val_28 = val_28 + val_18;
            }
            while((this.AddLightToGroup(group:  group, lp:  lp, segmentIndex:  val_28, nthLight:  maxLights, nthShadows:  val_26, maxLights: ref  val_28, nthShadowCounter: ref  val_26)) == false);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool AddLightToGroup(DigitalRuby.ThunderAndLightning.LightningBoltSegmentGroup group, DigitalRuby.ThunderAndLightning.LightningLightParameters lp, int segmentIndex, int nthLight, int nthShadows, ref int maxLights, ref int nthShadowCounter)
        {
            float val_3;
            float val_4;
            float val_5;
            float val_7;
            float val_8;
            float val_9;
            float val_15;
            float val_16;
            DigitalRuby.ThunderAndLightning.LightningBoltDependencies val_17;
            var val_18;
            var val_19;
            UnityEngine.Light val_1 = this.GetOrCreateLight(lp:  lp);
            group.Lights.Add(item:  val_1);
            DigitalRuby.ThunderAndLightning.LightningBoltSegment val_2 = group.Segments.Item[segmentIndex];
            DigitalRuby.ThunderAndLightning.LightningBoltSegment val_6 = group.Segments.Item[segmentIndex];
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3, y = val_4, z = val_5}, b:  new UnityEngine.Vector3() {x = val_7, y = val_8, z = val_9});
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  0.5f);
            val_15 = val_11.y;
            val_16 = val_11.z;
            if(this.dependencies.CameraIsOrthographic == false)
            {
                goto label_12;
            }
            
            val_17 = this.dependencies;
            if(val_17 == null)
            {
                goto label_9;
            }
            
            if(this.dependencies.CameraMode != 3)
            {
                goto label_10;
            }
            
            label_14:
            val_15 = val_15 + lp.OrthographicOffset;
            goto label_12;
            label_9:
            if(this.dependencies == null)
            {
                goto label_13;
            }
            
            val_17 = this.dependencies;
            if(this.dependencies.CameraMode == 3)
            {
                goto label_14;
            }
            
            label_10:
            val_16 = val_16 + lp.OrthographicOffset;
            label_12:
            UnityEngine.Transform val_13 = val_1.gameObject.transform;
            if(this.dependencies.UseWorldSpace == false)
            {
                goto label_20;
            }
            
            val_13.position = new UnityEngine.Vector3() {x = val_11.x, y = val_15, z = val_16};
            if(lp != null)
            {
                goto label_29;
            }
            
            label_30:
            label_29:
            if(lp.LightShadowPercent == 0f)
            {
                goto label_22;
            }
            
            int val_15 = nthShadowCounter;
            val_15 = val_15 + 1;
            nthShadowCounter = val_15;
            if(val_15 >= nthShadows)
            {
                goto label_23;
            }
            
            label_22:
            val_1.shadows = 0;
            label_32:
            val_18 = null;
            val_18 = null;
            int val_16 = DigitalRuby.ThunderAndLightning.LightningBolt.lightCount;
            val_16 = val_16 + 1;
            DigitalRuby.ThunderAndLightning.LightningBolt.lightCount = val_16;
            if(val_16 == DigitalRuby.ThunderAndLightning.LightningBolt.MaximumLightCount)
            {
                    val_19 = 1;
                return (bool)(val_16 == DigitalRuby.ThunderAndLightning.LightningBolt.MaximumLightCount) ? 1 : 0;
            }
            
            int val_17 = maxLights;
            val_17 = val_17 - 1;
            maxLights = val_17;
            return (bool)(val_16 == DigitalRuby.ThunderAndLightning.LightningBolt.MaximumLightCount) ? 1 : 0;
            label_20:
            val_13.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_15, z = val_16};
            if(lp != null)
            {
                goto label_29;
            }
            
            goto label_30;
            label_23:
            val_1.shadows = 2;
            nthShadowCounter = 0;
            goto label_32;
            label_13:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Light GetOrCreateLight(DigitalRuby.ThunderAndLightning.LightningLightParameters lp)
        {
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            float val_20;
            UnityEngine.Color val_21;
            label_13:
            val_16 = null;
            val_16 = null;
            if(DigitalRuby.ThunderAndLightning.LightningBolt.lightCache.Count == 0)
            {
                goto label_4;
            }
            
            val_17 = null;
            val_17 = null;
            if(DigitalRuby.ThunderAndLightning.LightningBolt.lightCache != null)
            {
                    val_18 = DigitalRuby.ThunderAndLightning.LightningBolt.lightCache.Count;
            }
            else
            {
                    val_18 = 0.Count;
            }
            
            UnityEngine.Light val_5 = DigitalRuby.ThunderAndLightning.LightningBolt.lightCache.Item[val_18 - 1];
            if(DigitalRuby.ThunderAndLightning.LightningBolt.lightCache != null)
            {
                    val_19 = DigitalRuby.ThunderAndLightning.LightningBolt.lightCache.Count;
            }
            else
            {
                    val_19 = 0.Count;
            }
            
            DigitalRuby.ThunderAndLightning.LightningBolt.lightCache.RemoveAt(index:  val_19 - 1);
            if(val_5 == 0)
            {
                goto label_13;
            }
            
            label_20:
            if(val_5 == null)
            {
                goto label_15;
            }
            
            val_5.bounceIntensity = lp.BounceIntensity;
            val_20 = lp.ShadowNormalBias;
            goto label_16;
            label_4:
            new UnityEngine.GameObject(name:  "LightningBoltLight").AddComponent<UnityEngine.Light>().type = 2;
            if(lp != null)
            {
                goto label_20;
            }
            
            goto label_20;
            label_15:
            0.bounceIntensity = lp.BounceIntensity;
            val_20 = lp.ShadowNormalBias;
            label_16:
            val_5.shadowNormalBias = val_20;
            val_21 = lp.LightColor;
            val_5.color = new UnityEngine.Color() {r = val_21, g = V9.16B, b = V10.16B, a = V11.16B};
            if(val_5 != null)
            {
                    val_5.renderMode = lp.RenderMode;
                val_5.range = lp.LightRange;
                val_5.shadowStrength = lp.ShadowStrength;
                val_5.shadowBias = lp.ShadowBias;
                val_5.intensity = 0f;
            }
            else
            {
                    0.renderMode = lp.RenderMode;
                0.range = lp.LightRange;
                0.shadowStrength = lp.ShadowStrength;
                val_21 = lp.ShadowBias;
                0.shadowBias = val_21;
                0.intensity = 0f;
            }
            
            val_5.gameObject.transform.parent = this.dependencies.Parent.transform;
            val_5.gameObject.SetActive(value:  true);
            this.dependencies.LightAdded.Invoke(obj:  val_5);
            return val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateLight(DigitalRuby.ThunderAndLightning.LightningLightParameters lp, System.Collections.Generic.IEnumerable<UnityEngine.Light> lights, float delay, float peakStart, float peakEnd, float lifeTime)
        {
            float val_24;
            float val_25;
            var val_26;
            var val_27;
            float val_28;
            float val_29;
            float val_30;
            var val_33;
            var val_36;
            var val_39;
            var val_44;
            val_24 = peakEnd;
            float val_29 = peakStart;
            val_25 = delay;
            val_26 = lp;
            val_27 = this;
            val_28 = this.elapsedTime;
            if(val_28 < 0)
            {
                    return;
            }
            
            if(val_26 != null)
            {
                    lifeTime = lifeTime - val_24;
                val_29 = lifeTime * lp.FadeOutMultiplier;
                val_30 = (val_24 - val_29) * lp.FadeFullyLitMultiplier;
            }
            else
            {
                    val_29 = (lifeTime - val_24) * 0f;
                val_30 = (val_24 - val_29) * 0f;
                val_28 = this.elapsedTime;
            }
            
            float val_4 = val_28 - val_25;
            val_24 = lp.FadeInMultiplier * val_29;
            if(val_4 >= val_24)
            {
                goto label_4;
            }
            
            label_98:
            if(lights != null)
            {
                goto label_99;
            }
            
            label_100:
            label_99:
            var val_28 = 0;
            val_28 = val_28 + 1;
            goto label_9;
            label_4:
            val_29 = val_30 + val_24;
            if(val_4 <= val_29)
            {
                goto label_10;
            }
            
            goto label_62;
            label_10:
            var val_30 = 0;
            val_30 = val_30 + 1;
            goto label_16;
            label_9:
            val_25 = val_4 / val_24;
            System.Collections.Generic.IEnumerator<T> val_6 = lights.GetEnumerator();
            val_33 = 1152921504840978432;
            label_32:
            var val_31 = 0;
            val_31 = val_31 + 1;
            if(val_6.MoveNext() == false)
            {
                goto label_22;
            }
            
            var val_32 = 0;
            val_32 = val_32 + 1;
            val_6.Current.intensity = UnityEngine.Mathf.Lerp(a:  0f, b:  lp.LightIntensity, t:  val_25);
            goto label_32;
            label_22:
            val_26 = 0;
            val_36 = 261;
            if(val_6 != null)
            {
                goto label_33;
            }
            
            goto label_104;
            label_16:
            val_27 = lights.GetEnumerator();
            label_48:
            var val_33 = 0;
            val_33 = val_33 + 1;
            if(val_27.MoveNext() == false)
            {
                goto label_40;
            }
            
            var val_34 = 0;
            val_34 = val_34 + 1;
            val_27.Current.intensity = lp.LightIntensity;
            goto label_48;
            label_40:
            val_39 = 0;
            val_36 = 261;
            if(val_27 == null)
            {
                
            }
            else
            {
                    var val_35 = 0;
                val_35 = val_35 + 1;
                val_27.Dispose();
            }
            
            if( == 261)
            {
                    return;
            }
            
            label_62:
            val_29 = val_29 + val_29;
            val_25 = val_4 - val_29;
            val_29 = val_29 - val_29;
            var val_36 = 0;
            val_36 = val_36 + 1;
            val_25 = val_25 / val_29;
            val_33 = 1152921504689487872;
            val_27 = lights.GetEnumerator();
            label_83:
            var val_37 = 0;
            val_37 = val_37 + 1;
            if(val_27.MoveNext() == false)
            {
                goto label_73;
            }
            
            var val_38 = 0;
            val_38 = val_38 + 1;
            val_27.Current.intensity = UnityEngine.Mathf.Lerp(a:  lp.LightIntensity, b:  0f, t:  val_25);
            goto label_83;
            label_73:
            val_44 = 0;
            val_36 = 261;
            if(val_27 == null)
            {
                
            }
            else
            {
                    var val_39 = 0;
                val_39 = val_39 + 1;
                val_27.Dispose();
            }
            
            if(261 == 261)
            {
                    return;
            }
            
            if( == false)
            {
                goto label_98;
            }
            
            if(lights != null)
            {
                goto label_99;
            }
            
            goto label_100;
            label_33:
            var val_40 = 0;
            val_40 = val_40 + 1;
            lights.Dispose();
            label_104:
            if( == false)
            {
                    return;
            }
            
            if(261 == 0)
            {
                    return;
            }
            
            if(261 == 261)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateLights()
        {
            var val_5;
            DigitalRuby.ThunderAndLightning.LightningLightParameters val_6;
            System.Collections.Generic.IEnumerable<UnityEngine.Light> val_7;
            System.Collections.Generic.List<GameUI.EmailData> val_9;
            val_5 = this;
            List.Enumerator<T> val_1 = this.segmentGroupsWithLight.GetEnumerator();
            label_5:
            if((186338600 & 1) == 0)
            {
                    return;
            }
            
            if(0.emailUIDataHandler != null)
            {
                    val_9 = val_2._emailDatas;
            }
            else
            {
                    val_6 = 0;
                val_7 = 1;
                val_9 = 8.96831E-44f;
            }
            
            this.UpdateLight(lp:  val_6, lights:  val_7, delay:  V8.16B, peakStart:  val_9, peakEnd:  V10.16B, lifeTime:  val_2._emailIdsToBeDeletedOnServer);
            goto label_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator GenerateParticleCoRoutine(UnityEngine.ParticleSystem p, UnityEngine.Vector3 pos, float delay)
        {
            LightningBolt.<GenerateParticleCoRoutine>d__54 val_1 = new LightningBolt.<GenerateParticleCoRoutine>d__54();
            .<>1__state = 0;
            if(val_1 != null)
            {
                    .p = p;
            }
            else
            {
                    mem[40] = p;
            }
            
            .pos = pos;
            mem[1152921526268211012] = pos.y;
            mem[1152921526268211016] = pos.z;
            .delay = delay;
            return (System.Collections.IEnumerator)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CheckForGlow(System.Collections.Generic.IEnumerable<DigitalRuby.ThunderAndLightning.LightningBoltParameters> parameters)
        {
            var val_16;
            var val_17;
            var val_20;
            float val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_16 = 1152921504689487872;
            val_17 = parameters.GetEnumerator();
            label_26:
            var val_19 = 0;
            val_19 = val_19 + 1;
            if(val_17.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            T val_6 = val_17.Current;
            val_20 = null;
            val_20 = null;
            val_21 = UnityEngine.Mathf.Epsilon;
            if((val_6 + 144) >= val_21)
            {
                goto label_20;
            }
            
            val_22 = 0;
            if(this != null)
            {
                goto label_25;
            }
            
            goto label_22;
            label_20:
            val_21 = UnityEngine.Mathf.Epsilon;
            bool val_7 = ((val_6 + 148) >= val_21) ? 1 : 0;
            if(this != null)
            {
                goto label_25;
            }
            
            label_22:
            label_25:
            this.<HasGlow>k__BackingField = val_7;
            if(val_7 == 0)
            {
                goto label_26;
            }
            
            label_11:
            val_23 = 0;
            val_24 = 84;
            if(val_17 == null)
            {
                
            }
            else
            {
                    var val_21 = 0;
                val_21 = val_21 + 1;
                val_17.Dispose();
            }
            
            if( == 84)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
            
            val_17 = ???;
            val_24 = ???;
            val_16 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static LightningBolt()
        {
            DigitalRuby.ThunderAndLightning.LightningBolt.MaximumLightCount = 128;
            DigitalRuby.ThunderAndLightning.LightningBolt.MaximumLightsPerBatch = 8;
            DigitalRuby.ThunderAndLightning.LightningBolt.lineRendererCache = new System.Collections.Generic.List<LineRendererMesh>();
            DigitalRuby.ThunderAndLightning.LightningBolt.groupCache = new System.Collections.Generic.List<DigitalRuby.ThunderAndLightning.LightningBoltSegmentGroup>();
            DigitalRuby.ThunderAndLightning.LightningBolt.lightCache = new System.Collections.Generic.List<UnityEngine.Light>();
        }
    
    }

}
