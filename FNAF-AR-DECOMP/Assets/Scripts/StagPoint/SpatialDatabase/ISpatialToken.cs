using UnityEngine;

namespace StagPoint.SpatialDatabase
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface ISpatialToken
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract UnityEngine.Bounds Bounds { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract UnityEngine.Bounds get_Bounds(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Remove(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Update(UnityEngine.Bounds newBounds); // 0
    
    }

}
