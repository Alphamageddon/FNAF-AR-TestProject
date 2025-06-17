using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LightningThreadState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Threading.Thread lightningThread;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Threading.AutoResetEvent lightningThreadEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Queue<System.Action> actionsForBackgroundThread;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Queue<System.Collections.Generic.KeyValuePair<System.Action, System.Threading.ManualResetEvent>> actionsForMainThread;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Running;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool isTerminating;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool UpdateMainThreadActionsOnce()
        {
            System.Collections.Generic.Queue<System.Collections.Generic.KeyValuePair<System.Action, System.Threading.ManualResetEvent>> val_6;
            var val_7;
            var val_8;
            var val_9;
            val_6 = this.actionsForMainThread;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  val_6, lockTaken: ref  val_1);
            if(this.actionsForMainThread.Count != 0)
            {
                    System.Collections.Generic.KeyValuePair<System.Action, System.Threading.ManualResetEvent> val_3 = this.actionsForMainThread.Dequeue();
                val_7 = 0;
                val_8 = 58;
            }
            else
            {
                    val_7 = 0;
                val_8 = 94;
            }
            
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_6);
            }
            
            if(94 != 58)
            {
                    if(94 == 94)
            {
                    val_9 = 0;
                return (bool)val_9;
            }
            
            }
            
            val_3.Value.emailUIDataHandler.Invoke();
            val_6 = 1152921528874697872;
            if(val_3.Value != 0)
            {
                    val_6 = ;
                bool val_5 = val_3.Value.Set();
            }
            
            val_9 = 1;
            return (bool)val_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BackgroundThreadMethod()
        {
            var val_6;
            System.Collections.Generic.Queue<System.Action> val_7;
            var val_8;
            val_6 = 0;
            goto label_27;
            label_35:
            if((this.lightningThreadEvent & 1) == 0)
            {
                goto label_27;
            }
            
            label_15:
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this.actionsForBackgroundThread, lockTaken: ref  val_1);
            val_7 = this.actionsForBackgroundThread;
            if(val_7.Count != 0)
            {
                    val_7 = this.actionsForBackgroundThread;
                System.Action val_3 = val_7.Dequeue();
                val_8 = 81;
            }
            else
            {
                    val_8 = 115;
            }
            
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.actionsForBackgroundThread);
            }
            
            var val_4 = (115 == 0) ? 81 : 115;
            if(val_4 == 81)
            {
                goto label_9;
            }
            
            if(val_4 == 115)
            {
                goto label_27;
            }
            
            if(0 != 0)
            {
                goto label_14;
            }
            
            goto label_13;
            label_9:
            if(0 != 0)
            {
                goto label_14;
            }
            
            label_13:
            label_14:
            0.Invoke();
            goto label_15;
            label_27:
            if(this.Running == true)
            {
                goto label_35;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LightningThreadState()
        {
            this.lightningThreadEvent = new System.Threading.AutoResetEvent(initialState:  false);
            this.actionsForBackgroundThread = new System.Collections.Generic.Queue<System.Action>();
            this.actionsForMainThread = new System.Collections.Generic.Queue<System.Collections.Generic.KeyValuePair<System.Action, System.Threading.ManualResetEvent>>();
            this.Running = true;
            System.Threading.Thread val_5 = new System.Threading.Thread(start:  new System.Threading.ThreadStart(object:  this, method:  System.Void DigitalRuby.ThunderAndLightning.LightningThreadState::BackgroundThreadMethod()));
            if(val_5 != null)
            {
                    val_5.IsBackground = true;
            }
            else
            {
                    val_5.IsBackground = true;
            }
            
            val_5.Name = "LightningBoltScriptThread";
            this.lightningThread = val_5;
            val_5.Start();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TerminateAndWaitForEnd()
        {
            this.isTerminating = true;
            do
            {
            
            }
            while(this.UpdateMainThreadActionsOnce() == true);
            
            bool val_2 = false;
            System.Threading.Monitor.Enter(obj:  this.actionsForBackgroundThread, lockTaken: ref  val_2);
            var val_4 = (this.actionsForBackgroundThread.Count == 0) ? 59 : 7;
            if(val_2 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.actionsForBackgroundThread);
            }
            
            var val_5 = (val_4 == 0) ? 7 : (val_4);
            if(val_5 != 7)
            {
                    if(val_5 == 59)
            {
                    return;
            }
            
                if(0 == 0)
            {
                    return;
            }
            
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateMainThreadActions()
        {
            do
            {
            
            }
            while(this.UpdateMainThreadActionsOnce() == true);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool AddActionForMainThread(System.Action action, bool waitForAction = False)
        {
            long val_4;
            long val_5;
            var val_6;
            long val_7;
            val_4 = waitForAction;
            val_5 = action;
            val_6 = 0;
            if(this.isTerminating == true)
            {
                    return (bool)val_6;
            }
            
            if(val_4 != false)
            {
                    System.Threading.ManualResetEvent val_1 = null;
                val_4 = val_1;
                val_1 = new System.Threading.ManualResetEvent(initialState:  false);
            }
            else
            {
                    val_4 = 0;
            }
            
            bool val_2 = false;
            System.Threading.Monitor.Enter(obj:  this.actionsForMainThread, lockTaken: ref  val_2);
            InternalClipper.IntPoint val_3 = new InternalClipper.IntPoint(X:  val_5, Y:  val_4);
            val_7 = val_3.Y;
            this.actionsForMainThread.Enqueue(item:  new System.Collections.Generic.KeyValuePair<System.Action, System.Threading.ManualResetEvent>() {Value = val_3.X});
            val_5 = 0;
            if(val_2 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.actionsForMainThread);
            }
            
            if((70 != 70) && (val_5 != 0))
            {
                    val_7 = 0;
            }
            
            val_6 = 1;
            return (bool)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool AddActionForBackgroundThread(System.Action action)
        {
            System.Action val_3;
            System.Threading.AutoResetEvent val_4;
            var val_5;
            val_3 = action;
            val_4 = this;
            val_5 = 0;
            if(this.isTerminating == true)
            {
                    return (bool)val_5;
            }
            
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this.actionsForBackgroundThread, lockTaken: ref  val_1);
            this.actionsForBackgroundThread.Enqueue(item:  val_3);
            val_3 = 0;
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.actionsForBackgroundThread);
            }
            
            val_4 = this.lightningThreadEvent;
            bool val_2 = val_4.Set();
            val_5 = 1;
            return (bool)val_5;
        }
    
    }

}
