using UnityEngine;

namespace Microsoft.Applications.Events.DataModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class Loc
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <id>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <country>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <timezone>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string id { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string country { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string timezone { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_id()
        {
            return (string)this.<id>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_id(string value)
        {
            this.<id>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_country()
        {
            return (string)this.<country>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_country(string value)
        {
            this.<country>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_timezone()
        {
            return (string)this.<timezone>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_timezone(string value)
        {
            this.<timezone>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Loc()
        {
        
        }
    
    }

}
