using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class EnvMapAnimator : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 RotationSpeeds;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private TMPro.TMP_Text m_textMeshPro;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Material m_material;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Awake()
    {
        TMPro.TMP_Text val_1 = this.GetComponent<TMPro.TMP_Text>();
        this.m_textMeshPro = val_1;
        this.m_material = val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.IEnumerator Start()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new EnvMapAnimator.<Start>d__4();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public EnvMapAnimator()
    {
    
    }

}
