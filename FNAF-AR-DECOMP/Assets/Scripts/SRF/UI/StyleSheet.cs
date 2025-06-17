using UnityEngine;

namespace SRF.UI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class StyleSheet : ScriptableObject
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<string> _keys;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<SRF.UI.Style> _styles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.UI.StyleSheet Parent;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.UI.Style GetStyle(string key, bool searchParent = True)
        {
            SRF.UI.StyleSheet val_4;
            var val_5;
            val_4 = this;
            goto label_5;
            label_8:
            if((searchParent == false) || (this.Parent == 0))
            {
                goto label_4;
            }
            
            val_4 = this.Parent;
            label_5:
            int val_2 = this.Parent._keys.IndexOf(item:  key);
            if((val_2 & 2147483648) != 0)
            {
                goto label_8;
            }
            
            SRF.UI.Style val_3 = this.Parent._styles.Item[val_2];
            return (SRF.UI.Style)val_5;
            label_4:
            val_5 = 0;
            return (SRF.UI.Style)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StyleSheet()
        {
            this._keys = new System.Collections.Generic.List<System.String>();
            this._styles = new System.Collections.Generic.List<SRF.UI.Style>();
        }
    
    }

}
