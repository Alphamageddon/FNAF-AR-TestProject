using UnityEngine;

namespace Systems.Guide
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GuideSrOptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.ServerDomain _serverDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Guide.GuideNodeDriver _nodeDriver;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _storedNodeId;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SelectActivatableNode { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GuideSrOptions(Game.Server.ServerDomain serverDomain, Systems.Guide.GuideNodeDriver nodeDriver)
        {
            val_1 = new System.Object();
            this._serverDomain = serverDomain;
            this._nodeDriver = val_1;
            this._storedNodeId = UnityEngine.PlayerPrefs.GetString(key:  "GuideSROptions_ActivateableNodeId");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowGuideVisualizer()
        {
            Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
            val_1.eventExposer.OnGuideVisualizerPresent();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_SelectActivatableNode()
        {
            return (string)this._storedNodeId;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_SelectActivatableNode(string value)
        {
            this._storedNodeId = value;
            UnityEngine.PlayerPrefs.SetString(key:  "GuideSROptions_ActivateableNodeId", value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TriggerActivatableNode()
        {
            this._nodeDriver.LoadNode(node:  Systems.Guide.GuideFactory.GenerateNode(uid:  this._storedNodeId));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClearTutorial()
        {
            TheGame.Domain val_2 = Master.MasterDomain.GetDomain().theGameDomain;
            val_2.cameraPermissionGovernor.ActivatePermissions(success:  0);
            Server.LoginDomain val_5 = Master.MasterDomain.GetDomain().theGameDomain.loginDomain;
            val_5.pushNotificationsInitializer.RegisterForPushNotifications();
            this._nodeDriver.ClearAllTutorials();
            this._serverDomain.tutorialRequester.ClearTutorial();
            this._serverDomain.tutorialRequester.ClearFtueFeatureFlags();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ResetPlayerTutorial()
        {
            this._serverDomain.tutorialRequester.ResetToInitialTutorial();
            this._serverDomain.tutorialRequester.ResetToInitialFtueFeatureFlags();
        }
    
    }

}
