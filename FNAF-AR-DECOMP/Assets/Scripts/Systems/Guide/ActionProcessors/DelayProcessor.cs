using UnityEngine;

namespace Systems.Guide.ActionProcessors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class DelayProcessor
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartAction(Systems.Guide.GuideNode node)
        {
            .TimeRemaining = Systems.Guide.ArgParser.GetFloat(args:  Systems.Guide.ArgParser.PrepArgs(args:  node.ActionArgs), index:  0, fallback:  0f);
            node.ActionData = new Systems.Guide.ActionProcessors.DelayData();
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
