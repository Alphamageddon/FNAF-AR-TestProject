using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SequentialRewardsDisplayHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int FLASH_TIME = 2;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.SequentialRewardsDisplayData _hookups;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.SequentialRewardsButtonDisplay _sequentialRewardsButtonDisplay;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.SequentialRewardsDisplayHandler.ButtonState _buttonState;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.SequentialRewardPackage _nextSequentialReward;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _flashTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _buttonReady;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SequentialRewardsDisplayHandler(GameUI.SequentialRewardsDisplayData sequentialRewardsDisplayData)
        {
            this._hookups = sequentialRewardsDisplayData;
            sequentialRewardsDisplayData.eventExposer.add_SequentialRewardsModelUpdated(value:  new System.Action<System.Collections.Generic.List<Game.SeasonalEvents.Data.SeasonalEventData>>(object:  this, method:  System.Void GameUI.SequentialRewardsDisplayHandler::EventExposer_SequentialRewardsModelUpdated(System.Collections.Generic.List<Game.SeasonalEvents.Data.SeasonalEventData> eventData)));
            this.BuildPackageFromEventData(eventData:  this._hookups.sequentialRewardDataModel.seasonalEventData);
            this.InitializeButton(button:  this._hookups.sequentialRewardDataModel.sequentialRewardsButtonDisplay);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_SequentialRewardsModelUpdated(System.Collections.Generic.List<Game.SeasonalEvents.Data.SeasonalEventData> eventData)
        {
            this.BuildPackageFromEventData(eventData:  eventData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void InitializeButton(GameUI.SequentialRewardsButtonDisplay button)
        {
            if(button != 0)
            {
                    this._sequentialRewardsButtonDisplay = button;
                this._buttonReady = true;
                button._showSequentialRewardsDialog = new System.Action(object:  this, method:  public System.Void GameUI.SequentialRewardsDisplayHandler::ShowSequentialRewardsDialog());
                return;
            }
            
            this._hookups.eventExposer.add_SequentialRewardsButtonReady(value:  new System.Action<GameUI.SequentialRewardsButtonDisplay>(object:  this, method:  System.Void GameUI.SequentialRewardsDisplayHandler::InitializeButton(GameUI.SequentialRewardsButtonDisplay button)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BuildPackageFromEventData(System.Collections.Generic.List<Game.SeasonalEvents.Data.SeasonalEventData> eventData)
        {
            var val_5;
            SequentialRewardsDisplayHandler.<>c__DisplayClass11_0 val_1 = new SequentialRewardsDisplayHandler.<>c__DisplayClass11_0();
            if(val_1 != null)
            {
                    val_5 = val_1;
                .eventData = eventData;
                mem[1152921524872608120] = this;
                this._buttonState = 0;
            }
            else
            {
                    val_5 = 16;
                mem[16] = eventData;
                mem[24] = this;
                this._buttonState = 0;
            }
            
            if(val_5 != 0)
            {
                    Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  val_1, method:  System.Void SequentialRewardsDisplayHandler.<>c__DisplayClass11_0::<BuildPackageFromEventData>b__0(Game.Localization.ILocalization localization)));
                return;
            }
            
            this._nextSequentialReward = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ConsumeNextReward()
        {
            GameUI.SequentialRewardPackage val_1;
            GameUI.SequentialRewardPackage val_2;
            string val_3;
            GameUI.SequentialRewardPackage val_4;
            GameUI.SequentialRewardPackage val_5;
            val_1 = this._nextSequentialReward;
            if(val_1 == null)
            {
                    return;
            }
            
            if(this._hookups != null)
            {
                goto label_2;
            }
            
            val_1 = this._nextSequentialReward;
            if(val_1 == null)
            {
                goto label_13;
            }
            
            label_2:
            this._hookups.sequentialRewardsDialog.SetSprite(sprite:  this._nextSequentialReward.sprite);
            val_2 = this._nextSequentialReward;
            if(val_2 == null)
            {
                goto label_6;
            }
            
            val_3 = this._nextSequentialReward.title;
            val_4 = val_2;
            goto label_9;
            label_6:
            val_4 = this._nextSequentialReward;
            val_3 = this._nextSequentialReward.title;
            if(val_4 == null)
            {
                goto label_8;
            }
            
            val_2 = val_4;
            goto label_9;
            label_8:
            val_2 = this._nextSequentialReward;
            if(val_2 == null)
            {
                goto label_13;
            }
            
            label_9:
            this._hookups.dialogHandler_Map.ShowSequentialRewardsDialog(title:  val_3, message:  this._nextSequentialReward.message, buttonText:  this._nextSequentialReward.buttonText);
            val_5 = this._nextSequentialReward;
            if(this._nextSequentialReward != null)
            {
                goto label_12;
            }
            
            val_5 = this._nextSequentialReward;
            if(val_5 == null)
            {
                goto label_13;
            }
            
            label_12:
            Systems.Analytics.AnalyticsCalls.FireEvent_Collect_SequentialReward(season:  this._nextSequentialReward.season, sequenceIndex:  this._nextSequentialReward.sequenceIndex);
            this._hookups.sequentialRewardRequester.ConsumeReward(logical:  this._nextSequentialReward.season);
            this._nextSequentialReward = 0;
            this._buttonState = 3;
            return;
            label_13:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateTimerType()
        {
            GameUI.SequentialRewardPackage val_5;
            if(this._flashTime > 0f)
            {
                    float val_1 = UnityEngine.Time.deltaTime;
                val_1 = this._flashTime - val_1;
                this._flashTime = val_1;
            }
            
            if(this._buttonState == 3)
            {
                    return;
            }
            
            val_5 = this._nextSequentialReward;
            if(val_5 != null)
            {
                    if(this._nextSequentialReward.sequenceIndex != 1)
            {
                    System.TimeSpan val_2 = this.GetTimeDiff();
                var val_4 = (val_2._ticks.Milliseconds < 1) ? (1 + 1) : 1;
            }
            else
            {
                    val_5 = 0;
            }
            
            }
            
            this._buttonState = val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.TimeSpan GetTimeDiff()
        {
            double val_2 = (double)TheGame.ServerTime.GetCurrentTime();
            val_2 = this._nextSequentialReward.timeAvailableAt - val_2;
            return System.TimeSpan.FromSeconds(value:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateButtonState()
        {
            var val_3;
            if((this._hookups.serverGameUIDataModel.<AlertsAllowed>k__BackingField) != false)
            {
                    val_3 = this._hookups.gameDisplayChanger.IsDisplayType(displayType:  0);
            }
            else
            {
                    val_3 = 0;
            }
            
            this._sequentialRewardsButtonDisplay.UpdateDisplayState(buttonState:  this._buttonState, allowShow:  val_3 & 1);
            if(this._buttonState != 1)
            {
                    return;
            }
            
            System.TimeSpan val_3 = this.GetTimeDiff();
            this._sequentialRewardsButtonDisplay.ShowCountdown(diff:  new System.TimeSpan() {_ticks = val_3._ticks}, flashTime:  this._flashTime);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadNextReward(GameUI.SequentialRewardPackage sequentialRewardPackage)
        {
            this._nextSequentialReward = sequentialRewardPackage;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowSequentialRewardsDialog()
        {
            if(this._buttonState == 2)
            {
                    this.ConsumeNextReward();
                return;
            }
            
            this._flashTime = 2f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this.UpdateTimerType();
            if(this._buttonReady == false)
            {
                    return;
            }
            
            this.UpdateButtonState();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDestroy()
        {
            this._hookups.eventExposer.remove_SequentialRewardsModelUpdated(value:  new System.Action<System.Collections.Generic.List<Game.SeasonalEvents.Data.SeasonalEventData>>(object:  this, method:  System.Void GameUI.SequentialRewardsDisplayHandler::EventExposer_SequentialRewardsModelUpdated(System.Collections.Generic.List<Game.SeasonalEvents.Data.SeasonalEventData> eventData)));
            this._hookups.eventExposer.remove_SequentialRewardsButtonReady(value:  new System.Action<GameUI.SequentialRewardsButtonDisplay>(object:  this, method:  System.Void GameUI.SequentialRewardsDisplayHandler::InitializeButton(GameUI.SequentialRewardsButtonDisplay button)));
        }
    
    }

}
