using UnityEngine;

namespace SRDebugger.UI.Controls
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class DataBoundControl : OptionsControlBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _hasStarted;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isReadOnly;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private object _prevValue;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRF.Helpers.PropertyReference _prop;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <PropertyName>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.Helpers.PropertyReference Property { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsReadOnly { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PropertyName { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.Helpers.PropertyReference get_Property()
        {
            return (SRF.Helpers.PropertyReference)this._prop;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsReadOnly()
        {
            return (bool)this._isReadOnly;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_PropertyName()
        {
            return (string)this.<PropertyName>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_PropertyName(string value)
        {
            this.<PropertyName>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Bind(string propertyName, SRF.Helpers.PropertyReference prop)
        {
            this._prop = prop;
            this.<PropertyName>k__BackingField = propertyName;
            if(prop != null)
            {
                    bool val_3 = ~prop.CanWrite;
                val_3 = val_3 & 1;
                this._isReadOnly = val_3;
            }
            else
            {
                    bool val_4 = ~0.CanWrite;
                val_4 = val_4 & 1;
                this._isReadOnly = val_4;
            }
            
            if(prop._property == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void UpdateValue(object newValue)
        {
            if(this._prevValue == newValue)
            {
                    return;
            }
            
            if(this._isReadOnly == true)
            {
                    return;
            }
            
            this._prop.SetValue(value:  newValue);
            this._prevValue = newValue;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Refresh()
        {
            if(this._prop == null)
            {
                    return;
            }
            
            this._prevValue = this._prop.GetValue();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void OnBind(string propertyName, System.Type t)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected abstract void OnValueUpdated(object newValue); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool CanBind(System.Type type, bool isReadOnly); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Start()
        {
            this.Start();
            this._hasStarted = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnEnable()
        {
            this.OnEnable();
            if(this._hasStarted == false)
            {
                    return;
            }
            
            goto typeof(SRDebugger.UI.Controls.DataBoundControl).__il2cppRuntimeField_1D8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected DataBoundControl()
        {
            val_1 = new SRF.SRMonoBehaviourEx();
        }
    
    }

}
