using UnityEngine;

namespace StagPoint.SpatialDatabase
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal interface ISpatialDatabase
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract UnityEngine.Bounds EnclosedArea { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract UnityEngine.Bounds get_EnclosedArea(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract StagPoint.SpatialDatabase.ISpatialToken AddItem(object item, UnityEngine.Bounds bounds); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Reset(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void ExecuteQuery<T>(StagPoint.SpatialDatabase.SpacialDatabaseQuery<T> query); // 0
    
    }

}
