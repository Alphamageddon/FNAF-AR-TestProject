using UnityEngine;

namespace SRDebugger
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class AutoInitialize
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void OnLoad()
        {
            if(SRDebugger.Settings.Instance.IsEnabled == false)
            {
                    return;
            }
            
            if(SRDebugger.Settings.Instance.AutoLoad == false)
            {
                    return;
            }
            
            SRDebug.Init();
        }
    
    }

}
