using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class DirectionsFactory.<QueryTimer>d__14 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Mapbox.Unity.MeshGeneration.Factories.DirectionsFactory <>4__this;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DirectionsFactory.<QueryTimer>d__14(int <>1__state)
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
        var val_6;
        UnityEngine.Transform val_7;
        float val_8;
        int val_10;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) != null)
        {
            goto label_20;
        }
        
        goto label_20;
        label_1:
        this.<>1__state = 0;
        val_6 = 0;
        goto label_5;
        label_19:
        val_7 = 0;
        UnityEngine.Vector3 val_1 = this.<>4__this._waypoints[val_7].position;
        val_8 = val_1.z;
        UnityEngine.Vector3 val_2 = this.<>4__this._cachedWaypoints.Item[0];
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_8}, rhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z})) != false)
        {
                this.<>4__this._recalculateNext = true;
            val_7 = this.<>4__this._waypoints[val_7];
            UnityEngine.Vector3 val_4 = val_7.position;
            val_8 = val_4.z;
            this.<>4__this._cachedWaypoints.set_Item(index:  0, value:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_8});
        }
        
        val_6 = 1;
        label_5:
        if(val_6 < (this.<>4__this._waypoints.Length))
        {
            goto label_19;
        }
        
        if((this.<>4__this._recalculateNext) != false)
        {
                this.<>4__this.Query();
            this.<>4__this._recalculateNext = false;
        }
        
        label_20:
        val_10 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  this.<>4__this.UpdateFrequency);
        this.<>1__state = val_10;
        return (bool)val_10;
        label_2:
        val_10 = 0;
        return (bool)val_10;
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
