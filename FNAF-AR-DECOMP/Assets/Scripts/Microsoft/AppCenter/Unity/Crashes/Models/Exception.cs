using UnityEngine;

namespace Microsoft.AppCenter.Unity.Crashes.Models
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Exception
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Message>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <StackTrace>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Message { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string StackTrace { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Message()
        {
            return (string)this.<Message>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Message(string value)
        {
            this.<Message>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_StackTrace()
        {
            return (string)this.<StackTrace>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_StackTrace(string value)
        {
            this.<StackTrace>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Exception(string message, string stackTrace)
        {
            val_1 = new System.Object();
            this.<Message>k__BackingField = message;
            this.<StackTrace>k__BackingField = val_1;
        }
    
    }

}
