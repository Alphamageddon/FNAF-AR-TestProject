using UnityEngine;

namespace Master.Startup
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SpawnScreenSleepDelayerTask : IStartupTask
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.Domain _theGameDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEvents;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.Startup.SpawnScreenSleepDelayerTask Setup(Master.EventExposer masterEvents, TheGame.Domain theGameDomain)
        {
            this._theGameDomain = theGameDomain;
            this._masterEvents = masterEvents;
            return (Master.Startup.SpawnScreenSleepDelayerTask)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Execute(Master.Startup.StartupSequencer parent)
        {
            Game.Utilities.ScreenSleepDelayer val_1 = new Game.Utilities.ScreenSleepDelayer();
            val_1.Setup(masterEvents:  this._masterEvents);
            this._theGameDomain.InjectScreenSleepDelayer(screenSleepDelayer:  val_1);
            parent.CompleteTask(task:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetSize()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetName()
        {
            return "SpawnScreenSleepDelayer";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetPartialProgress()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._theGameDomain = 0;
            this._masterEvents = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SpawnScreenSleepDelayerTask()
        {
        
        }
    
    }

}
