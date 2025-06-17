using UnityEngine;

namespace SRDebugger.UI.Other
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SRTab : SRMonoBehaviourEx
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.RectTransform HeaderExtraContent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Sprite Icon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.RectTransform IconExtraContent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string IconStyleKey;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int SortIndex;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.UI.Controls.SRTabButton TabButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _title;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _longTitle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _key;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Title { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string LongTitle { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Key { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Title()
        {
            return (string)this._title;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_LongTitle()
        {
            return (string)((System.String.IsNullOrEmpty(value:  this._longTitle)) != true) ? 1152921522954381640 : (this._longTitle);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Key()
        {
            return (string)this._key;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRTab()
        {
            this.IconStyleKey = "Icon_Stompy";
        }
    
    }

}
