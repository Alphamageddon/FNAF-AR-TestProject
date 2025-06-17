using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LineMeshModifier : MeshModifier
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Width;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _scaledWidth;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override Mapbox.Unity.MeshGeneration.Modifiers.ModifierType Type { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override Mapbox.Unity.MeshGeneration.Modifiers.ModifierType get_Type()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void OnEnable()
        {
            this._scaledWidth = this.Width;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Run(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature, Mapbox.Unity.MeshGeneration.Data.MeshData md, float scale)
        {
            scale = this.Width * scale;
            this._scaledWidth = scale;
            this.ExtureLine(feature:  feature, md:  md);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Run(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature, Mapbox.Unity.MeshGeneration.Data.MeshData md, Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            float val_3 = this.Width;
            if(tile != 0)
            {
                    val_3 = val_3 * tile.TileScale;
            }
            
            this._scaledWidth = val_3;
            this.ExtureLine(feature:  feature, md:  md);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ExtureLine(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature, Mapbox.Unity.MeshGeneration.Data.MeshData md)
        {
            var val_4;
            var val_55;
            Mapbox.Unity.MeshGeneration.Modifiers.LineMeshModifier val_56;
            float val_58;
            var val_59;
            float val_60;
            UnityEngine.Vector3[] val_61;
            var val_62;
            float val_63;
            float val_64;
            float val_68;
            float val_69;
            float val_70;
            float val_71;
            float val_72;
            float val_73;
            var val_74;
            var val_75;
            var val_76;
            float val_77;
            float val_78;
            UnityEngine.Vector3[] val_79;
            var val_80;
            float val_81;
            float val_82;
            float val_83;
            float val_84;
            float val_85;
            var val_86;
            float val_87;
            var val_88;
            var val_89;
            var val_90;
            val_55 = md;
            val_56 = this;
            if(feature.Points.Count < 1)
            {
                    return;
            }
            
            List.Enumerator<T> val_2 = feature.Points.GetEnumerator();
            label_85:
            if(((-2080495360) & 1) == 0)
            {
                    return;
            }
            
            var val_76 = val_4.emailUIDataHandler;
            int val_6 = md.Vertices.Count;
            int val_7 = val_76.Count;
            int val_8 = val_7 << 1;
            var val_9 = (md.Edges == 0) ? 1 : 0;
            int val_10 = val_8 - 2;
            if(md.Edges >= 0)
            {
                    do
            {
                md.Edges.Add(item:  val_6 + 1);
                md.Edges.Add(item:  (val_6 + 1) - 1);
                var val_14 = (md.Edges == 0) ? 1 : 0;
            }
            while(2 < val_8);
            
            }
            
            md.Edges.Add(item:  val_6);
            int val_16 = (val_8 + val_6) - 1;
            md.Edges.Add(item:  val_16);
            UnityEngine.Vector3[] val_17 = new UnityEngine.Vector3[0];
            UnityEngine.Vector3[] val_18 = new UnityEngine.Vector3[0];
            UnityEngine.Vector2[] val_19 = new UnityEngine.Vector2[0];
            UnityEngine.Vector4[] val_20 = new UnityEngine.Vector4[0];
            if(val_7 >= 2)
            {
                    UnityEngine.Vector2[] val_58 = val_19;
                int val_21 = val_8 - 1;
                val_58 = val_58 + (val_21 << 3);
                val_21 = val_58 + 32;
                val_58 = val_58 + 36;
                UnityEngine.Vector4[] val_59 = val_20[val_21 << 4][32];
                UnityEngine.Vector4[] val_60 = val_20[val_21 << 4][36];
                UnityEngine.Vector4[] val_61 = val_20[val_21 << 4][40];
                UnityEngine.Vector4[] val_62 = val_20[val_21 << 4][44];
                val_58 = (long)val_7;
                UnityEngine.Vector3[] val_22 = val_18 + ((val_20[0x3C][((val_7 << 1) - 1)]) << 2);
                UnityEngine.Vector3[] val_63 = val_17[(val_20[0x3C][((val_7 << 1) - 1)]) << 2][32];
                UnityEngine.Vector3[] val_64 = val_17[(val_20[0x3C][((val_7 << 1) - 1)]) << 2][40];
                UnityEngine.Vector3[] val_65 = val_17[(val_20[0x3C][((val_7 << 1) - 1)]) << 2][36];
                UnityEngine.Vector3[] val_23 = val_22 + 32;
                val_59 = 0;
                UnityEngine.Vector3[] val_24 = val_22 + 36;
                val_22 = val_22 + 40;
                do
            {
                UnityEngine.Vector3 val_25 = val_76.Item[0];
                val_63 = val_25.x;
                val_60 = val_25.y;
                val_64 = val_25.z;
                UnityEngine.Vector3 val_26 = val_76.Item[1];
                val_68 = val_26.x;
                val_69 = val_26.y;
                val_70 = val_26.z;
                val_71 = val_68;
                if(2 < val_58)
            {
                    UnityEngine.Vector3 val_27 = val_76.Item[2];
                val_71 = val_27.x;
            }
            
                if(val_59 == 0)
            {
                    UnityEngine.Vector3 val_28 = val_76.GetNormal(p1:  new UnityEngine.Vector3() {x = val_63, y = val_60, z = val_64}, newPos:  new UnityEngine.Vector3() {x = val_63, y = val_60, z = val_64}, p2:  new UnityEngine.Vector3() {x = val_68, y = val_70});
                UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, d:  this._scaledWidth);
                UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_63, y = val_60, z = val_64}, b:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z});
                val_17[0] = val_30;
                val_17[0] = val_30.y;
                val_17[1] = val_30.z;
                val_64 = val_64;
                UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_63, y = val_60, z = val_64}, b:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z});
                mem2[0] = val_31.x;
                mem2[0] = val_31.y;
                mem2[0] = val_31.z;
                val_61 = val_18;
                val_62 = null;
                val_72 = val_70;
                val_73 = val_68;
                val_60 = val_60;
                val_71 = val_71;
                if(val_61 == 0)
            {
                    val_61 = val_18;
            }
            
                val_74 = mem[1152921519706310072];
                if(val_74 == 0)
            {
                    val_61 = val_18;
                val_74 = mem[1152921519706310072];
            }
            
                mem[1152921519706310080] = Constants.Math.Vector3Up;
                mem[1152921519706310084] = Constants.Math.Vector3Zero.__il2cppRuntimeField_10;
                mem[1152921519706310088] = Constants.Math.Vector3Zero.__il2cppRuntimeField_14;
                mem2[0] = Constants.Math.Vector3Up;
                mem2[0] = Constants.Math.Vector3Zero.__il2cppRuntimeField_10;
                mem2[0] = Constants.Math.Vector3Zero.__il2cppRuntimeField_14;
                UnityEngine.Vector2 val_32 = new UnityEngine.Vector2(x:  0f, y:  0f);
                mem[1152921519706314176] = val_32.x;
                mem[1152921519706314180] = val_32.y;
                UnityEngine.Vector2 val_33 = new UnityEngine.Vector2(x:  1f, y:  0f);
                float val_34 =  - val_63;
                float val_35 =  - val_64;
                mem2[0] = val_33.x;
                mem2[0] = val_33.y;
                float val_66 = val_69;
                val_4 = 0;
                val_66 = val_66 - val_60;
                val_75 = mem[1152921519706318264];
                if(val_75 == 0)
            {
                    val_75 = mem[1152921519706318264];
            }
            
                mem[1152921519706318272] = val_4;
                mem[1152921519706318276] = val_66;
                mem[1152921519706318280] = val_35;
                mem[1152921519706318284] = 1f;
                if(val_75 != 0)
            {
                    val_76 = 0;
                val_77 = val_66;
                val_58 = val_35;
                val_78 = 1f;
            }
            else
            {
                    val_76 = mem[1152921519706318272];
                val_77 = mem[1152921519706318276];
                val_58 = mem[1152921519706318280];
                val_78 = mem[1152921519706318284];
                val_75 = mem[1152921519706318264];
            }
            
                val_63 = val_63;
                val_70 = val_70;
                val_68 = val_68;
                val_69 = val_69;
                mem2[0] = val_76;
                mem2[0] = val_77;
                mem2[0] = val_58;
                mem2[0] = val_78;
                val_56 = val_56;
                val_59 = val_59;
            }
            
                UnityEngine.Vector3 val_37 = this.GetNormal(p1:  new UnityEngine.Vector3() {x = val_63, y = val_60, z = val_64}, newPos:  new UnityEngine.Vector3() {x = val_68, y = val_69, z = val_70}, p2:  new UnityEngine.Vector3() {x = val_71, y = val_27.z});
                UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z}, d:  this._scaledWidth);
                UnityEngine.Vector3 val_39 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_68, y = val_69, z = val_70}, b:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z});
                var val_40 = val_59 + 1;
                mem2[0] = val_39.x;
                mem2[0] = val_39.y;
                mem2[0] = val_39.z;
                UnityEngine.Vector3 val_41 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_68, y = val_69, z = val_70}, b:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z});
                var val_67 = 12;
                val_67 = val_17 + ((long)val_10 * val_67);
                mem2[0] = val_41.x;
                mem2[0] = val_41.y;
                mem2[0] = val_41.z;
                val_79 = val_18;
                val_80 = null;
                val_81 = 1f;
                val_83 = val_64;
                val_82 = 0f;
                val_84 = val_63;
                val_85 = val_60;
                if( == 0)
            {
                    val_79 = val_18;
            }
            
                if(val_40 >= mem[1152921519706310072])
            {
                    val_79 = val_18;
            }
            
                mem[1152921519706310092] = Constants.Math.Vector3Up;
                mem[1152921519706310096] = Constants.Math.Vector3Zero.__il2cppRuntimeField_10;
                mem[1152921519706310100] = Constants.Math.Vector3Zero.__il2cppRuntimeField_14;
                var val_68 = 12;
                 =  + (UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_63, y = val_60, z = val_64}, b:  new UnityEngine.Vector3() {x = val_68, y = val_69, z = val_70}));
                val_68 = val_18 + ((long)val_10 * val_68);
                mem2[0] = Constants.Math.Vector3Up;
                mem2[0] = Constants.Math.Vector3Zero.__il2cppRuntimeField_10;
                mem2[0] = Constants.Math.Vector3Zero.__il2cppRuntimeField_14;
                UnityEngine.Vector2 val_42 = new UnityEngine.Vector2(x:  0f, y:  null);
                mem[1152921519706314184] = val_42.x;
                mem[1152921519706314188] = val_42.y;
                UnityEngine.Vector2 val_43 = new UnityEngine.Vector2(x:  null, y:  null);
                UnityEngine.Vector2[] val_69 = val_19;
                float val_70 = val_68;
                float val_44 = val_69 - ;
                val_69 = val_69 + (((long)(int)(((val_7 << 1) - 2))) << 3);
                mem2[0] = val_43.x;
                mem2[0] = val_43.y;
                float val_71 = val_70;
                val_70 = val_70 - ;
                val_4 = 0;
                val_71 = val_71 - ;
                mem2[0] = val_4;
                mem2[0] = val_44;
                mem2[0] = val_71;
                mem2[0] = ;
                val_86 = mem[1152921519706318264];
                if(val_40 < val_86)
            {
                    val_87 = 1f;
                val_88 = val_71;
                val_89 = val_44;
                val_90 = 0;
            }
            else
            {
                    val_86 = mem[1152921519706318264];
                val_90 = val_20[0x3C] + -12;
                val_89 = val_20[0x3C] + -12 + 4;
                val_88 = val_20[0x3C] + -4;
                val_87 = mem[val_20[0x3C] + -4 + 4];
                val_87 = val_20[0x3C] + -4 + 4;
            }
            
                UnityEngine.Vector3[] val_72 = val_17[52];
                UnityEngine.Vector4[] val_73 = val_20;
                val_72 = val_72 + 12;
                val_73 = val_73 + (((long)(int)(((val_7 << 1) - 2))) << 4);
                int val_74 = val_10;
                val_74 = val_74 - 1;
                mem2[0] = val_90;
                mem2[0] = val_89;
                mem2[0] = val_88;
                mem2[0] = val_87;
                UnityEngine.Vector4[] val_75 = val_20[60];
                val_75 = val_75 + 16;
            }
            while(2 < val_58);
            
            }
            
            md.Vertices.AddRange(collection:  val_17);
            md.Normals.AddRange(collection:  val_18);
            md.UV.Item[0].AddRange(collection:  val_19);
            md.Tangents.AddRange(collection:  val_20);
            System.Collections.Generic.List<System.Int32> val_46 = new System.Collections.Generic.List<System.Int32>();
            val_76 = val_7 - 1;
            if(val_76 >= 1)
            {
                    var val_77 = 0;
                do
            {
                null.Add(item:  val_6 + val_77);
                int val_49 = (val_6 + val_77) + 1;
                null.Add(item:  val_49);
                null.Add(item:  val_16);
                null.Add(item:  val_49);
                null.Add(item:  val_16 - 1);
                null.Add(item:  val_16);
                val_77 = val_77 + 1;
            }
            while(val_77 < val_76);
            
            }
            
            if(md.Triangles.Count <= 0)
            {
                    System.Collections.Generic.List<System.Int32> val_52 = new System.Collections.Generic.List<System.Int32>();
                md.Triangles.Add(item:  null);
            }
            
            md.Triangles.Item[0].AddRange(collection:  null);
            goto label_85;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 GetNormal(UnityEngine.Vector3 p1, UnityEngine.Vector3 newPos, UnityEngine.Vector3 p2)
        {
            float val_1;
            float val_11;
            var val_12;
            val_11 = newPos.z;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = newPos.x, y = newPos.y, z = val_11}, rhs:  new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z})) != true)
            {
                    if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = newPos.x, y = newPos.y, z = val_11}, rhs:  new UnityEngine.Vector3() {x = p2.x, y = val_1, z = p2.y})) != true)
            {
                    UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = p2.x, y = val_1, z = p2.y}, b:  new UnityEngine.Vector3() {x = newPos.x, y = newPos.y, z = val_11});
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = newPos.x, y = newPos.y, z = val_11});
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z}, b:  new UnityEngine.Vector3() {x = newPos.x, y = newPos.y, z = val_11});
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = newPos.x, y = newPos.y, z = val_11});
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
                val_11 = val_8.z;
                val_12 = null;
                val_12 = null;
                if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_11}, rhs:  new UnityEngine.Vector3() {x = Constants.Math.Vector3Zero, y = Constants.Math.Vector3Zero.__il2cppRuntimeField_4, z = Constants.Math.Vector3Zero.__il2cppRuntimeField_8})) == false)
            {
                    return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            }
            
            }
            
            }
            
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = p2.x, y = val_1, z = p2.y}, b:  new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z});
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LineMeshModifier()
        {
            this.Width = 3f;
            mem[1152921519706563512] = 1;
            val_1 = new UnityEngine.ScriptableObject();
        }
    
    }

}
