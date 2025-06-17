using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class ProfileTabHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ProfileTabData profileTabData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string nameSaver;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<GameUI.ProfileAvatarSet> profileAvatarSets;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProfileTabHandler(Master.MasterDomain masterDomain, GameUI.ProfileUIActions profileUIActions, GameUI.ProfileTabData profileTabData)
        {
            val_1 = new System.Object();
            this._masterDomain = masterDomain;
            this.profileTabData = val_1;
            GameUI.Domain val_2 = masterDomain.gameUIDomain;
            this.profileAvatarSets = val_2.profileAvatarConfigs;
            this.SetupDisplayNameInputField(profileUIActions:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetupDisplayNameInputField(GameUI.ProfileUIActions profileUIActions)
        {
            this.profileTabData.tMP_Input.onSelect.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void GameUI.ProfileTabHandler::OnSelect(string arg0)));
            this.profileTabData.tMP_Input.onSelect.AddListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void GameUI.ProfileTabHandler::OnSelect(string arg0)));
            this.profileTabData.tMP_Input.onEndEdit.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void GameUI.ProfileTabHandler::OnEndEdit(string characters)));
            this.profileTabData.tMP_Input.onEndEdit.AddListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void GameUI.ProfileTabHandler::OnEndEdit(string characters)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnSelect(string arg0)
        {
            if(this._masterDomain == null)
            {
                goto label_6;
            }
            
            Server.LoginDomain val_2 = this._masterDomain.theGameDomain.loginDomain;
            if(val_2.playerProfile.displayName == null)
            {
                goto label_6;
            }
            
            label_9:
            this.profileTabData.tMP_Input.text = val_2.playerProfile.displayName;
            return;
            label_6:
            if(this.profileTabData.tMP_Input != null)
            {
                goto label_9;
            }
            
            goto label_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnSubmit(string newName)
        {
            Server.LoginDomain val_2 = this._masterDomain.theGameDomain.loginDomain;
            val_2.playerProfile.displayName = newName;
            Server.LoginDomain val_4 = this._masterDomain.theGameDomain.loginDomain;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_4.changeDisplayNameRequester.ChangeDisplayName(displayName:  newName);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEndEdit(string characters)
        {
            if((System.String.op_Inequality(a:  characters, b:  System.String.alignConst)) != false)
            {
                    this.OnSubmit(newName:  characters);
            }
            
            this.profileTabData.tMP_Input.text = System.String.alignConst;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateProfileStreakDisplays()
        {
            var val_13;
            var val_14;
            if(this._masterDomain != null)
            {
                    val_13 = this._masterDomain.gameUIDomain.GetServerCurrentStreak();
            }
            else
            {
                    val_13 = 0;
            }
            
            decimal val_3 = System.Decimal.op_Implicit(value:  0);
            this.profileTabData.currentStreakNumText.text = FormatNumber.ToKMB(num:  new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid});
            if(this._masterDomain != null)
            {
                    val_14 = this._masterDomain.gameUIDomain.GetServerBestStreak();
            }
            else
            {
                    val_14 = 0;
            }
            
            decimal val_7 = System.Decimal.op_Implicit(value:  0);
            this.profileTabData.maxStreakNumText.text = FormatNumber.ToKMB(num:  new System.Decimal() {flags = val_7.flags, hi = val_7.hi, lo = val_7.lo, mid = val_7.mid});
            decimal val_11 = System.Decimal.op_Implicit(value:  this._masterDomain.PlayerStatsDomain.PlayerStats.GetTotalRemnant());
            this.profileTabData.totalRemnantNumText.text = FormatNumber.ToKMB(num:  new System.Decimal() {flags = val_11.flags, hi = val_11.hi, lo = val_11.lo, mid = val_11.mid});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdatePlayerProfileNameDisplay()
        {
            if(this._masterDomain == null)
            {
                goto label_6;
            }
            
            Server.LoginDomain val_2 = this._masterDomain.theGameDomain.loginDomain;
            if(val_2.playerProfile.displayName == null)
            {
                goto label_6;
            }
            
            label_9:
            this.profileTabData.userNameText.text = val_2.playerProfile.displayName;
            return;
            label_6:
            if(this.profileTabData.userNameText != null)
            {
                goto label_9;
            }
            
            goto label_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateDisplay()
        {
            this.UpdateProfileStreakDisplays();
            this.UpdatePlayerProfileNameDisplay();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetAvatarIconSprite(UnityEngine.Sprite sprite)
        {
            this.profileTabData.avatarImage.SetSprite(sprite:  sprite);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RefreshAvatarIcon()
        {
            UnityEngine.Sprite val_3;
            if((this.profileAvatarSets.Find(match:  new System.Predicate<GameUI.ProfileAvatarSet>(object:  this, method:  System.Boolean GameUI.ProfileTabHandler::<RefreshAvatarIcon>b__13_0(GameUI.ProfileAvatarSet x)))) != null)
            {
                    val_3 = val_2.sprite;
            }
            else
            {
                    val_3 = 0;
            }
            
            this.SetAvatarIconSprite(sprite:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this.UpdateProfileStreakDisplays();
            this.UpdatePlayerProfileNameDisplay();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <RefreshAvatarIcon>b__13_0(GameUI.ProfileAvatarSet x)
        {
            Server.LoginDomain val_2 = this._masterDomain.theGameDomain.loginDomain;
            if(val_2.playerProfile != null)
            {
                    return System.String.op_Equality(a:  x.id, b:  val_2.playerProfile.avatarId);
            }
            
            return System.String.op_Equality(a:  x.id, b:  val_2.playerProfile.avatarId);
        }
    
    }

}
