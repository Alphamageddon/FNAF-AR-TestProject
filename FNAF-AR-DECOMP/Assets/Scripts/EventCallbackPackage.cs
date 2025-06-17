using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkCallbackManager.EventCallbackPackage
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool m_bNotifyEndOfEvent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCallbackManager.EventCallback m_Callback;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public object m_Cookie;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint m_playingID;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AkCallbackManager.EventCallbackPackage Create(AkCallbackManager.EventCallback in_cb, object in_cookie, ref uint io_Flags)
    {
        object val_3;
        EventCallbackPackage val_4;
        uint val_5;
        var val_6;
        val_3 = in_cookie;
        if((in_cb == null) || (io_Flags == 0))
        {
            goto label_2;
        }
        
        AkCallbackManager.EventCallbackPackage val_1 = null;
        val_4 = val_1;
        val_1 = new AkCallbackManager.EventCallbackPackage();
        if(val_4 == null)
        {
            goto label_3;
        }
        
        .m_Callback = in_cb;
        .m_Cookie = val_3;
        val_5 = io_Flags;
        goto label_4;
        label_2:
        val_4 = 0;
        io_Flags = 0;
        return val_4;
        label_3:
        mem[24] = in_cb;
        mem[32] = val_3;
        val_5 = io_Flags;
        label_4:
        .m_bNotifyEndOfEvent = 0;
        io_Flags = 1;
        val_6 = null;
        val_6 = null;
        val_3 = val_1.GetHashCode();
        AkCallbackManager.m_mapEventCallbacks.set_Item(key:  val_3, value:  val_1);
        AkCallbackManager.m_LastAddedEventPackage = val_4;
        return val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void Finalize()
    {
        if(this.m_Cookie != null)
        {
                AkCallbackManager.RemoveEventCallbackCookie(in_cookie:  this.m_Cookie);
        }
        
        this.Finalize();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCallbackManager.EventCallbackPackage()
    {
    
    }

}
