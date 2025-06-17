using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class IllumixButton : Button
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float throttleTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool blockOnCanvasTransitions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TheGame.GameDisplayData.DisplayType displayTypeToBlockFor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.IllumixButtonBlackBoard illumixButtonBlackBoard;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.MainDisplayBlackboard mainDisplayBlackboard;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Start()
        {
            this.Start();
            Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
            this.masterDomain = val_1;
            GameUI.Domain val_2 = val_1.gameUIDomain;
            this.illumixButtonBlackBoard = null;
            GameUI.Domain val_3 = this.masterDomain.gameUIDomain;
            this.mainDisplayBlackboard = null;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if((this.illumixButtonBlackBoard.<ButtonsLocked>k__BackingField) != false)
            {
                    return;
            }
            
            if(this.blockOnCanvasTransitions != false)
            {
                    if((this.mainDisplayBlackboard.<IsLocked>k__BackingField) == true)
            {
                    return;
            }
            
                this.mainDisplayBlackboard.LockDisplayChange(displayType:  this.displayTypeToBlockFor);
            }
            
            this.illumixButtonBlackBoard.LockButtons(delay:  this.throttleTime);
            this.OnPointerClick(eventData:  eventData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IllumixButton()
        {
            this.throttleTime = 0.5f;
            this.displayTypeToBlockFor = 5;
        }
    
    }

}
