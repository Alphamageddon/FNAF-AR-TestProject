using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class HighlightToggle : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject selectedObject;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject unselectedObject;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool autoSelectOnButtonClick;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool unselectSiblingsOnSelected;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void SetSelected(bool value)
    {
        if((this.selectedObject != 0) && (this.selectedObject != null))
        {
                this.selectedObject.SetActive(value:  value);
        }
        
        if(this.unselectedObject == 0)
        {
                return;
        }
        
        this.unselectedObject.SetActive(value:  (~value) & 1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void UnselectSiblings()
    {
        goto label_3;
        label_9:
        T val_6 = this.transform.parent.GetComponentsInChildren<HighlightToggle>()[0];
        val_6.SetSelected(value:  UnityEngine.Object.op_Equality(x:  val_6, y:  this));
        0 = 1;
        label_3:
        if(0 < val_3.Length)
        {
            goto label_9;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetHighlight(bool value)
    {
        this.SetSelected(value:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetHighlightAndOtherCellsHighlightState(bool value)
    {
        if(this.unselectSiblingsOnSelected != false)
        {
                this.UnselectSiblings();
        }
        
        value = value;
        this.SetSelected(value:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Awake()
    {
        var val_8;
        IntPtr val_10;
        if(this.autoSelectOnButtonClick == false)
        {
                return;
        }
        
        if((this.GetComponent<UnityEngine.UI.Button>()) != 0)
        {
                val_8 = this.GetComponent<UnityEngine.UI.Button>().onClick;
            val_10 = 1152921518900073472;
        }
        else
        {
                GameUI.IllumixButton val_5 = this.GetComponent<GameUI.IllumixButton>();
            if(val_5 == null)
        {
                return;
        }
        
            val_8 = val_5.onClick;
            UnityEngine.Events.UnityAction val_7 = null;
            val_10 = 1152921518900087808;
        }
        
        val_7 = new UnityEngine.Events.UnityAction(object:  this, method:  val_10);
        val_8.AddListener(call:  val_7);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public HighlightToggle()
    {
        this.autoSelectOnButtonClick = true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void <Awake>b__8_0()
    {
        this.SetHighlightAndOtherCellsHighlightState(value:  true);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void <Awake>b__8_1()
    {
        this.SetHighlightAndOtherCellsHighlightState(value:  true);
    }

}
