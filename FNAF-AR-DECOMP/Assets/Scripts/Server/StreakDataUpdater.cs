using UnityEngine;

namespace Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StreakDataUpdater
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer masterEvents;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update(Systems.Server.ServerData data)
        {
            Master.EventExposer val_7;
            int val_8;
            int val_9;
            val_7 = this;
            val_8 = data.GetServerData(key:  "StreakData");
            if(val_8 == null)
            {
                    return;
            }
            
            System.Nullable<System.Int32> val_2 = val_8.GetInt(key:  "CurrentStreak");
            if((1413613608 & 1) != 0)
            {
                    val_9 = val_2.HasValue.region;
            }
            else
            {
                    val_9 = 0;
            }
            
            System.Nullable<System.Int32> val_4 = val_8.GetInt(key:  "BestStreak");
            if((1413613608 & 1) != 0)
            {
                    val_8 = val_4.HasValue.region;
            }
            else
            {
                    val_8 = 0;
            }
            
            val_7 = this.masterEvents;
            TheGame.Data.StreakData val_6 = new TheGame.Data.StreakData();
            if(val_6 != null)
            {
                    .currentStreak = val_9;
            }
            else
            {
                    mem[16] = val_9;
            }
            
            .bestStreak = val_8;
            val_7.OnStreakDataUpdated(data:  val_6);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.EventExposer eventExposer)
        {
            this.masterEvents = eventExposer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StreakDataUpdater()
        {
        
        }
    
    }

}
