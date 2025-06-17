using UnityEngine;

namespace SRDebugger.UI.Controls.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ActionControl : OptionsControlBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRF.Helpers.MethodReference _method;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Button Button;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text Title;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.Helpers.MethodReference Method { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.Helpers.MethodReference get_Method()
        {
            return (SRF.Helpers.MethodReference)this._method;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Start()
        {
            this.Start();
            this.Button.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SRDebugger.UI.Controls.Data.ActionControl::ButtonOnClick()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ButtonOnClick()
        {
            if(this._method != null)
            {
                    object val_1 = this._method.Invoke(parameters:  0);
                return;
            }
            
            UnityEngine.Debug.LogWarning(message:  "[SRDebugger.Options] No method set for action control", context:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetMethod(string methodName, SRF.Helpers.MethodReference method)
        {
            this._method = method;
            if(this.Title == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ActionControl()
        {
            val_1 = new SRF.SRMonoBehaviourEx();
        }
    
    }

}
