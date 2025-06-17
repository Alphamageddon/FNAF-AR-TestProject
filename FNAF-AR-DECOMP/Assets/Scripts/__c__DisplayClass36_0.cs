using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class EssenceNodes.<>c__DisplayClass36_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Game.EssenceCollection.Data.EssenceNodes.EssenceNodes <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder.CameraInfoFrame cameraInfoFrame;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection detectedObject;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Game.Server.EssenceNodeEntry entry;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public EssenceNodes.<>c__DisplayClass36_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <MakeEssenceForDetectedObject>b__0(Game.EssenceCollection.Visuals.EssenceVisual essenceVisual)
    {
        this.<>4__this.InstantiateEssenceVisual(essenceVisual:  essenceVisual, cameraInfoFrame:  new CameraInfoFrame() {cameraPosition = new UnityEngine.Vector3(), cameraRotation = new UnityEngine.Quaternion(), upperLeftProjectedPoint = new UnityEngine.Vector3(), upperRightProjectedPoint = new UnityEngine.Vector3(), lowerLeftProjectedPoint = new UnityEngine.Vector3(), lowerRightProjectedPoint = new UnityEngine.Vector3()}, detectedObject:  new SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection() {objectType = this.detectedObject, minX = this.detectedObject, minY = this.detectedObject, maxX = ???, maxY = ???, conf = ???}, entry:  this.entry);
    }

}
