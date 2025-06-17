using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ConfigDataResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.Processors.ConfigProcessor configProcessor;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.EventExposer eventExposer)
        {
            Game.Server.Processors.ConfigProcessor val_1 = new Game.Server.Processors.ConfigProcessor();
            this.configProcessor = val_1;
            val_1.Setup(eventExposer:  eventExposer);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            if((data.ContainsKey(key:  "MasterDataVersion")) == false)
            {
                    return;
            }
            
            if((data.ContainsKey(key:  "AssetDataVersion")) == false)
            {
                    return;
            }
            
            this.configProcessor.Process(data:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ConfigDataResponseHandler()
        {
        
        }
    
    }

}
