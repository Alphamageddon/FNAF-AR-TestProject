using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class LightningLightParameters
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.LightRenderMode RenderMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Color LightColor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float LightPercent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float LightShadowPercent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float LightIntensity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float BounceIntensity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ShadowStrength;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ShadowBias;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ShadowNormalBias;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float LightRange;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.LayerMask CullingMask;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float OrthographicOffset;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float FadeInMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float FadeFullyLitMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float FadeOutMultiplier;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasLight { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HasLight()
        {
            if(S0 <= 0f)
            {
                    return false;
            }
            
            if(this.LightIntensity < 0.01f)
            {
                    return false;
            }
            
            if(this.LightPercent >= (1E-07f))
            {
                    return (bool)(this.LightRange > 0.01f) ? 1 : 0;
            }
            
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LightningLightParameters()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.LightPercent = 1E-06f;
            this.ShadowStrength = 1f;
            this.ShadowBias = 0.05f;
            this.LightColor = val_1;
            mem[1152921526258951320] = val_1.g;
            mem[1152921526258951324] = val_1.b;
            mem[1152921526258951328] = val_1.a;
            this.LightIntensity = 0.5f;
            this.ShadowNormalBias = 0.4f;
            UnityEngine.LayerMask val_2 = UnityEngine.LayerMask.op_Implicit(intVal:  0);
            this.CullingMask = val_2;
            this.FadeInMultiplier = 1f;
            this.FadeFullyLitMultiplier = 1f;
            this.FadeOutMultiplier = 1f;
        }
    
    }

}
