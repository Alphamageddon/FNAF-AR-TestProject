using UnityEngine;

namespace Systems.Guide.ActionProcessors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class ScrimProcessor
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartAction(Systems.Guide.GuideNode node, Systems.Guide.GuideActionSharedContext actionSharedContext, bool visibility)
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_10 = actionSharedContext;
            val_11 = node;
            Systems.Guide.UI.ITutorialScrim val_1 = 0;
            if((val_10.TryGetScrim(scrim: out  val_1)) == false)
            {
                goto label_2;
            }
            
            if(visibility == false)
            {
                goto label_3;
            }
            
            val_12 = 1;
            val_10 = Systems.Guide.ArgParser.GetBool(args:  Systems.Guide.ArgParser.PrepArgs(args:  node.ActionArgs), index:  0, fallback:  true);
            goto label_5;
            label_2:
            ConsoleLogger.LogError(className:  "ScrimProcessor", functionName:  "StartAction", logString:  "ScrimProcessor cannot perform without a useable scrim target");
            return;
            label_3:
            val_10 = 0;
            label_5:
            val_11 = val_1;
            var val_9 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_10;
            }
            
            var val_7 = mem[282584257676847];
            var val_8 = 0;
            val_7 = val_7 + 8;
            label_12:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_11;
            }
            
            val_8 = val_8 + 1;
            val_7 = val_7 + 16;
            if(val_8 < mem[282584257676957])
            {
                goto label_12;
            }
            
            label_10:
            val_12 = 0;
            goto label_13;
            label_11:
            val_9 = val_9 + (((mem[282584257676847] + 8)) << 4);
            val_13 = val_9 + 296;
            label_13:
            val_14 = public System.Void Systems.Guide.UI.ITutorialScrim::ConfigureBlocking(bool isBlocking);
            val_11.ConfigureBlocking(isBlocking:  visibility);
            var val_13 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_15;
            }
            
            var val_10 = mem[282584257676847];
            var val_11 = 0;
            val_10 = val_10 + 8;
            label_17:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_16;
            }
            
            val_11 = val_11 + 1;
            val_10 = val_10 + 16;
            if(val_11 < mem[282584257676957])
            {
                goto label_17;
            }
            
            label_15:
            val_14 = 1;
            goto label_18;
            label_16:
            var val_12 = val_10;
            val_12 = val_12 + 1;
            val_13 = val_13 + val_12;
            val_15 = val_13 + 296;
            label_18:
            val_16 = public System.Void Systems.Guide.UI.ITutorialScrim::ConfigureMasking(bool isMasking);
            val_11.ConfigureMasking(isMasking:  val_10 & 1);
            if(visibility == true)
            {
                    return;
            }
            
            var val_17 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_21;
            }
            
            var val_14 = mem[282584257676847];
            var val_15 = 0;
            val_14 = val_14 + 8;
            label_23:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_22;
            }
            
            val_15 = val_15 + 1;
            val_14 = val_14 + 16;
            if(val_15 < mem[282584257676957])
            {
                goto label_23;
            }
            
            label_21:
            val_16 = 2;
            goto label_24;
            label_22:
            var val_16 = val_14;
            val_16 = val_16 + 2;
            val_17 = val_17 + val_16;
            val_17 = val_17 + 296;
            label_24:
            val_18 = public System.Void Systems.Guide.UI.ITutorialScrim::ConfigureHighlight(UnityEngine.UI.Image targetElement);
            val_11.ConfigureHighlight(targetElement:  0);
            var val_21 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_26;
            }
            
            var val_18 = mem[282584257676847];
            var val_19 = 0;
            val_18 = val_18 + 8;
            label_28:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_27;
            }
            
            val_19 = val_19 + 1;
            val_18 = val_18 + 16;
            if(val_19 < mem[282584257676957])
            {
                goto label_28;
            }
            
            label_26:
            val_18 = 3;
            goto label_29;
            label_27:
            var val_20 = val_18;
            val_20 = val_20 + 3;
            val_21 = val_21 + val_20;
            val_19 = val_21 + 296;
            label_29:
            val_11.ConfigureTapOverride(onTapAction:  0);
        }
    
    }

}
