using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BottomBarHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.BottomBarData _bottomBarData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool rewardsOpen;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Func<bool> IsInAttack;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Func<TheGame.GameDisplayData.DisplayType, bool> IsDisplayType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool showCameraPopDown;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_GameDisplayChange(TheGame.GameDisplayData obj)
        {
            this.SetHighlightToggle(index:  obj.currentDisplay);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_RewardDialogOpened()
        {
            this.rewardsOpen = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_RewardDialogClosed()
        {
            this.rewardsOpen = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_AttackEncounterStarted(Game.ItemDefinition.Data.DataDefinitions.EncounterType obj)
        {
            this.showCameraPopDown = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_AttackEncounterEnded()
        {
            this.showCameraPopDown = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_NewCameraUIIconAnimator(Systems.Guide.UI.CameraUIIconAnimator cameraUiIconAnimator)
        {
            if(this._bottomBarData != null)
            {
                goto label_0;
            }
            
            this._bottomBarData = this._bottomBarData;
            if(this._bottomBarData == null)
            {
                goto label_1;
            }
            
            label_0:
            cameraUiIconAnimator.Setup(isInAttack:  this.IsInAttack, isDisplayType:  this.IsDisplayType, cameraImageAlert:  this._bottomBarData.cameraImageAlert, cameraAlertToggleTime:  this._bottomBarData.cameraAlertToggleTime);
            return;
            label_1:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetHighlightToggle(int index)
        {
            if(this._bottomBarData.bottomBarButtons.Count <= index)
            {
                    return;
            }
            
            this._bottomBarData.bottomBarButtons.Item[index].SetHighlightAndOtherCellsHighlightState(value:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateBarVisibility()
        {
            var val_15;
            var val_16;
            GameUI.Domain val_1 = this._bottomBarData.masterDomain.gameUIDomain;
            GameUI.Domain val_3 = this._bottomBarData.masterDomain.gameUIDomain;
            bool val_6 = this._bottomBarData.masterDomain.theGameDomain.gameDisplayChanger.IsDisplayType(displayType:  1);
            bool val_9 = this._bottomBarData.masterDomain.theGameDomain.gameDisplayChanger.IsDisplayType(displayType:  7);
            if((val_6 | (~val_1.gameUIData.showUIBars)) == false)
            {
                goto label_16;
            }
            
            val_15 = 0;
            if(this._bottomBarData.bottomBarParent != null)
            {
                goto label_19;
            }
            
            goto label_18;
            label_16:
            bool val_13 = this.rewardsOpen;
            val_13 = val_13 ^ 1;
            val_15 = val_13 & 255;
            if(this._bottomBarData.bottomBarParent != null)
            {
                goto label_19;
            }
            
            label_18:
            label_19:
            this._bottomBarData.bottomBarParent.SetActive(value:  (val_15 != W23) ? 1 : 0);
            if(val_6 == false)
            {
                goto label_21;
            }
            
            bool val_14 = this.rewardsOpen;
            val_14 = val_14 ^ 1;
            val_16 = val_14 & 255;
            if(this._bottomBarData.bottomBarCloseParent != null)
            {
                goto label_24;
            }
            
            goto label_23;
            label_21:
            val_16 = 0;
            if(this._bottomBarData.bottomBarCloseParent != null)
            {
                goto label_24;
            }
            
            label_23:
            label_24:
            this._bottomBarData.bottomBarCloseParent.SetActive(value:  (val_16 != 0) ? 1 : 0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateCameraAlert()
        {
            bool val_8;
            if(this.IsInAttack.Invoke() != false)
            {
                    if((this.IsDisplayType.Invoke(arg:  1)) == false)
            {
                goto label_4;
            }
            
            }
            
            val_8 = 0;
            goto label_5;
            label_4:
            val_8 = (this.IsDisplayType.Invoke(arg:  7)) ^ 1;
            label_5:
            if(val_8 ^ this._bottomBarData.cameraButtonPulse.activeSelf == false)
            {
                    return;
            }
            
            this._bottomBarData.cameraButtonPulse.SetActive(value:  val_8);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DisableCameraPopDown()
        {
            this.showCameraPopDown = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EnableCameraPopDown()
        {
            this.showCameraPopDown = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BottomBarHandler(GameUI.BottomBarData bottomBarData)
        {
            this._bottomBarData = bottomBarData;
            this.IsInAttack = new System.Func<System.Boolean>(object:  bottomBarData.masterDomain.AttackSequenceDomain, method:  public System.Boolean Game.AttackSequence.AttackSequenceDomain::IsInEncounter());
            this.IsDisplayType = new System.Func<DisplayType, System.Boolean>(object:  this._bottomBarData.masterDomain.theGameDomain.gameDisplayChanger, method:  public System.Boolean TheGame.GameDisplayChanger::IsDisplayType(TheGame.GameDisplayData.DisplayType displayType));
            this._bottomBarData.masterDomain.eventExposer.add_GameDisplayChange(value:  new System.Action<TheGame.GameDisplayData>(object:  this, method:  System.Void GameUI.BottomBarHandler::EventExposer_GameDisplayChange(TheGame.GameDisplayData obj)));
            this._bottomBarData.masterDomain.eventExposer.add_RewardDialogOpened(value:  new System.Action(object:  this, method:  System.Void GameUI.BottomBarHandler::EventExposer_RewardDialogOpened()));
            this._bottomBarData.masterDomain.eventExposer.add_RewardDialogClosed(value:  new System.Action(object:  this, method:  System.Void GameUI.BottomBarHandler::EventExposer_RewardDialogClosed()));
            this._bottomBarData.masterDomain.eventExposer.add_AttackEncounterStarted(value:  new System.Action<Game.ItemDefinition.Data.DataDefinitions.EncounterType>(object:  this, method:  System.Void GameUI.BottomBarHandler::EventExposer_AttackEncounterStarted(Game.ItemDefinition.Data.DataDefinitions.EncounterType obj)));
            this._bottomBarData.masterDomain.eventExposer.add_AttackEncounterEnded(value:  new System.Action(object:  this, method:  System.Void GameUI.BottomBarHandler::EventExposer_AttackEncounterEnded()));
            this._bottomBarData.masterDomain.eventExposer.add_NewCameraUIIconAnimator(value:  new System.Action<Systems.Guide.UI.CameraUIIconAnimator>(object:  this, method:  System.Void GameUI.BottomBarHandler::EventExposer_NewCameraUIIconAnimator(Systems.Guide.UI.CameraUIIconAnimator cameraUiIconAnimator)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this.UpdateBarVisibility();
            this.UpdateCameraAlert();
        }
    
    }

}
