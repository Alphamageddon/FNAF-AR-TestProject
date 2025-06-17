using UnityEngine;

namespace SRDebugger.UI.Controls.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StringControl : DataBoundControl
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.InputField InputField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text Title;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Start()
        {
            this.Start();
            this.Refresh();
            mem[1152921522978258272] = 1;
            this.InputField.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void SRDebugger.UI.Controls.Data.StringControl::OnValueChanged(string newValue)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnValueChanged(string newValue)
        {
            this.UpdateValue(newValue:  newValue);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnBind(string propertyName, System.Type t)
        {
            this.InputField.text = "";
            this.InputField.interactable = (this == 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnValueUpdated(object newValue)
        {
            object val_2 = newValue;
            if(val_2 == null)
            {
                goto label_1;
            }
            
            if(null == null)
            {
                goto label_3;
            }
            
            val_2 = 0;
            goto label_3;
            label_1:
            val_2 = "";
            label_3:
            this.InputField.text = val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool CanBind(System.Type type, bool isReadOnly)
        {
            bool val_2 = System.Type.op_Equality(left:  type, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_2 = val_2 & (~isReadOnly);
            return (bool)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StringControl()
        {
            val_1 = new SRF.SRMonoBehaviourEx();
        }
    
    }

}
