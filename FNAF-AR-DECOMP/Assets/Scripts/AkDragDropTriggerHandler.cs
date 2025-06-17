using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public abstract class AkDragDropTriggerHandler : AkTriggerHandler
{
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected abstract AK.Wwise.BaseType WwiseType { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected abstract AK.Wwise.BaseType get_WwiseType(); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void Awake()
    {
        this.Awake();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void Start()
    {
        this.Start();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void OnDestroy()
    {
        this.OnDestroy();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected AkDragDropTriggerHandler()
    {
    
    }

}
