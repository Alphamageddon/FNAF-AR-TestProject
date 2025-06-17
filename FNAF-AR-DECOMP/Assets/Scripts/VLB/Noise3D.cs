using UnityEngine;

namespace VLB
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class Noise3D
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool ms_IsSupportedChecked;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool ms_IsSupported;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.Texture3D ms_NoiseTexture;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const UnityEngine.HideFlags kHideFlags = 61;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int kMinShaderLevel = 35;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool isSupported { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool isProperlyLoaded { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string isNotSupportedString { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool get_isSupported()
        {
            object val_4;
            var val_5;
            var val_6;
            var val_7;
            val_5 = null;
            val_5 = null;
            if(VLB.Noise3D.kMinShaderLevel == 0)
            {
                    val_6 = null;
                val_4 = UnityEngine.SystemInfo.graphicsShaderLevel;
                val_6 = null;
                VLB.Noise3D.ms_IsSupported = (val_4 > 34) ? 1 : 0;
                val_7 = null;
                if(VLB.Noise3D.ms_IsSupported != true)
            {
                    val_4 = VLB.Noise3D.isNotSupportedString;
                UnityEngine.Debug.LogWarning(message:  val_4);
                val_7 = null;
            }
            
                val_7 = null;
                VLB.Noise3D.kMinShaderLevel = 1;
                val_5 = null;
            }
            
            val_5 = null;
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool get_isProperlyLoaded()
        {
            null = null;
            return UnityEngine.Object.op_Inequality(x:  VLB.Noise3D.ms_NoiseTexture, y:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string get_isNotSupportedString()
        {
            return (string)System.String.Format(format:  "3D Noise requires higher shader capabilities (Shader Model 3.5 / OpenGL ES 3.0), which are not available on the current platform: graphicsShaderLevel (current/required) = {0} / {1}", arg0:  UnityEngine.SystemInfo.graphicsShaderLevel, arg1:  35);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void OnStartUp()
        {
            VLB.Noise3D.LoadIfNeeded();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LoadIfNeeded()
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            val_9 = null;
            if(VLB.Noise3D.isSupported == false)
            {
                    return;
            }
            
            val_10 = null;
            val_10 = null;
            if(VLB.Noise3D.ms_NoiseTexture == 0)
            {
                    VLB.Config val_3 = VLB.Config.Instance;
                VLB.Config val_4 = VLB.Config.Instance;
                VLB.Noise3D.ms_NoiseTexture = VLB.Noise3D.LoadTexture3D(textData:  val_3.noise3DData, size:  val_4.noise3DSize);
                if((UnityEngine.Object.op_Implicit(exists:  VLB.Noise3D.ms_NoiseTexture)) != false)
            {
                    val_11 = null;
                val_11 = null;
                VLB.Noise3D.ms_NoiseTexture.hideFlags = 61;
            }
            
            }
            
            val_12 = null;
            val_12 = null;
            UnityEngine.Shader.SetGlobalTexture(name:  "_VLB_NoiseTex3D", value:  VLB.Noise3D.ms_NoiseTexture);
            UnityEngine.Vector4 val_8 = VLB.Config.Instance.globalNoiseParam;
            UnityEngine.Shader.SetGlobalVector(name:  "_VLB_NoiseGlobal", value:  new UnityEngine.Vector4() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.Texture3D LoadTexture3D(UnityEngine.TextAsset textData, int size)
        {
            int val_11;
            System.Object[] val_12;
            string val_13;
            var val_14;
            var val_15;
            val_11 = size;
            if(textData != 0)
            {
                goto label_3;
            }
            
            val_12 = System.Array.Empty<System.Object>();
            val_13 = "Fail to open Noise 3D Data";
            goto label_6;
            label_3:
            val_12 = textData.bytes;
            val_14 = UnityEngine.Mathf.Max(a:  0, b:  (val_11 * val_11) * val_11);
            if(val_14 != val_3.Length)
            {
                goto label_11;
            }
            
            UnityEngine.Texture3D val_7 = null;
            val_15 = val_7;
            val_7 = new UnityEngine.Texture3D(width:  val_11, height:  val_11, depth:  val_11, textureFormat:  1, mipChain:  false);
            UnityEngine.Color[] val_8 = new UnityEngine.Color[0];
            val_11 = val_8;
            if(val_14 >= 1)
            {
                    do
            {
                UnityEngine.Color val_9 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
                val_14 = 0 + 1;
                mem2[0] = val_9.r;
                mem2[0] = val_9.g;
                mem2[0] = val_9.b;
                mem2[0] = val_9.a;
            }
            while(val_14 != val_14);
            
            }
            
            if(val_15 == null)
            {
                goto label_17;
            }
            
            val_7.SetPixels(colors:  val_8);
            goto label_18;
            label_11:
            object[] val_10 = new object[1];
            val_12 = val_10;
            val_12[0] = val_11;
            val_13 = "Noise 3D Data file has not the proper size {0}x{0}x{0}";
            label_6:
            UnityEngine.Debug.LogErrorFormat(format:  val_13, args:  val_10);
            val_15 = 0;
            return (UnityEngine.Texture3D)val_15;
            label_17:
            val_7.SetPixels(colors:  val_8);
            label_18:
            val_7.Apply();
            return (UnityEngine.Texture3D)val_15;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Noise3D()
        {
        
        }
    
    }

}
