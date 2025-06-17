using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public static class CollectionExtensionMethods
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static T Any<T>(System.Collections.Generic.HashSet<T> hashSet)
    {
        var val_1;
        var val_2;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        if((1505899296 & 1) != 0)
        {
                val_6 = val_2.emailUIDataHandler;
            val_7 = 0;
            val_8 = 54;
        }
        else
        {
                val_7 = 0;
            val_6 = 0;
            val_8 = 44;
        }
        
        val_2 = __RuntimeMethodHiddenParam + 48 + 24;
        val_1 = val_2;
        if((__RuntimeMethodHiddenParam + 48 + 24 + 286) == 0)
        {
            goto label_8;
        }
        
        var val_5 = __RuntimeMethodHiddenParam + 48 + 24 + 176;
        var val_6 = 0;
        val_5 = val_5 + 8;
        label_7:
        if(((__RuntimeMethodHiddenParam + 48 + 24 + 176 + 8) + -8) == null)
        {
            goto label_6;
        }
        
        val_6 = val_6 + 1;
        val_5 = val_5 + 16;
        if(val_6 < (__RuntimeMethodHiddenParam + 48 + 24 + 286))
        {
            goto label_7;
        }
        
        goto label_8;
        label_6:
        val_9 = ((__RuntimeMethodHiddenParam + 48 + 24) + (((__RuntimeMethodHiddenParam + 48 + 24 + 176 + 8)) << 4)) + 296;
        label_8:
        val_2.Dispose();
        if(44 != 44)
        {
                if(44 == 54)
        {
                return (object)val_6;
        }
        
        }
        
        val_6 = 0;
        return (object)val_6;
    }

}
