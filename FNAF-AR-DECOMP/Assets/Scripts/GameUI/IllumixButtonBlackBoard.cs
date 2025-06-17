using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IllumixButtonBlackBoard
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <ButtonsLocked>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ButtonsLocked { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_ButtonsLocked()
        {
            return (bool)this.<ButtonsLocked>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ButtonsLocked(bool value)
        {
            this.<ButtonsLocked>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IllumixButtonBlackBoard(Master.MasterDomain masterDomain)
        {
            this._masterDomain = masterDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator LockButtonsWithDelay(float delay)
        {
            IllumixButtonBlackBoard.<LockButtonsWithDelay>d__6 val_1 = new IllumixButtonBlackBoard.<LockButtonsWithDelay>d__6();
            .<>1__state = 0;
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .delay = delay;
            return (System.Collections.IEnumerator)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LockButtons(float delay = 0)
        {
            if((this.<ButtonsLocked>k__BackingField) != false)
            {
                    ConsoleLogger.LogError(className:  "IllumixButtonBlackBoard", functionName:  "LockButtons", logString:  "Attempt to lock illumix buttons when already locked; ignoring");
                return;
            }
            
            UnityEngine.Coroutine val_2 = this._masterDomain.StartCoroutine(routine:  this.LockButtonsWithDelay(delay:  delay));
        }
    
    }

}
