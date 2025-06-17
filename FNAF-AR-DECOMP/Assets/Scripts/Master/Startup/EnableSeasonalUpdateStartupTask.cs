using UnityEngine;

namespace Master.Startup
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EnableSeasonalUpdateStartupTask : IStartupTask
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.Startup.StartupSequencer _parent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEvents;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.Startup.EnableSeasonalUpdateStartupTask Setup(Master.EventExposer masterEvents)
        {
            this._masterEvents = masterEvents;
            return (Master.Startup.EnableSeasonalUpdateStartupTask)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Execute(Master.Startup.StartupSequencer parent)
        {
            this._parent = parent;
            this._masterEvents.OnShouldStartCheckingSeasonalUpdate();
            this._parent.CompleteTask(task:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._parent = 0;
            this._masterEvents = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetSize()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetName()
        {
            return "EnableSeasonalUpdate";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetPartialProgress()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EnableSeasonalUpdateStartupTask()
        {
        
        }
    
    }

}
