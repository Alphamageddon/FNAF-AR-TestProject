using UnityEngine;

namespace PaperPlaneTools
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AlertAndroidOptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool DefaultCancelable;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <Cancelable>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Cancelable { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AlertAndroidOptions()
        {
            null = null;
            this.<Cancelable>k__BackingField = PaperPlaneTools.AlertAndroidOptions.DefaultCancelable;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_Cancelable()
        {
            return (bool)this.<Cancelable>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Cancelable(bool value)
        {
            this.<Cancelable>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static AlertAndroidOptions()
        {
            PaperPlaneTools.AlertAndroidOptions.DefaultCancelable = true;
        }
    
    }

}
