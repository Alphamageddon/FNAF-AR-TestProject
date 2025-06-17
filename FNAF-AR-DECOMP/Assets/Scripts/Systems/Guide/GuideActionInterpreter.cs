using UnityEngine;

namespace Systems.Guide
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class GuideActionInterpreter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ActivateListeningNode(Systems.Guide.GuideNode node, Systems.Guide.GuideActionSharedContext actionSharedContext)
        {
            if(node.Action <= 40)
            {
                    var val_168 = 52946276 + (node.Action) << 2;
                val_168 = val_168 + 52946276;
            }
            else
            {
                    System.ArgumentOutOfRangeException val_167 = new System.ArgumentOutOfRangeException(paramName:  System.String.Format(format:  "Node calls unsupported action: {0}:{1}.", arg0:  node.Uid, arg1:  node.Action));
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void UpdateAction(Systems.Guide.GuideNode node, Systems.Guide.GuideActionSharedContext actionSharedContext)
        {
            if(node.Action <= 40)
            {
                    var val_23 = 52946440 + (node.Action) << 2;
                val_23 = val_23 + 52946440;
            }
            else
            {
                    System.ArgumentOutOfRangeException val_22 = new System.ArgumentOutOfRangeException(paramName:  System.String.Format(format:  "Node calls unsupported action: {0}:{1}.", arg0:  node.Uid, arg1:  node.Action));
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ShouldComplete(Systems.Guide.GuideNode node, Systems.Guide.GuideActionSharedContext actionSharedContext)
        {
            if(node.Action <= 40)
            {
                    var val_34 = 52946604 + (node.Action) << 2;
                val_34 = val_34 + 52946604;
            }
            else
            {
                    System.ArgumentOutOfRangeException val_33 = new System.ArgumentOutOfRangeException(paramName:  System.String.Format(format:  "Node calls unsupported action: {0}:{1}.", arg0:  node.Uid, arg1:  node.Action));
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void CompleteAction(Systems.Guide.GuideNode node, Systems.Guide.GuideActionSharedContext actionSharedContext)
        {
            if(node == null)
            {
                    25389 = 0;
            }
            
            if(node.Action <= 40)
            {
                    var val_3 = 1;
                val_3 = val_3 << node.Action;
                val_3 = val_3 & 2199022862335;
                if(val_3 != 0)
            {
                    return;
            }
            
                if(node.Action == 17)
            {
                    Systems.Guide.ActionProcessors.AllowTapProcessor.CompleteAction(node:  25389, actionSharedContext:  actionSharedContext);
                return;
            }
            
                Systems.Guide.ActionProcessors.AllowCameraPermissionProcessor.isComplete = false;
                return;
            }
            
            System.ArgumentOutOfRangeException val_2 = new System.ArgumentOutOfRangeException(paramName:  System.String.Format(format:  "Node calls unsupported action: {0}:{1}.", arg0:  node.Uid, arg1:  node.Action));
        }
    
    }

}
