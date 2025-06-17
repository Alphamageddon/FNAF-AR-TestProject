using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class GA_SpecialEvents.<SubmitFPSRoutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GA_SpecialEvents.<SubmitFPSRoutine>d__6(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void System.IDisposable.Dispose()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool MoveNext()
    {
        int val_6;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_11;
        }
        
        this.<>1__state = 0;
        goto label_3;
        label_1:
        this.<>1__state = 0;
        GameAnalyticsSDK.Events.GA_SpecialEvents.SubmitFPS();
        label_3:
        if((UnityEngine.Application.isPlaying != false) && (GameAnalyticsSDK.GameAnalytics.SettingsGA != 0))
        {
                GameAnalyticsSDK.Setup.Settings val_4 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(val_4.SubmitFpsAverage != false)
        {
                val_6 = 1;
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  30f);
            this.<>1__state = val_6;
            return (bool)val_6;
        }
        
        }
        
        label_11:
        val_6 = 0;
        return (bool)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
