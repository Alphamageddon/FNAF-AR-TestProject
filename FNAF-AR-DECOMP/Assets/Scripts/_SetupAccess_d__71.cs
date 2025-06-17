using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class AbstractMap.<SetupAccess>d__71 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Mapbox.Unity.Map.AbstractMap <>4__this;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AbstractMap.<SetupAccess>d__71(int <>1__state)
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
        var val_4;
        var val_5;
        System.Func<System.Boolean> val_7;
        int val_8;
        val_4 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_4;
        }
        
            this.<>1__state = 0;
            this.<>4__this._fileSource = Mapbox.Unity.MapboxAccess.Instance;
            val_5 = null;
            val_5 = null;
            val_7 = AbstractMap.<>c.<>9__71_0;
            if(val_7 == null)
        {
                System.Func<System.Boolean> val_2 = null;
            val_7 = val_2;
            val_2 = new System.Func<System.Boolean>(object:  AbstractMap.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean AbstractMap.<>c::<SetupAccess>b__71_0());
            AbstractMap.<>c.<>9__71_0 = val_7;
        }
        
            val_8 = 1;
            val_4 = 1;
            this.<>2__current = new UnityEngine.WaitUntil(predicate:  val_2);
        }
        else
        {
                val_8 = 0;
        }
        
        this.<>1__state = val_8;
        return (bool)val_4;
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
