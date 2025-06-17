using UnityEngine;

namespace StagPoint.SpatialDatabase
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ProximityQuery<T> : SpacialDatabaseQuery<T>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static StagPoint.Core.ListEx<object> pool;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private StagPoint.Core.ListEx<T> results;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 origin;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float radius;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 Origin { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Radius { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IList<T> Results { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static StagPoint.SpatialDatabase.ProximityQuery<T> Obtain(UnityEngine.Vector3 origin, float radius)
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            val_5 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            if((val_5 & 1) == 0)
            {
                    val_5 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
                val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            }
            
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  __RuntimeMethodHiddenParam + 24 + 192 + 184, lockTaken: ref  val_1);
            val_6 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_6 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            if((val_6 & 1) == 0)
            {
                    val_6 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
                val_6 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            }
            
            if((__RuntimeMethodHiddenParam + 24 + 192 + 184.Count) < 1)
            {
                goto label_22;
            }
            
            val_7 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_7 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            if((val_7 & 1) == 0)
            {
                    val_7 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
                val_7 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            }
            
            object val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 184.Pop();
            if(val_3 == null)
            {
                goto label_36;
            }
            
            val_8 = val_3;
            if(val_8 != null)
            {
                goto label_38;
            }
            
            label_36:
            val_8 = 0;
            goto label_38;
            label_22:
            val_8 = __RuntimeMethodHiddenParam + 24 + 192 + 16;
            val_9 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_9 = __RuntimeMethodHiddenParam + 24 + 294;
            val_10 = __RuntimeMethodHiddenParam + 24;
            if((val_9 & 1) == 0)
            {
                    val_10 = mem[__RuntimeMethodHiddenParam + 24];
                val_10 = __RuntimeMethodHiddenParam + 24;
                val_9 = mem[__RuntimeMethodHiddenParam + 24 + 294];
                val_9 = __RuntimeMethodHiddenParam + 24 + 294;
            }
            
            label_38:
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  __RuntimeMethodHiddenParam + 24 + 192 + 184);
            }
            
            val_11 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 40 + 294];
            val_11 = __RuntimeMethodHiddenParam + 24 + 192 + 40 + 294;
            if((val_11 & 1) == 0)
            {
                    val_11 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 40 + 294];
                val_11 = __RuntimeMethodHiddenParam + 24 + 192 + 40 + 294;
            }
            
            val_12 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_12 = __RuntimeMethodHiddenParam + 24 + 294;
            val_13 = __RuntimeMethodHiddenParam + 24;
            if((val_12 & 1) == 0)
            {
                    val_13 = mem[__RuntimeMethodHiddenParam + 24];
                val_13 = __RuntimeMethodHiddenParam + 24;
                val_12 = mem[__RuntimeMethodHiddenParam + 24 + 294];
                val_12 = __RuntimeMethodHiddenParam + 24 + 294;
            }
            
            if(val_8 != 0)
            {
                    mem2[0] = __RuntimeMethodHiddenParam + 24 + 192 + 32;
            }
            else
            {
                    mem[24] = __RuntimeMethodHiddenParam + 24 + 192 + 32;
            }
            
            mem2[0] = origin.x;
            mem2[0] = origin.y;
            mem2[0] = origin.z;
            mem2[0] = radius;
            return (StagPoint.SpatialDatabase.ProximityQuery<T>)val_8;
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
            mem[1152921520165125224] = 0;
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
        public UnityEngine.Vector3 get_Origin()
        {
            return new UnityEngine.Vector3();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Radius()
        {
            return (float)S0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IList<T> get_Results()
        {
            return (System.Collections.Generic.IList<T>)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override StagPoint.SpatialDatabase.IntersectionType GetVolumeIntersection(ref UnityEngine.Bounds bounds)
        {
            return StagPoint.SpatialDatabase.IntersectionTests.GetIntersectionType(box: ref  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = bounds.m_Center.x, y = bounds.m_Center.y, z = bounds.m_Center.z}, m_Extents = new UnityEngine.Vector3() {x = bounds.m_Extents.x, y = bounds.m_Extents.y, z = bounds.m_Extents.z}}, center: ref  new UnityEngine.Vector3(), radius:  null);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool IntersectsItem(ref UnityEngine.Bounds bounds)
        {
            return StagPoint.SpatialDatabase.IntersectionTests.Intersects(box: ref  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = bounds.m_Center.x, y = bounds.m_Center.y, z = bounds.m_Center.z}, m_Extents = new UnityEngine.Vector3() {x = bounds.m_Extents.x, y = bounds.m_Extents.y, z = bounds.m_Extents.z}}, center: ref  new UnityEngine.Vector3(), radius:  null);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void ProcessResult(T result)
        {
            if(X20 == 0)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProximityQuery<T>()
        {
            mem[1152921520165933672] = __RuntimeMethodHiddenParam + 24 + 192 + 64;
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static ProximityQuery<T>()
        {
            StagPoint.Core.ListEx<System.Object> val_1 = 38843;
            val_1 = new StagPoint.Core.ListEx<System.Object>();
            mem2[0] = val_1;
        }
    
    }

}
