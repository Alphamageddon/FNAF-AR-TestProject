using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TutorialDataResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.TheGame.Data.TutorialData> TutorialDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string IgnoreFTUEVO;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<Game.TheGame.Data.TutorialData> callback)
        {
            this.TutorialDataReceived = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "PlayerTutorialData");
            if(val_1 == null)
            {
                    return;
            }
            
            this.ProcessTutorialData(data:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessTutorialData(Systems.Server.ServerData data)
        {
            var val_8;
            System.Collections.Generic.List<Game.TheGame.Data.TutorialEntry> val_9;
            System.Collections.Generic.List<Systems.Server.ServerData> val_2 = data.GetServerDataList(key:  "Entries");
            if(val_2 == null)
            {
                    return;
            }
            
            val_8 = val_2.Count;
            System.Collections.Generic.List<Game.TheGame.Data.TutorialEntry> val_4 = null;
            val_9 = val_4;
            val_4 = new System.Collections.Generic.List<Game.TheGame.Data.TutorialEntry>();
            .Entries = val_9;
            if()
            {
                goto label_4;
            }
            
            val_8 = 0;
            goto label_5;
            label_7:
            val_9 = (Game.TheGame.Data.TutorialData)[1152921525192695440].Entries;
            val_8 = 1;
            label_5:
            Systems.Server.ServerData val_6 = val_2.Item[1];
            val_9.Add(item:  val_6.ProcessTutorialEntry(data:  val_6));
            if((val_8 - 1) != val_8)
            {
                goto label_7;
            }
            
            label_4:
            if(this.TutorialDataReceived == null)
            {
                    return;
            }
            
            this.TutorialDataReceived.Invoke(obj:  new Game.TheGame.Data.TutorialData());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.TheGame.Data.TutorialEntry ProcessTutorialEntry(Systems.Server.ServerData data)
        {
            .TutorialKey = data.GetString(key:  "TutorialKey");
            .GuideNodeId = data.GetString(key:  "GuideNodeId");
            return (Game.TheGame.Data.TutorialEntry)new Game.TheGame.Data.TutorialEntry();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TutorialDataResponseHandler()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static TutorialDataResponseHandler()
        {
            Game.Server.TutorialDataResponseHandler.IgnoreFTUEVO = "IgnoreFTUEVO_false";
        }
    
    }

}
