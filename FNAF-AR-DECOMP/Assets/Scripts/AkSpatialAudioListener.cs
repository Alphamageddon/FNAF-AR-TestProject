using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkSpatialAudioListener : AkSpatialAudioBase
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AkSpatialAudioListener s_SpatialAudioListener;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly AkSpatialAudioListener.SpatialAudioListenerList spatialAudioListeners;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AkAudioListener AkAudioListener;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AkAudioListener TheSpatialAudioListener { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AkSpatialAudioListener.SpatialAudioListenerList SpatialAudioListeners { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AkAudioListener get_TheSpatialAudioListener()
    {
        var val_2;
        AkSpatialAudioListener val_3;
        AkAudioListener val_4;
        var val_5;
        val_2 = null;
        val_2 = null;
        val_3 = AkSpatialAudioListener.s_SpatialAudioListener;
        val_4 = 0;
        if(val_3 == 0)
        {
                return val_4;
        }
        
        val_5 = null;
        val_5 = null;
        val_3 = AkSpatialAudioListener.s_SpatialAudioListener;
        val_4 = mem[AkSpatialAudioListener.s_SpatialAudioListener + 32];
        val_4 = AkSpatialAudioListener.s_SpatialAudioListener.AkAudioListener;
        return val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AkSpatialAudioListener.SpatialAudioListenerList get_SpatialAudioListeners()
    {
        null = null;
        return (SpatialAudioListenerList)AkSpatialAudioListener.spatialAudioListeners;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Awake()
    {
        this.AkAudioListener = this.GetComponent<AkAudioListener>();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnEnable()
    {
        null = null;
        bool val_1 = AkSpatialAudioListener.spatialAudioListeners.Add(listener:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnDisable()
    {
        null = null;
        bool val_1 = AkSpatialAudioListener.spatialAudioListeners.Remove(listener:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkSpatialAudioListener()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AkSpatialAudioListener()
    {
        AkSpatialAudioListener.spatialAudioListeners = new AkSpatialAudioListener.SpatialAudioListenerList();
    }

}
