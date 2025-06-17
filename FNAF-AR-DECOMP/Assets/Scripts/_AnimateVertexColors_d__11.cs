using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class VertexShakeA.<AnimateVertexColors>d__11 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TMPro.Examples.VertexShakeA <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private TMPro.TMP_TextInfo <textInfo>5__2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Vector3[][] <copyOfVertices>5__3;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public VertexShakeA.<AnimateVertexColors>d__11(int <>1__state)
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
        VertexShakeA.<AnimateVertexColors>d__11 val_69;
        var val_70;
        TMPro.TMP_TextInfo val_71;
        var val_72;
        var val_73;
        var val_74;
        var val_75;
        var val_76;
        float val_77;
        float val_78;
        float val_80;
        float val_81;
        UnityEngine.WaitForSeconds val_82;
        int val_83;
        var val_84;
        val_69 = this;
        if(((this.<>1__state) - 1) >= 2)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
            goto label_2;
        }
        
        goto label_8;
        label_1:
        if((this.<>1__state) != 0)
        {
            goto label_4;
        }
        
        this.<>1__state = 0;
        this.<textInfo>5__2 = this.<>4__this.m_TextComponent.textInfo;
        this.<copyOfVertices>5__3 = new UnityEngine.Vector3[][0];
        this.<>4__this.hasTextChanged = true;
        goto label_8;
        label_4:
        val_70 = 0;
        return (bool)val_70;
        label_2:
        label_8:
        if((this.<>4__this.hasTextChanged) == false)
        {
            goto label_10;
        }
        
        val_71 = val_69;
        if((this.<copyOfVertices>5__3.Length) < (this.<textInfo>5__2.meshInfo.Length))
        {
                this.<copyOfVertices>5__3 = new UnityEngine.Vector3[][0];
        }
        
        val_72 = 72;
        goto label_17;
        label_30:
        val_73 = 0;
        UnityEngine.Vector3[] val_5 = new UnityEngine.Vector3[0];
        if((this.<copyOfVertices>5__3) == null)
        {
            goto label_22;
        }
        
        if(val_5 != null)
        {
            goto label_23;
        }
        
        goto label_26;
        label_22:
        if(val_5 == null)
        {
            goto label_26;
        }
        
        label_23:
        label_26:
        this.<copyOfVertices>5__3[val_73] = val_5;
        label_17:
        if(1 < val_2.meshInfo.Length)
        {
            goto label_30;
        }
        
        this.<>4__this.hasTextChanged = false;
        goto label_32;
        label_10:
        val_71 = this.<textInfo>5__2;
        label_32:
        val_74 = mem[this.<textInfo>5__2];
        if((mem[this.<textInfo>5__2] + 24) == 0)
        {
            goto label_34;
        }
        
        if((mem[this.<textInfo>5__2] + 44) <= 0)
        {
            goto label_36;
        }
        
        val_73 = 344;
        do
        {
            var val_79 = 3670080;
            val_75 = 1769500;
            val_76 = 3670080;
            val_77 = mem[608708300];
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = mem[1262507804], y = mem[1262507808], z = mem[1262507812]}, b:  new UnityEngine.Vector3() {x = mem[608708296], y = val_77, z = mem[608708304]});
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  2f);
            val_78 = UnityEngine.Random.Range(min:  -0.25f, max:  0.25f);
            UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  val_78 * (this.<>4__this + 36));
            if(val_79 <= val_75)
        {
                do
        {
            val_76 = mem[mem[this.<textInfo>5__2] + 56];
            val_76 = mem[this.<textInfo>5__2] + 56;
            var val_11 = val_76 + (3670080 * 344);
            if(((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 368) != 0)
        {
                var val_12 = (mem[this.<textInfo>5__2] + 56) + (3670080 * 344);
            var val_13 = (mem[this.<textInfo>5__2] + 56) + (3670080 * 344);
            var val_14 = (mem[this.<textInfo>5__2] + 96) + (((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) * 72);
            var val_15 = (mem[this.<copyOfVertices>5__3]) + (((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3);
            var val_16 = (((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88 * 72) + mem[this.<textInfo>5__2] + 96 + 48) + (((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108) * 12);
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 * 12) + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88 * 72) + mem[this.<textInfo>5__2] + 96 + 48 + 32, y = ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 * 12) + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88 * 72) + mem[this.<textInfo>5__2] + 96 + 48 + 32 + 4, z = ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 * 12) + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88 * 72) + mem[this.<textInfo>5__2] + 96 + 48 + 40}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            var val_18 = ((mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32) + (((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108) * 12);
            mem2[0] = val_17.x;
            mem2[0] = val_17.y;
            mem2[0] = val_17.z;
            var val_19 = (mem[this.<copyOfVertices>5__3]) + (((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3);
            val_76 = (long)((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108) + 1;
            var val_21 = (((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88 * 72) + mem[this.<textInfo>5__2] + 96 + 48) + (val_76 * 12);
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = ((long)(int)(((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 + 1)) * 12) + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88 * 72) + mem[this.<textInfo>5__2] + 96 + 48 + 32, y = ((long)(int)(((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 + 1)) * 12) + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88 * 72) + mem[this.<textInfo>5__2] + 96 + 48 + 32 + 4, z = ((long)(int)(((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 + 1)) * 12) + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88 * 72) + mem[this.<textInfo>5__2] + 96 + 48 + 40}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            var val_23 = ((mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32) + (val_76 * 12);
            mem2[0] = val_22.x;
            mem2[0] = val_22.y;
            mem2[0] = val_22.z;
            var val_24 = (mem[this.<copyOfVertices>5__3]) + (((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3);
            var val_26 = (((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88 * 72) + mem[this.<textInfo>5__2] + 96 + 48) + (((long)((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108) + 2) * 12);
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = ((long)(int)(((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 + 2)) * 12) + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88 * 72) + mem[this.<textInfo>5__2] + 96 + 48 + 32, y = ((long)(int)(((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 + 2)) * 12) + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88 * 72) + mem[this.<textInfo>5__2] + 96 + 48 + 32 + 4, z = ((long)(int)(((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 + 2)) * 12) + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88 * 72) + mem[this.<textInfo>5__2] + 96 + 48 + 40}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            var val_28 = ((mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32) + (((long)((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108) + 2) * 12);
            mem2[0] = val_27.x;
            mem2[0] = val_27.y;
            mem2[0] = val_27.z;
            var val_29 = (mem[this.<copyOfVertices>5__3]) + (((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3);
            var val_31 = (((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88 * 72) + mem[this.<textInfo>5__2] + 96 + 48) + (((long)((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108) + 3) * 12);
            UnityEngine.Vector3 val_32 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = ((long)(int)(((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 + 3)) * 12) + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88 * 72) + mem[this.<textInfo>5__2] + 96 + 48 + 32, y = ((long)(int)(((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 + 3)) * 12) + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88 * 72) + mem[this.<textInfo>5__2] + 96 + 48 + 32 + 4, z = ((long)(int)(((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 + 3)) * 12) + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88 * 72) + mem[this.<textInfo>5__2] + 96 + 48 + 40}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            var val_33 = ((mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32) + (((long)((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108) + 3) * 12);
            mem2[0] = val_32.x;
            mem2[0] = val_32.y;
            mem2[0] = val_32.z;
            if((1 & 1) != 0)
        {
                val_80 = mem[this.<>4__this + 32];
            val_80 = this.<>4__this + 32;
            val_81 = mem[this.<>4__this + 32];
            val_81 = this.<>4__this + 32;
        }
        else
        {
                val_81 = mem[this.<>4__this + 32];
            val_81 = this.<>4__this + 32;
            val_80 = val_81;
        }
        
            float val_72 = 0.001f;
            val_72 = val_81 * val_72;
            float val_73 = 0.995f;
            val_73 = val_73 - (val_80 * val_72);
            float val_74 = 1.005f;
            val_74 = val_72 + val_74;
            UnityEngine.Vector3 val_36 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_37 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z}, d:  UnityEngine.Random.Range(min:  val_73, max:  val_74));
            val_78 = val_38.x;
            UnityEngine.Matrix4x4 val_39 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z}, q:  new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w}, s:  new UnityEngine.Vector3() {x = val_78, y = val_38.z});
            var val_44 = (mem[this.<copyOfVertices>5__3]) + (((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3);
            var val_45 = (mem[this.<copyOfVertices>5__3]) + (((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3);
            var val_46 = ((mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32) + (((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108) * 12);
            var val_47 = ((mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32) + (((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108) * 12);
            mem2[0] = ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 * 12) + (mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32 + 32;
            mem2[0] = ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 * 12) + (mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32 + 32 + 4;
            mem2[0] = ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 * 12) + (mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32 + 40;
            var val_48 = (mem[this.<copyOfVertices>5__3]) + (((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3);
            var val_49 = (mem[this.<copyOfVertices>5__3]) + (((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3);
            var val_50 = ((mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32) + (val_76 * 12);
            var val_51 = ((mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32) + (val_76 * 12);
            mem2[0] = ((long)(int)(((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 + 1)) * 12) + (mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32 + 32;
            mem2[0] = ((long)(int)(((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 + 1)) * 12) + (mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32 + 32 + 4;
            mem2[0] = ((long)(int)(((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 + 1)) * 12) + (mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32 + 40;
            var val_52 = (mem[this.<copyOfVertices>5__3]) + (((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3);
            var val_53 = (mem[this.<copyOfVertices>5__3]) + (((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3);
            var val_54 = ((mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32) + (((long)((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108) + 2) * 12);
            var val_55 = ((mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32) + (((long)((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108) + 2) * 12);
            mem2[0] = ((long)(int)(((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 + 2)) * 12) + (mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32 + 32;
            mem2[0] = ((long)(int)(((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 + 2)) * 12) + (mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32 + 32 + 4;
            mem2[0] = ((long)(int)(((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 + 2)) * 12) + (mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32 + 40;
            var val_56 = (mem[this.<copyOfVertices>5__3]) + (((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3);
            var val_57 = (mem[this.<copyOfVertices>5__3]) + (((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3);
            var val_58 = ((mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32) + (((long)((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108) + 3) * 12);
            val_77 = ((long)(int)(((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 + 3)) * 12) + (mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32 + 32;
            var val_59 = ((mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32) + (((long)((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108) + 3) * 12);
            mem2[0] = val_77;
            mem2[0] = ((long)(int)(((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 + 3)) * 12) + (mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32 + 32 + 4;
            mem2[0] = ((long)(int)(((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 + 3)) * 12) + (mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32 + 40;
            var val_60 = (mem[this.<copyOfVertices>5__3]) + (((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3);
            var val_75 = (mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32;
            val_75 = val_75 + (((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108) * 12);
            UnityEngine.Vector3 val_61 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 * 12) + (mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32 + 32, y = ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 * 12) + (mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32 + 32 + 4, z = ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 * 12) + (mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32 + 40}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            mem2[0] = val_61.x;
            mem2[0] = val_61.y;
            mem2[0] = val_61.z;
            val_75 = val_75;
            var val_62 = (mem[this.<copyOfVertices>5__3]) + (((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3);
            var val_76 = (mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32;
            val_76 = val_76 + (val_76 * 12);
            UnityEngine.Vector3 val_63 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = ((long)(int)(((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 + 1)) * 12) + (mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32 + 32, y = ((long)(int)(((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 + 1)) * 12) + (mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32 + 32 + 4, z = ((long)(int)(((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 + 1)) * 12) + (mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32 + 40}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            mem2[0] = val_63.x;
            mem2[0] = val_63.y;
            mem2[0] = val_63.z;
            var val_64 = (mem[this.<copyOfVertices>5__3]) + (((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3);
            var val_77 = (mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32;
            val_77 = val_77 + (((long)((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108) + 2) * 12);
            UnityEngine.Vector3 val_65 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = ((long)(int)(((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 + 2)) * 12) + (mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32 + 32, y = ((long)(int)(((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 + 2)) * 12) + (mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32 + 32 + 4, z = ((long)(int)(((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 + 2)) * 12) + (mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32 + 40}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            mem2[0] = val_65.x;
            mem2[0] = val_65.y;
            mem2[0] = val_65.z;
            val_73 = 344;
            var val_66 = (mem[this.<copyOfVertices>5__3]) + (((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3);
            var val_78 = (mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32;
            val_78 = val_78 + (((long)((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108) + 3) * 12);
            UnityEngine.Vector3 val_67 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = ((long)(int)(((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 + 3)) * 12) + (mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32 + 32, y = ((long)(int)(((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 + 3)) * 12) + (mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32 + 32 + 4, z = ((long)(int)(((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 108 + 3)) * 12) + (mem[this.<copyOfVertices>5__3] + ((3670080 * 344) + mem[this.<textInfo>5__2] + 56 + 88) << 3) + 32 + 40}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            mem2[0] = val_67.x;
            mem2[0] = val_67.y;
            mem2[0] = val_67.z;
            val_71 = val_71;
        }
        
            val_79 = val_79 + 1;
        }
        while(val_79 <= val_75);
        
        }
        
            var val_80 = 0;
            val_80 = val_80 + 1;
        }
        while(val_80 != (mem[this.<textInfo>5__2] + 44));
        
        goto label_145;
        label_34:
        UnityEngine.WaitForSeconds val_68 = null;
        val_82 = val_68;
        val_68 = new UnityEngine.WaitForSeconds(seconds:  0.25f);
        val_83 = 1;
        goto label_146;
        label_36:
        label_145:
        val_84 = 0;
        val_74 = 72;
        goto label_147;
        label_161:
        val_73 = 0;
        var val_69 = (mem[this.<copyOfVertices>5__3]) + 0;
        64.vertices = (mem[this.<copyOfVertices>5__3] + 0) + 32;
        var val_70 = (mem[this.<textInfo>5__2] + 96) + (val_73 * 72);
        val_84 = 1;
        label_147:
        val_72 = mem[mem[this.<textInfo>5__2] + 96];
        val_72 = mem[this.<textInfo>5__2] + 96;
        if(val_84 < (mem[this.<textInfo>5__2] + 96 + 24))
        {
            goto label_161;
        }
        
        UnityEngine.WaitForSeconds val_71 = null;
        val_82 = val_71;
        val_71 = new UnityEngine.WaitForSeconds(seconds:  0.1f);
        val_69 = val_69;
        val_83 = 2;
        label_146:
        val_70 = 1;
        mem[1152921524683428264] = val_82;
        this.<>1__state = val_83;
        return (bool)val_70;
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
