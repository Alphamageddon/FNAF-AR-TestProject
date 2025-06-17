using UnityEngine;

namespace PaperPlaneTools
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AlertUnityUIAdapter : MonoBehaviour, IAlertPlatformAdapter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMPro.TextMeshProUGUI titleTextTMP;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMPro.TextMeshProUGUI messageTextTMP;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text titleText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text messageText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Button positiveButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Button neutralButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Button negativeButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject dismissPanel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action onDismiss;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PaperPlaneTools.IAlertPlatformAdapter.SetOnDismiss(System.Action action)
        {
            this.onDismiss = action;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PaperPlaneTools.IAlertPlatformAdapter.Dismiss()
        {
            this.gameObject.SetActive(value:  false);
            if(this.onDismiss == null)
            {
                    return;
            }
            
            this.onDismiss.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PaperPlaneTools.IAlertPlatformAdapter.Show(PaperPlaneTools.Alert alert)
        {
            string val_49;
            System.Action val_50;
            UnityEngine.Object val_51;
            var val_52;
            TMPro.TextMeshProUGUI val_54;
            val_49 = alert;
            if(val_49.OnDismiss != null)
            {
                    if(((System.Delegate.Combine(a:  this.onDismiss, b:  val_49.OnDismiss)) != null) && (null != null))
            {
                    val_50 = 0;
            }
            
                this.onDismiss = val_50;
            }
            
            this.transform.SetAsLastSibling();
            if(this.titleText == 0)
            {
                goto label_15;
            }
            
            this.titleText.gameObject.SetActive(value:  (val_49.Title != null) ? 1 : 0);
            if(this.titleText == 0)
            {
                goto label_15;
            }
            
            if(val_49.Title == null)
            {
                goto label_17;
            }
            
            string val_12 = val_49.Title;
            if(this.titleText != null)
            {
                goto label_49;
            }
            
            label_50:
            label_49:
            label_15:
            if(this.messageText == 0)
            {
                goto label_28;
            }
            
            this.messageText.gameObject.SetActive(value:  (val_49.Message != null) ? 1 : 0);
            if(this.messageText == 0)
            {
                goto label_28;
            }
            
            if(val_49.Message == null)
            {
                goto label_30;
            }
            
            string val_19 = val_49.Message;
            if(this.messageText != null)
            {
                goto label_51;
            }
            
            label_52:
            label_51:
            label_28:
            this.SetButton(uiButton:  this.positiveButton, alertButton:  val_49.PositiveButton);
            this.SetButton(uiButton:  this.neutralButton, alertButton:  val_49.NeutralButton);
            this.SetButton(uiButton:  this.negativeButton, alertButton:  val_49.NegativeButton);
            if(this.dismissPanel == 0)
            {
                goto label_55;
            }
            
            val_51 = this.dismissPanel.GetComponent<UnityEngine.EventSystems.EventTrigger>();
            if(val_51 != 0)
            {
                goto label_48;
            }
            
            UnityEngine.Component val_27 = this.dismissPanel.AddComponent(componentType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_51 = 0;
            goto label_48;
            label_17:
            if(this.titleText != null)
            {
                goto label_49;
            }
            
            goto label_50;
            label_30:
            if(this.messageText != null)
            {
                goto label_51;
            }
            
            goto label_52;
            label_48:
            if( == 0)
            {
                goto label_55;
            }
            
            System.Collections.Generic.List<Entry> val_29 = new System.Collections.Generic.List<Entry>();
            triggers = val_29;
            val_52 = null;
            val_52 = null;
            if((AlertUnityUIAdapter.<>c.<>9__11_0) == null)
            {
                goto label_59;
            }
            
            label_66:
            int val_30 = val_29.RemoveAll(match:  AlertUnityUIAdapter.<>c.<>9__11_0);
            EventTrigger.Entry val_31 = new EventTrigger.Entry();
            if(val_31 == null)
            {
                goto label_61;
            }
            
            .eventID = 4;
            goto label_62;
            label_59:
            AlertUnityUIAdapter.<>c.<>9__11_0 = new System.Predicate<Entry>(object:  AlertUnityUIAdapter.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean AlertUnityUIAdapter.<>c::<PaperPlaneTools.IAlertPlatformAdapter.Show>b__11_0(UnityEngine.EventSystems.EventTrigger.Entry foo));
            if(val_29 != null)
            {
                goto label_66;
            }
            
            goto label_66;
            label_61:
            mem[16] = 4;
            label_62:
            (EventTrigger.Entry)[1152921519489161120].callback.AddListener(call:  new UnityEngine.Events.UnityAction<UnityEngine.EventSystems.BaseEventData>(object:  this, method:  System.Void PaperPlaneTools.AlertUnityUIAdapter::<PaperPlaneTools.IAlertPlatformAdapter.Show>b__11_1(UnityEngine.EventSystems.BaseEventData eventData)));
            val_29.Add(item:  val_31);
            label_55:
            this.gameObject.SetActive(value:  true);
            if(this.titleTextTMP == 0)
            {
                goto label_78;
            }
            
            this.titleTextTMP.gameObject.SetActive(value:  (val_49.Title != null) ? 1 : 0);
            if(this.titleTextTMP == 0)
            {
                goto label_78;
            }
            
            if(val_49.Title == null)
            {
                goto label_80;
            }
            
            if(this.titleTextTMP != null)
            {
                goto label_96;
            }
            
            label_97:
            label_96:
            this.titleTextTMP.text = val_49.Title;
            label_78:
            val_54 = this.messageTextTMP;
            if(val_54 == 0)
            {
                    return;
            }
            
            this.messageTextTMP.gameObject.SetActive(value:  (val_49.Message != null) ? 1 : 0);
            val_54 = this.messageTextTMP;
            if(val_54 == 0)
            {
                    return;
            }
            
            if(val_49.Message == null)
            {
                goto label_93;
            }
            
            val_49 = val_49.Message;
            if(this.messageTextTMP != null)
            {
                goto label_98;
            }
            
            label_99:
            label_98:
            this.messageTextTMP.text = val_49;
            return;
            label_80:
            if(this.titleTextTMP != null)
            {
                goto label_96;
            }
            
            goto label_97;
            label_93:
            if(this.messageTextTMP != null)
            {
                goto label_98;
            }
            
            goto label_99;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PaperPlaneTools.IAlertPlatformAdapter.HandleEvent(string name, string value)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetButton(UnityEngine.UI.Button uiButton, PaperPlaneTools.AlertButton alertButton)
        {
            PaperPlaneTools.AlertButton val_17;
            var val_18;
            var val_19;
            string val_20;
            val_17 = alertButton;
            AlertUnityUIAdapter.<>c__DisplayClass13_0 val_1 = new AlertUnityUIAdapter.<>c__DisplayClass13_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .alertButton = val_17;
            if(uiButton == 0)
            {
                    return;
            }
            
            uiButton.gameObject.SetActive(value:  (((AlertUnityUIAdapter.<>c__DisplayClass13_0)[1152921519489653408].alertButton) != 0) ? 1 : 0);
            UnityEngine.Component[] val_18 = uiButton.GetComponentsInChildren(t:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), includeInactive:  true);
            if((val_18 != null) && (val_6.Length != 0))
            {
                    UnityEngine.Component val_17 = val_18[0];
                val_18 = 0;
                if(((AlertUnityUIAdapter.<>c__DisplayClass13_0)[1152921519489653408].alertButton) != null)
            {
                    var val_7 = (((AlertUnityUIAdapter.<>c__DisplayClass13_0)[1152921519489653408].alertButton.<Title>k__BackingField) == null) ? "" : ((AlertUnityUIAdapter.<>c__DisplayClass13_0)[1152921519489653408].alertButton + 16);
            }
            else
            {
                    val_19 = "";
                val_18 = 0;
            }
            
            }
            
            UnityEngine.Component[] val_10 = uiButton.GetComponentsInChildren(t:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), includeInactive:  true);
            if((val_10 == null) || (val_10.Length == 0))
            {
                goto label_27;
            }
            
            UnityEngine.Component val_19 = val_10[0];
            if(((AlertUnityUIAdapter.<>c__DisplayClass13_0)[1152921519489653408].alertButton) == null)
            {
                goto label_31;
            }
            
            val_20 = mem[(AlertUnityUIAdapter.<>c__DisplayClass13_0)[1152921519489653408].alertButton.<Title>k__BackingField == null ? "" : (AlertUnityUIAdapter.<>c__DisplayClass13_0)[1152921519489653408].alertButton + 16];
            val_20 = (((AlertUnityUIAdapter.<>c__DisplayClass13_0)[1152921519489653408].alertButton.<Title>k__BackingField) == null) ? "" : ((AlertUnityUIAdapter.<>c__DisplayClass13_0)[1152921519489653408].alertButton + 16);
            if(0 != 0)
            {
                goto label_32;
            }
            
            goto label_33;
            label_31:
            val_20 = "";
            label_33:
            label_32:
            0.text = val_20;
            label_27:
            uiButton.onClick.RemoveAllListeners();
            val_17 = uiButton.onClick;
            val_17.AddListener(call:  new UnityEngine.Events.UnityAction(object:  val_1, method:  System.Void AlertUnityUIAdapter.<>c__DisplayClass13_0::<SetButton>b__0()));
            if(((AlertUnityUIAdapter.<>c__DisplayClass13_0)[1152921519489653408].alertButton) == null)
            {
                    return;
            }
            
            if(((AlertUnityUIAdapter.<>c__DisplayClass13_0)[1152921519489653408].alertButton.<Handler>k__BackingField) == null)
            {
                    return;
            }
            
            uiButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  val_1, method:  System.Void AlertUnityUIAdapter.<>c__DisplayClass13_0::<SetButton>b__1()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AlertUnityUIAdapter()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <PaperPlaneTools.IAlertPlatformAdapter.Show>b__11_1(UnityEngine.EventSystems.BaseEventData eventData)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.Dismiss();
        }
    
    }

}
