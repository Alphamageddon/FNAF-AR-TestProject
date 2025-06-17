using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StreakDataResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<TheGame.Data.StreakData> StreakUpdated;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.EventExposer eventExposer)
        {
            this.StreakUpdated = new System.Action<TheGame.Data.StreakData>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnStreakDataUpdated(TheGame.Data.StreakData data));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "StreakData");
            if(val_1 == null)
            {
                    return;
            }
            
            this.HandleResponse(data:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleResponse(Systems.Server.ServerData data)
        {
            int val_6;
            int val_7;
            System.Nullable<System.Int32> val_1 = data.GetInt(key:  "CurrentStreak");
            if(((-890036808) & 1) == 0)
            {
                goto label_2;
            }
            
            val_6 = val_1.HasValue.region;
            if(data != null)
            {
                goto label_5;
            }
            
            goto label_4;
            label_2:
            val_6 = 0;
            if(data != null)
            {
                goto label_5;
            }
            
            label_4:
            label_5:
            System.Nullable<System.Int32> val_3 = data.GetInt(key:  "BestStreak");
            if(((-890036808) & 1) != 0)
            {
                    val_7 = val_3.HasValue.region;
            }
            else
            {
                    val_7 = 0;
            }
            
            TheGame.Data.StreakData val_5 = new TheGame.Data.StreakData();
            if(val_5 != null)
            {
                    .currentStreak = val_6;
            }
            else
            {
                    mem[16] = val_6;
            }
            
            .bestStreak = val_7;
            this.StreakUpdated.Invoke(obj:  val_5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StreakDataResponseHandler()
        {
        
        }
    
    }

}
