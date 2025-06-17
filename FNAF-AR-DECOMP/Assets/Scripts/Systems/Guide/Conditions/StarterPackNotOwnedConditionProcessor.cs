using UnityEngine;

namespace Systems.Guide.Conditions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class StarterPackNotOwnedConditionProcessor
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string STARTER_PACK_ID = "com.illumix.fnafar.pack_starter";
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool Evaluate(Systems.Guide.GuideNode node, string conditionArgs, Systems.Guide.GuideConditionSharedContext context)
        {
            return (bool)((context._storeDomain.NumGoodsOwned(id:  "com.illumix.fnafar.pack_starter")) == 0) ? 1 : 0;
        }
    
    }

}
