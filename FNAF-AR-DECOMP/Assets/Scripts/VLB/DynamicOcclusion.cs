using UnityEngine;

namespace VLB
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DynamicOcclusion : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VLB.OccluderDimensions dimensions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.LayerMask layerMask;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool considerTriggers;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float minOccluderArea;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int waitFrameCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float minSurfaceRatio;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float maxSurfaceDot;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VLB.PlaneAlignment planeAlignment;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float planeOffset;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private VLB.VolumetricLightBeam m_Master;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int m_FrameCountToWait;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float m_RangeMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private uint m_PrevNonSubHitDirectionId;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.QueryTriggerInteraction queryTriggerInteraction { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float raycastMaxDistance { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnValidate()
        {
            this.minOccluderArea = UnityEngine.Mathf.Max(a:  this.minOccluderArea, b:  0f);
            this.waitFrameCount = UnityEngine.Mathf.Clamp(value:  this.waitFrameCount, min:  1, max:  60);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            this.m_Master = this.GetComponent<VLB.VolumetricLightBeam>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            this.SetClippingPlaneOff();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.GetComponent<VLB.TriggerZone>())) == false)
            {
                    return;
            }
            
            this.m_RangeMultiplier = UnityEngine.Mathf.Max(a:  1f, b:  val_2.rangeMultiplier);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LateUpdate()
        {
            int val_1 = this.m_FrameCountToWait;
            if(val_1 <= 0)
            {
                    this.ProcessRaycasts();
                val_1 = this.waitFrameCount;
                this.m_FrameCountToWait = val_1;
            }
            
            val_1 = val_1 - 1;
            this.m_FrameCountToWait = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 GetRandomVectorAround(UnityEngine.Vector3 direction, float angleDiff)
        {
            float val_1 = angleDiff * 0.5f;
            float val_2 = angleDiff * (-0.5f);
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Euler(x:  UnityEngine.Random.Range(min:  val_2, max:  val_1), y:  UnityEngine.Random.Range(min:  val_2, max:  val_1), z:  UnityEngine.Random.Range(min:  val_2, max:  val_1));
            return UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w}, point:  new UnityEngine.Vector3() {x = direction.x, y = direction.y, z = direction.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.QueryTriggerInteraction get_queryTriggerInteraction()
        {
            return (UnityEngine.QueryTriggerInteraction)(this.considerTriggers == true) ? (1 + 1) : 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float get_raycastMaxDistance()
        {
            UnityEngine.Vector3 val_2 = this.transform.lossyScale;
            float val_3 = this.m_Master.fallOffEnd * this.m_RangeMultiplier;
            val_3 = val_3 * val_2.z;
            return (float)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private VLB.DynamicOcclusion.HitResult GetBestHit(UnityEngine.Vector3 rayPos, UnityEngine.Vector3 rayDir)
        {
            if(this.dimensions != 1)
            {
                    return this.GetBestHit3D(rayPos:  new UnityEngine.Vector3() {x = rayPos.x, y = rayPos.y, z = rayPos.z}, rayDir:  new UnityEngine.Vector3() {x = rayDir.x, y = rayDir.y, z = rayDir.z});
            }
            
            return this.GetBestHit2D(rayPos:  new UnityEngine.Vector3() {x = rayPos.x, y = rayPos.y, z = rayPos.z}, rayDir:  new UnityEngine.Vector3() {x = rayDir.x, y = rayDir.y, z = rayDir.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private VLB.DynamicOcclusion.HitResult GetBestHit3D(UnityEngine.Vector3 rayPos, UnityEngine.Vector3 rayDir)
        {
            float val_7;
            float val_8;
            float val_14;
            var val_15;
            var val_16;
            var val_17;
            val_14 = 3.402823E+38f;
            val_15 = 0;
            val_16 = 0;
            goto label_1;
            label_11:
            var val_5 = 0 + 32;
            UnityEngine.Bounds val_6 = val_5.bounds;
            if((VLB.Utils.GetMaxArea2D(self:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_8}, m_Extents = new UnityEngine.Vector3() {x = val_8, y = val_7, z = val_7}})) >= this.minOccluderArea)
            {
                    if(val_5.targetValue < 0)
            {
                    val_14 = val_5.targetValue;
                val_16 = val_15;
            }
            
            }
            
            val_15 = 1;
            label_1:
            if(val_15 < val_4.Length)
            {
                goto label_11;
            }
            
            if(val_16 != 1)
            {
                    var val_12 = (UnityEngine.Physics.RaycastAll(origin:  new UnityEngine.Vector3() {x = rayPos.x, y = rayPos.y, z = rayPos.z}, direction:  new UnityEngine.Vector3() {x = rayDir.x, y = rayDir.y, z = rayDir.z}, maxDistance:  this.raycastMaxDistance, layerMask:  this.layerMask.value, queryTriggerInteraction:  (this.considerTriggers == true) ? (1 + 1) : 1)) + (0 * 44);
                val_7 = (0 * 44) + val_4 + 48;
                val_8 = (0 * 44) + val_4 + 32;
                DynamicOcclusion.HitResult val_13 = null;
                val_17 = val_13;
                val_13 = new DynamicOcclusion.HitResult(hit3D:  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_8}, m_Normal = new UnityEngine.Vector3() {x = val_8, y = val_7, z = val_7}, m_FaceID = val_7, m_Distance = val_7, m_UV = new UnityEngine.Vector2() {x = val_7, y = val_7}, m_Collider = val_7});
                return (HitResult)val_17;
            }
            
            DynamicOcclusion.HitResult val_14 = null;
            val_17 = val_14;
            val_14 = new DynamicOcclusion.HitResult();
            return (HitResult)val_17;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private VLB.DynamicOcclusion.HitResult GetBestHit2D(UnityEngine.Vector3 rayPos, UnityEngine.Vector3 rayDir)
        {
            float val_10;
            float val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  rayPos.x, y:  rayPos.y);
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  rayDir.x, y:  rayDir.y);
            UnityEngine.RaycastHit2D[] val_5 = UnityEngine.Physics2D.RaycastAll(origin:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, direction:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, distance:  this.raycastMaxDistance, layerMask:  this.layerMask.value);
            val_15 = 3.402823E+38f;
            val_16 = 0;
            val_17 = 0;
            goto label_3;
            label_17:
            if(this.considerTriggers == true)
            {
                goto label_4;
            }
            
            val_18 = 0 + 32;
            if(val_18.isTrigger == true)
            {
                goto label_14;
            }
            
            label_4:
            val_18 = (val_5 + (0 * 36)) + 32;
            UnityEngine.Bounds val_9 = val_18.bounds;
            if((VLB.Utils.GetMaxArea2D(self:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = val_1.x}, m_Extents = new UnityEngine.Vector3() {y = val_10, z = val_10}})) >= this.minOccluderArea)
            {
                    if(val_18.startValue < 0)
            {
                    val_15 = val_18.startValue;
                val_17 = val_16;
            }
            
            }
            
            label_14:
            val_16 = 1;
            label_3:
            if(val_16 < val_5.Length)
            {
                goto label_17;
            }
            
            if(val_17 != 1)
            {
                    var val_14 = val_5 + (0 * 36);
                val_10 = (0 * 36) + val_5 + 48;
                DynamicOcclusion.HitResult val_15 = null;
                val_19 = val_15;
                val_15 = new DynamicOcclusion.HitResult(hit2D:  new UnityEngine.RaycastHit2D() {m_Centroid = new UnityEngine.Vector2() {x = (0 * 36) + val_5 + 32, y = (0 * 36) + val_5 + 32}, m_Point = new UnityEngine.Vector2() {x = (0 * 36) + val_5 + 32, y = (0 * 36) + val_5 + 32}, m_Normal = new UnityEngine.Vector2() {x = val_10, y = val_10}, m_Distance = val_10, m_Fraction = val_10, m_Collider = (0 * 36) + val_5 + 64});
                return (HitResult)val_19;
            }
            
            DynamicOcclusion.HitResult val_16 = null;
            val_19 = val_16;
            val_16 = new DynamicOcclusion.HitResult();
            return (HitResult)val_19;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 GetDirection(uint dirInt)
        {
            int val_3 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).Length;
            uint val_4 = dirInt / val_3;
            val_4 = dirInt - (val_4 * val_3);
            if(val_4 > 3)
            {
                    return UnityEngine.Vector3.zero;
            }
            
            var val_6 = 52948112 + (dirInt - ((dirInt / val_3) * val_3)) << 2;
            val_6 = val_6 + 52948112;
            goto (52948112 + (dirInt - ((dirInt / val_3) * val_3)) << 2 + 52948112);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsHitValid(VLB.DynamicOcclusion.HitResult hit)
        {
            var val_7;
            if(hit.hasCollider != false)
            {
                    UnityEngine.Vector3 val_3 = this.transform.forward;
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
                var val_6 = ((UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = hit.normal, y = V9.16B, z = V10.16B}, rhs:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z})) >= this.maxSurfaceDot) ? 1 : 0;
                return (bool)val_7;
            }
            
            val_7 = 0;
            return (bool)val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessRaycasts()
        {
            float val_31;
            float val_32;
            HitResult val_33;
            uint val_34;
            float val_35;
            float val_36;
            UnityEngine.Vector3 val_2 = this.transform.position;
            val_31 = val_2.x;
            val_32 = val_2.z;
            UnityEngine.Vector3 val_4 = this.transform.forward;
            val_33 = this.GetBestHit(rayPos:  new UnityEngine.Vector3() {x = val_31, y = val_2.y, z = val_32}, rayDir:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            if((this.IsHitValid(hit:  val_33)) == false)
            {
                goto label_3;
            }
            
            if(this.minSurfaceRatio <= 0.5f)
            {
                goto label_4;
            }
            
            val_34 = 0;
            val_32 = -1f;
            goto label_5;
            label_22:
            UnityEngine.Vector3 val_8 = this.GetDirection(dirInt:  val_34 + this.m_PrevNonSubHitDirectionId);
            UnityEngine.Vector3 val_10 = this.transform.position;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  this.m_Master.coneRadiusStart);
            float val_31 = this.minSurfaceRatio;
            val_31 = val_31 + val_31;
            val_31 = val_31 + val_32;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  val_31);
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            UnityEngine.Vector3 val_15 = this.transform.position;
            UnityEngine.Vector3 val_17 = this.transform.forward;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, d:  this.m_Master.fallOffEnd);
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  this.m_Master.coneRadiusEnd);
            float val_32 = this.minSurfaceRatio;
            val_32 = -1f;
            val_32 = val_32 + val_32;
            val_32 = val_32 + val_32;
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, d:  val_32);
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, b:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
            val_35 = val_13.x;
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, b:  new UnityEngine.Vector3() {x = val_35, y = val_13.y, z = val_13.z});
            HitResult val_25 = this.GetBestHit(rayPos:  new UnityEngine.Vector3() {x = val_35, y = val_13.y, z = val_13.z}, rayDir:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
            if((this.IsHitValid(hit:  val_25)) == false)
            {
                goto label_14;
            }
            
            val_36 = val_25.distance;
            val_34 = 1;
            label_5:
            if(val_34 < (System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).Length))
            {
                goto label_22;
            }
            
            label_4:
            this.SetHit(hit:  (val_36 > val_5.distance) ? (val_25) : (val_33));
            return;
            label_14:
            this.m_PrevNonSubHitDirectionId = val_34;
            label_3:
            this.SetClippingPlaneOff();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetHit(VLB.DynamicOcclusion.HitResult hit)
        {
            UnityEngine.Vector3 val_4;
            var val_5;
            var val_6;
            if(this.planeAlignment != 1)
            {
                goto label_1;
            }
            
            UnityEngine.Vector3 val_2 = this.transform.forward;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            val_4 = val_3.x;
            val_5 = val_3.y;
            val_6 = val_3.z;
            if(hit != null)
            {
                goto label_8;
            }
            
            goto label_6;
            label_1:
            if(hit == null)
            {
                goto label_7;
            }
            
            val_4 = hit.normal;
            goto label_8;
            label_7:
            val_4 = hit.normal;
            label_6:
            label_8:
            this.SetClippingPlane(planeWS:  new UnityEngine.Plane() {m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f}});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetHitNull()
        {
            this.SetClippingPlaneOff();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetClippingPlane(UnityEngine.Plane planeWS)
        {
            var val_3;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, d:  this.planeOffset);
            val_3 = null;
            UnityEngine.Plane val_2 = VLB.Utils.TranslateCustom(plane:  new UnityEngine.Plane() {m_Normal = new UnityEngine.Vector3() {x = VLB.Utils>>0&0xFFFFFFFF, y = VLB.Utils>>32&0x0, z = 0f}, m_Distance = 0f}, translation:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
            this.m_Master.SetClippingPlane(planeWS:  new UnityEngine.Plane() {m_Normal = new UnityEngine.Vector3() {x = val_2.m_Normal.z, y = val_2.m_Distance, z = planeWS.m_Normal.z}, m_Distance = planeWS.m_Distance});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetClippingPlaneOff()
        {
            this.m_Master.SetClippingPlaneOff();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DynamicOcclusion()
        {
            null = null;
            this.waitFrameCount = 3;
            this.minSurfaceRatio = 0.5f;
            this.maxSurfaceDot = 0.25f;
            this.planeOffset = 0.1f;
            this.layerMask = VLB.Consts.DynOcclusionLayerMaskDefault;
            this.m_RangeMultiplier = 1f;
        }
    
    }

}
