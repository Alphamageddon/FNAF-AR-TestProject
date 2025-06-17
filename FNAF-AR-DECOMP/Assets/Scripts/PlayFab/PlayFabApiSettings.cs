using UnityEngine;

namespace PlayFab
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayFabApiSettings
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _ProductionEnvironmentUrl;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly System.Collections.Generic.Dictionary<string, string> _requestGetParams;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <TitleId>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <VerticalName>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <AdvertisingIdType>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <AdvertisingIdValue>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <DisableAdvertising>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <DisableDeviceInfo>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <DisableFocusTimeCollection>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual System.Collections.Generic.Dictionary<string, string> RequestGetParams { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual string ProductionEnvironmentUrl { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual string TitleId { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal virtual string VerticalName { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual string AdvertisingIdType { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual string AdvertisingIdValue { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual bool DisableAdvertising { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual bool DisableDeviceInfo { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual bool DisableFocusTimeCollection { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual System.Collections.Generic.Dictionary<string, string> get_RequestGetParams()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.String>)this._requestGetParams;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual string get_ProductionEnvironmentUrl()
        {
            return (string)this._ProductionEnvironmentUrl;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void set_ProductionEnvironmentUrl(string value)
        {
            this._ProductionEnvironmentUrl = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual string get_TitleId()
        {
            return (string)this.<TitleId>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void set_TitleId(string value)
        {
            this.<TitleId>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal virtual string get_VerticalName()
        {
            return (string)this.<VerticalName>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal virtual void set_VerticalName(string value)
        {
            this.<VerticalName>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual string get_AdvertisingIdType()
        {
            return (string)this.<AdvertisingIdType>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void set_AdvertisingIdType(string value)
        {
            this.<AdvertisingIdType>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual string get_AdvertisingIdValue()
        {
            return (string)this.<AdvertisingIdValue>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void set_AdvertisingIdValue(string value)
        {
            this.<AdvertisingIdValue>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual bool get_DisableAdvertising()
        {
            return (bool)this.<DisableAdvertising>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void set_DisableAdvertising(bool value)
        {
            this.<DisableAdvertising>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual bool get_DisableDeviceInfo()
        {
            return (bool)this.<DisableDeviceInfo>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void set_DisableDeviceInfo(bool value)
        {
            this.<DisableDeviceInfo>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual bool get_DisableFocusTimeCollection()
        {
            return (bool)this.<DisableFocusTimeCollection>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void set_DisableFocusTimeCollection(bool value)
        {
            this.<DisableFocusTimeCollection>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual string GetFullUrl(string apiCall, System.Collections.Generic.Dictionary<string, string> getParams)
        {
            return PlayFab.PlayFabSettings.GetFullUrl(apiCall:  apiCall, getParams:  getParams, apiSettings:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFabApiSettings()
        {
            this._ProductionEnvironmentUrl = "playfabapi.com";
            System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            val_1.Add(key:  "sdk", value:  "UnitySDK-2.75.191001");
            this._requestGetParams = val_1;
        }
    
    }

}
