using UnityEngine;

namespace Microsoft.Applications.Events.DataModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class Sdk
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <libVer>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <epoch>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long <seq>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <installId>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string libVer { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string epoch { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long seq { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string installId { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_libVer()
        {
            return (string)this.<libVer>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_libVer(string value)
        {
            this.<libVer>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_epoch()
        {
            return (string)this.<epoch>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_epoch(string value)
        {
            this.<epoch>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long get_seq()
        {
            return (long)this.<seq>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_seq(long value)
        {
            this.<seq>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_installId()
        {
            return (string)this.<installId>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_installId(string value)
        {
            this.<installId>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Sdk()
        {
        
        }
    
    }

}
