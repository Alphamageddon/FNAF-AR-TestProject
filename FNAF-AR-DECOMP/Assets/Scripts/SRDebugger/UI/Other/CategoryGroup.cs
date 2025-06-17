using UnityEngine;

namespace SRDebugger.UI.Other
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CategoryGroup : SRMonoBehaviourEx
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.RectTransform Container;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text Header;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject Background;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Toggle SelectionToggle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject[] EnabledDuringSelectionMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _selectionModeEnabled;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsSelected { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool SelectionModeEnabled { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsSelected()
        {
            if(this.SelectionToggle != null)
            {
                    return this.SelectionToggle.isOn;
            }
            
            return this.SelectionToggle.isOn;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_IsSelected(bool value)
        {
            bool val_9;
            var val_10;
            val_9 = value;
            value = val_9;
            this.SelectionToggle.isOn = value;
            if(this.SelectionToggle.graphic == 0)
            {
                    return;
            }
            
            val_10 = 0f;
            if(val_9 != false)
            {
                    var val_2 = (this._selectionModeEnabled == true) ? 1f : 0.2f;
            }
            
            val_9 = ???;
            goto typeof(UnityEngine.UI.Graphic).__il2cppRuntimeField_438;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_SelectionModeEnabled()
        {
            return (bool)this._selectionModeEnabled;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_SelectionModeEnabled(bool value)
        {
            var val_4;
            var val_1 = (this._selectionModeEnabled == true) ? 1 : 0;
            val_1 = val_1 ^ value;
            if(val_1 == false)
            {
                    return;
            }
            
            val_4 = 0;
            this._selectionModeEnabled = value;
            goto label_1;
            label_6:
            this.EnabledDuringSelectionMode[0].SetActive(value:  (this._selectionModeEnabled == true) ? 1 : 0);
            val_4 = 1;
            label_1:
            if(val_4 < this.EnabledDuringSelectionMode.Length)
            {
                goto label_6;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CategoryGroup()
        {
            this.EnabledDuringSelectionMode = new UnityEngine.GameObject[0];
            this._selectionModeEnabled = true;
        }
    
    }

}
