using UnityEngine;

namespace Microsoft.AppCenter.Unity.Crashes
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ErrorReport
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Id>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.DateTimeOffset <AppStartTime>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.DateTimeOffset <AppErrorTime>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Microsoft.AppCenter.Unity.Device <Device>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Microsoft.AppCenter.Unity.Crashes.Models.Exception <Exception>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <ThreadName>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <ProcessId>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <ReporterKey>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <ReporterSignal>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <IsAppKill>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Id { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTimeOffset AppStartTime { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTimeOffset AppErrorTime { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Microsoft.AppCenter.Unity.Device Device { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Microsoft.AppCenter.Unity.Crashes.Models.Exception Exception { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ThreadName { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int ProcessId { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ReporterKey { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ReporterSignal { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsAppKill { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ErrorReport(string id, System.DateTimeOffset appStartTime, System.DateTimeOffset appErrorTime, Microsoft.AppCenter.Unity.Crashes.Models.Exception exception, Microsoft.AppCenter.Unity.Device device, string threadName)
        {
            val_1 = new System.Object();
            this.<Id>k__BackingField = id;
            this.<AppStartTime>k__BackingField = appStartTime;
            mem[1152921526213508784] = appStartTime.m_offsetMinutes;
            this.<AppErrorTime>k__BackingField = appErrorTime;
            mem[1152921526213508800] = appErrorTime.m_offsetMinutes;
            this.<Device>k__BackingField = device;
            this.<Exception>k__BackingField = val_1;
            this.<ThreadName>k__BackingField = threadName;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ErrorReport(string id, System.DateTimeOffset appStartTime, System.DateTimeOffset appErrorTime, Microsoft.AppCenter.Unity.Crashes.Models.Exception exception, int processId, string reporterKey, string reporterSignal, bool isAppKill, Microsoft.AppCenter.Unity.Device device)
        {
            val_1 = new System.Object();
            this.<Id>k__BackingField = id;
            this.<AppStartTime>k__BackingField = appStartTime;
            mem[1152921526213657648] = appStartTime.m_offsetMinutes;
            this.<AppErrorTime>k__BackingField = appErrorTime;
            this.<Exception>k__BackingField = val_1;
            this.<ReporterKey>k__BackingField = reporterKey;
            this.<ReporterSignal>k__BackingField = reporterSignal;
            this.<ProcessId>k__BackingField = processId;
            this.<IsAppKill>k__BackingField = isAppKill;
            mem[1152921526213657664] = appErrorTime.m_offsetMinutes;
            this.<Device>k__BackingField = device;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Id()
        {
            return (string)this.<Id>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Id(string value)
        {
            this.<Id>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTimeOffset get_AppStartTime()
        {
            return new System.DateTimeOffset() {m_dateTime = new System.DateTime() {dateData = this.<AppStartTime>k__BackingField}};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_AppStartTime(System.DateTimeOffset value)
        {
            this.<AppStartTime>k__BackingField = value;
            mem[1152921526214142512] = value.m_offsetMinutes;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTimeOffset get_AppErrorTime()
        {
            return new System.DateTimeOffset() {m_dateTime = new System.DateTime() {dateData = this.<AppErrorTime>k__BackingField}};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_AppErrorTime(System.DateTimeOffset value)
        {
            this.<AppErrorTime>k__BackingField = value;
            mem[1152921526214366528] = value.m_offsetMinutes;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Microsoft.AppCenter.Unity.Device get_Device()
        {
            return (Microsoft.AppCenter.Unity.Device)this.<Device>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Device(Microsoft.AppCenter.Unity.Device value)
        {
            this.<Device>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Microsoft.AppCenter.Unity.Crashes.Models.Exception get_Exception()
        {
            return (Microsoft.AppCenter.Unity.Crashes.Models.Exception)this.<Exception>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Exception(Microsoft.AppCenter.Unity.Crashes.Models.Exception value)
        {
            this.<Exception>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_ThreadName()
        {
            return (string)this.<ThreadName>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ThreadName(string value)
        {
            this.<ThreadName>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_ProcessId()
        {
            return (int)this.<ProcessId>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ProcessId(int value)
        {
            this.<ProcessId>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_ReporterKey()
        {
            return (string)this.<ReporterKey>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ReporterKey(string value)
        {
            this.<ReporterKey>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_ReporterSignal()
        {
            return (string)this.<ReporterSignal>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ReporterSignal(string value)
        {
            this.<ReporterSignal>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsAppKill()
        {
            return (bool)this.<IsAppKill>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_IsAppKill(bool value)
        {
            this.<IsAppKill>k__BackingField = value;
        }
    
    }

}
