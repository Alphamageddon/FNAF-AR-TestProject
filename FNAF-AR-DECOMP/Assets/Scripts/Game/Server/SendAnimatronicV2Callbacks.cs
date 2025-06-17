using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SendAnimatronicV2Callbacks
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly System.Action<Game.Server.SendAnimatronicV2ResponseData> successCallback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly System.Action<string> errorCallback;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SendAnimatronicV2Callbacks(System.Action<Game.Server.SendAnimatronicV2ResponseData> success, System.Action<string> error)
        {
            string val_5;
            var val_1 = (success == 0) ? 0 : (this);
            if(success == null)
            {
                goto label_1;
            }
            
            mem2[0] = success;
            var val_2 = (error == 0) ? 0 : (this);
            if(error == null)
            {
                goto label_3;
            }
            
            mem2[0] = error;
            return;
            label_1:
            val_5 = "SendAnimatronicV2Callbacks - Invalid successCallback Sent";
            goto label_5;
            label_3:
            val_5 = "SendAnimatronicV2Callbacks - Invalid errorCallback Sent";
            label_5:
            null = new System.Exception(message:  val_5);
        }
    
    }

}
