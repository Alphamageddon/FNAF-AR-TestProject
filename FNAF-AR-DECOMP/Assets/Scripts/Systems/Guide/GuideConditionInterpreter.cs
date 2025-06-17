using UnityEngine;

namespace Systems.Guide
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GuideConditionInterpreter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool EvaluateAllConditions(Systems.Guide.GuideNode node, Systems.Guide.GuideConditionSharedContext context)
        {
            Systems.Guide.GuideCondition[] val_2;
            Systems.Guide.GuideNode val_3;
            var val_4;
            var val_3 = 0;
            label_7:
            val_2 = node.Conditions;
            if(val_3 >= node.Conditions.Length)
            {
                goto label_2;
            }
            
            if(val_3 >= node.Conditions.Length)
            {
                    val_3 = 0;
            }
            
            val_2 = node.Conditions[0];
            if(val_3 >= node.ConditionArgs.Length)
            {
                    val_3 = 0;
            }
            
            val_3 = val_3 + 1;
            if((Systems.Guide.GuideConditionInterpreter.EvaluateCondition(condition:  val_2, conditionArgs:  node.ConditionArgs[0], node:  val_3, context:  context)) == true)
            {
                goto label_7;
            }
            
            val_4 = 0;
            return (bool)val_4;
            label_2:
            val_4 = 1;
            return (bool)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool EvaluateCondition(Systems.Guide.GuideCondition condition, string conditionArgs, Systems.Guide.GuideNode node, Systems.Guide.GuideConditionSharedContext context)
        {
            if((condition - 2) > 8)
            {
                    return true;
            }
            
            var val_2 = 52946768 + ((condition - 2)) << 2;
            val_2 = val_2 + 52946768;
            goto (52946768 + ((condition - 2)) << 2 + 52946768);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GuideConditionInterpreter()
        {
        
        }
    
    }

}
