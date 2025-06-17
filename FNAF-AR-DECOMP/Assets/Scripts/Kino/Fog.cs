using UnityEngine;

namespace Kino
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Fog : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _startDistance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _useRadialDistance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _fadeToSkybox;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Shader _shader;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Material _material;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float startDistance { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool useRadialDistance { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool fadeToSkybox { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_startDistance()
        {
            return (float)this._startDistance;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_startDistance(float value)
        {
            this._startDistance = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_useRadialDistance()
        {
            return (bool)this._useRadialDistance;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_useRadialDistance(bool value)
        {
            this._useRadialDistance = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_fadeToSkybox()
        {
            return (bool)this._fadeToSkybox;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_fadeToSkybox(bool value)
        {
            this._fadeToSkybox = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            var val_5;
            UnityEngine.Camera val_1 = this.GetComponent<UnityEngine.Camera>();
            if(val_1 != null)
            {
                    val_5 = val_1.depthTextureMode;
            }
            else
            {
                    val_5 = val_1.depthTextureMode;
            }
            
            val_1.depthTextureMode = val_5 | 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnRenderImage(UnityEngine.RenderTexture source, UnityEngine.RenderTexture destination)
        {
            float val_54;
            float val_55;
            float val_57;
            float val_58;
            var val_59;
            float val_60;
            float val_61;
            if(this._material == 0)
            {
                    UnityEngine.Material val_2 = new UnityEngine.Material(shader:  this._shader);
                this._material = val_2;
                val_2.hideFlags = 52;
            }
            
            val_54 = 0f;
            float val_3 = UnityEngine.Mathf.Max(a:  this._startDistance, b:  val_54);
            this._startDistance = val_3;
            this._material.SetFloat(name:  "_DistanceOffset", value:  val_3);
            UnityEngine.FogMode val_4 = UnityEngine.RenderSettings.fogMode;
            if(val_4 == 2)
            {
                goto label_8;
            }
            
            if(val_4 != 1)
            {
                goto label_9;
            }
            
            float val_53 = UnityEngine.RenderSettings.fogStartDistance;
            float val_6 = UnityEngine.RenderSettings.fogEndDistance;
            val_6 = val_6 - val_53;
            val_54 = 1f;
            val_53 = val_54 / (UnityEngine.Mathf.Max(a:  val_6, b:  1E-06f));
            this._material.SetFloat(name:  "_LinearGrad", value:  -val_53);
            val_55 = val_6 * val_53;
            this._material.SetFloat(name:  "_LinearOffs", value:  val_55);
            this._material.DisableKeyword(keyword:  "FOG_EXP");
            goto label_15;
            label_8:
            val_55 = UnityEngine.RenderSettings.fogDensity * 1.442695f;
            this._material.SetFloat(name:  "_Density", value:  val_55);
            this._material.EnableKeyword(keyword:  "FOG_EXP");
            label_15:
            this._material.DisableKeyword(keyword:  "FOG_EXP2");
            goto label_19;
            label_9:
            val_55 = UnityEngine.RenderSettings.fogDensity * 1.201122f;
            this._material.SetFloat(name:  "_Density", value:  val_55);
            this._material.DisableKeyword(keyword:  "FOG_EXP");
            this._material.EnableKeyword(keyword:  "FOG_EXP2");
            label_19:
            if(this._useRadialDistance != false)
            {
                    this._material.EnableKeyword(keyword:  "RADIAL_DIST");
            }
            else
            {
                    this._material.DisableKeyword(keyword:  "RADIAL_DIST");
            }
            
            if(this._fadeToSkybox != false)
            {
                    this._material.EnableKeyword(keyword:  "USE_SKYBOX");
                UnityEngine.Material val_10 = UnityEngine.RenderSettings.skybox;
                this._material.SetTexture(name:  "_SkyCubemap", value:  val_10.GetTexture(name:  "_Tex"));
                UnityEngine.Color val_12 = val_10.GetColor(name:  "_Tint");
                val_57 = val_12.b;
                this._material.SetColor(name:  "_SkyTint", value:  new UnityEngine.Color() {r = val_12.r, g = val_12.g, b = val_57, a = val_12.a});
                this._material.SetFloat(name:  "_SkyExposure", value:  val_10.GetFloat(name:  "_Exposure"));
                val_58 = val_10.GetFloat(name:  "_Rotation");
                this._material.SetFloat(name:  "_SkyRotation", value:  val_58);
            }
            else
            {
                    this._material.DisableKeyword(keyword:  "USE_SKYBOX");
                UnityEngine.Color val_15 = UnityEngine.RenderSettings.fogColor;
                val_58 = val_15.r;
                val_57 = val_15.b;
                this._material.SetColor(name:  "_FogColor", value:  new UnityEngine.Color() {r = val_58, g = val_15.g, b = val_57, a = val_15.a});
            }
            
            UnityEngine.Camera val_16 = this.GetComponent<UnityEngine.Camera>();
            if(val_16 != null)
            {
                    val_59 = val_16.transform;
                val_60 = val_16.nearClipPlane;
                val_61 = val_16.farClipPlane;
            }
            else
            {
                    val_59 = 0.transform;
                val_60 = val_16.nearClipPlane;
                val_61 = val_16.farClipPlane;
            }
            
            float val_54 = 0.01745329f;
            val_54 = val_16.fieldOfView * val_54;
            val_54 = val_54 * 0.5f;
            UnityEngine.Vector3 val_24 = val_59.right;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, d:  val_60);
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, d:  val_54);
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, d:  val_16.aspect);
            UnityEngine.Vector3 val_29 = val_59.up;
            UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, d:  val_60);
            UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z}, d:  val_54);
            UnityEngine.Vector3 val_32 = val_59.forward;
            UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z}, d:  val_60);
            UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z}, b:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
            UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z}, b:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
            UnityEngine.Vector3 val_36 = val_59.forward;
            UnityEngine.Vector3 val_37 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z}, d:  val_60);
            UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z}, b:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
            UnityEngine.Vector3 val_39 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z}, b:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
            UnityEngine.Vector3 val_40 = val_59.forward;
            UnityEngine.Vector3 val_41 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_40.z}, d:  val_60);
            UnityEngine.Vector3 val_42 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_41.z}, b:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
            UnityEngine.Vector3 val_43 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_42.x, y = val_42.y, z = val_42.z}, b:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
            UnityEngine.Vector3 val_44 = val_59.forward;
            UnityEngine.Vector3 val_45 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_44.x, y = val_44.y, z = val_44.z}, d:  val_60);
            UnityEngine.Vector3 val_46 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_45.x, y = val_45.y, z = val_45.z}, b:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
            UnityEngine.Vector3 val_47 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_46.x, y = val_46.y, z = val_46.z}, b:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
            val_61 = val_61 * val_47.x;
            UnityEngine.RenderTexture.active = destination;
            val_60 = val_61 / val_60;
            this._material.SetTexture(name:  "_MainTex", value:  source);
            bool val_48 = this._material.SetPass(pass:  0);
            UnityEngine.GL.PushMatrix();
            UnityEngine.GL.LoadOrtho();
            UnityEngine.GL.Begin(mode:  7);
            UnityEngine.GL.MultiTexCoord2(unit:  0, x:  0f, y:  0f);
            UnityEngine.Vector3 val_49 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = val_47.z}, d:  val_60);
            UnityEngine.GL.MultiTexCoord(unit:  1, v:  new UnityEngine.Vector3() {x = val_49.x, y = val_49.y, z = val_49.z});
            UnityEngine.GL.Vertex3(x:  0f, y:  0f, z:  0.1f);
            UnityEngine.GL.MultiTexCoord2(unit:  0, x:  1f, y:  0f);
            UnityEngine.Vector3 val_50 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 1f, y = 0f, z = 0.1f}, d:  val_60);
            UnityEngine.GL.MultiTexCoord(unit:  1, v:  new UnityEngine.Vector3() {x = val_50.x, y = val_50.y, z = val_50.z});
            UnityEngine.GL.Vertex3(x:  1f, y:  0f, z:  0.1f);
            UnityEngine.GL.MultiTexCoord2(unit:  0, x:  1f, y:  1f);
            UnityEngine.Vector3 val_51 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 1f, y = 1f, z = 0.1f}, d:  val_60);
            UnityEngine.GL.MultiTexCoord(unit:  1, v:  new UnityEngine.Vector3() {x = val_51.x, y = val_51.y, z = val_51.z});
            UnityEngine.GL.Vertex3(x:  1f, y:  1f, z:  0.1f);
            UnityEngine.GL.MultiTexCoord2(unit:  0, x:  0f, y:  1f);
            UnityEngine.Vector3 val_52 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 0f, y = 1f, z = 0.1f}, d:  val_60);
            UnityEngine.GL.MultiTexCoord(unit:  1, v:  new UnityEngine.Vector3() {x = val_52.x, y = val_52.y, z = val_52.z});
            UnityEngine.GL.Vertex3(x:  0f, y:  1f, z:  0.1f);
            UnityEngine.GL.End();
            UnityEngine.GL.PopMatrix();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Fog()
        {
            this._startDistance = 1f;
        }
    
    }

}
