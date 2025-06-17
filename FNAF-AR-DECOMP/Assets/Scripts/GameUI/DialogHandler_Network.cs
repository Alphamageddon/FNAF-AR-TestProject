using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DialogHandler_Network : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject genericDialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.Alert genericAlert;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_GenericDialogRequestRecieved(GameUI.GenericDialogData data)
        {
            this.ShowGenericDialog(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddSubscriptions()
        {
            this._masterDomain.eventExposer.add_NetworkDialogRequestReceived(value:  new System.Action<GameUI.GenericDialogData>(object:  this, method:  System.Void GameUI.DialogHandler_Network::EventExposer_GenericDialogRequestRecieved(GameUI.GenericDialogData data)));
            this._masterDomain.eventExposer.add_NetworkDialogRequestRemoved(value:  new System.Action(object:  this, method:  System.Void GameUI.DialogHandler_Network::CancelAlert()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RemoveSubcriptions()
        {
            if(this._masterDomain.eventExposer == null)
            {
                    return;
            }
            
            this._masterDomain.eventExposer.remove_NetworkDialogRequestReceived(value:  new System.Action<GameUI.GenericDialogData>(object:  this, method:  System.Void GameUI.DialogHandler_Network::EventExposer_GenericDialogRequestRecieved(GameUI.GenericDialogData data)));
            this._masterDomain.eventExposer.remove_NetworkDialogRequestRemoved(value:  new System.Action(object:  this, method:  System.Void GameUI.DialogHandler_Network::CancelAlert()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowGenericDialog(string title, string message, string positiveButtonText, System.Action positiveButtonAction, string neutralButtonText, System.Action neutralButtonAction, string negativeButtonText, System.Action negativeButtonAction)
        {
            if(title == null)
            {
                goto label_1;
            }
            
            label_9:
            PaperPlaneTools.Alert val_1 = this.genericAlert.SetTitle(title:  title);
            if(message == null)
            {
                goto label_3;
            }
            
            label_11:
            PaperPlaneTools.Alert val_2 = this.genericAlert.SetMessage(message:  message);
            var val_4 = ((positiveButtonText | positiveButtonAction) == null) ? 1 : 0;
            if(this.genericAlert == null)
            {
                goto label_5;
            }
            
            if((val_4 & 1) == 0)
            {
                goto label_6;
            }
            
            label_12:
            this.genericAlert.ClearPositiveButton();
            goto label_7;
            label_1:
            if(this.genericAlert != null)
            {
                goto label_9;
            }
            
            goto label_9;
            label_3:
            if(this.genericAlert != null)
            {
                goto label_11;
            }
            
            goto label_11;
            label_5:
            if((val_4 & 1) != 0)
            {
                goto label_12;
            }
            
            label_6:
            PaperPlaneTools.Alert val_5 = this.genericAlert.SetPositiveButton(title:  positiveButtonText, handler:  positiveButtonAction);
            label_7:
            var val_7 = ((neutralButtonText | neutralButtonAction) == null) ? 1 : 0;
            if(this.genericAlert == null)
            {
                goto label_13;
            }
            
            if((val_7 & 1) == 0)
            {
                goto label_14;
            }
            
            label_16:
            this.genericAlert.ClearNeutralButton();
            goto label_15;
            label_13:
            if((val_7 & 1) != 0)
            {
                goto label_16;
            }
            
            label_14:
            PaperPlaneTools.Alert val_8 = this.genericAlert.SetNeutralButton(title:  neutralButtonText, handler:  neutralButtonAction);
            label_15:
            var val_10 = ((negativeButtonText | negativeButtonAction) == null) ? 1 : 0;
            if(this.genericAlert == null)
            {
                goto label_17;
            }
            
            if((val_10 & 1) == 0)
            {
                goto label_18;
            }
            
            label_19:
            this.genericAlert.ClearNegativeButton();
            Utilities.AlertUtilities.ShowAlertWithAndroidBackButtonPause(alert:  this.genericAlert);
            return;
            label_17:
            if((val_10 & 1) != 0)
            {
                goto label_19;
            }
            
            label_18:
            PaperPlaneTools.Alert val_11 = this.genericAlert.SetNegativeButton(title:  negativeButtonText, handler:  negativeButtonAction);
            Utilities.AlertUtilities.ShowAlertWithAndroidBackButtonAction(alert:  this.genericAlert, backButtonAction:  new System.Action(object:  this, method:  System.Void GameUI.DialogHandler_Network::<ShowGenericDialog>b__6_0()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowGenericDialog(GameUI.GenericDialogData obj)
        {
            string val_1;
            string val_2;
            string val_3;
            System.Action val_4;
            string val_5;
            System.Action val_6;
            string val_7;
            if(obj != null)
            {
                    val_1 = obj.title;
                val_2 = obj.message;
                val_3 = obj.positiveButtonText;
                val_4 = obj.positiveButtonAction;
                val_5 = obj.neutralButtonText;
                val_6 = obj.neutralButtonAction;
                val_7 = obj.negativeButtonText;
            }
            else
            {
                    val_1 = 11993091;
                val_2 = 15026800;
                val_3 = 64;
                val_4 = 69077560;
                val_5 = 0;
                val_6 = 4194311;
                val_7 = 1;
            }
            
            this.ShowGenericDialog(title:  val_1, message:  val_2, positiveButtonText:  val_3, positiveButtonAction:  val_4, neutralButtonText:  val_5, neutralButtonAction:  val_6, negativeButtonText:  val_7, negativeButtonAction:  obj.negativeButtonAction);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetupGenericDialog()
        {
            PaperPlaneTools.Alert val_1 = new PaperPlaneTools.Alert(title:  0, message:  0);
            this.genericAlert = val_1;
            PaperPlaneTools.Alert val_3 = val_1.SetAdapter(adaper:  this.genericDialog.GetComponent<PaperPlaneTools.IAlertPlatformAdapter>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CancelAlert()
        {
            this.genericAlert.Dismiss();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this.SetupGenericDialog();
            this._masterDomain = Master.MasterDomain.GetDomain();
            this.AddSubscriptions();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            if(this.genericAlert != null)
            {
                    this.genericAlert.Dismiss();
            }
            
            this.genericAlert = 0;
            this.RemoveSubcriptions();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DialogHandler_Network()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <ShowGenericDialog>b__6_0()
        {
            System.Action val_2 = this.genericAlert.NegativeButton.Handler;
            if(val_2 != null)
            {
                    val_2.Invoke();
            }
            
            this.genericAlert.Dismiss();
        }
    
    }

}
