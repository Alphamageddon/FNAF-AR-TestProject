using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class BugReportScreenshotUtil.<ScreenshotCaptureCo>d__1 : IEnumerator<object>, IEnumerator, IDisposable
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
    public BugReportScreenshotUtil.<ScreenshotCaptureCo>d__1(int <>1__state)
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
        UnityEngine.Texture2D val_8;
        int val_9;
        val_8 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        if(SRDebugger.Internal.BugReportScreenshotUtil.ScreenshotData != null)
        {
                UnityEngine.Debug.LogWarning(message:  "[SRDebugger] Warning, overriding existing screenshot data.");
        }
        
        val_9 = 1;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        this.<>1__state = val_9;
        return (bool)val_9;
        label_1:
        this.<>1__state = 0;
        UnityEngine.Texture2D val_4 = null;
        val_8 = val_4;
        val_4 = new UnityEngine.Texture2D(width:  UnityEngine.Screen.width, height:  UnityEngine.Screen.height, textureFormat:  3, mipChain:  false);
        int val_5 = UnityEngine.Screen.width;
        int val_6 = UnityEngine.Screen.height;
        val_4.ReadPixels(source:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, destX:  0, destY:  0);
        val_4.Apply();
        SRDebugger.Internal.BugReportScreenshotUtil.ScreenshotData = UnityEngine.ImageConversion.EncodeToPNG(tex:  val_4);
        UnityEngine.Object.Destroy(obj:  val_4);
        label_2:
        val_9 = 0;
        return (bool)val_9;
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
