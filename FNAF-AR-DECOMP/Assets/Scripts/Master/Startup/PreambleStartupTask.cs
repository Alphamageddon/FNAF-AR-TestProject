using UnityEngine;

namespace Master.Startup
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PreambleStartupTask : IStartupTask
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float DELAY_TIME = 1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.Startup.StartupSequencer _parent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEvents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.CanvasFlow.GameProject_Alpine_CanvasController_Preamble _preambleController;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _screenReady;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _taskReady;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _delayTime;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.Startup.PreambleStartupTask Setup(Master.EventExposer masterEvents)
        {
            this._masterEvents = masterEvents;
            masterEvents.add_PreloadEvent(value:  new System.Action<P7.CanvasFlow.CanvasController, System.String>(object:  this, method:  System.Void Master.Startup.PreambleStartupTask::OnPreloadEvent(P7.CanvasFlow.CanvasController controller, string eventName)));
            return (Master.Startup.PreambleStartupTask)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Execute(Master.Startup.StartupSequencer parent)
        {
            this._parent = parent;
            this._taskReady = true;
            this.TryStartPreambleTask();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._masterEvents.remove_PreloadEvent(value:  new System.Action<P7.CanvasFlow.CanvasController, System.String>(object:  this, method:  System.Void Master.Startup.PreambleStartupTask::OnPreloadEvent(P7.CanvasFlow.CanvasController controller, string eventName)));
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
            return "Preamble";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetPartialProgress()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnPreloadEvent(P7.CanvasFlow.CanvasController controller, string eventName)
        {
            P7.CanvasFlow.CanvasController val_5 = controller;
            if(val_5 == null)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  eventName, b:  "start")) != false)
            {
                    val_5 = 0;
                this._preambleController = val_5;
                this._screenReady = true;
                this.TryStartPreambleTask();
                return;
            }
            
            if((System.String.op_Equality(a:  eventName, b:  "complete")) == false)
            {
                    return;
            }
            
            this._preambleController.PerformTransitionWithIdentifier(identifier:  "Dismiss");
            this.StartTimer();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TryStartPreambleTask()
        {
            if(this._taskReady == false)
            {
                    return;
            }
            
            if(this._screenReady == false)
            {
                    return;
            }
            
            this._preambleController.StartAnimation();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StartTimer()
        {
            this._delayTime = 1f;
            this._parent.add_UpdateTime(value:  new System.Action<System.Single>(object:  this, method:  System.Void Master.Startup.PreambleStartupTask::OnTick(float dt)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnTick(float dt)
        {
            float val_2 = this._delayTime;
            val_2 = val_2 - dt;
            this._delayTime = val_2;
            if(val_2 >= 0)
            {
                    return;
            }
            
            this._parent.remove_UpdateTime(value:  new System.Action<System.Single>(object:  this, method:  System.Void Master.Startup.PreambleStartupTask::OnTick(float dt)));
            this.OnTimerComplete();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnTimerComplete()
        {
            this._parent.CompleteTask(task:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PreambleStartupTask()
        {
        
        }
    
    }

}
