using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public static class AkAudioInputManager
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static bool initialized;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly System.Collections.Generic.Dictionary<uint, AkAudioInputManager.AudioSamplesDelegate> audioSamplesDelegates;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly System.Collections.Generic.Dictionary<uint, AkAudioInputManager.AudioFormatDelegate> audioFormatDelegates;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly AkAudioFormat audioFormat;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly AkAudioInputManager.AudioSamplesInteropDelegate audioSamplesDelegate;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly AkAudioInputManager.AudioFormatInteropDelegate audioFormatDelegate;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint PostAudioInputEvent(AK.Wwise.Event akEvent, UnityEngine.GameObject gameObject, AkAudioInputManager.AudioSamplesDelegate sampleDelegate, AkAudioInputManager.AudioFormatDelegate formatDelegate)
    {
        AkAudioInputManager.TryInitialize();
        mem[1152921519382821648] = 0;
        mem[1152921519382821656] = static System.Void AkAudioInputManager::EventCallback(object cookie, AkCallbackType type, AkCallbackInfo callbackInfo);
        mem[1152921519382821632] = static System.Void AkAudioInputManager::EventCallback(object cookie, AkCallbackType type, AkCallbackInfo callbackInfo);
        uint val_1 = akEvent.Post(gameObject:  gameObject, flags:  1, callback:  new AkCallbackManager.EventCallback(), cookie:  0);
        AkAudioInputManager.AddPlayingID(playingID:  val_1, sampleDelegate:  sampleDelegate, formatDelegate:  formatDelegate);
        return val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint PostAudioInputEvent(uint akEventID, UnityEngine.GameObject gameObject, AkAudioInputManager.AudioSamplesDelegate sampleDelegate, AkAudioInputManager.AudioFormatDelegate formatDelegate)
    {
        AkAudioInputManager.TryInitialize();
        mem[1152921519382966416] = 0;
        mem[1152921519382966424] = static System.Void AkAudioInputManager::EventCallback(object cookie, AkCallbackType type, AkCallbackInfo callbackInfo);
        mem[1152921519382966400] = static System.Void AkAudioInputManager::EventCallback(object cookie, AkCallbackType type, AkCallbackInfo callbackInfo);
        uint val_1 = AkSoundEngine.PostEvent(in_eventID:  akEventID, in_gameObjectID:  gameObject, in_uFlags:  1, in_pfnCallback:  new AkCallbackManager.EventCallback(), in_pCookie:  0);
        AkAudioInputManager.AddPlayingID(playingID:  val_1, sampleDelegate:  sampleDelegate, formatDelegate:  formatDelegate);
        return val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint PostAudioInputEvent(string akEventName, UnityEngine.GameObject gameObject, AkAudioInputManager.AudioSamplesDelegate sampleDelegate, AkAudioInputManager.AudioFormatDelegate formatDelegate)
    {
        AkAudioInputManager.TryInitialize();
        mem[1152921519383119376] = 0;
        mem[1152921519383119384] = static System.Void AkAudioInputManager::EventCallback(object cookie, AkCallbackType type, AkCallbackInfo callbackInfo);
        mem[1152921519383119360] = static System.Void AkAudioInputManager::EventCallback(object cookie, AkCallbackType type, AkCallbackInfo callbackInfo);
        uint val_1 = AkSoundEngine.PostEvent(in_pszEventName:  akEventName, in_gameObjectID:  gameObject, in_uFlags:  1, in_pfnCallback:  new AkCallbackManager.EventCallback(), in_pCookie:  0);
        AkAudioInputManager.AddPlayingID(playingID:  val_1, sampleDelegate:  sampleDelegate, formatDelegate:  formatDelegate);
        return val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static bool InternalAudioSamplesDelegate(uint playingID, float[] samples, uint channelIndex, uint frames)
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if((AkAudioInputManager.audioSamplesDelegates.ContainsKey(key:  playingID)) == false)
        {
                return false;
        }
        
        val_4 = null;
        val_4 = null;
        AudioSamplesDelegate val_2 = AkAudioInputManager.audioSamplesDelegates.Item[playingID];
        if(val_2 != null)
        {
                return val_2.Invoke(playingID:  playingID, channelIndex:  channelIndex, samples:  samples);
        }
        
        return val_2.Invoke(playingID:  playingID, channelIndex:  channelIndex, samples:  samples);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static void InternalAudioFormatDelegate(uint playingID, IntPtr format)
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if((AkAudioInputManager.audioFormatDelegates.ContainsKey(key:  playingID)) == false)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        AkAudioInputManager.audioFormatDelegates.Item[playingID].Invoke(playingID:  playingID, format:  AkAudioInputManager.audioFormat);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static void TryInitialize()
    {
        var val_1 = null;
        if(AkAudioInputManager.initialized != false)
        {
                return;
        }
        
        AkAudioInputManager.initialized = true;
        AkSoundEngine.SetAudioInputCallbacks(getAudioSamples:  AkAudioInputManager.audioSamplesDelegate, getAudioFormat:  AkAudioInputManager.audioFormatDelegate);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static void AddPlayingID(uint playingID, AkAudioInputManager.AudioSamplesDelegate sampleDelegate, AkAudioInputManager.AudioFormatDelegate formatDelegate)
    {
        var val_1;
        var val_2;
        if(playingID == 0)
        {
                return;
        }
        
        if(sampleDelegate == null)
        {
                return;
        }
        
        val_1 = null;
        val_1 = null;
        AkAudioInputManager.audioSamplesDelegates.Add(key:  playingID, value:  sampleDelegate);
        if(formatDelegate == null)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        AkAudioInputManager.audioFormatDelegates.Add(key:  playingID, value:  formatDelegate);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static void EventCallback(object cookie, AkCallbackType type, AkCallbackInfo callbackInfo)
    {
        if(type != 1)
        {
                return;
        }
        
        if(callbackInfo == null)
        {
                return;
        }
        
        var val_1 = (((AkCallbackInfo.__il2cppRuntimeField_typeHierarchy + (AkEventCallbackInfo.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (callbackInfo) : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AkAudioInputManager()
    {
        AkAudioInputManager.audioSamplesDelegates = new System.Collections.Generic.Dictionary<System.UInt32, AudioSamplesDelegate>();
        AkAudioInputManager.audioFormatDelegates = new System.Collections.Generic.Dictionary<System.UInt32, AudioFormatDelegate>();
        AkAudioInputManager.audioFormat = new AkAudioFormat();
        mem[1152921519383971600] = 0;
        mem[1152921519383971608] = static System.Boolean AkAudioInputManager::InternalAudioSamplesDelegate(uint playingID, float[] samples, uint channelIndex, uint frames);
        mem[1152921519383971584] = static System.Boolean AkAudioInputManager::InternalAudioSamplesDelegate(uint playingID, float[] samples, uint channelIndex, uint frames);
        AkAudioInputManager.audioSamplesDelegate = new AkAudioInputManager.AudioSamplesInteropDelegate();
        mem[1152921519383975696] = 0;
        mem[1152921519383975704] = static System.Void AkAudioInputManager::InternalAudioFormatDelegate(uint playingID, IntPtr format);
        mem[1152921519383975680] = static System.Void AkAudioInputManager::InternalAudioFormatDelegate(uint playingID, IntPtr format);
        AkAudioInputManager.audioFormatDelegate = new AkAudioInputManager.AudioFormatInteropDelegate();
    }

}
