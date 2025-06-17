using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class IllumixEngine_SROptions
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IllumixSurfaceManager ism;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IllumixEngine_SROptions(IllumixSurfaceManager ism)
    {
        this.ism = ism;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void ClearData()
    {
        this.ism.ClearIllumixEngineData();
    }

}
