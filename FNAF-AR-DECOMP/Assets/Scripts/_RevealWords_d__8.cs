using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class TextConsoleSimulator.<RevealWords>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TMPro.TMP_Text textComponent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <totalWordCount>5__2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <totalVisibleCharacters>5__3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <counter>5__4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <visibleCount>5__5;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TextConsoleSimulator.<RevealWords>d__8(int <>1__state)
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
        var val_10;
        int val_11;
        int val_12;
        int val_13;
        var val_14;
        object val_15;
        int val_16;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_3;
        }
        
        this.<>1__state = 0;
        TMPro.TMP_TextInfo val_1 = this.textComponent.textInfo;
        val_10 = this;
        this.<totalWordCount>5__2 = val_1.wordCount;
        TMPro.TMP_TextInfo val_2 = this.textComponent.textInfo;
        val_11 = this;
        val_12 = 0;
        this.<counter>5__4 = 0;
        this.<visibleCount>5__5 = 0;
        mem[1152921524665234812] = val_2.characterCount;
        goto label_9;
        label_1:
        val_11 = this;
        val_12 = this.<counter>5__4;
        this.<>1__state = 0;
        val_10 = 1152921524665234808;
        label_9:
        int val_3 = val_10 + 1;
        val_10 = val_12 - ((val_12 / val_3) * val_3);
        if(val_10 == 0)
        {
            goto label_10;
        }
        
        if(val_10 >= val_10)
        {
            goto label_11;
        }
        
        TMPro.TMP_TextInfo val_5 = this.textComponent.textInfo;
        val_10 = val_10 - 1;
        var val_8 = 24;
        val_8 = val_5.wordInfo + ((long)val_10 * val_8);
        val_13 = (((long)(int)((this.<counter>5__4 - ((this.<counter>5__4 / (val_1.wordCount + 1)) * (val_1.wordCount + 1)) - 1)) * 24) + val_5.wordInfo + 44) + 1;
        goto label_19;
        label_2:
        val_11 = this.<counter>5__4;
        this.<>1__state = 0;
        goto label_17;
        label_3:
        val_14 = 0;
        return (bool)val_14;
        label_10:
        val_13 = 0;
        goto label_19;
        label_11:
        if(val_10 != val_10)
        {
            goto label_24;
        }
        
        val_13 = this.<totalVisibleCharacters>5__3;
        label_19:
        this.<visibleCount>5__5 = val_13;
        label_24:
        this.textComponent.maxVisibleCharacters = val_13;
        if((this.<visibleCount>5__5) >= (this.<totalVisibleCharacters>5__3))
        {
            goto label_22;
        }
        
        label_17:
        int val_9 = this.<counter>5__4;
        val_9 = val_9 + 1;
        this.<counter>5__4 = val_9;
        UnityEngine.WaitForSeconds val_6 = null;
        val_15 = val_6;
        val_6 = new UnityEngine.WaitForSeconds(seconds:  0.1f);
        val_16 = 2;
        goto label_23;
        label_22:
        UnityEngine.WaitForSeconds val_7 = null;
        val_15 = val_7;
        val_7 = new UnityEngine.WaitForSeconds(seconds:  1f);
        val_16 = 1;
        label_23:
        val_14 = 1;
        this.<>2__current = val_15;
        this.<>1__state = val_16;
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
