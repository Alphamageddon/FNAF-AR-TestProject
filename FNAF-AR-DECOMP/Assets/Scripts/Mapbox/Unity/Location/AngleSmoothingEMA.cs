using UnityEngine;

namespace Mapbox.Unity.Location
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AngleSmoothingEMA : AngleSmoothingAbstractBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double _alpha;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AngleSmoothingEMA()
        {
            double val_2 = (double)W8 + 1;
            val_2 = 2 / val_2;
            this._alpha = val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override double Calculate()
        {
            float val_6;
            float val_7;
            TSource[] val_2 = System.Linq.Enumerable.ToArray<System.Double>(source:  System.Linq.Enumerable.Reverse<System.Double>(source:  3366));
            val_6 = val_2[0] * D9;
            TSource val_8 = val_2[0];
            val_8 = val_8 * D1;
            val_7 = val_8;
            if(val_2.Length >= 2)
            {
                    do
            {
                TSource val_9 = val_2[1];
                double val_4 = val_9 * D11;
                val_4 = val_4 - val_6;
                val_9 = val_4 * this._alpha;
                float val_10 = val_2[0x1] + 32;
                val_6 = val_6 + val_9;
                val_10 = val_10 * this._alpha;
                val_10 = val_10 - val_7;
                val_10 = val_10 * this._alpha;
                val_7 = val_7 + val_10;
            }
            while((1 + 1) < val_2.Length);
            
            }
            
            float val_11 = val_6;
            val_11 = val_11 * val_7;
            double val_6 = System.Math.Round(value:  val_11, digits:  2);
            if(val_6 < 0)
            {
                    val_6 = val_6 + 360;
                return (double)val_6;
            }
            
            double val_12 = -360;
            val_12 = val_6 + val_12;
            val_6 = (val_6 >= 360) ? (val_12) : (val_6);
            return (double)val_6;
        }
    
    }

}
