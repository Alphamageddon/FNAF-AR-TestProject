using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class AllowCameraPermissionProcessor.<>c__DisplayClass1_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Systems.Guide.GuideActionSharedContext actionSharedContext;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AllowCameraPermissionProcessor.<>c__DisplayClass1_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <StartAction>b__0()
    {
        this.actionSharedContext._cameraPermissionGovernor.EnsurePermissions(success:  new System.Action(object:  0, method:  static System.Void Systems.Guide.ActionProcessors.AllowCameraPermissionProcessor::Complete()));
    }

}
