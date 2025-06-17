using UnityEngine;

namespace SRDebugger.UI.Controls.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BoolControl : DataBoundControl
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text Title;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Toggle Toggle;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Start()
        {
            this.Start();
            this.Refresh();
            mem[1152921522973586672] = 1;
            this.Toggle.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void SRDebugger.UI.Controls.Data.BoolControl::ToggleOnValueChanged(bool isOn)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ToggleOnValueChanged(bool isOn)
        {
            this.UpdateValue(newValue:  isOn);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnBind(string propertyName, System.Type t)
        {
            this.Toggle.interactable = (this == 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnValueUpdated(object newValue)
        {
            this.Toggle.isOn = (null != 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool CanBind(System.Type type, bool isReadOnly)
        {
            return System.Type.op_Equality(left:  type, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BoolControl()
        {
            val_1 = new SRF.SRMonoBehaviourEx();
        }
    
    }

}
