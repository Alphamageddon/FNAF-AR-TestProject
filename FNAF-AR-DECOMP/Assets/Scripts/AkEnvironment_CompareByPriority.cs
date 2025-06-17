using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkEnvironment.AkEnvironment_CompareByPriority : IComparer<AkEnvironment>
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual int Compare(AkEnvironment a, AkEnvironment b)
    {
        int val_3 = a.priority;
        if(val_3 != 0)
        {
                return (int)val_3;
        }
        
        val_3 = UnityEngine.Object.op_Inequality(x:  a, y:  b);
        return (int)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkEnvironment.AkEnvironment_CompareByPriority()
    {
    
    }

}
