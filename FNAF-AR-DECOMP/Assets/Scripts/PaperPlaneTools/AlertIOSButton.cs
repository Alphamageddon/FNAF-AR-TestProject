using UnityEngine;

namespace PaperPlaneTools
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AlertIOSButton
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.AlertIOSButton.Type <WhichButton>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Title>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action <Handler>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <IsPreferable>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PaperPlaneTools.AlertIOSButton.Type WhichButton { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Title { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action Handler { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsPreferable { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AlertIOSButton(PaperPlaneTools.AlertIOSButton.Type whichButton, string title, System.Action handler, bool isPreferable)
        {
            val_1 = new System.Object();
            this.<WhichButton>k__BackingField = whichButton;
            this.<Title>k__BackingField = val_1;
            this.<Handler>k__BackingField = handler;
            this.<IsPreferable>k__BackingField = isPreferable;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PaperPlaneTools.AlertIOSButton.Type get_WhichButton()
        {
            return (Type)this.<WhichButton>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_WhichButton(PaperPlaneTools.AlertIOSButton.Type value)
        {
            this.<WhichButton>k__BackingField = value;
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
        public System.Action get_Handler()
        {
            return (System.Action)this.<Handler>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Handler(System.Action value)
        {
            this.<Handler>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsPreferable()
        {
            return (bool)this.<IsPreferable>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_IsPreferable(bool value)
        {
            this.<IsPreferable>k__BackingField = value;
        }
    
    }

}
