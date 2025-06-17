using UnityEngine;

namespace Systems.Analytics
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AnalyticsVisualizerPresenter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnalyticsVisualizer _activeVisualizer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Analytics.AnalyticsHistory _history;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _eventExposer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.EventExposer eventExposer, Systems.Analytics.AnalyticsHistory history)
        {
            var val_4;
            this._history = history;
            this._eventExposer = eventExposer;
            Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
            val_1.eventExposer.add_AnalyticsVisualizerPresent(value:  new System.Action(object:  this, method:  public System.Void Systems.Analytics.AnalyticsVisualizerPresenter::Present()));
            val_4 = null;
            val_4 = null;
            if((UnityEngine.PlayerPrefs.GetInt(key:  AnalyticsVisualizer.PlayerPrefsStartGameOpenKey, defaultValue:  0)) == 0)
            {
                    return;
            }
            
            this.Present();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            if(this._eventExposer != null)
            {
                    this._eventExposer.remove_AnalyticsVisualizerPresent(value:  new System.Action(object:  this, method:  public System.Void Systems.Analytics.AnalyticsVisualizerPresenter::Present()));
            }
            
            this._history = 0;
            this._eventExposer = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Present()
        {
            if(this._activeVisualizer != 0)
            {
                    return;
            }
            
            UnityEngine.Transform val_3 = UnityEngine.Object.FindObjectOfType<GameUI.DialogHandler_Shared>().AnalyticsVisualizerCanvas;
            val_3.gameObject.SetActive(value:  true);
            AnalyticsVisualizer val_5 = val_3.GetComponent<AnalyticsVisualizer>();
            if(val_5 != null)
            {
                    val_5.InjectHistory(history:  this._history);
            }
            else
            {
                    val_5.InjectHistory(history:  this._history);
            }
            
            val_5.Show();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnalyticsVisualizerPresenter()
        {
        
        }
    
    }

}
