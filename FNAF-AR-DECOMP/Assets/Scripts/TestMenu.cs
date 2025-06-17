using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class TestMenu : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject opaqueSet;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject shadowSet;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject testCard;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool showShadowsOnly;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool showTestCard;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnGUI()
    {
        bool val_8;
        val_8 = 1152921504865099776;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "Switch Shader")) != false)
        {
                this.showShadowsOnly = (this.showShadowsOnly == false) ? 1 : 0;
            this.opaqueSet.SetActive(value:  (this.showShadowsOnly == true) ? 1 : 0);
            this.shadowSet.SetActive(value:  (this.showShadowsOnly == true) ? 1 : 0);
        }
        
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "Test Card")) == false)
        {
                return;
        }
        
        val_8 = this.showTestCard;
        this.showTestCard = val_8 ^ 1;
        this.testCard.SetActive(value:  (val_8 == false) ? 1 : 0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TestMenu()
    {
    
    }

}
