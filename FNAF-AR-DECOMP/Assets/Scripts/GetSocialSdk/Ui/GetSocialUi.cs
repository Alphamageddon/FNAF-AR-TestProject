using UnityEngine;

namespace GetSocialSdk.Ui
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class GetSocialUi
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static GetSocialSdk.Ui.IGetSocialUiNativeBridge _getSocialUiImpl;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static GetSocialSdk.Ui.IGetSocialUiNativeBridge GetSocialImpl { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static GetSocialSdk.Ui.IGetSocialUiNativeBridge get_GetSocialImpl()
        {
            if(GetSocialSdk.Ui.GetSocialUi._getSocialUiImpl != null)
            {
                    return val_1;
            }
            
            GetSocialSdk.Ui.IGetSocialUiNativeBridge val_1 = GetSocialSdk.Ui.GetSocialUiNativeBridgeAndroid.Instance;
            GetSocialSdk.Ui.GetSocialUi._getSocialUiImpl = val_1;
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Ui.InvitesViewBuilder CreateInvitesView()
        {
            return (GetSocialSdk.Ui.InvitesViewBuilder)new GetSocialSdk.Ui.InvitesViewBuilder();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Ui.ActivityFeedViewBuilder CreateGlobalActivityFeedView()
        {
            return (GetSocialSdk.Ui.ActivityFeedViewBuilder)new GetSocialSdk.Ui.ActivityFeedViewBuilder();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Ui.ActivityFeedViewBuilder CreateActivityFeedView(string feed)
        {
            return (GetSocialSdk.Ui.ActivityFeedViewBuilder)new GetSocialSdk.Ui.ActivityFeedViewBuilder(feed:  feed);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Ui.ActivityDetailsViewBuilder CreateActivityDetailsView(string activityId)
        {
            return (GetSocialSdk.Ui.ActivityDetailsViewBuilder)new GetSocialSdk.Ui.ActivityDetailsViewBuilder(activityId:  activityId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Ui.NotificationCenterViewBuilder CreateNotificationCenterView()
        {
            return (GetSocialSdk.Ui.NotificationCenterViewBuilder)new GetSocialSdk.Ui.NotificationCenterViewBuilder();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ShowView<T>(GetSocialSdk.Ui.ViewBuilder<T> viewBuilder)
        {
            GetSocialSdk.Ui.IGetSocialUiNativeBridge val_1 = GetSocialSdk.Ui.GetSocialUi.GetSocialImpl;
            var val_3 = 0;
            val_3 = val_3 + 1;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(val_1, typeof(__RuntimeMethodHiddenParam + 48 + 24), slot: 0) + 8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool LoadDefaultConfiguration()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return GetSocialSdk.Ui.GetSocialUi.GetSocialImpl.LoadDefaultConfiguration();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool LoadConfiguration(string path)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return GetSocialSdk.Ui.GetSocialUi.GetSocialImpl.LoadConfiguration(filePath:  path);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool CloseView()
        {
            return GetSocialSdk.Ui.GetSocialUi.CloseView(saveViewState:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool CloseView(bool saveViewState)
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            return GetSocialSdk.Ui.GetSocialUi.GetSocialImpl.CloseView(saveViewState:  saveViewState);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool RestoreView()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return GetSocialSdk.Ui.GetSocialUi.GetSocialImpl.RestoreView();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool OnBackPressed()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return GetSocialSdk.Ui.GetSocialUi.GetSocialImpl.OnBackPressed();
        }
    
    }

}
