using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public abstract class AREnvironmentSetupSequence : MonoBehaviour
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void Init(); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void StartSequence(); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void UpdateSequence(); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract bool IsSequenceDone(); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void EndSequence(); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void LateUpdateSequence()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected AREnvironmentSetupSequence()
    {
    
    }

}
