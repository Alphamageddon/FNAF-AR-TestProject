using UnityEngine;

namespace Systems.Guide.ActionProcessors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class OpenPlatformUriProcessor
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartAction(Systems.Guide.GuideNode node, Systems.Guide.GuideActionSharedContext actionSharedContext)
        {
            string val_3 = actionSharedContext._keyValueAccess.GetString(key:  Systems.Guide.ArgParser.GetString(args:  Systems.Guide.ArgParser.PrepArgs(args:  node.ActionArgs), index:  1, fallback:  System.String.alignConst), fallback:  System.String.alignConst);
            if((System.String.IsNullOrEmpty(value:  val_3)) != false)
            {
                    return;
            }
            
            UnityEngine.Application.OpenURL(url:  val_3);
        }
    
    }

}
