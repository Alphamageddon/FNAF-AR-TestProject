using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_Random2D : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _previous;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Dest.Math.Tests.Test_Random2D.Types _lastGenType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2[][] _arrays;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ToggleToGenerate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Dest.Math.Tests.Test_Random2D.Types GenType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int[] Counts;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector2[] Offsets;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float SquareSide;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float CircleRadius;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float CircleRadiusMin;
        
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
            var val_18;
            UnityEngine.Vector2 val_19;
            int val_20;
            var val_21;
            float val_22;
            UnityEngine.Vector2[][] val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            this._arrays = new UnityEngine.Vector2[][0];
            if(this.GenType > 4)
            {
                goto label_102;
            }
            
            var val_17 = 52952312 + (this.GenType) << 2;
            val_17 = val_17 + 52952312;
            goto (52952312 + (this.GenType) << 2 + 52952312);
            label_26:
            int val_18 = this.Counts[0];
            UnityEngine.Vector2[] val_2 = new UnityEngine.Vector2[0];
            val_19 = this.Offsets[0];
            val_20 = this.Counts[0];
            if(val_20 >= 1)
            {
                    var val_20 = 0;
                do
            {
                val_21 = null;
                val_21 = null;
                UnityEngine.Vector2 val_3 = Dest.Math.Rand.Instance.InSquare(side:  this.SquareSide);
                UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, b:  new UnityEngine.Vector2() {x = val_19, y = this.Offsets[0]});
                val_22 = val_4.x;
                val_20 = val_20 + 1;
                mem2[0] = val_22;
                mem2[0] = val_4.y;
            }
            while(val_20 != val_20);
            
            }
            
            val_24 = this._arrays;
            if(val_24 == null)
            {
                goto label_19;
            }
            
            if(val_2 != null)
            {
                goto label_20;
            }
            
            goto label_23;
            label_19:
            if(val_2 == null)
            {
                goto label_23;
            }
            
            label_20:
            label_23:
            val_18 = 1;
            val_24[0] = val_2;
            if(val_18 < this.Counts.Length)
            {
                goto label_26;
            }
            
            goto label_102;
            label_51:
            int val_21 = this.Counts[0];
            UnityEngine.Vector2[] val_5 = new UnityEngine.Vector2[0];
            val_19 = this.Offsets[0];
            val_20 = this.Counts[0];
            if(val_20 >= 1)
            {
                    var val_23 = 0;
                do
            {
                val_26 = null;
                val_26 = null;
                UnityEngine.Vector2 val_6 = Dest.Math.Rand.Instance.OnSquare(side:  this.SquareSide);
                UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, b:  new UnityEngine.Vector2() {x = val_19, y = this.Offsets[0]});
                val_22 = val_7.x;
                val_23 = val_23 + 1;
                mem2[0] = val_22;
                mem2[0] = val_7.y;
            }
            while(val_20 != val_23);
            
            }
            
            val_24 = this._arrays;
            if(val_24 == null)
            {
                goto label_44;
            }
            
            if(val_5 != null)
            {
                goto label_45;
            }
            
            goto label_48;
            label_44:
            if(val_5 == null)
            {
                goto label_48;
            }
            
            label_45:
            label_48:
            val_25 = 1;
            val_24[0] = val_5;
            if(val_25 < this.Counts.Length)
            {
                goto label_51;
            }
            
            goto label_102;
            label_76:
            int val_24 = this.Counts[0];
            UnityEngine.Vector2[] val_8 = new UnityEngine.Vector2[0];
            val_19 = this.Offsets[0];
            val_20 = this.Counts[0];
            if(val_20 >= 1)
            {
                    var val_26 = 0;
                do
            {
                val_28 = null;
                val_28 = null;
                UnityEngine.Vector2 val_9 = Dest.Math.Rand.Instance.InCircle(radius:  this.CircleRadius);
                UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y}, b:  new UnityEngine.Vector2() {x = val_19, y = this.Offsets[0]});
                val_22 = val_10.x;
                val_26 = val_26 + 1;
                mem2[0] = val_22;
                mem2[0] = val_10.y;
            }
            while(val_20 != val_26);
            
            }
            
            val_24 = this._arrays;
            if(val_24 == null)
            {
                goto label_69;
            }
            
            if(val_8 != null)
            {
                goto label_70;
            }
            
            goto label_73;
            label_69:
            if(val_8 == null)
            {
                goto label_73;
            }
            
            label_70:
            label_73:
            val_27 = 1;
            val_24[0] = val_8;
            if(val_27 < this.Counts.Length)
            {
                goto label_76;
            }
            
            goto label_102;
            label_101:
            int val_27 = this.Counts[0];
            UnityEngine.Vector2[] val_11 = new UnityEngine.Vector2[0];
            val_19 = this.Offsets[0];
            val_20 = this.Counts[0];
            if(val_20 >= 1)
            {
                    var val_29 = 0;
                do
            {
                val_30 = null;
                val_30 = null;
                UnityEngine.Vector2 val_12 = Dest.Math.Rand.Instance.InCircle(radiusMin:  this.CircleRadiusMin, radiusMax:  this.CircleRadius);
                UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, b:  new UnityEngine.Vector2() {x = val_19, y = this.Offsets[0]});
                val_22 = val_13.x;
                val_29 = val_29 + 1;
                mem2[0] = val_22;
                mem2[0] = val_13.y;
            }
            while(val_20 != val_29);
            
            }
            
            val_24 = this._arrays;
            if(val_24 == null)
            {
                goto label_94;
            }
            
            if(val_11 != null)
            {
                goto label_95;
            }
            
            goto label_98;
            label_94:
            if(val_11 == null)
            {
                goto label_98;
            }
            
            label_95:
            label_98:
            val_29 = 1;
            val_24[0] = val_11;
            if(val_29 < this.Counts.Length)
            {
                goto label_101;
            }
            
            goto label_102;
            label_126:
            int val_30 = this.Counts[0];
            UnityEngine.Vector2[] val_14 = new UnityEngine.Vector2[0];
            val_19 = this.Offsets[0];
            val_20 = this.Counts[0];
            if(val_20 >= 1)
            {
                    var val_32 = 0;
                do
            {
                val_32 = null;
                val_32 = null;
                UnityEngine.Vector2 val_15 = Dest.Math.Rand.Instance.OnCircle(radius:  this.CircleRadius);
                UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y}, b:  new UnityEngine.Vector2() {x = val_19, y = this.Offsets[0]});
                val_22 = val_16.x;
                val_32 = val_32 + 1;
                mem2[0] = val_22;
                mem2[0] = val_16.y;
            }
            while(val_20 != val_32);
            
            }
            
            val_24 = this._arrays;
            if(val_24 == null)
            {
                goto label_119;
            }
            
            if(val_14 != null)
            {
                goto label_120;
            }
            
            goto label_123;
            label_119:
            if(val_14 == null)
            {
                goto label_123;
            }
            
            label_120:
            label_123:
            val_31 = 1;
            val_24[0] = val_14;
            if(val_31 < this.Counts.Length)
            {
                goto label_126;
            }
            
            label_102:
            this._lastGenType = this.GenType;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            if(this._arrays == null)
            {
                    return;
            }
            
            if(this._lastGenType > 4)
            {
                    return;
            }
            
            var val_4 = 52952332 + (this._lastGenType) << 2;
            val_4 = val_4 + 52952332;
            goto (52952332 + (this._lastGenType) << 2 + 52952332);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_Random2D()
        {
        
        }
    
    }

}
