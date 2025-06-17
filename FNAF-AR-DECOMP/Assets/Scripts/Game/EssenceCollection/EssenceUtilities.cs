using UnityEngine;

namespace Game.EssenceCollection
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class EssenceUtilities
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Vector3 ProjectPointBetweenCorners(Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder.CameraInfoFrame cameraInfoFrame, UnityEngine.Vector2 point)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = cameraInfoFrame.upperLeftProjectedPoint.x, y = cameraInfoFrame.upperLeftProjectedPoint.y, z = cameraInfoFrame.upperLeftProjectedPoint.z}, b:  new UnityEngine.Vector3() {x = cameraInfoFrame.upperRightProjectedPoint.x, y = cameraInfoFrame.upperRightProjectedPoint.y, z = cameraInfoFrame.upperRightProjectedPoint.z}, t:  point.x);
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = cameraInfoFrame.lowerLeftProjectedPoint.x, y = cameraInfoFrame.lowerLeftProjectedPoint.y, z = cameraInfoFrame.lowerLeftProjectedPoint.z}, b:  new UnityEngine.Vector3() {x = cameraInfoFrame.lowerRightProjectedPoint.x, y = cameraInfoFrame.lowerRightProjectedPoint.y, z = cameraInfoFrame.lowerRightProjectedPoint.z}, t:  point.x);
            return UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, t:  point.y);
        }
    
    }

}
