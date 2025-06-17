using UnityEngine;

namespace Systems.Guide.ActionProcessors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class EmulateButtonProcessor
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartAction(Systems.Guide.GuideNode node, Systems.Guide.GuideActionSharedContext actionSharedContext)
        {
            string val_5;
            if((GuideUtils.TryGetButton(heirarchyPath:  node.ActionArgs, button: out  0)) != false)
            {
                    val_5 = val_1.onClick;
                val_5.Invoke();
                return;
            }
            
            val_5 = "Could not find EmulateButton target \"" + node.ActionArgs + "\", ignoring action";
            ConsoleLogger.LogError(className:  "EmulateButtonProcessor", functionName:  "StartAction", logString:  val_5);
        }
    
    }

}
