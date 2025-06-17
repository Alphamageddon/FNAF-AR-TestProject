using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DialogHandler_DailyChallenges : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _collectRewardDialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _possibleRewardsDialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.RewardsDialog _rewardsDialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.Alert _collectRewardAlert;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.Alert _possibleRewardsAlert;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowPossibleRewards()
        {
            this._possibleRewardsAlert.Show();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            PaperPlaneTools.Alert val_2 = this._collectRewardAlert.SetAdapter(adaper:  this._collectRewardDialog.GetComponent<PaperPlaneTools.IAlertPlatformAdapter>());
            PaperPlaneTools.Alert val_3 = this._collectRewardAlert.SetNegativeButton(title:  System.String.alignConst, handler:  0);
            Game.Localization.LocalizationDomain val_4 = Game.Localization.LocalizationDomain.Instance;
            var val_11 = 0;
            val_11 = val_11 + 1;
            PaperPlaneTools.Alert val_7 = this._collectRewardAlert.SetNeutralButton(title:  val_4.ILocalization.GetLocalizedString(localizedStringId:  "ui_generic_ok", originalString:  "OK"), handler:  0);
            PaperPlaneTools.Alert val_9 = this._possibleRewardsAlert.SetAdapter(adaper:  this._possibleRewardsDialog.GetComponent<PaperPlaneTools.IAlertPlatformAdapter>());
            PaperPlaneTools.Alert val_10 = this._possibleRewardsAlert.SetNegativeButton(title:  System.String.alignConst, handler:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void ShowCollectReward(string locRef, int quantity, Game.AssetManagement.Icons.IIconLookup iconLookup, string iconRef)
        {
            string val_9;
            var val_9 = 0;
            val_9 = val_9 + 1;
            this._rewardsDialog.SetSprite(sprite:  iconLookup.GetIcon(group:  4, name:  iconRef));
            Game.Localization.LocalizationDomain val_3 = Game.Localization.LocalizationDomain.Instance;
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_9 = val_3.ILocalization.GetLocalizedString(localizedStringId:  locRef, originalString:  locRef);
            if(quantity >= 2)
            {
                    val_9 = val_9 + " x" + quantity.ToString();
            }
            
            PaperPlaneTools.Alert val_8 = this._collectRewardAlert.SetMessage(message:  val_9);
            this._collectRewardAlert.Show();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DialogHandler_DailyChallenges()
        {
            this._collectRewardAlert = new PaperPlaneTools.Alert(title:  0, message:  0);
            this._possibleRewardsAlert = new PaperPlaneTools.Alert(title:  0, message:  0);
        }
    
    }

}
