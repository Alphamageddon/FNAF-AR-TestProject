using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_ConcaveHull2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector2[] _points;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int[] _indicesConvex;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int[] _indicesConcave;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _previous;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ToggleToGenerate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Threshold;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GenerateRadius;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float CoeffX;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float CoeffY;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GenerateCountMin;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GenerateCountMax;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Dest.Math.Tests.Test_Vector2Array SourcePoints;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            var val_3;
            UnityEngine.Vector2 val_4;
            var val_5;
            if(this._points == null)
            {
                    return;
            }
            
            this.DrawPoints(points:  this._points, size:  0.11f);
            if(this._indicesConvex == null)
            {
                    return;
            }
            
            if(this._indicesConcave == null)
            {
                    return;
            }
            
            this.FiguresColor();
            val_3 = 1;
            goto label_3;
            label_13:
            val_4 = this._points[this._indicesConvex[(long)(long)(int)(W22)]];
            int val_1 = val_3 / this._indicesConvex.Length;
            val_1 = val_3 - (val_1 * this._indicesConvex.Length);
            0.DrawSegment(p0:  new UnityEngine.Vector2() {x = this._points[this._indicesConvex[(long)(long)(int)(W22)]], y = val_4}, p1:  new UnityEngine.Vector2() {x = this._points[this._indicesConvex[(long)val_1]], y = this._points[this._indicesConvex[(long)val_1]]});
            val_3 = 2;
            label_3:
            var val_2 = val_3 - 1;
            if(val_2 < this._indicesConvex.Length)
            {
                goto label_13;
            }
            
            0.ResultsColor();
            val_5 = 1;
            goto label_14;
            label_24:
            val_4 = this._points[this._indicesConcave[(long)val_2]];
            int val_3 = val_5 / this._indicesConcave.Length;
            val_3 = val_5 - (val_3 * this._indicesConcave.Length);
            0.DrawSegment(p0:  new UnityEngine.Vector2() {x = this._points[this._indicesConcave[(long)val_2]], y = val_4}, p1:  new UnityEngine.Vector2() {x = this._points[this._indicesConcave[(long)val_3]], y = this._points[this._indicesConcave[(long)val_3]]});
            val_5 = 2;
            label_14:
            if((val_5 - 1) < this._indicesConcave.Length)
            {
                goto label_24;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnGUI()
        {
            if((UnityEngine.GUILayout.Button(text:  "btn", options:  System.Array.Empty<UnityEngine.GUILayoutOption>())) == false)
            {
                    return;
            }
            
            bool val_5 = Dest.Math.ConcaveHull.Create2D(points:  this._points, concaveHull: out  this._indicesConcave, convexHull: out  this._indicesConvex, algorithmThreshold:  this.Threshold, epsilon:  1E-05f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            bool val_12;
            UnityEngine.Vector2[] val_13;
            val_12 = this.ToggleToGenerate;
            if(((val_12 == true) ? 1 : 0) != ((this._previous == true) ? 1 : 0))
            {
                    bool val_3 = UnityEngine.Object.op_Inequality(x:  this.SourcePoints, y:  0);
                if(val_3 != false)
            {
                    val_13 = this.SourcePoints.Array;
            }
            else
            {
                    UnityEngine.Vector2[] val_4 = val_3.GenerateMemoryRandomSet2D(setRadius:  this.GenerateRadius, countMin:  this.GenerateCountMin, countMax:  this.GenerateCountMax, coeffX:  this.CoeffX, coeffY:  this.CoeffY);
            }
            
                this._points = val_4;
                object[] val_9 = new object[6];
                val_9[0] = "Created: ";
                val_9[1] = Dest.Math.ConcaveHull.Create2D(points:  val_4, concaveHull: out  this._indicesConcave, convexHull: out  this._indicesConvex, algorithmThreshold:  this.Threshold, epsilon:  1E-05f).ToString();
                val_9[2] = "   ConvexIndexCount: ";
                val_9[3] = mem[this._indicesConvex] + 24;
                val_9[4] = "   ConcaveIndexCount: ";
                val_9[5] = mem[this._indicesConcave] + 24;
                Dest.Math.Logger.LogInfo(value:  +val_9);
                val_12 = this.ToggleToGenerate;
            }
            
            this._previous = val_12;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_ConcaveHull2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
