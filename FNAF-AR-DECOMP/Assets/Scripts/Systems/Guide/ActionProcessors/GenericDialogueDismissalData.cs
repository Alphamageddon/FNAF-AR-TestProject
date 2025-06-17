using UnityEngine;

namespace Systems.Guide.ActionProcessors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GenericDialogueDismissalData : IActionData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool wasDismissed;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GenericDialogueDismissalData()
        {
        
        }
    
    }

}
