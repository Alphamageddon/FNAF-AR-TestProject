using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class TutorialCopyWhenClicked : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private TMPro.TextMeshProUGUI _sourceText;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private TMPro.TextMeshProUGUI _destText;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.UI.Image[] _sourceImgs;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.UI.Image[] _destImgs;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.UI.Button[] _buttonsToDisable;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnClicked()
    {
        var val_4;
        UnityEngine.UI.Image[] val_5;
        var val_6;
        val_4 = 0;
        goto label_0;
        label_22:
        this._destImgs[0].sprite = this._sourceImgs[0].sprite;
        UnityEngine.UI.Image val_6 = this._destImgs[0];
        UnityEngine.UI.Image val_7 = this._sourceImgs[0];
        UnityEngine.Color val_2 = this._sourceImgs[0].color;
        this._destImgs[0].color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        val_4 = 1;
        label_0:
        val_5 = this._sourceImgs;
        if(val_4 >= this._sourceImgs.Length)
        {
            goto label_20;
        }
        
        val_5 = this._destImgs;
        if(val_4 < this._destImgs.Length)
        {
            goto label_22;
        }
        
        label_20:
        this._destText.text = this._sourceText.text;
        val_6 = 0;
        goto label_27;
        label_32:
        this._buttonsToDisable[0].enabled = false;
        val_6 = 1;
        label_27:
        if(val_6 < this._buttonsToDisable.Length)
        {
            goto label_32;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TutorialCopyWhenClicked()
    {
    
    }

}
