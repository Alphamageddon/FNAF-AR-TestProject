using UnityEngine;

namespace GameUI.CanvasFlow
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GameProject_Alpine_CanvasController_BottomBar : CanvasController
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CameraOverride = "CameraDisplayOverride";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string WorkshopOverride = "WorkshopDisplayOverride";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string MapOverride = "MapDisplayOverride";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string SplashOverride = "SplashDisplayOverride";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string InboxDisplayOverride = "InboxDisplayOverride";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string StoreDisplayOverride = "StoreDisplayOverride";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string ResultsDisplayOverride = "ResultsDisplayOverride";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<TheGame.GameDisplayData.DisplayType, string> displayIdentifierKVPs;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_UIChangeRequest(TheGame.GameDisplayData.DisplayType displayType)
        {
            this.PerformOverride(displayType:  displayType);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PerformOverride(TheGame.GameDisplayData.DisplayType displayType)
        {
            if((this.displayIdentifierKVPs.ContainsKey(key:  displayType)) == false)
            {
                    return;
            }
            
            this.PerformTransitionWithIdentifier(identifier:  this.displayIdentifierKVPs.Item[displayType]);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StartUpDisplay()
        {
            this.PerformOverride(displayType:  6);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BuildDataSets()
        {
            System.Collections.Generic.Dictionary<DisplayType, System.String> val_1 = new System.Collections.Generic.Dictionary<DisplayType, System.String>();
            if(val_1 != null)
            {
                    val_1.Add(key:  1, value:  "CameraDisplayOverride");
            }
            else
            {
                    val_1.Add(key:  1, value:  "CameraDisplayOverride");
            }
            
            val_1.Add(key:  2, value:  "WorkshopDisplayOverride");
            if(val_1 != null)
            {
                    val_1.Add(key:  0, value:  "MapDisplayOverride");
            }
            else
            {
                    val_1.Add(key:  0, value:  "MapDisplayOverride");
            }
            
            val_1.Add(key:  6, value:  "SplashDisplayOverride");
            if(val_1 != null)
            {
                    val_1.Add(key:  4, value:  "InboxDisplayOverride");
            }
            else
            {
                    val_1.Add(key:  4, value:  "InboxDisplayOverride");
            }
            
            val_1.Add(key:  3, value:  "StoreDisplayOverride");
            val_1.Add(key:  7, value:  "ResultsDisplayOverride");
            this.displayIdentifierKVPs = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Awake()
        {
            this.Awake();
            this.BuildDataSets();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Start()
        {
            this.Start();
            this._masterDomain = Master.MasterDomain.GetDomain();
            val_1.eventExposer.add_UIChangeRequest(value:  new System.Action<DisplayType>(object:  this, method:  System.Void GameUI.CanvasFlow.GameProject_Alpine_CanvasController_BottomBar::EventExposer_UIChangeRequest(TheGame.GameDisplayData.DisplayType displayType)));
            this.PerformOverride(displayType:  6);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            if(this._masterDomain == null)
            {
                    return;
            }
            
            if(this._masterDomain.eventExposer == null)
            {
                    return;
            }
            
            this._masterDomain.eventExposer.remove_UIChangeRequest(value:  new System.Action<DisplayType>(object:  this, method:  System.Void GameUI.CanvasFlow.GameProject_Alpine_CanvasController_BottomBar::EventExposer_UIChangeRequest(TheGame.GameDisplayData.DisplayType displayType)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void PrepareForStoryboardTransition(P7.CanvasFlow.StoryboardTransition transition)
        {
            if(this.PresentedCanvasController == 0)
            {
                    return;
            }
            
            this.PresentedCanvasController.DismissCanvasController(animated:  false, completion:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameProject_Alpine_CanvasController_BottomBar()
        {
        
        }
    
    }

}
