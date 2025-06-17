using UnityEngine;

namespace Systems.Guide.Conditions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class PlayerStreakAtLeastConditionProcessor
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool Evaluate(Systems.Guide.GuideNode node, string conditionArgs, Systems.Guide.GuideConditionSharedContext context)
        {
            GameUI.Domain val_2 = Master.MasterDomain.GetDomain().gameUIDomain;
            return (bool)(val_2.gameUIData.GetServerCurrentStreak() >= (System.Convert.ToInt32(value:  conditionArgs))) ? 1 : 0;
        }
    
    }

}
