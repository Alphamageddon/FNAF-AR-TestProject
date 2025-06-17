using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class ToyChicaBeakVisibility : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject beak;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject noBeak;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Animator _animator;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _isBeakNotNull;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _isNoBeakNotNull;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        UnityEngine.GameObject val_5 = this.noBeak;
        this._isBeakNotNull = UnityEngine.Object.op_Inequality(x:  this.beak, y:  0);
        val_5 = UnityEngine.Object.op_Inequality(x:  val_5, y:  0);
        this._isNoBeakNotNull = val_5;
        this._animator = this.GetComponent<UnityEngine.Animator>();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        UnityEngine.GameObject val_6;
        var val_7;
        val_6 = this;
        if(this._isBeakNotNull == false)
        {
                return;
        }
        
        if(this._isNoBeakNotNull == false)
        {
                return;
        }
        
        UnityEngine.AnimatorStateInfo val_1 = this._animator.GetCurrentAnimatorStateInfo(layerIndex:  0);
        if((1359390016 & 1) == 0)
        {
                if((1359390016 & 1) == 0)
        {
            goto label_5;
        }
        
        }
        
        this.beak.SetActive(value:  true);
        val_6 = this.noBeak;
        val_7 = 0;
        goto label_8;
        label_5:
        this.beak.SetActive(value:  false);
        val_6 = this.noBeak;
        val_7 = 1;
        label_8:
        val_6.SetActive(value:  true);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ToyChicaBeakVisibility()
    {
    
    }

}
