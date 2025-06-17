using UnityEngine;

namespace SRDebugger.UI.Controls
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ProfilerGraphControl : Graphic
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.UI.Controls.ProfilerGraphControl.VerticalAlignments VerticalAlignment;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly float[] ScaleSteps;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool FloatingScale;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool TargetFpsUseApplication;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DrawAxes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int TargetFps;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Clip;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float DataPointMargin = 2;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float DataPointVerticalMargin = 2;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float DataPointWidth = 4;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int VerticalPadding;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int LineCount = 3;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Color[] LineColours;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.Services.IProfilerService _profilerService;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.UI.Controls.ProfilerGraphAxisLabel[] _axisLabels;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Rect _clipBounds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<UnityEngine.Vector3> _meshVertices;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<UnityEngine.Color32> _meshVertexColors;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<int> _meshTriangles;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Awake()
        {
            this.Awake();
            this._profilerService = SRF.Service.SRServiceManager.GetService<SRDebugger.Services.IProfilerService>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Start()
        {
            this.Start();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void Update()
        {
            this.SetVerticesDirty();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnPopulateMesh(UnityEngine.Mesh m)
        {
            float val_27;
            int val_29;
            float val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            int val_37;
            var val_38;
            var val_39;
            int val_40;
            System.Collections.Generic.List<UnityEngine.Color32> val_41;
            int val_42;
            var val_43;
            System.Collections.Generic.List<System.Int32> val_44;
            this._meshVertices.Clear();
            this._meshVertexColors.Clear();
            this._meshTriangles.Clear();
            UnityEngine.Rect val_2 = this.rectTransform.rect;
            val_27 = val_2.m_XMin;
            UnityEngine.Rect val_4 = this.rectTransform.rect;
            float val_26 = val_4.m_XMin;
            val_29 = this.TargetFps;
            this._clipBounds = 0;
            mem[1152921522970453564] = 0;
            mem[1152921522970453572] = 0;
            if((UnityEngine.Application.isPlaying != false) && (this.TargetFpsUseApplication != false))
            {
                    if(UnityEngine.Application.targetFrameRate >= 1)
            {
                    val_29 = UnityEngine.Application.targetFrameRate;
            }
            
            }
            
            val_30 = 1f / (float)val_29;
            if((this.FloatingScale == false) || (this.FloatingScale == false))
            {
                goto label_10;
            }
            
            val_31 = 0;
            goto label_11;
            label_20:
            val_32 = null;
            val_32 = null;
            int val_9 = SRDebugger.UI.Controls.ProfilerGraphControl.LineCount + 0;
            float val_10 = ((SRDebugger.UI.Controls.ProfilerGraphControl.LineCount + 0) + 32) * 1.1f;
            if(this.CalculateMaxFrameTime() < 0)
            {
                goto label_16;
            }
            
            val_31 = 1;
            label_11:
            val_33 = null;
            val_33 = null;
            if(val_31 < (SRDebugger.UI.Controls.ProfilerGraphControl.LineCount + 24))
            {
                goto label_20;
            }
            
            goto label_21;
            label_10:
            val_34 = 0;
            val_35 = 0;
            goto label_22;
            label_30:
            val_36 = null;
            val_36 = null;
            val_37 = 0;
            int val_11 = SRDebugger.UI.Controls.ProfilerGraphControl.LineCount + 0;
            var val_12 = (val_30 > ((SRDebugger.UI.Controls.ProfilerGraphControl.LineCount + 0) + 32)) ? (val_34) : (val_35);
            val_34 = 1;
            label_22:
            val_38 = null;
            val_38 = null;
            if(val_34 < (SRDebugger.UI.Controls.ProfilerGraphControl.LineCount + 24))
            {
                goto label_30;
            }
            
            goto label_32;
            label_16:
            if((val_31 & 2147483648) == 0)
            {
                goto label_32;
            }
            
            label_21:
            val_39 = null;
            val_39 = null;
            val_40 = SRDebugger.UI.Controls.ProfilerGraphControl.LineCount;
            if(SRDebugger.UI.Controls.ProfilerGraphControl.LineCount != 0)
            {
                goto label_35;
            }
            
            val_40 = SRDebugger.UI.Controls.ProfilerGraphControl.LineCount;
            if(val_40 == 0)
            {
                goto label_36;
            }
            
            label_35:
            val_35 = (SRDebugger.UI.Controls.ProfilerGraphControl.LineCount + 24) - 1;
            int val_13 = val_40 + (((long)(int)((SRDebugger.UI.Controls.ProfilerGraphControl.LineCount + 24 - 1))) << 2);
            val_30 = mem[(SRDebugger.UI.Controls.ProfilerGraphControl.LineCount + ((long)(int)((SRDebugger.UI.Controls.ProfilerGraphControl.LineCount + 24 - 1))) << 2) + 32];
            val_30 = (SRDebugger.UI.Controls.ProfilerGraphControl.LineCount + ((long)(int)((SRDebugger.UI.Controls.ProfilerGraphControl.LineCount + 24 - 1))) << 2) + 32;
            label_32:
            int val_24 = this.VerticalPadding;
            val_24 = val_24 << 1;
            float val_25 = (float)val_24;
            val_25 = val_26 - val_25;
            val_26 = val_25 / val_30;
            val_41 = this.CalculateVisibleDataPointCount();
            int val_15 = this.GetFrameBufferCurrentSize();
            val_42 = val_15 - 1;
            if((val_35 < (SRDebugger.UI.Controls.ProfilerGraphControl.LineCount + 24)) || (val_41 < 1))
            {
                goto label_40;
            }
            
            label_41:
            SRDebugger.Services.ProfilerFrame val_17 = this.GetFrame(i:  val_42);
            float val_27 = 0f;
            val_27 = val_27 * (-4f);
            val_27 = val_27 + val_27;
            val_27 = val_27 + (-4f);
            val_27 = val_27 - (val_27 * 0.5f);
            this.DrawDataPoint(xPosition:  val_27, verticalScale:  val_26, frame:  new SRDebugger.Services.ProfilerFrame() {FrameTime = val_42, OtherTime = val_42, RenderTime = val_42, UpdateTime = val_42});
            val_37 = 0 + 1;
            if(val_15 <= val_37)
            {
                goto label_40;
            }
            
            val_42 = val_42 - 1;
            if(val_37 < val_41)
            {
                goto label_41;
            }
            
            label_40:
            if(this.DrawAxes == false)
            {
                goto label_53;
            }
            
            if(this.FloatingScale == false)
            {
                goto label_43;
            }
            
            val_41 = 0;
            if((val_35 & 2147483648) == 0)
            {
                goto label_44;
            }
            
            goto label_53;
            label_43:
            this.DrawAxis(frameTime:  val_30, yPosition:  val_30 * val_26, label:  this.GetAxisLabel(index:  0));
            int val_20 = (this.FloatingScale == false) ? 1 : 0;
            if((val_35 & 2147483648) != 0)
            {
                goto label_53;
            }
            
            label_44:
            val_42 = 1152921505146781696;
            var val_21 = (long)val_35 + 8;
            label_54:
            val_43 = null;
            val_43 = null;
            val_35 = val_21 - 8;
            val_37 = SRDebugger.UI.Controls.ProfilerGraphControl.LineCount;
            this.DrawAxis(frameTime:  1.992256E-38f, yPosition:  val_26 * null, label:  this.GetAxisLabel(index:  val_20));
            if(val_35 < 1)
            {
                goto label_53;
            }
            
            val_41 = val_20 + 1;
            val_21 = val_21 - 1;
            if(val_20 < 1)
            {
                goto label_54;
            }
            
            label_53:
            if(m != null)
            {
                    m.Clear();
                m.SetVertices(inVertices:  this._meshVertices);
                m.SetColors(inColors:  this._meshVertexColors);
                val_44 = this._meshTriangles;
            }
            else
            {
                    0.Clear();
                0.SetVertices(inVertices:  this._meshVertices);
                val_41 = this._meshVertexColors;
                0.SetColors(inColors:  val_41);
                val_44 = this._meshTriangles;
            }
            
            m.SetTriangles(triangles:  val_44, submesh:  0);
            return;
            label_36:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawDataPoint(float xPosition, float verticalScale, SRDebugger.Services.ProfilerFrame frame)
        {
            float val_14;
            float val_15;
            float val_16;
            var val_17;
            float val_18;
            val_14 = V4.16B;
            float val_12 = V3.16B;
            val_15 = verticalScale;
            float val_10 = 4f;
            float val_11 = 0.5f;
            val_10 = xPosition + val_10;
            val_11 = xPosition * val_11;
            val_10 = val_10 + (-2f);
            var val_20 = 0;
            var val_19 = 0;
            val_16 = 0f;
            goto label_20;
            label_15:
            val_17 = (val_14 - val_12) + 2f;
            goto label_4;
            label_20:
            if(val_19 == 2)
            {
                goto label_5;
            }
            
            val_18 = (float)val_14;
            if(val_19 == 1)
            {
                goto label_8;
            }
            
            val_18 = 0f;
            if(val_19 != 0)
            {
                goto label_8;
            }
            
            val_18 = (float)V5.16B;
            goto label_8;
            label_5:
            val_18 = (float)val_12;
            label_8:
            val_12 = val_18 * val_15;
            if((SRF.SRFFloatExtensions.ApproxZero(f:  val_12)) == true)
            {
                goto label_10;
            }
            
            float val_13 = -4f;
            val_13 = val_12 + val_13;
            if(val_13 < 0)
            {
                goto label_10;
            }
            
            UnityEngine.Rect val_5 = this.rectTransform.rect;
            if(this.VerticalAlignment == 0)
            {
                goto label_12;
            }
            
            float val_14 = 2f;
            val_14 = val_16 + val_14;
            val_5.m_XMin = val_5.m_XMin * (-0.5f);
            val_14 = val_14 + val_5.m_XMin;
            goto label_13;
            label_12:
            UnityEngine.Rect val_7 = this.rectTransform.rect;
            val_7.m_XMin = val_7.m_XMin * 0.5f;
            val_7.m_XMin = val_7.m_XMin - val_16;
            val_14 = val_7.m_XMin + (-2f);
            if(this.VerticalAlignment == 0)
            {
                goto label_15;
            }
            
            label_13:
            val_7.m_XMin = val_12 + val_14;
            val_17 = val_7.m_XMin + (-2f);
            label_4:
            UnityEngine.Color val_15 = this.LineColours[val_20];
            UnityEngine.Color val_16 = this.LineColours[val_20];
            UnityEngine.Color val_18 = this.LineColours[val_20];
            val_15 = val_15 * (-0.5f);
            float val_8 = UnityEngine.Mathf.Max(a:  val_15, b:  xPosition);
            val_8 = val_8 * (-0.5f);
            float val_9 = UnityEngine.Mathf.Max(a:  val_8, b:  xPosition);
            this.AddRect(tl:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, tr:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, bl:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, br:  new UnityEngine.Vector3() {x = 0f, y = val_15, z = this.LineColours[val_20]}, c:  new UnityEngine.Color() {g = (float)val_12, b = UnityEngine.Mathf.Min(a:  val_11, b:  val_10), a = xPosition});
            val_15 = val_15;
            val_16 = val_16 + val_12;
            label_10:
            val_19 = val_19 + 1;
            val_20 = val_20 + 16;
            if(val_19 != 3)
            {
                goto label_20;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void DrawAxis(float frameTime, float yPosition, SRDebugger.UI.Controls.ProfilerGraphAxisLabel label)
        {
            UnityEngine.Rect val_2 = this.rectTransform.rect;
            float val_9 = val_2.m_XMin;
            float val_11 = -0.5f;
            float val_10 = 0.5f;
            float val_4 = val_9 * val_11;
            val_9 = val_9 * val_10;
            UnityEngine.Rect val_5 = this.rectTransform.rect;
            val_5.m_XMin = val_5.m_XMin * val_10;
            val_5.m_XMin = yPosition - val_5.m_XMin;
            val_10 = val_5.m_XMin + val_10;
            UnityEngine.Rect val_7 = this.rectTransform.rect;
            val_7.m_XMin = val_7.m_XMin * val_11;
            val_7.m_XMin = yPosition + val_7.m_XMin;
            val_11 = val_7.m_XMin + val_11;
            this.AddRect(tl:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, tr:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, bl:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, br:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, c:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
            if(label == 0)
            {
                    return;
            }
            
            label.SetValue(frameTime:  frameTime, yPosition:  yPosition);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void AddRect(UnityEngine.Vector3 tl, UnityEngine.Vector3 tr, UnityEngine.Vector3 bl, UnityEngine.Vector3 br, UnityEngine.Color c)
        {
            var val_1;
            var val_2;
            float val_3;
            float val_4;
            this._meshVertices.Add(item:  new UnityEngine.Vector3() {x = tl.x, y = tl.y, z = tl.z});
            this._meshVertices.Add(item:  new UnityEngine.Vector3() {x = tr.x, y = tr.y, z = tr.z});
            this._meshVertices.Add(item:  new UnityEngine.Vector3() {x = bl.x, y = val_4, z = bl.y});
            this._meshVertices.Add(item:  new UnityEngine.Vector3() {x = bl.z, y = val_3, z = br.x});
            this._meshTriangles.Add(item:  this._meshVertices.Count - 4);
            this._meshTriangles.Add(item:  this._meshVertices.Count - 3);
            this._meshTriangles.Add(item:  this._meshVertices.Count - 1);
            this._meshTriangles.Add(item:  this._meshVertices.Count - 2);
            this._meshTriangles.Add(item:  this._meshVertices.Count - 1);
            this._meshTriangles.Add(item:  this._meshVertices.Count - 3);
            UnityEngine.Color32 val_17 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = br.y, g = val_2, b = br.z, a = val_1});
            this._meshVertexColors.Add(item:  new UnityEngine.Color32() {r = val_17.r & 4294967295, g = val_17.r & 4294967295, b = val_17.r & 4294967295, a = val_17.r & 4294967295});
            UnityEngine.Color32 val_19 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = br.y, g = val_2, b = br.z, a = val_1});
            this._meshVertexColors.Add(item:  new UnityEngine.Color32() {r = val_19.r & 4294967295, g = val_19.r & 4294967295, b = val_19.r & 4294967295, a = val_19.r & 4294967295});
            UnityEngine.Color32 val_21 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = br.y, g = val_2, b = br.z, a = val_1});
            this._meshVertexColors.Add(item:  new UnityEngine.Color32() {r = val_21.r & 4294967295, g = val_21.r & 4294967295, b = val_21.r & 4294967295, a = val_21.r & 4294967295});
            UnityEngine.Color32 val_23 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = br.y, g = val_2, b = br.z, a = val_1});
            this._meshVertexColors.Add(item:  new UnityEngine.Color32() {r = val_23.r & 4294967295, g = val_23.r & 4294967295, b = val_23.r & 4294967295, a = val_23.r & 4294967295});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected SRDebugger.Services.ProfilerFrame GetFrame(int i)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame> val_2 = this._profilerService.FrameBuffer;
            if(val_2 != null)
            {
                    return val_2.Item[i];
            }
            
            return val_2.Item[i];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected int CalculateVisibleDataPointCount()
        {
            UnityEngine.Rect val_2 = this.rectTransform.rect;
            float val_4 = 0.25f;
            val_4 = val_2.m_XMin * val_4;
            return (int)UnityEngine.Mathf.RoundToInt(f:  val_4);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected int GetFrameBufferCurrentSize()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame> val_2 = this._profilerService.FrameBuffer;
            if(val_2 != null)
            {
                    return val_2.Count;
            }
            
            return val_2.Count;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected int GetFrameBufferMaxSize()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame> val_2 = this._profilerService.FrameBuffer;
            if(val_2 != null)
            {
                    return val_2.Capacity;
            }
            
            return val_2.Capacity;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected float CalculateMaxFrameTime()
        {
            int val_6 = this.GetFrameBufferCurrentSize();
            int val_7 = UnityEngine.Mathf.Min(a:  this.CalculateVisibleDataPointCount(), b:  val_6);
            if(val_7 < 1)
            {
                    return 0f;
            }
            
            val_6 = val_6 - 1;
            do
            {
                SRDebugger.Services.ProfilerFrame val_4 = this.GetFrame(i:  val_6);
                val_7 = val_7 - 1;
                var val_5 = (D0 > 0) ? (D0) : 0;
                val_6 = val_6 - 1;
            }
            while(val_7 != 0);
            
            return 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.UI.Controls.ProfilerGraphAxisLabel GetAxisLabel(int index)
        {
            var val_3;
            SRDebugger.UI.Controls.ProfilerGraphAxisLabel[] val_4;
            SRDebugger.UI.Controls.ProfilerGraphAxisLabel val_5;
            val_3 = index;
            if((this._axisLabels == null) || (UnityEngine.Application.isPlaying == false))
            {
                goto label_2;
            }
            
            val_4 = this._axisLabels;
            if(val_4 != null)
            {
                goto label_5;
            }
            
            goto label_4;
            label_2:
            val_4 = this.GetComponentsInChildren<SRDebugger.UI.Controls.ProfilerGraphAxisLabel>();
            this._axisLabels = val_4;
            if(val_4 != null)
            {
                goto label_5;
            }
            
            label_4:
            label_5:
            if(val_2.Length > val_3)
            {
                    val_3 = (long)val_3;
                val_5 = this._axisLabels[val_3];
                return (SRDebugger.UI.Controls.ProfilerGraphAxisLabel)val_5;
            }
            
            UnityEngine.Debug.LogWarning(message:  "[SRDebugger.Profiler] Not enough axis labels in pool");
            val_5 = 0;
            return (SRDebugger.UI.Controls.ProfilerGraphAxisLabel)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProfilerGraphControl()
        {
            this.VerticalAlignment = 1;
            this.DrawAxes = 1;
            this.TargetFps = 60;
            this.Clip = 1;
            this.VerticalPadding = 10;
            this.LineColours = new UnityEngine.Color[0];
            this._meshVertices = new System.Collections.Generic.List<UnityEngine.Vector3>();
            this._meshVertexColors = new System.Collections.Generic.List<UnityEngine.Color32>();
            this._meshTriangles = new System.Collections.Generic.List<System.Int32>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static ProfilerGraphControl()
        {
            SRDebugger.UI.Controls.ProfilerGraphControl.LineCount = new float[9] {2.076515E-32f, -4.294921E+08f, -3.274855E-33f, 2.0717E-32f, -3.286892E-33f, -3.274856E-33f, -4.284436E+08f, -1.212648E-12f, -1.209095E-12f};
        }
    
    }

}
