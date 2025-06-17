using UnityEngine;

namespace Master.Startup
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StartupSequencer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.Startup.IStartupTask _currentTask;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Queue<Master.Startup.IStartupTask> _tasks;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action _completeCallback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> _taskCompleteCallback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEvents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _maxTasks;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _taskProgress;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<float> UpdateTime;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_UpdateTime(System.Action<float> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.UpdateTime, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.UpdateTime != 1152921523315388304);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_UpdateTime(System.Action<float> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.UpdateTime, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.UpdateTime != 1152921523315524880);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.EventExposer masterEvents)
        {
            this._masterEvents = masterEvents;
            this._tasks = new System.Collections.Generic.Queue<Master.Startup.IStartupTask>();
            this._maxTasks = 0;
            this._taskProgress = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetProgressCount()
        {
            var val_6;
            var val_7;
            var val_8;
            if(this._currentTask == null)
            {
                goto label_1;
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            goto label_5;
            label_1:
            val_6 = 0;
            goto label_6;
            label_5:
            int val_2 = this._currentTask.GetPartialProgress();
            val_6 = 0;
            label_6:
            if((1529062608 & 1) != 0)
            {
                    UnityEngine.XR.ARCore.ARCoreFaceRegion val_4 = val_6.region + this._taskProgress;
                val_7 = 0;
            }
            else
            {
                    val_7 = 0;
            }
            
            if((1529062616 & 1) != 0)
            {
                    UnityEngine.XR.ARCore.ARCoreFaceRegion val_5 = val_7.region;
                return (int)val_8;
            }
            
            val_8 = 0;
            return (int)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetTotalCount()
        {
            return (int)this._maxTasks;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._masterEvents = 0;
            if(this._tasks != null)
            {
                    this._tasks.Clear();
            }
            
            this._tasks = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddTask(Master.Startup.IStartupTask task)
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            this._maxTasks = task.GetSize() + this._maxTasks;
            this._tasks.Enqueue(item:  task);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CompleteTask(Master.Startup.IStartupTask task)
        {
            string val_8;
            var val_9;
            var val_10;
            var val_12;
            var val_13;
            var val_14;
            val_8 = task;
            val_9 = this;
            if(this._currentTask == val_8)
            {
                goto label_1;
            }
            
            if(this._currentTask == null)
            {
                goto label_23;
            }
            
            var val_9 = 0;
            val_10 = 1152921505164816392;
            val_9 = val_9 + 1;
            val_10 = 1152921505164816408;
            goto label_6;
            label_1:
            val_13 = null;
            var val_10 = 0;
            val_10 = 1152921505164816392;
            val_10 = val_10 + 1;
            goto label_11;
            label_6:
            label_23:
            val_8 = "Task is completing out of order: "("Task is completing out of order: ") + 3 + " is completing instead of " + this._currentTask.GetName();
            System.Exception val_4 = null;
            val_9 = val_4;
            val_4 = new System.Exception(message:  val_8);
            val_12 = 1152921523316270464;
            val_13 = 0;
            val_10 = val_10 + 2;
            val_12 = val_12 + val_10;
            val_14 = val_12 + 296;
            label_11:
            mem[1152921523316348140] = val_8.GetSize() + W22;
            var val_11 = 0;
            val_11 = val_11 + 1;
            (System.Exception)[1152921523316348080]._innerException.Invoke(obj:  val_8);
            var val_12 = 0;
            val_12 = val_12 + 1;
            ._className = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Execute(System.Action completeCallback, System.Action<string> taskCompleteCallback)
        {
            this._completeCallback = completeCallback;
            this._taskCompleteCallback = taskCompleteCallback;
            if(this._tasks.Count != 0)
            {
                    this.ProcessNextTask();
                return;
            }
            
            System.Exception val_2 = new System.Exception(message:  "Attempting to start startup sequencer with no tasks added");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            if(this.UpdateTime != null)
            {
                    this.UpdateTime.Invoke(obj:  UnityEngine.Time.deltaTime);
            }
            
            if(this._tasks.Count != 0)
            {
                    if(this._currentTask != null)
            {
                    return;
            }
            
                this.ProcessNextTask();
                return;
            }
            
            if(this._completeCallback == null)
            {
                    return;
            }
            
            this._completeCallback.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessNextTask()
        {
            Master.Startup.IStartupTask val_1 = this._tasks.Dequeue();
            this._currentTask = val_1;
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_1.Execute(parent:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CompleteStartup()
        {
            if(this._completeCallback == null)
            {
                    return;
            }
            
            this._completeCallback.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StartupSequencer()
        {
        
        }
    
    }

}
