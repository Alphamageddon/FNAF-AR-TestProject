using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class TutorialButtonDisable : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.UI.Button[] _buttonsToDisable;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnClicked()
    {
        goto label_0;
        label_5:
        this._buttonsToDisable[0].enabled = false;
        0 = 1;
        label_0:
        if(0 < this._buttonsToDisable.Length)
        {
            goto label_5;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TutorialButtonDisable()
    {
    
    }

}
