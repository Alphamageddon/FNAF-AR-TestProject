using UnityEngine;

namespace GameUI.CanvasFlow
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GameProject_Alpine_CanvasController_Results : GameProject_Alpine_CanvasController_TransitionBroadcaster
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _pauseId;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override TheGame.GameDisplayData.DisplayType DisplayType { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override TheGame.GameDisplayData.DisplayType get_DisplayType()
        {
            return 7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void CanvasDidAppear()
        {
            this.CanvasDidAppear();
            this._pauseId = Systems.Android.AndroidBackButtonHandler.Pause();
            Master.MasterDomain val_2 = Master.MasterDomain.GetDomain();
            val_2.essenceCollectionDomain.RewardsFlowActive = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void CanvasDidDisappear()
        {
            this.CanvasDidDisappear();
            Systems.Android.AndroidBackButtonHandler.Unpause(pauseId:  this._pauseId);
            this._pauseId = 0;
            Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
            val_1.essenceCollectionDomain.RewardsFlowActive = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameProject_Alpine_CanvasController_Results()
        {
            this._pauseId = 0;
        }
    
    }

}
