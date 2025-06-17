using UnityEngine;

namespace Systems.Guide.ActionProcessors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class EventResolutionMappingProcessor
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartAction(Systems.Guide.GuideNode node)
        {
            Systems.Guide.NodeResolutionData val_1;
            if(node != null)
            {
                    val_1 = node.ResolutionData;
            }
            else
            {
                    val_1 = 62590012;
            }
            
            mem[62590028] = node.EventData.Index;
        }
    
    }

}
