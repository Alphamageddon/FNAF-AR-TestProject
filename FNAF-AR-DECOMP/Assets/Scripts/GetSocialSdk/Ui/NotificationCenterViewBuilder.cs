using UnityEngine;

namespace GetSocialSdk.Ui
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class NotificationCenterViewBuilder : ViewBuilder<GetSocialSdk.Ui.NotificationCenterViewBuilder>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string[] _notificationTypes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string[] _actionTypes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GetSocialSdk.Ui.NotificationCenterViewBuilder.NotificationClickListener _notificationClickListener;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GetSocialSdk.Ui.NotificationCenterViewBuilder.ActionButtonClickListener _actionButtonClickListener;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Ui.NotificationCenterViewBuilder SetFilterByTypes(string[] notificationTypes)
        {
            this._notificationTypes = notificationTypes;
            return (GetSocialSdk.Ui.NotificationCenterViewBuilder)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Ui.NotificationCenterViewBuilder SetFilterByActions(string[] actionTypes)
        {
            this._actionTypes = actionTypes;
            return (GetSocialSdk.Ui.NotificationCenterViewBuilder)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Ui.NotificationCenterViewBuilder SetNotificationClickListener(GetSocialSdk.Ui.NotificationCenterViewBuilder.NotificationClickListener notificationClickListener)
        {
            this._notificationClickListener = notificationClickListener;
            return (GetSocialSdk.Ui.NotificationCenterViewBuilder)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Ui.NotificationCenterViewBuilder SetActionButtonClickListener(GetSocialSdk.Ui.NotificationCenterViewBuilder.ActionButtonClickListener actionButtonClickListener)
        {
            this._actionButtonClickListener = actionButtonClickListener;
            return (GetSocialSdk.Ui.NotificationCenterViewBuilder)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal override bool ShowInternal()
        {
            return this.ShowBuilder(builder:  this.ToAJO());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.AndroidJavaObject ToAJO()
        {
            T[] val_17 = System.Array.Empty<System.Object>();
            UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaObject(className:  "im.getsocial.sdk.ui.pushnotifications.NotificationCenterViewBuilder", args:  val_17 = System.Array.Empty<System.Object>());
            if((this._notificationTypes != null) && (this._notificationTypes.Length != 0))
            {
                    object[] val_3 = new object[1];
                val_17 = val_3;
                val_17[0] = GetSocialSdk.Core.JniUtils.ToJavaStringArray(values:  System.Linq.Enumerable.ToList<System.String>(source:  this._notificationTypes));
                UnityEngine.AndroidJavaObject val_6 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "setFilterByTypes", args:  val_3);
            }
            
            if((this._actionTypes != null) && (this._actionTypes.Length != 0))
            {
                    object[] val_7 = new object[1];
                val_17 = val_7;
                val_17[0] = GetSocialSdk.Core.JniUtils.ToJavaStringArray(values:  System.Linq.Enumerable.ToList<System.String>(source:  this._actionTypes));
                UnityEngine.AndroidJavaObject val_10 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "setFilterByActions", args:  val_7);
            }
            
            if(this._notificationClickListener != null)
            {
                    object[] val_11 = new object[1];
                val_17 = val_11;
                val_17[0] = new GetSocialSdk.Ui.NotificationClickListenerProxy(notificationClickListener:  this._notificationClickListener);
                UnityEngine.AndroidJavaObject val_13 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "setNotificationClickListener", args:  val_11);
            }
            
            if(this._actionButtonClickListener == null)
            {
                    return val_2;
            }
            
            object[] val_14 = new object[1];
            GetSocialSdk.Ui.NotificationActionButtonClickListenerProxy val_15 = null;
            val_17 = val_15;
            val_15 = new GetSocialSdk.Ui.NotificationActionButtonClickListenerProxy(actionButtonClickListener:  this._actionButtonClickListener);
            val_14[0] = val_17;
            UnityEngine.AndroidJavaObject val_16 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "setActionButtonClickListener", args:  val_14);
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public NotificationCenterViewBuilder()
        {
        
        }
    
    }

}
