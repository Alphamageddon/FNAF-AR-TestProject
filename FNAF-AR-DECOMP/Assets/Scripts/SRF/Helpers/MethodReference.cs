using UnityEngine;

namespace SRF.Helpers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MethodReference
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Reflection.MethodInfo _method;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private object _target;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string MethodName { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MethodReference(object target, System.Reflection.MethodInfo method)
        {
            SRDebugUtil.AssertNotNull(value:  target, message:  0, instance:  0);
            this._method = method;
            this._target = target;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_MethodName()
        {
            if(this._method == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public object Invoke(object[] parameters)
        {
            if(this._method != null)
            {
                    return this._method.Invoke(obj:  this._target, parameters:  parameters);
            }
            
            return this._method.Invoke(obj:  this._target, parameters:  parameters);
        }
    
    }

}
