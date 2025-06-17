using UnityEngine;

namespace Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayerProfile
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string userId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string userName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string displayName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string avatarId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayerProfile()
        {
        
        }
    
    }

}
