using UnityEngine;

namespace Systems.Guide.ActionProcessors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class ZoomMapProcessor
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartAction(Systems.Guide.GuideNode node, Systems.Guide.GuideActionSharedContext context)
        {
            float val_11;
            var val_12;
            float val_14;
            float val_15;
            Systems.Guide.ActionProcessors.ZoomMapData val_1 = new Systems.Guide.ActionProcessors.ZoomMapData();
            System.String[] val_2 = Systems.Guide.ArgParser.PrepArgs(args:  node.ActionArgs);
            float val_3 = Systems.Guide.ArgParser.GetFloat(args:  val_2, index:  0, fallback:  0f);
            if(val_1 != null)
            {
                    val_11 = val_1;
                .StartZoom = val_3;
                mem[1152921523400321380] = Systems.Guide.ArgParser.GetFloat(args:  val_2, index:  1, fallback:  1f);
                val_12 = 1152921523400321380;
                val_14 = .StartZoom;
                mem[1152921523400321384] = Systems.Guide.ArgParser.GetFloat(args:  val_2, index:  2, fallback:  1f);
            }
            else
            {
                    val_11 = 2.242078E-44f;
                mem[16] = val_3;
                val_12 = val_1;
                .EndZoom = Systems.Guide.ArgParser.GetFloat(args:  val_2, index:  1, fallback:  1f);
                mem[24] = Systems.Guide.ArgParser.GetFloat(args:  val_2, index:  2, fallback:  1f);
                val_14 = mem[16];
            }
            
            val_15 = UnityEngine.Mathf.Min(a:  val_14, b:  .EndZoom);
            if(val_1 != null)
            {
                    .MinZoom = val_15;
                .MaxZoom = UnityEngine.Mathf.Max(a:  val_11, b:  (Systems.Guide.ActionProcessors.ZoomMapData)[1152921523400321360].EndZoom);
            }
            else
            {
                    .MinZoom = val_15;
                val_15 = UnityEngine.Mathf.Max(a:  mem[16], b:  (Systems.Guide.ActionProcessors.ZoomMapData)[1152921523400321360].EndZoom);
                mem[32] = val_15;
            }
            
            .TimeElapsed = 0f;
            node.ActionData = val_1;
            Systems.Guide.ActionProcessors.ZoomMapProcessor.UpdateAction(node:  node, context:  context);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void UpdateAction(Systems.Guide.GuideNode node, Systems.Guide.GuideActionSharedContext context)
        {
            float val_3 = UnityEngine.Time.deltaTime;
            val_3 = val_3 + 0f;
            mem[36] = val_3;
            Systems.Guide.ActionProcessors.ZoomMapProcessor.ZoomMap(data:  0, context:  context);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsActionComplete(Systems.Guide.GuideNode node)
        {
            if(node.ActionData != null)
            {
                    return (bool)(S0 >= S1) ? 1 : 0;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static float GetLerpedZoom(Systems.Guide.ActionProcessors.ZoomMapData data)
        {
            float val_5;
            float val_6;
            float val_7;
            float val_8;
            if(data != null)
            {
                    val_5 = data.StartZoom;
                val_6 = data.MinZoom;
                val_7 = data.TimeElapsed / data.Duration;
                val_8 = data.EndZoom - val_5;
            }
            else
            {
                    val_7 = 0f / (2.105703E-38f);
                float val_1 = 1.68059E-38f;
                val_8 = (1.401298E-45f) - val_1;
                val_5 = 1.68059E-38f;
                val_6 = 0f;
            }
            
            val_1 = val_8 * val_7;
            val_1 = val_5 + val_1;
            return UnityEngine.Mathf.Clamp(value:  val_1, min:  val_6, max:  data.MaxZoom);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void ZoomMap(Systems.Guide.ActionProcessors.ZoomMapData data, Systems.Guide.GuideActionSharedContext context)
        {
            context._mapSceneLookup.MapInputController.SetZoomProportion(prop:  Systems.Guide.ActionProcessors.ZoomMapProcessor.GetLerpedZoom(data:  data));
        }
    
    }

}
