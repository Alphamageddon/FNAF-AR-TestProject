using UnityEngine;

namespace Systems.Guide.ActionProcessors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class SaveStepProcessor
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartAction(Systems.Guide.GuideNode node, Systems.Guide.GuideActionSharedContext actionSharedContext)
        {
            var val_8;
            System.String[] val_1 = Systems.Guide.ArgParser.PrepArgs(args:  node.ActionArgs);
            if((val_1.Length & 1) != 0)
            {
                goto label_3;
            }
            
            System.Collections.Generic.List<System.Tuple<System.String, System.String>> val_2 = new System.Collections.Generic.List<System.Tuple<System.String, System.String>>();
            if(val_1.Length < 1)
            {
                goto label_4;
            }
            
            val_8 = 0;
            int val_8 = 0;
            do
            {
                string val_3 = Systems.Guide.ArgParser.GetString(args:  val_1, index:  0, fallback:  "error");
                val_8 = val_8 + 1;
                string val_4 = Systems.Guide.ArgParser.GetString(args:  val_1, index:  val_8, fallback:  "");
                val_2.Add(item:  new System.Tuple<System.String, System.String>(item1:  val_3, item2:  val_4));
                if((System.String.op_Equality(a:  val_3, b:  "FTUE")) != false)
            {
                    val_8 = val_8 | (System.String.op_Equality(a:  val_4, b:  System.String.alignConst));
            }
            
                val_8 = val_8 + 1;
            }
            while(val_8 < val_1.Length);
            
            goto label_8;
            label_3:
            ConsoleLogger.LogError(className:  "SaveStepProcessor", functionName:  "StartAction", logString:  "Expected an even number of arguments for SaveStep action");
            return;
            label_4:
            val_8 = 0;
            label_8:
            actionSharedContext + 40.SaveTutorialSteps(tutorialKeyGuideNodePairs:  val_2);
            if((val_8 & 1) == 0)
            {
                    return;
            }
            
            if((actionSharedContext + 16) == 0)
            {
                    return;
            }
            
            actionSharedContext + 16.OnFTUEComplete();
        }
    
    }

}
