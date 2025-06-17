using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SingleLineAttribute : PropertyAttribute
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Tooltip>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Tooltip { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SingleLineAttribute(string tooltip)
        {
            this.<Tooltip>k__BackingField = tooltip;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Tooltip()
        {
            return (string)this.<Tooltip>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Tooltip(string value)
        {
            this.<Tooltip>k__BackingField = value;
        }
    
    }

}
