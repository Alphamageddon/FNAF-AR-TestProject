using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayerGoodsResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<System.Collections.Generic.Dictionary<string, int>> PlayerGoodsUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Func<System.Collections.Generic.List<Systems.Server.ServerData>, System.Collections.Generic.Dictionary<string, int>> ProcessPlayerGoods;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<System.Collections.Generic.Dictionary<string, int>> callback, System.Func<System.Collections.Generic.List<Systems.Server.ServerData>, System.Collections.Generic.Dictionary<string, int>> processor)
        {
            this.PlayerGoodsUpdated = callback;
            this.ProcessPlayerGoods = processor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            System.Collections.Generic.List<Systems.Server.ServerData> val_1 = data.GetServerDataList(key:  "Goods");
            if(val_1 == null)
            {
                    return;
            }
            
            this.HandleResponse(data:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleResponse(System.Collections.Generic.List<Systems.Server.ServerData> data)
        {
            if(this.PlayerGoodsUpdated == null)
            {
                    return;
            }
            
            this.PlayerGoodsUpdated.Invoke(obj:  this.ProcessPlayerGoods.Invoke(arg:  data));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayerGoodsResponseHandler()
        {
        
        }
    
    }

}
