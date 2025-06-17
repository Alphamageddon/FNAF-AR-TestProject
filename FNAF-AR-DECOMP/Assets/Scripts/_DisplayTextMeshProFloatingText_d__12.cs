using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class TextMeshProFloatingText.<DisplayTextMeshProFloatingText>d__12 : IEnumerator<object>, IEnumerator, IDisposable
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
    public TextMeshProFloatingText.<DisplayTextMeshProFloatingText>d__12(int <>1__state)
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
        int val_26;
        float val_27;
        TMPro.TextMeshPro val_28;
        UnityEngine.Vector3 val_29;
        float val_31;
        float val_32;
        float val_33;
        float val_34;
        float val_35;
        float val_36;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_26 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_26;
        }
        
        this.<>1__state = 0;
        this.<CountDuration>5__2 = 2f;
        float val_1 = UnityEngine.Random.Range(min:  5f, max:  20f);
        this.<starting_Count>5__3 = val_1;
        this.<current_Count>5__4 = val_1;
        val_27 = this.<current_Count>5__4;
        UnityEngine.Vector3 val_2 = this.<>4__this.m_floatingText_Transform.position;
        this.<start_pos>5__5 = val_2;
        mem[1152921524666938984] = val_2.y;
        mem[1152921524666938988] = val_2.z;
        val_28 = this.<>4__this.m_textMeshPro;
        UnityEngine.Color32 val_3 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_2.x, g = val_2.y, b = val_2.z});
        this.<start_color>5__6 = val_3;
        this.<alpha>5__7 = 255f;
        float val_26 = this.<starting_Count>5__3;
        val_26 = 3f / val_26;
        val_26 = val_26 * (this.<CountDuration>5__2);
        this.<fadeDuration>5__8 = val_26;
        goto label_7;
        label_1:
        this.<>1__state = 0;
        val_28 = this.<>4__this.m_floatingText_Transform;
        val_29 = this.<start_pos>5__5;
        val_28.position = new UnityEngine.Vector3() {x = val_29, y = V9.16B, z = V10.16B};
        UnityEngine.Coroutine val_5 = this.<>4__this.StartCoroutine(routine:  this.<>4__this.DisplayTextMeshProFloatingText());
        val_26 = 0;
        return (bool)val_26;
        label_2:
        val_27 = this.<current_Count>5__4;
        this.<>1__state = 0;
        label_7:
        if(val_27 <= 0f)
        {
                val_29 = UnityEngine.Random.Range(min:  0.1f, max:  1f);
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  val_29);
            this.<>1__state = 2;
            val_26 = 1;
            return (bool)val_26;
        }
        
        float val_8 = UnityEngine.Time.deltaTime;
        val_31 = this.<starting_Count>5__3;
        val_8 = val_8 / (this.<CountDuration>5__2);
        val_8 = val_8 * val_31;
        val_32 = val_27 - val_8;
        this.<current_Count>5__4 = val_32;
        if(val_32 <= 3f)
        {
                float val_9 = UnityEngine.Time.deltaTime;
            val_31 = 255f;
            val_9 = val_9 / (this.<fadeDuration>5__8);
            val_9 = val_9 * val_31;
            val_9 = (this.<alpha>5__7) - val_9;
            val_32 = this.<current_Count>5__4;
            this.<alpha>5__7 = UnityEngine.Mathf.Clamp(value:  val_9, min:  0f, max:  val_31);
        }
        
        this.<>4__this.m_textMeshPro.text = (int)val_32.ToString();
        UnityEngine.Color val_12 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
        UnityEngine.Vector3 val_13 = this.<>4__this.m_floatingText_Transform.position;
        float val_15 = (this.<starting_Count>5__3) * UnityEngine.Time.deltaTime;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.<>4__this.m_floatingText_Transform.position = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
        UnityEngine.Vector3 val_17 = this.<>4__this.m_cameraTransform.position;
        val_33 = val_17.x;
        val_34 = this.<>4__this.lastPOS;
        val_35 = val_16.y;
        val_36 = val_16.z;
        if((TMPro.TMPro_ExtensionMethods.Compare(v1:  new UnityEngine.Vector3() {x = val_34, y = val_35, z = val_36}, v2:  new UnityEngine.Vector3() {x = val_33, y = val_17.y, z = val_17.z}, accuracy:  232)) == false)
        {
            goto label_24;
        }
        
        val_29 = this.<>4__this.lastRotation;
        val_28 = this.<>4__this.m_cameraTransform;
        UnityEngine.Quaternion val_19 = val_28.rotation;
        val_34 = val_29;
        val_35 = val_16.y;
        val_36 = this.<starting_Count>5__3;
        val_33 = val_16.z;
        if((TMPro.TMPro_ExtensionMethods.Compare(q1:  new UnityEngine.Quaternion() {x = val_34, y = val_35, z = val_36, w = val_33}, q2:  new UnityEngine.Quaternion() {x = val_19.x, y = val_19.y, z = val_19.z, w = val_19.w}, accuracy:  232)) == true)
        {
            goto label_26;
        }
        
        label_24:
        UnityEngine.Vector3 val_21 = this.<>4__this.m_cameraTransform.position;
        this.<>4__this.lastPOS = val_21;
        mem2[0] = val_21.y;
        mem2[0] = val_21.z;
        UnityEngine.Quaternion val_22 = this.<>4__this.m_cameraTransform.rotation;
        this.<>4__this.lastRotation = val_22;
        mem2[0] = val_22.y;
        mem2[0] = val_22.z;
        mem2[0] = val_22.w;
        this.<>4__this.m_floatingText_Transform.rotation = new UnityEngine.Quaternion() {x = val_22.x, y = val_22.y, z = val_22.z, w = val_22.w};
        val_28 = this.<>4__this.m_transform;
        UnityEngine.Vector3 val_23 = val_28.position;
        val_29 = val_23.x;
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_29, y = val_23.y, z = val_23.z}, b:  new UnityEngine.Vector3() {x = this.<>4__this.lastPOS, y = val_22.w, z = val_22.z});
        this.<>4__this.m_transform.forward = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        label_26:
        val_26 = 1;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        this.<>1__state = val_26;
        return (bool)val_26;
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
