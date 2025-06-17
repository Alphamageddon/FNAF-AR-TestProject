using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class ServerTimeOutDialogHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_ServerTimeOutReceived()
        {
            var val_3;
            System.Action val_5;
            val_3 = null;
            val_3 = null;
            val_5 = ServerTimeOutDialogHandler.<>c.<>9__1_0;
            if(val_5 == null)
            {
                    System.Action val_1 = null;
                val_5 = val_1;
                val_1 = new System.Action(object:  ServerTimeOutDialogHandler.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ServerTimeOutDialogHandler.<>c::<EventExposer_ServerTimeOutReceived>b__1_0());
                ServerTimeOutDialogHandler.<>c.<>9__1_0 = val_5;
            }
            
            GameUI.GenericDialogData val_2 = new GameUI.GenericDialogData();
            if(val_2 != null)
            {
                    .title = "SERVER TIME OUT";
                .message = "UNABLE TO CONNECT WITH SERVER";
                .positiveButtonText = "OK";
            }
            else
            {
                    mem[16] = "SERVER TIME OUT";
                mem[24] = "UNABLE TO CONNECT WITH SERVER";
                mem[32] = "OK";
            }
            
            .positiveButtonAction = val_5;
            this._masterDomain.eventExposer.GenericDialogRequest(genericDialogData:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ServerTimeOutDialogHandler(Master.MasterDomain masterDomain)
        {
            this._masterDomain = masterDomain;
        }
    
    }

}
