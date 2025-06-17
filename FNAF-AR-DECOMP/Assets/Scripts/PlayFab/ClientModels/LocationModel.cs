using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class LocationModel : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string City;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<PlayFab.ClientModels.ContinentCode> ContinentCode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<PlayFab.ClientModels.CountryCode> CountryCode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<double> Latitude;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<double> Longitude;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LocationModel()
        {
        
        }
    
    }

}
