using UnityEngine;

namespace EZCameraShake
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class CameraShakePresets
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static EZCameraShake.CameraShakeInstance Bump { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static EZCameraShake.CameraShakeInstance Explosion { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static EZCameraShake.CameraShakeInstance Earthquake { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static EZCameraShake.CameraShakeInstance BadTrip { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static EZCameraShake.CameraShakeInstance HandheldCamera { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static EZCameraShake.CameraShakeInstance Vibration { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static EZCameraShake.CameraShakeInstance RoughDriving { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static EZCameraShake.CameraShakeInstance get_Bump()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.15f);
            .PositionInfluence = val_3;
            mem[1152921526250751100] = val_3.y;
            mem[1152921526250751104] = val_3.z;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            .RotationInfluence = val_4;
            mem[1152921526250751112] = val_4.y;
            mem[1152921526250751116] = val_4.z;
            return (EZCameraShake.CameraShakeInstance)new EZCameraShake.CameraShakeInstance(magnitude:  2.5f, roughness:  4f, fadeInTime:  0.1f, fadeOutTime:  0.75f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static EZCameraShake.CameraShakeInstance get_Explosion()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.25f);
            .PositionInfluence = val_3;
            mem[1152921526250871292] = val_3.y;
            mem[1152921526250871296] = val_3.z;
            .RotationInfluence = 0;
            mem[1152921526250871304] = 0;
            mem[1152921526250871308] = 0;
            return (EZCameraShake.CameraShakeInstance)new EZCameraShake.CameraShakeInstance(magnitude:  5f, roughness:  10f, fadeInTime:  0f, fadeOutTime:  1.5f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static EZCameraShake.CameraShakeInstance get_Earthquake()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.25f);
            .PositionInfluence = val_3;
            mem[1152921526250991484] = val_3.y;
            mem[1152921526250991488] = val_3.z;
            .RotationInfluence = 0;
            mem[1152921526250991496] = 0;
            mem[1152921526250991500] = 0;
            return (EZCameraShake.CameraShakeInstance)new EZCameraShake.CameraShakeInstance(magnitude:  0.6f, roughness:  3.5f, fadeInTime:  2f, fadeOutTime:  10f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static EZCameraShake.CameraShakeInstance get_BadTrip()
        {
            .PositionInfluence = 0;
            mem[1152921526251111676] = 0;
            mem[1152921526251111680] = 0;
            .RotationInfluence = 0;
            mem[1152921526251111688] = 0;
            mem[1152921526251111692] = 0;
            return (EZCameraShake.CameraShakeInstance)new EZCameraShake.CameraShakeInstance(magnitude:  10f, roughness:  0.15f, fadeInTime:  5f, fadeOutTime:  10f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static EZCameraShake.CameraShakeInstance get_HandheldCamera()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            .PositionInfluence = val_2;
            mem[1152921526251231868] = val_2.y;
            mem[1152921526251231872] = val_2.z;
            .RotationInfluence = 0;
            mem[1152921526251231880] = 0;
            mem[1152921526251231884] = 0;
            return (EZCameraShake.CameraShakeInstance)new EZCameraShake.CameraShakeInstance(magnitude:  1f, roughness:  0.25f, fadeInTime:  5f, fadeOutTime:  10f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static EZCameraShake.CameraShakeInstance get_Vibration()
        {
            .PositionInfluence = 0;
            mem[1152921526251352060] = 0;
            mem[1152921526251352064] = 0;
            .RotationInfluence = 0;
            mem[1152921526251352072] = 0;
            mem[1152921526251352076] = 0;
            return (EZCameraShake.CameraShakeInstance)new EZCameraShake.CameraShakeInstance(magnitude:  0.4f, roughness:  20f, fadeInTime:  2f, fadeOutTime:  2f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static EZCameraShake.CameraShakeInstance get_RoughDriving()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            .PositionInfluence = val_2;
            mem[1152921526251472252] = val_2.y;
            mem[1152921526251472256] = val_2.z;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            .RotationInfluence = val_3;
            mem[1152921526251472264] = val_3.y;
            mem[1152921526251472268] = val_3.z;
            return (EZCameraShake.CameraShakeInstance)new EZCameraShake.CameraShakeInstance(magnitude:  1f, roughness:  2f, fadeInTime:  1f, fadeOutTime:  1f);
        }
    
    }

}
