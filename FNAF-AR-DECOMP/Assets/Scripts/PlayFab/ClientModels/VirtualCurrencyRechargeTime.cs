using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class VirtualCurrencyRechargeTime : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int RechargeMax;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTime RechargeTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int SecondsToRecharge;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VirtualCurrencyRechargeTime()
        {
        
        }
    
    }

}
