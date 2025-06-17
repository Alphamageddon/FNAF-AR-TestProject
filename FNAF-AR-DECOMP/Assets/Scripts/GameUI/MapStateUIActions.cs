using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MapStateUIActions : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DialogHandler_Map _dialogHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.MapStateUIView _mapStateUIView;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _deliveryCost;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this._masterDomain = Master.MasterDomain.GetDomain();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this._masterDomain.MasterDataDomain.GetAccessToData.GetConfigDataEntryAsync(returnConfigDataEntryCallback:  new GetAccessToData.ReturnConfigDataEntry(object:  this, method:  System.Void GameUI.MapStateUIActions::OnConfigDataLoaded(ProtoData.CONFIG_DATA.Types.ENTRY data)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SpeedUpAnimatronic(MapMode.GeoPositionObject.MapAnimatronic animatronic)
        {
            if(animatronic.CanTap() == false)
            {
                goto label_2;
            }
            
            if((this._masterDomain.theGameDomain.bank.GetCurrency(currencyName:  "FAZ_TOKENS")) >= this._deliveryCost)
            {
                goto label_6;
            }
            
            this._dialogHandler.ShowCantAffordError();
            return;
            label_2:
            this._dialogHandler.ShowTooFarError();
            return;
            label_6:
            this._masterDomain.serverDomain.expressDeliveryRequester.SendExpressDeliveryRequest(id:  animatronic.animatronicEntity.entityId, errorCallback:  new System.Action(object:  this, method:  public System.Void GameUI.MapStateUIActions::HandleDeliveryError()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnConfigDataLoaded(ProtoData.CONFIG_DATA.Types.ENTRY data)
        {
            int val_4;
            if(data == null)
            {
                goto label_2;
            }
            
            EXPRESSDELIVERY val_1 = data.ExpressDelivery;
            if(val_1 == null)
            {
                goto label_2;
            }
            
            double val_2 = val_1.CostFazCoins;
            goto label_3;
            label_2:
            label_3:
            if(((-1326158640) & 1) == 0)
            {
                goto label_4;
            }
            
            val_4 = (int)0.South;
            if(this != null)
            {
                goto label_7;
            }
            
            goto label_6;
            label_4:
            val_4 = 0;
            if(this != null)
            {
                goto label_7;
            }
            
            label_6:
            label_7:
            this._deliveryCost = val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AnimatronicSelected(MapMode.GeoPositionObject.MapAnimatronic animatronic)
        {
            this._dialogHandler.ShowExpressDelivery(animatronic:  animatronic, cost:  this._deliveryCost);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HandleDeliveryError()
        {
            this._dialogHandler.ShowGenericError();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapStateUIActions()
        {
            this._deliveryCost = 10;
        }
    
    }

}
