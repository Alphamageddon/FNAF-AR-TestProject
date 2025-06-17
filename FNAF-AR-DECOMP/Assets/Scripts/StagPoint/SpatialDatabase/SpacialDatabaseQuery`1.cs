using UnityEngine;

namespace StagPoint.SpatialDatabase
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class SpacialDatabaseQuery<T> : IDisposable
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StagPoint.SpatialDatabase.SpacialDatabaseQuery.IntersectsItemCallback<T, T> IntersectsItemOverride;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract StagPoint.SpatialDatabase.IntersectionType GetVolumeIntersection(ref UnityEngine.Bounds bounds); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual bool IntersectsItem(ref UnityEngine.Bounds bounds)
        {
            return (bool)(this != 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void ProcessResult(T result); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void Prepare()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void Finish()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Dispose(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected SpacialDatabaseQuery<T>()
        {
            if(this != null)
            {
                    return;
            }
        
        }
    
    }

}
