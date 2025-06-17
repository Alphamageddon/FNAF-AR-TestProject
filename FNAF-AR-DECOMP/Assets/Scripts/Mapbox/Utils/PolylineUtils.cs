using UnityEngine;

namespace Mapbox.Utils
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class PolylineUtils
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Collections.Generic.List<Mapbox.Utils.Vector2d> Decode(string encodedPath, int precision = 5)
        {
            int val_1 = encodedPath.Length;
            System.Collections.Generic.List<Mapbox.Utils.Vector2d> val_2 = new System.Collections.Generic.List<Mapbox.Utils.Vector2d>();
            if(val_1 < 1)
            {
                    return val_2;
            }
            
            var val_20 = 0;
            var val_21 = 0;
            do
            {
                var val_16 = 0;
                var val_15 = 1;
                do
            {
                int val_3 = 0 + 1;
                char val_5 = encodedPath.Chars[0] & 65535;
                val_5 = (val_5 - 64) << (val_16 & 31);
                val_15 = val_5 + val_15;
                val_16 = val_16 + 5;
            }
            while(val_5 > '^');
            
                var val_18 = 0;
                val_15 = ((int)(val_15 >> 0) & 1) ^ (val_15 >> 1);
                var val_17 = 1;
                do
            {
                char val_10 = encodedPath.Chars[val_3] & 65535;
                val_10 = (val_10 - 64) << (val_18 & 31);
                val_17 = val_10 + val_17;
                val_18 = val_18 + 5;
            }
            while(val_10 > '^');
            
                var val_19 = (int)(val_17 >> 0) & 1;
                val_19 = val_19 ^ (val_17 >> 1);
                val_20 = val_15 + val_20;
                val_21 = val_19 + val_21;
                val_2.Add(item:  new Mapbox.Utils.Vector2d() {x = (double)val_20 / 10, y = (double)val_21 / 10});
            }
            while((val_3 + 1) < val_1);
            
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string Encode(System.Collections.Generic.List<Mapbox.Utils.Vector2d> path, int precision = 5)
        {
            float val_3;
            float val_19;
            long val_20;
            var val_21;
            float val_23;
            long val_24;
            var val_25;
            var val_27;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            List.Enumerator<T> val_2 = path.GetEnumerator();
            label_19:
            if(((-1854026192) & 1) == 0)
            {
                goto label_4;
            }
            
            Mapbox.Utils.Vector2d val_5 = val_3.Min;
            double val_15 = val_5.x;
            double val_16 = val_5.y;
            val_15 = 10 * val_15;
            if(val_15 >= 0f)
            {
                goto label_7;
            }
            
            if(val_15 != (-0.5))
            {
                goto label_8;
            }
            
            val_19 = val_3;
            val_20 = (long)val_19;
            val_21 = val_19 + (-1);
            goto label_9;
            label_7:
            if(val_15 != 0.5)
            {
                goto label_10;
            }
            
            val_19 = val_3;
            val_20 = (long)val_19;
            val_21 = val_19 + 1;
            label_9:
            val_19 = ((val_20 & 1) != 0) ? (val_19) : (val_21);
            goto label_12;
            label_8:
            double val_6 = val_15 + (-0.5);
            goto label_12;
            label_10:
            label_12:
            val_16 = 10 * val_16;
            if(val_16 >= 0f)
            {
                goto label_13;
            }
            
            if(val_16 != (-0.5))
            {
                goto label_14;
            }
            
            val_23 = val_3;
            val_24 = (long)val_23;
            val_25 = val_23 + (-1);
            goto label_15;
            label_13:
            if(val_16 != 0.5)
            {
                goto label_16;
            }
            
            val_23 = val_3;
            val_24 = (long)val_23;
            val_25 = val_23 + 1;
            label_15:
            var val_8 = ((val_24 & 1) != 0) ? (val_23) : (val_25);
            goto label_18;
            label_14:
            double val_9 = val_16 + (-0.5);
            goto label_18;
            label_16:
            double val_10 = val_16 + 0.5;
            label_18:
            Mapbox.Utils.PolylineUtils.Encode(variable:  ((long)val_15 + 0.5) - 0, result:  val_1);
            Mapbox.Utils.PolylineUtils.Encode(variable:  (long)val_16 - 0, result:  val_1);
            goto label_19;
            label_4:
            val_27 = public System.Void List.Enumerator<Mapbox.Utils.Vector2d>::Dispose();
            if(val_1 != null)
            {
                    return (string)val_1;
            }
            
            return (string)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void Encode(long variable, System.Text.StringBuilder result)
        {
            var val_6 = (variable << 1) ^ (variable >> 63);
            goto label_0;
            label_2:
            System.Text.StringBuilder val_2 = result.Append(value:  '_');
            val_6 = val_6 >> 5;
            label_0:
            if(val_6 > 31)
            {
                goto label_2;
            }
            
            System.Text.StringBuilder val_4 = result.Append(value:  val_6 + 63);
        }
    
    }

}
