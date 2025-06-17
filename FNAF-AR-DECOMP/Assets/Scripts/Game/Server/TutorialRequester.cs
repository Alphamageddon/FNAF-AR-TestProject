using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TutorialRequester : AbstractRequester
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string STARTING_GUIDE_NODE = "FTUE_start_from_server";
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TutorialRequester(Game.Server.LogEventHandler eventHandler)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RequestTutorialRewards(string cpuId)
        {
            GameSparks.Api.Requests.LogEventRequest val_1 = new GameSparks.Api.Requests.LogEventRequest();
            if(val_1 != null)
            {
                    GameSparks.Api.Requests.LogEventRequest val_2 = val_1.SetEventKey(eventKey:  "AWARD_UNIQUE_REWARDS");
            }
            else
            {
                    GameSparks.Api.Requests.LogEventRequest val_3 = val_1.SetEventKey(eventKey:  "AWARD_UNIQUE_REWARDS");
            }
            
            GameSparks.Api.Requests.LogEventRequest val_4 = val_1.SetEventAttribute(key:  "cpuId", value:  cpuId);
            this.Send(request:  val_1, successCallback:  new System.Action<Systems.Server.ServerResponse>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullResponse(Systems.Server.ServerResponse response)), errorCallback:  new System.Action<Systems.Server.ServerData>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullErrorResponse(Systems.Server.ServerData serverData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SaveTutorialStep(string tutorialKey, string guideNodeId)
        {
            System.Collections.Generic.List<System.Tuple<System.String, System.String>> val_1 = new System.Collections.Generic.List<System.Tuple<System.String, System.String>>();
            val_1.Add(item:  new System.Tuple<System.String, System.String>(item1:  tutorialKey, item2:  guideNodeId));
            this.SaveTutorialSteps(tutorialKeyGuideNodePairs:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SaveTutorialSteps(System.Collections.Generic.List<System.Tuple<string, string>> tutorialKeyGuideNodePairs)
        {
            var val_16;
            GameSparks.Api.Requests.LogEventRequest val_1 = new GameSparks.Api.Requests.LogEventRequest();
            GameSparks.Api.Requests.LogEventRequest val_2 = val_1.SetEventKey(eventKey:  "SAVE_TUTORIAL_STEP");
            System.Collections.Generic.List<GameSparks.Core.GSData> val_3 = new System.Collections.Generic.List<GameSparks.Core.GSData>();
            val_16 = 0;
            goto label_2;
            label_20:
            System.Tuple<System.String, System.String> val_4 = tutorialKeyGuideNodePairs.Item[0];
            GameSparks.Core.GSData val_5 = new GameSparks.Core.GSData();
            string val_7 = val_4.Item1;
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_5.BaseData.set_Item(key:  this, value:  val_1);
            string val_10 = val_4.Item2;
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_5.BaseData.set_Item(key:  this, value:  val_1);
            val_3.Add(item:  val_5);
            val_16 = 1;
            label_2:
            if(val_16 < tutorialKeyGuideNodePairs.Count)
            {
                goto label_20;
            }
            
            GameSparks.Api.Requests.LogEventRequest val_13 = val_1.SetEventAttribute(key:  "steps", value:  val_3);
            mem[1152921525168950976].Send(request:  val_1, successCallback:  new System.Action<Systems.Server.ServerResponse>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullResponse(Systems.Server.ServerResponse response)), errorCallback:  new System.Action<UnityEngine.U2D.SpriteAtlas>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullErrorResponse(Systems.Server.ServerData serverData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetFeatureFlags(string tutorialKey, bool allowAlerts, bool allowSpawns, bool allowEssence, bool allowScaryMood, bool allowTopBar, bool allowStaySafe, bool resultsReturnToCamera, bool allowScreenSleep)
        {
            bool val_1 = allowAlerts;
            bool val_2 = allowSpawns;
            bool val_3 = allowEssence;
            bool val_4 = allowScaryMood;
            bool val_5 = allowTopBar;
            bool val_6 = allowStaySafe;
            bool val_7 = resultsReturnToCamera;
            TutorialRequester.FeatureFlagEntryObject val_9 = new TutorialRequester.FeatureFlagEntryObject();
            if(val_9 != null)
            {
                    .allowAlerts = val_1;
                .allowSpawns = val_2;
                .allowEssence = val_3;
                .allowScaryMood = val_5;
                .allowTopBar = val_4;
                .allowStaySafe = val_6;
                .tutorialKey = tutorialKey;
                .allowResultsReturnToCamera = val_7;
            }
            else
            {
                    mem[16] = tutorialKey;
                mem[24] = val_1;
                .allowSpawns = val_2;
                mem[32] = val_3;
                .allowScaryMood = val_5;
                mem[40] = val_4;
                .allowStaySafe = val_6;
                mem[48] = val_7;
            }
            
            .allowScreenSleep = allowScreenSleep;
            GameSparks.Api.Requests.LogEventRequest val_12 = new GameSparks.Api.Requests.LogEventRequest();
            if(val_12 != null)
            {
                    GameSparks.Api.Requests.LogEventRequest val_13 = val_12.SetEventKey(eventKey:  "SET_FEATURE_FLAGS");
            }
            else
            {
                    GameSparks.Api.Requests.LogEventRequest val_14 = val_12.SetEventKey(eventKey:  "SET_FEATURE_FLAGS");
            }
            
            GameSparks.Api.Requests.LogEventRequest val_15 = val_12.SetEventAttribute(key:  "entryObject", value:  new GameSparks.Core.GSRequestData(jsonString:  UnityEngine.JsonUtility.ToJson(obj:  val_9)));
            mem[1152921525169157424].Send(request:  val_12, successCallback:  new System.Action<Systems.Server.ServerResponse>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullResponse(Systems.Server.ServerResponse response)), errorCallback:  new System.Action<Systems.Server.ServerData>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullErrorResponse(Systems.Server.ServerData serverData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ResetToInitialFtueFeatureFlags()
        {
            this.SetFeatureFlags(tutorialKey:  "FTUE", allowAlerts:  false, allowSpawns:  false, allowEssence:  false, allowScaryMood:  false, allowTopBar:  false, allowStaySafe:  false, resultsReturnToCamera:  false, allowScreenSleep:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClearFtueFeatureFlags()
        {
            this.SetFeatureFlags(tutorialKey:  "FTUE", allowAlerts:  true, allowSpawns:  true, allowEssence:  true, allowScaryMood:  true, allowTopBar:  true, allowStaySafe:  true, resultsReturnToCamera:  true, allowScreenSleep:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ResetToInitialTutorial()
        {
            this.SaveTutorialStep(tutorialKey:  "FTUE", guideNodeId:  "FTUE_start_from_server");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClearTutorial()
        {
            GameSparks.Api.Requests.LogEventRequest val_1 = new GameSparks.Api.Requests.LogEventRequest();
            GameSparks.Api.Requests.LogEventRequest val_2 = val_1.SetEventKey(eventKey:  "CLEAR_ALL_TUTORIAL_STEPS");
            this.Send(request:  val_1, successCallback:  new System.Action<Systems.Server.ServerResponse>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullResponse(Systems.Server.ServerResponse response)), errorCallback:  new System.Action<Systems.Server.ServerData>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullErrorResponse(Systems.Server.ServerData serverData)));
        }
    
    }

}
