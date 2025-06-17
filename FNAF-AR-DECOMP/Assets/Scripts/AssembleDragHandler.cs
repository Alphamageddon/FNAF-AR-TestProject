using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AssembleDragHandler : MonoBehaviour, IDragHandler, IEventSystemHandler, IBeginDragHandler
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Vector3 mPrevPos;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Master.MasterDomain _masterDomain;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        this._masterDomain = Master.MasterDomain.GetDomain();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Input.mousePosition;
        this.mPrevPos = val_1;
        mem[1152921518893889548] = val_1.y;
        mem[1152921518893889552] = val_1.z;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Input.mousePosition;
        this._masterDomain.eventExposer.OnWorkshopRotateCamera(prev:  new UnityEngine.Vector3() {x = this.mPrevPos, y = V12.16B, z = V13.16B}, curr:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        this.mPrevPos = val_1;
        mem[1152921518894017932] = val_1.y;
        mem[1152921518894017936] = val_1.z;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AssembleDragHandler()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.mPrevPos = val_1;
        mem[1152921518894142220] = val_1.y;
        mem[1152921518894142224] = val_1.z;
    }

}
