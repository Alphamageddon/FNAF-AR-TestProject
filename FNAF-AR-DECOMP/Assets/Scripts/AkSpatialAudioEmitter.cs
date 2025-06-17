using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkSpatialAudioEmitter : AkSpatialAudioBase
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AK.Wwise.AuxBus reflectAuxBus;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float reflectionMaxPathLength;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float reflectionsAuxBusGain;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint reflectionsOrder;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float roomReverbAuxBusGain;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint diffractionMaxEdges;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint diffractionMaxPaths;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint diffractionMaxPathLength;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnEnable()
    {
        uint val_5;
        AkEmitterSettings val_1 = new AkEmitterSettings();
        uint val_2 = this.reflectAuxBus.Id;
        if(val_1 != null)
        {
                val_1.reflectAuxBusID = val_2;
            val_1.reflectionMaxPathLength = this.reflectionMaxPathLength;
            val_1.reflectionsAuxBusGain = this.reflectionsAuxBusGain;
            val_1.reflectionsOrder = this.reflectionsOrder;
            val_1.reflectorFilterMask = 0;
            val_1.roomReverbAuxBusGain = this.roomReverbAuxBusGain;
            val_1.useImageSources = 0;
            val_1.diffractionMaxEdges = this.diffractionMaxEdges;
            val_1.diffractionMaxPaths = this.diffractionMaxPaths;
            val_5 = this.diffractionMaxPathLength;
        }
        else
        {
                val_1.reflectAuxBusID = val_2;
            val_1.reflectionMaxPathLength = this.reflectionMaxPathLength;
            val_1.reflectionsAuxBusGain = this.reflectionsAuxBusGain;
            val_1.reflectionsOrder = this.reflectionsOrder;
            val_1.reflectorFilterMask = 0;
            val_1.roomReverbAuxBusGain = this.roomReverbAuxBusGain;
            val_1.useImageSources = 0;
            val_1.diffractionMaxEdges = this.diffractionMaxEdges;
            val_1.diffractionMaxPaths = this.diffractionMaxPaths;
            val_5 = this.diffractionMaxPathLength;
        }
        
        val_1.diffractionMaxPathLength = (float)(double)val_5;
        if((AkSoundEngine.RegisterEmitter(in_gameObjectID:  this.gameObject, in_settings:  val_1)) != 1)
        {
                return;
        }
        
        this.SetGameObjectInRoom();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnDisable()
    {
        AKRESULT val_2 = AkSoundEngine.UnregisterEmitter(in_gameObjectID:  this.gameObject);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkSpatialAudioEmitter()
    {
        this.reflectAuxBus = new AK.Wwise.AuxBus();
        this.reflectionMaxPathLength = 0f;
        this.reflectionsAuxBusGain = 1f;
        this.reflectionsOrder = 1;
        this.roomReverbAuxBusGain = 1f;
    }

}
