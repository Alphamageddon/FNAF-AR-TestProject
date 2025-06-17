using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DailyChallengesDisplayHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DailyChallengesDisplayHandler.LoadData _data;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DailyChallengesCellManager _dailyChallengesCellManager;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.PossibleRewardsCellManager _possibleRewardsCellManager;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AssetManagement.Icons.IIconLookup _iconLookup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Audio.IAudioPlayer _audioPlayer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _collectRewardsString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _rewardsCollectedString;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_ActiveDailyChallengesUpdated()
        {
            this.RefreshChallengeCells();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void IconCacheReady(Game.AssetManagement.Icons.IIconLookup obj)
        {
            this._iconLookup = obj;
            this._possibleRewardsCellManager.RefreshDisplayIcons(loadData:  new LoadData(), iconLookup:  obj);
            this.RefreshChallengeCells();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_DailyChallengeRewardReceived(string logical)
        {
            this.CollectReward(logical:  logical);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AudioReady(Game.Audio.IAudioPlayer obj)
        {
            this._audioPlayer = obj;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DailyChallengesDisplayHandler(GameUI.DailyChallengesDisplayHandler.LoadData dailyChallengesLoadData)
        {
            this._dailyChallengesCellManager = new GameUI.DailyChallengesCellManager();
            this._possibleRewardsCellManager = new GameUI.PossibleRewardsCellManager();
            System.Action val_3 = new System.Action(object:  this, method:  System.Void GameUI.DailyChallengesDisplayHandler::EventExposer_ActiveDailyChallengesUpdated());
            this._data.add_ActiveDailyChallengesUpdated(value:  val_3);
            this._data.SetEndTime(t:  val_3.ExpirationTime);
            this._data.add_DailyChallengeRewardReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void GameUI.DailyChallengesDisplayHandler::EventExposer_DailyChallengeRewardReceived(string logical)));
            this._possibleRewardsCellManager.GeneratePossibleRewardsCells(loadData:  new LoadData());
            this._possibleRewardsCellManager.RefreshDisplayContent(loadData:  new LoadData());
            Utilities.AsyncInterfaceAccess<Game.AssetManagement.Icons.IIconLookup> val_6 = this._data.IconLookupAccess;
            val_6.GetInterfaceAsync(callback:  new System.Action<Game.AssetManagement.Icons.IIconLookup>(object:  this, method:  System.Void GameUI.DailyChallengesDisplayHandler::IconCacheReady(Game.AssetManagement.Icons.IIconLookup obj)));
            val_6.AudioPlayer.GetInterfaceAsync(callback:  new System.Action<Game.Audio.IAudioPlayer>(object:  this, method:  System.Void GameUI.DailyChallengesDisplayHandler::AudioReady(Game.Audio.IAudioPlayer obj)));
            this.FetchLocalization();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FetchLocalization()
        {
            Game.Localization.LocalizationDomain val_1 = Game.Localization.LocalizationDomain.Instance;
            var val_7 = 0;
            val_7 = val_7 + 1;
            this._collectRewardsString = val_1.ILocalization.GetLocalizedString(localizedStringId:  "ui_daily_rewards_collect_button_text", originalString:  "Collect Rewards");
            Game.Localization.LocalizationDomain val_4 = Game.Localization.LocalizationDomain.Instance;
            var val_8 = 0;
            val_8 = val_8 + 1;
            this._rewardsCollectedString = val_4.ILocalization.GetLocalizedString(localizedStringId:  "ui_daily_rewards_collected_button_text", originalString:  "Collected");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RefreshChallengeCells()
        {
            this._dailyChallengesCellManager.GenerateCells(data:  new LoadData());
            this._dailyChallengesCellManager.SetCellData(data:  new LoadData());
            if(this._iconLookup == null)
            {
                    return;
            }
            
            this._dailyChallengesCellManager.SetCellIcons(data:  new LoadData(), iconLookup:  this._iconLookup);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CollectReward(string logical)
        {
            string val_5;
            int val_6;
            Game.AssetManagement.Icons.IIconLookup val_7;
            Game.DailyChallenge.Data.DailyChallengeRewardsData val_1 = GetReward(logical:  logical);
            var val_4 = 0;
            val_4 = val_4 + 1;
            this._audioPlayer.RaiseGameEventForMode(name:  89, mode:  3);
            if(val_1.Items.Item[0] != null)
            {
                    val_5 = val_2.LocRef;
                val_6 = val_2.Quantity;
                val_7 = this._iconLookup;
            }
            else
            {
                    val_5 = 0;
                val_6 = 64;
                val_7 = this._iconLookup;
            }
            
            this._audioPlayer.ShowCollectReward(locRef:  val_5, quantity:  64, iconLookup:  val_7, iconRef:  val_2.IconRef);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ShowMoreInfo()
        {
            X19.ShowPossibleRewards();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateCollectButtonState()
        {
            X20.text = ((X21 + 52) == 3) ? this._rewardsCollectedString : this._collectRewardsString;
            this.interactable = ((X20 + 52) == 2) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SelectMoreInfo()
        {
            this.ShowMoreInfo();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this.UpdateCollectButtonState();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDestroy()
        {
            this._data.remove_DailyChallengeRewardReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void GameUI.DailyChallengesDisplayHandler::EventExposer_DailyChallengeRewardReceived(string logical)));
            this._data.remove_ActiveDailyChallengesUpdated(value:  new System.Action(object:  this, method:  System.Void GameUI.DailyChallengesDisplayHandler::EventExposer_ActiveDailyChallengesUpdated()));
        }
    
    }

}
