using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public static class SRFileUtil
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void DeleteDirectory(string path)
    {
        System.IO.Directory.Delete(path:  path, recursive:  true);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string GetBytesReadable(long i)
    {
        string val_13;
        var val_14;
        var val_1 = (i < 0) ? (-i) : i;
        string val_2 = (i < 0) ? "-" : "";
        if(i >= 1152921504606846976)
        {
            goto label_1;
        }
        
        if(i >= 1125899906842624)
        {
            goto label_2;
        }
        
        if(i >= 1099511627776)
        {
            goto label_3;
        }
        
        if(i >= 1073741824)
        {
            goto label_4;
        }
        
        if(i >= 1048576)
        {
            goto label_5;
        }
        
        if(i >= 1024)
        {
            goto label_12;
        }
        
        string val_4 = i.ToString(format:  val_2 + "0 B");
        return (string)val_2 + val_7.ToString(format:  "0.### ")(val_7.ToString(format:  "0.### ")) + val_13;
        label_1:
        val_13 = "EB";
        val_14 = i >> 50;
        goto label_11;
        label_2:
        val_13 = "PB";
        val_14 = i >> 40;
        goto label_11;
        label_3:
        val_13 = "TB";
        val_14 = i >> 30;
        goto label_11;
        label_4:
        val_13 = "GB";
        val_14 = i >> 20;
        goto label_11;
        label_5:
        val_13 = "MB";
        val_14 = i >> 10;
        label_11:
        double val_7 = (double)val_14;
        label_12:
        val_7 = val_7 * 0.0009765625;
        return (string)val_2 + val_7.ToString(format:  "0.### ")(val_7.ToString(format:  "0.### ")) + val_13;
    }

}
