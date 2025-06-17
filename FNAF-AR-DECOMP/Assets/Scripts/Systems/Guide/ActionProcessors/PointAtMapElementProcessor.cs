using UnityEngine;

namespace Systems.Guide.ActionProcessors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class PointAtMapElementProcessor
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartAction(Systems.Guide.GuideNode node, Systems.Guide.GuideActionSharedContext actionSharedContext, bool show)
        {
            if(actionSharedContext._mapSceneLookup == null)
            {
                goto label_2;
            }
            
            if(show == false)
            {
                goto label_3;
            }
            
            label_7:
            actionSharedContext._mapSceneLookup.MapInputController.SetOverrideTarget(target:  Systems.Guide.ActionProcessors.PointAtMapElementProcessor.FindFirstMatchingTransform(node:  node, actionSharedContext:  actionSharedContext, mapAnimatronics:  actionSharedContext._mapSceneLookup.PlayerTarget.GetComponentsInChildren<MapMode.GeoPositionObject.MapAnimatronic>()));
            return;
            label_2:
            if(show == true)
            {
                goto label_7;
            }
            
            label_3:
            actionSharedContext._mapSceneLookup.MapInputController.SetOverrideTarget(target:  0);
            UnityEngine.Transform val_7 = actionSharedContext._mapSceneLookup.PlayerTarget.GetComponentInChildren<UnityEngine.Transform>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.Transform FindFirstMatchingTransform(Systems.Guide.GuideNode node, Systems.Guide.GuideActionSharedContext actionSharedContext, MapMode.GeoPositionObject.MapAnimatronic[] mapAnimatronics)
        {
            UnityEngine.Transform val_6 = actionSharedContext._mapSceneLookup.PlayerTarget.transform;
            var val_9 = 0;
            do
            {
                if(val_9 >= mapAnimatronics.Length)
            {
                    return val_6;
            }
            
                val_9 = val_9 + 1;
            }
            while((Systems.Guide.ActionProcessors.PointAtMapElementProcessor.TestSingleAnimatronic(sb:  new System.Text.StringBuilder(), checkTransform:  mapAnimatronics[0].transform, needle:  node.ActionArgs.ToLower(), foundTransform: ref  val_6)) == false);
            
            return val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool TestSingleAnimatronic(System.Text.StringBuilder sb, UnityEngine.Transform checkTransform, string needle, ref UnityEngine.Transform foundTransform)
        {
            System.Text.StringBuilder val_5;
            var val_6;
            if(sb != null)
            {
                    System.Text.StringBuilder val_1 = sb.Clear();
                val_5 = sb;
                Systems.Guide.ActionProcessors.PointAtMapElementProcessor.ConcatenateName(transform:  checkTransform, sb:  val_5);
            }
            else
            {
                    System.Text.StringBuilder val_2 = 0.Clear();
                val_5 = 0;
                Systems.Guide.ActionProcessors.PointAtMapElementProcessor.ConcatenateName(transform:  checkTransform, sb:  val_5);
            }
            
            if((sb.ToLower().Contains(value:  needle)) != false)
            {
                    val_6 = 1;
                foundTransform = checkTransform;
                return (bool)val_6;
            }
            
            val_6 = 0;
            return (bool)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void ConcatenateName(UnityEngine.Transform transform, System.Text.StringBuilder sb)
        {
            var val_5;
            System.Text.StringBuilder val_2 = sb.Append(value:  transform.name);
            val_5 = 0;
            goto label_2;
            label_6:
            UnityEngine.Transform val_3 = transform.GetChild(index:  0);
            val_5 = 1;
            label_2:
            if(val_5 < transform.childCount)
            {
                goto label_6;
            }
        
        }
    
    }

}
