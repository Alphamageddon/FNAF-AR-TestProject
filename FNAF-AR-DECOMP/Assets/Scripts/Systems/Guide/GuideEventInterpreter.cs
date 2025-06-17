using UnityEngine;

namespace Systems.Guide
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class GuideEventInterpreter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool EvaluateEvent(Systems.Guide.GuideEvent guideEvent, string eventArg, Systems.Guide.GuideNode node, out int triggeringIndex)
        {
            int val_10;
            var val_11;
            int val_12;
            int val_13;
            System.String[] val_14;
            val_10 = 0;
            val_11 = 0;
            triggeringIndex = 0;
            goto label_1;
            label_29:
            if(node.Events[0] != guideEvent)
            {
                goto label_25;
            }
            
            if(node.EventArgs != null)
            {
                    val_12 = node.EventArgs.Length;
            }
            else
            {
                    val_12 = 0;
            }
            
            if(guideEvent > 18)
            {
                goto label_25;
            }
            
            Systems.Guide.GuideEvent val_1 = 1 << guideEvent;
            if((val_1 & 1436) == 0)
            {
                goto label_8;
            }
            
            if(val_12 == 0)
            {
                goto label_9;
            }
            
            val_13 = System.Math.Min(val1:  0, val2:  val_12 - 1);
            val_14 = (long)val_13;
            if((System.String.op_Equality(a:  eventArg, b:  node.EventArgs[val_14])) == true)
            {
                goto label_14;
            }
            
            goto label_25;
            label_8:
            if((val_1 & 507904) == 0)
            {
                goto label_16;
            }
            
            if(val_12 == 0)
            {
                goto label_17;
            }
            
            val_13 = System.Math.Min(val1:  0, val2:  val_12 - 1);
            val_14 = node.EventArgs;
            if((System.Int32.Parse(s:  eventArg)) < (System.Int32.Parse(s:  val_14[(long)val_13])))
            {
                goto label_25;
            }
            
            label_14:
            val_11 = 1;
            triggeringIndex = val_13;
            goto label_25;
            label_9:
            triggeringIndex = 0;
            val_11 = System.String.IsNullOrEmpty(value:  eventArg);
            goto label_25;
            label_17:
            val_11 = 0;
            triggeringIndex = 0;
            goto label_25;
            label_16:
            val_1 = val_1 & 6755;
            if(val_1 != 0)
            {
                goto label_26;
            }
            
            label_25:
            val_10 = 1;
            label_1:
            val_12 = node.Events;
            if(val_10 < node.Events.Length)
            {
                goto label_29;
            }
            
            return (bool)val_11 & 1;
            label_26:
            triggeringIndex = val_10;
            val_11 = 1;
            return (bool)val_11 & 1;
        }
    
    }

}
