using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IxReceivers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxQuerier_iOS
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxQuerier_iOS.URLFound SettingsURLFoundEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxQuerier_iOS.PushNotificationStatus PushNotificationStatusEvent;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool QueryIfCameraPermissionAskedYet()
        {
            UnityCVManager val_1 = UnityCVManager.Instance;
            if(val_1 != null)
            {
                    return val_1.QueryCameraPermissionAskedYet();
            }
            
            return val_1.QueryCameraPermissionAskedYet();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool QueryCameraPermission()
        {
            UnityCVManager val_1 = UnityCVManager.Instance;
            if(val_1 != null)
            {
                    return val_1.QueryCameraPermission();
            }
            
            return val_1.QueryCameraPermission();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool QueryLocationPermission()
        {
            UnityCVManager val_1 = UnityCVManager.Instance;
            if(val_1 != null)
            {
                    return val_1.QueryGPSPermission();
            }
            
            return val_1.QueryGPSPermission();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void QueryGoToSettingsURL()
        {
            UnityCVManager.Instance.SetupStringCallback(callback:  new UnityCVManager.StringUpdate(object:  0, method:  static System.Void SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxQuerier_iOS::CallSettingsURLUpdate(string url)));
            UnityCVManager.Instance.QuerySettingsURL();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void QueryRemotePushNotificationEnabled()
        {
            UnityCVManager.Instance.SetupPushNotifCallback(callback:  new UnityCVManager.BoolUpdate(object:  0, method:  static System.Void SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxQuerier_iOS::CallRemotePushNotificationsUpdate(bool isAuthorized)));
            UnityCVManager.Instance.QueryRemotePushNotificationEnabled();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void CallSettingsURLUpdate(string url)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxQuerier_iOS.SettingsURLFoundEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxQuerier_iOS.SettingsURLFoundEvent.Invoke(r:  url);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void CallRemotePushNotificationsUpdate(bool isAuthorized)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxQuerier_iOS.PushNotificationStatusEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxQuerier_iOS.PushNotificationStatusEvent.Invoke(isAuthorized:  isAuthorized);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_SettingsURLFoundEvent(SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxQuerier_iOS.URLFound value)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxQuerier_iOS.SettingsURLFoundEvent, b:  value);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_SettingsURLFoundEvent(SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxQuerier_iOS.URLFound value)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxQuerier_iOS.SettingsURLFoundEvent, value:  value);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_PushNotificationStatusEvent(SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxQuerier_iOS.PushNotificationStatus value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxQuerier_iOS.PushNotificationStatusEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxQuerier_iOS.PushNotificationStatusEvent != 1152921505159725064);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_PushNotificationStatusEvent(SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxQuerier_iOS.PushNotificationStatus value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxQuerier_iOS.PushNotificationStatusEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxQuerier_iOS.PushNotificationStatusEvent != 1152921505159725064);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxQuerier_iOS()
        {
        
        }
    
    }

}
