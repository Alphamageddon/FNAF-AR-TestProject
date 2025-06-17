using UnityEngine;

namespace StagPoint.SpatialDatabase
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlaneBoundedVolumeQuery<T> : SpacialDatabaseQuery<T>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static StagPoint.Core.ListEx<object> pool;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private StagPoint.Core.ListEx<T> results;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Plane[] planes;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IList<UnityEngine.Plane> Planes { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IList<T> Results { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static StagPoint.SpatialDatabase.PlaneBoundedVolumeQuery<T> Obtain(UnityEngine.Plane[] planes)
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            val_4 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            if((val_4 & 1) == 0)
            {
                    val_4 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
                val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            }
            
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  __RuntimeMethodHiddenParam + 24 + 192 + 184, lockTaken: ref  val_1);
            val_5 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            if((val_5 & 1) == 0)
            {
                    val_5 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
                val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            }
            
            if((__RuntimeMethodHiddenParam + 24 + 192 + 184 + 24) < 1)
            {
                goto label_22;
            }
            
            val_6 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_6 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            if((val_6 & 1) == 0)
            {
                    val_6 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
                val_6 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            }
            
            object val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 184.Pop();
            if(val_2 == null)
            {
                goto label_36;
            }
            
            val_7 = val_2;
            if(val_7 != null)
            {
                goto label_38;
            }
            
            label_36:
            val_7 = 0;
            goto label_38;
            label_22:
            val_7 = __RuntimeMethodHiddenParam + 24 + 192 + 16;
            val_8 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_8 = __RuntimeMethodHiddenParam + 24 + 294;
            val_9 = __RuntimeMethodHiddenParam + 24;
            if((val_8 & 1) == 0)
            {
                    val_9 = mem[__RuntimeMethodHiddenParam + 24];
                val_9 = __RuntimeMethodHiddenParam + 24;
                val_8 = mem[__RuntimeMethodHiddenParam + 24 + 294];
                val_8 = __RuntimeMethodHiddenParam + 24 + 294;
            }
            
            label_38:
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  __RuntimeMethodHiddenParam + 24 + 192 + 184);
            }
            
            val_10 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 40 + 294];
            val_10 = __RuntimeMethodHiddenParam + 24 + 192 + 40 + 294;
            if((val_10 & 1) == 0)
            {
                    val_10 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 40 + 294];
                val_10 = __RuntimeMethodHiddenParam + 24 + 192 + 40 + 294;
            }
            
            val_11 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_11 = __RuntimeMethodHiddenParam + 24 + 294;
            val_12 = __RuntimeMethodHiddenParam + 24;
            if((val_11 & 1) == 0)
            {
                    val_12 = mem[__RuntimeMethodHiddenParam + 24];
                val_12 = __RuntimeMethodHiddenParam + 24;
                val_11 = mem[__RuntimeMethodHiddenParam + 24 + 294];
                val_11 = __RuntimeMethodHiddenParam + 24 + 294;
            }
            
            if(val_7 != 0)
            {
                    mem2[0] = __RuntimeMethodHiddenParam + 24 + 192 + 32;
            }
            else
            {
                    mem[24] = __RuntimeMethodHiddenParam + 24 + 192 + 32;
            }
            
            mem2[0] = planes;
            return (StagPoint.SpatialDatabase.PlaneBoundedVolumeQuery<T>)val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Dispose()
        {
            var val_2;
            var val_3;
            val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            if((val_2 & 1) == 0)
            {
                    val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
                val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            }
            
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  __RuntimeMethodHiddenParam + 24 + 192 + 184, lockTaken: ref  val_1);
            mem[1152921520163129512] = 0;
            val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            if((val_3 & 1) == 0)
            {
                    val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
                val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            }
            
            __RuntimeMethodHiddenParam + 24 + 192 + 184.Add(item:  this);
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  __RuntimeMethodHiddenParam + 24 + 192 + 184);
            }
            
            if(57 == 57)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlaneBoundedVolumeQuery<T>()
        {
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IList<UnityEngine.Plane> get_Planes()
        {
            return (System.Collections.Generic.IList<UnityEngine.Plane>)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IList<T> get_Results()
        {
            return (System.Collections.Generic.IList<T>)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override StagPoint.SpatialDatabase.IntersectionType GetVolumeIntersection(ref UnityEngine.Bounds bounds)
        {
            return StagPoint.SpatialDatabase.IntersectionTests.GetIntersectionType(planes:  this, bounds: ref  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = bounds.m_Center.x, y = bounds.m_Center.y, z = bounds.m_Center.z}, m_Extents = new UnityEngine.Vector3() {x = bounds.m_Extents.x, y = bounds.m_Extents.y, z = bounds.m_Extents.z}});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void ProcessResult(T result)
        {
            if(X20 == 0)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PlaneBoundedVolumeQuery<T>()
        {
            mem2[0] = new StagPoint.Core.ListEx<System.Object>();
        }
    
    }

}
