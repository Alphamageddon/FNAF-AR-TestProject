using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class AstronautMouseController.<MoveTo>d__24 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Mapbox.Examples.AstronautMouseController <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float <time>5__2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float <t>5__3;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AstronautMouseController.<MoveTo>d__24(int <>1__state)
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
        float val_10;
        float val_11;
        float val_12;
        System.Collections.IEnumerator val_13;
        int val_14;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        UnityEngine.Vector3 val_2 = this.<>4__this.transform.localPosition;
        val_10 = val_2.x;
        val_11 = val_2.z;
        if((this.<>4__this) == null)
        {
            goto label_5;
        }
        
        this.<>4__this.prevPos = val_2;
        mem2[0] = val_2.y;
        mem2[0] = val_11;
        goto label_6;
        label_1:
        val_12 = this.<t>5__3;
        this.<>1__state = 0;
        goto label_7;
        label_5:
        mem[208] = val_10;
        mem[212] = val_2.y;
        mem[216] = val_11;
        label_6:
        val_12 = this;
        this.<t>5__3 = 0f;
        mem[1152921519844045192] = this.<>4__this.CalculateTime();
        if((this.<>4__this) != null)
        {
                val_13 = this.<>4__this.LookAtNextPos();
        }
        else
        {
                val_13 = 0.LookAtNextPos();
        }
        
        UnityEngine.Coroutine val_6 = this.<>4__this.StartCoroutine(routine:  val_13);
        label_7:
        if((this.<t>5__3) >= 0)
        {
            goto label_10;
        }
        
        if((this.<>4__this.interruption) == true)
        {
            goto label_12;
        }
        
        float val_7 = UnityEngine.Time.deltaTime;
        val_7 = val_7 / (this.<time>5__2);
        val_7 = (this.<t>5__3) + val_7;
        this.<t>5__3 = val_7;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<>4__this.prevPos, y = V14.16B, z = V13.16B}, b:  new UnityEngine.Vector3() {x = this.<>4__this.nextPos, y = V11.16B, z = this.<t>5__3}, t:  this.<t>5__3);
        val_11 = val_9.x;
        val_10 = val_9.z;
        this.<>4__this.transform.localPosition = new UnityEngine.Vector3() {x = val_11, y = val_9.y, z = val_10};
        val_14 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_14;
        return (bool)val_14;
        label_10:
        if((this.<>4__this) == null)
        {
            goto label_17;
        }
        
        label_12:
        this.<>4__this.interruption = false;
        goto label_18;
        label_17:
        mem[192] = 0;
        label_18:
        this.<>4__this.MoveToNextPlace();
        label_2:
        val_14 = 0;
        return (bool)val_14;
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
