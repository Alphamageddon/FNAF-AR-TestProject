using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class TextMeshProFloatingText.<DisplayTextMeshFloatingText>d__13 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TMPro.Examples.TextMeshProFloatingText <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float <CountDuration>5__2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float <starting_Count>5__3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float <current_Count>5__4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Vector3 <start_pos>5__5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Color32 <start_color>5__6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float <alpha>5__7;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float <fadeDuration>5__8;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TextMeshProFloatingText.<DisplayTextMeshFloatingText>d__13(int <>1__state)
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
        int val_27;
        float val_28;
        UnityEngine.TextMesh val_29;
        UnityEngine.Vector3 val_30;
        float val_32;
        float val_33;
        float val_34;
        float val_35;
        float val_36;
        float val_37;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_27 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_27;
        }
        
        this.<>1__state = 0;
        this.<CountDuration>5__2 = 2f;
        float val_1 = UnityEngine.Random.Range(min:  5f, max:  20f);
        this.<starting_Count>5__3 = val_1;
        this.<current_Count>5__4 = val_1;
        val_28 = this.<current_Count>5__4;
        UnityEngine.Vector3 val_2 = this.<>4__this.m_floatingText_Transform.position;
        this.<start_pos>5__5 = val_2;
        mem[1152921524667792232] = val_2.y;
        mem[1152921524667792236] = val_2.z;
        val_29 = this.<>4__this.m_textMesh;
        UnityEngine.Color val_3 = val_29.color;
        UnityEngine.Color32 val_4 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a});
        this.<start_color>5__6 = val_4;
        this.<alpha>5__7 = 255f;
        float val_27 = this.<starting_Count>5__3;
        val_27 = 3f / val_27;
        val_27 = val_27 * (this.<CountDuration>5__2);
        this.<fadeDuration>5__8 = val_27;
        goto label_7;
        label_1:
        this.<>1__state = 0;
        val_29 = this.<>4__this.m_floatingText_Transform;
        val_30 = this.<start_pos>5__5;
        val_29.position = new UnityEngine.Vector3() {x = val_30, y = V9.16B, z = V10.16B};
        UnityEngine.Coroutine val_6 = this.<>4__this.StartCoroutine(routine:  this.<>4__this.DisplayTextMeshFloatingText());
        val_27 = 0;
        return (bool)val_27;
        label_2:
        val_28 = this.<current_Count>5__4;
        this.<>1__state = 0;
        label_7:
        if(val_28 <= 0f)
        {
                val_30 = UnityEngine.Random.Range(min:  0.1f, max:  1f);
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  val_30);
            this.<>1__state = 2;
            val_27 = 1;
            return (bool)val_27;
        }
        
        float val_9 = UnityEngine.Time.deltaTime;
        val_32 = this.<starting_Count>5__3;
        val_9 = val_9 / (this.<CountDuration>5__2);
        val_9 = val_9 * val_32;
        val_33 = val_28 - val_9;
        this.<current_Count>5__4 = val_33;
        if(val_33 <= 3f)
        {
                float val_10 = UnityEngine.Time.deltaTime;
            val_32 = 255f;
            val_10 = val_10 / (this.<fadeDuration>5__8);
            val_10 = val_10 * val_32;
            val_10 = (this.<alpha>5__7) - val_10;
            val_33 = this.<current_Count>5__4;
            this.<alpha>5__7 = UnityEngine.Mathf.Clamp(value:  val_10, min:  0f, max:  val_32);
        }
        
        this.<>4__this.m_textMesh.text = (int)val_33.ToString();
        UnityEngine.Color val_13 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
        this.<>4__this.m_textMesh.color = new UnityEngine.Color() {r = val_13.r, g = val_13.g, b = val_13.b, a = val_13.a};
        UnityEngine.Vector3 val_14 = this.<>4__this.m_floatingText_Transform.position;
        float val_16 = (this.<starting_Count>5__3) * UnityEngine.Time.deltaTime;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.<>4__this.m_floatingText_Transform.position = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
        UnityEngine.Vector3 val_18 = this.<>4__this.m_cameraTransform.position;
        val_34 = val_18.x;
        val_35 = this.<>4__this.lastPOS;
        val_36 = val_17.y;
        val_37 = val_17.z;
        if((TMPro.TMPro_ExtensionMethods.Compare(v1:  new UnityEngine.Vector3() {x = val_35, y = val_36, z = val_37}, v2:  new UnityEngine.Vector3() {x = val_34, y = val_18.y, z = val_18.z}, accuracy:  232)) == false)
        {
            goto label_24;
        }
        
        val_30 = this.<>4__this.lastRotation;
        val_29 = this.<>4__this.m_cameraTransform;
        UnityEngine.Quaternion val_20 = val_29.rotation;
        val_35 = val_30;
        val_36 = val_17.y;
        val_37 = this.<starting_Count>5__3;
        val_34 = val_17.z;
        if((TMPro.TMPro_ExtensionMethods.Compare(q1:  new UnityEngine.Quaternion() {x = val_35, y = val_36, z = val_37, w = val_34}, q2:  new UnityEngine.Quaternion() {x = val_20.x, y = val_20.y, z = val_20.z, w = val_20.w}, accuracy:  232)) == true)
        {
            goto label_26;
        }
        
        label_24:
        UnityEngine.Vector3 val_22 = this.<>4__this.m_cameraTransform.position;
        this.<>4__this.lastPOS = val_22;
        mem2[0] = val_22.y;
        mem2[0] = val_22.z;
        UnityEngine.Quaternion val_23 = this.<>4__this.m_cameraTransform.rotation;
        this.<>4__this.lastRotation = val_23;
        mem2[0] = val_23.y;
        mem2[0] = val_23.z;
        mem2[0] = val_23.w;
        this.<>4__this.m_floatingText_Transform.rotation = new UnityEngine.Quaternion() {x = val_23.x, y = val_23.y, z = val_23.z, w = val_23.w};
        val_29 = this.<>4__this.m_transform;
        UnityEngine.Vector3 val_24 = val_29.position;
        val_30 = val_24.x;
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_30, y = val_24.y, z = val_24.z}, b:  new UnityEngine.Vector3() {x = this.<>4__this.lastPOS, y = val_23.w, z = val_23.z});
        this.<>4__this.m_transform.forward = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        label_26:
        val_27 = 1;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        this.<>1__state = val_27;
        return (bool)val_27;
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
