using UnityEngine;

namespace Systems.Analytics
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AnalyticsHistory
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.LinkedList<Systems.Analytics.AnalyticsHistory.Entry> _entries;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.LinkedList<Systems.Analytics.AnalyticsHistory.Entry> Entries { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup()
        {
            this._entries = new System.Collections.Generic.LinkedList<Entry>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Log(Systems.Analytics.AnalyticsEventMode mode, string key, System.Collections.Generic.Dictionary<string, string> metadata)
        {
            System.Collections.Generic.Dictionary<System.String, System.String> val_5 = metadata;
            if(val_5 == null)
            {
                    System.Collections.Generic.Dictionary<System.String, System.String> val_2 = null;
                val_5 = val_2;
                val_2 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            }
            
            .timestamp = this.GetCurrentMillisecondsInUTC();
            .mode = mode;
            .key = key;
            .metadata = val_5;
            System.Collections.Generic.LinkedListNode<T> val_4 = this._entries.AddLast(value:  new AnalyticsHistory.Entry());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.LinkedList<Systems.Analytics.AnalyticsHistory.Entry> get_Entries()
        {
            return (System.Collections.Generic.LinkedList<Entry>)this._entries;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ulong GetCurrentMillisecondsInUTC()
        {
            System.DateTime val_1 = System.DateTime.UtcNow;
            System.TimeSpan val_2 = val_1.dateData.Subtract(value:  new System.DateTime());
            return 1663975816;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnalyticsHistory()
        {
        
        }
    
    }

}
