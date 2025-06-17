using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_RandomDistribution : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3[] _points;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _previous;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ToggleToGenerate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Count;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int IntMin;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int IntMax;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector2 Scale;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            bool val_3 = this.ToggleToGenerate;
            if(((val_3 == true) ? 1 : 0) != ((this._previous == true) ? 1 : 0))
            {
                    this.Generate();
                val_3 = this.ToggleToGenerate;
            }
            
            this._previous = val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Generate()
        {
            var val_8;
            int val_9;
            UnityEngine.Vector3[] val_10;
            int val_1 = this.IntMax - this.IntMin;
            this._points = new UnityEngine.Vector3[0];
            int[] val_3 = new int[0];
            if(this.Count >= 1)
            {
                    do
            {
                val_8 = null;
                val_8 = null;
                val_9 = this.IntMin;
                int val_5 = (Dest.Math.Rand.Instance.NextInt(min:  this.IntMin, max:  this.IntMax)) - val_9;
                int val_8 = val_3[((long)(int)((val_4 - this.IntMin))) << 2];
                val_10 = 0 + 1;
                val_8 = val_8 + 1;
                val_3[((long)(int)((val_4 - this.IntMin))) << 2] = val_8;
            }
            while(val_10 < this.Count);
            
            }
            
            if(val_1 < 1)
            {
                    return;
            }
            
            var val_10 = 0;
            do
            {
                val_10 = this._points;
                float val_9 = (float)0 + this.IntMin;
                float val_7 = S1 * (1.152922E+18f);
                val_9 = this.Scale * val_9;
                val_7 = val_7 / (float)this.Count;
                val_9 = 0 + 1;
                val_10 = val_10 + 12;
                val_10[val_10] = 0;
                val_10[val_10] = 0;
                val_10[val_10] = 0;
            }
            while(val_1 != val_9);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            var val_2;
            if(this._points == null)
            {
                    return;
            }
            
            this.DrawPoint(position:  new UnityEngine.Vector3() {x = this._points[0], y = this._points[0], z = this._points[0]});
            val_2 = 1;
            goto label_2;
            label_10:
            var val_1 = this._points + ((long)(long)(int)(W22) * 12);
            this.DrawSegment(p0:  new UnityEngine.Vector3() {x = ((long)(int)(W22) * 12) + this._points + 32, y = ((long)(int)(W22) * 12) + this._points + 32 + 4, z = ((long)(int)(W22) * 12) + this._points + 40}, p1:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 5.142877E-39f});
            var val_2 = this._points + (1 * 12);
            this.DrawPoint(position:  new UnityEngine.Vector3() {x = (1 * 12) + this._points + 32, y = (1 * 12) + this._points + 32 + 4, z = (1 * 12) + this._points + 40});
            val_2 = 2;
            label_2:
            int val_7 = this._points.Length;
            val_7 = val_7 - 1;
            if((val_2 - 1) < val_7)
            {
                goto label_10;
            }
            
            int val_8 = this.IntMax;
            val_8 = val_8 - 1;
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_RandomDistribution()
        {
        
        }
    
    }

}
