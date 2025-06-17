using UnityEngine;

namespace PaperPlaneTools
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AlertAndroidAdapter : IAlertPlatformAdapter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.AlertAndroid alertAndroid;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action onDismiss;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject gameObject;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AlertAndroidAdapter()
        {
            UnityEngine.GameObject val_4;
            UnityEngine.Object val_2 = UnityEngine.Object.Instantiate(original:  UnityEngine.Resources.Load(path:  "PaperPlaneTools/Alert/AlertCallbackHandler"));
            if(val_2 != null)
            {
                    var val_3 = (null == null) ? (val_2) : 0;
            }
            else
            {
                    val_4 = 0;
            }
            
            this.gameObject = val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PaperPlaneTools.IAlertPlatformAdapter.SetOnDismiss(System.Action action)
        {
            this.onDismiss = action;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PaperPlaneTools.IAlertPlatformAdapter.Show(PaperPlaneTools.Alert alert)
        {
            var val_2;
            System.Action val_18;
            var val_19;
            var val_20;
            var val_21;
            string val_23;
            if((alert.<OnDismiss>k__BackingField) != null)
            {
                    if(((System.Delegate.Combine(a:  this.onDismiss, b:  alert.<OnDismiss>k__BackingField)) != null) && (null != null))
            {
                    val_18 = 0;
            }
            
                this.onDismiss = val_18;
            }
            
            List.Enumerator<T> val_3 = alert.<Options>k__BackingField.GetEnumerator();
            label_9:
            if((1994058944 & 1) == 0)
            {
                goto label_6;
            }
            
            val_19 = val_2.emailUIDataHandler;
            if(val_19 == null)
            {
                goto label_9;
            }
            
            val_20 = 0;
            goto label_10;
            label_6:
            val_20 = 0;
            val_19 = 0;
            label_10:
            val_21 = 1;
            long val_6 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519485807808});
            if( == 0)
            {
                    PaperPlaneTools.AlertAndroidOptions val_7 = null;
                val_19 = val_7;
                val_7 = new PaperPlaneTools.AlertAndroidOptions();
            }
            
            this.alertAndroid = new PaperPlaneTools.AlertAndroid(title:  0, message:  0);
            .<Title>k__BackingField = alert.<Title>k__BackingField;
            val_23 = alert.<Message>k__BackingField;
            this.alertAndroid.<Message>k__BackingField = val_23;
            if((alert.<PositiveButton>k__BackingField) != null)
            {
                    val_23 = alert.<PositiveButton>k__BackingField.Title;
                this.alertAndroid.SetButton(whichButton:  0, title:  val_23, handler:  alert.<PositiveButton>k__BackingField.Handler);
            }
            
            if((alert.<NegativeButton>k__BackingField) != null)
            {
                    val_23 = alert.<NegativeButton>k__BackingField.Title;
                this.alertAndroid.SetButton(whichButton:  -2, title:  val_23, handler:  alert.<NegativeButton>k__BackingField.Handler);
            }
            
            if((alert.<NeutralButton>k__BackingField) != null)
            {
                    val_23 = alert.<NeutralButton>k__BackingField.Handler;
                this.alertAndroid.SetButton(whichButton:  -3, title:  alert.<NeutralButton>k__BackingField.Title, handler:  val_23);
            }
            
            this.alertAndroid.OnDismiss = new System.Action(object:  this, method:  System.Void PaperPlaneTools.AlertAndroidAdapter::onDismissCallback());
            this.alertAndroid.<Cancelable>k__BackingField = (PaperPlaneTools.AlertAndroidOptions)[1152921519485876480].<Cancelable>k__BackingField;
            this.alertAndroid.Show(gameObjectName:  this.gameObject.transform.name);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PaperPlaneTools.IAlertPlatformAdapter.Dismiss()
        {
            if(this.alertAndroid == null)
            {
                    return;
            }
            
            this.alertAndroid.Dismiss();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PaperPlaneTools.IAlertPlatformAdapter.HandleEvent(string eventName, string value)
        {
            string val_5;
            PaperPlaneTools.AlertAndroid val_6;
            val_5 = value;
            val_6 = this;
            if(this.alertAndroid == null)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  eventName, b:  "AlertAndroid_OnButtonClick")) != false)
            {
                    val_5 = System.Int32.Parse(s:  val_5);
                this.alertAndroid.HandleButtonClick(whichButton:  val_5);
            }
            
            bool val_3 = System.String.op_Equality(a:  eventName, b:  "AlertAndroid_OnCancel");
            if((System.String.op_Equality(a:  eventName, b:  "AlertAndroid_OnDismiss")) == false)
            {
                    return;
            }
            
            val_6 = this.alertAndroid;
            if(this.alertAndroid.OnDismiss == null)
            {
                    return;
            }
            
            this.alertAndroid.OnDismiss.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onDismissCallback()
        {
            if(this.onDismiss != null)
            {
                    this.onDismiss.Invoke();
            }
            
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
    
    }

}
