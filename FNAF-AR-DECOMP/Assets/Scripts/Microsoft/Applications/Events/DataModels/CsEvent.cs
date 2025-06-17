using UnityEngine;

namespace Microsoft.Applications.Events.DataModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class CsEvent
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <ver>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <name>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long <time>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double <popSample>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <iKey>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long <flags>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <cV>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Ingest> <extIngest>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Protocol> <extProtocol>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.User> <extUser>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Device> <extDevice>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Os> <extOs>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.App> <extApp>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Utc> <extUtc>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Xbl> <extXbl>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Javascript> <extJavascript>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Receipts> <extReceipts>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Net> <extNet>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Sdk> <extSdk>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Loc> <extLoc>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Cloud> <extCloud>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Data> <ext>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, string> <tags>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <baseType>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Data> <baseData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Data> <data>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ver { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string name { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long time { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double popSample { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string iKey { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long flags { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string cV { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Ingest> extIngest { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Protocol> extProtocol { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.User> extUser { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Device> extDevice { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Os> extOs { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.App> extApp { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Utc> extUtc { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Xbl> extXbl { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Javascript> extJavascript { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Receipts> extReceipts { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Net> extNet { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Sdk> extSdk { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Loc> extLoc { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Cloud> extCloud { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Data> ext { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> tags { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string baseType { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Data> baseData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Data> data { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_ver()
        {
            return (string)this.<ver>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ver(string value)
        {
            this.<ver>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_name()
        {
            return (string)this.<name>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_name(string value)
        {
            this.<name>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long get_time()
        {
            return (long)this.<time>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_time(long value)
        {
            this.<time>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double get_popSample()
        {
            return (double)this.<popSample>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_popSample(double value)
        {
            this.<popSample>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_iKey()
        {
            return (string)this.<iKey>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_iKey(string value)
        {
            this.<iKey>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long get_flags()
        {
            return (long)this.<flags>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_flags(long value)
        {
            this.<flags>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_cV()
        {
            return (string)this.<cV>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_cV(string value)
        {
            this.<cV>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Ingest> get_extIngest()
        {
            return (System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Ingest>)this.<extIngest>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_extIngest(System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Ingest> value)
        {
            this.<extIngest>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Protocol> get_extProtocol()
        {
            return (System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Protocol>)this.<extProtocol>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_extProtocol(System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Protocol> value)
        {
            this.<extProtocol>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.User> get_extUser()
        {
            return (System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.User>)this.<extUser>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_extUser(System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.User> value)
        {
            this.<extUser>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Device> get_extDevice()
        {
            return (System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Device>)this.<extDevice>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_extDevice(System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Device> value)
        {
            this.<extDevice>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Os> get_extOs()
        {
            return (System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Os>)this.<extOs>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_extOs(System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Os> value)
        {
            this.<extOs>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.App> get_extApp()
        {
            return (System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.App>)this.<extApp>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_extApp(System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.App> value)
        {
            this.<extApp>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Utc> get_extUtc()
        {
            return (System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Utc>)this.<extUtc>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_extUtc(System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Utc> value)
        {
            this.<extUtc>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Xbl> get_extXbl()
        {
            return (System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Xbl>)this.<extXbl>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_extXbl(System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Xbl> value)
        {
            this.<extXbl>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Javascript> get_extJavascript()
        {
            return (System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Javascript>)this.<extJavascript>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_extJavascript(System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Javascript> value)
        {
            this.<extJavascript>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Receipts> get_extReceipts()
        {
            return (System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Receipts>)this.<extReceipts>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_extReceipts(System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Receipts> value)
        {
            this.<extReceipts>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Net> get_extNet()
        {
            return (System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Net>)this.<extNet>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_extNet(System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Net> value)
        {
            this.<extNet>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Sdk> get_extSdk()
        {
            return (System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Sdk>)this.<extSdk>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_extSdk(System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Sdk> value)
        {
            this.<extSdk>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Loc> get_extLoc()
        {
            return (System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Loc>)this.<extLoc>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_extLoc(System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Loc> value)
        {
            this.<extLoc>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Cloud> get_extCloud()
        {
            return (System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Cloud>)this.<extCloud>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_extCloud(System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Cloud> value)
        {
            this.<extCloud>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Data> get_ext()
        {
            return (System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Data>)this.<ext>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ext(System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Data> value)
        {
            this.<ext>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> get_tags()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.String>)this.<tags>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_tags(System.Collections.Generic.Dictionary<string, string> value)
        {
            this.<tags>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_baseType()
        {
            return (string)this.<baseType>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_baseType(string value)
        {
            this.<baseType>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Data> get_baseData()
        {
            return (System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Data>)this.<baseData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_baseData(System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Data> value)
        {
            this.<baseData>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Data> get_data()
        {
            return (System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Data>)this.<data>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_data(System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Data> value)
        {
            this.<data>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CsEvent()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected CsEvent(string fullName, string name)
        {
            val_1 = new System.Object();
            this.<popSample>k__BackingField = 100;
            this.<ver>k__BackingField = "";
            this.<name>k__BackingField = "";
            this.<tags>k__BackingField = new System.Collections.Generic.Dictionary<System.String, System.String>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void Reset()
        {
            var val_3;
            var val_15;
            if((this.<ext>k__BackingField) == null)
            {
                goto label_8;
            }
            
            List.Enumerator<T> val_1 = this.<ext>k__BackingField.GetEnumerator();
            label_4:
            if((116513744 & 1) == 0)
            {
                goto label_2;
            }
            
            val_3.emailUIDataHandler.Release();
            goto label_4;
            label_2:
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526198197200});
            goto label_5;
            label_8:
            label_5:
            if((this.<data>k__BackingField) == null)
            {
                goto label_9;
            }
            
            List.Enumerator<T> val_7 = this.<data>k__BackingField.GetEnumerator();
            label_12:
            if((116513744 & 1) == 0)
            {
                goto label_10;
            }
            
            val_3.emailUIDataHandler.Release();
            goto label_12;
            label_10:
            val_15 = 0;
            long val_9 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526198197200});
            if(((118 == 0) ? 118 : 118) != 118)
            {
                goto label_16;
            }
            
            goto label_18;
            label_16:
            if( == 0)
            {
                goto label_18;
            }
            
            label_9:
            val_15 = 0;
            label_18:
            if((this.<baseData>k__BackingField) == null)
            {
                goto label_28;
            }
            
            List.Enumerator<T> val_11 = this.<baseData>k__BackingField.GetEnumerator();
            label_22:
            if((116513744 & 1) == 0)
            {
                goto label_23;
            }
            
            val_3.emailUIDataHandler.Release();
            goto label_22;
            label_23:
            long val_13 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526198197200});
            label_28:
            this.<ver>k__BackingField = System.String.alignConst;
            this.<time>k__BackingField = 0;
            this.<popSample>k__BackingField = 0;
            this.<name>k__BackingField = System.String.alignConst;
            this.<iKey>k__BackingField = System.String.alignConst;
            this.<flags>k__BackingField = 0;
            this.<cV>k__BackingField = System.String.alignConst;
            Microsoft.Applications.Events.DataModels.CsEvent.SafeClear(list:  this.<ext>k__BackingField);
            Microsoft.Applications.Events.DataModels.CsEvent.SafeClear(list:  this.<extIngest>k__BackingField);
            Microsoft.Applications.Events.DataModels.CsEvent.SafeClear(list:  this.<extProtocol>k__BackingField);
            Microsoft.Applications.Events.DataModels.CsEvent.SafeClear(list:  this.<extUser>k__BackingField);
            Microsoft.Applications.Events.DataModels.CsEvent.SafeClear(list:  this.<extDevice>k__BackingField);
            Microsoft.Applications.Events.DataModels.CsEvent.SafeClear(list:  this.<extOs>k__BackingField);
            Microsoft.Applications.Events.DataModels.CsEvent.SafeClear(list:  this.<extApp>k__BackingField);
            Microsoft.Applications.Events.DataModels.CsEvent.SafeClear(list:  this.<extUtc>k__BackingField);
            Microsoft.Applications.Events.DataModels.CsEvent.SafeClear(list:  this.<extNet>k__BackingField);
            Microsoft.Applications.Events.DataModels.CsEvent.SafeClear(list:  this.<extDevice>k__BackingField);
            Microsoft.Applications.Events.DataModels.CsEvent.SafeClear(list:  this.<extCloud>k__BackingField);
            Microsoft.Applications.Events.DataModels.CsEvent.SafeClear(list:  this.<extLoc>k__BackingField);
            Microsoft.Applications.Events.DataModels.CsEvent.SafeClear(list:  this.<extXbl>k__BackingField);
            Microsoft.Applications.Events.DataModels.CsEvent.SafeClear(list:  this.<extSdk>k__BackingField);
            Microsoft.Applications.Events.DataModels.CsEvent.SafeClear(list:  this.<extJavascript>k__BackingField);
            Microsoft.Applications.Events.DataModels.CsEvent.SafeClear(list:  this.<extReceipts>k__BackingField);
            Microsoft.Applications.Events.DataModels.CsEvent.SafeClear(list:  this.<ext>k__BackingField);
            if((this.<tags>k__BackingField) != null)
            {
                    this.<tags>k__BackingField.Clear();
            }
            
            if((this.<baseType>k__BackingField) != null)
            {
                    this.<baseType>k__BackingField = System.String.alignConst;
            }
            
            Microsoft.Applications.Events.DataModels.CsEvent.SafeClear(list:  this.<baseData>k__BackingField);
            Microsoft.Applications.Events.DataModels.CsEvent.SafeClear(list:  this.<data>k__BackingField);
            this.<baseType>k__BackingField = System.String.alignConst;
            this.<baseData>k__BackingField = 0;
            this.<data>k__BackingField = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void SafeClear(System.Collections.IList list)
        {
            if(list == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            list.Clear();
        }
    
    }

}
