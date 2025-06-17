using UnityEngine;

namespace Systems.Guide.ActionProcessors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class AllowTapProcessor
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartAction(Systems.Guide.GuideNode node, Systems.Guide.GuideActionSharedContext actionSharedContext)
        {
            Systems.Guide.GuideActionSharedContext val_12;
            string val_13;
            Systems.Guide.GuideActionSharedContext val_14;
            var val_15;
            string val_16;
            string val_17;
            string val_18;
            string val_19;
            string val_20;
            var val_21;
            IntPtr val_22;
            var val_23;
            val_12 = actionSharedContext;
            AllowTapProcessor.<>c__DisplayClass0_0 val_1 = null;
            val_13 = val_1;
            val_1 = new AllowTapProcessor.<>c__DisplayClass0_0();
            .actionSharedContext = val_12;
            if(node == null)
            {
                    val_12 = (AllowTapProcessor.<>c__DisplayClass0_0)[1152921523389279680].actionSharedContext;
            }
            
            (AllowTapProcessor.<>c__DisplayClass0_0)[1152921523389279680].actionSharedContext.overrideIsTapped = true;
            val_14 = (AllowTapProcessor.<>c__DisplayClass0_0)[1152921523389279680].actionSharedContext;
            if((val_14.TryGetScrim(scrim: out  0)) == false)
            {
                goto label_5;
            }
            
            if((GuideUtils.TryGetButton(heirarchyPath:  node.ActionArgs, button: out  0)) == false)
            {
                goto label_8;
            }
            
            val_14 = val_4.GetComponent<UnityEngine.UI.Image>();
            val_15 = 0;
            if(val_14 != 0)
            {
                goto label_12;
            }
            
            val_16 = "AllowTap target \"";
            val_17 = "\", does not have an Image component";
            goto label_13;
            label_5:
            val_18 = "AllowTapProcessor";
            val_19 = "StartAction";
            val_20 = "Could not find scrim in screen target, ignoring AllowTap action";
            goto label_16;
            label_8:
            val_16 = "Could not find AllowTap target \"";
            val_17 = "\", ignoring action";
            label_13:
            val_13 = val_16 + node.ActionArgs + val_17;
            val_20 = val_13;
            val_18 = "AllowTapProcessor";
            val_19 = "StartAction";
            label_16:
            ConsoleLogger.LogError(className:  val_18, functionName:  val_19, logString:  val_20);
            return;
            label_12:
            var val_13 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_20;
            }
            
            var val_10 = mem[282584257676847];
            var val_11 = 0;
            val_10 = val_10 + 8;
            label_22:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_21;
            }
            
            val_11 = val_11 + 1;
            val_10 = val_10 + 16;
            if(val_11 < mem[282584257676957])
            {
                goto label_22;
            }
            
            label_20:
            val_15 = 2;
            goto label_23;
            label_21:
            var val_12 = val_10;
            val_12 = val_12 + 2;
            val_13 = val_13 + val_12;
            val_21 = val_13 + 296;
            label_23:
            val_2.ConfigureHighlight(targetElement:  val_14);
            System.Action val_9 = null;
            val_22 = System.Void AllowTapProcessor.<>c__DisplayClass0_0::<StartAction>b__0();
            val_9 = new System.Action(object:  val_1, method:  val_22);
            var val_17 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_25;
            }
            
            var val_14 = mem[282584257676847];
            var val_15 = 0;
            val_14 = val_14 + 8;
            label_27:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_26;
            }
            
            val_15 = val_15 + 1;
            val_14 = val_14 + 16;
            if(val_15 < mem[282584257676957])
            {
                goto label_27;
            }
            
            label_25:
            val_22 = 3;
            goto label_28;
            label_26:
            var val_16 = val_14;
            val_16 = val_16 + 3;
            val_17 = val_17 + val_16;
            val_23 = val_17 + 296;
            label_28:
            val_2.ConfigureTapOverride(onTapAction:  val_9);
            (AllowTapProcessor.<>c__DisplayClass0_0)[1152921523389279680].actionSharedContext.overrideIsTapped = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsActionComplete(Systems.Guide.GuideNode node, Systems.Guide.GuideActionSharedContext actionSharedContext)
        {
            if(actionSharedContext != null)
            {
                    return (bool)actionSharedContext.overrideIsTapped;
            }
            
            return (bool)actionSharedContext.overrideIsTapped;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void CompleteAction(Systems.Guide.GuideNode node, Systems.Guide.GuideActionSharedContext actionSharedContext)
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            val_5 = actionSharedContext;
            Systems.Guide.UI.ITutorialScrim val_1 = 0;
            if(val_5 != null)
            {
                    actionSharedContext.overrideIsTapped = false;
            }
            else
            {
                    mem[128] = 0;
            }
            
            if((val_5.TryGetScrim(scrim: out  val_1)) == false)
            {
                    return;
            }
            
            val_5 = val_1;
            var val_6 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_8;
            }
            
            var val_3 = mem[282584257676847];
            var val_4 = 0;
            val_3 = val_3 + 8;
            label_7:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_6;
            }
            
            val_4 = val_4 + 1;
            val_3 = val_3 + 16;
            if(val_4 < mem[282584257676957])
            {
                goto label_7;
            }
            
            goto label_8;
            label_6:
            var val_5 = val_3;
            val_5 = val_5 + 2;
            val_6 = val_6 + val_5;
            val_6 = val_6 + 296;
            label_8:
            val_7 = public System.Void Systems.Guide.UI.ITutorialScrim::ConfigureHighlight(UnityEngine.UI.Image targetElement);
            val_5.ConfigureHighlight(targetElement:  0);
            var val_10 = 1179403647;
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
            val_7 = 3;
            goto label_13;
            label_11:
            var val_9 = val_7;
            val_9 = val_9 + 3;
            val_10 = val_10 + val_9;
            val_8 = val_10 + 296;
            label_13:
            val_5.ConfigureTapOverride(onTapAction:  0);
        }
    
    }

}
