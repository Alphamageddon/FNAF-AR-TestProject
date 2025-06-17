using UnityEngine;

namespace Systems.Guide.ActionProcessors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class ShowGenericDialogueProcessor
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartAction(Systems.Guide.GuideNode node, Systems.Guide.GuideActionSharedContext actionSharedContext)
        {
            Systems.Guide.ActionProcessors.IActionData val_15;
            ShowGenericDialogueProcessor.<>c__DisplayClass0_0 val_1 = new ShowGenericDialogueProcessor.<>c__DisplayClass0_0();
            Systems.Guide.ActionProcessors.GenericDialogueDismissalData val_2 = new Systems.Guide.ActionProcessors.GenericDialogueDismissalData();
            if(val_1 != null)
            {
                    val_15 = val_1;
                .nodeData = val_2;
            }
            else
            {
                    val_15 = 16;
                mem[16] = val_2;
            }
            
            if(node != null)
            {
                    node.ActionData = val_15;
            }
            else
            {
                    mem[80] = val_15;
            }
            
            System.String[] val_3 = Systems.Guide.ArgParser.PrepArgs(args:  node.ActionArgs);
            string val_4 = Systems.Guide.ArgParser.GetString(args:  val_3, index:  0, fallback:  "No Title");
            Game.Localization.LocalizationDomain val_5 = Game.Localization.LocalizationDomain.Instance;
            var val_18 = 0;
            val_18 = val_18 + 1;
            string val_7 = val_5.ILocalization.GetLocalizedString(localizedStringId:  val_4, originalString:  val_4);
            string val_8 = Systems.Guide.ArgParser.GetString(args:  val_3, index:  1, fallback:  "No Body");
            Game.Localization.LocalizationDomain val_9 = Game.Localization.LocalizationDomain.Instance;
            var val_19 = 0;
            val_19 = val_19 + 1;
            string val_11 = val_9.ILocalization.GetLocalizedString(localizedStringId:  val_8, originalString:  val_8);
            string val_12 = Systems.Guide.ArgParser.GetString(args:  val_3, index:  2, fallback:  "OK");
            Game.Localization.LocalizationDomain val_13 = Game.Localization.LocalizationDomain.Instance;
            var val_20 = 0;
            val_20 = val_20 + 1;
            GameUI.GenericDialogData val_16 = new GameUI.GenericDialogData();
            if(val_16 != null)
            {
                    .title = val_7;
                .message = val_11;
            }
            else
            {
                    mem[16] = val_7;
                mem[24] = val_11;
            }
            
            .positiveButtonText = val_13.ILocalization.GetLocalizedString(localizedStringId:  val_12, originalString:  val_12);
            .positiveButtonAction = new System.Action(object:  val_1, method:  System.Void ShowGenericDialogueProcessor.<>c__DisplayClass0_0::<StartAction>b__0());
            actionSharedContext._masterEvents.GenericDialogRequest(genericDialogData:  val_16);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsActionComplete(Systems.Guide.GuideNode node)
        {
            return false;
        }
    
    }

}
