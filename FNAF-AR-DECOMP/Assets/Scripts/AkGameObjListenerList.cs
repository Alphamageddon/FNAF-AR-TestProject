using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
[Serializable]
public class AkGameObjListenerList : AkAudioListener.BaseListenerList
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AkGameObj akGameObj;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<AkAudioListener> initialListenerList;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool useDefaultListeners;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetUseDefaultListeners(bool useDefault)
    {
        var val_14;
        int val_15;
        var val_1 = (this.useDefaultListeners == true) ? 1 : 0;
        val_1 = val_1 ^ useDefault;
        if(val_1 == false)
        {
                return;
        }
        
        this.useDefaultListeners = useDefault;
        if(useDefault == false)
        {
            goto label_2;
        }
        
        AKRESULT val_4 = AkSoundEngine.ResetListenersToDefault(in_emitterGameObj:  this.akGameObj.gameObject);
        val_14 = 0;
        goto label_6;
        label_13:
        UnityEngine.GameObject val_5 = this.akGameObj.gameObject;
        AKRESULT val_8 = AkSoundEngine.AddListener(in_emitterGameObj:  val_5, in_listenerGameObj:  X22.Item[0].gameObject);
        val_14 = 1;
        label_6:
        if(val_14 < val_5.Count)
        {
            goto label_13;
        }
        
        return;
        label_2:
        System.UInt64[] val_10 = this.GetListenerIds();
        if(val_10 != null)
        {
                val_15 = val_10.Length;
        }
        else
        {
                val_15 = 0;
        }
        
        AKRESULT val_12 = AkSoundEngine.SetListeners(in_emitterGameObj:  this.akGameObj.gameObject, in_pListenerGameObjs:  val_10, in_uNumListeners:  0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Init(AkGameObj akGameObj)
    {
        var val_5;
        this.akGameObj = akGameObj;
        if(this.useDefaultListeners != true)
        {
                AKRESULT val_2 = AkSoundEngine.SetListeners(in_emitterGameObj:  akGameObj.gameObject, in_pListenerGameObjs:  0, in_uNumListeners:  0);
        }
        
        val_5 = 0;
        goto label_5;
        label_9:
        this.initialListenerList.Item[0].StartListeningToEmitter(emitter:  akGameObj);
        val_5 = 1;
        label_5:
        if(val_5 < this.initialListenerList.Count)
        {
            goto label_9;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Add(AkAudioListener listener)
    {
        AkAudioListener val_6;
        var val_7;
        val_6 = listener;
        if((this.Add(listener:  val_6)) != false)
        {
                if(AkSoundEngine.IsInitialized() != false)
        {
                val_6 = val_6.gameObject;
            AKRESULT val_5 = AkSoundEngine.AddListener(in_emitterGameObj:  this.akGameObj.gameObject, in_listenerGameObj:  val_6);
        }
        
            val_7 = 1;
            return (bool)val_7;
        }
        
        val_7 = 0;
        return (bool)val_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Remove(AkAudioListener listener)
    {
        AkAudioListener val_6;
        var val_7;
        val_6 = listener;
        if((this.Remove(listener:  val_6)) != false)
        {
                if(AkSoundEngine.IsInitialized() != false)
        {
                val_6 = val_6.gameObject;
            AKRESULT val_5 = AkSoundEngine.RemoveListener(in_emitterGameObj:  this.akGameObj.gameObject, in_listenerGameObj:  val_6);
        }
        
            val_7 = 1;
            return (bool)val_7;
        }
        
        val_7 = 0;
        return (bool)val_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkGameObjListenerList()
    {
        this.initialListenerList = new System.Collections.Generic.List<AkAudioListener>();
        this.useDefaultListeners = true;
    }

}
