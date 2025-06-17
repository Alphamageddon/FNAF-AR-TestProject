using UnityEngine;

namespace Utilities
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class AlertUtilities
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ShowAlertWithAndroidBackButtonAction(PaperPlaneTools.Alert alert, System.Action backButtonAction)
        {
            var val_7;
            AlertUtilities.<>c__DisplayClass0_0 val_1 = new AlertUtilities.<>c__DisplayClass0_0();
            if(val_1 != null)
            {
                    val_7 = val_1;
                .alert = alert;
                mem[1152921523189842488] = backButtonAction;
            }
            else
            {
                    mem[24] = backButtonAction;
                val_7 = 32;
                mem[32] = alert;
            }
            
            .backButtonActionId = 0;
            .backButtonActionId = Systems.Android.AndroidBackButtonHandler.PushBackButtonAction(backButtonAction:  new System.Action(object:  val_1, method:  System.Void AlertUtilities.<>c__DisplayClass0_0::<ShowAlertWithAndroidBackButtonAction>b__0()));
            .oldOnDismiss = val_7.OnDismiss;
            PaperPlaneTools.Alert val_6 = mem[32].SetOnDismiss(handler:  new System.Action(object:  val_1, method:  System.Void AlertUtilities.<>c__DisplayClass0_0::<ShowAlertWithAndroidBackButtonAction>b__1()));
            mem[32].Show();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ShowAlertWithAndroidBackButtonPause(PaperPlaneTools.Alert alert)
        {
            .alert = alert;
            .pauseId = Systems.Android.AndroidBackButtonHandler.Pause();
            .oldOnDismiss = (AlertUtilities.<>c__DisplayClass1_0)[1152921523190012832].alert.OnDismiss;
            PaperPlaneTools.Alert val_5 = (AlertUtilities.<>c__DisplayClass1_0)[1152921523190012832].alert.SetOnDismiss(handler:  new System.Action(object:  new AlertUtilities.<>c__DisplayClass1_0(), method:  System.Void AlertUtilities.<>c__DisplayClass1_0::<ShowAlertWithAndroidBackButtonPause>b__0()));
            (AlertUtilities.<>c__DisplayClass1_0)[1152921523190012832].alert.Show();
        }
    
    }

}
