using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private class Octree.Node
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal StagPoint.SpatialDatabase.Octree outerClass;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal UnityEngine.Bounds bounds;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private StagPoint.SpatialDatabase.Octree.Node parent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private StagPoint.SpatialDatabase.Octree.Node[] childNodes;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private StagPoint.Core.ListEx<StagPoint.SpatialDatabase.Octree.TrackingInfo> items;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool hasStoredItems;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public StagPoint.SpatialDatabase.Octree.Node Parent { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsEmpty { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsLeafNode { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int ItemCount { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public StagPoint.SpatialDatabase.Octree.Node get_Parent()
    {
        return (Octree.Node)this.parent;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_IsEmpty()
    {
        return (bool)(this.hasStoredItems == false) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_IsLeafNode()
    {
        return (bool)(this.childNodes == null) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_ItemCount()
    {
        if(this.items != null)
        {
                return this.items.Count;
        }
        
        return this.items.Count;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Octree.Node()
    {
        this.items = new StagPoint.Core.ListEx<TrackingInfo>();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void ExecuteQuery<T>(StagPoint.SpatialDatabase.SpacialDatabaseQuery<T> query)
    {
        var val_1;
        Octree.Node[] val_2;
        var val_3;
        val_1 = mem[__RuntimeMethodHiddenParam + 48];
        val_1 = __RuntimeMethodHiddenParam + 48;
        val_2 = this.childNodes;
        if(val_2 == null)
        {
                return;
        }
        
        val_3 = 0;
        goto label_2;
        label_9:
        val_2 = this.childNodes;
        val_3 = 1;
        label_2:
        if(val_3 >= this.childNodes.Length)
        {
                val_1 = 0;
        }
        
        Octree.Node val_1 = val_2[val_3];
        if(val_3 != 7)
        {
            goto label_9;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void AddItem(StagPoint.SpatialDatabase.Octree.TrackingInfo item, bool canAutoSplit)
    {
        var val_7;
        Octree.Node val_8;
        Octree.Node val_9;
        StagPoint.SpatialDatabase.Octree val_10;
        val_7 = canAutoSplit;
        val_8 = this;
        goto label_7;
        label_11:
        var val_1 = (V0.16B < S0) ? 0 : 4;
        val_1 = (V1.16B < S1) ? (val_1) : (val_1 | 2);
        val_9 = this.childNodes[val_1 | ((V2.16B >= S2) ? 1 : 0)];
        if((StagPoint.SpatialDatabase.IntersectionTests.GetIntersectionType(lhs: ref  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = this.childNodes[(V1.16B < S1 ? V0.16B < S0 ? 0 : 4 : (V0.16B < S0 ? 0 : 4 | 2) | V2.16B >= S2 ? 1 : 0)][0].bounds, y = this.childNodes[(V1.16B < S1 ? V0.16B < S0 ? 0 : 4 : (V0.16B < S0 ? 0 : 4 | 2) | V2.16B >= S2 ? 1 : 0)][0].bounds, z = this.childNodes[(V1.16B < S1 ? V0.16B < S0 ? 0 : 4 : (V0.16B < S0 ? 0 : 4 | 2) | V2.16B >= S2 ? 1 : 0)][0].bounds}, m_Extents = new UnityEngine.Vector3() {x = this.childNodes[(V1.16B < S1 ? V0.16B < S0 ? 0 : 4 : (V0.16B < S0 ? 0 : 4 | 2) | V2.16B >= S2 ? 1 : 0)][0].bounds, y = this.childNodes[(V1.16B < S1 ? V0.16B < S0 ? 0 : 4 : (V0.16B < S0 ? 0 : 4 | 2) | V2.16B >= S2 ? 1 : 0)][0].bounds, z = this.childNodes[(V1.16B < S1 ? V0.16B < S0 ? 0 : 4 : (V0.16B < S0 ? 0 : 4 | 2) | V2.16B >= S2 ? 1 : 0)][0].bounds}}, rhs: ref  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = item.bounds, y = item.bounds, z = item.bounds}, m_Extents = new UnityEngine.Vector3() {x = item.bounds, y = item.bounds, z = item.bounds}})) != 2)
        {
            goto label_6;
        }
        
        val_7 = 1;
        val_8 = val_9;
        if(val_9 == null)
        {
                val_7 = 1;
        }
        
        label_7:
        val_10 = this.childNodes[(V1.16B < S1 ? V0.16B < S0 ? 0 : 4 : (V0.16B < S0 ? 0 : 4 | 2) | V2.16B >= S2 ? 1 : 0)][0].outerClass;
        if(val_10 != null)
        {
                val_9 = this.childNodes[(V1.16B < S1 ? V0.16B < S0 ? 0 : 4 : (V0.16B < S0 ? 0 : 4 | 2) | V2.16B >= S2 ? 1 : 0)][0].outerClass._numAdds;
        }
        else
        {
                val_9 = 1;
            val_10 = 64;
        }
        
        mem[64] = 2;
        this.childNodes[(V1.16B < S1 ? V0.16B < S0 ? 0 : 4 : (V0.16B < S0 ? 0 : 4 | 2) | V2.16B >= S2 ? 1 : 0)][0].hasStoredItems = true;
        if((this.childNodes[(V1.16B < S1 ? V0.16B < S0 ? 0 : 4 : (V0.16B < S0 ? 0 : 4 | 2) | V2.16B >= S2 ? 1 : 0)][0].childNodes) != null)
        {
            goto label_11;
        }
        
        label_6:
        item.node = val_8;
        this.childNodes[(V1.16B < S1 ? V0.16B < S0 ? 0 : 4 : (V0.16B < S0 ? 0 : 4 | 2) | V2.16B >= S2 ? 1 : 0)][0].items.Add(item:  item);
        if((val_7 & 1) == 0)
        {
                return;
        }
        
        val_9 = this.childNodes[(V1.16B < S1 ? V0.16B < S0 ? 0 : 4 : (V0.16B < S0 ? 0 : 4 | 2) | V2.16B >= S2 ? 1 : 0)][0].outerClass;
        if((this.childNodes[(V1.16B < S1 ? V0.16B < S0 ? 0 : 4 : (V0.16B < S0 ? 0 : 4 | 2) | V2.16B >= S2 ? 1 : 0)][0].items.Count) <= (this.childNodes[(V1.16B < S1 ? V0.16B < S0 ? 0 : 4 : (V0.16B < S0 ? 0 : 4 | 2) | V2.16B >= S2 ? 1 : 0)][0].outerClass.maxItemsPerNode))
        {
                return;
        }
        
        val_8.Split(splitChildren:  false);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void Split(bool splitChildren)
    {
        Octree.Node val_15;
        Node val_16;
        Octree.Node[] val_17;
        StagPoint.SpatialDatabase.Octree val_18;
        int val_19;
        StagPoint.SpatialDatabase.Octree val_20;
        int val_21;
        val_16 = this;
        val_17 = this.childNodes;
        if(val_17 == null)
        {
            goto label_1;
        }
        
        if(splitChildren == false)
        {
                return;
        }
        
        val_15 = 0;
        goto label_3;
        label_8:
        val_17 = this.childNodes;
        val_15 = 1;
        label_3:
        Octree.Node val_16 = val_17[val_15];
        if(val_15 != 7)
        {
            goto label_8;
        }
        
        return;
        label_1:
        val_18 = this.outerClass;
        if(val_18 != null)
        {
                val_19 = this.outerClass._numSplits;
        }
        else
        {
                val_18 = 60;
            val_19 = 1769500;
        }
        
        mem[60] = 1769501;
        float val_18 = V1.16B;
        this.childNodes = new Octree.Node[8];
        var val_20 = 0;
        do
        {
            float val_19 = V1.16B;
            float val_17 = -0.5f;
            val_17 = ((val_20 & 4) != 0) ? (val_17) : 0.5f;
            float val_2 = V0.16B * val_17;
            val_18 = val_18 * (((val_20 & 2) != 0) ? (val_17) : 0.5f);
            val_20 = this.outerClass;
            if(val_20 != null)
        {
                val_21 = this.outerClass._numNodes;
        }
        else
        {
                val_21 = 4194311;
            val_20 = 56;
        }
        
            mem[56] = 4194312;
            val_2 = val_2 + V0.16B;
            val_19 = val_18 + val_19;
            float val_6 = ((???) * (((val_20 & 1) != 0) ? (val_17) : 0.5f)) + V2.16B;
            Octree.Node val_7 = null;
            val_15 = val_7;
            val_7 = new Octree.Node();
            if(val_15 != null)
        {
                .outerClass = this.outerClass;
        }
        else
        {
                mem[16] = this.outerClass;
        }
        
            .parent = val_16;
            mem[1152921520159259096] = 0;
            .bounds = 0;
            val_20 = val_20 + 1;
            this.childNodes[val_20] = val_15;
        }
        while(val_20 != 8);
        
        if(this.items.Count < 1)
        {
                return;
        }
        
        this.items = new StagPoint.Core.ListEx<TrackingInfo>();
        System.Collections.Generic.IEnumerator<T> val_10 = this.items.GetEnumerator();
        label_35:
        var val_21 = 0;
        val_21 = val_21 + 1;
        if(val_10.MoveNext() == false)
        {
            goto label_29;
        }
        
        var val_22 = 0;
        val_22 = val_22 + 1;
        this.AddItem(item:  val_10.Current, canAutoSplit:  false);
        goto label_35;
        label_29:
        val_16 = 0;
        val_15 = 367;
        if(val_10 == null)
        {
            
        }
        else
        {
                var val_23 = 0;
            val_23 = val_23 + 1;
            val_10.Dispose();
        }
        
        if( == 367)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void RemoveItem(StagPoint.SpatialDatabase.Octree.TrackingInfo item)
    {
        StagPoint.SpatialDatabase.Octree val_3;
        int val_4;
        if((this.items.Remove(item:  item)) != false)
        {
                this.updateIsEmptyFlag();
            val_3 = this.outerClass;
            if(val_3 != null)
        {
                val_4 = this.outerClass._numRemoves;
        }
        else
        {
                val_3 = 68;
            val_4 = 5;
        }
        
            mem[68] = 6;
            return;
        }
        
        System.IndexOutOfRangeException val_2 = new System.IndexOutOfRangeException();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void updateIsEmptyFlag()
    {
        StagPoint.Core.ListEx<TrackingInfo> val_3;
        label_8:
        val_3 = this.items;
        bool val_2 = (val_3.Count > 0) ? 1 : 0;
        this.hasStoredItems = val_2;
        if(this.childNodes == null)
        {
            goto label_3;
        }
        
        val_3 = 0;
        label_7:
        val_2 = val_2 & 255;
        if(val_2 != 0)
        {
            goto label_3;
        }
        
        Octree.Node val_3 = this.childNodes[val_3];
        val_3 = val_3 + 1;
        this.hasStoredItems = this.childNodes[0x0][0].hasStoredItems;
        if(val_3 <= 6)
        {
            goto label_7;
        }
        
        label_3:
        if(this.parent != null)
        {
            goto label_8;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void processFullyContainedItems<T>(StagPoint.SpatialDatabase.SpacialDatabaseQuery<T> query)
    {
        var val_4;
        Octree.Node[] val_5;
        int val_1 = this.items.Count;
        if(val_1 < 1)
        {
            goto label_2;
        }
        
        label_11:
        TrackingInfo val_2 = this.items.Item[0];
        if(val_2.item != null)
        {
                if(val_2.item != null)
        {
                if(query != null)
        {
            goto label_10;
        }
        
        }
        
        }
        
        label_10:
        val_4 = 0 + 1;
        if(val_4 < val_1)
        {
            goto label_11;
        }
        
        label_2:
        val_5 = this.childNodes;
        if(val_5 == null)
        {
                return;
        }
        
        val_4 = 0;
        goto label_13;
        label_18:
        val_5 = this.childNodes;
        val_4 = 1;
        label_13:
        Octree.Node val_4 = val_5[val_4];
        if(val_4 != 7)
        {
            goto label_18;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void processIntersectingItems<T>(StagPoint.SpatialDatabase.SpacialDatabaseQuery<T> query)
    {
        var val_4;
        var val_5;
        int val_1 = this.items.Count;
        if(val_1 < 1)
        {
                return;
        }
        
        var val_4 = 0;
        label_15:
        TrackingInfo val_2 = this.items.Item[0];
        val_4 = mem[__RuntimeMethodHiddenParam + 48];
        val_4 = __RuntimeMethodHiddenParam + 48;
        if(val_2.item == null)
        {
            goto label_14;
        }
        
        val_4 = val_2.item;
        if(val_4 == null)
        {
            goto label_14;
        }
        
        if(0 == 0)
        {
            goto label_10;
        }
        
        val_5 = val_4;
        if((0 & 1) != 0)
        {
            goto label_11;
        }
        
        goto label_14;
        label_10:
        if((query & 1) == 0)
        {
            goto label_14;
        }
        
        label_11:
        label_14:
        val_4 = val_4 + 1;
        if(val_4 < val_1)
        {
            goto label_15;
        }
    
    }

}
