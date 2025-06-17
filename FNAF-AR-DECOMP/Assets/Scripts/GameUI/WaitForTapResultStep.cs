using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class WaitForTapResultStep : BaseResultStep
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _hasBeenClicked;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly SimpleTimer _expireTimer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WaitForTapResultStep(GameUI.ResultStepConfig config)
        {
            this._expireTimer = new SimpleTimer();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool IsComplete()
        {
            var val_3;
            this.TryToExpire();
            if(this.HasStarted != false)
            {
                    var val_2 = (this._hasBeenClicked == true) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void StartStep()
        {
            this._expireTimer.StartTimer(time:  X21 + 60);
            this._expireTimer.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void GameUI.WaitForTapResultStep::ButtonClick()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ButtonClick()
        {
            this._hasBeenClicked = true;
            onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void GameUI.WaitForTapResultStep::ButtonClick()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TryToExpire()
        {
            if(this._expireTimer.Started() == false)
            {
                    return;
            }
            
            if(this._expireTimer.IsExpired() == false)
            {
                    return;
            }
            
            if(this._expireTimer != 0)
            {
                    if(this._expireTimer.IsContentShowing() != false)
            {
                    this._expireTimer.StartTimer(time:  5f);
                return;
            }
            
            }
            
            this.onClick.Invoke();
        }
    
    }

}
