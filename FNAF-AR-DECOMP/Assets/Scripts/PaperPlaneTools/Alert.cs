using UnityEngine;

namespace PaperPlaneTools
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Alert
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Title>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Message>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.AlertButton <PositiveButton>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.AlertButton <NegativeButton>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.AlertButton <NeutralButton>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<object> <Options>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action <OnDismiss>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.IAlertPlatformAdapter <Adapter>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Title { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Message { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PaperPlaneTools.AlertButton PositiveButton { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PaperPlaneTools.AlertButton NegativeButton { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PaperPlaneTools.AlertButton NeutralButton { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<object> Options { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action OnDismiss { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PaperPlaneTools.IAlertPlatformAdapter Adapter { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Alert(string title, string message)
        {
            val_1 = new System.Object();
            this.<Title>k__BackingField = title;
            this.<Message>k__BackingField = val_1;
            this.<Options>k__BackingField = new System.Collections.Generic.List<System.Object>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Title()
        {
            return (string)this.<Title>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Title(string value)
        {
            this.<Title>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Message()
        {
            return (string)this.<Message>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Message(string value)
        {
            this.<Message>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PaperPlaneTools.AlertButton get_PositiveButton()
        {
            return (PaperPlaneTools.AlertButton)this.<PositiveButton>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_PositiveButton(PaperPlaneTools.AlertButton value)
        {
            this.<PositiveButton>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PaperPlaneTools.AlertButton get_NegativeButton()
        {
            return (PaperPlaneTools.AlertButton)this.<NegativeButton>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_NegativeButton(PaperPlaneTools.AlertButton value)
        {
            this.<NegativeButton>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PaperPlaneTools.AlertButton get_NeutralButton()
        {
            return (PaperPlaneTools.AlertButton)this.<NeutralButton>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_NeutralButton(PaperPlaneTools.AlertButton value)
        {
            this.<NeutralButton>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<object> get_Options()
        {
            return (System.Collections.Generic.List<System.Object>)this.<Options>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Options(System.Collections.Generic.List<object> value)
        {
            this.<Options>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action get_OnDismiss()
        {
            return (System.Action)this.<OnDismiss>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_OnDismiss(System.Action value)
        {
            this.<OnDismiss>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PaperPlaneTools.IAlertPlatformAdapter get_Adapter()
        {
            return (PaperPlaneTools.IAlertPlatformAdapter)this.<Adapter>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Adapter(PaperPlaneTools.IAlertPlatformAdapter value)
        {
            this.<Adapter>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PaperPlaneTools.Alert SetTitle(string title)
        {
            this.<Title>k__BackingField = title;
            return (PaperPlaneTools.Alert)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PaperPlaneTools.Alert SetMessage(string message)
        {
            this.<Message>k__BackingField = message;
            return (PaperPlaneTools.Alert)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PaperPlaneTools.Alert SetPositiveButton(string title, System.Action handler)
        {
            this.<PositiveButton>k__BackingField = new PaperPlaneTools.AlertButton(title:  title, handler:  handler);
            return (PaperPlaneTools.Alert)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClearPositiveButton()
        {
            this.<PositiveButton>k__BackingField = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PaperPlaneTools.Alert SetNegativeButton(string title, System.Action handler)
        {
            this.<NegativeButton>k__BackingField = new PaperPlaneTools.AlertButton(title:  title, handler:  handler);
            return (PaperPlaneTools.Alert)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClearNegativeButton()
        {
            this.<NegativeButton>k__BackingField = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PaperPlaneTools.Alert SetNeutralButton(string title, System.Action handler)
        {
            this.<NeutralButton>k__BackingField = new PaperPlaneTools.AlertButton(title:  title, handler:  handler);
            return (PaperPlaneTools.Alert)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClearNeutralButton()
        {
            this.<NeutralButton>k__BackingField = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PaperPlaneTools.Alert AddOptions(object opt)
        {
            this.<Options>k__BackingField.Add(item:  opt);
            return (PaperPlaneTools.Alert)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PaperPlaneTools.Alert SetOptions(System.Collections.Generic.List<object> options)
        {
            this.<Options>k__BackingField = options;
            return (PaperPlaneTools.Alert)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PaperPlaneTools.Alert SetOnDismiss(System.Action handler)
        {
            this.<OnDismiss>k__BackingField = handler;
            return (PaperPlaneTools.Alert)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PaperPlaneTools.Alert SetAdapter(PaperPlaneTools.IAlertPlatformAdapter adaper)
        {
            this.<Adapter>k__BackingField = adaper;
            return (PaperPlaneTools.Alert)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Show()
        {
            PaperPlaneTools.AlertManager.Instance.Show(alert:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Dismiss()
        {
            PaperPlaneTools.AlertManager.Instance.Dismiss(alert:  this);
        }
    
    }

}
