using UnityEngine;

namespace GameSparks.Platforms
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TimerController
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long timeOfLastUpdate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<GameSparks.Platforms.IControlledTimer> timers;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Initialize()
        {
            System.DateTime val_1 = System.DateTime.UtcNow;
            this.timeOfLastUpdate = val_1.dateData.Ticks;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            long val_9;
            System.DateTime val_1 = System.DateTime.UtcNow;
            long val_2 = val_1.dateData.Ticks;
            this.timeOfLastUpdate = val_2;
            val_9 = val_2 - this.timeOfLastUpdate;
            List.Enumerator<T> val_3 = this.timers.GetEnumerator();
            label_10:
            if(((-1702510040) & 1) == 0)
            {
                goto label_4;
            }
            
            var val_8 = 0;
            val_8 = val_8 + 1;
            0.emailUIDataHandler.Update(ticks:  val_9);
            goto label_10;
            label_4:
            long val_6 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921520084206120});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddTimer(GameSparks.Platforms.IControlledTimer timer)
        {
            this.timers.Add(item:  timer);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveTimer(GameSparks.Platforms.IControlledTimer timer)
        {
            bool val_1 = this.timers.Remove(item:  timer);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TimerController()
        {
            this.timers = new System.Collections.Generic.List<GameSparks.Platforms.IControlledTimer>();
        }
    
    }

}
