using UnityEngine;

namespace SharedTechAssets.Scripts.Utilities
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ARCameraConfigurator_SROptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ARCameraConfigurator _configurator;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int CurrentConfigIdx { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ARCameraConfigurator_SROptions(ARCameraConfigurator configurator)
        {
            this._configurator = configurator;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_CurrentConfigIdx()
        {
            if(this._configurator != null)
            {
                    return (int)this._configurator.configIdx;
            }
            
            return (int)this._configurator.configIdx;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_CurrentConfigIdx(int value)
        {
            this._configurator.configIdx = value;
            this._configurator.UpdateConfig();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowConfigs()
        {
            this._configurator.PrintConfigs();
        }
    
    }

}
