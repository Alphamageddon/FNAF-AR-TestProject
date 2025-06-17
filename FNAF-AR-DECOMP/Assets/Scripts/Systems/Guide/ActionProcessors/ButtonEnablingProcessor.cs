using UnityEngine;

namespace Systems.Guide.ActionProcessors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class ButtonEnablingProcessor
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string BACK_TO_MAP = "backToMap";
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartAction(Systems.Guide.GuideNode node, Systems.Guide.GuideActionSharedContext context, bool enable)
        {
            if((System.String.op_Equality(a:  node.ActionArgs, b:  "backToMap")) == false)
            {
                    return;
            }
            
            context._masterEvents.ConfigureFabButton(buttonName:  "backToMap", desiredState:  enable, requestingEntity:  context);
        }
    
    }

}
