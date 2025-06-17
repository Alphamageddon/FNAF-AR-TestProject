using UnityEngine;

namespace Microsoft.Applications.Events.DataModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class Net
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <provider>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <cost>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <type>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string provider { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string cost { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string type { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_provider()
        {
            return (string)this.<provider>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_provider(string value)
        {
            this.<provider>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_cost()
        {
            return (string)this.<cost>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_cost(string value)
        {
            this.<cost>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_type()
        {
            return (string)this.<type>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_type(string value)
        {
            this.<type>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Net()
        {
        
        }
    
    }

}
