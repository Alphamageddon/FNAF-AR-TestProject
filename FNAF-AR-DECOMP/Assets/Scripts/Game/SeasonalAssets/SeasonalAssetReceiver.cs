using UnityEngine;

namespace Game.SeasonalAssets
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SeasonalAssetReceiver : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _seasonalKey;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ReceiverId { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_ReceiverId()
        {
            return (string)this._seasonalKey;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this.Request();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Request()
        {
            Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
            val_1.eventExposer.OnPopulateSeasonalAssetsRequest(receiverId:  this._seasonalKey, target:  this.transform);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SeasonalAssetReceiver()
        {
        
        }
    
    }

}
