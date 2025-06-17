using UnityEngine;

namespace GameUI.CanvasFlow
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GameProject_Alpine_CanvasController_Preamble : CanvasController
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string PREAMBLE_TRIGGER = "PlayPreamble";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEvents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Animator _animator;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Start()
        {
            this.Start();
            Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
            this._masterEvents = val_1.eventExposer;
            this._animator = this.GetComponent<UnityEngine.Animator>();
            this._masterEvents.SendPreloadEvent(preloadView:  this, eventName:  "start");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void StartAnimation()
        {
            this._animator.SetTrigger(name:  "PlayPreamble");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CompleteAnimation()
        {
            this._masterEvents.SendPreloadEvent(preloadView:  this, eventName:  "complete");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameProject_Alpine_CanvasController_Preamble()
        {
        
        }
    
    }

}
