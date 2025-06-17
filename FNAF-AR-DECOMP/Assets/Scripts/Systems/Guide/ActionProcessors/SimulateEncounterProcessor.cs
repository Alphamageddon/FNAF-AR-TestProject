using UnityEngine;

namespace Systems.Guide.ActionProcessors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class SimulateEncounterProcessor
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartAction(Systems.Guide.GuideNode node, Systems.Guide.GuideActionSharedContext context, bool success)
        {
            if(context == null)
            {
                goto label_0;
            }
            
            if(success == false)
            {
                goto label_1;
            }
            
            label_4:
            context._serverTutorialRequester.RequestTutorialRewards(cpuId:  node.ActionArgs);
            return;
            label_0:
            if(success == true)
            {
                goto label_4;
            }
            
            label_1:
            context._masterEvents.OnAttackModeLost();
        }
    
    }

}
