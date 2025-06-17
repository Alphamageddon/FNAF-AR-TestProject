using UnityEngine;

namespace Systems.Guide.Conditions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class GuideIntegerCompareConditionProcessor
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool Evaluate(Systems.Guide.GuideNode node, string conditionArgs, bool timeSpan, Systems.Guide.Conditions.GuideIntegerCompareConditionProcessor.Comparison comparison)
        {
            var val_13;
            var val_14;
            System.String[] val_1 = Systems.Guide.ArgParser.PrepArgs(args:  conditionArgs);
            int val_4 = Systems.Guide.ArgParser.GetInt(args:  val_1, index:  1, fallback:  0);
            val_13 = UnityEngine.PlayerPrefs.GetInt(key:  "Guide_" + Systems.Guide.ArgParser.GetString(args:  val_1, index:  0, fallback:  "undefinedKey")(Systems.Guide.ArgParser.GetString(args:  val_1, index:  0, fallback:  "undefinedKey")), defaultValue:  0);
            if(timeSpan != false)
            {
                    System.DateTime val_6 = System.DateTime.Now;
                System.TimeSpan val_7 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_6.dateData}, d2:  new System.DateTime());
                val_13 = (int)val_7._ticks.TotalSeconds - val_13;
            }
            
            if(comparison == 0)
            {
                    return (bool)(val_13 > val_4) ? 1 : 0;
            }
            
            val_14 = ((comparison == 1) ? 1 : 0) & ((val_13 < val_4) ? 1 : 0);
            return (bool)(val_13 > val_4) ? 1 : 0;
        }
    
    }

}
