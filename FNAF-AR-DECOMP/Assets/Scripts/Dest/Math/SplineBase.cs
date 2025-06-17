using UnityEngine;

namespace Dest.Math
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class SplineBase : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Dest.Math.SplineBase.ArcLengthParametrization _parametrization;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected System.Collections.Generic.List<Dest.Math.SplineBase.ItemData> _data;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Dest.Math.SplineTypes _type;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected bool _recalcSegmentsLength;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected UnityEngine.Color _renderColor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Dest.Math.SplinePlaneTypes _creationPlane;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected int SegmentCount { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int VertexCount { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Valid { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Dest.Math.SplineTypes SplineType { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected int get_SegmentCount()
        {
            int val_2 = this._data.Count;
            val_2 = val_2 - ((this._type == 0) ? 1 : 0);
            return (int)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_VertexCount()
        {
            if(this._data != null)
            {
                    return this._data.Count;
            }
            
            return this._data.Count;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_Valid()
        {
            return (bool)(this._data.Count > 1) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Dest.Math.SplineTypes get_SplineType(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void set_SplineType(Dest.Math.SplineTypes value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this.PrepareForRuntime();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected SplineBase()
        {
            this._data = new System.Collections.Generic.List<ItemData>();
            this._recalcSegmentsLength = true;
            UnityEngine.Color val_2 = UnityEngine.Color.white;
            this._renderColor = val_2;
            mem[1152921519505912692] = val_2.g;
            mem[1152921519505912696] = val_2.b;
            mem[1152921519505912700] = val_2.a;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void GetSegmentIndexAndTime(float time, out int segmentIndex, out float segmentTime)
        {
            float val_4;
            int val_5;
            if(time <= 0f)
            {
                goto label_0;
            }
            
            int val_1 = this.SegmentCount;
            val_4 = 1f;
            if(time >= val_4)
            {
                goto label_1;
            }
            
            float val_3 = (float)val_1;
            val_5 = (int)val_3 * time;
            val_3 = 1f / val_3;
            float val_4 = (float)val_5;
            val_4 = val_3 * val_4;
            val_4 = time - val_4;
            val_4 = val_4 / val_3;
            goto label_2;
            label_0:
            segmentIndex = 0;
            val_4 = 0f;
            goto label_3;
            label_1:
            val_5 = val_1 - 1;
            label_2:
            segmentIndex = val_5;
            label_3:
            segmentTime = val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void PrepareForRuntime()
        {
            int val_1 = this._data.Count;
            if(val_1 < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            do
            {
                ItemData val_2 = this._data.Item[0];
                val_3 = val_3 + 1;
                val_2.RenderPoints = 0;
            }
            while(val_1 != val_3);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void RecalcSegmentsLength()
        {
            if(this._recalcSegmentsLength == false)
            {
                    return;
            }
            
            int val_3 = this.SegmentCount;
            if(val_3 >= 2)
            {
                    var val_6 = 1;
                do
            {
                float val_5 = this._data.Item[1].ProcessLength(currentLength:  this._data.Item[0].ProcessLength(currentLength:  0f));
                val_6 = val_6 + 1;
            }
            while(val_3 != val_6);
            
            }
            
            this._recalcSegmentsLength = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void AddVertexFirst(UnityEngine.Vector3 position); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void AddVertexLast(UnityEngine.Vector3 position); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void RemoveVertex(int index); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Clear(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void InsertBefore(int vertexIndex, UnityEngine.Vector3 position); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void InsertAfter(int vertexIndex, UnityEngine.Vector3 position); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract UnityEngine.Vector3 GetVertex(int vertexIndex); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetVertex(int vertexIndex, UnityEngine.Vector3 position); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 EvalPosition(float time)
        {
            this.GetSegmentIndexAndTime(time:  time, segmentIndex: out  0, segmentTime: out  float val_2 = 1.214194E+34f);
            UnityEngine.Vector3 val_4 = this._data.Item[0].EvalPosition(t:  0f);
            return new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 EvalTangent(float time)
        {
            this.GetSegmentIndexAndTime(time:  time, segmentIndex: out  0, segmentTime: out  float val_2 = 1.230088E+34f);
            UnityEngine.Vector3 val_4 = this._data.Item[0].EvalTangent(t:  0f);
            return new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Dest.Math.PositionTangent EvalPositionTangent(float time)
        {
            Dest.Math.PositionTangent val_0;
            this.GetSegmentIndexAndTime(time:  time, segmentIndex: out  0, segmentTime: out  float val_2 = 1.246476E+34f);
            ItemData val_3 = this._data.Item[0];
            UnityEngine.Vector3 val_4 = val_3.EvalPosition(t:  0f);
            UnityEngine.Vector3 val_5 = val_3.EvalTangent(t:  0f);
            val_0.Position.x = val_4.x;
            val_0.Position.y = val_4.y;
            val_0.Position.z = val_4.z;
            val_0.Tangent.x = val_5.x;
            val_0.Tangent.y = val_5.y;
            val_0.Tangent.z = val_5.z;
            return val_0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void EvalPosition(float time, out UnityEngine.Vector3 position)
        {
            this.GetSegmentIndexAndTime(time:  time, segmentIndex: out  0, segmentTime: out  float val_2 = 1.263363E+34f);
            UnityEngine.Vector3 val_4 = this._data.Item[0].EvalPosition(t:  0f);
            position.x = val_4.x;
            position.y = val_4.y;
            position.z = val_4.z;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void EvalTangent(float time, out UnityEngine.Vector3 tangent)
        {
            this.GetSegmentIndexAndTime(time:  time, segmentIndex: out  0, segmentTime: out  float val_2 = 1.280259E+34f);
            UnityEngine.Vector3 val_4 = this._data.Item[0].EvalTangent(t:  0f);
            tangent.x = val_4.x;
            tangent.y = val_4.y;
            tangent.z = val_4.z;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void EvalPositionTangent(float time, out Dest.Math.PositionTangent positionTangent)
        {
            this.GetSegmentIndexAndTime(time:  time, segmentIndex: out  0, segmentTime: out  float val_2 = 1.297156E+34f);
            ItemData val_3 = this._data.Item[0];
            if(val_3 != null)
            {
                    UnityEngine.Vector3 val_4 = val_3.EvalPosition(t:  0f);
                positionTangent.Position.x = val_4.x;
                positionTangent.Position.y = val_4.y;
                positionTangent.Position.z = val_4.z;
            }
            else
            {
                    UnityEngine.Vector3 val_5 = val_3.EvalPosition(t:  0f);
                positionTangent.Position.x = val_5.x;
                positionTangent.Position.y = val_5.y;
                positionTangent.Position.z = val_5.z;
            }
            
            UnityEngine.Vector3 val_6 = val_3.EvalTangent(t:  0f);
            positionTangent.Tangent.x = val_6.x;
            positionTangent.Tangent.y = val_6.y;
            positionTangent.Tangent.z = val_6.z;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void EvalFrame(float time, out Dest.Math.CurveFrame frame)
        {
            this.GetSegmentIndexAndTime(time:  time, segmentIndex: out  0, segmentTime: out  float val_2 = 1.314063E+34f);
            ItemData val_3 = this._data.Item[0];
            if(val_3 != null)
            {
                    UnityEngine.Vector3 val_4 = val_3.EvalPosition(t:  0f);
                frame.Position.x = val_4.x;
                frame.Position.y = val_4.y;
                frame.Position.z = val_4.z;
            }
            else
            {
                    UnityEngine.Vector3 val_5 = val_3.EvalPosition(t:  0f);
                frame.Position.x = val_5.x;
                frame.Position.y = val_5.y;
                frame.Position.z = val_5.z;
            }
            
            UnityEngine.Vector3 val_6 = val_3.EvalFirstDerivative(t:  0f);
            UnityEngine.Vector3 val_7 = val_3.EvalSecondDerivative(t:  0f);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(d:  Dest.Math.Vector3ex.Dot(vector:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, value:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}), a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(d:  Dest.Math.Vector3ex.Dot(vector:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, value:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}), a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            frame.Normal.x = val_12.x;
            frame.Normal.y = val_12.y;
            frame.Normal.z = val_12.z;
            frame.Tangent.x = val_6.x;
            frame.Tangent.y = val_6.y;
            frame.Tangent.z = val_6.z;
            UnityEngine.Vector3 val_13 = Dest.Math.Vector3ex.Cross(vector:  new UnityEngine.Vector3() {x = frame.Tangent.x, y = frame.Tangent.y, z = frame.Tangent.z}, value:  new UnityEngine.Vector3() {x = frame.Normal.x, y = frame.Normal.y, z = frame.Normal.z});
            frame.Binormal.x = val_13.x;
            frame.Binormal.y = val_13.y;
            frame.Binormal.z = val_13.z;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float EvalCurvature(float time)
        {
            this.GetSegmentIndexAndTime(time:  time, segmentIndex: out  0, segmentTime: out  float val_2 = 1.33046E+34f);
            ItemData val_3 = this._data.Item[0];
            UnityEngine.Vector3 val_4 = val_3.EvalFirstDerivative(t:  0f);
            if(val_4.x < (1E-05f))
            {
                    return (float)val_7;
            }
            
            UnityEngine.Vector3 val_5 = val_3.EvalSecondDerivative(t:  0f);
            UnityEngine.Vector3 val_6 = Dest.Math.Vector3ex.Cross(vector:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, value:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            float val_7 = val_4.x;
            val_7 = val_6.x / val_7;
            return (float)val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float EvalTorsion(float time)
        {
            float val_9;
            float val_10;
            float val_11;
            this.GetSegmentIndexAndTime(time:  time, segmentIndex: out  0, segmentTime: out  float val_2 = 1.346353E+34f);
            ItemData val_3 = this._data.Item[0];
            val_9 = 0f;
            UnityEngine.Vector3 val_4 = val_3.EvalFirstDerivative(t:  val_9);
            val_10 = val_4.y;
            UnityEngine.Vector3 val_5 = val_3.EvalSecondDerivative(t:  val_9);
            val_11 = val_5.x;
            UnityEngine.Vector3 val_6 = Dest.Math.Vector3ex.Cross(vector:  new UnityEngine.Vector3() {x = val_4.x, y = val_10, z = val_4.z}, value:  new UnityEngine.Vector3() {x = val_11, y = val_5.y, z = val_5.z});
            if(val_6.x < (1E-05f))
            {
                    return (float)val_8;
            }
            
            UnityEngine.Vector3 val_7 = val_3.EvalThirdDerivative(t:  val_9);
            val_11 = val_6.z;
            val_9 = val_7.x;
            val_10 = val_7.y;
            float val_8 = Dest.Math.Vector3ex.Dot(vector:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_11}, value:  new UnityEngine.Vector3() {x = val_9, y = val_10, z = val_7.z});
            val_8 = val_8 / val_6.x;
            return (float)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 EvalPositionParametrized(float length)
        {
            this.GetSegmentIndexAndTime(time:  this._parametrization.GetApproximateTimeParameter(s:  length), segmentIndex: out  0, segmentTime: out  float val_3 = 1.362759E+34f);
            UnityEngine.Vector3 val_5 = this._data.Item[0].EvalPosition(t:  0f);
            return new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 EvalTangentParametrized(float length)
        {
            this.GetSegmentIndexAndTime(time:  this._parametrization.GetApproximateTimeParameter(s:  length), segmentIndex: out  0, segmentTime: out  float val_3 = 1.379666E+34f);
            UnityEngine.Vector3 val_5 = this._data.Item[0].EvalTangent(t:  0f);
            return new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Dest.Math.PositionTangent EvalPositionTangentParametrized(float length)
        {
            Dest.Math.PositionTangent val_0;
            this.GetSegmentIndexAndTime(time:  this._parametrization.GetApproximateTimeParameter(s:  length), segmentIndex: out  0, segmentTime: out  float val_3 = 1.397069E+34f);
            ItemData val_4 = this._data.Item[0];
            UnityEngine.Vector3 val_5 = val_4.EvalPosition(t:  0f);
            UnityEngine.Vector3 val_6 = val_4.EvalTangent(t:  0f);
            val_0.Position.x = val_5.x;
            val_0.Position.y = val_5.y;
            val_0.Position.z = val_5.z;
            val_0.Tangent.x = val_6.x;
            val_0.Tangent.y = val_6.y;
            val_0.Tangent.z = val_6.z;
            return val_0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void EvalPositionParametrized(float length, out UnityEngine.Vector3 position)
        {
            this.GetSegmentIndexAndTime(time:  this._parametrization.GetApproximateTimeParameter(s:  length), segmentIndex: out  0, segmentTime: out  float val_3 = 1.41497E+34f);
            UnityEngine.Vector3 val_5 = this._data.Item[0].EvalPosition(t:  0f);
            position.x = val_5.x;
            position.y = val_5.y;
            position.z = val_5.z;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void EvalTangentParametrized(float length, out UnityEngine.Vector3 tangent)
        {
            this.GetSegmentIndexAndTime(time:  this._parametrization.GetApproximateTimeParameter(s:  length), segmentIndex: out  0, segmentTime: out  float val_3 = 1.43288E+34f);
            UnityEngine.Vector3 val_5 = this._data.Item[0].EvalTangent(t:  0f);
            tangent.x = val_5.x;
            tangent.y = val_5.y;
            tangent.z = val_5.z;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void EvalPositionTangentParametrized(float length, out Dest.Math.PositionTangent positionTangent)
        {
            this.GetSegmentIndexAndTime(time:  this._parametrization.GetApproximateTimeParameter(s:  length), segmentIndex: out  0, segmentTime: out  float val_3 = 1.450791E+34f);
            ItemData val_4 = this._data.Item[0];
            if(val_4 != null)
            {
                    UnityEngine.Vector3 val_5 = val_4.EvalPosition(t:  0f);
                positionTangent.Position.x = val_5.x;
                positionTangent.Position.y = val_5.y;
                positionTangent.Position.z = val_5.z;
            }
            else
            {
                    UnityEngine.Vector3 val_6 = val_4.EvalPosition(t:  0f);
                positionTangent.Position.x = val_6.x;
                positionTangent.Position.y = val_6.y;
                positionTangent.Position.z = val_6.z;
            }
            
            UnityEngine.Vector3 val_7 = val_4.EvalTangent(t:  0f);
            positionTangent.Tangent.x = val_7.x;
            positionTangent.Tangent.y = val_7.y;
            positionTangent.Tangent.z = val_7.z;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void EvalFrameParametrized(float length, out Dest.Math.CurveFrame frame)
        {
            this.GetSegmentIndexAndTime(time:  this._parametrization.GetApproximateTimeParameter(s:  length), segmentIndex: out  0, segmentTime: out  float val_3 = 1.468713E+34f);
            ItemData val_4 = this._data.Item[0];
            if(val_4 != null)
            {
                    UnityEngine.Vector3 val_5 = val_4.EvalPosition(t:  0f);
                frame.Position.x = val_5.x;
                frame.Position.y = val_5.y;
                frame.Position.z = val_5.z;
            }
            else
            {
                    UnityEngine.Vector3 val_6 = val_4.EvalPosition(t:  0f);
                frame.Position.x = val_6.x;
                frame.Position.y = val_6.y;
                frame.Position.z = val_6.z;
            }
            
            UnityEngine.Vector3 val_7 = val_4.EvalFirstDerivative(t:  0f);
            UnityEngine.Vector3 val_8 = val_4.EvalSecondDerivative(t:  0f);
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(d:  Dest.Math.Vector3ex.Dot(vector:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, value:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}), a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(d:  Dest.Math.Vector3ex.Dot(vector:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, value:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}), a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            frame.Normal.x = val_13.x;
            frame.Normal.y = val_13.y;
            frame.Normal.z = val_13.z;
            frame.Tangent.x = val_7.x;
            frame.Tangent.y = val_7.y;
            frame.Tangent.z = val_7.z;
            UnityEngine.Vector3 val_14 = Dest.Math.Vector3ex.Cross(vector:  new UnityEngine.Vector3() {x = frame.Tangent.x, y = frame.Tangent.y, z = frame.Tangent.z}, value:  new UnityEngine.Vector3() {x = frame.Normal.x, y = frame.Normal.y, z = frame.Normal.z});
            frame.Binormal.x = val_14.x;
            frame.Binormal.y = val_14.y;
            frame.Binormal.z = val_14.z;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float EvalCurvatureParametrized(float length)
        {
            this.GetSegmentIndexAndTime(time:  this._parametrization.GetApproximateTimeParameter(s:  length), segmentIndex: out  0, segmentTime: out  float val_3 = 1.486123E+34f);
            ItemData val_4 = this._data.Item[0];
            UnityEngine.Vector3 val_5 = val_4.EvalFirstDerivative(t:  0f);
            if(val_5.x < (1E-05f))
            {
                    return (float)val_8;
            }
            
            UnityEngine.Vector3 val_6 = val_4.EvalSecondDerivative(t:  0f);
            UnityEngine.Vector3 val_7 = Dest.Math.Vector3ex.Cross(vector:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, value:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            float val_8 = val_5.x;
            val_8 = val_7.x / val_8;
            return (float)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float EvalTorsionParametrized(float length)
        {
            float val_10;
            float val_11;
            float val_12;
            this.GetSegmentIndexAndTime(time:  this._parametrization.GetApproximateTimeParameter(s:  length), segmentIndex: out  0, segmentTime: out  float val_3 = 1.503031E+34f);
            ItemData val_4 = this._data.Item[0];
            val_10 = 0f;
            UnityEngine.Vector3 val_5 = val_4.EvalFirstDerivative(t:  val_10);
            val_11 = val_5.y;
            UnityEngine.Vector3 val_6 = val_4.EvalSecondDerivative(t:  val_10);
            val_12 = val_6.x;
            UnityEngine.Vector3 val_7 = Dest.Math.Vector3ex.Cross(vector:  new UnityEngine.Vector3() {x = val_5.x, y = val_11, z = val_5.z}, value:  new UnityEngine.Vector3() {x = val_12, y = val_6.y, z = val_6.z});
            if(val_7.x < (1E-05f))
            {
                    return (float)val_9;
            }
            
            UnityEngine.Vector3 val_8 = val_4.EvalThirdDerivative(t:  val_10);
            val_12 = val_7.z;
            val_10 = val_8.x;
            val_11 = val_8.y;
            float val_9 = Dest.Math.Vector3ex.Dot(vector:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_12}, value:  new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_8.z});
            val_9 = val_9 / val_7.x;
            return (float)val_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float CalcTotalLength()
        {
            if(this._data.Count < 2)
            {
                    return (float)val_4.AccumulatedLength;
            }
            
            this.RecalcSegmentsLength();
            this = this._data.Item[this.SegmentCount - 1];
            return (float)val_4.AccumulatedLength;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float LengthToTime(float length, int iterations, float tolerance)
        {
            float val_16;
            var val_17;
            float val_18;
            System.Collections.Generic.List<ItemData> val_19;
            float val_20;
            float val_22;
            float val_23;
            val_16 = length;
            val_17 = this;
            val_18 = 0f;
            if(this._data.Count < 2)
            {
                    return (float)val_18;
            }
            
            this.RecalcSegmentsLength();
            int val_2 = this.SegmentCount;
            if(val_16 <= 0f)
            {
                    return (float)val_18;
            }
            
            val_19 = this._data;
            ItemData val_4 = val_19.Item[val_2 - 1];
            if(val_4.AccumulatedLength <= val_16)
            {
                goto label_6;
            }
            
            if(val_2 < 1)
            {
                goto label_7;
            }
            
            val_19 = 0;
            label_11:
            ItemData val_5 = this._data.Item[0];
            if(val_5.AccumulatedLength > val_16)
            {
                goto label_12;
            }
            
            val_19 = val_19 + 1;
            if(val_19 < val_2)
            {
                goto label_11;
            }
            
            goto label_12;
            label_6:
            val_18 = 1f;
            return (float)val_18;
            label_7:
            val_19 = 0;
            label_12:
            ItemData val_6 = this._data.Item[0];
            if(val_19 != 0)
            {
                    ItemData val_8 = this._data.Item[val_19 - 1];
                val_16 = val_16 - val_8.AccumulatedLength;
            }
            
            val_17 = this._data.Item[0];
            float val_10 = val_16 / val_9.Length;
            if(iterations < 1)
            {
                goto label_20;
            }
            
            val_19 = 1152921504840978432;
            val_17 = 0;
            val_20 = 0f;
            label_30:
            float val_12 = (val_6.EvalLength(t0:  0f, t1:  val_10)) - val_16;
            if(System.Math.Abs(val_12) <= tolerance)
            {
                goto label_24;
            }
            
            float val_13 = val_6.EvalSpeed(t:  val_10);
            val_13 = val_12 / val_13;
            val_22 = val_10 - val_13;
            if(val_12 <= 0f)
            {
                goto label_26;
            }
            
            if(val_22 > val_20)
            {
                goto label_28;
            }
            
            val_22 = (val_20 + val_10) * 0.5f;
            goto label_28;
            label_26:
            if(val_22 >= 1f)
            {
                    val_22 = (1f + val_10) * 0.5f;
            }
            
            val_20 = val_10;
            label_28:
            val_17 = val_17 + 1;
            if(val_17 < iterations)
            {
                goto label_30;
            }
            
            goto label_31;
            label_20:
            val_22 = val_10;
            label_31:
            val_23 = val_22 + 0f;
            goto label_32;
            label_24:
            val_23 = val_10 + 0f;
            label_32:
            val_18 = val_23 / (float)val_2;
            return (float)val_18;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float LengthToTime(float length)
        {
            return this.LengthToTime(length:  length, iterations:  32, tolerance:  1E-05f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ParametrizeByArcLength(int pointCount)
        {
            ArcLengthParametrization val_16;
            float val_18;
            float val_19;
            int val_20;
            int val_21;
            int val_22;
            float val_23;
            int val_24;
            val_16 = pointCount;
            if(this.Valid == false)
            {
                goto label_1;
            }
            
            int val_3 = val_16 + 1;
            val_18 = this.CalcTotalLength();
            float[] val_4 = new float[0];
            float[] val_5 = new float[0];
            float[] val_6 = new float[0];
            val_4[0] = 0f;
            val_5[0] = 0f;
            val_6[0] = 0f;
            if(val_16 >= 2)
            {
                    do
            {
                var val_8 = 9 - 8;
                float val_9 = (val_18 / (float)val_16) * (float)val_8;
                mem2[0] = val_9;
                val_19 = this.LengthToTime(length:  val_9, iterations:  32, tolerance:  1E-05f);
                mem2[0] = val_19;
                val_20 = val_5.Length;
                if(val_8 >= val_20)
            {
                    val_20 = val_5.Length;
            }
            
                val_8 = val_8 - 1;
                val_21 = val_4.Length;
                val_8 = val_8 + 1;
                if(val_8 >= val_21)
            {
                    val_21 = val_4.Length;
            }
            
                val_8 = val_8 - 1;
                val_8 = val_8 + 1;
                val_6[1] = (null - null) / (null - null);
                var val_15 = 9 + 1;
            }
            while((val_8 + 1) != val_16);
            
            }
            
            val_4[(long)val_16] = val_18;
            val_5[(long)val_16] = 1f;
            val_22 = val_5.Length;
            if(val_22 <= val_16)
            {
                goto label_19;
            }
            
            val_23 = 1f;
            goto label_20;
            label_1:
            val_18 = -1f;
            return val_18;
            label_19:
            val_23 = mem[val_5[(long)(int)(pointCount)] + 32];
            val_23 = val_5[(long)(int)(pointCount)] + 32;
            val_22 = val_5.Length;
            label_20:
            val_24 = val_4.Length;
            if(val_24 <= val_16)
            {
                    val_24 = val_4.Length;
            }
            
            float val_20 = val_4[(long)val_16 - 1];
            val_20 = (val_4[(long)(int)(pointCount)] + 32) - val_20;
            val_23 = (val_23 - (val_5[(long)val_16 - 1])) / val_20;
            val_6[(long)val_16] = val_23;
            SplineBase.ArcLengthParametrization val_18 = null;
            val_16 = val_18;
            val_18 = new SplineBase.ArcLengthParametrization();
            if(val_16 != null)
            {
                    .sSample = val_4;
                .tSample = val_5;
                .tsSlope = val_6;
            }
            else
            {
                    mem[16] = val_4;
                mem[24] = val_5;
                mem[32] = val_6;
            }
            
            .L = val_18;
            this._parametrization = val_16;
            return val_18;
        }
    
    }

}
