using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkRoom : AkTriggerHandler
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static ulong INVALID_ROOM_ID;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static int RoomCount;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int priority;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AK.Wwise.AuxBus reverbAuxBus;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float reverbLevel;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float wallOcclusion;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AK.Wwise.Event roomToneEvent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float roomToneAuxSend;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool IsSpatialAudioEnabled { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool get_IsSpatialAudioEnabled()
    {
        var val_4;
        var val_5;
        if(AkSpatialAudioListener.TheSpatialAudioListener != 0)
        {
                val_4 = null;
            val_4 = null;
            var val_3 = (AkRoom.RoomCount > 0) ? 1 : 0;
            return (bool)val_5;
        }
        
        val_5 = 0;
        return (bool)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ulong GetID()
    {
        return AkSoundEngine.GetAkGameObjectID(gameObject:  this.gameObject);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnEnable()
    {
        uint val_26;
        float val_27;
        var val_28;
        AkRoomParams val_1 = new AkRoomParams();
        UnityEngine.Vector3 val_4 = this.transform.up;
        val_1.Up.X = val_4.x;
        UnityEngine.Vector3 val_7 = this.transform.up;
        val_1.Up.Y = val_7.y;
        UnityEngine.Vector3 val_10 = this.transform.up;
        val_1.Up.Z = val_10.z;
        UnityEngine.Vector3 val_13 = this.transform.forward;
        val_1.Front.X = val_13.x;
        UnityEngine.Vector3 val_16 = this.transform.forward;
        val_1.Front.Y = val_16.y;
        UnityEngine.Vector3 val_19 = this.transform.forward;
        val_1.Front.Z = val_19.z;
        uint val_20 = this.reverbAuxBus.Id;
        if(val_1 != null)
        {
                val_26 = val_20;
            val_1.ReverbAuxBus = val_26;
            val_1.ReverbLevel = this.reverbLevel;
            val_1.WallOcclusion = this.wallOcclusion;
            val_27 = this.roomToneAuxSend;
        }
        else
        {
                val_26 = val_20;
            val_1.ReverbAuxBus = val_26;
            val_1.ReverbLevel = this.reverbLevel;
            val_1.WallOcclusion = this.wallOcclusion;
            val_27 = this.roomToneAuxSend;
        }
        
        val_1.RoomGameObj_AuxSendLevelToSelf = val_27;
        val_1.RoomGameObj_KeepRegistered = this.roomToneEvent.IsValid();
        val_28 = null;
        val_28 = null;
        int val_26 = AkRoom.RoomCount;
        val_26 = val_26 + 1;
        AkRoom.RoomCount = val_26;
        AKRESULT val_25 = AkSoundEngine.SetRoom(in_RoomID:  this.GetID(), in_roomParams:  val_1, in_pName:  this.name);
        AkRoomPortalManager.RegisterRoomUpdate(room:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override void HandleEvent(UnityEngine.GameObject in_gameObject)
    {
        uint val_2 = this.roomToneEvent.Post(gameObject:  this.gameObject);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnDisable()
    {
        var val_3;
        AkRoomPortalManager.RegisterRoomUpdate(room:  this);
        val_3 = null;
        val_3 = null;
        int val_3 = AkRoom.RoomCount;
        val_3 = val_3 - 1;
        AkRoom.RoomCount = val_3;
        AKRESULT val_2 = AkSoundEngine.RemoveRoom(in_RoomID:  this.GetID());
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnTriggerEnter(UnityEngine.Collider in_other)
    {
        T val_3;
        goto label_2;
        label_9:
        val_3 = in_other.GetComponentsInChildren<AkSpatialAudioBase>()[0];
        if(val_3.enabled != false)
        {
                val_3 = mem[val_1[0x0] + 32];
            val_3 = val_1[0x0] + 32;
            val_3.EnteredRoom(room:  this);
        }
        
        0 = 1;
        label_2:
        if(0 < val_1.Length)
        {
            goto label_9;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnTriggerExit(UnityEngine.Collider in_other)
    {
        T val_3;
        goto label_2;
        label_9:
        val_3 = in_other.GetComponentsInChildren<AkSpatialAudioBase>()[0];
        if(val_3.enabled != false)
        {
                val_3 = mem[val_1[0x0] + 32];
            val_3 = val_1[0x0] + 32;
            val_3.ExitedRoom(room:  this);
        }
        
        0 = 1;
        label_2:
        if(0 < val_1.Length)
        {
            goto label_9;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkRoom()
    {
        this.reverbAuxBus = new AK.Wwise.AuxBus();
        this.reverbLevel = 1f;
        this.wallOcclusion = 1f;
        this.roomToneEvent = new AK.Wwise.Event();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AkRoom()
    {
        AkRoom.INVALID_ROOM_ID = 0;
    }

}
