using UnityEngine;

namespace Ibuprogames.VideoGlitchesAsset
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class RenderDepth : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int layer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.RenderTexture renderTexture;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Shader shader;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Material material;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera depthCamera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera parentCamera;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Material Material { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Material get_Material()
        {
            if(this.material != 0)
            {
                    return (UnityEngine.Material)this.material;
            }
            
            UnityEngine.Material val_2 = new UnityEngine.Material(shader:  this.shader);
            this.material = val_2;
            if(val_2 != 0)
            {
                    this.material.hideFlags = 61;
                return (UnityEngine.Material)this.material;
            }
            
            UnityEngine.Debug.LogWarning(message:  "[Ibuprogames.VideoGlitches] \'RenderDepth\' material null. Please contact with \'hello@ibuprogames.com\' and send the log file.");
            this.enabled = false;
            return (UnityEngine.Material)this.material;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            UnityEngine.Camera val_11 = this.GetComponent<UnityEngine.Camera>();
            this.depthCamera = val_11;
            val_11.cullingMask = this.layer;
            this.depthCamera.depthTextureMode = 1;
            this.depthCamera.clearFlags = 2;
            UnityEngine.Color val_2 = UnityEngine.Color.black;
            this.depthCamera.backgroundColor = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
            UnityEngine.Shader val_3 = UnityEngine.Resources.Load<UnityEngine.Shader>(path:  "Shaders/RenderDepth");
            this.shader = val_3;
            if(val_3 == 0)
            {
                goto label_7;
            }
            
            if(this.shader.isSupported == false)
            {
                goto label_9;
            }
            
            this.parentCamera = this.transform.parent.GetComponent<UnityEngine.Camera>();
            this.CreateRenderTexture();
            return;
            label_7:
            object[] val_9 = new object[1];
            val_11 = this.GetType();
            val_9[0] = val_11;
            UnityEngine.Debug.LogWarningFormat(format:  "[Ibuprogames.VideoGlitches] Shader \'Ibuprogames/Vintage/Resources/Shaders/RenderDepth.shader\' not found. \'{0}\' disabled.", args:  val_9);
            goto label_19;
            label_9:
            UnityEngine.Debug.LogWarning(message:  "[Ibuprogames.VideoGlitches] \'RenderDepth\' shader not supported. Please contact with \'hello@ibuprogames.com\' and send the log file.");
            label_19:
            this.enabled = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            if(this.material != 0)
            {
                    UnityEngine.Object.DestroyImmediate(obj:  this.material);
            }
            
            if(this.depthCamera == 0)
            {
                    return;
            }
            
            this.depthCamera.targetTexture = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            if(this.MustCreateRenderTexture() == false)
            {
                    return;
            }
            
            this.CreateRenderTexture();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LateUpdate()
        {
            if(this.depthCamera == 0)
            {
                    return;
            }
            
            if(this.parentCamera == 0)
            {
                    return;
            }
            
            if(this.renderTexture == 0)
            {
                    return;
            }
            
            this.depthCamera.CopyFrom(other:  this.parentCamera);
            this.depthCamera.cullingMask = this.layer;
            this.depthCamera.depthTextureMode = 1;
            this.depthCamera.clearFlags = 2;
            UnityEngine.Color val_4 = UnityEngine.Color.black;
            this.depthCamera.backgroundColor = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a};
            this.depthCamera.targetTexture = this.renderTexture;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnRenderImage(UnityEngine.RenderTexture source, UnityEngine.RenderTexture destination)
        {
            if(this.Material == 0)
            {
                    return;
            }
            
            UnityEngine.Graphics.Blit(source:  source, dest:  destination, mat:  this.material);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool MustCreateRenderTexture()
        {
            var val_6;
            var val_7;
            val_6 = this;
            if((this.renderTexture != 0) && (this.renderTexture.IsCreated() != false))
            {
                    if(UnityEngine.Screen.width == this.renderTexture)
            {
                    val_6 = UnityEngine.Screen.height;
                var val_5 = (val_6 != this.renderTexture) ? 1 : 0;
                return (bool)val_7;
            }
            
            }
            
            val_7 = 1;
            return (bool)val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateRenderTexture()
        {
            System.Object[] val_16;
            object val_17;
            string val_18;
            if((UnityEngine.Screen.width < 1) || (UnityEngine.Screen.height < 1))
            {
                goto label_2;
            }
            
            UnityEngine.RenderTexture val_5 = new UnityEngine.RenderTexture(width:  UnityEngine.Screen.width, height:  UnityEngine.Screen.height, depth:  24);
            this.renderTexture = val_5;
            if(val_5 == 0)
            {
                goto label_5;
            }
            
            this.renderTexture.isPowerOfTwo = false;
            this.renderTexture.antiAliasing = 1;
            this.renderTexture.name = "RenderTexture from VideoGlitches";
            if(this.renderTexture.Create() == false)
            {
                goto label_10;
            }
            
            this.depthCamera.targetTexture = this.renderTexture;
            return;
            label_2:
            object[] val_8 = new object[3];
            val_8[0] = UnityEngine.Screen.width;
            val_8[1] = UnityEngine.Screen.height;
            val_8[2] = this.GetType();
            UnityEngine.Debug.LogErrorFormat(format:  "[Ibuprogames.VideoGlitches] Wrong screen resolution \'{0}x{1}\', \'{2}\' disabled.", args:  val_8);
            this.enabled = false;
            return;
            label_5:
            val_16 = new object[1];
            val_17 = this.GetType();
            val_16[0] = val_17;
            val_18 = "[Ibuprogames.VideoGlitches] RenderTexture null, hardware may not support Render-To-Texture, \'{0}\' disabled.";
            goto label_32;
            label_10:
            object[] val_14 = new object[1];
            val_16 = val_14;
            val_17 = this.GetType();
            val_16[0] = val_17;
            val_18 = "[Ibuprogames.VideoGlitches] Hardware not support Render-To-Texture, \'{0}\' disabled.";
            label_32:
            UnityEngine.Debug.LogErrorFormat(format:  val_18, args:  val_14);
            this.enabled = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RenderDepth()
        {
            this.layer = 0;
        }
    
    }

}
