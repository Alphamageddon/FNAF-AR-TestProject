using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_Random3D : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _previous;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Dest.Math.Tests.Test_Random3D.Types _lastGenType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3[][] _arrays;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ToggleToGenerate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Dest.Math.Tests.Test_Random3D.Types GenType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int[] Counts;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3[] Offsets;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float CubeSide;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float SphereRadius;
        
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
            var val_15;
            var val_16;
            float val_17;
            float val_18;
            var val_19;
            float val_20;
            var val_21;
            UnityEngine.Vector3[][] val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            this._arrays = new UnityEngine.Vector3[][0];
            if(this.GenType > 3)
            {
                goto label_77;
            }
            
            var val_14 = 52952352 + (this.GenType) << 2;
            val_14 = val_14 + 52952352;
            goto (52952352 + (this.GenType) << 2 + 52952352);
            label_26:
            val_16 = 0;
            int val_15 = this.Counts[val_16];
            UnityEngine.Vector3[] val_2 = new UnityEngine.Vector3[0];
            var val_16 = 12;
            val_16 = this.Offsets + (val_16 * val_16);
            val_17 = mem[(val_16 * 12) + this.Offsets + 32];
            val_17 = (val_16 * 12) + this.Offsets + 32;
            val_18 = mem[(val_16 * 12) + this.Offsets + 40];
            val_18 = (val_16 * 12) + this.Offsets + 40;
            int val_17 = this.Counts[val_16];
            if(val_17 >= 1)
            {
                    do
            {
                val_19 = null;
                val_19 = null;
                UnityEngine.Vector3 val_3 = Dest.Math.Rand.Instance.InCube(side:  this.CubeSide);
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_17, y = (val_16 * 12) + this.Offsets + 32 + 4, z = val_18});
                val_20 = val_4.y;
                val_21 = 0 + 1;
                mem2[0] = val_4.x;
                mem2[0] = val_20;
                mem2[0] = val_4.z;
            }
            while(val_17 != val_21);
            
            }
            
            val_22 = this._arrays;
            if(val_22 == null)
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
            val_15 = 1;
            val_22[val_16] = val_2;
            if(val_15 < this.Counts.Length)
            {
                goto label_26;
            }
            
            goto label_77;
            label_51:
            val_16 = 0;
            int val_18 = this.Counts[val_16];
            UnityEngine.Vector3[] val_5 = new UnityEngine.Vector3[0];
            var val_19 = 12;
            val_19 = this.Offsets + (val_16 * val_19);
            val_17 = mem[(val_16 * 12) + this.Offsets + 32];
            val_17 = (val_16 * 12) + this.Offsets + 32;
            val_18 = mem[(val_16 * 12) + this.Offsets + 40];
            val_18 = (val_16 * 12) + this.Offsets + 40;
            int val_20 = this.Counts[val_16];
            if(val_20 >= 1)
            {
                    do
            {
                val_24 = null;
                val_24 = null;
                UnityEngine.Vector3 val_6 = Dest.Math.Rand.Instance.OnCube(side:  this.CubeSide);
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_17, y = (val_16 * 12) + this.Offsets + 32 + 4, z = val_18});
                val_20 = val_7.y;
                val_21 = 0 + 1;
                mem2[0] = val_7.x;
                mem2[0] = val_20;
                mem2[0] = val_7.z;
            }
            while(val_20 != val_21);
            
            }
            
            val_22 = this._arrays;
            if(val_22 == null)
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
            val_23 = 1;
            val_22[val_16] = val_5;
            if(val_23 < this.Counts.Length)
            {
                goto label_51;
            }
            
            goto label_77;
            label_76:
            val_16 = 0;
            int val_21 = this.Counts[val_16];
            UnityEngine.Vector3[] val_8 = new UnityEngine.Vector3[0];
            var val_22 = 12;
            val_22 = this.Offsets + (val_16 * val_22);
            val_17 = mem[(val_16 * 12) + this.Offsets + 32];
            val_17 = (val_16 * 12) + this.Offsets + 32;
            val_18 = mem[(val_16 * 12) + this.Offsets + 40];
            val_18 = (val_16 * 12) + this.Offsets + 40;
            int val_23 = this.Counts[val_16];
            if(val_23 >= 1)
            {
                    do
            {
                val_26 = null;
                val_26 = null;
                UnityEngine.Vector3 val_9 = Dest.Math.Rand.Instance.InSphere(radius:  this.SphereRadius);
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_17, y = (val_16 * 12) + this.Offsets + 32 + 4, z = val_18});
                val_20 = val_10.y;
                val_21 = 0 + 1;
                mem2[0] = val_10.x;
                mem2[0] = val_20;
                mem2[0] = val_10.z;
            }
            while(val_23 != val_21);
            
            }
            
            val_22 = this._arrays;
            if(val_22 == null)
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
            val_25 = 1;
            val_22[val_16] = val_8;
            if(val_25 < this.Counts.Length)
            {
                goto label_76;
            }
            
            goto label_77;
            label_101:
            val_16 = 0;
            int val_24 = this.Counts[val_16];
            UnityEngine.Vector3[] val_11 = new UnityEngine.Vector3[0];
            var val_25 = 12;
            val_25 = this.Offsets + (val_16 * val_25);
            val_17 = mem[(val_16 * 12) + this.Offsets + 32];
            val_17 = (val_16 * 12) + this.Offsets + 32;
            val_18 = mem[(val_16 * 12) + this.Offsets + 40];
            val_18 = (val_16 * 12) + this.Offsets + 40;
            int val_26 = this.Counts[val_16];
            if(val_26 >= 1)
            {
                    do
            {
                val_28 = null;
                val_28 = null;
                UnityEngine.Vector3 val_12 = Dest.Math.Rand.Instance.OnSphere(radius:  this.SphereRadius);
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_17, y = (val_16 * 12) + this.Offsets + 32 + 4, z = val_18});
                val_20 = val_13.y;
                val_21 = 0 + 1;
                mem2[0] = val_13.x;
                mem2[0] = val_20;
                mem2[0] = val_13.z;
            }
            while(val_26 != val_21);
            
            }
            
            val_22 = this._arrays;
            if(val_22 == null)
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
            val_27 = 1;
            val_22[val_16] = val_11;
            if(val_27 < this.Counts.Length)
            {
                goto label_101;
            }
            
            label_77:
            this._lastGenType = this.GenType;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            if(this._arrays == null)
            {
                    return;
            }
            
            if(this._lastGenType > 3)
            {
                    return;
            }
            
            var val_4 = 52952368 + (this._lastGenType) << 2;
            val_4 = val_4 + 52952368;
            goto (52952368 + (this._lastGenType) << 2 + 52952368);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_Random3D()
        {
        
        }
    
    }

}
