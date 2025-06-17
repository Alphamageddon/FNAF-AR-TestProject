using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class SkewTextExample.<WarpText>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TMPro.Examples.SkewTextExample <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float <old_CurveScale>5__2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float <old_ShearValue>5__3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.AnimationCurve <old_curve>5__4;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SkewTextExample.<WarpText>d__7(int <>1__state)
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
        TMPro.TMP_CharacterInfo[] val_55;
        SkewTextExample.<WarpText>d__7 val_56;
        var val_57;
        float val_58;
        int val_59;
        TMPro.TMP_Text val_60;
        float val_61;
        var val_62;
        var val_63;
        val_56 = this;
        if(((this.<>1__state) == 2) || ((this.<>1__state) == 1))
        {
            goto label_2;
        }
        
        val_57 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_57;
        }
        
        this.<>1__state = 0;
        this.<>4__this.VertexCurve.preWrapMode = 1;
        this.<>4__this.VertexCurve.postWrapMode = 1;
        this.<>4__this.m_TextComponent.havePropertiesChanged = true;
        float val_53 = this.<>4__this.CurveScale;
        val_53 = val_53 * 10f;
        this.<>4__this.CurveScale = val_53;
        this.<old_CurveScale>5__2 = val_53;
        this.<old_ShearValue>5__3 = this.<>4__this.ShearAmount;
        this.<old_curve>5__4 = this.<>4__this.m_TextComponent.CopyAnimationCurve(curve:  this.<>4__this.VertexCurve);
        if((this.<>4__this) != null)
        {
            goto label_10;
        }
        
        goto label_9;
        label_2:
        this.<>1__state = 0;
        label_25:
        if((this.<>4__this) != null)
        {
            goto label_10;
        }
        
        label_9:
        label_10:
        if(((this.<>4__this.m_TextComponent.havePropertiesChanged) != true) && ((this.<old_CurveScale>5__2) == (this.<>4__this.CurveScale)))
        {
                val_58 = this.<old_CurveScale>5__2;
            if(val_58 == (this.<old_CurveScale>5__2))
        {
                if((this.<old_ShearValue>5__3) == (this.<>4__this.ShearAmount))
        {
            goto label_89;
        }
        
        }
        
        }
        
        this.<old_CurveScale>5__2 = this.<>4__this.CurveScale;
        this.<old_curve>5__4 = this.<>4__this.VertexCurve.keys[60].CopyAnimationCurve(curve:  this.<>4__this.VertexCurve);
        this.<old_ShearValue>5__3 = this.<>4__this.ShearAmount;
        TMPro.TMP_TextInfo val_6 = this.<>4__this.m_TextComponent.textInfo;
        val_59 = val_6.characterCount;
        if(val_59 == 0)
        {
            goto label_25;
        }
        
        UnityEngine.Bounds val_7 = this.<>4__this.m_TextComponent.bounds;
        val_60 = this.<>4__this.m_TextComponent;
        UnityEngine.Bounds val_10 = val_60.bounds;
        if(val_59 >= 1)
        {
                val_61 = val_12 - val_9;
            var val_60 = 0;
            val_62 = 368;
            val_63 = 12;
            do
        {
            val_55 = val_6.characterInfo;
            if(val_55[42] != 0)
        {
                val_6.characterInfo[368] = val_6.characterInfo[368] - 260;
            val_6.characterInfo[368] = val_6.characterInfo[368] - 280;
            float val_13 = (mem[-4611685971230904032]) + (mem[-4343123656]);
            val_13 = val_13 * 0.5f;
            UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  val_13, y:  -7.175961E+25f);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = mem[-4611685971230904032], y = mem[-4611685971230904028], z = mem[-4611685971230904024]}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
            mem2[-4611685971230904032] = val_17.x;
            mem2[-4611685971230904028] = val_17.y;
            mem2[-4611685971230904024] = val_17.z;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = mem[-4343123668], y = mem[-4343123664], z = mem[-4343123660]}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            mem2[-4343123668] = val_19.x;
            mem2[-4343123664] = val_19.y;
            mem2[-4343123660] = val_19.z;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = mem[-4343123656], y = mem[-4343123652], z = mem[-4343123648]}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
            mem2[-4343123656] = val_21.x;
            mem2[-4343123652] = val_21.y;
            mem2[-4343123648] = val_21.z;
            val_62 = 368;
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = mem[-4343123644], y = mem[-4343123640], z = mem[-4343123636]}, b:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
            mem2[-4343123644] = val_23.x;
            mem2[-4343123640] = val_23.y;
            mem2[-4343123636] = val_23.z;
            float val_55 = this.<>4__this.ShearAmount;
            var val_24 = (val_6 + 56) + val_62;
            val_55 = val_55 * 0.01f;
            var val_25 = (val_6 + 56) + val_62;
            float val_56 = (val_6 + 56 + val_62) + -40;
            val_56 = ((val_6 + 56 + val_62) + -68) - val_56;
            val_56 = val_55 * val_56;
            var val_26 = (val_6 + 56) + val_62;
            var val_27 = (val_6 + 56) + val_62;
            float val_57 = (val_6 + 56 + val_62) + -56;
            val_57 = ((val_6 + 56 + val_62) + -40) - val_57;
            val_57 = val_55 * val_57;
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = mem[-4611685971230904032], y = mem[-4611685971230904028], z = mem[-4611685971230904024]}, b:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
            mem2[-4611685971230904032] = val_29.x;
            mem2[-4611685971230904028] = val_29.y;
            mem2[-4611685971230904024] = val_29.z;
            UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = mem[-4343123668], y = mem[-4343123664], z = mem[-4343123660]}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            mem2[-4343123668] = val_30.x;
            mem2[-4343123664] = val_30.y;
            mem2[-4343123660] = val_30.z;
            UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = mem[-4343123656], y = mem[-4343123652], z = mem[-4343123648]}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            mem2[-4343123656] = val_31.x;
            mem2[-4343123652] = val_31.y;
            mem2[-4343123648] = val_31.z;
            UnityEngine.Vector3 val_32 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = mem[-4343123644], y = mem[-4343123640], z = mem[-4343123636]}, b:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z});
            mem2[-4343123644] = val_33.x;
            mem2[-4343123640] = val_33.y;
            mem2[-4343123636] = val_33.z;
            float val_35 = (val_15.x - val_9) / val_61;
            float val_36 = val_35 + 0.0001f;
            float val_38 = (this.<>4__this.VertexCurve.Evaluate(time:  val_35)) * (this.<>4__this.CurveScale);
            val_35 = (this.<>4__this.VertexCurve.Evaluate(time:  val_36)) * (this.<>4__this.CurveScale);
            val_9 = 0;
            float val_40 = val_61 * val_36;
            val_40 = val_9 + val_40;
            val_12 = 0;
            UnityEngine.Vector3 val_41 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            float val_58 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rhs:  new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_41.z});
            val_58 = val_58 * 57.29578f;
            UnityEngine.Vector3 val_43 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rhs:  new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_41.z});
            float val_59 = 360f;
            val_59 = val_59 - val_58;
            val_58 = (val_43.z > 0f) ? (val_58) : (val_59);
            val_12 = 0;
            UnityEngine.Quaternion val_44 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  val_58);
            UnityEngine.Vector3 val_45 = UnityEngine.Vector3.one;
            UnityEngine.Matrix4x4 val_46 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, q:  new UnityEngine.Quaternion() {x = val_44.x, y = val_44.y, z = val_44.z, w = val_44.w}, s:  new UnityEngine.Vector3() {x = val_45.x, y = val_45.z});
            val_61 = val_61;
            mem2[-4611685971230904032] = mem[-4611685971230904032];
            mem2[-4611685971230904028] = mem[-4611685971230904028];
            mem2[-4611685971230904024] = mem[-4611685971230904024];
            mem2[-4343123668] = mem[-4343123668];
            mem2[-4343123664] = mem[-4343123664];
            mem2[-4343123660] = mem[-4343123660];
            mem2[-4343123656] = mem[-4343123656];
            mem2[-4343123652] = mem[-4343123652];
            mem2[-4343123648] = mem[-4343123648];
            mem2[-4343123644] = mem[-4343123644];
            mem2[-4343123640] = mem[-4343123640];
            mem2[-4343123636] = mem[-4343123636];
            val_58 = val_15.y;
            UnityEngine.Vector3 val_49 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = mem[-4611685971230904032], y = mem[-4611685971230904028], z = mem[-4611685971230904024]}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_58, z = val_15.z});
            mem2[-4611685971230904032] = val_49.x;
            mem2[-4611685971230904028] = val_49.y;
            mem2[-4611685971230904024] = val_49.z;
            UnityEngine.Vector3 val_50 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = mem[-4343123668], y = mem[-4343123664], z = mem[-4343123660]}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_58, z = val_15.z});
            mem2[-4343123668] = val_50.x;
            mem2[-4343123664] = val_50.y;
            mem2[-4343123660] = val_50.z;
            UnityEngine.Vector3 val_51 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = mem[-4343123656], y = mem[-4343123652], z = mem[-4343123648]}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_58, z = val_15.z});
            mem2[-4343123656] = val_51.x;
            mem2[-4343123652] = val_51.y;
            mem2[-4343123648] = val_51.z;
            val_55 = -48156348;
            val_60 = -48156340;
            UnityEngine.Vector3 val_52 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = mem[-4343123644], y = mem[-4343123640], z = mem[-4343123636]}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_58, z = val_15.z});
            mem2[-4343123644] = val_52.x;
            mem2[-4343123640] = val_52.y;
            mem2[-4343123636] = val_52.z;
            val_59 = val_59;
            val_63 = 12;
        }
        
            val_60 = val_60 + 1;
            val_62 = val_62 + 344;
        }
        while(val_59 != val_60);
        
        }
        
        val_56 = val_56;
        label_89:
        val_57 = 1;
        mem[1152921524661220856] = 0;
        this.<>1__state = 2;
        return (bool)val_57;
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
