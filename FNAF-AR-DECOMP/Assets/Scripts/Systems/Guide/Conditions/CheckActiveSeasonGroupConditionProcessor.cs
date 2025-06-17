using UnityEngine;

namespace Systems.Guide.Conditions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class CheckActiveSeasonGroupConditionProcessor
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool Evaluate(Systems.Guide.GuideNode node, string conditionArgs, Systems.Guide.GuideConditionSharedContext context)
        {
            var val_4;
            if(context._activeSeasonalAssets != null)
            {
                    var val_2 = (context._activeSeasonalAssets.Count > 0) ? 1 : 0;
            }
            else
            {
                    val_4 = 0;
            }
            
            bool val_3 = System.String.IsNullOrEmpty(value:  conditionArgs);
            if((val_3 != true) && (val_4 != 0))
            {
                    if(context._activeSeasonalAssets != null)
            {
                    return context._activeSeasonalAssets.Contains(item:  conditionArgs);
            }
            
                return context._activeSeasonalAssets.Contains(item:  conditionArgs);
            }
            
            val_3 = val_3 & val_4;
            return (bool)val_3;
        }
    
    }

}
