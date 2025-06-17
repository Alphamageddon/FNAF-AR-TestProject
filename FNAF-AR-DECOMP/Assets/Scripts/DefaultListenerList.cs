using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkAudioListener.DefaultListenerList : AkAudioListener.BaseListenerList
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Add(AkAudioListener listener)
    {
        AkAudioListener val_5;
        var val_6;
        val_5 = listener;
        if((this.Add(listener:  val_5)) != false)
        {
                if(AkSoundEngine.IsInitialized() != false)
        {
                val_5 = val_5.gameObject;
            AKRESULT val_4 = AkSoundEngine.AddDefaultListener(in_listenerGameObj:  val_5);
        }
        
            val_6 = 1;
            return (bool)val_6;
        }
        
        val_6 = 0;
        return (bool)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Remove(AkAudioListener listener)
    {
        AkAudioListener val_5;
        var val_6;
        val_5 = listener;
        if((this.Remove(listener:  val_5)) != false)
        {
                if(AkSoundEngine.IsInitialized() != false)
        {
                val_5 = val_5.gameObject;
            AKRESULT val_4 = AkSoundEngine.RemoveDefaultListener(in_listenerGameObj:  val_5);
        }
        
            val_6 = 1;
            return (bool)val_6;
        }
        
        val_6 = 0;
        return (bool)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkAudioListener.DefaultListenerList()
    {
    
    }

}
