using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class UpdateMapWithLocationProvider.<Start>d__12 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Mapbox.Unity.Map.UpdateMapWithLocationProvider <>4__this;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UpdateMapWithLocationProvider.<Start>d__12(int <>1__state)
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
        Mapbox.Unity.Location.ILocationProvider val_5;
        int val_6;
        IntPtr val_7;
        var val_8;
        val_5 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        val_6 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_6;
        return (bool)val_6;
        label_1:
        this.<>1__state = 0;
        val_5 = Mapbox.Unity.Location.LocationProviderFactory.Instance.DefaultLocationProvider;
        if((this.<>4__this) != null)
        {
                this.<>4__this._locationProvider = val_5;
        }
        else
        {
                mem[32] = val_5;
            val_5 = mem[32];
        }
        
        System.Action<Mapbox.Unity.Location.Location> val_3 = null;
        val_7 = System.Void Mapbox.Unity.Map.UpdateMapWithLocationProvider::LocationProvider_OnFirstLocationUpdate(Mapbox.Unity.Location.Location location);
        val_3 = new System.Action<Mapbox.Unity.Location.Location>(object:  this.<>4__this, method:  val_7);
        var val_6 = val_5;
        if((val_2 + 286) == 0)
        {
            goto label_8;
        }
        
        var val_4 = val_2 + 176;
        var val_5 = 0;
        val_4 = val_4 + 8;
        label_10:
        if(((val_2 + 176 + 8) + -8) == null)
        {
            goto label_9;
        }
        
        val_5 = val_5 + 1;
        val_4 = val_4 + 16;
        if(val_5 < (val_2 + 286))
        {
            goto label_10;
        }
        
        label_8:
        val_7 = 0;
        goto label_11;
        label_9:
        val_6 = val_6 + (((val_2 + 176 + 8)) << 4);
        val_8 = val_6 + 296;
        label_11:
        val_5.add_OnLocationUpdated(value:  val_3);
        label_2:
        val_6 = 0;
        return (bool)val_6;
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
