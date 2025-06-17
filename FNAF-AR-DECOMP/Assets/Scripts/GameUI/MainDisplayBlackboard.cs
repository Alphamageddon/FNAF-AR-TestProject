using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MainDisplayBlackboard
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.GameDisplayData.DisplayType _unblockDisplayExpected;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <IsLocked>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsLocked { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_IsLocked(bool value)
        {
            this.<IsLocked>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsLocked()
        {
            return (bool)this.<IsLocked>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UICanvasChanged(TheGame.GameDisplayData.DisplayType displayType)
        {
            if(this._unblockDisplayExpected != displayType)
            {
                    return;
            }
            
            this.<IsLocked>k__BackingField = false;
            this._masterDomain.eventExposer.remove_UICanvasDidAppear(value:  new System.Action<DisplayType>(object:  this, method:  System.Void GameUI.MainDisplayBlackboard::UICanvasChanged(TheGame.GameDisplayData.DisplayType displayType)));
            this._masterDomain.eventExposer.remove_UICanvasClosed(value:  new System.Action<DisplayType>(object:  this, method:  System.Void GameUI.MainDisplayBlackboard::UICanvasChanged(TheGame.GameDisplayData.DisplayType displayType)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MainDisplayBlackboard(Master.MasterDomain masterDomain)
        {
            this._masterDomain = masterDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LockDisplayChange(TheGame.GameDisplayData.DisplayType displayType)
        {
            if((this.<IsLocked>k__BackingField) != false)
            {
                    ConsoleLogger.LogError(className:  "MainDisplayBlackboard", functionName:  "LockDisplayChange", logString:  "Attempting to lock display that is already locked. Ignoring.");
                return;
            }
            
            this.<IsLocked>k__BackingField = true;
            this._unblockDisplayExpected = displayType;
            this._masterDomain.eventExposer.add_UICanvasDidAppear(value:  new System.Action<DisplayType>(object:  this, method:  System.Void GameUI.MainDisplayBlackboard::UICanvasChanged(TheGame.GameDisplayData.DisplayType displayType)));
            this._masterDomain.eventExposer.add_UICanvasClosed(value:  new System.Action<DisplayType>(object:  this, method:  System.Void GameUI.MainDisplayBlackboard::UICanvasChanged(TheGame.GameDisplayData.DisplayType displayType)));
        }
    
    }

}
