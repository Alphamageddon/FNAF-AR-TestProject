using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AppCenter_SROptions
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const string CategoryName = "AppCenter";
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void CrashType1()
    {
        this.ForceCrash(firstOne:  true);
        System.Exception val_1 = new System.Exception(message:  "Test Exception");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void ForceCrash(bool firstOne)
    {
        bool val_1 = firstOne;
        System.Runtime.CompilerServices.AsyncVoidMethodBuilder val_2 = System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Create();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void CrashType2()
    {
        Microsoft.AppCenter.Unity.Crashes.Crashes.GenerateTestCrash();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AppCenter_SROptions()
    {
    
    }

}
