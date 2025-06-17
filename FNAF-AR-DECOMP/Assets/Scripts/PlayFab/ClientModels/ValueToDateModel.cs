using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ValueToDateModel : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Currency;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint TotalValue;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TotalValueAsDecimal;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ValueToDateModel()
        {
        
        }
    
    }

}
