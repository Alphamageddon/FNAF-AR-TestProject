using UnityEngine;

namespace Microsoft.Applications.Events.DataModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class User
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <id>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <localId>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <authId>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <locale>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string id { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string localId { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string authId { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string locale { get; set; }
        
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
        public string get_localId()
        {
            return (string)this.<localId>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_localId(string value)
        {
            this.<localId>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_authId()
        {
            return (string)this.<authId>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_authId(string value)
        {
            this.<authId>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_locale()
        {
            return (string)this.<locale>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_locale(string value)
        {
            this.<locale>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public User()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected User(string fullName, string name)
        {
            val_1 = new System.Object();
        }
    
    }

}
