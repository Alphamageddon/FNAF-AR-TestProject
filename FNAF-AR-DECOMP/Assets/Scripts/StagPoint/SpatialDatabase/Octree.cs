using UnityEngine;

namespace StagPoint.SpatialDatabase
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Octree : ISpatialDatabase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Bounds <EnclosedArea>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int initialSplitDepth = 1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int maxItemsPerNode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private StagPoint.SpatialDatabase.Octree.Node root;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _numNodes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _numSplits;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _numAdds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _numRemoves;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _numQueries;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Bounds EnclosedArea { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int numNodes { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int numSplits { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int numAdds { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int numRemoves { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int numQueries { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Bounds get_EnclosedArea()
        {
            UnityEngine.Bounds val_0;
            val_0.m_Extents.y = ;
            val_0.m_Center.x = this.<EnclosedArea>k__BackingField;
            return val_0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_EnclosedArea(UnityEngine.Bounds value)
        {
            mem[1152921520155721408] = value.m_Extents.y;
            this.<EnclosedArea>k__BackingField = value.m_Center.x;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_numNodes()
        {
            return (int)this._numNodes;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_numSplits()
        {
            return (int)this._numSplits;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_numAdds()
        {
            return (int)this._numAdds;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_numRemoves()
        {
            return (int)this._numRemoves;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_numQueries()
        {
            return (int)this._numQueries;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Octree(UnityEngine.Bounds bounds)
        {
            var val_3;
            this.maxItemsPerNode = 10;
            mem[1152921520156405632] = bounds.m_Extents.y;
            this.<EnclosedArea>k__BackingField = bounds.m_Center.x;
            this._numNodes = this._numNodes + 1;
            Octree.Node val_2 = new Octree.Node();
            if(val_2 != null)
            {
                    .outerClass = this;
                val_3;
            }
            else
            {
                    mem[16] = this;
                val_3;
            }
            
            mem[1152921520156441704] = bounds.m_Extents.y;
            .bounds = bounds.m_Center.x;
            this.root = val_2;
            val_2.Split(splitChildren:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Octree(UnityEngine.Bounds bounds, int maxItemsPerNode)
        {
            var val_3;
            this.maxItemsPerNode = 10;
            this.maxItemsPerNode = maxItemsPerNode;
            mem[1152921520156533952] = bounds.m_Extents.y;
            this.<EnclosedArea>k__BackingField = bounds.m_Center.x;
            this._numNodes = this._numNodes + 1;
            Octree.Node val_2 = new Octree.Node();
            if(val_2 != null)
            {
                    .outerClass = this;
                val_3;
            }
            else
            {
                    mem[16] = this;
                val_3;
            }
            
            mem[1152921520156570024] = bounds.m_Extents.y;
            .bounds = bounds.m_Center.x;
            this.root = val_2;
            val_2.Split(splitChildren:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StagPoint.SpatialDatabase.ISpatialToken AddItem(object item, UnityEngine.Bounds bounds)
        {
            Octree.TrackingInfo val_1 = new Octree.TrackingInfo();
            if(val_1 != null)
            {
                    .item = item;
                mem[1152921520156710648] = bounds.m_Extents.y;
                .bounds = bounds.m_Center.x;
            }
            else
            {
                    mem[32] = item;
                mem[56] = bounds.m_Extents.y;
                mem[40] = bounds.m_Center.x;
            }
            
            .tree = this;
            this.root.AddItem(item:  val_1, canAutoSplit:  true);
            return (StagPoint.SpatialDatabase.ISpatialToken)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StagPoint.SpatialDatabase.BoundsQuery<T> ExecuteQuery<T>(UnityEngine.Bounds bounds)
        {
            var val_1 = mem[__RuntimeMethodHiddenParam + 48 + 8 + 294];
            val_1 = __RuntimeMethodHiddenParam + 48 + 8 + 294;
            if((val_1 & 1) == 0)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 48 + 8 + 294];
                val_1 = __RuntimeMethodHiddenParam + 48 + 8 + 294;
            }
            
            if(this != null)
            {
                    return (StagPoint.SpatialDatabase.BoundsQuery<T>);
            }
            
            return (StagPoint.SpatialDatabase.BoundsQuery<T>);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StagPoint.SpatialDatabase.PlaneBoundedVolumeQuery<T> ExecuteQuery<T>(UnityEngine.Plane[] planes)
        {
            var val_1 = mem[__RuntimeMethodHiddenParam + 48 + 8 + 294];
            val_1 = __RuntimeMethodHiddenParam + 48 + 8 + 294;
            if((val_1 & 1) == 0)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 48 + 8 + 294];
                val_1 = __RuntimeMethodHiddenParam + 48 + 8 + 294;
            }
            
            if(this != null)
            {
                    return (StagPoint.SpatialDatabase.PlaneBoundedVolumeQuery<T>)planes;
            }
            
            return (StagPoint.SpatialDatabase.PlaneBoundedVolumeQuery<T>)planes;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StagPoint.SpatialDatabase.LineSegmentQuery<T> ExecuteQuery<T>(UnityEngine.Vector3 start, UnityEngine.Vector3 end)
        {
            var val_1 = mem[__RuntimeMethodHiddenParam + 48 + 8 + 294];
            val_1 = __RuntimeMethodHiddenParam + 48 + 8 + 294;
            if((val_1 & 1) == 0)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 48 + 8 + 294];
                val_1 = __RuntimeMethodHiddenParam + 48 + 8 + 294;
            }
            
            if(this != null)
            {
                    return (StagPoint.SpatialDatabase.LineSegmentQuery<T>)__RuntimeMethodHiddenParam + 48;
            }
            
            return (StagPoint.SpatialDatabase.LineSegmentQuery<T>)__RuntimeMethodHiddenParam + 48;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StagPoint.SpatialDatabase.ProximityQuery<T> ExecuteQuery<T>(UnityEngine.Vector3 position, float radius)
        {
            var val_1 = mem[__RuntimeMethodHiddenParam + 48 + 8 + 294];
            val_1 = __RuntimeMethodHiddenParam + 48 + 8 + 294;
            if((val_1 & 1) == 0)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 48 + 8 + 294];
                val_1 = __RuntimeMethodHiddenParam + 48 + 8 + 294;
            }
            
            if(this != null)
            {
                    return (StagPoint.SpatialDatabase.ProximityQuery<T>)__RuntimeMethodHiddenParam + 48;
            }
            
            return (StagPoint.SpatialDatabase.ProximityQuery<T>)__RuntimeMethodHiddenParam + 48;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ExecuteQuery<T>(StagPoint.SpatialDatabase.SpacialDatabaseQuery<T> query)
        {
            int val_1 = this._numQueries;
            val_1 = val_1 + 1;
            this._numQueries = val_1;
            if(this.root == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Reset()
        {
            this.initializeNodes();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void initializeNodes()
        {
            int val_2 = this._numNodes;
            val_2 = val_2 + 1;
            this._numNodes = val_2;
            Octree.Node val_1 = new Octree.Node();
            .outerClass = this;
            mem[1152921520157605160] = 1152921505138688000;
            .bounds = this.<EnclosedArea>k__BackingField;
            this.root = val_1;
            val_1.Split(splitChildren:  true);
        }
    
    }

}
