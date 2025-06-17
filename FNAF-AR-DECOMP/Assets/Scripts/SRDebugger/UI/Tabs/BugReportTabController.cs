using UnityEngine;

namespace SRDebugger.UI.Tabs
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BugReportTabController : SRMonoBehaviourEx, IEnableTab
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.UI.Other.BugReportSheetController BugReportSheetPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.RectTransform Container;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsEnabled { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsEnabled()
        {
            if(SRDebugger.Settings.Instance != null)
            {
                    return (bool)val_1._enableBugReporter;
            }
            
            return (bool)val_1._enableBugReporter;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Start()
        {
            this.Start();
            SRDebugger.UI.Other.BugReportSheetController val_1 = SRInstantiate.Instantiate<SRDebugger.UI.Other.BugReportSheetController>(prefab:  this.BugReportSheetPrefab);
            val_1.IsCancelButtonEnabled = false;
            val_1.TakingScreenshot = new System.Action(object:  this, method:  System.Void SRDebugger.UI.Tabs.BugReportTabController::TakingScreenshot());
            System.Action val_3 = new System.Action(object:  this, method:  System.Void SRDebugger.UI.Tabs.BugReportTabController::ScreenshotComplete());
            if(val_1 != null)
            {
                    val_1.ScreenshotComplete = val_3;
            }
            else
            {
                    mem[136] = val_3;
            }
            
            val_1.CachedTransform.SetParent(parent:  this.Container, worldPositionStays:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TakingScreenshot()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            SRDebug.Instance.HideDebugPanel();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ScreenshotComplete()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            SRDebug.Instance.ShowDebugPanel(requireEntryCode:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BugReportTabController()
        {
        
        }
    
    }

}
