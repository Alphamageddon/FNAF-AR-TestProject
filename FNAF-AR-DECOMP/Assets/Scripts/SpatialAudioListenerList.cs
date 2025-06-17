using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkSpatialAudioListener.SpatialAudioListenerList
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly System.Collections.Generic.List<AkSpatialAudioListener> listenerList;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<AkSpatialAudioListener> ListenerList { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<AkSpatialAudioListener> get_ListenerList()
    {
        return (System.Collections.Generic.List<AkSpatialAudioListener>)this.listenerList;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Add(AkSpatialAudioListener listener)
    {
        var val_3;
        if(listener != 0)
        {
                if((this.listenerList.Contains(item:  listener)) == false)
        {
            goto label_5;
        }
        
        }
        
        val_3 = 0;
        return (bool)val_3;
        label_5:
        this.listenerList.Add(item:  listener);
        this.Refresh();
        val_3 = 1;
        return (bool)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Remove(AkSpatialAudioListener listener)
    {
        var val_4;
        if(listener != 0)
        {
                if((this.listenerList.Contains(item:  listener)) != false)
        {
                bool val_3 = this.listenerList.Remove(item:  listener);
            this.Refresh();
            val_4 = 1;
            return (bool)val_4;
        }
        
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Refresh()
    {
        var val_12;
        var val_13;
        var val_14;
        UnityEngine.GameObject val_15;
        var val_16;
        var val_17;
        var val_18;
        if(this.listenerList.Count == 1)
        {
                val_12 = null;
            val_12 = null;
            if(AkSpatialAudioListener.s_SpatialAudioListener != 0)
        {
                val_13 = null;
            val_13 = null;
            AKRESULT val_4 = AkSoundEngine.UnregisterSpatialAudioListener(in_gameObjectID:  AkSpatialAudioListener.s_SpatialAudioListener.gameObject);
        }
        
            val_14 = null;
            val_14 = null;
            AkSpatialAudioListener.s_SpatialAudioListener = this.listenerList.Item[0];
            val_15 = AkSpatialAudioListener.s_SpatialAudioListener.gameObject;
            if((AkSoundEngine.RegisterSpatialAudioListener(in_gameObjectID:  val_15)) != 1)
        {
                return;
        }
        
            val_16 = null;
            val_16 = null;
            AkSpatialAudioListener.s_SpatialAudioListener.SetGameObjectInRoom();
            return;
        }
        
        val_15 = this.listenerList;
        if(val_15.Count != 0)
        {
                return;
        }
        
        val_17 = null;
        val_17 = null;
        val_15 = AkSpatialAudioListener.s_SpatialAudioListener;
        if(val_15 == 0)
        {
                return;
        }
        
        val_18 = null;
        val_18 = null;
        val_15 = AkSpatialAudioListener.s_SpatialAudioListener.gameObject;
        AKRESULT val_11 = AkSoundEngine.UnregisterSpatialAudioListener(in_gameObjectID:  val_15);
        AkSpatialAudioListener.s_SpatialAudioListener = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkSpatialAudioListener.SpatialAudioListenerList()
    {
        this.listenerList = new System.Collections.Generic.List<AkSpatialAudioListener>();
    }

}
