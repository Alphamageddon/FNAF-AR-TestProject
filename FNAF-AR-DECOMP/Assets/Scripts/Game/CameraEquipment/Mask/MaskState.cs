using UnityEngine;

namespace Game.CameraEquipment.Mask
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MaskState : IMask
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <IsMaskAvailable>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MaskController _maskController;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsMaskAvailable { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsMaskAvailable()
        {
            return (bool)this.<IsMaskAvailable>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_IsMaskAvailable(bool value)
        {
            this.<IsMaskAvailable>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MaskState(Master.EventExposer masterEventExposer)
        {
            this._masterEventExposer = masterEventExposer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetFxController(MaskController maskController)
        {
            this._maskController = maskController;
            maskController.SetStatusCallback(maskStatusChanged:  new System.Action<MaskStatusChange>(object:  this, method:  System.Void Game.CameraEquipment.Mask.MaskState::MaskStatusChanged(MaskStatusChange change)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsMaskFullyOn()
        {
            if(this._maskController == 0)
            {
                    return false;
            }
            
            if(this._maskController != null)
            {
                    return this._maskController.IsMaskFullyOn();
            }
            
            return this._maskController.IsMaskFullyOn();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsMaskFullyOff()
        {
            if(this._maskController == 0)
            {
                    return true;
            }
            
            if(this._maskController != null)
            {
                    return this._maskController.IsMaskFullyOff();
            }
            
            return this._maskController.IsMaskFullyOff();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsMaskInTransition()
        {
            if(this._maskController == 0)
            {
                    return false;
            }
            
            if(this._maskController != null)
            {
                    return this._maskController.IsMaskInTransition();
            }
            
            return this._maskController.IsMaskInTransition();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetMaskAvailable(bool shouldMaskBeAvailable)
        {
            if(this._maskController == 0)
            {
                    return;
            }
            
            bool val_2 = shouldMaskBeAvailable;
            this.<IsMaskAvailable>k__BackingField = val_2;
            this._maskController.SetMaskAvailable(shouldMaskBeAvailable:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetDesiredMaskState(bool desiredMaskState)
        {
            if(this._maskController == 0)
            {
                    return;
            }
            
            this._maskController.SetDesiredMaskState(desiredMaskState:  desiredMaskState);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MaskStatusChanged(MaskStatusChange change)
        {
            if(change.WasTransitionForced == false)
            {
                goto label_1;
            }
            
            if(change.IsMaskGoingOn == false)
            {
                goto label_2;
            }
            
            return;
            label_1:
            this._masterEventExposer.OnMaskStateChanged(isMaskGoingOn:  (change.IsMaskGoingOn == true) ? 1 : 0, isMaskTransitionBeginning:  (change.IsTransitionBeginning == true) ? 1 : 0);
            return;
            label_2:
            this._masterEventExposer.OnMaskForcedOff();
        }
    
    }

}
