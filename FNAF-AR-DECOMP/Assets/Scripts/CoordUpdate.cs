using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class TSDF_Manager.CoordUpdate
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public com.illumix.IntVector3.IntVector3 coord;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool isAdd;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool isSeparator;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TSDF_Manager.CoordUpdate(com.illumix.IntVector3.IntVector3 coord, bool isAdd, bool isSeparator)
    {
        this.coord = coord;
        this.isAdd = isAdd;
        this.isSeparator = isSeparator;
    }

}
