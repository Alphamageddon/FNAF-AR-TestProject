using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetPlayerCombinedInfoRequestParams : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool GetCharacterInventories;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool GetCharacterList;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool GetPlayerProfile;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool GetPlayerStatistics;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool GetTitleData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool GetUserAccountInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool GetUserData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool GetUserInventory;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool GetUserReadOnlyData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool GetUserVirtualCurrency;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> PlayerStatisticNames;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.PlayerProfileViewConstraints ProfileConstraints;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> TitleDataKeys;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> UserDataKeys;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> UserReadOnlyDataKeys;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetPlayerCombinedInfoRequestParams()
        {
        
        }
    
    }

}
