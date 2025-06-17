using UnityEngine;

namespace PlayFab
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class PlayFabSettingsRedirect : PlayFabApiSettings
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Func<PlayFabSharedSettings> GetSO;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ProductionEnvironmentUrl { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal override string VerticalName { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string TitleId { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string AdvertisingIdType { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string AdvertisingIdValue { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool DisableAdvertising { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool DisableDeviceInfo { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool DisableFocusTimeCollection { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFabSettingsRedirect(System.Func<PlayFabSharedSettings> getSO)
        {
            this.GetSO = getSO;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string get_ProductionEnvironmentUrl()
        {
            PlayFabSharedSettings val_1 = this.GetSO.Invoke();
            if(val_1 == 0)
            {
                    return this.ProductionEnvironmentUrl;
            }
            
            if(val_1 != null)
            {
                    return (string)val_1.ProductionEnvironmentUrl;
            }
            
            return (string)val_1.ProductionEnvironmentUrl;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void set_ProductionEnvironmentUrl(string value)
        {
            if(this.GetSO.Invoke() != 0)
            {
                    val_1.ProductionEnvironmentUrl = value;
            }
            
            this.ProductionEnvironmentUrl = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal override string get_VerticalName()
        {
            PlayFabSharedSettings val_1 = this.GetSO.Invoke();
            if(val_1 == 0)
            {
                    return this.VerticalName;
            }
            
            if(val_1 != null)
            {
                    return (string)val_1.VerticalName;
            }
            
            return (string)val_1.VerticalName;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal override void set_VerticalName(string value)
        {
            if(this.GetSO.Invoke() != 0)
            {
                    val_1.VerticalName = value;
            }
            
            this.VerticalName = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string get_TitleId()
        {
            PlayFabSharedSettings val_1 = this.GetSO.Invoke();
            if(val_1 == 0)
            {
                    return this.TitleId;
            }
            
            if(val_1 != null)
            {
                    return (string)val_1.TitleId;
            }
            
            return (string)val_1.TitleId;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void set_TitleId(string value)
        {
            if(this.GetSO.Invoke() != 0)
            {
                    val_1.TitleId = value;
            }
            
            this.TitleId = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string get_AdvertisingIdType()
        {
            PlayFabSharedSettings val_1 = this.GetSO.Invoke();
            if(val_1 == 0)
            {
                    return this.AdvertisingIdType;
            }
            
            if(val_1 != null)
            {
                    return (string)val_1.AdvertisingIdType;
            }
            
            return (string)val_1.AdvertisingIdType;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void set_AdvertisingIdType(string value)
        {
            if(this.GetSO.Invoke() != 0)
            {
                    val_1.AdvertisingIdType = value;
            }
            
            this.AdvertisingIdType = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string get_AdvertisingIdValue()
        {
            PlayFabSharedSettings val_1 = this.GetSO.Invoke();
            if(val_1 == 0)
            {
                    return this.AdvertisingIdValue;
            }
            
            if(val_1 != null)
            {
                    return (string)val_1.AdvertisingIdValue;
            }
            
            return (string)val_1.AdvertisingIdValue;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void set_AdvertisingIdValue(string value)
        {
            if(this.GetSO.Invoke() != 0)
            {
                    val_1.AdvertisingIdValue = value;
            }
            
            this.AdvertisingIdValue = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool get_DisableAdvertising()
        {
            PlayFabSharedSettings val_1 = this.GetSO.Invoke();
            if(val_1 == 0)
            {
                    return this.DisableAdvertising;
            }
            
            if(val_1 != null)
            {
                    return (bool)val_1.DisableAdvertising;
            }
            
            return (bool)val_1.DisableAdvertising;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void set_DisableAdvertising(bool value)
        {
            if(this.GetSO.Invoke() != 0)
            {
                    val_1.DisableAdvertising = value;
            }
            
            this.DisableAdvertising = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool get_DisableDeviceInfo()
        {
            PlayFabSharedSettings val_1 = this.GetSO.Invoke();
            if(val_1 == 0)
            {
                    return this.DisableDeviceInfo;
            }
            
            if(val_1 != null)
            {
                    return (bool)val_1.DisableDeviceInfo;
            }
            
            return (bool)val_1.DisableDeviceInfo;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void set_DisableDeviceInfo(bool value)
        {
            if(this.GetSO.Invoke() != 0)
            {
                    val_1.DisableDeviceInfo = value;
            }
            
            this.DisableDeviceInfo = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool get_DisableFocusTimeCollection()
        {
            PlayFabSharedSettings val_1 = this.GetSO.Invoke();
            if(val_1 == 0)
            {
                    return this.DisableFocusTimeCollection;
            }
            
            if(val_1 != null)
            {
                    return (bool)val_1.DisableFocusTimeCollection;
            }
            
            return (bool)val_1.DisableFocusTimeCollection;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void set_DisableFocusTimeCollection(bool value)
        {
            if(this.GetSO.Invoke() != 0)
            {
                    val_1.DisableFocusTimeCollection = value;
            }
            
            this.DisableFocusTimeCollection = value;
        }
    
    }

}
