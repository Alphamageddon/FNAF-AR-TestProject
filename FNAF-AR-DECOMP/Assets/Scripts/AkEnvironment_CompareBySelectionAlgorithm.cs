using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkEnvironment.AkEnvironment_CompareBySelectionAlgorithm : AkEnvironment.AkEnvironment_CompareByPriority
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int Compare(AkEnvironment a, AkEnvironment b)
    {
        var val_1;
        if(a.isDefault == false)
        {
            goto label_2;
        }
        
        if(b.isDefault == false)
        {
            goto label_3;
        }
        
        return 0.Compare(a:  a, b:  b);
        label_2:
        if(b.isDefault == false)
        {
            goto label_4;
        }
        
        label_8:
        val_1 = 0;
        return (int)val_1;
        label_4:
        if(a.excludeOthers == false)
        {
            goto label_6;
        }
        
        if(b.excludeOthers == true)
        {
                return 0.Compare(a:  a, b:  b);
        }
        
        goto label_8;
        label_6:
        if(b.excludeOthers == false)
        {
                return 0.Compare(a:  a, b:  b);
        }
        
        label_3:
        val_1 = 1;
        return (int)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkEnvironment.AkEnvironment_CompareBySelectionAlgorithm()
    {
        val_1 = new System.Object();
    }

}
