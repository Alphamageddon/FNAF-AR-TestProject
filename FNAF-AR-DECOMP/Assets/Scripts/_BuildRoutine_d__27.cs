using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class VoxelTile.<BuildRoutine>d__27 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Mapbox.Examples.Voxels.VoxelTile <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<Mapbox.Examples.Voxels.VoxelData> <distanceOrderedVoxels>5__2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <i>5__3;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public VoxelTile.<BuildRoutine>d__27(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void System.IDisposable.Dispose()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool MoveNext()
    {
        System.Collections.Generic.List<Mapbox.Examples.Voxels.VoxelData> val_11;
        var val_12;
        var val_13;
        int val_14;
        UnityEngine.GameObject val_15;
        int val_16;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_8;
        }
        
        this.<>1__state = 0;
        val_11 = System.Linq.Enumerable.ToList<Mapbox.Examples.Voxels.VoxelData>(source:  System.Linq.Enumerable.OrderBy<Mapbox.Examples.Voxels.VoxelData, System.Single>(source:  this.<>4__this._voxels, keySelector:  new System.Func<Mapbox.Examples.Voxels.VoxelData, System.Single>(object:  this.<>4__this, method:  System.Single Mapbox.Examples.Voxels.VoxelTile::<BuildRoutine>b__27_0(Mapbox.Examples.Voxels.VoxelData x))));
        val_12 = this;
        this.<distanceOrderedVoxels>5__2 = val_11;
        val_13 = 1152921519870402728;
        val_14 = 0;
        mem[1152921519870402736] = 0;
        if(val_11 != null)
        {
            goto label_7;
        }
        
        goto label_5;
        label_1:
        val_13 = this;
        this.<>1__state = 0;
        val_12 = this;
        val_11 = this.<distanceOrderedVoxels>5__2;
        val_14 = (this.<>4__this._voxelBatchCount) + (this.<i>5__3);
        this.<i>5__3 = val_14;
        if(val_11 != null)
        {
            goto label_7;
        }
        
        label_5:
        label_7:
        if(val_14 < val_11.Count)
        {
                if((this.<>4__this._voxelBatchCount) >= 1)
        {
                var val_10 = 0;
            do
        {
            val_11 = val_10 + (this.<i>5__3);
            if(val_11 < (this.<distanceOrderedVoxels>5__2.Count))
        {
                val_11 = this.<>4__this._instantiatedVoxels;
            if((this.<distanceOrderedVoxels>5__2.Item[val_11]) != null)
        {
                val_15 = val_6.Prefab;
        }
        else
        {
                val_15 = 64;
        }
        
            UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.identity;
            val_11.Add(item:  UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_15, position:  new UnityEngine.Vector3() {x = val_6.Position, y = V8.16B, z = V9.16B}, rotation:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w}, parent:  this.<>4__this.transform));
        }
        
            val_10 = val_10 + 1;
        }
        while(val_10 < (this.<>4__this._voxelBatchCount));
        
        }
        
            val_16 = 1;
            this.<>2__current = 0;
            this.<>1__state = val_16;
            return (bool)val_16;
        }
        
        label_8:
        val_16 = 0;
        return (bool)val_16;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
