using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class InitializeMapWithLocationProvider.<Start>d__3 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Mapbox.Unity.Map.InitializeMapWithLocationProvider <>4__this;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public InitializeMapWithLocationProvider.<Start>d__3(int <>1__state)
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
        Mapbox.Unity.Location.ILocationProvider val_2;
        int val_3;
        IntPtr val_4;
        val_2 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        val_3 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_3;
        return (bool)val_3;
        label_1:
        this.<>1__state = 0;
        val_2 = mem[Mapbox.Unity.Location.LocationProviderFactory._instance + 80];
        val_2 = Mapbox.Unity.Location.LocationProviderFactory._instance._defaultLocationProvider;
        if((this.<>4__this) != null)
        {
                this.<>4__this._locationProvider = val_2;
        }
        else
        {
                mem[32] = val_2;
            val_2 = mem[32];
        }
        
        System.Action<Mapbox.Unity.Location.Location> val_1 = null;
        val_4 = System.Void Mapbox.Unity.Map.InitializeMapWithLocationProvider::LocationProvider_OnLocationUpdated(Mapbox.Unity.Location.Location location);
        val_1 = new System.Action<Mapbox.Unity.Location.Location>(object:  this.<>4__this, method:  val_4);
        Mapbox.Unity.Location.ILocationProvider val_4 = null;
        if((mem[null + 286]) == 0)
        {
            goto label_9;
        }
        
        var val_2 = mem[null + 176];
        var val_3 = 0;
        val_2 = val_2 + 8;
        label_11:
        if(((mem[null + 176] + 8) + -8) == null)
        {
            goto label_10;
        }
        
        val_3 = val_3 + 1;
        val_2 = val_2 + 16;
        if(val_3 < (mem[null + 286]))
        {
            goto label_11;
        }
        
        label_9:
        val_4 = 0;
        goto label_12;
        label_10:
        val_4 = val_4 + (((mem[null + 176] + 8)) << 4);
        label_12:
        add_OnLocationUpdated(value:  val_1);
        label_2:
        val_3 = 0;
        return (bool)val_3;
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
