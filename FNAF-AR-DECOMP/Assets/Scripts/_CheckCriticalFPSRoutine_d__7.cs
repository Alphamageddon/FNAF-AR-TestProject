using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class GA_SpecialEvents.<CheckCriticalFPSRoutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GameAnalyticsSDK.Events.GA_SpecialEvents <>4__this;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GA_SpecialEvents.<CheckCriticalFPSRoutine>d__7(int <>1__state)
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
        int val_7;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_10;
        }
        
        this.<>1__state = 0;
        goto label_3;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.CheckCriticalFPS();
        label_3:
        if((UnityEngine.Application.isPlaying != false) && (GameAnalyticsSDK.GameAnalytics.SettingsGA != 0))
        {
                GameAnalyticsSDK.Setup.Settings val_4 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(val_4.SubmitFpsCritical != false)
        {
                GameAnalyticsSDK.Setup.Settings val_5 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            val_7 = 1;
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  (float)val_5.FpsCirticalSubmitInterval);
            this.<>1__state = val_7;
            return (bool)val_7;
        }
        
        }
        
        label_10:
        val_7 = 0;
        return (bool)val_7;
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
