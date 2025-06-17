using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class VertexZoom.<AnimateVertexColors>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TMPro.Examples.VertexZoom <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private TMPro.Examples.VertexZoom.<>c__DisplayClass10_0 <>8__1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private TMPro.TMP_TextInfo <textInfo>5__2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private TMPro.TMP_MeshInfo[] <cachedMeshInfoVertexData>5__3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<int> <scaleSortingOrder>5__4;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public VertexZoom.<AnimateVertexColors>d__10(int <>1__state)
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
        TMPro.Examples.VertexZoom val_54;
        VertexZoom.<>c__DisplayClass10_0 val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        object val_62;
        int val_63;
        val_54 = this.<>4__this;
        int val_1 = (this.<>1__state) - 1;
        if(val_1 >= 2)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        if(val_54 == null)
        {
            goto label_2;
        }
        
        goto label_10;
        label_1:
        if((this.<>1__state) != 0)
        {
            goto label_4;
        }
        
        this.<>1__state = 0;
        this.<>8__1 = new VertexZoom.<>c__DisplayClass10_0();
        TMPro.TMP_TextInfo val_3 = this.<>4__this.m_TextComponent.textInfo;
        this.<textInfo>5__2 = val_3;
        this.<cachedMeshInfoVertexData>5__3 = val_3.CopyMeshInfoVertexData();
        val_55 = this.<>8__1;
        this.<>8__1.modifiedCharScale = new System.Collections.Generic.List<System.Single>();
        this.<scaleSortingOrder>5__4 = new System.Collections.Generic.List<System.Int32>();
        val_54 = val_54;
        this.<>4__this.hasTextChanged = true;
        goto label_10;
        label_4:
        val_56 = 0;
        return (bool)val_56;
        label_2:
        label_10:
        if((this.<>4__this.hasTextChanged) != false)
        {
                this.<cachedMeshInfoVertexData>5__3 = this.<textInfo>5__2.CopyMeshInfoVertexData();
            mem2[0] = 0;
        }
        
        if((this.<textInfo>5__2.characterCount) == 0)
        {
            goto label_15;
        }
        
        this.<>8__1.modifiedCharScale.Clear();
        this.<scaleSortingOrder>5__4.Clear();
        if((this.<textInfo>5__2.characterCount) >= 1)
        {
                val_57 = 0;
            val_58 = 368;
            do
        {
            if((this.<textInfo>5__2.characterInfo[42]) != 0)
        {
                this.<textInfo>5__2.characterInfo[368] = (this.<textInfo>5__2.characterInfo[368]) - 280;
            this.<textInfo>5__2.characterInfo[368] = (this.<textInfo>5__2.characterInfo[368]) - 260;
            TMPro.TMP_CharacterInfo[] val_8 = (this.<cachedMeshInfoVertexData>5__3) + (1152921508539887296 * 72);
            val_59 = mem[mem[(1152921508539887296 * 72) + this.<cachedMeshInfoVertexData>5__3 + 48] + 24];
            val_59 = mem[(1152921508539887296 * 72) + this.<cachedMeshInfoVertexData>5__3 + 48] + 24;
            if(null >= val_59)
        {
                val_59 = mem[mem[(1152921508539887296 * 72) + this.<cachedMeshInfoVertexData>5__3 + 48] + 24];
            val_59 = mem[(1152921508539887296 * 72) + this.<cachedMeshInfoVertexData>5__3 + 48] + 24;
        }
        
            TMPro.TMP_CharacterInfo[] val_9 = (mem[(1152921508539887296 * 72) + this.<cachedMeshInfoVertexData>5__3 + 48]) + (1152921508539887296 * 12);
            var val_71 = (long)val_1;
            val_71 = (mem[(1152921508539887296 * 72) + this.<cachedMeshInfoVertexData>5__3 + 48]) + (val_71 * 12);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = mem[(1152921508539887296 * 12) + mem[(1152921508539887296 * 72) + this.<cachedMeshInfoVertexData>5__3 + 48] + 32], y = (1152921508539887296 * 12) + mem[(1152921508539887296 * 72) + this.<cachedMeshInfoVertexData>5__3 + 48] + 32 + 4, z = (1152921508539887296 * 12) + mem[(1152921508539887296 * 72) + this.<cachedMeshInfoVertexData>5__3 + 48] + 32 + 8}, b:  new UnityEngine.Vector3() {x = ((long)(int)((this.<>1__state - 1)) * 12) + mem[(1152921508539887296 * 72) + this.<cachedMeshInfoVertexData>5__3 + 48] + 32, y = ((long)(int)((this.<>1__state - 1)) * 12) + mem[(1152921508539887296 * 72) + this.<cachedMeshInfoVertexData>5__3 + 48] + 32 + 4, z = ((long)(int)((this.<>1__state - 1)) * 12) + mem[(1152921508539887296 * 72) + this.<cachedMeshInfoVertexData>5__3 + 48] + 32 + 8});
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  2f);
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            UnityEngine.Vector3 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
            TMPro.TMP_CharacterInfo[] val_14 = (this.<textInfo>5__2.meshInfo) + (null * 72);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = (1152921508539887296 * 12) + mem[(1152921508539887296 * 72) + this.<cachedMeshInfoVertexData>5__3 + 48] + 32, y = (1152921508539887296 * 12) + mem[(1152921508539887296 * 72) + this.<cachedMeshInfoVertexData>5__3 + 48] + 32 + 4, z = (1152921508539887296 * 12) + mem[(1152921508539887296 * 72) + this.<cachedMeshInfoVertexData>5__3 + 48] + 32 + 8}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            var val_72 = 12;
            TMPro.TMP_CharacterInfo[] val_16 = ((null * 72) + this.<textInfo>5__2.meshInfo + 48) + (1152921508539887296 * val_72);
            mem2[0] = val_15.x;
            mem2[0] = val_15.y;
            mem2[0] = val_15.z;
            var val_17 = (mem[(1152921508539887296 * 72) + this.<cachedMeshInfoVertexData>5__3 + 48]) + (((long)(long)(int)((1152921508539887296 * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8)) * val_72);
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = ((long)(int)((1152921508539887296 * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8) * 12) + mem[(1152921508539887296 * 72) + this.<cachedMeshInfoVertexData>5__3 + 48] + 32, y = ((long)(int)((1152921508539887296 * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8) * 12) + mem[(1152921508539887296 * 72) + this.<cachedMeshInfoVertexData>5__3 + 48] + 32 + 4, z = ((long)(int)((1152921508539887296 * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8) * 12) + mem[(1152921508539887296 * 72) + this.<cachedMeshInfoVertexData>5__3 + 48] + 40}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            val_72 = ((null * 72) + this.<textInfo>5__2.meshInfo + 48) + (((long)(long)(int)((1152921508539887296 * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8)) * val_72);
            mem2[0] = val_18.x;
            mem2[0] = val_18.y;
            mem2[0] = val_18.z;
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = ((long)(int)((this.<>1__state - 1)) * 12) + mem[(1152921508539887296 * 72) + this.<cachedMeshInfoVertexData>5__3 + 48] + 32, y = ((long)(int)((this.<>1__state - 1)) * 12) + mem[(1152921508539887296 * 72) + this.<cachedMeshInfoVertexData>5__3 + 48] + 32 + 4, z = ((long)(int)((this.<>1__state - 1)) * 12) + mem[(1152921508539887296 * 72) + this.<cachedMeshInfoVertexData>5__3 + 48] + 32 + 8}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            var val_20 = ((null * 72) + this.<textInfo>5__2.meshInfo + 48) + (val_71 * 12);
            mem2[0] = val_19.x;
            mem2[0] = val_19.y;
            mem2[0] = val_19.z;
            var val_21 = (mem[(1152921508539887296 * 72) + this.<cachedMeshInfoVertexData>5__3 + 48]) + (((long)(long)(int)(((long)(int)((this.<>1__state - 1)) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8)) * 12);
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = ((long)(int)(((long)(int)((this.<>1__state - 1)) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8) * 12) + mem[(1152921508539887296 * 72) + this.<cachedMeshInfoVertexData>5__3 + 48] + 32, y = ((long)(int)(((long)(int)((this.<>1__state - 1)) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8) * 12) + mem[(1152921508539887296 * 72) + this.<cachedMeshInfoVertexData>5__3 + 48] + 32 + 4, z = ((long)(int)(((long)(int)((this.<>1__state - 1)) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8) * 12) + mem[(1152921508539887296 * 72) + this.<cachedMeshInfoVertexData>5__3 + 48] + 40}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            var val_23 = ((null * 72) + this.<textInfo>5__2.meshInfo + 48) + (((long)(long)(int)(((long)(int)((this.<>1__state - 1)) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8)) * 12);
            mem2[0] = val_22.x;
            mem2[0] = val_22.y;
            mem2[0] = val_22.z;
            float val_24 = UnityEngine.Random.Range(min:  1f, max:  1.5f);
            this.<>8__1.modifiedCharScale.Add(item:  val_24);
            this.<scaleSortingOrder>5__4.Add(item:  (this.<>8__1.modifiedCharScale.Count) - 1);
            UnityEngine.Quaternion val_27 = UnityEngine.Quaternion.identity;
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, d:  val_24);
            UnityEngine.Matrix4x4 val_30 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, q:  new UnityEngine.Quaternion() {x = val_27.x, y = val_27.y, z = val_27.z, w = val_27.w}, s:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.z});
            mem2[0] = (1152921508539887296 * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32;
            mem2[0] = (1152921508539887296 * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 4;
            mem2[0] = (1152921508539887296 * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8;
            mem2[0] = ((long)(int)((1152921508539887296 * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32;
            mem2[0] = ((long)(int)((1152921508539887296 * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 4;
            mem2[0] = ((long)(int)((1152921508539887296 * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8;
            mem2[0] = ((long)(int)((this.<>1__state - 1)) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32;
            mem2[0] = ((long)(int)((this.<>1__state - 1)) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 4;
            mem2[0] = ((long)(int)((this.<>1__state - 1)) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8;
            mem2[0] = ((long)(int)(((long)(int)((this.<>1__state - 1)) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32;
            mem2[0] = ((long)(int)(((long)(int)((this.<>1__state - 1)) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 4;
            mem2[0] = ((long)(int)(((long)(int)((this.<>1__state - 1)) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8;
            UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (1152921508539887296 * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32, y = (1152921508539887296 * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 4, z = (1152921508539887296 * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            mem2[0] = val_35.x;
            mem2[0] = val_35.y;
            mem2[0] = val_35.z;
            UnityEngine.Vector3 val_36 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = ((long)(int)((1152921508539887296 * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32, y = ((long)(int)((1152921508539887296 * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 4, z = ((long)(int)((1152921508539887296 * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            mem2[0] = val_36.x;
            mem2[0] = val_36.y;
            mem2[0] = val_36.z;
            UnityEngine.Vector3 val_37 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = ((long)(int)((this.<>1__state - 1)) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32, y = ((long)(int)((this.<>1__state - 1)) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 4, z = ((long)(int)((this.<>1__state - 1)) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            mem2[0] = val_37.x;
            mem2[0] = val_37.y;
            mem2[0] = val_37.z;
            UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = ((long)(int)(((long)(int)((this.<>1__state - 1)) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32, y = ((long)(int)(((long)(int)((this.<>1__state - 1)) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 4, z = ((long)(int)(((long)(int)((this.<>1__state - 1)) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            mem2[0] = val_38.x;
            mem2[0] = val_38.y;
            mem2[0] = val_38.z;
            TMPro.TMP_CharacterInfo[] val_39 = (this.<cachedMeshInfoVertexData>5__3) + (null * 72);
            TMPro.TMP_CharacterInfo[] val_40 = (this.<textInfo>5__2.meshInfo) + (null * 72);
            var val_41 = ((null * 72) + this.<cachedMeshInfoVertexData>5__3 + 72) + (-9223372005390453248);
            var val_42 = ((null * 72) + this.<textInfo>5__2.meshInfo + 72) + (-9223372005390453248);
            mem2[0] = ((null * 72) + this.<cachedMeshInfoVertexData>5__3 + 72 + -9223372005390453248) + 32;
            mem2[0] = ((null * 72) + this.<cachedMeshInfoVertexData>5__3 + 72 + -9223372005390453248) + 32 + 4;
            var val_43 = ((null * 72) + this.<cachedMeshInfoVertexData>5__3 + 72) + (((long)(int)((1152921508539887296 * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8)) << 3);
            var val_44 = ((null * 72) + this.<textInfo>5__2.meshInfo + 72) + (((long)(int)((1152921508539887296 * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8)) << 3);
            mem2[0] = ((null * 72) + this.<cachedMeshInfoVertexData>5__3 + 72 + ((long)(int)((1152921508539887296 * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8)) << 3) + 32;
            mem2[0] = ((null * 72) + this.<cachedMeshInfoVertexData>5__3 + 72 + ((long)(int)((1152921508539887296 * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8)) << 3) + 32 + 4;
            var val_45 = ((null * 72) + this.<cachedMeshInfoVertexData>5__3 + 72) + (((long)(int)((this.<>1__state - 1))) << 3);
            var val_46 = ((null * 72) + this.<textInfo>5__2.meshInfo + 72) + (((long)(int)((this.<>1__state - 1))) << 3);
            mem2[0] = ((null * 72) + this.<cachedMeshInfoVertexData>5__3 + 72 + ((long)(int)((this.<>1__state - 1))) << 3) + 32;
            mem2[0] = ((null * 72) + this.<cachedMeshInfoVertexData>5__3 + 72 + ((long)(int)((this.<>1__state - 1))) << 3) + 32 + 4;
            var val_47 = ((null * 72) + this.<cachedMeshInfoVertexData>5__3 + 72) + (((long)(int)(((long)(int)((this.<>1__state - 1)) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8)) << 3);
            var val_48 = ((null * 72) + this.<textInfo>5__2.meshInfo + 72) + (((long)(int)(((long)(int)((this.<>1__state - 1)) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8)) << 3);
            mem2[0] = ((null * 72) + this.<cachedMeshInfoVertexData>5__3 + 72 + ((long)(int)(((long)(int)((this.<>1__state - 1)) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8)) << 3) + 32;
            mem2[0] = ((null * 72) + this.<cachedMeshInfoVertexData>5__3 + 72 + ((long)(int)(((long)(int)((this.<>1__state - 1)) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8)) << 3) + 32 + 4;
            TMPro.TMP_CharacterInfo[] val_49 = (this.<cachedMeshInfoVertexData>5__3) + (null * 72);
            TMPro.TMP_CharacterInfo[] val_50 = (this.<textInfo>5__2.meshInfo) + (null * 72);
            var val_51 = ((null * 72) + this.<cachedMeshInfoVertexData>5__3 + 88) + 4611686034159549184;
            var val_52 = ((null * 72) + this.<textInfo>5__2.meshInfo + 88) + 4611686034159549184;
            mem2[0] = ((null * 72) + this.<cachedMeshInfoVertexData>5__3 + 88 + 4611686034159549184) + 32;
            var val_53 = ((null * 72) + this.<cachedMeshInfoVertexData>5__3 + 88) + (((long)(int)((1152921508539887296 * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8)) << 2);
            val_60 = (long)(long)(int)((1152921508539887296 * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8);
            var val_54 = ((null * 72) + this.<textInfo>5__2.meshInfo + 88) + (((long)(int)((1152921508539887296 * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8)) << 2);
            mem2[0] = ((null * 72) + this.<cachedMeshInfoVertexData>5__3 + 88 + ((long)(int)((1152921508539887296 * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8)) << 2) + 32;
            var val_55 = ((null * 72) + this.<cachedMeshInfoVertexData>5__3 + 88) + (((long)(int)((this.<>1__state - 1))) << 2);
            var val_56 = ((null * 72) + this.<textInfo>5__2.meshInfo + 88) + (((long)(int)((this.<>1__state - 1))) << 2);
            mem2[0] = ((null * 72) + this.<cachedMeshInfoVertexData>5__3 + 88 + ((long)(int)((this.<>1__state - 1))) << 2) + 32;
            var val_57 = ((null * 72) + this.<cachedMeshInfoVertexData>5__3 + 88) + (((long)(int)(((long)(int)((this.<>1__state - 1)) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8)) << 2);
            val_58 = 368;
            var val_58 = ((null * 72) + this.<textInfo>5__2.meshInfo + 88) + (((long)(int)(((long)(int)((this.<>1__state - 1)) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8)) << 2);
            mem2[0] = ((null * 72) + this.<cachedMeshInfoVertexData>5__3 + 88 + ((long)(int)(((long)(int)((this.<>1__state - 1)) * 12) + (null * 72) + this.<textInfo>5__2.meshInfo + 48 + 32 + 8)) << 2) + 32;
            val_57 = val_57;
        }
        
            val_57 = val_57 + 1;
            val_58 = val_58 + 344;
        }
        while((this.<textInfo>5__2.characterCount) != val_57);
        
        }
        
        val_61 = 0;
        goto label_136;
        label_142:
        if((this.<>8__1.<>9__0) == null)
        {
            goto label_105;
        }
        
        label_139:
        this.<scaleSortingOrder>5__4.Sort(comparison:  this.<>8__1.<>9__0);
        val_60 = 0;
        var val_59 = 0 + 32;
        var val_60 = (this.<textInfo>5__2.meshInfo) + (val_60 * 72);
        var val_61 = (this.<textInfo>5__2.meshInfo) + (val_60 * 72);
        (val_60 * 72) + this.<textInfo>5__2.meshInfo + 32.vertices = (val_60 * 72) + this.<textInfo>5__2.meshInfo + 48;
        var val_62 = (this.<textInfo>5__2.meshInfo) + (val_60 * 72);
        var val_63 = (this.<textInfo>5__2.meshInfo) + (val_60 * 72);
        (val_60 * 72) + this.<textInfo>5__2.meshInfo + 32.uv = (val_60 * 72) + this.<textInfo>5__2.meshInfo + 72;
        var val_64 = (this.<textInfo>5__2.meshInfo) + (val_60 * 72);
        var val_65 = (this.<textInfo>5__2.meshInfo) + (val_60 * 72);
        (val_60 * 72) + this.<textInfo>5__2.meshInfo + 32.colors32 = (val_60 * 72) + this.<textInfo>5__2.meshInfo + 88;
        var val_66 = (this.<textInfo>5__2.meshInfo) + (val_60 * 72);
        val_61 = 1;
        goto label_136;
        label_105:
        this.<>8__1.<>9__0 = new System.Comparison<System.Int32>(object:  this.<>8__1, method:  System.Int32 VertexZoom.<>c__DisplayClass10_0::<AnimateVertexColors>b__0(int a, int b));
        if((this.<scaleSortingOrder>5__4) != null)
        {
            goto label_139;
        }
        
        goto label_139;
        label_136:
        val_55 = this.<textInfo>5__2.meshInfo;
        if(val_61 < (this.<textInfo>5__2.meshInfo.Length))
        {
            goto label_142;
        }
        
        UnityEngine.WaitForSeconds val_68 = null;
        val_62 = val_68;
        val_68 = new UnityEngine.WaitForSeconds(seconds:  0.1f);
        val_63 = 2;
        goto label_143;
        label_15:
        UnityEngine.WaitForSeconds val_69 = null;
        val_62 = val_69;
        val_69 = new UnityEngine.WaitForSeconds(seconds:  0.25f);
        val_63 = 1;
        label_143:
        val_56 = 1;
        this.<>2__current = val_62;
        this.<>1__state = val_63;
        return (bool)val_56;
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
