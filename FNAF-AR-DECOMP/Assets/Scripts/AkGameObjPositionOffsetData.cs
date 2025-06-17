using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
[Serializable]
public class AkGameObjPositionOffsetData
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool KeepMe;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 positionOffset;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkGameObjPositionOffsetData(bool IReallyWantToBeConstructed = False)
    {
        this.KeepMe = IReallyWantToBeConstructed;
    }

}
