using UnityEngine;

namespace SRF.Helpers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PropertyReference
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Reflection.PropertyInfo _property;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly object _target;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PropertyName { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Type PropertyType { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool CanRead { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool CanWrite { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PropertyReference(object target, System.Reflection.PropertyInfo property)
        {
            val_1 = new System.Object();
            SRDebugUtil.AssertNotNull(value:  target, message:  0, instance:  0);
            this._property = val_1;
            this._target = target;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_PropertyName()
        {
            if(this._property == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Type get_PropertyType()
        {
            if(this._property == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_CanRead()
        {
            return System.Reflection.MethodInfo.op_Inequality(left:  this._property.GetGetMethod(), right:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_CanWrite()
        {
            return System.Reflection.MethodInfo.op_Inequality(left:  this._property.GetSetMethod(), right:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public object GetValue()
        {
            if((this._property & 1) == 0)
            {
                    return 0;
            }
            
            return SRF.Helpers.SRReflection.GetPropertyValue(obj:  this._target, p:  this._property);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetValue(object value)
        {
            if((this._property & 1) != 0)
            {
                    SRF.Helpers.SRReflection.SetPropertyValue(obj:  this._target, p:  this._property, value:  value);
                return;
            }
            
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "Can not write to property");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T GetAttribute<T>()
        {
            var val_4;
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48});
            object val_2 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  this._property);
            if(val_2 != null)
            {
                    val_4 = val_2;
                if(val_4 != null)
            {
                    return (SROptions.IncrementAttribute)val_4;
            }
            
            }
            
            val_4 = 0;
            return (SROptions.IncrementAttribute)val_4;
        }
    
    }

}
