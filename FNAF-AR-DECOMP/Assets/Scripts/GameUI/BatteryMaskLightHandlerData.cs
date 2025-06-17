using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BatteryMaskLightHandlerData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.SurgeMechanicUIHandler surgeMechanicUIHandler;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BatteryMaskLightHandlerData(GameUI.SurgeMechanicUIHandler surgeMechanicUIHandler)
        {
            this.surgeMechanicUIHandler = surgeMechanicUIHandler;
        }
    
    }

}
