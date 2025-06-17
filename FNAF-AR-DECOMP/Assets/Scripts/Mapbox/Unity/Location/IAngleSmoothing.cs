using UnityEngine;

namespace Mapbox.Unity.Location
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IAngleSmoothing
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Add(double angle); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract double Calculate(); // 0
    
    }

}
