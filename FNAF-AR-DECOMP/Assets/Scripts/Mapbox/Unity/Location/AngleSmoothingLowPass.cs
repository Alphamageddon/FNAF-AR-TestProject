using UnityEngine;

namespace Mapbox.Unity.Location
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AngleSmoothingLowPass : AngleSmoothingAbstractBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double _smoothingFactor;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AngleSmoothingLowPass()
        {
            this._smoothingFactor = 0.5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AngleSmoothingLowPass(double smoothingFactor)
        {
            this._smoothingFactor = 0.5;
            this._smoothingFactor = smoothingFactor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override double Calculate()
        {
            float val_8;
            float val_9;
            TSource[] val_2 = System.Linq.Enumerable.ToArray<System.Double>(source:  System.Linq.Enumerable.Reverse<System.Double>(source:  3367));
            val_8 = val_2[0] * D9;
            TSource val_10 = val_2[0];
            val_10 = val_10 * D1;
            val_9 = val_10;
            if(val_2.Length >= 2)
            {
                    do
            {
                TSource val_11 = val_2[1];
                double val_4 = val_11 * D13;
                val_4 = this._smoothingFactor * val_4;
                double val_5 = 1 - this._smoothingFactor;
                val_5 = val_8 * val_5;
                val_8 = val_4 + val_5;
                double val_6 = val_11 * D1;
                double val_12 = this._smoothingFactor;
                val_6 = this._smoothingFactor * val_6;
                val_12 = 1 - val_12;
                val_12 = val_9 * val_12;
                val_9 = val_6 + val_12;
            }
            while((1 + 1) < val_2.Length);
            
            }
            
            float val_13 = val_8;
            val_13 = val_13 * val_9;
            double val_8 = System.Math.Round(value:  val_13, digits:  2);
            if(val_8 < 0)
            {
                    val_8 = val_8 + 360;
                return (double)val_8;
            }
            
            double val_14 = -360;
            val_14 = val_8 + val_14;
            val_8 = (val_8 >= 360) ? (val_14) : (val_8);
            return (double)val_8;
        }
    
    }

}
