using UnityEngine;

namespace Alerts.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DesignData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.ALERT_DATA <AlertData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.CONFIG_DATA.Types.ENTRY <ConfigDataEntry>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Domain _domain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _configDataLoaded;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _alertDataLoaded;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DataLoaded { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.ALERT_DATA AlertData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.CONFIG_DATA.Types.ENTRY ConfigDataEntry { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_DataLoaded()
        {
            if(this._configDataLoaded == false)
            {
                    return false;
            }
            
            return (bool)(this._alertDataLoaded == true) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.ALERT_DATA get_AlertData()
        {
            return (ProtoData.ALERT_DATA)this.<AlertData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_AlertData(ProtoData.ALERT_DATA value)
        {
            this.<AlertData>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.CONFIG_DATA.Types.ENTRY get_ConfigDataEntry()
        {
            return (ENTRY)this.<ConfigDataEntry>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ConfigDataEntry(ProtoData.CONFIG_DATA.Types.ENTRY value)
        {
            this.<ConfigDataEntry>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DesignData(Alerts.Domain domain)
        {
            this._domain = domain;
            domain._masterDomain.MasterDataDomain.GetAccessToData.GetConfigDataEntryAsync(returnConfigDataEntryCallback:  new GetAccessToData.ReturnConfigDataEntry(object:  this, method:  System.Void Alerts.Data.DesignData::SetConfigData(ProtoData.CONFIG_DATA.Types.ENTRY configDataEntry)));
            this._domain._masterDomain.MasterDataDomain.GetAccessToData.GetAlertDataAsync(returnAlertDataCallback:  new GetAccessToData.ReturnAnyData<ProtoData.ALERT_DATA>(object:  this, method:  System.Void Alerts.Data.DesignData::SetAlertData(ProtoData.ALERT_DATA alertData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetConfigData(ProtoData.CONFIG_DATA.Types.ENTRY configDataEntry)
        {
            this.<ConfigDataEntry>k__BackingField = configDataEntry;
            this._configDataLoaded = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetAlertData(ProtoData.ALERT_DATA alertData)
        {
            this.<AlertData>k__BackingField = alertData;
            this._alertDataLoaded = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.ALERT_DATA.Types.ENTRY GetAlertEntryForId(string id)
        {
            string val_9;
            var val_12;
            var val_13;
            var val_14;
            string val_15;
            string val_16;
            string val_17;
            val_9 = id;
            if((this._configDataLoaded == false) || (this._alertDataLoaded == false))
            {
                goto label_2;
            }
            
            System.Collections.Generic.IEnumerator<T> val_2 = this.<AlertData>k__BackingField.Entries.GetEnumerator();
            label_17:
            var val_11 = 0;
            val_11 = val_11 + 1;
            if(val_2.MoveNext() == false)
            {
                goto label_10;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_12 = val_2.Current;
            if((System.String.op_Equality(a:  val_12.Logical, b:  val_9)) == false)
            {
                goto label_17;
            }
            
            val_13 = 0;
            val_14 = 122;
            if(val_2 != null)
            {
                goto label_23;
            }
            
            goto label_29;
            label_2:
            val_15 = "Alerts.DesignData";
            val_16 = "GetAlertEntryForId";
            val_17 = "Data not loaded";
            goto label_22;
            label_10:
            val_13 = 0;
            val_12 = 0;
            val_14 = 94;
            if(val_2 != null)
            {
                goto label_23;
            }
            
            goto label_29;
            label_23:
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_2.Dispose();
            label_29:
            if( != 94)
            {
                    if( == 122)
            {
                    return (ENTRY)val_12;
            }
            
            }
            
            val_9 = "Couldn\'t find alert entry for id:"("Couldn\'t find alert entry for id:") + val_9;
            val_17 = val_9;
            val_15 = "Alerts.DesignData";
            val_16 = "GetAlertEntryForId";
            label_22:
            ConsoleLogger.LogError(className:  val_15, functionName:  val_16, logString:  val_17);
            val_12 = 0;
            return (ENTRY)val_12;
        }
    
    }

}
