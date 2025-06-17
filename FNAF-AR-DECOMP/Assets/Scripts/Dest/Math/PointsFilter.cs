using UnityEngine;

namespace Dest.Math
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class PointsFilter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Collections.Generic.List<int> DistanceFilter(UnityEngine.Vector3[] points, Dest.Math.AAB3 pointsAAB, float radius, Dest.Math.Rand rand)
        {
            PointsFilter.Data val_1 = null;
            val_1 = new PointsFilter.Data(points:  points, radius:  radius, rand:  rand, aab:  new Dest.Math.AAB3() {Min = new UnityEngine.Vector3() {x = pointsAAB.Min.x}, Max = new UnityEngine.Vector3() {y = pointsAAB.Max.y}});
            if(val_1 != null)
            {
                    return val_1.Filter();
            }
            
            return val_1.Filter();
        }
    
    }

}
