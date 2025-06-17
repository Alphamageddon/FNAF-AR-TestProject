using UnityEngine;

namespace PlayFab
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class PlayFabAuthenticationContext
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ClientSessionTicket;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PlayFabId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string EntityToken;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string EntityId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string EntityType;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFabAuthenticationContext()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFabAuthenticationContext(string clientSessionTicket, string entityToken, string playFabId, string entityId, string entityType)
        {
            val_1 = new System.Object();
            this.ClientSessionTicket = clientSessionTicket;
            this.PlayFabId = playFabId;
            this.EntityToken = val_1;
            this.EntityId = entityId;
            this.EntityType = entityType;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CopyFrom(PlayFab.PlayFabAuthenticationContext other)
        {
            if(other != null)
            {
                    this.ClientSessionTicket = other.ClientSessionTicket;
                this.PlayFabId = other.PlayFabId;
                this.EntityToken = other.EntityToken;
                this.EntityId = other.EntityId;
            }
            else
            {
                    this.ClientSessionTicket = 11993091;
                this.PlayFabId = 15026800;
                this.EntityToken = 64;
                this.EntityId = 69077560;
            }
            
            this.EntityType = other.EntityType;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsClientLoggedIn()
        {
            bool val_1 = System.String.IsNullOrEmpty(value:  this.ClientSessionTicket);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsEntityLoggedIn()
        {
            bool val_1 = System.String.IsNullOrEmpty(value:  this.EntityToken);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ForgetAllCredentials()
        {
            this.EntityType = 0;
            this.ClientSessionTicket = 0;
            this.EntityToken = 0;
        }
    
    }

}
