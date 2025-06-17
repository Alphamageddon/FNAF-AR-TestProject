using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class GraphRequest.<TakeScreenshot>d__4 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Facebook.Unity.Example.GraphRequest <>4__this;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GraphRequest.<TakeScreenshot>d__4(int <>1__state)
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
        object val_8;
        int val_9;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForEndOfFrame val_1 = null;
        val_8 = val_1;
        val_1 = new UnityEngine.WaitForEndOfFrame();
        val_9 = 1;
        this.<>2__current = val_8;
        this.<>1__state = val_9;
        return (bool)val_9;
        label_1:
        val_8 = this.<>4__this;
        this.<>1__state = 0;
        UnityEngine.Texture2D val_4 = new UnityEngine.Texture2D(width:  UnityEngine.Screen.width, height:  UnityEngine.Screen.height, textureFormat:  3, mipChain:  false);
        val_4.ReadPixels(source:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, destX:  0, destY:  0);
        val_4.Apply();
        System.Byte[] val_5 = UnityEngine.ImageConversion.EncodeToPNG(tex:  val_4);
        UnityEngine.WWWForm val_6 = new UnityEngine.WWWForm();
        if(val_6 != null)
        {
                val_6.AddBinaryData(fieldName:  "image", contents:  val_5, fileName:  "InteractiveConsole.png");
        }
        else
        {
                val_6.AddBinaryData(fieldName:  "image", contents:  val_5, fileName:  "InteractiveConsole.png");
        }
        
        val_6.AddField(fieldName:  "message", value:  "herp derp.  I did a thing!  Did I do this right?");
        Facebook.Unity.FB.API(query:  "me/photos", method:  1, callback:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult>(object:  val_8, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result)), formData:  val_6);
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
