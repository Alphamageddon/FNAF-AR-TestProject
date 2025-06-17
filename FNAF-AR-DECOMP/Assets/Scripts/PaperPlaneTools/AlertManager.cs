using UnityEngine;

namespace PaperPlaneTools
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AlertManager
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.IAlertPlatformAdapter currentAdapter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.Alert currentAlert;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<PaperPlaneTools.Alert> queue;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PaperPlaneTools.AlertManager instance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Func<PaperPlaneTools.IAlertPlatformAdapter> <AlertFactory>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static PaperPlaneTools.AlertManager Instance { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Func<PaperPlaneTools.IAlertPlatformAdapter> AlertFactory { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AlertManager()
        {
            this.queue = new System.Collections.Generic.List<PaperPlaneTools.Alert>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static PaperPlaneTools.AlertManager get_Instance()
        {
            System.Func<PaperPlaneTools.IAlertPlatformAdapter> val_3;
            PaperPlaneTools.AlertManager val_4;
            var val_5;
            val_4 = PaperPlaneTools.AlertManager.instance;
            if(val_4 != null)
            {
                    return val_4;
            }
            
            PaperPlaneTools.AlertManager.instance = new PaperPlaneTools.AlertManager();
            val_5 = null;
            val_5 = null;
            val_3 = AlertManager.<>c.<>9__6_0;
            if(val_3 == null)
            {
                goto label_4;
            }
            
            label_9:
            mem[1152921519498732856] = val_3;
            val_4 = PaperPlaneTools.AlertManager.instance;
            return val_4;
            label_4:
            AlertManager.<>c.<>9__6_0 = new System.Func<PaperPlaneTools.IAlertPlatformAdapter>(object:  AlertManager.<>c.__il2cppRuntimeField_static_fields, method:  PaperPlaneTools.IAlertPlatformAdapter AlertManager.<>c::<get_Instance>b__6_0());
            if(PaperPlaneTools.AlertManager.instance != null)
            {
                goto label_9;
            }
            
            goto label_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Func<PaperPlaneTools.IAlertPlatformAdapter> get_AlertFactory()
        {
            return (System.Func<PaperPlaneTools.IAlertPlatformAdapter>)this.<AlertFactory>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_AlertFactory(System.Func<PaperPlaneTools.IAlertPlatformAdapter> value)
        {
            this.<AlertFactory>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Show(PaperPlaneTools.Alert alert)
        {
            this.queue.Add(item:  alert);
            this.ShowNext();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Dismiss(PaperPlaneTools.Alert alert)
        {
            if(this.currentAlert == alert)
            {
                goto label_1;
            }
            
            label_4:
            int val_1 = this.queue.IndexOf(item:  alert);
            if((val_1 >> 31) == 0)
            {
                goto label_3;
            }
            
            return;
            label_1:
            if(this.currentAdapter == null)
            {
                goto label_4;
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            goto label_8;
            label_3:
            this.queue.RemoveAt(index:  val_1);
            if(alert.OnDismiss == null)
            {
                    return;
            }
            
            alert.OnDismiss.Invoke();
            return;
            label_8:
            this.currentAdapter.Dismiss();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HandleEvent(string eventName, string value)
        {
            if(this.currentAlert == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.currentAdapter.HandleEvent(name:  eventName, value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.IAlertPlatformAdapter CreateAdapter()
        {
            if((this.<AlertFactory>k__BackingField) == null)
            {
                    return (PaperPlaneTools.IAlertPlatformAdapter)this.<AlertFactory>k__BackingField;
            }
            
            return this.<AlertFactory>k__BackingField.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDismiss()
        {
            this.currentAdapter = 0;
            this.currentAlert = 0;
            this.ShowNext();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ShowNext()
        {
            IntPtr val_10;
            var val_12;
            if(this.currentAdapter != null)
            {
                    return;
            }
            
            if(this.queue.Count < 1)
            {
                    return;
            }
            
            this.currentAlert = this.queue.Item[0];
            this.queue.RemoveAt(index:  0);
            if(this.currentAlert == null)
            {
                    return;
            }
            
            if(this.currentAlert.Adapter != null)
            {
                    PaperPlaneTools.IAlertPlatformAdapter val_4 = this.currentAlert.Adapter;
            }
            else
            {
                    PaperPlaneTools.IAlertPlatformAdapter val_5 = this.CreateAdapter();
            }
            
            this.currentAdapter = val_5;
            System.Action val_6 = null;
            val_10 = System.Void PaperPlaneTools.AlertManager::OnDismiss();
            val_6 = new System.Action(object:  this, method:  val_10);
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_10 = 0;
            val_12 = public System.Void PaperPlaneTools.IAlertPlatformAdapter::SetOnDismiss(System.Action action);
            val_5.SetOnDismiss(action:  val_6);
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_12 = 1;
            this.currentAdapter.Show(alert:  this.currentAlert);
        }
    
    }

}
