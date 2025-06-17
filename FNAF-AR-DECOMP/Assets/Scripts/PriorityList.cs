using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkRoom.PriorityList
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly AkRoom.PriorityList.CompareByPriority s_compareByPriority;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<AkRoom> rooms;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ulong GetHighestPriorityRoomID()
    {
        var val_3;
        AkRoom val_1 = this.GetHighestPriorityRoom();
        if(val_1 == 0)
        {
                val_3 = null;
            val_3 = null;
            return (ulong)AkRoom.INVALID_ROOM_ID;
        }
        
        if(val_1 != null)
        {
                return val_1.GetID();
        }
        
        return val_1.GetID();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkRoom GetHighestPriorityRoom()
    {
        System.Collections.Generic.List<AkRoom> val_3;
        var val_4;
        val_3 = this;
        if(this.rooms.Count != 0)
        {
                val_3 = this.rooms;
            AkRoom val_2 = val_3.Item[0];
            return (AkRoom)val_4;
        }
        
        val_4 = 0;
        return (AkRoom)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Add(AkRoom room)
    {
        int val_1 = this.BinarySearch(room:  room);
        if((val_1 & 2147483648) == 0)
        {
                return;
        }
        
        this.rooms.Insert(index:  ~val_1, item:  room);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Remove(AkRoom room)
    {
        bool val_1 = this.rooms.Remove(item:  room);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Contains(AkRoom room)
    {
        int val_1 = this.BinarySearch(room:  room);
        val_1 = (val_1 >> 31) ^ 1;
        return (bool)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int BinarySearch(AkRoom room)
    {
        var val_2;
        if((UnityEngine.Object.op_Implicit(exists:  room)) == false)
        {
                return 0;
        }
        
        val_2 = null;
        val_2 = null;
        if(this.rooms != null)
        {
                return this.rooms.BinarySearch(item:  room, comparer:  AkRoom.PriorityList.s_compareByPriority);
        }
        
        return this.rooms.BinarySearch(item:  room, comparer:  AkRoom.PriorityList.s_compareByPriority);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkRoom.PriorityList()
    {
        this.rooms = new System.Collections.Generic.List<AkRoom>();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AkRoom.PriorityList()
    {
        AkRoom.PriorityList.s_compareByPriority = new AkRoom.PriorityList.CompareByPriority();
    }

}
