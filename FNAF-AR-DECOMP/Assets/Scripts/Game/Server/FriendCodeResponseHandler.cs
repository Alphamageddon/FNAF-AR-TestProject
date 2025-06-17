using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FriendCodeResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> OnFriendCodeUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.Server.FriendCodeResponseHandler.FriendLookupResponse> OnFriendCodeLookedUp;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string[] FriendLookupServerString;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<string> callbackUpdated, System.Action<Game.Server.FriendCodeResponseHandler.FriendLookupResponse> callbackLookedUp)
        {
            this.OnFriendCodeUpdated = callbackUpdated;
            this.OnFriendCodeLookedUp = callbackLookedUp;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            if((data.ContainsKey(key:  "friendCode")) != false)
            {
                    this.HandleResponseRefresh(friendCode:  data.GetString(key:  "friendCode"));
            }
            
            if((data.ContainsKey(key:  "lookupFriendCodeResponse")) == false)
            {
                    return;
            }
            
            this.HandleResponseLookup(resultString:  data.GetString(key:  "lookupFriendCodeResponse"));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleResponseRefresh(string friendCode)
        {
            this.OnFriendCodeUpdated.Invoke(obj:  friendCode);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleResponseLookup(string resultString)
        {
            FriendLookupResponse val_2;
            var val_3;
            System.String[] val_4;
            var val_5;
            System.Action<FriendLookupResponse> val_6;
            var val_7;
            FriendLookupResponse val_8;
            val_2 = 0;
            goto label_1;
            label_10:
            val_3 = null;
            val_3 = null;
            val_4 = Game.Server.FriendCodeResponseHandler.FriendLookupServerString;
            if((System.String.op_Equality(a:  resultString, b:  Game.Server.FriendCodeResponseHandler.FriendLookupServerString.Length + 32)) == true)
            {
                goto label_6;
            }
            
            val_2 = 1;
            label_1:
            val_5 = null;
            val_5 = null;
            val_4 = Game.Server.FriendCodeResponseHandler.FriendLookupServerString;
            if(val_2 < Game.Server.FriendCodeResponseHandler.FriendLookupServerString.Length)
            {
                goto label_10;
            }
            
            val_6 = this.OnFriendCodeLookedUp;
            val_7 = 1152921523280286656;
            val_8 = 4;
            goto label_12;
            label_6:
            val_6 = this.OnFriendCodeLookedUp;
            val_7 = 1152921523280286656;
            val_8 = val_2;
            label_12:
            val_6.Invoke(obj:  val_8);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FriendCodeResponseHandler()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static FriendCodeResponseHandler()
        {
            string[] val_1 = new string[4];
            val_1[0] = "success";
            val_1[1] = "groupNotFound";
            val_1[2] = "userTriedToFriendSelf";
            val_1[3] = "usersWereAlreadyFriends";
            Game.Server.FriendCodeResponseHandler.FriendLookupServerString = val_1;
        }
    
    }

}
