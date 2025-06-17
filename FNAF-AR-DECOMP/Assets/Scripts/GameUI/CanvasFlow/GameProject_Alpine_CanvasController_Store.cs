using UnityEngine;

namespace GameUI.CanvasFlow
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GameProject_Alpine_CanvasController_Store : GameProject_Alpine_CanvasController_TransitionBroadcaster
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override TheGame.GameDisplayData.DisplayType DisplayType { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override TheGame.GameDisplayData.DisplayType get_DisplayType()
        {
            return 3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameProject_Alpine_CanvasController_Store()
        {
        
        }
    
    }

}
