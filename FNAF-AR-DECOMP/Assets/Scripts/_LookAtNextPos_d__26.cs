using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class AstronautMouseController.<LookAtNextPos>d__26 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Mapbox.Examples.AstronautMouseController <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Quaternion <neededRotation>5__2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Quaternion <thisRotation>5__3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float <t>5__4;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AstronautMouseController.<LookAtNextPos>d__26(int <>1__state)
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
        UnityEngine.Vector3 val_12;
        float val_15;
        float val_16;
        int val_17;
        float val_18;
        UnityEngine.Quaternion val_19;
        float val_20;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
            goto label_3;
        }
        
        val_12 = this.<>4__this.nextPos;
        goto label_4;
        label_1:
        val_15 = this.<t>5__4;
        val_16 = 1f;
        this.<>1__state = 0;
        if(val_15 < 0)
        {
            goto label_5;
        }
        
        label_2:
        val_17 = 0;
        return (bool)val_17;
        label_3:
        val_12 = this.<>4__this.nextPos;
        label_4:
        UnityEngine.Vector3 val_2 = this.<>4__this.character.transform.position;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_12, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        val_16 = val_3.x;
        UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_16, y = val_3.y, z = val_3.z});
        this.<neededRotation>5__2 = val_4;
        mem[1152921519844796044] = val_4.y;
        mem[1152921519844796048] = val_4.z;
        mem[1152921519844796052] = val_4.w;
        UnityEngine.Quaternion val_6 = this.<>4__this.character.transform.localRotation;
        val_18 = 0f;
        this.<thisRotation>5__3 = val_6;
        mem[1152921519844796060] = val_6.y;
        mem[1152921519844796064] = val_6.z;
        mem[1152921519844796068] = val_6.w;
        this.<t>5__4 = 0f;
        label_5:
        float val_7 = UnityEngine.Time.deltaTime;
        val_19 = this.<thisRotation>5__3;
        val_7 = val_7 * 4f;
        float val_8 = val_18 + val_7;
        this.<t>5__4 = val_8;
        val_19 = val_19;
        UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.Slerp(a:  new UnityEngine.Quaternion() {x = val_19, y = val_3.y, z = V15.16B, w = V14.16B}, b:  new UnityEngine.Quaternion() {x = this.<neededRotation>5__2, y = val_2.x, z = val_2.y, w = val_18}, t:  val_8);
        UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.Euler(x:  0f, y:  val_9.y, z:  0f);
        val_20 = val_11.z;
        this.<>4__this.character.transform.rotation = new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_20, w = val_11.w};
        val_17 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_17;
        return (bool)val_17;
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
