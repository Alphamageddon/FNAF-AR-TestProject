using UnityEngine;

namespace Dest.Math
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class WeightedSampler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected float[] _accum;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected float _total;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Dest.Math.Rand _rand;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected WeightedSampler(Dest.Math.Rand rand)
        {
            this._rand = rand;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected static int BinarySearch(float[] array, float value)
        {
            var val_6 = 0;
            int val_1 = array.Length - 1;
            if((val_1 & 2147483648) == 0)
            {
                goto label_4;
            }
            
            return (int)val_6;
            label_8:
            if(>=0)
            {
                goto label_3;
            }
            
            val_6 = W22 + 1;
            label_6:
            if(val_1 >= val_6)
            {
                goto label_4;
            }
            
            return (int)val_6;
            label_3:
            var val_2 = W22 - 1;
            goto label_6;
            label_4:
            var val_4 = val_6 + ((val_1 - val_6) >> 1);
            if(array[(long)val_4] != value)
            {
                goto label_8;
            }
            
            val_6 = val_4;
            return (int)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WeightedSampler(float[] weights)
        {
            null = null;
            this._rand = Dest.Math.Rand.Instance;
            this.Init(weights:  weights);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WeightedSampler(float[] weights, Dest.Math.Rand rand)
        {
            val_1 = new System.Object();
            this._rand = val_1;
            this.Init(weights:  weights);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void Init(float[] weights)
        {
            var val_4;
            float[] val_1 = new float[0];
            this._accum = val_1;
            val_1[0] = weights[0];
            val_4 = 0;
            goto label_6;
            label_11:
            var val_2 = W24 - 1;
            float val_6 = val_1[0];
            val_2 = val_2 + 1;
            val_6 = val_6 + weights[(long)(long)(int)(W24)];
            val_4 = 1;
            val_1[(long)(long)(int)(W24)] = val_6;
            label_6:
            if((val_4 + 1) < weights.Length)
            {
                goto label_11;
            }
            
            var val_8 = -4294967296;
            val_8 = val_8 + ((this._accum.Length) << 32);
            this._total = this._accum[val_8 >> 32];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int SampleIndex()
        {
            return Dest.Math.WeightedSampler.BinarySearch(array:  this._accum, value:  this._rand.NextFloat(min:  0f, max:  this._total));
        }
    
    }

}
