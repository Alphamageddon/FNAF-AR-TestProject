using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkBasePathGetter
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string DefaultBasePath;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string GetPlatformName()
    {
        return (string)((System.String.IsNullOrEmpty(value:  System.String.alignConst)) != true) ? "Android" : System.String.alignConst;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string GetPlatformBasePath()
    {
        string val_4 = System.IO.Path.Combine(path1:  AkBasePathGetter.GetFullSoundBankPath(), path2:  AkBasePathGetter.GetPlatformName());
        AkBasePathGetter.FixSlashes(path: ref  val_4);
        return val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string GetFullSoundBankPath()
    {
        if((System.String.IsNullOrEmpty(value:  System.String.alignConst)) != false)
        {
                AkBasePlatformSettings val_3 = AkWwiseInitializationSettings.ActivePlatformSettings;
        }
        
        AkBasePathGetter.FixSlashes(path: ref  val_3);
        return (string)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void FixSlashes(ref string path, char separatorChar, char badChar, bool addTrailingSlash)
    {
        char val_8 = separatorChar;
        if((System.String.IsNullOrEmpty(value:  path)) == true)
        {
                return;
        }
        
        char[] val_4 = new char[1];
        val_4[0] = '\';
        val_8 = path.Trim().Replace(oldChar:  badChar, newChar:  val_8 = separatorChar).TrimStart(trimChars:  val_4);
        path = val_8;
        if(addTrailingSlash == false)
        {
                return;
        }
        
        if((val_8.EndsWith(value:  val_8)) == true)
        {
                return;
        }
        
        path = path + val_8;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void FixSlashes(ref string path)
    {
        null = null;
        AkBasePathGetter.FixSlashes(path: ref  string val_2 = path, separatorChar:  System.IO.Path.DirectorySeparatorChar, badChar:  (System.IO.Path.DirectorySeparatorChar == '\') ? 47 : 92, addTrailingSlash:  true);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string GetSoundbankBasePath()
    {
        return AkBasePathGetter.GetPlatformBasePath();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkBasePathGetter()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AkBasePathGetter()
    {
        AkBasePathGetter.DefaultBasePath = System.IO.Path.Combine(path1:  "Audio", path2:  "GeneratedSoundBanks");
    }

}
