using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class PlayerProfileModel : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.AdCampaignAttributionModel> AdCampaignAttributions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string AvatarUrl;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> BannedUntil;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.ContactEmailInfoModel> ContactEmailAddresses;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> Created;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DisplayName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> LastLogin;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.LinkedPlatformAccountModel> LinkedAccounts;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.LocationModel> Locations;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.MembershipModel> Memberships;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<PlayFab.ClientModels.LoginIdentityProvider> Origination;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PlayerId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PublisherId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.PushNotificationRegistrationModel> PushNotificationRegistrations;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.StatisticModel> Statistics;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.TagModel> Tags;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TitleId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<uint> TotalValueToDateInUSD;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.ValueToDateModel> ValuesToDate;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayerProfileModel()
        {
        
        }
    
    }

}
