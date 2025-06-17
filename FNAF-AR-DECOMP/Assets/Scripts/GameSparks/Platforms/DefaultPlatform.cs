using UnityEngine;

namespace GameSparks.Platforms
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DefaultPlatform : PlatformBase
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override GameSparks.IGameSparksTimer GetTimer()
        {
            return (GameSparks.IGameSparksTimer)new GameSparks.Core.GameSparksTimer();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string MakeHmac(string stringToHmac, string secret)
        {
            return GameSparks.Core.GameSparksUtil.MakeHmac(strToHmac:  stringToHmac, secret:  secret);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override GameSparks.IGameSparksWebSocket GetSocket(string url, System.Action<string> messageReceived, System.Action closed, System.Action opened, System.Action<string> error)
        {
            GameSparks.GameSparksWebSocket val_1 = new GameSparks.GameSparksWebSocket();
            val_1.Initialize(url:  url, onMessage:  messageReceived, onClose:  closed, onOpen:  opened, onError:  error);
            return (GameSparks.IGameSparksWebSocket)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DefaultPlatform()
        {
        
        }
    
    }

}
