using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class Benchmark01_UGUI.<Start>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TMPro.Examples.Benchmark01_UGUI <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <i>5__2;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Benchmark01_UGUI.<Start>d__10(int <>1__state)
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
        var val_13;
        int val_14;
        int val_15;
        UnityEngine.Object val_16;
        int val_17;
        UnityEngine.UI.Text val_18;
        var val_19;
        var val_20;
        int val_21;
        val_13 = 0;
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
                return (bool)val_13;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
            goto label_4;
        }
        
        val_14 = this.<>4__this.BenchmarkType;
        if(val_14 != 0)
        {
            goto label_5;
        }
        
        goto label_10;
        label_1:
        val_15 = 0;
        goto label_7;
        label_2:
        val_16 = this;
        this.<>1__state = 0;
        val_17 = (this.<i>5__2) + 1;
        this.<i>5__2 = val_17;
        if(val_17 < 1000001)
        {
            goto label_8;
        }
        
        val_15 = 2;
        goto label_9;
        label_4:
        val_18 = 15026800;
        if(val_18 == 0)
        {
            goto label_10;
        }
        
        val_14 = 15026800;
        label_5:
        if(val_14 != 1)
        {
            goto label_28;
        }
        
        UnityEngine.UI.Text val_2 = this.<>4__this.gameObject.AddComponent<UnityEngine.UI.Text>();
        if((this.<>4__this) == null)
        {
            goto label_14;
        }
        
        val_19 = this.<>4__this;
        this.<>4__this.m_textMesh = val_2;
        goto label_15;
        label_10:
        TMPro.TextMeshProUGUI val_4 = this.<>4__this.gameObject.AddComponent<TMPro.TextMeshProUGUI>();
        if((this.<>4__this) != null)
        {
                val_20 = this.<>4__this;
            this.<>4__this.m_textMeshPro = val_4;
        }
        else
        {
                val_20 = 56;
            mem[56] = val_4;
        }
        
        if((this.<>4__this.TMProFont) != 0)
        {
                val_20.font = this.<>4__this.TMProFont;
        }
        
        mem[56].fontSize = 48f;
        mem[56].alignment = 2;
        mem[56].extraPadding = true;
        val_18 = mem[56].font;
        this.<>4__this.m_material01 = null;
        this.<>4__this.m_material02 = UnityEngine.Resources.Load<UnityEngine.Material>(path:  "Fonts & Materials/LiberationSans SDF - BEVEL");
        goto label_28;
        label_14:
        val_19 = 64;
        mem[64] = val_2;
        label_15:
        if((this.<>4__this.TextMeshFont) != 0)
        {
                val_19.font = this.<>4__this.TextMeshFont;
        }
        
        mem[64].fontSize = 48;
        val_18 = mem[64];
        val_18.alignment = 4;
        label_28:
        val_16 = this;
        val_17 = 0;
        this.<i>5__2 = 0;
        label_8:
        if((this.<>4__this) == null)
        {
            goto label_35;
        }
        
        val_21 = this.<>4__this.BenchmarkType;
        if(val_21 != 0)
        {
            goto label_36;
        }
        
        goto label_37;
        label_35:
        val_18 = 15026800;
        if(val_18 == 0)
        {
            goto label_38;
        }
        
        val_21 = 15026800;
        label_36:
        if(val_21 != 1)
        {
            goto label_44;
        }
        
        int val_15 = this.<i>5__2;
        int val_9 = val_15 * 274877907;
        val_9 = val_9 >> 38;
        val_9 = val_9 + (val_9 >> 63);
        val_15 = val_15 - (val_9 * 1000);
        val_18 = "The <color=#0050FF>count is: </color>"("The <color=#0050FF>count is: </color>") + val_15.ToString();
        if((this.<>4__this.m_textMesh) != null)
        {
            goto label_42;
        }
        
        goto label_42;
        label_38:
        val_17 = this.<i>5__2;
        label_37:
        val_18 = this.<>4__this.m_textMeshPro;
        val_18.text = "The <#0050FF>count is: </color>"("The <#0050FF>count is: </color>") + 0;
        int val_16 = this.<i>5__2;
        val_16 = val_16 - (0 * 1000);
        if(val_16 != 999)
        {
            goto label_44;
        }
        
        val_18 = this.<>4__this.m_textMeshPro;
        val_16 = val_18;
        if(val_16 != (this.<>4__this.m_material01))
        {
            goto label_48;
        }
        
        if((this.<>4__this.m_textMeshPro) != null)
        {
            goto label_50;
        }
        
        label_51:
        label_50:
        label_42:
        label_44:
        val_15 = 1;
        label_9:
        val_13 = 1;
        this.<>2__current = 0;
        label_7:
        this.<>1__state = val_15;
        return (bool)val_13;
        label_48:
        if((this.<>4__this.m_textMeshPro) != null)
        {
            goto label_50;
        }
        
        goto label_51;
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
