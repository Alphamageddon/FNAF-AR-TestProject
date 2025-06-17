using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class MaskController : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject maskCamera;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject mask;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Animator animator;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Animatronics.Animatronic3d.Model.Animation.AnimationEventListener listener;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _isMaskEnabled;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _shouldMaskBeOn;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _isMaskGoingOn;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _isMaskInTransition;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Action<MaskStatusChange> OnMaskStatusChanged;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const string MaskOn = "MaskOn";
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const string MaskOff = "MaskOff";
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly int IsMaskOnId;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly int ForceMaskOffId;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void add_OnMaskStatusChanged(System.Action<MaskStatusChange> value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.OnMaskStatusChanged, b:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.OnMaskStatusChanged != 1152921518880709584);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void remove_OnMaskStatusChanged(System.Action<MaskStatusChange> value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.OnMaskStatusChanged, value:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.OnMaskStatusChanged != 1152921518880846160);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetStatusCallback(System.Action<MaskStatusChange> maskStatusChanged)
    {
        this.add_OnMaskStatusChanged(value:  maskStatusChanged);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsMaskFullyOn()
    {
        var val_4;
        if(this._isMaskEnabled != false)
        {
                if((this.animator.gameObject.activeInHierarchy != false) && (this._isMaskGoingOn != false))
        {
                var val_3 = (this._isMaskInTransition == false) ? 1 : 0;
            return (bool)val_4;
        }
        
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsMaskFullyOff()
    {
        var val_4;
        if((this._isMaskEnabled == false) || (this.animator.gameObject.activeInHierarchy == false))
        {
            goto label_3;
        }
        
        if(this._isMaskGoingOn == false)
        {
            goto label_4;
        }
        
        val_4 = 0;
        return (bool)val_4;
        label_3:
        val_4 = 1;
        return (bool)val_4;
        label_4:
        var val_3 = (this._isMaskInTransition == false) ? 1 : 0;
        return (bool)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsMaskInTransition()
    {
        var val_4;
        if(this._isMaskEnabled != false)
        {
                if(this.animator.gameObject.activeInHierarchy != false)
        {
                var val_3 = (this._isMaskInTransition == true) ? 1 : 0;
            return (bool)val_4;
        }
        
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetMaskAvailable(bool shouldMaskBeAvailable)
    {
        var val_1 = (this._isMaskEnabled == true) ? 1 : 0;
        val_1 = val_1 ^ shouldMaskBeAvailable;
        if(val_1 != false)
        {
                this.ForceMaskOff();
        }
        
        this._isMaskEnabled = shouldMaskBeAvailable;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void ForceMaskOff()
    {
        var val_2;
        var val_3;
        this._shouldMaskBeOn = false;
        val_2 = 0;
        val_3 = null;
        val_2 = 0;
        this.animator.SetBool(id:  MaskController.IsMaskOnId, value:  null);
        this.animator.SetTrigger(id:  MaskController.ForceMaskOffId);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetDesiredMaskState(bool desiredMaskState)
    {
        bool val_3;
        var val_4;
        if(this._isMaskEnabled == false)
        {
                return;
        }
        
        val_3 = desiredMaskState;
        this._shouldMaskBeOn = val_3;
        val_4 = null;
        val_4 = null;
        val_3 = this._shouldMaskBeOn;
        this.animator.SetBool(id:  MaskController.IsMaskOnId, value:  (val_3 == true) ? 1 : 0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        this.listener.add_OnAnimationEventReceived(value:  new System.Action<UnityEngine.AnimationEvent>(object:  this, method:  System.Void MaskController::MaskAnimationEvent(UnityEngine.AnimationEvent animationEvent)));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void MaskAnimationEvent(UnityEngine.AnimationEvent animationEvent)
    {
        if((animationEvent.intParameter - 1) > 4)
        {
                return;
        }
        
        var val_8 = 52948688 + ((val_1 - 1)) << 2;
        val_8 = val_8 + 52948688;
        goto (52948688 + ((val_1 - 1)) << 2 + 52948688);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public MaskController()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static MaskController()
    {
        MaskController.IsMaskOnId = UnityEngine.Animator.StringToHash(name:  "IsMaskOn");
        MaskController.ForceMaskOffId = UnityEngine.Animator.StringToHash(name:  "ForceMaskOff");
    }

}
