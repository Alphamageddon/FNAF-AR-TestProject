using UnityEngine;

namespace EZCameraShake
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CameraUtilities
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Vector3 SmoothDampEuler(UnityEngine.Vector3 current, UnityEngine.Vector3 target, ref UnityEngine.Vector3 velocity, float smoothTime)
        {
            return new UnityEngine.Vector3() {x = UnityEngine.Mathf.SmoothDampAngle(current:  current.x, target:  target.x, currentVelocity: ref  8.92654E-33f, smoothTime:  smoothTime), y = UnityEngine.Mathf.SmoothDampAngle(current:  current.y, target:  target.y, currentVelocity: ref  8.926542E-33f, smoothTime:  smoothTime), z = UnityEngine.Mathf.SmoothDampAngle(current:  current.z, target:  target.z, currentVelocity: ref  8.926545E-33f, smoothTime:  smoothTime)};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Vector3 MultiplyVectors(UnityEngine.Vector3 v, UnityEngine.Vector3 w)
        {
            v.x = v.x * w.x;
            v.y = v.y * w.y;
            v.z = v.z * w.z;
            return new UnityEngine.Vector3() {x = v.x, y = v.y, z = v.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CameraUtilities()
        {
        
        }
    
    }

}
