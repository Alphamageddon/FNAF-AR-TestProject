using UnityEngine;

namespace Microsoft.Applications.Events.DataModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class Ingest
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long <time>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <clientIp>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long <auth>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long <quality>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long <uploadTime>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <userAgent>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <client>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long time { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string clientIp { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long auth { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long quality { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long uploadTime { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string userAgent { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string client { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long get_time()
        {
            return (long)this.<time>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_time(long value)
        {
            this.<time>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_clientIp()
        {
            return (string)this.<clientIp>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_clientIp(string value)
        {
            this.<clientIp>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long get_auth()
        {
            return (long)this.<auth>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_auth(long value)
        {
            this.<auth>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long get_quality()
        {
            return (long)this.<quality>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_quality(long value)
        {
            this.<quality>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long get_uploadTime()
        {
            return (long)this.<uploadTime>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_uploadTime(long value)
        {
            this.<uploadTime>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_userAgent()
        {
            return (string)this.<userAgent>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_userAgent(string value)
        {
            this.<userAgent>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_client()
        {
            return (string)this.<client>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_client(string value)
        {
            this.<client>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Ingest()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Ingest(string fullName, string name)
        {
            val_1 = new System.Object();
            this.<clientIp>k__BackingField = "";
        }
    
    }

}
