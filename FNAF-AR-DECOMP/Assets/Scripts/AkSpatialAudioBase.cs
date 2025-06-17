using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public abstract class AkSpatialAudioBase : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly AkRoom.PriorityList roomPriorityList;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected void SetGameObjectInHighestPriorityRoom()
    {
        AKRESULT val_3 = AkSoundEngine.SetGameObjectInRoom(in_gameObjectID:  this.gameObject, in_CurrentRoomID:  this.roomPriorityList.GetHighestPriorityRoomID());
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void EnteredRoom(AkRoom room)
    {
        this.roomPriorityList.Add(room:  room);
        this.SetGameObjectInHighestPriorityRoom();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void ExitedRoom(AkRoom room)
    {
        this.roomPriorityList.Remove(room:  room);
        this.SetGameObjectInHighestPriorityRoom();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetGameObjectInRoom()
    {
        var val_7;
        UnityEngine.Vector3 val_2 = this.transform.position;
        val_7 = 0;
        goto label_2;
        label_11:
        AkRoom val_5 = UnityEngine.Physics.OverlapSphere(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, radius:  0f)[0].gameObject.GetComponent<AkRoom>();
        if(val_5 != 0)
        {
                this.roomPriorityList.Add(room:  val_5);
        }
        
        val_7 = 1;
        label_2:
        if(val_7 < val_3.Length)
        {
            goto label_11;
        }
        
        this.SetGameObjectInHighestPriorityRoom();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected AkSpatialAudioBase()
    {
        this.roomPriorityList = new AkRoom.PriorityList();
    }

}
