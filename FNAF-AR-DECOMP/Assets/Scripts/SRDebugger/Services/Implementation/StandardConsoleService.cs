using UnityEngine;

namespace SRDebugger.Services.Implementation
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StandardConsoleService : IConsoleService
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly bool _collapseEnabled;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _hasCleared;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly SRDebugger.CircularBuffer<SRDebugger.Services.ConsoleEntry> _allConsoleEntries;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.CircularBuffer<SRDebugger.Services.ConsoleEntry> _consoleEntries;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly object _threadLock;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <ErrorCount>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <WarningCount>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <InfoCount>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.Services.ConsoleUpdatedEventHandler Updated;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int ErrorCount { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int WarningCount { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int InfoCount { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.IReadOnlyList<SRDebugger.Services.ConsoleEntry> Entries { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.IReadOnlyList<SRDebugger.Services.ConsoleEntry> AllEntries { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StandardConsoleService()
        {
            this._threadLock = new System.Object();
            UnityEngine.Application.add_logMessageReceivedThreaded(value:  new Application.LogCallback(object:  this, method:  System.Void SRDebugger.Services.Implementation.StandardConsoleService::UnityLogCallback(string condition, string stackTrace, UnityEngine.LogType type)));
            SRF.Service.SRServiceManager.RegisterService<SRDebugger.Services.IConsoleService>(service:  this);
            SRDebugger.Settings val_3 = SRDebugger.Settings.Instance;
            this._collapseEnabled = val_3._collapseDuplicateLogEntries;
            SRDebugger.Settings val_4 = SRDebugger.Settings.Instance;
            this._allConsoleEntries = new SRDebugger.CircularBuffer<SRDebugger.Services.ConsoleEntry>(capacity:  val_4._maximumConsoleEntries);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_ErrorCount()
        {
            return (int)this.<ErrorCount>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ErrorCount(int value)
        {
            this.<ErrorCount>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_WarningCount()
        {
            return (int)this.<WarningCount>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_WarningCount(int value)
        {
            this.<WarningCount>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_InfoCount()
        {
            return (int)this.<InfoCount>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_InfoCount(int value)
        {
            this.<InfoCount>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_Updated(SRDebugger.Services.ConsoleUpdatedEventHandler value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.Updated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.Updated != 1152921523001531664);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_Updated(SRDebugger.Services.ConsoleUpdatedEventHandler value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.Updated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.Updated != 1152921523001668240);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.IReadOnlyList<SRDebugger.Services.ConsoleEntry> get_Entries()
        {
            return (SRDebugger.IReadOnlyList<SRDebugger.Services.ConsoleEntry>)(this._hasCleared == false) ? this._allConsoleEntries : this._consoleEntries;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.IReadOnlyList<SRDebugger.Services.ConsoleEntry> get_AllEntries()
        {
            return (SRDebugger.IReadOnlyList<SRDebugger.Services.ConsoleEntry>)this._allConsoleEntries;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Clear()
        {
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this._threadLock, lockTaken: ref  val_1);
            this._hasCleared = true;
            if(this._consoleEntries != null)
            {
                    this._consoleEntries.Clear();
            }
            else
            {
                    SRDebugger.Settings val_2 = SRDebugger.Settings.Instance;
                SRDebugger.CircularBuffer<SRDebugger.Services.ConsoleEntry> val_3 = new SRDebugger.CircularBuffer<SRDebugger.Services.ConsoleEntry>(capacity:  val_2._maximumConsoleEntries);
                this._consoleEntries = null;
            }
            
            this.<InfoCount>k__BackingField = 0;
            this.<ErrorCount>k__BackingField = 0;
            this.<WarningCount>k__BackingField = 0;
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this._threadLock);
            }
            
            this.OnUpdated();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void OnEntryAdded(SRDebugger.Services.ConsoleEntry entry)
        {
            SRDebugger.CircularBuffer<SRDebugger.Services.ConsoleEntry> val_5;
            if(this._hasCleared == false)
            {
                goto label_1;
            }
            
            if(this._consoleEntries.IsFull == false)
            {
                goto label_3;
            }
            
            SRDebugger.Services.ConsoleEntry val_2 = this._consoleEntries.Front();
            if(val_2.LogType > 4)
            {
                goto label_14;
            }
            
            var val_5 = 52951464 + (val_2.LogType) << 2;
            val_5 = val_5 + 52951464;
            goto (52951464 + (val_2.LogType) << 2 + 52951464);
            label_1:
            val_5 = this;
            if(this._allConsoleEntries.IsFull == false)
            {
                goto label_17;
            }
            
            SRDebugger.Services.ConsoleEntry val_4 = this._allConsoleEntries.Front();
            if(val_4.LogType > 4)
            {
                goto label_18;
            }
            
            var val_7 = 52951484 + (val_4.LogType) << 2;
            val_7 = val_7 + 52951484;
            goto (52951484 + (val_4.LogType) << 2 + 52951484);
            label_14:
            this._consoleEntries.PopFront();
            label_3:
            this._consoleEntries.PushBack(item:  entry);
            val_5 = this._allConsoleEntries;
            goto label_17;
            label_18:
            this._allConsoleEntries._start.PopFront();
            label_17:
            this._allConsoleEntries._start.PushBack(item:  entry);
            this.OnUpdated();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void OnEntryDuplicated(SRDebugger.Services.ConsoleEntry entry)
        {
            SRDebugger.CircularBuffer<SRDebugger.Services.ConsoleEntry> val_3;
            int val_4;
            if(entry != null)
            {
                    val_3 = entry;
                val_4 = entry.Count;
            }
            else
            {
                    val_3 = 32;
                val_4 = 64;
            }
            
            mem[32] = 65;
            this.OnUpdated();
            if(this._hasCleared == false)
            {
                    return;
            }
            
            val_3 = this._consoleEntries;
            if(val_3.Count != 0)
            {
                    return;
            }
            
            .Count = 1;
            this.OnEntryAdded(entry:  new SRDebugger.Services.ConsoleEntry(other:  entry));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnUpdated()
        {
            if(this.Updated == null)
            {
                    return;
            }
            
            this.Updated.Invoke(console:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UnityLogCallback(string condition, string stackTrace, UnityEngine.LogType type)
        {
            var val_9;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this._threadLock, lockTaken: ref  val_1);
            if((this._collapseEnabled == false) || (this._allConsoleEntries.Count <= 0))
            {
                goto label_9;
            }
            
            SRDebugger.Services.ConsoleEntry val_5 = this._allConsoleEntries.Item[this._allConsoleEntries.Count - 1];
            if((((val_5 == null) || (val_5.LogType != type)) || ((System.String.op_Equality(a:  val_5.Message, b:  condition)) == false)) || ((System.String.op_Equality(a:  val_5.StackTrace, b:  stackTrace)) == false))
            {
                goto label_9;
            }
            
            this.OnEntryDuplicated(entry:  val_5);
            goto label_10;
            label_9:
            new SRDebugger.Services.ConsoleEntry() = new SRDebugger.Services.ConsoleEntry();
            if(new SRDebugger.Services.ConsoleEntry() != null)
            {
                    .LogType = type;
                .StackTrace = stackTrace;
            }
            else
            {
                    .LogType = type;
                mem[48] = stackTrace;
            }
            
            .Message = condition;
            this.OnEntryAdded(entry:  new SRDebugger.Services.ConsoleEntry());
            label_10:
            if(type <= 4)
            {
                    var val_9 = 52951524 + (type) << 2;
                val_9 = val_9 + 52951524;
            }
            else
            {
                    val_9 = 0;
                if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this._threadLock);
            }
            
                if(170 == 170)
            {
                    return;
            }
            
                if(val_9 == 0)
            {
                    return;
            }
            
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AdjustCounter(UnityEngine.LogType type, int amount)
        {
            if(type > 4)
            {
                    return;
            }
            
            var val_1 = 52951504 + (type) << 2;
            val_1 = val_1 + 52951504;
            goto (52951504 + (type) << 2 + 52951504);
        }
    
    }

}
