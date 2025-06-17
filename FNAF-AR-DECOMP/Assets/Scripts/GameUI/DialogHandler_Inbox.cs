using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DialogHandler_Inbox : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject tapToExpandImageDialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.Alert tapToExpandImageAlert;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            PaperPlaneTools.Alert val_1 = new PaperPlaneTools.Alert(title:  0, message:  0);
            this.tapToExpandImageAlert = val_1;
            PaperPlaneTools.Alert val_3 = val_1.SetAdapter(adaper:  this.tapToExpandImageDialog.GetComponent<PaperPlaneTools.IAlertPlatformAdapter>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            if(this.tapToExpandImageAlert != null)
            {
                    this.tapToExpandImageAlert.Dismiss();
            }
            
            this.tapToExpandImageAlert = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void ShowImageDialog(UnityEngine.Sprite sprite)
        {
            Utilities.AlertUtilities.ShowAlertWithAndroidBackButtonAction(alert:  this.tapToExpandImageAlert, backButtonAction:  new System.Action(object:  this, method:  System.Void GameUI.DialogHandler_Inbox::<ShowImageDialog>b__4_0()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DialogHandler_Inbox()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <ShowImageDialog>b__4_0()
        {
            this.tapToExpandImageAlert.Dismiss();
        }
    
    }

}
