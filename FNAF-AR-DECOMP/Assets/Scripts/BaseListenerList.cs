using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkAudioListener.BaseListenerList
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly System.Collections.Generic.List<ulong> listenerIdList;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly System.Collections.Generic.List<AkAudioListener> listenerList;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<AkAudioListener> ListenerList { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<AkAudioListener> get_ListenerList()
    {
        return (System.Collections.Generic.List<AkAudioListener>)this.listenerList;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual bool Add(AkAudioListener listener)
    {
        ulong val_3;
        var val_4;
        if(listener == 0)
        {
            goto label_3;
        }
        
        val_3 = listener.akGameObjectID;
        if((this.listenerIdList.Contains(item:  val_3)) == false)
        {
            goto label_6;
        }
        
        label_3:
        val_4 = 0;
        return (bool)val_4;
        label_6:
        this.listenerIdList.Add(item:  val_3);
        this.listenerList.Add(item:  listener);
        val_4 = 1;
        return (bool)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual bool Remove(AkAudioListener listener)
    {
        ulong val_5;
        var val_6;
        if(listener != 0)
        {
                val_5 = listener.akGameObjectID;
            if((this.listenerIdList.Contains(item:  val_5)) != false)
        {
                bool val_3 = this.listenerIdList.Remove(item:  val_5);
            bool val_4 = this.listenerList.Remove(item:  listener);
            val_6 = 1;
            return (bool)val_6;
        }
        
        }
        
        val_6 = 0;
        return (bool)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ulong[] GetListenerIds()
    {
        if(this.listenerIdList != null)
        {
                return this.listenerIdList.ToArray();
        }
        
        return this.listenerIdList.ToArray();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkAudioListener.BaseListenerList()
    {
        this.listenerIdList = new System.Collections.Generic.List<System.UInt64>();
        this.listenerList = new System.Collections.Generic.List<AkAudioListener>();
    }

}
