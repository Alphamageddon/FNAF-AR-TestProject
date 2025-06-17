using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class VertexColorCycler.<AnimateVertexColors>d__3 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TMPro.Examples.VertexColorCycler <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private TMPro.TMP_TextInfo <textInfo>5__2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <currentCharacter>5__3;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public VertexColorCycler.<AnimateVertexColors>d__3(int <>1__state)
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
        var val_20;
        int val_21;
        object val_22;
        int val_23;
        if(((this.<>1__state) != 2) && ((this.<>1__state) != 1))
        {
                val_20 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_20;
        }
        
            this.<>1__state = 0;
            this.<textInfo>5__2 = this.<>4__this.m_TextComponent.textInfo;
            this.<currentCharacter>5__3 = 0;
            UnityEngine.Color32 val_2 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color());
        }
        else
        {
                this.<>1__state = 0;
        }
        
        if((this.<textInfo>5__2.characterCount) != 0)
        {
                int val_3 = (this.<textInfo>5__2.characterInfo) + ((this.<currentCharacter>5__3) * 344);
            var val_4 = (this.<textInfo>5__2.meshInfo) + (((this.<currentCharacter>5__3 * 344) + this.<textInfo>5__2.characterInfo + 88) * 72);
            int val_5 = (this.<textInfo>5__2.characterInfo) + ((this.<currentCharacter>5__3) * 344);
            val_21 = this.<currentCharacter>5__3;
            int val_6 = (this.<textInfo>5__2.characterInfo) + (val_21 * 344);
            if(((this.<currentCharacter>5__3 * 344) + this.<textInfo>5__2.characterInfo + 368) != 0)
        {
                int val_7 = UnityEngine.Random.Range(min:  0, max:  255);
            int val_8 = UnityEngine.Random.Range(min:  0, max:  255);
            int val_9 = UnityEngine.Random.Range(min:  0, max:  255);
            var val_10 = (((this.<currentCharacter>5__3 * 344) + this.<textInfo>5__2.characterInfo + 88 * 72) + this.<textInfo>5__2.meshInfo + 88) + (((this.<currentCharacter>5__3 * 344) + this.<textInfo>5__2.characterInfo + 108) << 2);
            mem2[0] = val_2.r;
            mem[1] = val_2.g;
            mem[2] = val_2.b;
            mem[3] = val_2.a;
            var val_11 = ((this.<currentCharacter>5__3 * 344) + this.<textInfo>5__2.characterInfo + 108) + 1;
            var val_12 = (((this.<currentCharacter>5__3 * 344) + this.<textInfo>5__2.characterInfo + 88 * 72) + this.<textInfo>5__2.meshInfo + 88) + (((long)(int)(((this.<currentCharacter>5__3 * 344) + this.<textInfo>5__2.characterInfo + 108 + 1))) << 2);
            mem2[0] = val_2.r;
            mem[1] = val_2.g;
            mem[2] = val_2.b;
            mem[3] = val_2.a;
            var val_13 = ((this.<currentCharacter>5__3 * 344) + this.<textInfo>5__2.characterInfo + 108) + 2;
            var val_14 = (((this.<currentCharacter>5__3 * 344) + this.<textInfo>5__2.characterInfo + 88 * 72) + this.<textInfo>5__2.meshInfo + 88) + (((long)(int)(((this.<currentCharacter>5__3 * 344) + this.<textInfo>5__2.characterInfo + 108 + 2))) << 2);
            mem2[0] = val_2.r;
            mem[1] = val_2.g;
            mem[2] = val_2.b;
            mem[3] = val_2.a;
            val_21 = (long)((this.<currentCharacter>5__3 * 344) + this.<textInfo>5__2.characterInfo + 108) + 3;
            var val_16 = (((this.<currentCharacter>5__3 * 344) + this.<textInfo>5__2.characterInfo + 88 * 72) + this.<textInfo>5__2.meshInfo + 88) + (((long)(int)(((this.<currentCharacter>5__3 * 344) + this.<textInfo>5__2.characterInfo + 108 + 3))) << 2);
            mem2[0] = val_2.r;
            mem[1] = val_2.g;
            mem[2] = val_2.b;
            mem[3] = val_2.a;
        }
        
            int val_20 = this.<currentCharacter>5__3;
            val_20 = val_20 + 1;
            val_20 = val_20 - ((val_20 / (this.<textInfo>5__2.characterCount)) * (this.<textInfo>5__2.characterCount));
            this.<currentCharacter>5__3 = val_20;
            UnityEngine.WaitForSeconds val_18 = null;
            val_22 = val_18;
            val_18 = new UnityEngine.WaitForSeconds(seconds:  0.05f);
            val_23 = 2;
        }
        else
        {
                UnityEngine.WaitForSeconds val_19 = null;
            val_22 = val_19;
            val_19 = new UnityEngine.WaitForSeconds(seconds:  0.25f);
            val_23 = 1;
        }
        
        val_20 = 1;
        this.<>2__current = val_22;
        this.<>1__state = val_23;
        return (bool)val_20;
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
