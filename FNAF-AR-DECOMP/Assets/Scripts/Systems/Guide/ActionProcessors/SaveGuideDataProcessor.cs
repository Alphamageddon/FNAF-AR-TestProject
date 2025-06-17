using UnityEngine;

namespace Systems.Guide.ActionProcessors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class SaveGuideDataProcessor
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartAction(Systems.Guide.GuideNode node)
        {
            int val_8;
            System.String[] val_1 = Systems.Guide.ArgParser.PrepArgs(args:  node.ActionArgs);
            string val_3 = "Guide_" + Systems.Guide.ArgParser.GetString(args:  val_1, index:  0, fallback:  "undefinedKey")(Systems.Guide.ArgParser.GetString(args:  val_1, index:  0, fallback:  "undefinedKey"));
            if(node.Action == 34)
            {
                goto label_3;
            }
            
            if(node.Action == 35)
            {
                goto label_4;
            }
            
            if(node.Action != 36)
            {
                    return;
            }
            
            UnityEngine.PlayerPrefs.DeleteKey(key:  val_3);
            return;
            label_3:
            System.DateTime val_4 = System.DateTime.Now;
            System.TimeSpan val_5 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_4.dateData}, d2:  new System.DateTime());
            val_8 = (int)val_5._ticks.TotalSeconds;
            goto label_9;
            label_4:
            val_8 = Systems.Guide.ArgParser.GetInt(args:  val_1, index:  1, fallback:  0);
            label_9:
            UnityEngine.PlayerPrefs.SetInt(key:  val_3, value:  val_8);
        }
    
    }

}
