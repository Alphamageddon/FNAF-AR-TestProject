using UnityEngine;

namespace PlayFab.Public
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class PlayFabLoggerBase : IPlayFabLogger
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly System.Text.StringBuilder Sb;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Queue<string> LogMessageQueue;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int LOG_CACHE_INTERVAL_MS = 10000;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Threading.Thread _writeLogThread;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly object _threadLock;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly System.TimeSpan _threadKillTimeout;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.DateTime _threadKillTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isApplicationPlaying;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _pendingLogsCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Net.IPAddress <ip>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <port>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <url>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Net.IPAddress ip { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int port { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string url { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Net.IPAddress get_ip()
        {
            return (System.Net.IPAddress)this.<ip>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ip(System.Net.IPAddress value)
        {
            this.<ip>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_port()
        {
            return (int)this.<port>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_port(int value)
        {
            this.<port>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_url()
        {
            return (string)this.<url>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_url(string value)
        {
            this.<url>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected PlayFabLoggerBase()
        {
            var val_8;
            this.LogMessageQueue = new System.Collections.Generic.Queue<System.String>();
            this._threadLock = new System.Object();
            System.DateTime val_3 = System.DateTime.UtcNow;
            val_8 = null;
            val_8 = null;
            System.DateTime val_4 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = val_3.dateData}, t:  new System.TimeSpan() {_ticks = PlayFab.Public.PlayFabLoggerBase._threadKillTimeout});
            this._threadKillTime = val_4;
            this._isApplicationPlaying = true;
            bool val_7 = false;
            System.Threading.Monitor.Enter(obj:  this.LogMessageQueue, lockTaken: ref  val_7);
            this.LogMessageQueue.Enqueue(item:  new PlayFab.PlayFabDataGatherer().GenerateReport());
            if(val_7 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.LogMessageQueue);
            }
            
            if(108 == 108)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void OnEnable()
        {
            UnityEngine.Coroutine val_3 = PlayFab.Internal.SingletonMonoBehaviour<PlayFab.Internal.PlayFabHttp>.instance.StartCoroutine(routine:  this.RegisterLogger());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator RegisterLogger()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new PlayFabLoggerBase.<RegisterLogger>d__23();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void OnDisable()
        {
            if((System.String.IsNullOrEmpty(value:  PlayFab.PlayFabSettings.LoggerHost)) != false)
            {
                    return;
            }
            
            UnityEngine.Application.remove_logMessageReceivedThreaded(value:  new Application.LogCallback(object:  this, method:  System.Void PlayFab.Public.PlayFabLoggerBase::HandleUnityLog(string message, string stacktrace, UnityEngine.LogType type)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void OnDestroy()
        {
            this._isApplicationPlaying = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected abstract void BeginUploadLog(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected abstract void UploadLog(string message); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected abstract void EndUploadLog(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleUnityLog(string message, string stacktrace, UnityEngine.LogType type)
        {
            int val_16;
            string val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            val_17 = message;
            val_18 = null;
            if(PlayFab.PlayFabSettings.EnableRealTimeLogging == false)
            {
                    return;
            }
            
            val_19 = null;
            val_19 = null;
            val_16 = PlayFab.Public.PlayFabLoggerBase.LOG_CACHE_INTERVAL_MS;
            val_16.Length = 0;
            if((type & 4294967294) != 2)
            {
                goto label_7;
            }
            
            val_20 = null;
            val_20 = null;
            System.Text.StringBuilder val_5 = PlayFab.Public.PlayFabLoggerBase.LOG_CACHE_INTERVAL_MS.Append(value:  type).Append(value:  ": ").Append(value:  val_17);
            val_16 = this.LogMessageQueue;
            val_17 = PlayFab.Public.PlayFabLoggerBase.LOG_CACHE_INTERVAL_MS;
            bool val_6 = false;
            System.Threading.Monitor.Enter(obj:  val_16, lockTaken: ref  val_6);
            this.LogMessageQueue.Enqueue(item:  val_17);
            if(val_6 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_16);
            }
            
            if(235 == 235)
            {
                goto label_34;
            }
            
            if(0 == 0)
            {
                goto label_18;
            }
            
            goto label_18;
            label_7:
            label_18:
            if((type | 4) == 4)
            {
                    val_21 = null;
                val_21 = null;
                val_16 = PlayFab.Public.PlayFabLoggerBase.LOG_CACHE_INTERVAL_MS;
                System.Text.StringBuilder val_14 = val_16.Append(value:  type).Append(value:  ": ").Append(value:  val_17).Append(value:  "\n").Append(value:  stacktrace).Append(value:  UnityEngine.StackTraceUtility.ExtractStackTrace());
                bool val_15 = false;
                System.Threading.Monitor.Enter(obj:  this.LogMessageQueue, lockTaken: ref  val_15);
                this.LogMessageQueue.Enqueue(item:  PlayFab.Public.PlayFabLoggerBase.LOG_CACHE_INTERVAL_MS);
                val_17 = 0;
                if(val_15 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.LogMessageQueue);
            }
            
            }
            
            label_34:
            this.ActivateThreadWorker();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ActivateThreadWorker()
        {
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this._threadLock, lockTaken: ref  val_1);
            if(this._writeLogThread == null)
            {
                    new System.Threading.ThreadStart() = new System.Threading.ThreadStart(object:  this, method:  System.Void PlayFab.Public.PlayFabLoggerBase::WriteLogThreadWorker());
                new System.Threading.Thread() = new System.Threading.Thread(start:  new System.Threading.ThreadStart());
                this._writeLogThread = new System.Threading.Thread();
                new System.Threading.Thread().Start();
            }
            
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this._threadLock);
            }
            
            if(73 == 73)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void WriteLogThreadWorker()
        {
            var val_17;
            System.Exception val_18;
            var val_19;
            var val_20;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this._threadLock, lockTaken: ref  val_1);
            System.DateTime val_2 = System.DateTime.UtcNow;
            val_17 = null;
            val_17 = null;
            System.DateTime val_3 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = val_2.dateData}, t:  new System.TimeSpan() {_ticks = PlayFab.Public.PlayFabLoggerBase._threadKillTimeout});
            this._threadKillTime = val_3;
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this._threadLock);
            }
            
            if(50 == 50)
            {
                
            }
            
            System.Collections.Generic.Queue<System.String> val_4 = new System.Collections.Generic.Queue<System.String>();
            goto label_34;
            label_47:
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  1152921505298911232);
            }
            
            if(((50 == 0) ? 138 : 50) == 138)
            {
                
            }
            else
            {
                    if( != 0)
            {
                    val_18 = 0;
            }
            
            }
            
            label_17:
            if(null.Count < 1)
            {
                goto label_15;
            }
            
            string val_7 = null.Dequeue();
            goto label_17;
            label_15:
            bool val_8 = false;
            System.Threading.Monitor.Enter(obj:  this._threadLock, lockTaken: ref  val_8);
            System.DateTime val_9 = System.DateTime.UtcNow;
            if((this._pendingLogsCount >= 1) && (this._isApplicationPlaying != false))
            {
                    val_19 = null;
                val_19 = null;
                System.DateTime val_10 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = val_9.dateData}, t:  new System.TimeSpan() {_ticks = PlayFab.Public.PlayFabLoggerBase._threadKillTimeout});
                this._threadKillTime = val_10;
            }
            
            if((System.DateTime.op_LessThanOrEqual(t1:  new System.DateTime() {dateData = val_9.dateData}, t2:  new System.DateTime() {dateData = this._threadKillTime})) != false)
            {
                    val_20 = 1;
            }
            else
            {
                    val_20 = 0;
                this._writeLogThread = 0;
            }
            
            if(val_8 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this._threadLock);
            }
            
            if(((268 == 0) ? 268 : 268) == 268)
            {
                
            }
            else
            {
                    if(val_18 != 0)
            {
                    val_18 = 0;
            }
            
            }
            
            System.Threading.Thread.Sleep(millisecondsTimeout:  16);
            if((val_20 & 1) == 0)
            {
                    return;
            }
            
            label_34:
            System.Threading.Monitor.Enter(obj:  this.LogMessageQueue, lockTaken: ref  false);
            this._pendingLogsCount = this.LogMessageQueue.Count;
            label_46:
            if(this.LogMessageQueue.Count < 1)
            {
                goto label_47;
            }
            
            null.Enqueue(item:  this.LogMessageQueue.Dequeue());
            goto label_46;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PlayFabLoggerBase()
        {
            PlayFab.Public.PlayFabLoggerBase.LOG_CACHE_INTERVAL_MS = new System.Text.StringBuilder();
            System.TimeSpan val_2 = System.TimeSpan.FromSeconds(value:  60);
            PlayFab.Public.PlayFabLoggerBase._threadKillTimeout = val_2._ticks;
        }
    
    }

}
