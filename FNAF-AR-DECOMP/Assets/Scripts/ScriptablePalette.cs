using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class ScriptablePalette : ScriptableObject
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int m_numColors;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Color m_keyColor;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Color[] m_colors;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float m_hueRange;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float m_saturationRange;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float m_valueRange;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool m_setBaseColor_Override;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool m_setDetailColor1_Override;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool m_setDetailColor2_Override;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Color m_baseColor_Override;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Color m_detailColor1_Override;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Color m_detailColor2_Override;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void GeneratePalette()
    {
        float val_12;
        UnityEngine.Color[] val_13;
        UnityEngine.Color.RGBToHSV(rgbColor:  new UnityEngine.Color() {r = this.m_keyColor}, H: out  float val_1 = 1.183658E+19f, S: out  float val_2 = 1.183658E+19f, V: out  float val_3 = 1.183657E+19f);
        float val_15 = this.m_hueRange;
        val_12 = 1f;
        float val_12 = 0f;
        val_12 = val_12 + this.m_saturationRange;
        float val_13 = 0f;
        val_13 = val_13 - this.m_valueRange;
        float val_14 = 0f;
        val_14 = val_14 + this.m_valueRange;
        val_13 = new UnityEngine.Color[0];
        this.m_colors = val_13;
        if(this.m_numColors < 1)
        {
                return;
        }
        
        var val_16 = 0;
        val_15 = 0f + val_15;
        goto label_4;
        label_7:
        val_13 = this.m_colors;
        label_4:
        UnityEngine.Color val_11 = UnityEngine.Random.ColorHSV(hueMin:  0f - val_15, hueMax:  val_15, saturationMin:  UnityEngine.Mathf.Clamp(value:  0f - this.m_saturationRange, min:  0f, max:  val_12), saturationMax:  UnityEngine.Mathf.Clamp(value:  val_12, min:  0f, max:  val_12), valueMin:  UnityEngine.Mathf.Clamp(value:  val_13, min:  0f, max:  val_12), valueMax:  UnityEngine.Mathf.Clamp(value:  val_14, min:  0f, max:  val_12));
        val_12 = val_11.b;
        val_13[0] = val_11;
        val_13[0] = val_11.g;
        val_13[0] = val_12;
        val_13[0] = val_11.a;
        val_16 = val_16 + 1;
        if(val_16 < this.m_numColors)
        {
            goto label_7;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ScriptablePalette()
    {
        this.m_numColors = 3;
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.m_keyColor = val_1;
        mem[1152921519088126192] = val_1.g;
        mem[1152921519088126196] = val_1.b;
        mem[1152921519088126200] = val_1.a;
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        this.m_baseColor_Override = val_2;
        mem[1152921519088126236] = val_2.g;
        mem[1152921519088126240] = val_2.b;
        mem[1152921519088126244] = val_2.a;
        UnityEngine.Color val_3 = UnityEngine.Color.white;
        this.m_detailColor1_Override = val_3;
        mem[1152921519088126252] = val_3.g;
        mem[1152921519088126256] = val_3.b;
        mem[1152921519088126260] = val_3.a;
        UnityEngine.Color val_4 = UnityEngine.Color.white;
        this.m_detailColor2_Override = val_4;
        mem[1152921519088126268] = val_4.g;
        mem[1152921519088126272] = val_4.b;
        mem[1152921519088126276] = val_4.a;
    }

}
