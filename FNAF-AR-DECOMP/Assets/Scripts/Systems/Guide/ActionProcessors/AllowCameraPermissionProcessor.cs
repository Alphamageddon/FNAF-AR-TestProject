using UnityEngine;

namespace Systems.Guide.ActionProcessors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class AllowCameraPermissionProcessor
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool isComplete;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartAction(Systems.Guide.GuideNode node, Systems.Guide.GuideActionSharedContext actionSharedContext)
        {
            AllowCameraPermissionProcessor.<>c__DisplayClass1_0 val_1 = new AllowCameraPermissionProcessor.<>c__DisplayClass1_0();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            .actionSharedContext = actionSharedContext;
            if(actionSharedContext != null)
            {
                goto label_4;
            }
            
            label_5:
            label_4:
            actionSharedContext._cameraPermissionGovernor.ActivatePermissions(success:  new System.Action(object:  val_1, method:  System.Void AllowCameraPermissionProcessor.<>c__DisplayClass1_0::<StartAction>b__0()));
            return;
            label_1:
            mem[16] = actionSharedContext;
            if(mem[16] != 0)
            {
                goto label_4;
            }
            
            goto label_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void UpdateAction(Systems.Guide.GuideActionSharedContext actionSharedContext)
        {
            actionSharedContext._cameraPermissionGovernor.UpdateAction();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void Complete()
        {
            Systems.Guide.ActionProcessors.AllowCameraPermissionProcessor.isComplete = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsActionComplete()
        {
            return (bool)Systems.Guide.ActionProcessors.AllowCameraPermissionProcessor.isComplete;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void CompleteAction()
        {
            Systems.Guide.ActionProcessors.AllowCameraPermissionProcessor.isComplete = false;
        }
    
    }

}
