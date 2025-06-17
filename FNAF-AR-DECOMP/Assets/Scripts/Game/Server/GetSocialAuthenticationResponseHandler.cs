using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GetSocialAuthenticationResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<bool, bool, int> _responseReceived;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<bool, bool, int> responseReceived)
        {
            this._responseReceived = responseReceived;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            var val_8;
            var val_9;
            var val_10;
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "FazPassAuthentication");
            if(val_1 == null)
            {
                    return;
            }
            
            System.Nullable<System.Boolean> val_2 = val_1.GetBoolean(key:  "fazPassInEffect");
            if(((-901062004) & 1) != 0)
            {
                    val_8 = val_2.HasValue.GetValueOrDefault();
            }
            else
            {
                    val_8 = 0;
            }
            
            System.Nullable<System.Boolean> val_4 = val_1.GetBoolean(key:  "canContinue");
            if(((-901062004) & 1) != 0)
            {
                    val_9 = val_4.HasValue.GetValueOrDefault();
            }
            else
            {
                    val_9 = 0;
            }
            
            System.Nullable<System.Int32> val_6 = val_1.GetInt(key:  "numInvites");
            if(( & 1) != 0)
            {
                    val_10 = val_6.HasValue.region;
            }
            else
            {
                    val_10 = 0;
            }
            
            if(this._responseReceived == null)
            {
                    return;
            }
            
            this._responseReceived.Invoke(arg1:  val_8 & 1, arg2:  val_9 & 1, arg3:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialAuthenticationResponseHandler()
        {
        
        }
    
    }

}
