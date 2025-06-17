using UnityEngine;

namespace KDTree
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface DistanceFunctions
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract double Distance(double[] p1, double[] p2); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract double DistanceToRectangle(double[] point, double[] min, double[] max); // 0
    
    }

}
