using UnityEngine;

namespace VLB
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class VolumetricLightBeam : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool colorFromLight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VLB.ColorMode colorMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Color color;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Gradient colorGradient;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool intensityFromLight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool intensityModeAdvanced;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float intensityInside;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float intensityOutside;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VLB.BlendingMode blendingMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool spotAngleFromLight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float spotAngle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float coneRadiusStart;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VLB.MeshType geomMeshType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int geomCustomSides;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int geomCustomSegments;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool geomCap;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool fallOffEndFromLight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VLB.AttenuationEquation attenuationEquation;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float attenuationCustomBlending;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float fallOffStart;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float fallOffEnd;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float depthBlendDistance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float cameraClippingDistance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float glareFrontal;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float glareBehind;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float boostDistanceInside;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float fresnelPowInside;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float fresnelPow;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool noiseEnabled;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float noiseIntensity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool noiseScaleUseGlobal;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float noiseScaleLocal;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool noiseVelocityUseGlobal;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 noiseVelocityLocal;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float fadeOutBegin;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float fadeOutEnd;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Plane m_PlaneWS;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int pluginVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _TrackChangesDuringPlaytime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _SortingLayerID;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _SortingOrder;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private uint <_INTERNAL_InstancedMaterialGroupID>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private VLB.BeamGeometry m_BeamGeom;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Coroutine m_CoPlaytimeUpdate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Light _CachedLight;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float alphaInside { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float alphaOutside { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float intensityGlobal { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float coneAngle { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float coneRadiusEnd { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float coneVolume { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float coneApexOffsetZ { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int geomSides { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int geomSegments { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool fadeEndFromLight { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float attenuationLerpLinearQuad { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float fadeStart { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float fadeEnd { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool isFadeOutEnabled { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int sortingLayerID { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string sortingLayerName { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int sortingOrder { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool trackChangesDuringPlaytime { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool isCurrentlyTrackingChanges { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool hasGeometry { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Bounds bounds { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int blendingModeAsInt { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint _INTERNAL_InstancedMaterialGroupID { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string meshStats { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int meshVerticesCount { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int meshTrianglesCount { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Light lightSpotAttached { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_alphaInside()
        {
            return (float)this.intensityInside;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_alphaInside(float value)
        {
            this.intensityInside = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_alphaOutside()
        {
            return (float)this.intensityOutside;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_alphaOutside(float value)
        {
            this.intensityOutside = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_intensityGlobal()
        {
            return (float)this.intensityOutside;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_intensityGlobal(float value)
        {
            this.intensityInside = value;
            this.intensityOutside = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_coneAngle()
        {
            float val_1 = this.coneRadiusEnd;
            val_1 = val_1 - this.coneRadiusStart;
            val_1 = val_1 * 57.29578f;
            val_1 = val_1 + val_1;
            return (float)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_coneRadiusEnd()
        {
            float val_1 = 0.01745329f;
            val_1 = this.spotAngle * val_1;
            val_1 = val_1 * 0.5f;
            val_1 = this.fallOffEnd * val_1;
            return (float)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_coneVolume()
        {
            float val_1 = this.coneRadiusEnd;
            float val_2 = this.coneRadiusStart * this.coneRadiusStart;
            val_2 = val_2 + (this.coneRadiusStart * val_1);
            val_1 = val_1 * val_1;
            val_1 = val_1 + val_2;
            val_1 = val_1 * 1.047198f;
            val_1 = this.fallOffEnd * val_1;
            return (float)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_coneApexOffsetZ()
        {
            float val_1 = this.coneRadiusEnd;
            val_1 = this.coneRadiusStart / val_1;
            if(val_1 == 1f)
            {
                    return (float)val_1;
            }
            
            float val_2 = this.fallOffEnd;
            val_2 = val_1 * val_2;
            val_1 = 1f - val_1;
            val_1 = val_2 / val_1;
            return (float)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_geomSides()
        {
            var val_2;
            int val_3;
            val_2 = this;
            if(this.geomMeshType == 1)
            {
                    val_3 = this.geomCustomSides;
                return val_3;
            }
            
            val_2 = VLB.Config.Instance;
            val_3 = val_1.sharedMeshSides;
            return val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_geomSides(int value)
        {
            this.geomCustomSides = value;
            UnityEngine.Debug.LogWarning(message:  "The setter VLB.VolumetricLightBeam.geomSides is OBSOLETE and has been renamed to geomCustomSides.");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_geomSegments()
        {
            var val_2;
            int val_3;
            val_2 = this;
            if(this.geomMeshType == 1)
            {
                    val_3 = this.geomCustomSegments;
                return val_3;
            }
            
            val_2 = VLB.Config.Instance;
            val_3 = val_1.sharedMeshSegments;
            return val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_geomSegments(int value)
        {
            this.geomCustomSegments = value;
            UnityEngine.Debug.LogWarning(message:  "The setter VLB.VolumetricLightBeam.geomSegments is OBSOLETE and has been renamed to geomCustomSegments.");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_fadeEndFromLight()
        {
            return (bool)this.fallOffEndFromLight;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_fadeEndFromLight(bool value)
        {
            this.fallOffEndFromLight = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_attenuationLerpLinearQuad()
        {
            if(this.attenuationEquation == 0)
            {
                    return 0f;
            }
            
            if(this.attenuationEquation != 1)
            {
                    return (float)this.attenuationCustomBlending;
            }
            
            return 1f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_fadeStart()
        {
            return (float)this.fallOffStart;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_fadeStart(float value)
        {
            this.fallOffStart = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_fadeEnd()
        {
            return (float)this.fallOffEnd;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_fadeEnd(float value)
        {
            this.fallOffEnd = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_isFadeOutEnabled()
        {
            return (bool)(this.fadeOutEnd >= 0f) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_sortingLayerID()
        {
            return (int)this._SortingLayerID;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_sortingLayerID(int value)
        {
            this._SortingLayerID = value;
            if((UnityEngine.Object.op_Implicit(exists:  this.m_BeamGeom)) == false)
            {
                    return;
            }
            
            this.m_BeamGeom.sortingLayerID = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_sortingLayerName()
        {
            return UnityEngine.SortingLayer.IDToName(id:  this._SortingLayerID);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_sortingLayerName(string value)
        {
            this.sortingLayerID = UnityEngine.SortingLayer.NameToID(name:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_sortingOrder()
        {
            return (int)this._SortingOrder;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_sortingOrder(int value)
        {
            this._SortingOrder = value;
            if((UnityEngine.Object.op_Implicit(exists:  this.m_BeamGeom)) == false)
            {
                    return;
            }
            
            this.m_BeamGeom.sortingOrder = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_trackChangesDuringPlaytime()
        {
            return (bool)this._TrackChangesDuringPlaytime;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_trackChangesDuringPlaytime(bool value)
        {
            this._TrackChangesDuringPlaytime = value;
            this.StartPlaytimeUpdateIfNeeded();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_isCurrentlyTrackingChanges()
        {
            return (bool)(this.m_CoPlaytimeUpdate != 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_hasGeometry()
        {
            return UnityEngine.Object.op_Inequality(x:  this.m_BeamGeom, y:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Bounds get_bounds()
        {
            if(this.m_BeamGeom != 0)
            {
                    if((this.m_BeamGeom.<meshRenderer>k__BackingField) != null)
            {
                    return this.m_BeamGeom.<meshRenderer>k__BackingField.bounds;
            }
            
                return this.m_BeamGeom.<meshRenderer>k__BackingField.bounds;
            }
            
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            val_0.m_Center.z = 0f;
            val_0.m_Extents.x = 0f;
            val_0.m_Extents.y = 0f;
            val_0.m_Extents.z = 0f;
            val_0.m_Center.x = 0f;
            val_0.m_Center.y = 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetClippingPlane(UnityEngine.Plane planeWS)
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.m_BeamGeom)) != false)
            {
                    this.m_BeamGeom.SetClippingPlane(planeWS:  new UnityEngine.Plane() {m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = planeWS.m_Normal.z}, m_Distance = planeWS.m_Distance});
            }
            
            this.m_PlaneWS = V0.16B;
            mem[1152921528931573404] = V1.16B;
            mem[1152921528931573408] = V2.16B;
            mem[1152921528931573412] = V3.16B;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetClippingPlaneOff()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.m_BeamGeom)) != false)
            {
                    this.m_BeamGeom.SetClippingPlaneOff();
            }
            
            this.m_PlaneWS = 0;
            mem[1152921528931701792] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsColliderHiddenByDynamicOccluder(UnityEngine.Collider collider)
        {
            float val_4;
            float val_5;
            UnityEngine.Plane val_8;
            var val_9;
            var val_10;
            val_9 = null;
            if((VLB.Utils.IsValid(plane:  new UnityEngine.Plane() {m_Normal = new UnityEngine.Vector3() {x = VLB.Utils>>0&0xFFFFFFFF, y = VLB.Utils>>32&0x0, z = collider}, m_Distance = collider})) != false)
            {
                    UnityEngine.Plane[] val_2 = new UnityEngine.Plane[1];
                val_8 = this.m_PlaneWS;
                val_2[0] = val_8;
                val_2[0] = new UnityEngine.Plane();
                val_2[1] = new UnityEngine.Plane();
                val_2[1] = new UnityEngine.Plane();
                UnityEngine.Bounds val_3 = collider.bounds;
                val_10 = (UnityEngine.GeometryUtility.TestPlanesAABB(planes:  val_2, bounds:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, m_Extents = new UnityEngine.Vector3() {x = val_5, y = val_4, z = val_4}})) ^ 1;
                return (bool)val_10 & 1;
            }
            
            val_10 = 0;
            return (bool)val_10 & 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_blendingModeAsInt()
        {
            return UnityEngine.Mathf.Clamp(value:  this.blendingMode, min:  0, max:  System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).Length);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint get__INTERNAL_InstancedMaterialGroupID()
        {
            return (uint)this.<_INTERNAL_InstancedMaterialGroupID>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void set__INTERNAL_InstancedMaterialGroupID(uint value)
        {
            this.<_INTERNAL_InstancedMaterialGroupID>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_meshStats()
        {
            object val_8;
            UnityEngine.Mesh val_9;
            var val_10;
            val_8 = 1152921504851574784;
            if((UnityEngine.Object.op_Implicit(exists:  this.m_BeamGeom)) != false)
            {
                    val_9 = this.m_BeamGeom.<coneMesh>k__BackingField;
            }
            else
            {
                    val_9 = 0;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  val_9)) != false)
            {
                    int val_4 = val_9.vertexCount;
                val_8 = val_4;
                val_9 = val_9.triangles;
                int val_8 = val_5.Length;
                val_8 = val_8 * 1431655766;
                val_8 = val_8 >> 32;
                val_8 = val_8 + (val_8 >> 63);
                string val_7 = System.String.Format(format:  "Cone angle: {0:0.0} degrees\nMesh: {1} vertices, {2} triangles", arg0:  this.coneAngle, arg1:  val_4, arg2:  val_8);
                return (string)val_10;
            }
            
            val_10 = "no mesh available";
            return (string)val_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_meshVerticesCount()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.m_BeamGeom)) == false)
            {
                    return 0;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.m_BeamGeom.<coneMesh>k__BackingField)) == false)
            {
                    return 0;
            }
            
            if((this.m_BeamGeom.<coneMesh>k__BackingField) != null)
            {
                    return this.m_BeamGeom.<coneMesh>k__BackingField.vertexCount;
            }
            
            return this.m_BeamGeom.<coneMesh>k__BackingField.vertexCount;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_meshTrianglesCount()
        {
            var val_6;
            var val_7;
            val_6 = this;
            if((UnityEngine.Object.op_Implicit(exists:  this.m_BeamGeom)) != false)
            {
                    if((UnityEngine.Object.op_Implicit(exists:  this.m_BeamGeom.<coneMesh>k__BackingField)) != false)
            {
                    val_6 = this.m_BeamGeom.<coneMesh>k__BackingField.triangles;
                int val_5 = val_3.Length;
                val_5 = val_5 * 1431655766;
                val_5 = val_5 >> 32;
                val_7 = val_5 + (val_5 >> 63);
                return (int)val_7;
            }
            
            }
            
            val_7 = 0;
            return (int)val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Light get_lightSpotAttached()
        {
            UnityEngine.Light val_5;
            UnityEngine.Light val_6;
            if(this._CachedLight == 0)
            {
                    val_5 = this.GetComponent<UnityEngine.Light>();
                this._CachedLight = val_5;
            }
            else
            {
                    val_5 = this._CachedLight;
            }
            
            val_6 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  val_5)) == false)
            {
                    return val_6;
            }
            
            val_6 = 0;
            if(this._CachedLight.type != 0)
            {
                    return val_6;
            }
            
            val_6 = this._CachedLight;
            return val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GetInsideBeamFactor(UnityEngine.Vector3 posWS)
        {
            UnityEngine.Vector3 val_2 = this.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = posWS.x, y = posWS.y, z = posWS.z});
            return this.GetInsideBeamFactorFromObjectSpacePos(posOS:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GetInsideBeamFactorFromObjectSpacePos(UnityEngine.Vector3 posOS)
        {
            float val_7;
            float val_8;
            val_7 = posOS.z;
            if(val_7 < 0)
            {
                    return (float)UnityEngine.Mathf.Clamp(value:  val_10 = val_10 / 0.1f, min:  -1f, max:  1f);
            }
            
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  posOS.x, y:  posOS.y);
            float val_2 = this.coneRadiusEnd;
            val_2 = this.coneRadiusStart / val_2;
            float val_8 = 1f;
            if(val_2 == val_8)
            {
                    val_8 = 3.402823E+38f;
            }
            else
            {
                    float val_7 = this.fallOffEnd;
                val_7 = val_2 * val_7;
                val_2 = val_8 - val_2;
                val_8 = val_7 / val_2;
            }
            
            val_8 = val_7 + val_8;
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  posOS.x, y:  val_8);
            UnityEngine.Vector2 val_4 = val_3.x.normalized;
            val_7 = val_4.x;
            float val_9 = 0.01745329f;
            val_9 = this.coneAngle * val_9;
            val_9 = val_9 * 0.5f;
            float val_10 = System.Math.Abs(val_9);
            val_10 = val_10 - System.Math.Abs(val_7);
            return (float)UnityEngine.Mathf.Clamp(value:  val_10, min:  -1f, max:  1f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Generate()
        {
            goto typeof(VLB.VolumetricLightBeam).__il2cppRuntimeField_168;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void GenerateGeometry()
        {
            this.HandleBackwardCompatibility(serializedVersion:  this.pluginVersion, newVersion:  164);
            this.pluginVersion = 1700;
            this.ValidateProperties();
            if(this.m_BeamGeom == 0)
            {
                    VLB.BeamGeometry val_2 = VLB.Utils.NewWithComponent<VLB.BeamGeometry>(name:  "Beam Geometry");
                this.m_BeamGeom = val_2;
                val_2.Initialize(master:  this);
            }
            
            this.m_BeamGeom.RegenerateMesh();
            this.m_BeamGeom.visible = this.enabled;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void UpdateAfterManualPropertyChange()
        {
            this.ValidateProperties();
            if((UnityEngine.Object.op_Implicit(exists:  this.m_BeamGeom)) == false)
            {
                    return;
            }
            
            this.m_BeamGeom.UpdateMaterialAndBounds();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            goto typeof(VLB.VolumetricLightBeam).__il2cppRuntimeField_168;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.m_BeamGeom)) != false)
            {
                    this.m_BeamGeom.visible = true;
            }
            
            this.StartPlaytimeUpdateIfNeeded();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.m_BeamGeom)) != false)
            {
                    this.m_BeamGeom.visible = false;
            }
            
            this.m_CoPlaytimeUpdate = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StartPlaytimeUpdateIfNeeded()
        {
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            if(this._TrackChangesDuringPlaytime == false)
            {
                    return;
            }
            
            if(this.m_CoPlaytimeUpdate != null)
            {
                    return;
            }
            
            this.m_CoPlaytimeUpdate = this.StartCoroutine(routine:  this.CoPlaytimeUpdate());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator CoPlaytimeUpdate()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new VolumetricLightBeam.<CoPlaytimeUpdate>d__124();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            this.DestroyBeam();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DestroyBeam()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.m_BeamGeom)) != false)
            {
                    UnityEngine.Object.DestroyImmediate(obj:  this.m_BeamGeom.gameObject);
            }
            
            this.m_BeamGeom = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AssignPropertiesFromSpotLight(UnityEngine.Light lightSpot)
        {
            if((UnityEngine.Object.op_Implicit(exists:  lightSpot)) == false)
            {
                    return;
            }
            
            if(lightSpot.type != 0)
            {
                    return;
            }
            
            if(this.intensityFromLight != false)
            {
                    this.intensityModeAdvanced = false;
                float val_3 = lightSpot.intensity;
                this.intensityInside = val_3;
                this.intensityOutside = val_3;
            }
            
            if(this.fallOffEndFromLight != false)
            {
                    this.fallOffEnd = lightSpot.range;
            }
            
            if(this.spotAngleFromLight != false)
            {
                    this.spotAngle = lightSpot.spotAngle;
            }
            
            if(this.colorFromLight == false)
            {
                    return;
            }
            
            this.colorMode = 0;
            UnityEngine.Color val_6 = lightSpot.color;
            this.color = val_6;
            mem[1152921528934603892] = val_6.g;
            mem[1152921528934603896] = val_6.b;
            mem[1152921528934603900] = val_6.a;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ClampProperties()
        {
            this.intensityInside = UnityEngine.Mathf.Clamp(value:  this.intensityInside, min:  0f, max:  8f);
            this.intensityOutside = UnityEngine.Mathf.Clamp(value:  this.intensityOutside, min:  0f, max:  8f);
            this.attenuationCustomBlending = UnityEngine.Mathf.Clamp01(value:  this.attenuationCustomBlending);
            float val_4 = UnityEngine.Mathf.Max(a:  0.01f, b:  this.fallOffEnd);
            this.fallOffEnd = val_4;
            this.fallOffStart = UnityEngine.Mathf.Clamp(value:  this.fallOffStart, min:  0f, max:  val_4 + (-0.01f));
            this.spotAngle = UnityEngine.Mathf.Clamp(value:  this.spotAngle, min:  0.1f, max:  179.9f);
            this.coneRadiusStart = UnityEngine.Mathf.Max(a:  this.coneRadiusStart, b:  0f);
            this.depthBlendDistance = UnityEngine.Mathf.Max(a:  this.depthBlendDistance, b:  0f);
            this.cameraClippingDistance = UnityEngine.Mathf.Max(a:  this.cameraClippingDistance, b:  0f);
            this.geomCustomSides = UnityEngine.Mathf.Clamp(value:  this.geomCustomSides, min:  3, max:  256);
            this.geomCustomSegments = UnityEngine.Mathf.Clamp(value:  this.geomCustomSegments, min:  0, max:  64);
            this.fresnelPow = UnityEngine.Mathf.Max(a:  0f, b:  this.fresnelPow);
            this.glareBehind = UnityEngine.Mathf.Clamp01(value:  this.glareBehind);
            this.glareFrontal = UnityEngine.Mathf.Clamp01(value:  this.glareFrontal);
            this.noiseIntensity = UnityEngine.Mathf.Clamp(value:  this.noiseIntensity, min:  0f, max:  1f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ValidateProperties()
        {
            this.AssignPropertiesFromSpotLight(lightSpot:  this.lightSpotAttached);
            this.ClampProperties();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
        {
            if(serializedVersion == 1)
            {
                    return;
            }
            
            if(serializedVersion == newVersion)
            {
                    return;
            }
            
            if(serializedVersion > 1300)
            {
                goto label_3;
            }
            
            this.attenuationEquation = 0;
            goto label_4;
            label_3:
            if(serializedVersion > 1500)
            {
                goto label_5;
            }
            
            label_4:
            this.geomMeshType = 1;
            this.geomCustomSegments = 5;
            label_10:
            this.intensityFromLight = false;
            bool val_2 = ~(UnityEngine.Mathf.Approximately(a:  this.intensityInside, b:  this.intensityOutside));
            val_2 = val_2 & 1;
            this.intensityModeAdvanced = val_2;
            return;
            label_5:
            if(serializedVersion <= 1609)
            {
                goto label_10;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VolumetricLightBeam()
        {
            var val_1;
            this.colorFromLight = true;
            val_1 = null;
            val_1 = null;
            this.intensityInside = 1f;
            this.intensityOutside = 1f;
            this.spotAngle = 35f;
            this.coneRadiusStart = 7.346868E-41f;
            this.geomCustomSides = 18;
            this.geomCustomSegments = 5;
            this.attenuationEquation = 1;
            this.fallOffEnd = 3f;
            this.boostDistanceInside = 0.5f;
            this.fresnelPowInside = 0f;
            this.fresnelPow = 8f;
            this.noiseIntensity = 0.5f;
            this.noiseScaleLocal = 0.5f;
            this.intensityFromLight = true;
            this.spotAngleFromLight = true;
            this.fallOffEndFromLight = true;
            this.noiseScaleUseGlobal = true;
            this.noiseVelocityUseGlobal = true;
            this.depthBlendDistance = ;
            this.cameraClippingDistance = ;
            this.glareFrontal = 0.5f;
            this.glareBehind = 0.5f;
            this.color = VLB.Consts.FlatColor;
            mem[1152921528935068276] = VLB.Consts.ConfigSharedMeshSegments.__il2cppRuntimeField_8;
            mem[1152921528935068284] = VLB.Consts.ConfigSharedMeshSegments.__il2cppRuntimeField_10;
            this.fadeOutBegin = -150f;
            this.fadeOutEnd = -200f;
            this.pluginVersion = 0;
            this.noiseVelocityLocal = VLB.Consts.NoiseVelocityDefault;
            mem[1152921528935068412] = VLB.Consts.ConfigSharedMeshSegments.__il2cppRuntimeField_1C;
        }
    
    }

}
