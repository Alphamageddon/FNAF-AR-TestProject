using UnityEngine;

namespace GameUI.CanvasFlow
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GameProject_Alpine_CanvasController_Profile : GameProject_Alpine_SubCanvasController
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void CanvasWillAppear()
        {
            Systems.Analytics.AnalyticsCalls.FireEvent_Ui_UserHitNavigationButton_Profile();
            this.CanvasWillAppear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void CanvasWillDisappear()
        {
            Systems.Analytics.AnalyticsCalls.FireEvent_Ui_UserHitNavigationButton_Map();
            this.CanvasWillDisappear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameProject_Alpine_CanvasController_Profile()
        {
            mem[1152921524969539664] = 0;
            val_1 = new GameProject_Alpine_CanvasController_TransitionBroadcaster();
        }
    
    }

}
