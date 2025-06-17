using UnityEngine;

namespace Mapbox.CheapRulerCs
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CheapRuler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double _kx;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double _ky;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CheapRuler(double latitude, Mapbox.CheapRulerCs.CheapRulerUnits outputUnits = 0)
        {
            double val_4;
            if((outputUnits - 1) <= 5)
            {
                    val_4 = mem[52949536 + ((outputUnits - 1)) << 3];
                val_4 = 52949536 + ((outputUnits - 1)) << 3;
            }
            else
            {
                    val_4 = 1;
            }
            
            double val_4 = 3.14159265358979;
            double val_5 = 180;
            val_4 = latitude * val_4;
            val_4 = val_4 / val_5;
            val_5 = val_4 + val_4;
            double val_6 = -1;
            double val_8 = -0.09455;
            double val_2 = val_4 * val_5;
            double val_7 = -0.56605;
            val_6 = val_2 + val_6;
            val_2 = val_5 * val_6;
            val_2 = val_2 - val_4;
            val_4 = val_4 * 111.41513;
            val_7 = val_6 * val_7;
            val_6 = (val_5 * val_2) - val_6;
            double val_9 = 111.13209;
            val_8 = val_2 * val_8;
            val_4 = val_4 + val_8;
            val_9 = val_7 + val_9;
            val_5 = val_5 * val_6;
            val_5 = val_5 - val_2;
            val_6 = val_6 * 0.0012;
            val_5 = val_5 * 0.00012;
            val_6 = val_9 + val_6;
            val_4 = val_4 + val_5;
            val_6 = val_4 * val_6;
            val_4 = val_4 * val_4;
            this._kx = val_4;
            this._ky = val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.CheapRulerCs.CheapRuler FromTile(int y, int z, Mapbox.CheapRulerCs.CheapRulerUnits units = 0)
        {
            double val_5 = 1;
            double val_4 = (double)y;
            val_4 = val_4 + 0.5;
            val_4 = val_4 * (-2);
            val_5 = val_4 / val_5;
            double val_1 = val_5 + 1;
            val_5 = val_1 * 3.14159265358979;
            double val_2 = -(val_1 * 3.14159265358979);
            val_2 = val_5 - val_2;
            val_2 = val_2 * 0.5;
            Mapbox.CheapRulerCs.CheapRuler val_3 = null;
            double val_6 = 180;
            val_6 = val_2 * val_6;
            val_6 = val_6 / 3.14159265358979;
            val_3 = new Mapbox.CheapRulerCs.CheapRuler(latitude:  val_6, outputUnits:  units);
            return val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double Distance(double[] a, double[] b)
        {
            double val_2 = a[0];
            double val_4 = a[1];
            double val_5 = b[1];
            double val_6 = this._ky;
            val_5 = val_4 - val_5;
            val_4 = val_5 * val_6;
            double val_1 = val_2 - b[0];
            val_2 = val_1 * this._kx;
            val_1 = val_2 * val_2;
            val_6 = val_4 * val_4;
            val_1 = val_1 + val_6;
            if(val_6 <= _TYPE_MAX_)
            {
                    return (double)val_6;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double Bearing(double[] a, double[] b)
        {
            double val_2 = b[0];
            val_2 = val_2 - a[0];
            val_2 = val_2 * this._kx;
            double val_5 = a[1];
            val_5 = b[1] - val_5;
            if(val_2 == 0f)
            {
                    if((val_5 * this._ky) == 0f)
            {
                    return (double)val_6;
            }
            
            }
            
            float val_6 = val_2;
            val_6 = val_6 * 180;
            val_6 = val_6 / 3.14159265358979;
            if(val_6 <= 180)
            {
                    return (double)val_6;
            }
            
            val_6 = val_6 + (-360);
            return (double)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double[] Destination(double[] p, double distance, double bearing)
        {
            double val_2 = bearing;
            double val_1 = 90;
            double val_4 = 3.14159265358979;
            double val_3 = 180;
            val_1 = val_1 - val_2;
            val_1 = val_1 * val_4;
            val_2 = val_1 / val_3;
            val_3 = val_2 * distance;
            val_4 = val_2 * distance;
            return this.offset(p:  p, dx:  val_3, dy:  val_4);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double[] offset(double[] p, double dx, double dy)
        {
            double val_6 = dy;
            double val_3 = dx;
            double[] val_1 = new double[2];
            dx = val_3 / this._kx;
            val_3 = p[0] + dx;
            val_1[0] = val_3;
            double val_5 = this._ky;
            val_5 = val_6 / val_5;
            val_6 = p[1] + val_5;
            val_1[1] = val_6;
            return (System.Double[])val_1;
        }
    
    }

}
