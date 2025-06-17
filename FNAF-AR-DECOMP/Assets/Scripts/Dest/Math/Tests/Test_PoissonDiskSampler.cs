using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_PoissonDiskSampler : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2 _min;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2 _max;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2 _size;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _previous;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ToggleToGenerate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform QuadRegion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.ParticleSystem Particles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool UseDistanceMap;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float DistOuter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float DistInner;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Texture2D DistanceMap;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ParticleScale;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int MaxPoints;
        
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
        private float DistanceFactor(ref UnityEngine.Vector2 point)
        {
            float val_3 = point.x;
            float val_4 = point.y;
            val_3 = val_3 - this._min;
            val_4 = val_4 - S3;
            if(this.DistanceMap != null)
            {
                    return this.DistanceMap.GetPixelBilinear(x:  val_3 / this._size, y:  val_4 / S5);
            }
            
            return this.DistanceMap.GetPixelBilinear(x:  val_3 / this._size, y:  val_4 / S5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Generate()
        {
            var val_16;
            UnityEngine.Vector2 val_17;
            int val_18;
            UnityEngine.ParticleSystem val_19;
            UnityEngine.Vector3 val_1 = this.QuadRegion.localScale;
            UnityEngine.Vector2 val_2 = Dest.Math.Vector3ex.ToVector2XY(vector:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, d:  0.5f);
            this._max = val_3;
            mem[1152921519575246388] = val_3.y;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_UnaryNegation(a:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            this._min = val_4;
            mem[1152921519575246380] = val_4.y;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = this._max, y = val_4.y}, b:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            this._size = val_5;
            mem[1152921519575246396] = val_5.y;
            val_16 = null;
            val_16 = null;
            val_17 = this._min;
            Dest.Math.PoissonDiskSampler val_6 = new Dest.Math.PoissonDiskSampler(rand:  Dest.Math.Rand.Instance, minCorner:  new UnityEngine.Vector2() {x = val_17, y = val_2.y}, maxCorner:  new UnityEngine.Vector2() {x = this._max, y = V11.16B}, minDistanceOuter:  this.DistOuter, minDistanceInner:  this.DistInner);
            if(this.UseDistanceMap != false)
            {
                    PoissonDiskSampler.PointDelegate val_7 = new PoissonDiskSampler.PointDelegate(object:  this, method:  System.Single Dest.Math.Tests.Test_PoissonDiskSampler::DistanceFactor(ref UnityEngine.Vector2 point));
                if(val_6 != null)
            {
                    .DistanceFilter = val_7;
                val_18 = this.MaxPoints;
            }
            else
            {
                    mem[104] = val_7;
                val_18 = this.MaxPoints;
            }
            
                val_6.MaxPoints = val_18;
            }
            
            Dest.Math.Logger.LogInfo(value:  val_9.Length + " points were generated");
            Particle[] val_11 = new Particle[0];
            if(val_9.Length < 1)
            {
                goto label_16;
            }
            
            do
            {
                long val_19 = 0;
                val_17 = val_6.Sample().ToArray()[val_19];
                UnityEngine.Vector3 val_12 = Dest.Math.Vector2ex.ToVector3XY(vector:  new UnityEngine.Vector2() {x = val_6.Sample().ToArray()[val_19], y = val_17});
                UnityEngine.Color val_13 = UnityEngine.Color.blue;
                UnityEngine.Color32 val_14 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_13.r, g = val_13.g, b = val_13.b, a = val_13.a});
                byte val_15 = val_14.r & 4294967295;
                var val_17 = (val_11 + (val_19 * 124)) + 32;
                val_19 = val_19 + 1;
            }
            while(val_19 < val_9.Length);
            
            val_19 = this.Particles;
            if(val_19 != null)
            {
                goto label_27;
            }
            
            goto label_28;
            label_16:
            val_19 = this.Particles;
            if(val_11 == null)
            {
                goto label_25;
            }
            
            if(val_19 != null)
            {
                goto label_27;
            }
            
            label_28:
            label_27:
            val_19.SetParticles(particles:  val_11, size:  val_11.Length);
            return;
            label_25:
            if(val_19 != null)
            {
                goto label_27;
            }
            
            goto label_28;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_PoissonDiskSampler()
        {
        
        }
    
    }

}
