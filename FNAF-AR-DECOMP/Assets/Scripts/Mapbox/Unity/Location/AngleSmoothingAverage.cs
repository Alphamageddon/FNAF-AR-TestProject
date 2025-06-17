using UnityEngine;

namespace Mapbox.Unity.Location
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AngleSmoothingAverage : AngleSmoothingAbstractBase
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override double Calculate()
        {
            double val_8 = System.Linq.Enumerable.Sum<System.Double>(source:  static_value_04282000, selector:  new System.Func<System.Double, System.Double>(object:  this, method:  System.Double Mapbox.Unity.Location.AngleSmoothingAverage::<Calculate>b__0_0(double a)));
            val_8 = val_8 / (double)Count;
            double val_9 = (double)Count;
            val_9 = (System.Linq.Enumerable.Sum<System.Double>(source:  static_value_04282000, selector:  new System.Func<System.Double, System.Double>(object:  this, method:  System.Double Mapbox.Unity.Location.AngleSmoothingAverage::<Calculate>b__0_1(double a)))) / val_9;
            val_9 = val_9 * val_8;
            double val_7 = System.Math.Round(value:  val_9, digits:  2);
            if(val_7 < 0)
            {
                    val_7 = val_7 + 360;
                return (double)val_7;
            }
            
            double val_10 = -360;
            val_10 = val_7 + val_10;
            val_7 = (val_7 >= 360) ? (val_10) : (val_7);
            return (double)val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AngleSmoothingAverage()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double <Calculate>b__0_0(double a)
        {
            a = D9 * a;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double <Calculate>b__0_1(double a)
        {
            a = D9 * a;
        }
    
    }

}
