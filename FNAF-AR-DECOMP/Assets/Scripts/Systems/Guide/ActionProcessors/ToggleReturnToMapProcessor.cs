using UnityEngine;

namespace Systems.Guide.ActionProcessors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class ToggleReturnToMapProcessor
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartAction(Systems.Guide.GuideNode node, Systems.Guide.GuideActionSharedContext actionSharedContext)
        {
            mem2[0] = Systems.Guide.ArgParser.GetBool(args:  Systems.Guide.ArgParser.PrepArgs(args:  node.ActionArgs), index:  0, fallback:  true);
        }
    
    }

}
