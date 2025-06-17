using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TopBarDisplayHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.TopBarDisplayHandler.TopBarDisplayData topBarDisplayData;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_PlayerAvatarUpdated()
        {
            Server.LoginDomain val_2 = this.topBarDisplayData.masterDomain.theGameDomain.loginDomain;
            this.UpdatePlayerAvatarImage(avatarId:  val_2.playerProfile.avatarId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_PlayerProfileUpdated(Server.PlayerProfile obj)
        {
            this.UpdatePlayerAvatarImage(avatarId:  obj.avatarId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdatePlayerAvatarImage(string avatarId)
        {
            UnityEngine.Sprite val_5;
            .avatarId = avatarId;
            GameUI.Domain val_2 = this.topBarDisplayData.masterDomain.gameUIDomain;
            if((val_2.profileAvatarConfigs.Find(match:  new System.Predicate<GameUI.ProfileAvatarSet>(object:  new TopBarDisplayHandler.<>c__DisplayClass4_0(), method:  System.Boolean TopBarDisplayHandler.<>c__DisplayClass4_0::<UpdatePlayerAvatarImage>b__0(GameUI.ProfileAvatarSet x)))) != null)
            {
                    val_5 = val_4.sprite;
            }
            else
            {
                    val_5 = 0;
            }
            
            this.topBarDisplayData.playerAvatarImage.overrideSprite = val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateTopBarParentVisibility()
        {
            var val_15;
            var val_16;
            GameUI.Domain val_1 = this.topBarDisplayData.masterDomain.gameUIDomain;
            Systems.Guide.FeatureFlags.FeatureFlagMap val_3 = val_1.gameUIData.serverGameUIDataModel.featureFlagMap;
            if(val_3 != null)
            {
                    val_15 = val_3.IsTopBarAllowed();
            }
            else
            {
                    val_15 = 0;
            }
            
            GameUI.Domain val_5 = this.topBarDisplayData.masterDomain.gameUIDomain;
            if((this.topBarDisplayData.masterDomain.theGameDomain.gameDisplayChanger.IsDisplayType(displayType:  1)) != false)
            {
                    val_16 = 0;
            }
            else
            {
                    DisplayType val_14 = 7;
                val_16 = (~(this.topBarDisplayData.masterDomain.theGameDomain.gameDisplayChanger.IsDisplayType(displayType:  val_14))) & 1;
            }
            
            val_15 = val_15 & (val_5.gameUIData.<storeSectionToScrollTo>k__BackingField);
            val_14 = ((val_15 != null) ? 1 : 0) & ((val_16 != 0) ? 1 : 0);
            this.topBarDisplayData.topBarParent.SetActive(value:  val_14);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateStreakDisplay()
        {
            GameUI.Domain val_1 = this.topBarDisplayData.masterDomain.gameUIDomain;
            decimal val_2 = System.Decimal.op_Implicit(value:  val_1.gameUIData.<popDownDataModel>k__BackingField);
            this.topBarDisplayData.streakNumText.text = FormatNumber.ToKMB(num:  new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid});
            GameUI.Domain val_4 = this.topBarDisplayData.masterDomain.gameUIDomain;
            decimal val_5 = System.Decimal.op_Implicit(value:  mem[val_4.gameUIData + 28]);
            this.topBarDisplayData.streakMaxNumText.text = FormatNumber.ToKMB(num:  new System.Decimal() {flags = val_5.flags, hi = val_5.hi, lo = val_5.lo, mid = val_5.mid});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateCurrentParts()
        {
            decimal val_4 = System.Decimal.op_Implicit(value:  this.topBarDisplayData.masterDomain.theGameDomain.bank.GetCurrency(currencyName:  "PARTS"));
            this.topBarDisplayData.partsNumText.text = FormatNumber.ToKMB(num:  new System.Decimal() {flags = val_4.flags, hi = val_4.hi, lo = val_4.lo, mid = val_4.mid});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateCurrentEssence()
        {
            decimal val_4 = System.Decimal.op_Implicit(value:  this.topBarDisplayData.masterDomain.WorkshopDomain.Inventory.CurrencyContainer.Essence);
            this.topBarDisplayData.essenceNumText.text = FormatNumber.ToKMB(num:  new System.Decimal() {flags = val_4.flags, hi = val_4.hi, lo = val_4.lo, mid = val_4.mid});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateFazTokensText()
        {
            int val_7 = this.topBarDisplayData.masterDomain.theGameDomain.bank.GetCurrency(currencyName:  "FAZ_TOKENS");
            GameUI.Domain val_4 = this.topBarDisplayData.masterDomain.gameUIDomain;
            val_7 = val_7 - val_4.rewardCollector.uncollectedFazTokens;
            decimal val_5 = System.Decimal.op_Implicit(value:  val_7);
            this.topBarDisplayData.fazTokenText.text = FormatNumber.ToKMB(num:  new System.Decimal() {flags = val_5.flags, hi = val_5.hi, lo = val_5.lo, mid = val_5.mid});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateDailyRewardsButtonDisplay()
        {
            var val_3;
            if((mem[this.topBarDisplayData.gameUIDomain.gameUIData + 65]) == 0)
            {
                goto label_3;
            }
            
            val_3 = 0;
            if((this.topBarDisplayData.gameDisplayChanger.IsDisplayType(displayType:  0)) == false)
            {
                goto label_10;
            }
            
            var val_2 = ((mem[this.topBarDisplayData.gameUIDomain.gameUIData + 76]) != 0) ? 1 : 0;
            goto label_10;
            label_3:
            val_3 = 0;
            label_10:
            this.topBarDisplayData.dailyChallengesButtonParent.SetActive(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TopBarDisplayHandler(GameUI.TopBarDisplayHandler.TopBarDisplayData topBarDisplayData)
        {
            this.topBarDisplayData = topBarDisplayData;
            topBarDisplayData.masterDomain.eventExposer.add_PlayerAvatarUpdated(value:  new System.Action(object:  this, method:  System.Void GameUI.TopBarDisplayHandler::EventExposer_PlayerAvatarUpdated()));
            topBarDisplayData.masterDomain.eventExposer.add_PlayerProfileUpdated(value:  new System.Action<Server.PlayerProfile>(object:  this, method:  System.Void GameUI.TopBarDisplayHandler::EventExposer_PlayerProfileUpdated(Server.PlayerProfile obj)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this.UpdateTopBarParentVisibility();
            this.UpdateStreakDisplay();
            this.UpdateCurrentParts();
            this.UpdateCurrentEssence();
            this.UpdateFazTokensText();
            this.UpdateDailyRewardsButtonDisplay();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDestroy()
        {
            if(this.topBarDisplayData.masterDomain.eventExposer == null)
            {
                    return;
            }
            
            this.topBarDisplayData.masterDomain.eventExposer.remove_PlayerAvatarUpdated(value:  new System.Action(object:  this, method:  System.Void GameUI.TopBarDisplayHandler::EventExposer_PlayerAvatarUpdated()));
            this.topBarDisplayData.masterDomain.eventExposer.remove_PlayerProfileUpdated(value:  new System.Action<Server.PlayerProfile>(object:  this, method:  System.Void GameUI.TopBarDisplayHandler::EventExposer_PlayerProfileUpdated(Server.PlayerProfile obj)));
        }
    
    }

}
