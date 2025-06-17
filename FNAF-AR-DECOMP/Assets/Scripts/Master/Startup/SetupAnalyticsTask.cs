using UnityEngine;

namespace Master.Startup
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SetupAnalyticsTask : IStartupTask
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _eventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Analytics.AnalyticsDomain _analyticsDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<System.Action> _teardownCallbacks;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.Startup.SetupAnalyticsTask Setup(System.Collections.Generic.List<System.Action> teardownCallbacks, Master.EventExposer eventExposer, Systems.Analytics.AnalyticsDomain analyticsDomain)
        {
            this._analyticsDomain = analyticsDomain;
            this._teardownCallbacks = teardownCallbacks;
            this._eventExposer = eventExposer;
            return (Master.Startup.SetupAnalyticsTask)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Execute(Master.Startup.StartupSequencer parent)
        {
            this._analyticsDomain.Setup(eventExposer:  this._eventExposer);
            this._teardownCallbacks.Add(item:  new System.Action(object:  this, method:  System.Void Master.Startup.SetupAnalyticsTask::<Execute>b__4_0()));
            parent.CompleteTask(task:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetName()
        {
            return "InitializeAnalyticsTask";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetSize()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetPartialProgress()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SetupAnalyticsTask()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <Execute>b__4_0()
        {
            if(this._analyticsDomain != null)
            {
                    this._analyticsDomain.Teardown();
            }
            
            this._analyticsDomain = 0;
        }
    
    }

}
