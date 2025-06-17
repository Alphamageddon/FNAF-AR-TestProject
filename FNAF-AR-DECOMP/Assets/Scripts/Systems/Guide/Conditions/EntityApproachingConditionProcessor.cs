using UnityEngine;

namespace Systems.Guide.Conditions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class EntityApproachingConditionProcessor
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool Evaluate(Systems.Guide.GuideNode node, string conditionArgs, Systems.Guide.GuideConditionSharedContext context)
        {
            var val_6;
            var val_7 = 0;
            label_10:
            if(val_7 >= val_2.Length)
            {
                goto label_5;
            }
            
            val_7 = val_7 + 1;
            if((context._mapSceneLookup.PlayerTarget.GetComponentsInChildren<MapMode.GeoPositionObject.MapAnimatronic>()[0].animatronicEntity.stateData.animatronicState) != 2)
            {
                goto label_10;
            }
            
            val_6 = 1;
            return (bool)val_6;
            label_5:
            val_6 = 0;
            return (bool)val_6;
        }
    
    }

}
