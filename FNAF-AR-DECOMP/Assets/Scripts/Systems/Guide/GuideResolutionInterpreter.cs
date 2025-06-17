using UnityEngine;

namespace Systems.Guide
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class GuideResolutionInterpreter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ResolveNode(Systems.Guide.GuideNode node, Systems.Guide.GuideNodeDriver instance)
        {
            if(node.Resolution == 3)
            {
                goto label_2;
            }
            
            if(node.Resolution == 2)
            {
                goto label_3;
            }
            
            if(node.Resolution != 1)
            {
                    return;
            }
            
            instance.LoadNode(node:  Systems.Guide.GuideFactory.GenerateNode(uid:  node.ResolutionArgs));
            return;
            label_2:
            Systems.Guide.GuideResolutionInterpreter.ResolveSwitch(parent:  node, instance:  instance);
            return;
            label_3:
            Systems.Guide.GuideResolutionInterpreter.ResolveMulti(parent:  node, instance:  instance);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void ResolveSwitch(Systems.Guide.GuideNode parent, Systems.Guide.GuideNodeDriver instance)
        {
            char[] val_1 = new char[1];
            val_1[0] = 32;
            instance.LoadNode(node:  Systems.Guide.GuideFactory.GenerateNode(uid:  parent.ResolutionArgs.Split(separator:  val_1)[parent.ResolutionData.Index]));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ValidateActionControlsSwitch(Systems.Guide.GuideNode node)
        {
            var val_2;
            if(node.Resolution == 3)
            {
                    Systems.Guide.GuideAction val_2 = node.Action;
                val_2 = val_2 | 2;
                var val_1 = (val_2 == 31) ? 1 : 0;
                return (bool)val_2;
            }
            
            val_2 = 1;
            return (bool)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void ResolveMulti(Systems.Guide.GuideNode parent, Systems.Guide.GuideNodeDriver instance)
        {
            var val_8;
            int val_9;
            var val_10;
            var val_11;
            char[] val_1 = new char[1];
            val_1[0] = 32;
            val_8 = parent.ResolutionArgs.Split(separator:  val_1);
            val_9 = val_2.Length;
            int val_3 = val_9 & 4294967295;
            Systems.Guide.GuideNode[] val_4 = new Systems.Guide.GuideNode[0];
            if(val_9 < 1)
            {
                    return;
            }
            
            var val_10 = 0;
            val_10 = 0;
            label_20:
            val_11 = 0;
            goto label_11;
            label_16:
            val_11 = 1;
            label_11:
            if(val_11 < val_5.Events.Length)
            {
                goto label_16;
            }
            
            val_10 = val_10 + 1;
            val_4[val_10] = Systems.Guide.GuideFactory.GenerateNode(uid:  val_8[val_10]);
            if(val_10 != val_3)
            {
                goto label_20;
            }
            
            if(((val_5.Events[0] == 0) ? (val_10 + 1) : (val_10)) <= 1)
            {
                    val_9 = instance;
                if(val_9 < 1)
            {
                    return;
            }
            
                do
            {
                val_9.LoadNode(node:  1152921509376470416);
                val_8 = 0 + 1;
            }
            while(val_3 != val_8);
            
                return;
            }
            
            ConsoleLogger.LogError(className:  "GuideResolutionInterpreter", functionName:  "ResolveMulti", logString:  "Node " + parent + 16(parent + 16) + " contains multiple resolution nodes with Immediate in the event list.");
        }
    
    }

}
