using UnityEngine;

namespace Mapbox.Unity.Location
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class AngleSmoothingAbstractBase : MonoBehaviour, IAngleSmoothing
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int _measurements;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Mapbox.Utils.CircularBuffer<double> _angles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected readonly double DEG2RAD;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected readonly double RAD2DEG;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AngleSmoothingAbstractBase()
        {
            this._measurements = 5;
            this.DEG2RAD = ;
            this.RAD2DEG = 57.2957795130823;
            this._angles = new Mapbox.Utils.CircularBuffer<System.Double>(capacity:  this._measurements);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Add(double angle)
        {
            float val_1;
            double val_2;
            val_1 = angle;
            val_2 = 360;
            if(val_1 < 0)
            {
                goto label_1;
            }
            
            if(val_1 < val_2)
            {
                goto label_2;
            }
            
            val_2 = -360;
            label_1:
            val_1 = val_1 + val_2;
            label_2:
            this._angles.Add(item:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract double Calculate(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void debugLogAngle(double raw, double smoothed)
        {
            double val_1 = this.DEG2RAD * smoothed;
            double val_3 = this.DEG2RAD;
            val_3 = val_3 * smoothed;
            UnityEngine.Debug.Log(message:  System.String.Format(format:  "{0:0.000} => {1:0.000}", arg0:  raw, arg1:  smoothed));
        }
    
    }

}
