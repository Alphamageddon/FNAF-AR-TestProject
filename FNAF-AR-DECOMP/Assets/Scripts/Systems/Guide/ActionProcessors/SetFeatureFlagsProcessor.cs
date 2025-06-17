using UnityEngine;

namespace Systems.Guide.ActionProcessors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class SetFeatureFlagsProcessor
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartAction(Systems.Guide.GuideNode node, Systems.Guide.GuideActionSharedContext actionSharedContext)
        {
            System.String[] val_1 = Systems.Guide.ArgParser.PrepArgs(args:  node.ActionArgs);
            actionSharedContext._serverTutorialRequester.SetFeatureFlags(tutorialKey:  Systems.Guide.ArgParser.GetString(args:  val_1, index:  0, fallback:  "error"), allowAlerts:  Systems.Guide.ArgParser.GetBool(args:  val_1, index:  1, fallback:  true), allowSpawns:  Systems.Guide.ArgParser.GetBool(args:  val_1, index:  2, fallback:  true), allowEssence:  Systems.Guide.ArgParser.GetBool(args:  val_1, index:  3, fallback:  true), allowScaryMood:  Systems.Guide.ArgParser.GetBool(args:  val_1, index:  4, fallback:  true), allowTopBar:  Systems.Guide.ArgParser.GetBool(args:  val_1, index:  5, fallback:  true), allowStaySafe:  Systems.Guide.ArgParser.GetBool(args:  val_1, index:  6, fallback:  true), resultsReturnToCamera:  Systems.Guide.ArgParser.GetBool(args:  val_1, index:  7, fallback:  true), allowScreenSleep:  Systems.Guide.ArgParser.GetBool(args:  val_1, index:  8, fallback:  true));
        }
    
    }

}
