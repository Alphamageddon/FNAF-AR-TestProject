using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SharedUIActions : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.SharedUIView sharedUIView;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DialogHandler_Shared dialogHandler_Shared;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.Domain _theGameDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.AttackSequenceDomain _attackSequenceDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.EmailUIDataHandler _emailUIDataHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.WorkshopSlotDataModel _workshopSlotDataModel;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GoToCamera()
        {
            if(this._attackSequenceDomain.IsInEncounter() != false)
            {
                    Systems.Analytics.AnalyticsCalls.FireEvent_Ui_UserHitNavigationButton_Camera_Stun();
            }
            else
            {
                    Systems.Analytics.AnalyticsCalls.FireEvent_Ui_UserHitNavigationButton_Camera_Remnant();
            }
            
            this._theGameDomain.gameDisplayChanger.RequestDisplayChange(displayType:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetCameraMainDisplay()
        {
            this._theGameDomain.cameraPermissionGovernor.EnsurePermissions(success:  new System.Action(object:  this, method:  System.Void GameUI.SharedUIActions::GoToCamera()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetMapMainDisplay()
        {
            Systems.Analytics.AnalyticsCalls.FireEvent_Ui_UserHitNavigationButton_Map();
            this._theGameDomain.gameDisplayChanger.RequestDisplayChange(displayType:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetWorkshopMainDisplay()
        {
            Systems.Analytics.AnalyticsCalls.FireEvent_Ui_UserHitNavigationButton_Workshop(unlockedSlots:  this._workshopSlotDataModel._workshopSlotDatas.Count);
            this._theGameDomain.gameDisplayChanger.RequestDisplayChange(displayType:  2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetStoreMainDisplay()
        {
            Systems.Analytics.AnalyticsCalls.FireEvent_Ui_UserHitNavigationButton_Store();
            this._theGameDomain.gameDisplayChanger.RequestDisplayChange(displayType:  3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetInboxMainDisplay()
        {
            int val_1 = 0;
            this._emailUIDataHandler.GetNumberReadAndUnread(read: out  val_1, unread: out  val_1);
            Systems.Analytics.AnalyticsCalls.FireEvent_Ui_UserHitNavigationButton_Inbox(readEmails:  0, unreadEmails:  0);
            this._theGameDomain.gameDisplayChanger.RequestDisplayChange(displayType:  4);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClosePopDown()
        {
            this.sharedUIView.ClosePopDown();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Awake()
        {
            Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
            if(val_1 != null)
            {
                    this._theGameDomain = val_1.theGameDomain;
                this._attackSequenceDomain = val_1.AttackSequenceDomain;
            }
            else
            {
                    this._theGameDomain = 0.theGameDomain;
                this._attackSequenceDomain = 1;
            }
            
            GameUI.Domain val_4 = val_1.gameUIDomain;
            this._emailUIDataHandler = val_4.gameUIData.emailUIDataHandler;
            GameUI.Domain val_6 = val_1.gameUIDomain;
            this._workshopSlotDataModel = val_6.gameUIData.emailUIDataHandler;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SharedUIActions()
        {
        
        }
    
    }

}
