using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class TextConsoleSimulator.<RevealCharacters>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TMPro.TMP_Text textComponent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TMPro.Examples.TextConsoleSimulator <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private TMPro.TMP_TextInfo <textInfo>5__2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <totalVisibleCharacters>5__3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <visibleCount>5__4;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TextConsoleSimulator.<RevealCharacters>d__7(int <>1__state)
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
        TMPro.Examples.TextConsoleSimulator val_3;
        var val_4;
        int val_5;
        object val_6;
        int val_7;
        var val_8;
        val_3 = this.<>4__this;
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
        this.<textInfo>5__2 = this.textComponent.textInfo;
        this.<totalVisibleCharacters>5__3 = val_1.characterCount;
        this.<visibleCount>5__4 = 0;
        if(val_3 != null)
        {
            goto label_9;
        }
        
        goto label_8;
        label_1:
        this.<>1__state = 0;
        if(val_3 != null)
        {
            goto label_9;
        }
        
        label_8:
        label_9:
        if((this.<>4__this.hasTextChanged) != false)
        {
                this.<totalVisibleCharacters>5__3 = this.<textInfo>5__2.characterCount;
            this.<>4__this.hasTextChanged = false;
        }
        
        val_4 = this;
        val_5 = this.<visibleCount>5__4;
        if(val_5 <= (this.<totalVisibleCharacters>5__3))
        {
            goto label_12;
        }
        
        UnityEngine.WaitForSeconds val_2 = null;
        val_6 = val_2;
        val_2 = new UnityEngine.WaitForSeconds(seconds:  1f);
        val_7 = 1;
        goto label_13;
        label_2:
        val_4 = this;
        val_5 = 0;
        this.<visibleCount>5__4 = 0;
        this.<>1__state = 0;
        label_12:
        val_3 = this.textComponent;
        val_3.maxVisibleCharacters = 0;
        val_6 = 0;
        this.<visibleCount>5__4 = 1;
        val_7 = 2;
        label_13:
        val_8 = 1;
        this.<>2__current = val_6;
        this.<>1__state = val_7;
        return (bool)val_8;
        label_3:
        val_8 = 0;
        return (bool)val_8;
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
