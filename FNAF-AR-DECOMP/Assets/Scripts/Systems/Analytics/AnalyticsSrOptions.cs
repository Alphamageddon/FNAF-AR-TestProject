using UnityEngine;

namespace Systems.Analytics
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AnalyticsSrOptions
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowAnalyticsVisualizer()
        {
            Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
            val_1.eventExposer.OnAnalyticsVisualizerPresent();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnalyticsSrOptions()
        {
        
        }
    
    }

}
