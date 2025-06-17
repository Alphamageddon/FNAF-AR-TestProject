using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetPlayerCombinedInfoResultPayload : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.UserAccountInfo AccountInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.CharacterInventory> CharacterInventories;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.CharacterResult> CharacterList;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.PlayerProfileModel PlayerProfile;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.StatisticValue> PlayerStatistics;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> TitleData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, PlayFab.ClientModels.UserDataRecord> UserData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint UserDataVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.ItemInstance> UserInventory;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, PlayFab.ClientModels.UserDataRecord> UserReadOnlyData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint UserReadOnlyDataVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, int> UserVirtualCurrency;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, PlayFab.ClientModels.VirtualCurrencyRechargeTime> UserVirtualCurrencyRechargeTimes;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetPlayerCombinedInfoResultPayload()
        {
        
        }
    
    }

}
