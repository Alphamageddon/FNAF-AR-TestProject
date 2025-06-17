using UnityEngine;

namespace Master.Startup
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FTUEVideoStartupTask : IStartupTask
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string GO_TO_LOADING = "Loading";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string HasVideoPlayed = "HasVideoPlayed";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEvents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.Startup.StartupSequencer _parent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private P7.CanvasFlow.CanvasController _authenticationCanvasController;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.Startup.FTUEVideoStartupTask Setup(Master.EventExposer masterEvents)
        {
            this._masterEvents = masterEvents;
            masterEvents.add_PreloadEvent(value:  new System.Action<P7.CanvasFlow.CanvasController, System.String>(object:  this, method:  System.Void Master.Startup.FTUEVideoStartupTask::OnPreloadEvent(P7.CanvasFlow.CanvasController controller, string eventName)));
            return (Master.Startup.FTUEVideoStartupTask)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnPreloadEvent(P7.CanvasFlow.CanvasController controller, string eventName)
        {
            var val_2;
            if(controller == null)
            {
                    return;
            }
            
            val_2 = "start";
            if("start" == null)
            {
                    val_2 = "start";
            }
            
            if((Equals(value:  eventName)) == false)
            {
                    return;
            }
            
            this._authenticationCanvasController = controller;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Execute(Master.Startup.StartupSequencer parent)
        {
            if(this.ShouldExecute() != false)
            {
                    this._parent = parent;
                this._masterEvents.add_CompleteFTUEVideo(value:  new System.Action(object:  this, method:  System.Void Master.Startup.FTUEVideoStartupTask::OnCompleteFTUEVideo()));
                this._masterEvents.RequestGuidePopup(popupName:  "FTUE_Video");
                LoadingScreenManager.MUSIC_MULTIPLE = 1.401298E-45f;
                UnityEngine.PlayerPrefs.SetString(key:  "HasVideoPlayed", value:  "y");
                return;
            }
            
            this._authenticationCanvasController.PerformTransitionWithIdentifier(identifier:  "Loading");
            parent.CompleteTask(task:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnCompleteFTUEVideo()
        {
            LoadingScreenManager.MUSIC_MULTIPLE = 0f;
            this._authenticationCanvasController.PerformTransitionWithIdentifier(identifier:  "Loading");
            this._parent.CompleteTask(task:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ShouldExecute()
        {
            bool val_1 = UnityEngine.PlayerPrefs.HasKey(key:  "HasVideoPlayed");
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._parent = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetSize()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetName()
        {
            return "FTUEVideo";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetPartialProgress()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FTUEVideoStartupTask()
        {
        
        }
    
    }

}
