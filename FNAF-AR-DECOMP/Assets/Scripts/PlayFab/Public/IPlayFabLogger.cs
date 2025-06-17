using UnityEngine;

namespace PlayFab.Public
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IPlayFabLogger
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract System.Net.IPAddress ip { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int port { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string url { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract System.Net.IPAddress get_ip(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void set_ip(System.Net.IPAddress value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int get_port(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void set_port(int value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string get_url(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void set_url(string value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnEnable(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnDisable(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnDestroy(); // 0
    
    }

}
