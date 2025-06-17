using UnityEngine;

namespace VLB
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class Utils
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static VLB.Utils.FloatPackingPrecision ms_FloatPackingPrecision;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int kFloatPackingHighMinShaderLevel = 35;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string GetPath(UnityEngine.Transform current)
        {
            bool val_2 = UnityEngine.Object.op_Equality(x:  current.parent, y:  0);
            if(current != null)
            {
                    if(val_2 == false)
            {
                    return current.parent + "/"("/") + current.name;
            }
            
                return "/"("/") + current.name;
            }
            
            if(val_2 == true)
            {
                    return "/"("/") + current.name;
            }
            
            return current.parent + "/"("/") + current.name;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static T NewWithComponent<T>(string name)
        {
            System.Type[] val_1 = new System.Type[1];
            System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48});
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(val_2 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_2 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = val_2;
            if((new UnityEngine.GameObject(name:  name, components:  val_1)) == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static T GetOrAddComponent<T>(UnityEngine.GameObject self)
        {
            var val_7;
            UnityEngine.Object val_8;
            val_7 = __RuntimeMethodHiddenParam;
            val_8 = self;
            if(val_8 != 0)
            {
                    return (object)val_8;
            }
            
            val_7 = ???;
            val_8 = ???;
            goto __RuntimeMethodHiddenParam + 48 + 16;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static T GetOrAddComponent<T>(UnityEngine.MonoBehaviour self)
        {
            UnityEngine.GameObject val_1 = self.gameObject;
            goto __RuntimeMethodHiddenParam + 48;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool HasFlag(System.Enum mask, System.Enum flags)
        {
            var val_2 = mem[mask];
            val_2 = mem[flags] & val_2;
            return (bool)(val_2 == mem[flags]) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Vector2 xy(UnityEngine.Vector3 aVector)
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  aVector.x, y:  aVector.y);
            return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Vector2 xz(UnityEngine.Vector3 aVector)
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  aVector.x, y:  aVector.z);
            return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Vector2 yz(UnityEngine.Vector3 aVector)
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  aVector.y, y:  aVector.z);
            return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Vector2 yx(UnityEngine.Vector3 aVector)
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  aVector.y, y:  aVector.x);
            return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Vector2 zx(UnityEngine.Vector3 aVector)
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  aVector.z, y:  aVector.x);
            return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Vector2 zy(UnityEngine.Vector3 aVector)
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  aVector.z, y:  aVector.y);
            return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static float GetVolumeCubic(UnityEngine.Bounds self)
        {
            float val_1 = V0.16B * V1.16B;
            val_1 = val_1 * S2;
            return (float)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static float GetMaxArea2D(UnityEngine.Bounds self)
        {
            float val_2 = V1.16B * V2.16B;
            float val_3 = UnityEngine.Mathf.Max(a:  V0.16B * V1.16B, b:  val_2);
            val_2 = val_3 * S2;
            return UnityEngine.Mathf.Max(a:  val_3, b:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Color Opaque(UnityEngine.Color self)
        {
            return new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GizmosDrawPlane(UnityEngine.Vector3 normal, UnityEngine.Vector3 position, UnityEngine.Color color, float size = 1)
        {
            float val_9;
            float val_10;
            float val_16;
            float val_17;
            float val_18;
            float val_19;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.forward;
            if((System.Math.Abs(UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z}, rhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}))) < 0)
            {
                    UnityEngine.Vector3 val_3 = UnityEngine.Vector3.forward;
            }
            else
            {
                    UnityEngine.Vector3 val_4 = UnityEngine.Vector3.up;
            }
            
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z}, rhs:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  color.b);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.AngleAxis(angle:  90f, axis:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z});
            UnityEngine.Vector3 val_12 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w}, point:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            UnityEngine.Matrix4x4 val_15 = UnityEngine.Matrix4x4.identity;
            UnityEngine.Gizmos.matrix = new UnityEngine.Matrix4x4() {m00 = val_18, m10 = val_18, m20 = val_18, m30 = val_18, m01 = val_19, m11 = val_19, m21 = val_19, m31 = val_19, m02 = val_16, m12 = val_16, m22 = val_16, m32 = val_16, m03 = val_17, m13 = val_17, m23 = val_17, m33 = val_17};
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = color.r, g = val_10, b = color.g, a = val_9};
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, to:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, to:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, to:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, to:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, to:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, to:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Plane TranslateCustom(UnityEngine.Plane plane, UnityEngine.Vector3 translation)
        {
            float val_1 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = translation.x, y = translation.y, z = translation.z}, rhs:  new UnityEngine.Vector3() {x = translation.x, y = translation.y, z = translation.z});
            val_1 = val_1 * val_1;
            val_1 = translation.x + val_1;
            return new UnityEngine.Plane() {m_Normal = new UnityEngine.Vector3() {x = -4.992285E-14f, y = 2.524356E-29f, z = 0f}, m_Distance = 0f};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsValid(UnityEngine.Plane plane)
        {
            return (bool)(S0 > 0.5f) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetKeywordEnabled(UnityEngine.Material mat, string name, bool enabled)
        {
            if(mat == null)
            {
                goto label_0;
            }
            
            if(enabled == false)
            {
                goto label_1;
            }
            
            label_2:
            mat.EnableKeyword(keyword:  name);
            return;
            label_0:
            if(enabled == true)
            {
                goto label_2;
            }
            
            label_1:
            mat.DisableKeyword(keyword:  name);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetShaderKeywordEnabled(string name, bool enabled)
        {
            if(enabled != false)
            {
                    UnityEngine.Shader.EnableKeyword(keyword:  name);
                return;
            }
            
            UnityEngine.Shader.DisableKeyword(keyword:  name);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Matrix4x4 SampleInMatrix(UnityEngine.Gradient self, int floatPackingPrecision)
        {
            UnityEngine.Matrix4x4 val_0;
            var val_5 = 0;
            do
            {
                float val_4 = 0f;
                val_4 = val_4 / 15f;
                UnityEngine.Color val_2 = self.Evaluate(time:  UnityEngine.Mathf.Clamp01(value:  val_4));
                float val_3 = VLB.Utils.PackToFloat(color:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a}, floatPackingPrecision:  floatPackingPrecision);
                val_5 = val_5 + 1;
            }
            while(val_5 != 16);
            
            val_0.m02 = 0f;
            val_0.m12 = 0f;
            val_0.m22 = 0f;
            val_0.m32 = 0f;
            val_0.m03 = 0f;
            val_0.m13 = 0f;
            val_0.m23 = 0f;
            val_0.m33 = 0f;
            val_0.m00 = 0f;
            val_0.m10 = 0f;
            val_0.m20 = 0f;
            val_0.m30 = 0f;
            val_0.m01 = 0f;
            val_0.m11 = 0f;
            val_0.m21 = 0f;
            val_0.m31 = 0f;
            return val_0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Color[] SampleInArray(UnityEngine.Gradient self, int samplesCount)
        {
            UnityEngine.Color[] val_1 = new UnityEngine.Color[0];
            if()
            {
                    return val_1;
            }
            
            var val_6 = 0;
            do
            {
                float val_5 = 0f;
                val_5 = val_5 / ((float)samplesCount - 1);
                UnityEngine.Color val_4 = self.Evaluate(time:  UnityEngine.Mathf.Clamp01(value:  val_5));
                val_6 = val_6 + 1;
                mem2[0] = val_4.r;
                mem2[0] = val_4.g;
                mem2[0] = val_4.b;
                mem2[0] = val_4.a;
            }
            while(samplesCount != val_6);
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.Vector4 Vector4_Floor(UnityEngine.Vector4 vec)
        {
            return new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static float PackToFloat(UnityEngine.Color color, int floatPackingPrecision)
        {
            UnityEngine.Color val_2 = UnityEngine.Color.op_Multiply(a:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, b:  (float)floatPackingPrecision - 1);
            UnityEngine.Vector4 val_3 = UnityEngine.Color.op_Implicit(c:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
            UnityEngine.Vector4 val_4 = VLB.Utils.Vector4_Floor(vec:  new UnityEngine.Vector4() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
            val_4.x = val_4.x * (float)floatPackingPrecision;
            val_4.x = val_4.x * (float)floatPackingPrecision;
            val_4.y = val_4.y * (float)floatPackingPrecision;
            val_4.x = val_4.x * (float)floatPackingPrecision;
            val_4.y = val_4.y * (float)floatPackingPrecision;
            val_4.x = val_4.x + 0f;
            val_4.x = val_4.y + val_4.x;
            val_4.x = (val_4.z * (float)floatPackingPrecision) + val_4.x;
            val_4.x = val_4.w + val_4.x;
            return (float)val_4.x;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static VLB.Utils.FloatPackingPrecision GetFloatPackingPrecision()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if(VLB.Utils.kFloatPackingHighMinShaderLevel == 0)
            {
                    val_4 = null;
                val_4 = null;
                VLB.Utils.kFloatPackingHighMinShaderLevel = (UnityEngine.SystemInfo.graphicsShaderLevel > 34) ? 64 : 8;
                val_3 = null;
            }
            
            val_3 = null;
            return (FloatPackingPrecision)VLB.Utils.kFloatPackingHighMinShaderLevel;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void MarkCurrentSceneDirty()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void MarkObjectDirty(UnityEngine.Object obj)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Utils()
        {
        
        }
    
    }

}
