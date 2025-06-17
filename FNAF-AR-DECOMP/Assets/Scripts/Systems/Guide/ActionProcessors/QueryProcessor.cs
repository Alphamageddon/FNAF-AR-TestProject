using UnityEngine;

namespace Systems.Guide.ActionProcessors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class QueryProcessor
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartAction(Systems.Guide.GuideNode node, Systems.Guide.GuideActionSharedContext actionSharedContext)
        {
            var val_12;
            Systems.Guide.ActionProcessors.QueryData val_13;
            Systems.Guide.GuideNode val_14;
            QueryProcessor.<>c__DisplayClass0_0 val_1 = new QueryProcessor.<>c__DisplayClass0_0();
            if(val_1 != null)
            {
                    val_12 = val_1;
                .node = node;
            }
            else
            {
                    val_12 = 56;
                mem[56] = node;
            }
            
            .actionSharedContext = actionSharedContext;
            Systems.Guide.ActionProcessors.QueryData val_2 = new Systems.Guide.ActionProcessors.QueryData();
            if(val_1 != null)
            {
                    val_13 = val_1;
                .actionData = val_2;
            }
            else
            {
                    val_13 = 64;
                mem[64] = val_2;
                val_14 = mem[56];
            }
            
            mem2[0] = val_13;
            System.String[] val_3 = Systems.Guide.ArgParser.PrepArgs(args:  node + 72);
            .titleKey = Systems.Guide.ArgParser.GetString(args:  val_3, index:  0, fallback:  "Undefined Title");
            .messageKey = Systems.Guide.ArgParser.GetString(args:  val_3, index:  1, fallback:  "Undefined Message");
            .yesButtonKey = Systems.Guide.ArgParser.GetString(args:  val_3, index:  2, fallback:  "Undefined Yes Button");
            .noButtonKey = Systems.Guide.ArgParser.GetString(args:  val_3, index:  3, fallback:  "Undefined No Button");
            .neutralButtonKey = Systems.Guide.ArgParser.GetString(args:  val_3, index:  4, fallback:  System.String.alignConst);
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  val_1, method:  System.Void QueryProcessor.<>c__DisplayClass0_0::<StartAction>b__0(Game.Localization.ILocalization localization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsActionComplete(Systems.Guide.GuideNode node)
        {
            return false;
        }
    
    }

}
