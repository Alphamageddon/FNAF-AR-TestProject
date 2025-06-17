using UnityEngine;

namespace SRDebugger.UI.Controls
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class OptionsControlBase : SRMonoBehaviourEx
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _selectionModeEnabled;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Toggle SelectionModeToggle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.Internal.OptionDefinition Option;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool SelectionModeEnabled { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsSelected { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_SelectionModeEnabled()
        {
            return (bool)this._selectionModeEnabled;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_SelectionModeEnabled(bool value)
        {
            var val_14;
            var val_15;
            val_14 = this;
            var val_1 = (this._selectionModeEnabled == true) ? 1 : 0;
            val_1 = val_1 ^ value;
            if(val_1 == false)
            {
                    return;
            }
            
            this._selectionModeEnabled = value;
            this.SelectionModeToggle.gameObject.SetActive(value:  (this._selectionModeEnabled == true) ? 1 : 0);
            if(this.SelectionModeToggle.graphic == 0)
            {
                    return;
            }
            
            val_15 = 0f;
            if(this.IsSelected != false)
            {
                    var val_7 = (this._selectionModeEnabled == true) ? 1f : 0.2f;
            }
            
            val_14 = ???;
            goto typeof(UnityEngine.UI.Graphic).__il2cppRuntimeField_438;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsSelected()
        {
            if(this.SelectionModeToggle != null)
            {
                    return this.SelectionModeToggle.isOn;
            }
            
            return this.SelectionModeToggle.isOn;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_IsSelected(bool value)
        {
            bool val_9;
            var val_10;
            val_9 = value;
            value = val_9;
            this.SelectionModeToggle.isOn = value;
            if(this.SelectionModeToggle.graphic == 0)
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
        protected override void Awake()
        {
            this.Awake();
            this.IsSelected = false;
            this.SelectionModeToggle.gameObject.SetActive(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnEnable()
        {
            var val_9;
            var val_10;
            val_9 = this;
            this.OnEnable();
            if(this.SelectionModeToggle.graphic == 0)
            {
                    return;
            }
            
            val_10 = 0f;
            if(this.IsSelected != false)
            {
                    var val_3 = (this._selectionModeEnabled == true) ? 1f : 0.2f;
            }
            
            val_9 = ???;
            goto typeof(UnityEngine.UI.Graphic).__il2cppRuntimeField_438;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void Refresh()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected OptionsControlBase()
        {
        
        }
    
    }

}
