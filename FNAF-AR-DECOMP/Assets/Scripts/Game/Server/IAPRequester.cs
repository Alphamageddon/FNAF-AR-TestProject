using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IAPRequester
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action _successCallback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> _errorCallback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.LogEventHandler _eventHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.ClientModels.PurchaseItemRequest _purchaseItemRequest;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int CLIENT_TO_PLAYFAB_CONVERSION_RATE = 100;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool USE_SANDBOX;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IAPRequester(Game.Server.LogEventHandler eventHandler, Master.EventExposer exposer)
        {
            val_1 = new System.Object();
            this._eventHandler = eventHandler;
            val_1.add_StoreIdReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.Server.IAPRequester::EventExposer_StoreIdReceived(string storeId)));
            this.InitializePlayFabPurchaseRequest();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_StoreIdReceived(string storeId)
        {
            this._purchaseItemRequest.StoreId = storeId;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void InitializePlayFabPurchaseRequest()
        {
            var val_2;
            PlayFab.ClientModels.PurchaseItemRequest val_1 = new PlayFab.ClientModels.PurchaseItemRequest();
            this._purchaseItemRequest = val_1;
            val_2 = null;
            val_2 = null;
            if(val_1 == null)
            {
                    val_2 = null;
            }
            
            .CatalogVersion = Game.Server.ServerDomain.CatalogName;
            this._purchaseItemRequest.StoreId = Game.Server.ServerDomain.StoreName;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void BuyVirtualGood(string itemId, string currency, int cost, System.Action successCallback, System.Action<string> errorCallback)
        {
            var val_1;
            this._successCallback = successCallback;
            this._errorCallback = errorCallback;
            val_1 = null;
            val_1 = null;
            if(Game.Server.ServerDomain.CurrentServer != 2)
            {
                    if(Game.Server.ServerDomain.CurrentServer != 1)
            {
                    return;
            }
            
                this.SendGameSparksPurchaseRequest(itemId:  itemId, currency:  currency);
                return;
            }
            
            this.SendPlayFabPurchaseRequest(itemId:  itemId, currency:  currency, cost:  cost);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SendGameSparksPurchaseRequest(string itemId, string currency)
        {
            GameSparks.Api.Requests.BuyVirtualGoodsRequest val_1 = new GameSparks.Api.Requests.BuyVirtualGoodsRequest();
            if(val_1 != null)
            {
                    GameSparks.Api.Requests.BuyVirtualGoodsRequest val_2 = val_1.SetCurrencyShortCode(currencyShortCode:  currency);
                GameSparks.Api.Requests.BuyVirtualGoodsRequest val_3 = val_1.SetQuantity(quantity:  1);
            }
            else
            {
                    GameSparks.Api.Requests.BuyVirtualGoodsRequest val_4 = val_1.SetCurrencyShortCode(currencyShortCode:  currency);
                GameSparks.Api.Requests.BuyVirtualGoodsRequest val_5 = val_1.SetQuantity(quantity:  1);
            }
            
            GameSparks.Api.Requests.BuyVirtualGoodsRequest val_6 = val_1.SetShortCode(shortCode:  itemId);
            val_1.Send(callback:  new System.Action<GameSparks.Api.Responses.BuyVirtualGoodResponse>(object:  this, method:  public System.Void Game.Server.IAPRequester::BuyResponseReceived(GameSparks.Api.Responses.BuyVirtualGoodResponse response)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SendPlayFabPurchaseRequest(string itemId, string currency, int cost)
        {
            this._purchaseItemRequest.ItemId = itemId;
            this._purchaseItemRequest.VirtualCurrency = currency;
            this._purchaseItemRequest.Price = cost;
            PlayFab.PlayFabClientAPI.PurchaseItem(request:  this._purchaseItemRequest, resultCallback:  new System.Action<PlayFab.ClientModels.PurchaseItemResult>(object:  this, method:  public System.Void Game.Server.IAPRequester::PlayFabPurchaseSuccess(PlayFab.ClientModels.PurchaseItemResult response)), errorCallback:  new System.Action<PlayFab.PlayFabError>(object:  this, method:  public System.Void Game.Server.IAPRequester::PlayFabPurchaseFailure(PlayFab.PlayFabError error)), customData:  0, extraHeaders:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void BuyGameSparksVirtualGoodWithReceipt(string receiptJson, System.Action<string> errorCallback)
        {
            string val_8;
            this._errorCallback = errorCallback;
            Game.Server.Receipt val_1 = UnityEngine.JsonUtility.FromJson<Game.Server.Receipt>(json:  receiptJson);
            Game.Server.GooglePayload val_2 = UnityEngine.JsonUtility.FromJson<Game.Server.GooglePayload>(json:  val_1.Payload);
            GameSparks.Api.Requests.GooglePlayBuyGoodsRequest val_3 = new GameSparks.Api.Requests.GooglePlayBuyGoodsRequest();
            if(val_3 != null)
            {
                    GameSparks.Api.Requests.GooglePlayBuyGoodsRequest val_4 = val_3.SetSignature(signature:  val_2.signature);
                val_8 = val_2.json;
            }
            else
            {
                    GameSparks.Api.Requests.GooglePlayBuyGoodsRequest val_5 = val_3.SetSignature(signature:  val_2.signature);
                val_8 = val_2.json;
            }
            
            GameSparks.Api.Requests.GooglePlayBuyGoodsRequest val_6 = val_3.SetSignedData(signedData:  val_8);
            val_3.Send(callback:  new System.Action<GameSparks.Api.Responses.BuyVirtualGoodResponse>(object:  this, method:  public System.Void Game.Server.IAPRequester::BuyResponseReceived(GameSparks.Api.Responses.BuyVirtualGoodResponse response)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void BuyPlayFabVirtualGoodWithReceipt(UnityEngine.Purchasing.Product product, System.Action successCallback, System.Action<string> errorCallback)
        {
            System.Action val_14;
            var val_15;
            val_14 = successCallback;
            if(product.hasReceipt == false)
            {
                    return;
            }
            
            this._successCallback = val_14;
            this._errorCallback = errorCallback;
            Game.Server.Receipt val_3 = UnityEngine.JsonUtility.FromJson<Game.Server.Receipt>(json:  product.receipt);
            val_15 = null;
            val_15 = null;
            .CatalogVersion = Game.Server.ServerDomain.CatalogName;
            .CurrencyCode = product.metadata.isoCurrencyCode;
            decimal val_9 = product.metadata.localizedPrice;
            decimal val_10 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = val_9.flags, hi = val_9.hi, lo = val_9.lo, mid = val_9.mid}, d2:  new System.Decimal());
            uint val_11 = System.Decimal.ToUInt32(d:  new System.Decimal() {flags = val_10.flags, hi = val_10.hi, lo = val_10.lo, mid = val_10.mid});
            .PurchasePrice = 0;
            if((UnityEngine.JsonUtility.FromJson<Game.Server.GooglePayload>(json:  val_3.Payload)) != null)
            {
                    .Signature = val_4.signature;
            }
            else
            {
                    .Signature = 15026800;
            }
            
            .ReceiptJson = val_4.json;
            System.Action<PlayFab.ClientModels.ValidateGooglePlayPurchaseResult> val_12 = null;
            val_14 = val_12;
            val_12 = new System.Action<PlayFab.ClientModels.ValidateGooglePlayPurchaseResult>(object:  this, method:  public System.Void Game.Server.IAPRequester::PlayFabGooglePlaySuccess(PlayFab.ClientModels.ValidateGooglePlayPurchaseResult result));
            PlayFab.PlayFabClientAPI.ValidateGooglePlayPurchase(request:  new PlayFab.ClientModels.ValidateGooglePlayPurchaseRequest(), resultCallback:  val_12, errorCallback:  new System.Action<PlayFab.PlayFabError>(object:  this, method:  public System.Void Game.Server.IAPRequester::PlayFabReceiptError(PlayFab.PlayFabError result)), customData:  0, extraHeaders:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PlayFabIOSSuccess(PlayFab.ClientModels.ValidateIOSReceiptResult result)
        {
            if(this._successCallback == null)
            {
                    return;
            }
            
            this._successCallback.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PlayFabGooglePlaySuccess(PlayFab.ClientModels.ValidateGooglePlayPurchaseResult result)
        {
            if(this._successCallback == null)
            {
                    return;
            }
            
            this._successCallback.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PlayFabReceiptError(PlayFab.PlayFabError result)
        {
            if(this._errorCallback == null)
            {
                    return;
            }
            
            this._errorCallback.Invoke(obj:  result);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void BuyResponseReceived(GameSparks.Api.Responses.BuyVirtualGoodResponse response)
        {
            System.Action<System.String> val_7;
            if(response.HasErrors != false)
            {
                    val_7 = this._errorCallback;
                if(val_7 != null)
            {
                    val_7.Invoke(obj:  response.Errors.ToString());
            }
            
            }
            
            if(response.ScriptData == null)
            {
                    return;
            }
            
            this._eventHandler.ProcessServerData(scriptData:  new Systems.Server.ServerData(gsData:  response.ScriptData, pfData:  0));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PlayFabPurchaseSuccess(PlayFab.ClientModels.PurchaseItemResult response)
        {
            goto label_1;
            label_7:
            Systems.Analytics.AnalyticsCalls.FireEvent_PlayFabPurchaseSuccessful(item:  response.Items.Item[0]);
            0 = 1;
            label_1:
            if(0 < response.Items.Count)
            {
                goto label_7;
            }
            
            if(this._successCallback == null)
            {
                    return;
            }
            
            this._successCallback.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PlayFabPurchaseFailure(PlayFab.PlayFabError error)
        {
            if(this._errorCallback == null)
            {
                    return;
            }
            
            this._errorCallback.Invoke(obj:  error);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static IAPRequester()
        {
        
        }
    
    }

}
