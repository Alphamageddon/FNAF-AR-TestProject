using UnityEngine;

namespace Systems.Guide.ActionProcessors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class ShowAlertProcessor
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartAction(Systems.Guide.GuideNode node, Systems.Guide.GuideActionSharedContext actionSharedContext)
        {
            string val_24;
            float val_26;
            float val_27;
            bool val_28;
            System.String[] val_1 = Systems.Guide.ArgParser.PrepArgs(args:  node.ActionArgs);
            string val_2 = Systems.Guide.ArgParser.GetString(args:  val_1, index:  0, fallback:  "No Title");
            Game.Localization.LocalizationDomain val_3 = Game.Localization.LocalizationDomain.Instance;
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_24 = val_3.ILocalization.GetLocalizedString(localizedStringId:  val_2, originalString:  val_2);
            string val_6 = Systems.Guide.ArgParser.GetString(args:  val_1, index:  1, fallback:  "No Message");
            Game.Localization.LocalizationDomain val_7 = Game.Localization.LocalizationDomain.Instance;
            var val_26 = 0;
            val_26 = val_26 + 1;
            string val_9 = val_7.ILocalization.GetLocalizedString(localizedStringId:  val_6, originalString:  val_6);
            GameUI.PopDownData val_10 = new GameUI.PopDownData();
            if(val_10 != null)
            {
                    val_26 = 0.5f;
                .title = val_24;
                .message = val_9;
                val_27 = (GameUI.PopDownData)[1152921523395938352].showTime;
                .showTime = Systems.Guide.ArgParser.GetFloat(args:  val_1, index:  2, fallback:  val_26);
                .iconGroupId = Systems.Guide.ArgParser.GetString(args:  val_1, index:  3, fallback:  0);
                .iconId = Systems.Guide.ArgParser.GetString(args:  val_1, index:  4, fallback:  0);
                .audioId = Systems.Guide.ArgParser.GetString(args:  val_1, index:  5, fallback:  0);
                val_28 = Systems.Guide.ArgParser.GetBool(args:  val_1, index:  6, fallback:  false);
            }
            else
            {
                    mem[32] = val_9;
                val_26 = 0.5f;
                mem[24] = val_24;
                val_27 = 40;
                mem[40] = Systems.Guide.ArgParser.GetFloat(args:  val_1, index:  2, fallback:  val_26);
                mem[56] = Systems.Guide.ArgParser.GetString(args:  val_1, index:  3, fallback:  0);
                mem[64] = Systems.Guide.ArgParser.GetString(args:  val_1, index:  4, fallback:  0);
                val_24 = Systems.Guide.ArgParser.GetString(args:  val_1, index:  5, fallback:  0);
                mem[80] = val_24;
                val_28 = Systems.Guide.ArgParser.GetBool(args:  val_1, index:  6, fallback:  false);
            }
            
            .showUnidentifiedOverlay = val_28;
            actionSharedContext._masterEvents.GenericPopdownRequest(popDownData:  val_10);
            .TimeRemaining = System.Convert.ToSingle(value:  mem[40], provider:  System.Globalization.CultureInfo.InvariantCulture);
            node.ActionData = new ShowAlertProcessor.AlertData();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void UpdateAction(Systems.Guide.GuideNode node)
        {
            float val_3 = UnityEngine.Time.deltaTime;
            val_3 = (1.68059E-38f) - val_3;
            mem[16] = val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsActionComplete(Systems.Guide.GuideNode node)
        {
            return (bool)(S0 <= 0f) ? 1 : 0;
        }
    
    }

}
