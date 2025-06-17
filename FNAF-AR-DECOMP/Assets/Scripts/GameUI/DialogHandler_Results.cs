using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DialogHandler_Results : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ResultsUIActions resultsUIActions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject dialogRewardsWin;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject dialogRewardsLose;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.AlertUnityUIAdapter dialogResultsPlayerWin;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.AlertUnityUIAdapter dialogResultsPlayerLose;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.AlertUnityUIAdapter dialogResultsTutorialEnd;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.Alert dialogRewardsAlertWin;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.Alert dialogRewardsAlertLose;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.Alert dialogResultsAlertPlayerWin;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.Alert dialogResultsAlertPlayerLose;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.Alert dialogResultsAlertTutorialEnd;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowRewardsWin()
        {
            this.dialogRewardsAlertWin.Show();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowRewardsLose()
        {
            this.dialogRewardsAlertLose.Show();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowResultsPlayerWin()
        {
            this.dialogResultsAlertPlayerWin.Show();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowResultsPlayerLose()
        {
            this.dialogResultsAlertPlayerLose.Show();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowResultsTutorialEnd()
        {
            this.dialogResultsAlertTutorialEnd.Show();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            var val_38;
            var val_39;
            var val_41;
            var val_43;
            this.dialogRewardsAlertWin = new PaperPlaneTools.Alert(title:  0, message:  0);
            this.dialogRewardsAlertLose = new PaperPlaneTools.Alert(title:  0, message:  0);
            this.dialogResultsAlertPlayerWin = new PaperPlaneTools.Alert(title:  0, message:  0);
            this.dialogResultsAlertPlayerLose = new PaperPlaneTools.Alert(title:  0, message:  0);
            this.dialogResultsAlertTutorialEnd = new PaperPlaneTools.Alert(title:  0, message:  0);
            PaperPlaneTools.Alert val_7 = this.dialogRewardsAlertWin.SetAdapter(adaper:  this.dialogRewardsWin.GetComponent<PaperPlaneTools.IAlertPlatformAdapter>());
            PaperPlaneTools.Alert val_9 = this.dialogRewardsAlertLose.SetAdapter(adaper:  this.dialogRewardsLose.GetComponent<PaperPlaneTools.IAlertPlatformAdapter>());
            PaperPlaneTools.Alert val_10 = this.dialogResultsAlertPlayerWin.SetAdapter(adaper:  this.dialogResultsPlayerWin);
            PaperPlaneTools.Alert val_11 = this.dialogResultsAlertPlayerLose.SetAdapter(adaper:  this.dialogResultsPlayerLose);
            PaperPlaneTools.Alert val_12 = this.dialogResultsAlertTutorialEnd.SetAdapter(adaper:  this.dialogResultsTutorialEnd);
            PaperPlaneTools.Alert val_14 = this.dialogRewardsAlertWin.SetPositiveButton(title:  "RETURN", handler:  new System.Action(object:  this.resultsUIActions, method:  public System.Void GameUI.ResultsUIActions::HideResultsCanvas()));
            Game.Localization.LocalizationDomain val_15 = Game.Localization.LocalizationDomain.Instance;
            if(val_15 != null)
            {
                    val_15.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.DialogHandler_Results::<Awake>b__16_0(Game.Localization.ILocalization localization)));
            }
            
            val_38 = 0;
            PaperPlaneTools.Alert val_19 = this.dialogRewardsAlertLose.SetPositiveButton(title:  "RETURN", handler:  new System.Action(object:  this.resultsUIActions, method:  public System.Void GameUI.ResultsUIActions::HideResultsCanvas()));
            Game.Localization.LocalizationDomain val_20 = Game.Localization.LocalizationDomain.Instance;
            if(val_20 != null)
            {
                    System.Action<Game.Localization.ILocalization> val_22 = null;
                val_38 = public System.Void System.Action<Game.Localization.ILocalization>::.ctor(object object, IntPtr method);
                val_22 = new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.DialogHandler_Results::<Awake>b__16_1(Game.Localization.ILocalization localization));
                val_20.Localization.GetInterfaceAsync(callback:  val_22);
            }
            
            if(Game.Localization.LocalizationDomain.Instance == null)
            {
                goto label_20;
            }
            
            if(val_23.ILocalization == null)
            {
                goto label_15;
            }
            
            string val_40 = "ui_results_display_return_button_win";
            var val_39 = 0;
            val_39 = val_39 + 1;
            goto label_19;
            label_15:
            val_39 = 0;
            goto label_20;
            label_19:
            val_39 = val_23.ILocalization;
            string val_25 = val_39.GetLocalizedString(localizedStringId:  val_40, originalString:  "RETURN");
            label_20:
            val_40 = (val_25 == null) ? "RETURN" : (val_25);
            PaperPlaneTools.Alert val_27 = this.dialogResultsAlertPlayerWin.SetPositiveButton(title:  val_40, handler:  new System.Action(object:  this.resultsUIActions, method:  public System.Void GameUI.ResultsUIActions::HideResultsCanvas()));
            if(Game.Localization.LocalizationDomain.Instance == null)
            {
                goto label_28;
            }
            
            if(val_28.ILocalization == null)
            {
                goto label_23;
            }
            
            string val_42 = "ui_results_display_return_button_loss";
            var val_41 = 0;
            val_41 = val_41 + 1;
            goto label_27;
            label_23:
            val_41 = 0;
            goto label_28;
            label_27:
            val_41 = val_28.ILocalization;
            string val_30 = val_41.GetLocalizedString(localizedStringId:  val_42, originalString:  "RETURN");
            label_28:
            val_42 = (val_30 == null) ? "RETURN" : (val_30);
            PaperPlaneTools.Alert val_32 = this.dialogResultsAlertPlayerLose.SetPositiveButton(title:  val_42, handler:  new System.Action(object:  this.resultsUIActions, method:  public System.Void GameUI.ResultsUIActions::HideResultsCanvas()));
            if(Game.Localization.LocalizationDomain.Instance == null)
            {
                goto label_36;
            }
            
            if(val_33.ILocalization == null)
            {
                goto label_31;
            }
            
            var val_43 = 0;
            val_43 = val_43 + 1;
            goto label_35;
            label_31:
            val_43 = 0;
            goto label_36;
            label_35:
            val_43 = val_33.ILocalization;
            string val_35 = val_43.GetLocalizedString(localizedStringId:  "ui_results_display_return_button_loss", originalString:  "RETURN");
            label_36:
            PaperPlaneTools.Alert val_38 = this.dialogResultsAlertTutorialEnd.SetPositiveButton(title:  (val_35 == null) ? "RETURN" : (val_35), handler:  new System.Action(object:  this.resultsUIActions, method:  public System.Void GameUI.ResultsUIActions::HideResultsCanvas()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            if(this.dialogRewardsAlertWin != null)
            {
                    this.dialogRewardsAlertWin.Dismiss();
            }
            
            if(this.dialogRewardsAlertLose != null)
            {
                    this.dialogRewardsAlertLose.Dismiss();
            }
            
            this.dialogRewardsAlertWin = 0;
            this.dialogRewardsAlertLose = 0;
            if(this.dialogResultsAlertPlayerWin != null)
            {
                    this.dialogResultsAlertPlayerWin.Dismiss();
            }
            
            if(this.dialogResultsAlertPlayerLose != null)
            {
                    this.dialogResultsAlertPlayerLose.Dismiss();
            }
            
            if(this.dialogResultsAlertTutorialEnd != null)
            {
                    this.dialogResultsAlertTutorialEnd.Dismiss();
            }
            
            this.dialogResultsAlertPlayerLose = 0;
            this.dialogResultsAlertTutorialEnd = 0;
            this.dialogResultsAlertPlayerWin = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DialogHandler_Results()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <Awake>b__16_0(Game.Localization.ILocalization localization)
        {
            var val_5 = 0;
            val_5 = val_5 + 1;
            PaperPlaneTools.Alert val_4 = this.dialogRewardsAlertWin.SetPositiveButton(title:  localization.GetLocalizedString(localizedStringId:  "ui_results_display_return_button_win", originalString:  "RETURN"), handler:  new System.Action(object:  this.resultsUIActions, method:  public System.Void GameUI.ResultsUIActions::HideResultsCanvas()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <Awake>b__16_1(Game.Localization.ILocalization localization)
        {
            var val_5 = 0;
            val_5 = val_5 + 1;
            PaperPlaneTools.Alert val_4 = this.dialogRewardsAlertLose.SetPositiveButton(title:  localization.GetLocalizedString(localizedStringId:  "ui_results_display_return_button_loss", originalString:  "RETURN"), handler:  new System.Action(object:  this.resultsUIActions, method:  public System.Void GameUI.ResultsUIActions::HideResultsCanvas()));
        }
    
    }

}
