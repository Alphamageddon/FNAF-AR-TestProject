using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SetEndoskeletonConfigRequester : AbstractRequester
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SetEndoskeletonConfigRequester(Game.Server.LogEventHandler eventHandler)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetEndoskeletonConfig(int slot, Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData endoskeleton)
        {
            GameSparks.Api.Requests.LogEventRequest val_1 = new GameSparks.Api.Requests.LogEventRequest();
            if(val_1 != null)
            {
                    GameSparks.Api.Requests.LogEventRequest val_2 = val_1.SetEventKey(eventKey:  "SET_ENDOSKELETON_CONFIG_V2");
            }
            else
            {
                    GameSparks.Api.Requests.LogEventRequest val_3 = val_1.SetEventKey(eventKey:  "SET_ENDOSKELETON_CONFIG_V2");
            }
            
            GameSparks.Api.Requests.LogEventRequest val_6 = val_1.SetEventAttribute(key:  "config", value:  val_1.SetEventAttribute(key:  "slot", value:  slot).ConvertEndoskeletonToGSRequestData(endoskeleton:  endoskeleton));
            this.Send(request:  val_1, successCallback:  new System.Action<Systems.Server.ServerResponse>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullResponse(Systems.Server.ServerResponse response)), errorCallback:  new System.Action<Systems.Server.ServerData>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullErrorResponse(Systems.Server.ServerData serverData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameSparks.Core.GSRequestData ConvertEndoskeletonToGSRequestData(Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData endoskeleton)
        {
            GameSparks.Core.GSRequestData val_1 = new GameSparks.Core.GSRequestData();
            GameSparks.Core.GSRequestData val_2 = val_1.AddStringList(paramName:  "mods", child:  endoskeleton.mods);
            GameSparks.Core.GSRequestData val_3 = val_1.AddString(paramName:  "cpu", value:  endoskeleton.cpu);
            GameSparks.Core.GSRequestData val_4 = val_1.AddString(paramName:  "plushSuit", value:  endoskeleton.plushSuit);
            GameSparks.Core.GSRequestData val_5 = val_1.AddNumber(paramName:  "essence", value:  endoskeleton.numEssence);
            return val_1;
        }
    
    }

}
