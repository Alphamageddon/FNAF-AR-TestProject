using UnityEngine;

namespace Game.Server.Errors.ErrorFilters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BaseErrorFilter : IErrorFilter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <ErrorString>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <ClassName>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ErrorString { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ClassName { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_ErrorString()
        {
            return (string)this.<ErrorString>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ErrorString(string value)
        {
            this.<ErrorString>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_ClassName()
        {
            return (string)this.<ClassName>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ClassName(string value)
        {
            this.<ClassName>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Log(Game.Server.Errors.ILoggingProcessor processor, Systems.Server.ServerData data)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return processor.Log(className:  this.<ClassName>k__BackingField, data:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BaseErrorFilter()
        {
        
        }
    
    }

}
