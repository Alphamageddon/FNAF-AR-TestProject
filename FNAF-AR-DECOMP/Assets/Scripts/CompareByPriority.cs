using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private class AkRoom.PriorityList.CompareByPriority : IComparer<AkRoom>
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual int Compare(AkRoom a, AkRoom b)
    {
        var val_2;
        if(a.priority == 0)
        {
                if(a != b)
        {
                val_2 = 1;
            return (int)val_2;
        }
        
        }
        
        val_2 = -a.priority;
        return (int)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkRoom.PriorityList.CompareByPriority()
    {
    
    }

}
