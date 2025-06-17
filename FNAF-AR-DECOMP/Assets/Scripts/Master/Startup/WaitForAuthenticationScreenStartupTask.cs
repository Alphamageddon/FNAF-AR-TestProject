using UnityEngine;

namespace Master.Startup
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class WaitForAuthenticationScreenStartupTask : IStartupTask
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.Startup.StartupSequencer _parent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEvents;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.Startup.WaitForAuthenticationScreenStartupTask Setup(Master.EventExposer masterEvents)
        {
            this._masterEvents = masterEvents;
            masterEvents.add_PreloadEvent(value:  new System.Action<P7.CanvasFlow.CanvasController, System.String>(object:  this, method:  System.Void Master.Startup.WaitForAuthenticationScreenStartupTask::OnPreloadEvent(P7.CanvasFlow.CanvasController controller, string eventName)));
            return (Master.Startup.WaitForAuthenticationScreenStartupTask)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnPreloadEvent(P7.CanvasFlow.CanvasController controller, string eventName)
        {
            var val_2;
            var val_3;
            val_2 = controller;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = "start";
            val_3 = "start";
            if("start" == null)
            {
                    val_3 = "start";
            }
            
            if((Equals(value:  eventName)) == false)
            {
                    return;
            }
            
            this._parent.CompleteTask(task:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Execute(Master.Startup.StartupSequencer parent)
        {
            this._parent = parent;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._masterEvents.remove_PreloadEvent(value:  new System.Action<P7.CanvasFlow.CanvasController, System.String>(object:  this, method:  System.Void Master.Startup.WaitForAuthenticationScreenStartupTask::OnPreloadEvent(P7.CanvasFlow.CanvasController controller, string eventName)));
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
            return "WaitForAuthenticateScreen";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetPartialProgress()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WaitForAuthenticationScreenStartupTask()
        {
        
        }
    
    }

}
