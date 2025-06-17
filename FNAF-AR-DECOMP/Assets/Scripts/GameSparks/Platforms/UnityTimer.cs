using UnityEngine;

namespace GameSparks.Platforms
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class UnityTimer : IControlledTimer, IGameSparksTimer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action callback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int interval;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long elapsedTicks;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool running;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameSparks.Platforms.TimerController controller;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetController(GameSparks.Platforms.TimerController controller)
        {
            this.controller = controller;
            controller.AddTimer(timer:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Initialize(int interval, System.Action callback)
        {
            this.callback = callback;
            this.interval = interval;
            this.running = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Trigger()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Stop()
        {
            this.running = false;
            this.callback = 0;
            this.controller.RemoveTimer(timer:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update(long ticks)
        {
            if(this.running == false)
            {
                    return;
            }
            
            long val_1 = this.elapsedTicks;
            int val_2 = this.interval;
            val_1 = val_1 + ticks;
            val_2 = val_1 - val_2;
            this.elapsedTicks = val_1;
            if()
            {
                    return;
            }
            
            this.elapsedTicks = val_2;
            if(this.callback == null)
            {
                    return;
            }
            
            this.callback.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityTimer()
        {
        
        }
    
    }

}
