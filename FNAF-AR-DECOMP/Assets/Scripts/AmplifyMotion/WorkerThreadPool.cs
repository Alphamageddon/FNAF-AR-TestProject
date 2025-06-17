using UnityEngine;

namespace AmplifyMotion
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class WorkerThreadPool
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int ThreadStateQueueCapacity = 1024;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal System.Collections.Generic.Queue<AmplifyMotion.MotionState>[] m_threadStateQueues;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal object[] m_threadStateQueueLocks;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int m_threadPoolSize;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Threading.ManualResetEvent m_threadPoolTerminateSignal;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Threading.AutoResetEvent[] m_threadPoolContinueSignals;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Threading.Thread[] m_threadPool;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool m_threadPoolFallback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal object m_threadPoolLock;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int m_threadPoolIndex;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void InitializeAsyncUpdateThreads(int threadCount, bool systemThreadPool)
        {
            bool val_14 = systemThreadPool;
            if(val_14 != true)
            {
                    this.m_threadPoolSize = threadCount;
                this.m_threadStateQueues = new System.Collections.Generic.Queue<AmplifyMotion.MotionState>[0];
                this.m_threadStateQueueLocks = new object[0];
                this.m_threadPool = new System.Threading.Thread[0];
                new System.Threading.ManualResetEvent() = new System.Threading.ManualResetEvent(initialState:  false);
                this.m_threadPoolTerminateSignal = new System.Threading.ManualResetEvent();
                this.m_threadPoolContinueSignals = new System.Threading.AutoResetEvent[0];
                new System.Object() = new System.Object();
                this.m_threadPoolLock = new System.Object();
                this.m_threadPoolIndex = 0;
                if(this.m_threadPoolSize < 1)
            {
                    return;
            }
            
                var val_13 = 0;
                do
            {
                System.Collections.Generic.Queue<AmplifyMotion.MotionState> val_7 = new System.Collections.Generic.Queue<AmplifyMotion.MotionState>(capacity:  1024);
                this.m_threadStateQueues[0] = null;
                new System.Object() = new System.Object();
                this.m_threadStateQueueLocks[0] = new System.Object();
                new System.Threading.AutoResetEvent() = new System.Threading.AutoResetEvent(initialState:  false);
                this.m_threadPoolContinueSignals[0] = new System.Threading.AutoResetEvent();
                new System.Threading.ParameterizedThreadStart() = new System.Threading.ParameterizedThreadStart(object:  0, method:  static System.Void AmplifyMotion.WorkerThreadPool::AsyncUpdateThread(object obj));
                new System.Threading.Thread() = new System.Threading.Thread(start:  new System.Threading.ParameterizedThreadStart());
                this.m_threadPool[0] = new System.Threading.Thread();
                val_14 = this.m_threadPool[0];
                val_14.Start(parameter:  0);
                val_13 = val_13 + 1;
            }
            while(val_13 < this.m_threadPoolSize);
            
                return;
            }
            
            this.m_threadPoolFallback = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void FinalizeAsyncUpdateThreads()
        {
            var val_8;
            if(this.m_threadPoolFallback == true)
            {
                    return;
            }
            
            bool val_1 = this.m_threadPoolTerminateSignal.Set();
            if(this.m_threadPoolSize <= 0)
            {
                goto label_3;
            }
            
            var val_14 = 0;
            val_8 = 0;
            label_40:
            if(this.m_threadPool[0].IsAlive != false)
            {
                    bool val_3 = this.m_threadPoolContinueSignals[0].Set();
                this.m_threadPool[0].Join();
                this.m_threadPool[0] = 0;
            }
            
            object val_11 = this.m_threadStateQueueLocks[0];
            bool val_4 = false;
            System.Threading.Monitor.Enter(obj:  val_11, lockTaken: ref  val_4);
            label_26:
            if(this.m_threadStateQueues[0].Count < 1)
            {
                goto label_27;
            }
            
            if(this.m_threadStateQueues[0].Dequeue() != null)
            {
                goto label_26;
            }
            
            goto label_26;
            label_27:
            if(val_4 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_11);
            }
            
            if(((145 == 0) ? 145 : 145) == 145)
            {
                
            }
            
            val_14 = val_14 + 1;
            if(val_14 < this.m_threadPoolSize)
            {
                goto label_40;
            }
            
            label_3:
            this.m_threadStateQueues = 0;
            this.m_threadStateQueueLocks = 0;
            this.m_threadPoolSize = 0;
            this.m_threadPoolContinueSignals = 0;
            this.m_threadPool = 0;
            this.m_threadPoolTerminateSignal = 0;
            this.m_threadPoolLock = 0;
            this.m_threadPoolIndex = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void EnqueueAsyncUpdate(AmplifyMotion.MotionState state)
        {
            object val_7;
            System.Threading.WaitCallback val_8;
            val_7 = state;
            val_8 = this;
            if(this.m_threadPoolFallback != false)
            {
                    System.Threading.WaitCallback val_1 = null;
                val_8 = val_1;
                val_1 = new System.Threading.WaitCallback(object:  0, method:  static System.Void AmplifyMotion.WorkerThreadPool::AsyncUpdateCallback(object obj));
                bool val_2 = System.Threading.ThreadPool.QueueUserWorkItem(callBack:  val_1, state:  val_7);
                return;
            }
            
            object val_7 = this.m_threadStateQueueLocks[this.m_threadPoolIndex];
            bool val_3 = false;
            System.Threading.Monitor.Enter(obj:  val_7, lockTaken: ref  val_3);
            this.m_threadStateQueues[this.m_threadPoolIndex].Enqueue(item:  val_7);
            if(val_3 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_7);
            }
            
            val_7 = this.m_threadPoolIndex;
            bool val_4 = this.m_threadPoolContinueSignals[val_7].Set();
            this.m_threadPoolIndex = ((this.m_threadPoolIndex + 1) >= this.m_threadPoolSize) ? 0 : (this.m_threadPoolIndex + 1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void AsyncUpdateCallback(object obj)
        {
            var val_4;
            var val_5;
            val_4 = obj;
            if(val_4 == null)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = 0;
            val_4 = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void AsyncUpdateThread(object obj)
        {
            var val_12;
            var val_13;
            System.Type val_14;
            var val_17;
            val_12 = 0;
            val_13 = System.IConvertible.ToInt64(provider:  public System.Object System.Collections.Generic.KeyValuePair<System.Object, System.Int32>::get_Key());
            if(val_13 != 0)
            {
                    val_12 = 0;
                val_13 = 0;
            }
            
            val_14 = public System.Int32 System.Collections.Generic.KeyValuePair<System.Object, System.Int32>::get_Value();
            goto label_51;
            label_59:
            var val_5 = 15026800 + (-13096135040);
            bool val_6 = false;
            val_12 = 0;
            System.Threading.Monitor.Enter(obj:  (15026800 + -13096135040) + 32, lockTaken: ref  val_6);
            if((-1637016880) >= mem[4306960411])
            {
                    val_12 = 0;
            }
            
            var val_7 = 11993091 + (-13096135040);
            val_14 = public System.Int32 System.Collections.Generic.Queue<AmplifyMotion.MotionState>::get_Count();
            if(((11993091 + -13096135040) + 32.Count) >= 1)
            {
                    if((-1637016880) >= mem[4306960411])
            {
                    val_12 = 0;
            }
            
                var val_9 = 11993091 + (-13096135040);
                val_14 = public AmplifyMotion.MotionState System.Collections.Generic.Queue<AmplifyMotion.MotionState>::Dequeue();
                val_17 = (11993091 + -13096135040) + 32.Dequeue();
            }
            else
            {
                    val_17 = 0;
            }
            
            if(val_6 != 0)
            {
                    val_14 = 0;
                System.Threading.Monitor.Exit(obj:  (15026800 + -13096135040) + 32);
            }
            
            if(((127 == 0) ? 127 : 127) != 127)
            {
                goto label_29;
            }
            
            if(val_17 != 0)
            {
                goto label_59;
            }
            
            goto label_51;
            label_29:
            if(0 != 0)
            {
                    val_14 = 0;
                val_12 = 0;
            }
            
            if(val_17 != 0)
            {
                goto label_59;
            }
            
            label_51:
            if((-1637016880) >= mem[15762873573703704])
            {
                    val_14 = 0;
                val_12 = 0;
            }
            
            var val_15 = 0 + (-13096135040);
            if((69077560 & 1) == 0)
            {
                goto label_59;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WorkerThreadPool()
        {
        
        }
    
    }

}
