using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkRoomPortal : AkTriggerHandler
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MAX_ROOMS_PER_PORTAL = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkRoomPortal.State initialState;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AkVector extent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AkTransform portalTransform;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool active;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<int> closePortalTriggerList;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AkRoom[] rooms;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool portalActive { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ulong frontRoomID { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ulong backRoomID { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkRoom frontRoom { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkRoom backRoom { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsValid { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_portalActive()
    {
        return (bool)this.active;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_portalActive(bool value)
    {
        this.active = value;
        this.UpdateSoundEngineRoomIDs();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ulong get_frontRoomID()
    {
        var val_4;
        AkRoom val_1 = this.frontRoom;
        if((val_1.IsRoomActive(in_room:  val_1)) != false)
        {
                AkRoom val_3 = this.frontRoom;
            if(val_3 != null)
        {
                return val_3.GetID();
        }
        
            return val_3.GetID();
        }
        
        val_4 = null;
        val_4 = null;
        return (ulong)AkRoom.INVALID_ROOM_ID;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ulong get_backRoomID()
    {
        var val_4;
        AkRoom val_1 = this.backRoom;
        if((val_1.IsRoomActive(in_room:  val_1)) != false)
        {
                AkRoom val_3 = this.backRoom;
            if(val_3 != null)
        {
                return val_3.GetID();
        }
        
            return val_3.GetID();
        }
        
        val_4 = null;
        val_4 = null;
        return (ulong)AkRoom.INVALID_ROOM_ID;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetRoom(int in_roomIndex, AkRoom in_room)
    {
        if(this.rooms[(long)in_roomIndex] == in_room)
        {
                return;
        }
        
        this = this.rooms;
        this[(long)in_roomIndex] = in_room;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetFrontRoom(AkRoom room)
    {
        this.SetRoom(in_roomIndex:  1, in_room:  room);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetBackRoom(AkRoom room)
    {
        this.SetRoom(in_roomIndex:  0, in_room:  room);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkRoom GetRoom(int index)
    {
        return (AkRoom)this.rooms[(long)index];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkRoom get_frontRoom()
    {
        return (AkRoom)this.rooms[1];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkRoom get_backRoom()
    {
        return (AkRoom)this.rooms[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void UpdateSoundEngineRoomIDs()
    {
        if(this.enabled == false)
        {
                return;
        }
        
        if(this.frontRoomID == this.backRoomID)
        {
                UnityEngine.Debug.LogError(message:  this.name + " is not placed/oriented correctly."(" is not placed/oriented correctly."));
            return;
        }
        
        AKRESULT val_10 = AkSoundEngine.SetRoomPortal(in_PortalID:  (long)this.GetInstanceID(), Transform:  this.portalTransform, Extent:  this.extent, bEnabled:  (this.active == true) ? 1 : 0, FrontRoom:  this.frontRoomID, BackRoom:  this.backRoomID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_IsValid()
    {
        return (bool)(this.frontRoomID != this.backRoomID) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ulong GetID()
    {
        return (ulong)(long)this.GetInstanceID();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void Awake()
    {
        float val_5;
        UnityEngine.BoxCollider val_1 = this.GetComponent<UnityEngine.BoxCollider>();
        val_1.isTrigger = true;
        AkTransform val_2 = new AkTransform();
        this.portalTransform = val_2;
        UnityEngine.Bounds val_3 = val_1.bounds;
        UnityEngine.Bounds val_6 = val_1.bounds;
        UnityEngine.Bounds val_9 = val_1.bounds;
        UnityEngine.Vector3 val_13 = this.transform.forward;
        UnityEngine.Vector3 val_15 = this.transform.forward;
        UnityEngine.Vector3 val_17 = this.transform.forward;
        UnityEngine.Vector3 val_19 = this.transform.up;
        UnityEngine.Vector3 val_21 = this.transform.up;
        UnityEngine.Vector3 val_23 = this.transform.up;
        val_2.Set(in_positionX:  val_5, in_positionY:  V1.16B, in_positionZ:  V2.16B, in_orientFrontX:  val_13.x, in_orientFrontY:  val_15.y, in_orientFrontZ:  val_17.z, in_orientTopX:  val_19.x, in_orientTopY:  val_21.y, in_orientTopZ:  val_23.z);
        AkVector val_24 = new AkVector();
        this.extent = val_24;
        UnityEngine.Vector3 val_25 = val_1.size;
        UnityEngine.Vector3 val_27 = this.transform.localScale;
        val_27.x = val_25.x * val_27.x;
        val_27.x = val_27.x * 0.5f;
        val_24.X = val_27.x;
        UnityEngine.Vector3 val_28 = val_1.size;
        UnityEngine.Vector3 val_30 = this.transform.localScale;
        float val_31 = val_28.y * val_30.y;
        val_31 = val_31 * 0.5f;
        this.extent.Y = val_31;
        UnityEngine.Vector3 val_32 = val_1.size;
        UnityEngine.Vector3 val_34 = this.transform.localScale;
        float val_35 = val_32.z * val_34.z;
        val_35 = val_35 * 0.5f;
        this.extent.Z = val_35;
        this.active = (this.initialState != 0) ? 1 : 0;
        this.UpdateSoundEngineRoomIDs();
        this.RegisterTriggers(in_triggerList:  this.closePortalTriggerList, in_delegate:  new AkTriggerBase.Trigger(object:  this, method:  public System.Void AkRoomPortal::ClosePortal(UnityEngine.GameObject in_gameObject)));
        AkRoomPortalManager.RegisterPortal(portal:  this);
        this.Awake();
        if((this.closePortalTriggerList.Contains(item:  1151176110)) == false)
        {
                return;
        }
        
        this.active = false;
        this.UpdateSoundEngineRoomIDs();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void Start()
    {
        this.UpdateOverlappingRooms();
        this.Start();
        if((this.closePortalTriggerList.Contains(item:  1281810935)) == false)
        {
                return;
        }
        
        this.active = false;
        this.UpdateSoundEngineRoomIDs();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override void HandleEvent(UnityEngine.GameObject in_gameObject)
    {
        this.active = true;
        this.UpdateSoundEngineRoomIDs();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void ClosePortal(UnityEngine.GameObject in_gameObject)
    {
        this.active = false;
        this.UpdateSoundEngineRoomIDs();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void OnDestroy()
    {
        this.OnDestroy();
        this.UnregisterTriggers(in_triggerList:  this.closePortalTriggerList, in_delegate:  new AkTriggerBase.Trigger(object:  this, method:  public System.Void AkRoomPortal::ClosePortal(UnityEngine.GameObject in_gameObject)));
        if((this.closePortalTriggerList.Contains(item:  -358577003)) != false)
        {
                this.active = false;
            this.UpdateSoundEngineRoomIDs();
        }
        
        AkRoomPortalManager.UnregisterPortal(portal:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool IsRoomActive(AkRoom in_room)
    {
        if(in_room == 0)
        {
                return false;
        }
        
        if(in_room != null)
        {
                return in_room.isActiveAndEnabled;
        }
        
        return in_room.isActiveAndEnabled;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Open()
    {
        this.active = true;
        this.UpdateSoundEngineRoomIDs();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Close()
    {
        this.active = false;
        this.UpdateSoundEngineRoomIDs();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void FindOverlappingRooms(AkRoom.PriorityList[] roomList)
    {
        UnityEngine.BoxCollider val_19 = this.gameObject.GetComponent<UnityEngine.BoxCollider>();
        if(val_19 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_4 = val_19.size;
        UnityEngine.Vector3 val_6 = this.transform.localScale;
        UnityEngine.Vector3 val_7 = val_19.size;
        UnityEngine.Vector3 val_9 = this.transform.localScale;
        UnityEngine.Vector3 val_10 = val_19.size;
        val_19 = this.transform;
        UnityEngine.Vector3 val_12 = val_19.localScale;
        float val_13 = val_4.x * val_6.x;
        float val_19 = 0.5f;
        val_12.z = val_10.z * val_12.z;
        val_13 = val_13 * val_19;
        val_19 = (val_7.y * val_9.y) * val_19;
        val_12.z = val_12.z * 0.25f;
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.forward;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, d:  -0.25f);
        this.FillRoomList(center:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, halfExtents:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, list:  roomList[0]);
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.forward;
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, d:  0.25f);
        this.FillRoomList(center:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, halfExtents:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, list:  roomList[1]);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void FillRoomList(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, AkRoom.PriorityList list)
    {
        UnityEngine.Object val_10;
        var val_11;
        list.rooms.Clear();
        val_10 = this.transform;
        UnityEngine.Vector3 val_2 = val_10.TransformPoint(position:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z});
        UnityEngine.Quaternion val_4 = this.transform.rotation;
        val_11 = 0;
        goto label_5;
        label_16:
        val_10 = UnityEngine.Physics.OverlapBox(center:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, halfExtents:  new UnityEngine.Vector3() {x = halfExtents.x, y = halfExtents.y, z = halfExtents.z}, orientation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.z, z = ???, w = ???}, layerMask:  0, queryTriggerInteraction:  2)[0].gameObject.GetComponent<AkRoom>();
        if(val_10 != 0)
        {
                if(((list.BinarySearch(room:  val_10)) & 2147483648) != 0)
        {
                list.Add(room:  val_10);
        }
        
        }
        
        val_11 = 1;
        label_5:
        if(val_11 < val_5.Length)
        {
            goto label_16;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void UpdateOverlappingRooms()
    {
        AkRoom.PriorityList[] val_1 = new AkRoom.PriorityList[2];
        AkRoom.PriorityList val_2 = new AkRoom.PriorityList();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(val_2 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_2 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = val_2;
        val_1[1] = new AkRoom.PriorityList();
        this.FindOverlappingRooms(roomList:  val_1);
        var val_7 = 0;
        do
        {
            if(((1152921508900635136.BinarySearch(room:  this.rooms[val_7])) & 2147483648) != 0)
        {
                this.SetRoom(in_roomIndex:  0, in_room:  1152921508900635136.GetHighestPriorityRoom());
        }
        
            val_7 = val_7 + 1;
        }
        while(val_7 != 2);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkRoomPortal()
    {
        this.active = true;
        this.closePortalTriggerList = new System.Collections.Generic.List<System.Int32>();
        this.rooms = new AkRoom[2];
    }

}
