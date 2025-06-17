using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SurgeMechanicUIHandlerData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.EventExposer eventExposer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SurgeMechanicUIHandlerData(Master.EventExposer eventExposer)
        {
            this.eventExposer = eventExposer;
        }
    
    }

}
