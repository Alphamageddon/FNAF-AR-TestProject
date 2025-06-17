using UnityEngine;

namespace Systems.Guide
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GuideVisualizerPresenter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Guide.GuideNodeDriver _driver;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GuideVisualizer _activeVisualizer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Systems.Guide.GuideNodeDriver driver)
        {
            var val_4;
            this._driver = driver;
            Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
            val_1.eventExposer.add_GuideVisualizerPresent(value:  new System.Action(object:  this, method:  public System.Void Systems.Guide.GuideVisualizerPresenter::Present()));
            val_4 = null;
            val_4 = null;
            if((UnityEngine.PlayerPrefs.GetInt(key:  GuideVisualizer.PlayerPrefsStartGameOpenKey, defaultValue:  0)) == 0)
            {
                    return;
            }
            
            this.Present();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            if(Master.MasterDomain.GetDomain() != 0)
            {
                    Master.MasterDomain val_3 = Master.MasterDomain.GetDomain();
                if(val_3.eventExposer != null)
            {
                    Master.MasterDomain val_4 = Master.MasterDomain.GetDomain();
                val_4.eventExposer.remove_GuideVisualizerPresent(value:  new System.Action(object:  this, method:  public System.Void Systems.Guide.GuideVisualizerPresenter::Present()));
            }
            
            }
            
            this._driver = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Present()
        {
            if(this._activeVisualizer != 0)
            {
                    return;
            }
            
            UnityEngine.Transform val_3 = UnityEngine.Object.FindObjectOfType<GameUI.DialogHandler_Shared>().GuideVisualizerCanvas;
            val_3.gameObject.SetActive(value:  true);
            GuideVisualizer val_5 = val_3.GetComponent<GuideVisualizer>();
            if(val_5 != null)
            {
                    val_5.ChangeDriver(driver:  this._driver);
            }
            else
            {
                    val_5.ChangeDriver(driver:  this._driver);
            }
            
            val_5.Show();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GuideVisualizerPresenter()
        {
        
        }
    
    }

}
