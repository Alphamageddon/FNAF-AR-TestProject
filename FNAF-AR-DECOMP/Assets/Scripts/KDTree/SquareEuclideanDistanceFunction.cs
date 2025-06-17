using UnityEngine;

namespace KDTree
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SquareEuclideanDistanceFunction : DistanceFunctions
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double Distance(double[] p1, double[] p2)
        {
            var val_1;
            float val_2;
            val_1 = 0;
            val_2 = 0;
            goto label_0;
            label_5:
            double val_2 = p2[0];
            val_1 = 1;
            val_2 = p1[0] - val_2;
            val_2 = val_2 * val_2;
            val_2 = val_2 + val_2;
            label_0:
            if(val_1 < p1.Length)
            {
                goto label_5;
            }
            
            return (double)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double DistanceToRectangle(double[] point, double[] min, double[] max)
        {
            var val_1;
            float val_2;
            float val_3;
            var val_4;
            float val_5;
            val_1 = 0;
            val_2 = 0;
            goto label_0;
            label_13:
            val_3 = mem[point[0x0] + 32];
            val_3 = point[0x0] + 32;
            if(point[0] <= max[0])
            {
                goto label_5;
            }
            
            val_4 = max;
            goto label_6;
            label_5:
            double val_3 = min[0];
            val_5 = 0;
            if(val_3 >= 0)
            {
                goto label_9;
            }
            
            val_3 = mem[point[0x0] + 32];
            val_3 = point[0x0] + 32;
            val_4 = min;
            label_6:
            val_5 = val_3 - val_4[0];
            label_9:
            val_5 = val_5 * val_5;
            val_2 = val_2 + val_5;
            val_1 = 1;
            label_0:
            if(val_1 < point.Length)
            {
                goto label_13;
            }
            
            return (double)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SquareEuclideanDistanceFunction()
        {
        
        }
    
    }

}
