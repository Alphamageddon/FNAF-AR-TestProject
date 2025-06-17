using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ResultsUIActions : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HideResultsCanvas()
        {
            DisplayType val_7;
            GameUI.Domain val_1 = this._masterDomain.gameUIDomain;
            bool val_4 = val_1.gameUIData.serverGameUIDataModel.featureFlagMap.IsResultsReturnToCameraAllowed();
            TheGame.GameDisplayChanger val_6 = this._masterDomain.theGameDomain.gameDisplayChanger;
            if(val_6 == null)
            {
                goto label_6;
            }
            
            if(val_4 == false)
            {
                goto label_7;
            }
            
            label_9:
            val_7 = 1;
            goto label_8;
            label_6:
            if(val_4 == true)
            {
                goto label_9;
            }
            
            label_7:
            val_7 = 0;
            label_8:
            val_6.RequestDisplayChange(displayType:  val_7);
            this._masterDomain.eventExposer.OnRewardsFlowCompleted();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this._masterDomain = Master.MasterDomain.GetDomain();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ResultsUIActions()
        {
        
        }
    
    }

}
