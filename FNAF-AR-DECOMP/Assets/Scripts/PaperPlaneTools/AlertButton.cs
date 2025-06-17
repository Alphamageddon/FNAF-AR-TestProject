using UnityEngine;

namespace PaperPlaneTools
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AlertButton
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Title>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action <Handler>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Title { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action Handler { get; set; }
        
        // Methods
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
        public AlertButton(string title, System.Action handler)
        {
            this.<Title>k__BackingField = title;
            this.<Handler>k__BackingField = handler;
        }
    
    }

}
