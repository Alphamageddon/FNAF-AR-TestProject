using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class PlayFabUnityHttp.<Post>d__12 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PlayFab.Internal.CallRequestContainer reqContainer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PlayFab.Internal.PlayFabUnityHttp <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Networking.UnityWebRequest <www>5__2;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PlayFabUnityHttp.<Post>d__12(int <>1__state)
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
        var val_16;
        UnityEngine.Networking.UnityWebRequest val_33;
        PlayFab.Internal.PlayFabUnityHttp val_34;
        string val_35;
        string val_36;
        int val_37;
        var val_38;
        var val_39;
        var val_42;
        val_33 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        UnityEngine.Networking.UnityWebRequest val_1 = new UnityEngine.Networking.UnityWebRequest(url:  this.reqContainer.FullUrl);
        val_1.uploadHandler = new UnityEngine.Networking.UploadHandlerRaw(data:  this.reqContainer.Payload);
        UnityEngine.Networking.DownloadHandlerBuffer val_3 = new UnityEngine.Networking.DownloadHandlerBuffer();
        if(val_1 == null)
        {
            goto label_6;
        }
        
        val_1.downloadHandler = val_3;
        goto label_7;
        label_1:
        val_34 = this.<>4__this;
        this.<>1__state = 0;
        if((System.String.IsNullOrEmpty(value:  this.<www>5__2.error)) == false)
        {
            goto label_9;
        }
        
        System.Byte[] val_7 = this.<www>5__2.downloadHandler.data;
        if(val_7 == null)
        {
            goto label_12;
        }
        
        if((val_7[0] != 31) || (val_7[0] != 139))
        {
            goto label_16;
        }
        
        new System.IO.MemoryStream() = new System.IO.MemoryStream(buffer:  val_7);
        new Ionic.Zlib.GZipStream() = new Ionic.Zlib.GZipStream(stream:  new System.IO.MemoryStream(), mode:  1, leaveOpen:  false);
        byte[] val_10 = new byte[4096];
        new System.IO.MemoryStream() = new System.IO.MemoryStream();
        label_21:
        if(new Ionic.Zlib.GZipStream() < 1)
        {
            goto label_19;
        }
        
        if(new System.IO.MemoryStream() != null)
        {
            goto label_21;
        }
        
        goto label_21;
        label_9:
        val_35 = this.<www>5__2.error;
        0.OnError(error:  val_35, reqContainer:  this.reqContainer);
        goto label_82;
        label_6:
        val_1.downloadHandler = val_3;
        label_7:
        val_1.method = "POST";
        val_35 = this.reqContainer;
        this.<www>5__2 = val_1;
        Dictionary.Enumerator<TKey, TValue> val_13 = this.reqContainer.RequestHeaders.GetEnumerator();
        val_34 = 1152921515881769584;
        label_34:
        if(((-313552560) & 1) == 0)
        {
            goto label_27;
        }
        
        UnityEngine.XR.ARSubsystems.TrackableId val_17 = val_16.trackableId;
        if((System.String.IsNullOrEmpty(value:  val_17.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.String>::get_Key()))) != true)
        {
                if((System.String.IsNullOrEmpty(value:  val_17.m_SubId1)) == false)
        {
            goto label_29;
        }
        
        }
        
        UnityEngine.Debug.LogWarning(message:  "Null header: "("Null header: ") + val_17.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.String>::get_Key())(val_17.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.String>::get_Key())) + " = "(" = ") + val_17.m_SubId1);
        goto label_34;
        label_29:
        this.<www>5__2.SetRequestHeader(name:  val_17.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.String>::get_Key()), value:  val_17.m_SubId1);
        goto label_34;
        label_16:
        val_36 = System.Text.Encoding.UTF8;
        goto label_84;
        label_12:
        val_36 = "Unexpected error: cannot decompress GZIP stream.";
        label_84:
        val_35 = this.reqContainer;
        0.OnResponse(response:  val_36, reqContainer:  val_35);
        label_82:
        val_33 = this.<www>5__2;
        val_33.Dispose();
        label_2:
        val_37 = 0;
        return (bool)val_37;
        label_27:
        long val_25 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525768130896});
        goto label_98;
        label_19:
        new System.IO.StreamReader() = new System.IO.StreamReader(stream:  new System.IO.MemoryStream());
        0.OnResponse(response:  new System.IO.StreamReader(), reqContainer:  this.reqContainer);
        val_38 = 0;
        val_39 = 524;
        var val_34 = 0;
        val_34 = val_34 + 1;
        new System.IO.MemoryStream().Dispose();
        if(( != 0) && ( != 524))
        {
                val_38 = 0;
        }
        
        val_42 = 552;
        if(new Ionic.Zlib.GZipStream() == null)
        {
            
        }
        else
        {
                var val_35 = 0;
            val_35 = val_35 + 1;
            new Ionic.Zlib.GZipStream().Dispose();
        }
        
        if( == 552)
        {
            goto label_82;
        }
        
        if( == 0)
        {
            goto label_84;
        }
        
        goto label_84;
        label_98:
        this.<>2__current = this.<www>5__2.SendWebRequest();
        val_37 = 1;
        this.<>1__state = val_37;
        return (bool)val_37;
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
