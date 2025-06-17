using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SellModsRequester : AbstractRequester
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SellModsRequester(Game.Server.LogEventHandler eventHandler)
        {
            val_1 = new System.Object();
            mem[1152921525170334704] = eventHandler;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SellMods(System.Collections.Generic.Dictionary<Game.ItemDefinition.Data.DataDefinitions.ModData, int> modTable)
        {
            GameSparks.Api.Requests.LogEventRequest val_1 = new GameSparks.Api.Requests.LogEventRequest();
            GameSparks.Api.Requests.LogEventRequest val_4 = val_1.SetEventAttribute(key:  "mods", value:  val_1.SetEventKey(eventKey:  "SELL_MODS").ConvertTableToRequest(table:  modTable));
            this.Send(request:  val_1, successCallback:  new System.Action<Systems.Server.ServerResponse>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullResponse(Systems.Server.ServerResponse response)), errorCallback:  new System.Action<Systems.Server.ServerData>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullErrorResponse(Systems.Server.ServerData serverData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameSparks.Core.GSRequestData ConvertTableToRequest(System.Collections.Generic.Dictionary<Game.ItemDefinition.Data.DataDefinitions.ModData, int> table)
        {
            GameSparks.Core.GSRequestData val_1 = new GameSparks.Core.GSRequestData();
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = table.Keys.GetEnumerator();
            label_7:
            if(((-911046664) & 1) == 0)
            {
                    return val_1;
            }
            
            GameSparks.Core.GSRequestData val_6 = val_1.AddNumber(paramName:  val_4._masterDomain, value:  table.Item[0.emailUIDataHandler]);
            goto label_7;
        }
    
    }

}
