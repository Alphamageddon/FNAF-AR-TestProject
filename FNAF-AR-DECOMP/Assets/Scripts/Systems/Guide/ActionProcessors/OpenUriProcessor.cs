using UnityEngine;

namespace Systems.Guide.ActionProcessors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class OpenUriProcessor
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartAction(Systems.Guide.GuideNode node, Systems.Guide.GuideActionSharedContext actionSharedContext)
        {
            string val_2 = Systems.Guide.ArgParser.GetString(args:  Systems.Guide.ArgParser.PrepArgs(args:  node.ActionArgs), index:  0, fallback:  System.String.alignConst);
            if((System.String.IsNullOrEmpty(value:  val_2)) == true)
            {
                    return;
            }
            
            string val_4 = actionSharedContext._keyValueAccess.GetString(key:  val_2, fallback:  System.String.alignConst);
            actionSharedContext = val_4;
            if((System.String.IsNullOrEmpty(value:  val_4)) != false)
            {
                    return;
            }
            
            UnityEngine.Application.OpenURL(url:  actionSharedContext);
        }
    
    }

}
