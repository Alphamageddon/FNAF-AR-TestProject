using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class WarpTextExample.<WarpText>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TMPro.Examples.WarpTextExample <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float <old_CurveScale>5__2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.AnimationCurve <old_curve>5__3;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public WarpTextExample.<WarpText>d__8(int <>1__state)
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
        float val_9;
        float val_12;
        TMPro.TMP_CharacterInfo[] val_45;
        WarpTextExample.<WarpText>d__8 val_46;
        float val_47;
        var val_48;
        float val_49;
        int val_50;
        TMPro.TMP_Text val_51;
        float val_52;
        var val_53;
        var val_54;
        var val_55;
        object val_56;
        int val_57;
        val_46 = this;
        val_47 = 0;
        if(((this.<>1__state) == 2) || ((this.<>1__state) == 1))
        {
            goto label_2;
        }
        
        val_48 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_48;
        }
        
        this.<>1__state = 0;
        this.<>4__this.VertexCurve.preWrapMode = 1;
        this.<>4__this.VertexCurve.postWrapMode = 1;
        this.<>4__this.m_TextComponent.havePropertiesChanged = true;
        val_47 = (this.<>4__this.CurveScale) * 10f;
        this.<>4__this.CurveScale = val_47;
        this.<old_CurveScale>5__2 = val_47;
        this.<old_curve>5__3 = this.<>4__this.m_TextComponent.CopyAnimationCurve(curve:  this.<>4__this.VertexCurve);
        if((this.<>4__this) != null)
        {
            goto label_10;
        }
        
        goto label_9;
        label_2:
        this.<>1__state = 0;
        label_24:
        if((this.<>4__this) != null)
        {
            goto label_10;
        }
        
        label_9:
        label_10:
        if((this.<>4__this.m_TextComponent.havePropertiesChanged) == true)
        {
            goto label_13;
        }
        
        val_47 = this.<old_CurveScale>5__2;
        if(val_47 != (this.<>4__this.CurveScale))
        {
            goto label_13;
        }
        
        val_49 = val_47;
        if(val_49 == val_47)
        {
            goto label_20;
        }
        
        label_13:
        this.<old_CurveScale>5__2 = this.<>4__this.CurveScale;
        this.<old_curve>5__3 = this.<>4__this.VertexCurve.keys[60].CopyAnimationCurve(curve:  this.<>4__this.VertexCurve);
        TMPro.TMP_TextInfo val_6 = this.<>4__this.m_TextComponent.textInfo;
        val_50 = val_6.characterCount;
        if(val_50 == 0)
        {
            goto label_24;
        }
        
        UnityEngine.Bounds val_7 = this.<>4__this.m_TextComponent.bounds;
        val_51 = this.<>4__this.m_TextComponent;
        UnityEngine.Bounds val_10 = val_51.bounds;
        if(val_50 >= 1)
        {
                val_52 = val_12 - val_9;
            val_53 = 0;
            val_54 = 368;
            val_51 = 12;
            do
        {
            val_45 = val_6.characterInfo;
            if(val_45[42] != 0)
        {
                val_6.characterInfo[368] = val_6.characterInfo[368] - 260;
            val_6.characterInfo[368] = val_6.characterInfo[368] - 280;
            TMPro.TMP_CharacterInfo[] val_13 = val_6.meshInfo + (1152921508539887296 * 72);
            val_55 = mem[mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 24];
            val_55 = mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 24;
            if(null >= val_55)
        {
                val_55 = mem[mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 24];
            val_55 = mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 24;
        }
        
            TMPro.TMP_CharacterInfo[] val_14 = (mem[(1152921508539887296 * 72) + val_6.meshInfo + 48]) + (1152921508539887296 * val_51);
            var val_50 = (long)(long)(int)((1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32);
            var val_15 = (mem[(1152921508539887296 * 72) + val_6.meshInfo + 48]) + (val_50 * val_51);
            float val_16 = (mem[(1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32]) + (((long)(int)((1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32) * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32);
            val_16 = val_16 * 0.5f;
            UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  val_16, y:  -7.175961E+25f);
            UnityEngine.Vector3 val_18 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y});
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            TMPro.TMP_CharacterInfo[] val_20 = (mem[(1152921508539887296 * 72) + val_6.meshInfo + 48]) + (1152921508539887296 * val_51);
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32, y = (1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 40 + -4, z = mem[(1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 40]}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
            mem2[0] = val_21.x;
            mem2[0] = val_21.y;
            mem2[0] = val_21.z;
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            var val_23 = (mem[(1152921508539887296 * 72) + val_6.meshInfo + 48]) + (((long)(long)(int)((1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32)) * val_51);
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = ((long)(int)((1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32) * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 40 + -8, y = ((long)(int)((1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32) * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 40 + -4, z = ((long)(int)((1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32) * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 40}, b:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
            mem2[0] = val_24.x;
            mem2[0] = val_24.y;
            mem2[0] = val_24.z;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            val_50 = (mem[(1152921508539887296 * 72) + val_6.meshInfo + 48]) + (val_50 * val_51);
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = ((long)(int)((1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32) * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32, y = ((long)(int)((1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32) * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 40 + -4, z = ((long)(int)((1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32) * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 40}, b:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
            mem2[0] = val_26.x;
            mem2[0] = val_26.y;
            mem2[0] = val_26.z;
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            var val_28 = (mem[(1152921508539887296 * 72) + val_6.meshInfo + 48]) + (((long)(long)(int)((1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32)) * val_51);
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = ((long)(int)((1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32) * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 40 + -8, y = ((long)(int)((1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32) * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 40 + -4, z = ((long)(int)((1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32) * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 40}, b:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z});
            mem2[0] = val_29.x;
            float val_30 = val_18.x - val_9;
            mem2[0] = val_29.y;
            mem2[0] = val_29.z;
            val_30 = val_30 / val_52;
            float val_31 = val_30 + 0.0001f;
            float val_33 = (this.<>4__this.VertexCurve.Evaluate(time:  val_30)) * (this.<>4__this.CurveScale);
            val_30 = (this.<>4__this.VertexCurve.Evaluate(time:  val_31)) * (this.<>4__this.CurveScale);
            val_9 = 0;
            float val_35 = val_52 * val_31;
            val_35 = val_9 + val_35;
            val_12 = 0;
            UnityEngine.Vector3 val_36 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            float val_51 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rhs:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z});
            val_51 = val_51 * 57.29578f;
            UnityEngine.Vector3 val_38 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rhs:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z});
            float val_52 = 360f;
            val_52 = val_52 - val_51;
            val_51 = (val_38.z > 0f) ? (val_51) : (val_52);
            val_12 = 0;
            UnityEngine.Quaternion val_39 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  val_51);
            UnityEngine.Vector3 val_40 = UnityEngine.Vector3.one;
            UnityEngine.Matrix4x4 val_41 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, q:  new UnityEngine.Quaternion() {x = val_39.x, y = val_39.y, z = val_39.z, w = val_39.w}, s:  new UnityEngine.Vector3() {x = val_40.x, y = val_40.z});
            val_52 = val_52;
            mem2[0] = (1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32;
            mem2[0] = (1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 40 + -4;
            mem2[0] = (1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 40;
            mem2[0] = ((long)(int)((1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32) * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 40 + -8;
            mem2[0] = ((long)(int)((1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32) * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 40 + -4;
            mem2[0] = ((long)(int)((1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32) * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 40;
            mem2[0] = ((long)(int)((1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32) * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32;
            mem2[0] = ((long)(int)((1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32) * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 40 + -4;
            mem2[0] = ((long)(int)((1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32) * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 40;
            mem2[0] = ((long)(int)((1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32) * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 40 + -8;
            mem2[0] = ((long)(int)((1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32) * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 40 + -4;
            mem2[0] = ((long)(int)((1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32) * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 40;
            val_49 = val_18.y;
            UnityEngine.Vector3 val_44 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32, y = (1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 40 + -4, z = (1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 40}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_49, z = val_18.z});
            mem2[0] = val_44.x;
            mem2[0] = val_44.y;
            mem2[0] = val_44.z;
            UnityEngine.Vector3 val_45 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = ((long)(int)((1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32) * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 40 + -8, y = ((long)(int)((1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32) * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 40 + -4, z = ((long)(int)((1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32) * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 40}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_49, z = val_18.z});
            mem2[0] = val_45.x;
            mem2[0] = val_45.y;
            mem2[0] = val_45.z;
            val_54 = 368;
            val_51 = 12;
            UnityEngine.Vector3 val_46 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = ((long)(int)((1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32) * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32, y = ((long)(int)((1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32) * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 40 + -4, z = ((long)(int)((1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32) * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 40}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_49, z = val_18.z});
            mem2[0] = val_46.x;
            mem2[0] = val_46.y;
            mem2[0] = val_46.z;
            val_53 = val_53;
            val_45 = ((long)(int)((1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32) * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 40 + -8;
            UnityEngine.Vector3 val_47 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_45, y = ((long)(int)((1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32) * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 40 + -4, z = ((long)(int)((1152921508539887296 * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 32) * val_51) + mem[(1152921508539887296 * 72) + val_6.meshInfo + 48] + 40}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_49, z = val_18.z});
            mem2[0] = val_47.x;
            mem2[0] = val_47.y;
            mem2[0] = val_47.z;
            val_50 = val_50;
        }
        
            val_53 = val_53 + 1;
            val_54 = val_54 + 344;
        }
        while(val_50 != val_53);
        
        }
        
        val_46 = val_46;
        UnityEngine.WaitForSeconds val_48 = null;
        val_56 = val_48;
        val_48 = new UnityEngine.WaitForSeconds(seconds:  0.025f);
        val_57 = 2;
        goto label_76;
        label_20:
        val_56 = 0;
        val_57 = 1;
        label_76:
        val_48 = 1;
        this.<>2__current = val_56;
        this.<>1__state = val_57;
        return (bool)val_48;
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
