using UnityEngine;

namespace GameUI.CanvasFlow
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GameProject_Alpine_CanvasController_Settings : GameProject_Alpine_SubCanvasController
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void CanvasWillAppear()
        {
            Systems.Analytics.AnalyticsCalls.FireEvent_Ui_UserHitNavigationButton_Settings();
            this.CanvasWillAppear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void CanvasWillDisappear()
        {
            Systems.Analytics.AnalyticsCalls.FireEvent_Ui_UserHitNavigationButton_Map();
            this.CanvasWillDisappear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameProject_Alpine_CanvasController_Settings()
        {
            mem[1152921524970356432] = 0;
            val_1 = new GameProject_Alpine_CanvasController_TransitionBroadcaster();
        }
    
    }

}
