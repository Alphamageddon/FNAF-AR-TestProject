using UnityEngine;

namespace SRDebugger.UI.Controls.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ReadOnlyControl : DataBoundControl
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text ValueText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text Title;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Start()
        {
            this.Start();
            this.Refresh();
            mem[1152921522977619424] = 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnBind(string propertyName, System.Type t)
        {
            if(this.Title == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnValueUpdated(object newValue)
        {
            string val_1 = System.Convert.ToString(value:  newValue);
            if(this.ValueText == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool CanBind(System.Type type, bool isReadOnly)
        {
            bool val_2 = System.Type.op_Equality(left:  type, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_2 = val_2 & isReadOnly;
            return (bool)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ReadOnlyControl()
        {
            val_1 = new SRF.SRMonoBehaviourEx();
        }
    
    }

}
