using UnityEngine;

namespace VLB
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class MeshGenerator
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float kMinTruncatedRadius = 0.001;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static float GetAngleOffset(int numSides)
        {
            return (float)(numSides != 4) ? 0f : 0.7853982f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
        {
            float val_1 = 0.01745329f;
            val_1 = coneAngle * val_1;
            val_1 = val_1 * 0.5f;
            coneAngle = val_1 * lengthZ;
            cap = cap;
            doubleSided = doubleSided;
            return VLB.MeshGenerator.GenerateConeZ_Radius(lengthZ:  lengthZ, radiusStart:  radiusStart, radiusEnd:  coneAngle, numSides:  numSides, numSegments:  numSegments, cap:  cap, doubleSided:  doubleSided);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
        {
            return VLB.MeshGenerator.GenerateConeZ_RadiusAndAngle(lengthZ:  lengthZ, radiusStart:  0f, coneAngle:  coneAngle, numSides:  numSides, numSegments:  numSegments, cap:  cap, doubleSided:  doubleSided);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
        {
            int val_52;
            float val_54;
            float val_55;
            float val_56;
            float val_57;
            System.Array val_58;
            int val_59;
            int val_61;
            int val_62;
            int val_63;
            UnityEngine.Vector2[] val_64;
            int val_65;
            int val_66;
            var val_67;
            int val_68;
            var val_69;
            var val_70;
            int val_71;
            int val_72;
            UnityEngine.Mesh val_73;
            System.Int32[] val_74;
            val_52 = numSides;
            UnityEngine.Mesh val_1 = new UnityEngine.Mesh();
            bool val_2 = (radiusStart > 0f) ? 1 : 0;
            val_2 = val_2 & cap;
            float val_3 = UnityEngine.Mathf.Max(a:  radiusStart, b:  0.001f);
            int val_4 = numSegments + 2;
            int val_5 = val_4 * val_52;
            val_54 = 0f;
            int val_7 = ((val_2 == false) ? 0 : (val_52 + 1)) + val_5;
            float val_8 = (val_52 != 4) ? (val_54) : 0.7853982f;
            UnityEngine.Vector3[] val_9 = new UnityEngine.Vector3[0];
            if(val_52 >= 1)
            {
                    int val_64 = numSegments;
                val_56 = 6.283185f;
                var val_68 = 0;
                val_64 = val_64 + 1;
                do
            {
                float val_65 = 0f;
                val_65 = val_65 * val_56;
                val_65 = val_65 / (float)val_52;
                val_54 = val_8;
                float val_10 = val_54 + val_65;
                val_55 = val_10;
                val_57 = val_55;
                if(val_4 >= 1)
            {
                    var val_66 = 0;
                var val_67 = val_68;
                do
            {
                float val_11 = 0f / (float)val_64;
                float val_12 = UnityEngine.Mathf.Lerp(a:  val_3, b:  radiusEnd, t:  val_11);
                val_54 = val_57 * val_12;
                float val_14 = val_11 * lengthZ;
                val_55 = val_10 * val_12;
                val_58 = 0;
                var val_15 = val_9 + (0 * 12);
                mem2[0] = 0;
                mem2[0] = val_58;
                mem2[0] = 0;
                val_52 = val_52;
                val_66 = val_66 + 1;
                val_67 = val_67 + val_52;
            }
            while(val_4 != val_66);
            
            }
            
                val_68 = val_68 + 1;
            }
            while(val_68 != val_52);
            
            }
            
            val_59 = numSegments;
            if(val_2 != false)
            {
                    UnityEngine.Vector3 val_16 = UnityEngine.Vector3.zero;
                val_57 = val_16.y;
                var val_69 = 12;
                val_69 = val_9 + ((long)val_5 * val_69);
                mem2[0] = val_16.x;
                mem2[0] = val_57;
                mem2[0] = val_16.z;
                if(val_52 >= 1)
            {
                    var val_71 = 0;
                val_56 = (float)val_52;
                do
            {
                float val_70 = 0f;
                val_70 = val_70 * 6.283185f;
                val_70 = val_70 / val_56;
                float val_19 = val_8 + val_70;
                val_57 = val_19;
                val_54 = val_3 * val_19;
                val_55 = val_3 * val_57;
                val_58 = 0;
                val_71 = val_71 + 1;
                var val_21 = val_9 + (((long)(val_5 + 1) + val_71) * 12);
                mem2[0] = 0;
                mem2[0] = val_58;
                mem2[0] = 0;
            }
            while(val_52 != val_71);
            
            }
            
            }
            
            if(doubleSided == false)
            {
                goto label_23;
            }
            
            UnityEngine.Vector3[] val_22 = new UnityEngine.Vector3[0];
            val_61 = val_7;
            val_58 = val_22;
            if(val_9 == null)
            {
                goto label_25;
            }
            
            val_9.CopyTo(array:  val_22, index:  0);
            goto label_26;
            label_23:
            val_61 = val_7;
            val_1.vertices = val_9;
            val_62 = val_5;
            goto label_28;
            label_25:
            0.CopyTo(array:  val_22, index:  0);
            label_26:
            val_62 = val_5;
            val_9.CopyTo(array:  val_22, index:  val_9.Length);
            val_1.vertices = val_22;
            label_28:
            int val_23 = val_52 + 1;
            UnityEngine.Vector2[] val_24 = new UnityEngine.Vector2[0];
            if(val_62 >= 1)
            {
                    val_58 = 1152921504853065728;
                var val_72 = 0;
                do
            {
                UnityEngine.Vector2 val_25 = UnityEngine.Vector2.zero;
                val_57 = val_25.y;
                val_72 = val_72 + 1;
                mem2[0] = val_25.x;
                mem2[0] = val_57;
            }
            while(val_62 != val_72);
            
                val_63 = val_5;
            }
            else
            {
                    val_63 = 0;
            }
            
            var val_26 = (val_23 > 0) ? 1 : 0;
            val_26 = val_2 & val_26;
            if(val_26 == true)
            {
                    do
            {
                UnityEngine.Vector2 val_27 = new UnityEngine.Vector2(x:  1f, y:  0f);
                val_58 = val_27.y;
                val_23 = val_23 - 1;
                val_63 = val_63 + 1;
                val_24[0] = val_27.x;
                val_24[0] = val_58;
            }
            while(val_23 != 0);
            
            }
            
            if(doubleSided == false)
            {
                goto label_41;
            }
            
            UnityEngine.Vector2[] val_29 = new UnityEngine.Vector2[0];
            val_58 = val_29;
            if(val_24 == null)
            {
                goto label_43;
            }
            
            val_24.CopyTo(array:  val_29, index:  0);
            goto label_44;
            label_41:
            val_64 = val_24;
            goto label_46;
            label_43:
            0.CopyTo(array:  val_29, index:  0);
            label_44:
            val_24.CopyTo(array:  val_29, index:  val_24.Length);
            val_65 = val_24.Length;
            if(val_65 >= 1)
            {
                    var val_75 = 0;
                do
            {
                if(val_58 == null)
            {
                    val_65 = val_24.Length;
            }
            
                val_65 = val_75 + val_65;
                UnityEngine.Vector2 val_30 = new UnityEngine.Vector2(x:  val_58[(long)val_65], y:  1f);
                int val_74 = val_24.Length;
                val_63 = val_30.x;
                val_74 = val_75 + val_74;
                val_58[(long)val_74] = val_63;
                val_58[(long)val_74] = val_30.y;
                val_75 = val_75 + 1;
            }
            while(val_75 < val_24.Length);
            
            }
            
            val_64 = val_58;
            label_46:
            val_1.uv = val_29;
            int val_31 = val_59 + 1;
            int val_36 = ((val_2 == true) ? (val_52 + (val_52 << 1)) : 0) + ((val_52 * (UnityEngine.Mathf.Max(a:  val_31, b:  1))) * 6);
            int[] val_37 = new int[0];
            val_66 = val_5;
            val_67 = 0;
            if(val_2 >= false)
            {
                    int val_76 = 6;
                val_76 = val_76 + (val_59 * 6);
                do
            {
                val_68 = 1;
                int val_39 = (val_68 == val_52) ? 0 : (0 + 1);
                if(val_31 >= 1)
            {
                    val_68 = val_52 + val_39;
                var val_78 = val_31;
                var val_77 = val_67;
                do
            {
                var val_41 = val_77 + 1;
                val_37[0] = 0 + 0;
                var val_44 = val_77 + 2;
                val_39 = val_39 + 0;
                val_37[((long)(int)((val_67 + 1))) << 2] = val_39;
                var val_46 = val_77 + 3;
                int val_47 = (val_52 + 0) + 0;
                val_37[((long)(int)((val_67 + 2))) << 2] = val_47;
                var val_49 = val_77 + 4;
                val_37[((long)(int)((val_67 + 3))) << 2] = val_68 + 0;
                var val_51 = val_77 + 5;
                val_77 = (((val_77 + 1) + 1) + 1) + 1;
                val_37[((long)(int)((val_67 + 4))) << 2] = val_47;
                val_52 = val_52;
                val_37[((long)(int)((val_67 + 5))) << 2] = val_39;
                val_59 = val_39;
                val_78 = val_78 - 1;
                val_63 = 0 + val_52;
                val_77 = (val_77 + 1) + 1;
            }
            while(val_78 != 0);
            
                val_66 = val_5;
                val_67 = val_76 + val_67;
                val_68 = val_68;
            }
            
                val_58 = val_68;
            }
            while(1 != val_52);
            
            }
            
            if(val_2 == false)
            {
                goto label_66;
            }
            
            val_69 = 0;
            goto label_67;
            label_72:
            val_66 = val_66 + val_69;
            val_37[((0 + numSides)) << 2] = val_66 + 2;
            val_67 = 4;
            val_37[((long)(int)((val_67 + 5))) << 2] = val_66 + 1;
            val_66 = val_5;
            val_69 = 1;
            label_67:
            val_58 = val_67;
            var val_55 = val_67 + 2;
            val_63 = 5;
            val_37[16] = val_66;
            if(val_69 < (val_52 - 1))
            {
                goto label_72;
            }
            
            val_37[20] = val_66 + 1;
            val_37[((long)(int)((val_67 + 2))) << 2] = val_66 + val_52;
            label_66:
            if(doubleSided == false)
            {
                goto label_75;
            }
            
            int[] val_58 = new int[0];
            val_63 = val_58;
            val_37.CopyTo(array:  val_58, index:  0);
            val_70 = 0;
            goto label_78;
            label_87:
            int val_79 = val_37[0];
            int val_80 = val_37.Length;
            val_79 = val_79 + val_7;
            val_80 = val_70 + val_80;
            val_63[((long)(int)((val_70 + val_37.Length))) << 2] = val_79;
            val_71 = val_37.Length;
            long val_82 = 2;
            if(2 >= val_71)
            {
                    val_71 = val_37.Length;
            }
            
            val_71 = val_70 + val_71;
            val_71 = val_71 + 1;
            val_66 = (long)val_71;
            val_58 = val_37[8] + val_7;
            val_63[((long)(int)(((val_70 + val_37.Length) + 1))) << 2] = val_58;
            val_72 = val_37.Length;
            val_82 = val_82 - 1;
            if(val_82 >= val_72)
            {
                    val_72 = val_37.Length;
            }
            
            val_72 = val_70 + val_72;
            val_72 = val_72 + 2;
            val_70 = val_82 + 2;
            val_63[((long)(int)(((val_70 + val_37.Length) + 2))) << 2] = val_37[4] + val_7;
            label_78:
            if(val_70 < val_37.Length)
            {
                goto label_87;
            }
            
            val_73 = val_1;
            val_74 = val_63;
            goto label_89;
            label_75:
            val_73 = val_1;
            val_74 = val_37;
            label_89:
            val_1.triangles = val_37;
            float val_60 = lengthZ * 0.5f;
            float val_84 = radiusEnd;
            float val_63 = (UnityEngine.Mathf.Max(a:  val_3, b:  radiusEnd)) + (UnityEngine.Mathf.Max(a:  val_3, b:  radiusEnd));
            val_84 = (UnityEngine.Mathf.Max(a:  val_3, b:  val_84)) + (UnityEngine.Mathf.Max(a:  val_3, b:  val_84));
            val_1.bounds = new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Extents = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}};
            return val_73;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
        {
            int val_1 = numSegments + 2;
            val_1 = (((geomCap & true) != 0) ? 0 : (numSides + 1)) + (val_1 * numSides);
            numSides = val_1 << doubleSided;
            return (int)numSides;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
        {
            int val_1 = numSegments + 1;
            val_1 = numSides * val_1;
            val_1 = ((geomCap != true) ? (numSides + (numSides << 1)) : 0) + (val_1 * 6);
            numSides = val_1 << doubleSided;
            return (int)numSides;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int GetSharedMeshVertexCount()
        {
            VLB.Config val_1 = VLB.Config.Instance;
            VLB.Config val_2 = VLB.Config.Instance;
            VLB.Config val_3 = VLB.Config.Instance;
            int val_4 = val_2.sharedMeshSegments + 2;
            val_4 = val_1.sharedMeshSides + (val_4 * val_1.sharedMeshSides);
            val_4 = val_4 + 1;
            return (int)val_4 << ((val_3.renderingMode != 0) ? 1 : 0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int GetSharedMeshIndicesCount()
        {
            VLB.Config val_1 = VLB.Config.Instance;
            VLB.Config val_2 = VLB.Config.Instance;
            VLB.Config val_3 = VLB.Config.Instance;
            var val_6 = 6;
            val_6 = val_2.sharedMeshSegments * val_6;
            val_6 = val_6 + 9;
            val_6 = val_6 * val_1.sharedMeshSides;
            return (int)val_6 << ((val_3.renderingMode != 0) ? 1 : 0);
        }
    
    }

}
