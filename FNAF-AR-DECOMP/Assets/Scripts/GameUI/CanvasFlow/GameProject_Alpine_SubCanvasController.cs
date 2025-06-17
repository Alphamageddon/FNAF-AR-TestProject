using UnityEngine;

namespace GameUI.CanvasFlow
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GameProject_Alpine_SubCanvasController : GameProject_Alpine_CanvasController_TransitionBroadcaster
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _backButtonActionId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain masterDomain;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override TheGame.GameDisplayData.DisplayType DisplayType { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override TheGame.GameDisplayData.DisplayType get_DisplayType()
        {
            return 5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_UIChangeRequest(TheGame.GameDisplayData.DisplayType obj)
        {
            this.DismissCanvasController(animated:  false, completion:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Start()
        {
            this.Start();
            this.masterDomain = Master.MasterDomain.GetDomain();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void CanvasWillAppear()
        {
            this.CanvasWillAppear();
            this.masterDomain.eventExposer.add_UIChangeRequest(value:  new System.Action<DisplayType>(object:  this, method:  System.Void GameUI.CanvasFlow.GameProject_Alpine_SubCanvasController::EventExposer_UIChangeRequest(TheGame.GameDisplayData.DisplayType obj)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void CanvasDidAppear()
        {
            this.CanvasDidAppear();
            this._backButtonActionId = Systems.Android.AndroidBackButtonHandler.PushBackButtonAction(backButtonAction:  new System.Action(object:  this, method:  System.Void GameUI.CanvasFlow.GameProject_Alpine_SubCanvasController::<CanvasDidAppear>b__7_0()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void CanvasWillDisappear()
        {
            this.CanvasWillDisappear();
            if(this.masterDomain.eventExposer == null)
            {
                    return;
            }
            
            this.masterDomain.eventExposer.remove_UIChangeRequest(value:  new System.Action<DisplayType>(object:  this, method:  System.Void GameUI.CanvasFlow.GameProject_Alpine_SubCanvasController::EventExposer_UIChangeRequest(TheGame.GameDisplayData.DisplayType obj)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void CanvasDidDisappear()
        {
            this.CanvasDidDisappear();
            if(this._backButtonActionId < 1)
            {
                    return;
            }
            
            BackButtonStackEntry val_1 = Systems.Android.AndroidBackButtonHandler.RemoveBackButtonActionById(backButtonId:  this._backButtonActionId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameProject_Alpine_SubCanvasController()
        {
            this._backButtonActionId = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <CanvasDidAppear>b__7_0()
        {
            this.DismissCanvasController(animated:  false, completion:  0);
            this._backButtonActionId = 0;
        }
    
    }

}
