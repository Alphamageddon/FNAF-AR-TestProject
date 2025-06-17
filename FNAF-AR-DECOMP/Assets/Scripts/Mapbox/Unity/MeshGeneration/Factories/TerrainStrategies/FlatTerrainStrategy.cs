using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Factories.TerrainStrategies
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FlatTerrainStrategy : TerrainStrategy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Mesh _cachedQuad;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Initialize(Mapbox.Unity.Map.ElevationLayerProperties elOptions)
        {
            mem[1152921519755077824] = elOptions;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void RegisterTile(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            if((mem[69738552] + 16) != 0)
            {
                    if(tile.gameObject.layer != (X22 + 56 + 20))
            {
                    tile.gameObject.layer = X22 + 56 + 56 + 20;
            }
            
            }
            
            if((tile._rasterDataState != 3) && (tile._rasterDataState != 0))
            {
                    UnityEngine.Material val_10 = tile.MeshRenderer.materials[0];
                UnityEngine.Material[] val_7 = new UnityEngine.Material[2];
                val_7[0] = val_10;
                val_7[1] = val_10;
                tile.MeshRenderer.materials = val_7;
            }
            
            UnityEngine.Material val_11 = val_7[4];
            tile.MeshFilter.sharedMesh = this.GetQuad(tile:  tile, buildSide:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Mesh GetQuad(Mapbox.Unity.MeshGeneration.Data.UnityTile tile, bool buildSide)
        {
            if(this._cachedQuad != 0)
            {
                    return (UnityEngine.Mesh)this._cachedQuad;
            }
            
            if(buildSide == false)
            {
                    return this.BuildQuad(tile:  tile);
            }
            
            return this.BuildQuadWithSides(tile:  tile);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Mesh BuildQuad(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            var val_33;
            float val_34;
            var val_35;
            int val_36;
            UnityEngine.Mesh val_1 = new UnityEngine.Mesh();
            UnityEngine.Vector3[] val_2 = new UnityEngine.Vector3[4];
            UnityEngine.Vector3[] val_3 = new UnityEngine.Vector3[4];
            if(tile != null)
            {
                    val_33 = tile;
                val_34 = tile.<TileScale>k__BackingField;
            }
            else
            {
                    val_33 = 176;
                val_34 = 2.802597E-45f;
            }
            
            Mapbox.Utils.Vector2d val_4 = tile.<Rect>k__BackingField.Min;
            Mapbox.Utils.Vector2d val_5 = tile.<Rect>k__BackingField.<Min>k__BackingField.Size;
            Mapbox.Utils.Vector2d val_6 = Mapbox.Utils.Vector2d.op_Subtraction(a:  new Mapbox.Utils.Vector2d() {x = val_4.x, y = val_4.y}, b:  new Mapbox.Utils.Vector2d() {x = val_5.x, y = val_5.y});
            UnityEngine.Vector3 val_7 = Mapbox.Unity.Utilities.VectorExtensions.ToVector3xz(v:  new Mapbox.Utils.Vector2d() {x = val_6.x, y = val_6.y});
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(d:  val_34, a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            val_2[0] = val_8;
            val_2[0] = val_8.y;
            val_2[1] = val_8.z;
            Mapbox.Utils.Vector2d val_9 = tile.<Rect>k__BackingField.<Min>k__BackingField.Min;
            Mapbox.Utils.Vector2d val_10 = tile.<Rect>k__BackingField.<Min>k__BackingField.Size;
            Mapbox.Utils.Vector2d val_11 = tile.<Rect>k__BackingField.<Min>k__BackingField.Min;
            Mapbox.Utils.Vector2d val_12 = tile.<Rect>k__BackingField.<Min>k__BackingField.Size;
            double val_13 = val_9.x - val_10.x;
            val_12.y = val_11.y - val_12.y;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(d:  2.802597E-45f, a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_2[1] = val_14;
            val_2[2] = val_14.y;
            val_2[2] = val_14.z;
            Mapbox.Utils.Vector2d val_15 = tile.<Rect>k__BackingField.<Min>k__BackingField.Min;
            Mapbox.Utils.Vector2d val_16 = tile.<Rect>k__BackingField.<Min>k__BackingField.Size;
            Mapbox.Utils.Vector2d val_17 = Mapbox.Utils.Vector2d.op_Subtraction(a:  new Mapbox.Utils.Vector2d() {x = val_15.x, y = val_15.y}, b:  new Mapbox.Utils.Vector2d() {x = val_16.x, y = val_16.y});
            UnityEngine.Vector3 val_18 = Mapbox.Unity.Utilities.VectorExtensions.ToVector3xz(v:  new Mapbox.Utils.Vector2d() {x = val_17.x, y = val_17.y});
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(d:  2.802597E-45f, a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            val_2[3] = val_19;
            val_2[3] = val_19.y;
            val_2[4] = val_19.z;
            Mapbox.Utils.Vector2d val_20 = tile.<Rect>k__BackingField.<Min>k__BackingField.Min;
            Mapbox.Utils.Vector2d val_21 = tile.<Rect>k__BackingField.<Min>k__BackingField.Size;
            Mapbox.Utils.Vector2d val_22 = tile.<Rect>k__BackingField.<Min>k__BackingField.Min;
            Mapbox.Utils.Vector2d val_23 = tile.<Rect>k__BackingField.<Min>k__BackingField.Size;
            double val_24 = val_20.x - val_21.x;
            val_23.y = val_22.y - val_23.y;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Multiply(d:  2.802597E-45f, a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_2[4] = val_25;
            val_2[5] = val_25.y;
            val_2[5] = val_25.z;
            val_35 = null;
            val_35 = null;
            val_36 = val_3.Length;
            if(val_36 == 0)
            {
                    val_36 = val_3.Length;
            }
            
            val_3[0] = Constants.Math.Vector3Up;
            val_3[0] = new UnityEngine.Vector3();
            val_3[1] = new UnityEngine.Vector3();
            if(val_36 <= 1)
            {
                    val_36 = val_3.Length;
            }
            
            val_3[1] = Constants.Math.Vector3Up;
            val_3[2] = new UnityEngine.Vector3();
            val_3[2] = new UnityEngine.Vector3();
            if(val_36 <= 2)
            {
                    val_36 = val_3.Length;
            }
            
            val_3[3] = Constants.Math.Vector3Up;
            val_3[3] = new UnityEngine.Vector3();
            val_3[4] = new UnityEngine.Vector3();
            val_3[4] = Constants.Math.Vector3Up;
            val_3[5] = new UnityEngine.Vector3();
            val_3[5] = new UnityEngine.Vector3();
            if(val_1 != null)
            {
                    val_1.vertices = val_2;
            }
            else
            {
                    val_1.vertices = val_2;
            }
            
            val_1.normals = val_3;
            val_1.SetTriangles(triangles:  new int[6] {0, 1, 2, 0, 2, 3}, submesh:  0);
            UnityEngine.Vector2[] val_27 = new UnityEngine.Vector2[4];
            UnityEngine.Vector2 val_28 = new UnityEngine.Vector2(x:  0f, y:  1f);
            val_27[0] = val_28.x;
            val_27[0] = val_28.y;
            UnityEngine.Vector2 val_29 = new UnityEngine.Vector2(x:  1f, y:  1f);
            val_27[1] = val_29.x;
            val_27[1] = val_29.y;
            UnityEngine.Vector2 val_30 = new UnityEngine.Vector2(x:  1f, y:  0f);
            val_27[2] = val_30.x;
            val_27[2] = val_30.y;
            UnityEngine.Vector2 val_31 = new UnityEngine.Vector2(x:  0f, y:  0f);
            val_27[3] = val_31.x;
            val_27[3] = val_31.y;
            val_1.uv = val_27;
            tile.MeshFilter.sharedMesh = val_1;
            this._cachedQuad = val_1;
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Mesh BuildQuadWithSides(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            var val_43;
            var val_44;
            var val_45;
            int val_46;
            int val_47;
            int val_48;
            int val_49;
            int val_50;
            UnityEngine.Mesh val_1 = new UnityEngine.Mesh();
            UnityEngine.Vector3[] val_2 = new UnityEngine.Vector3[20];
            UnityEngine.Vector3[] val_3 = new UnityEngine.Vector3[20];
            if(tile != null)
            {
                    val_43 = tile;
            }
            else
            {
                    val_43 = 176;
            }
            
            Mapbox.Utils.Vector2d val_4 = tile.<Rect>k__BackingField.Min;
            Mapbox.Utils.Vector2d val_5 = tile.<Rect>k__BackingField.<Min>k__BackingField.Size;
            Mapbox.Utils.Vector2d val_6 = Mapbox.Utils.Vector2d.op_Subtraction(a:  new Mapbox.Utils.Vector2d() {x = val_4.x, y = val_4.y}, b:  new Mapbox.Utils.Vector2d() {x = val_5.x, y = val_5.y});
            UnityEngine.Vector3 val_7 = Mapbox.Unity.Utilities.VectorExtensions.ToVector3xz(v:  new Mapbox.Utils.Vector2d() {x = val_6.x, y = val_6.y});
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(d:  2.802597E-45f, a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            val_2[0] = val_8;
            val_2[0] = val_8.y;
            val_2[1] = val_8.z;
            Mapbox.Utils.Vector2d val_9 = tile.<Rect>k__BackingField.<Min>k__BackingField.Min;
            Mapbox.Utils.Vector2d val_10 = tile.<Rect>k__BackingField.<Min>k__BackingField.Size;
            Mapbox.Utils.Vector2d val_11 = tile.<Rect>k__BackingField.<Min>k__BackingField.Min;
            Mapbox.Utils.Vector2d val_12 = tile.<Rect>k__BackingField.<Min>k__BackingField.Size;
            double val_13 = val_9.x - val_10.x;
            val_12.y = val_11.y - val_12.y;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(d:  2.802597E-45f, a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_2[1] = val_14;
            val_2[2] = val_14.y;
            val_2[2] = val_14.z;
            Mapbox.Utils.Vector2d val_15 = tile.<Rect>k__BackingField.<Min>k__BackingField.Min;
            Mapbox.Utils.Vector2d val_16 = tile.<Rect>k__BackingField.<Min>k__BackingField.Size;
            Mapbox.Utils.Vector2d val_17 = Mapbox.Utils.Vector2d.op_Subtraction(a:  new Mapbox.Utils.Vector2d() {x = val_15.x, y = val_15.y}, b:  new Mapbox.Utils.Vector2d() {x = val_16.x, y = val_16.y});
            UnityEngine.Vector3 val_18 = Mapbox.Unity.Utilities.VectorExtensions.ToVector3xz(v:  new Mapbox.Utils.Vector2d() {x = val_17.x, y = val_17.y});
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(d:  2.802597E-45f, a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            val_2[3] = val_19;
            val_2[3] = val_19.y;
            val_2[4] = val_19.z;
            Mapbox.Utils.Vector2d val_20 = tile.<Rect>k__BackingField.<Min>k__BackingField.Min;
            Mapbox.Utils.Vector2d val_21 = tile.<Rect>k__BackingField.<Min>k__BackingField.Size;
            Mapbox.Utils.Vector2d val_22 = tile.<Rect>k__BackingField.<Min>k__BackingField.Min;
            Mapbox.Utils.Vector2d val_23 = tile.<Rect>k__BackingField.<Min>k__BackingField.Size;
            double val_24 = val_20.x - val_21.x;
            val_23.y = val_22.y - val_23.y;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Multiply(d:  2.802597E-45f, a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_2[4] = val_25;
            val_2[5] = val_25.y;
            val_2[5] = val_25.z;
            val_44 = null;
            val_44 = null;
            val_45 = mem[1152921519755857832];
            if(val_45 == 0)
            {
                    val_45 = mem[1152921519755857832];
            }
            
            mem[1152921519755857840] = Constants.Math.Vector3Up;
            mem[1152921519755857844] = Constants.Math.Vector3Zero.__il2cppRuntimeField_10;
            mem[1152921519755857848] = Constants.Math.Vector3Zero.__il2cppRuntimeField_14;
            if(val_45 <= 1)
            {
                    val_45 = mem[1152921519755857832];
            }
            
            mem[1152921519755857852] = Constants.Math.Vector3Up;
            mem[1152921519755857856] = Constants.Math.Vector3Zero.__il2cppRuntimeField_10;
            mem[1152921519755857860] = Constants.Math.Vector3Zero.__il2cppRuntimeField_14;
            if(val_45 <= 2)
            {
                    val_45 = mem[1152921519755857832];
            }
            
            mem[1152921519755857864] = Constants.Math.Vector3Up;
            mem[1152921519755857868] = Constants.Math.Vector3Zero.__il2cppRuntimeField_10;
            mem[1152921519755857872] = Constants.Math.Vector3Zero.__il2cppRuntimeField_14;
            mem[1152921519755857876] = Constants.Math.Vector3Up;
            mem[1152921519755857880] = Constants.Math.Vector3Zero.__il2cppRuntimeField_10;
            mem[1152921519755857884] = Constants.Math.Vector3Zero.__il2cppRuntimeField_14;
            val_1.subMeshCount = 2;
            UnityEngine.Vector3[] val_26 = val_3 + 124;
            var val_54 = 4;
            do
            {
                val_46 = val_2.Length;
                if(0 >= val_46)
            {
                    val_46 = val_2.Length;
            }
            
                mem2[0] = null;
                mem2[0] = null;
                mem2[0] = null;
                val_47 = val_2.Length;
                var val_27 = 0 + 1;
                if(val_27 >= val_47)
            {
                    val_47 = val_2.Length;
            }
            
                mem2[0] = null;
                mem2[0] = null;
                mem2[0] = null;
                val_27 = val_27 - 1;
                UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 4.372641E+10f, y = 4.372641E+10f, z = 4.372641E+10f}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                var val_30 = val_54 + 2;
                val_2[0x50].Length = val_29.x;
                mem2[0] = val_29.y;
                val_2[80] = val_29.z;
                UnityEngine.Vector3 val_32 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 4.372641E+10f, y = 4.372641E+10f, z = 4.372641E+10f}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                var val_33 = val_54 + 3;
                val_2[80] = val_32;
                val_2[80] = val_32.y;
                val_2[80] = val_32.z;
                val_48 = val_2.Length;
                if((val_54 + 1) >= val_48)
            {
                    val_48 = val_2.Length;
            }
            
                UnityEngine.Vector3 val_53 = val_2[80];
                UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z}, b:  new UnityEngine.Vector3() {x = val_2[0x50].Length, y = 0f, z = val_53});
                val_49 = val_2.Length;
                if(val_54 >= val_49)
            {
                    val_49 = val_2.Length;
            }
            
                UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 4.372641E+10f, y = V12.16B, z = V13.16B}, b:  new UnityEngine.Vector3() {x = val_2[0x50].Length, y = 0f, z = val_53});
                UnityEngine.Vector3 val_36 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z}, rhs:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z});
                mem2[0] = val_36.x;
                mem2[0] = val_36.y;
                mem2[0] = val_36.z;
                mem2[0] = val_36.x;
                mem2[0] = val_36.y;
                mem2[0] = val_36.z;
                mem2[0] = val_36.x;
                mem2[0] = val_36.y;
                mem2[0] = val_36.z;
                mem2[0] = val_36.x;
                mem2[0] = val_36.y;
                mem2[0] = val_36.z;
                val_54 = val_54 + 4;
            }
            while((val_27 + 1) != 4);
            
            if(val_1 != 0)
            {
                    val_1.vertices = val_2;
            }
            else
            {
                    val_1.vertices = val_2;
            }
            
            val_1.normals = val_3;
            System.Collections.Generic.List<System.Int32> val_37 = new System.Collections.Generic.List<System.Int32>(capacity:  6);
            if(val_37 != null)
            {
                    val_37.Add(item:  0);
                val_37.Add(item:  1);
                val_37.Add(item:  2);
                val_37.Add(item:  0);
                val_37.Add(item:  2);
            }
            else
            {
                    val_37.Add(item:  0);
                val_37.Add(item:  1);
                val_37.Add(item:  2);
                val_37.Add(item:  0);
                val_37.Add(item:  2);
            }
            
            val_37.Add(item:  3);
            val_1.SetTriangles(triangles:  val_37, submesh:  0);
            System.Collections.Generic.List<System.Int32> val_38 = new System.Collections.Generic.List<System.Int32>(capacity:  8);
            var val_55 = 7;
            do
            {
                val_38.Add(item:  val_55 - 3);
                if(val_38 != null)
            {
                    int val_40 = val_55 - 1;
                val_38.Add(item:  val_40);
                val_50 = val_55 - 2;
                val_38.Add(item:  val_50);
                val_38.Add(item:  val_50);
                val_38.Add(item:  val_40);
            }
            else
            {
                    int val_41 = val_55 - 1;
                val_38.Add(item:  val_41);
                val_50 = val_55 - 2;
                val_38.Add(item:  val_50);
                val_38.Add(item:  val_50);
                val_38.Add(item:  val_41);
            }
            
                val_38.Add(item:  7);
                val_55 = val_55 + 4;
            }
            while(val_55 != 23);
            
            val_1.SetTriangles(triangles:  val_38, submesh:  1);
            UnityEngine.Vector2[] val_42 = new UnityEngine.Vector2[20];
            UnityEngine.Vector2 val_43 = new UnityEngine.Vector2(x:  0f, y:  1f);
            val_42[0] = val_43.x;
            val_42[0] = val_43.y;
            UnityEngine.Vector2 val_44 = new UnityEngine.Vector2(x:  1f, y:  1f);
            val_42[1] = val_44.x;
            val_42[1] = val_44.y;
            UnityEngine.Vector2 val_45 = new UnityEngine.Vector2(x:  1f, y:  0f);
            val_42[2] = val_45.x;
            val_42[2] = val_45.y;
            UnityEngine.Vector2 val_46 = new UnityEngine.Vector2(x:  0f, y:  0f);
            val_42[3] = val_46.x;
            val_42[3] = val_46.y;
            var val_56 = 4;
            do
            {
                UnityEngine.Vector2 val_47 = new UnityEngine.Vector2(x:  1f, y:  1f);
                mem2[0] = val_47.x;
                mem2[0] = val_47.y;
                UnityEngine.Vector2 val_48 = new UnityEngine.Vector2(x:  0f, y:  1f);
                val_56 = val_56 + 1;
                mem2[0] = val_48.x;
                mem2[0] = val_48.y;
                UnityEngine.Vector2 val_49 = new UnityEngine.Vector2(x:  1f, y:  0f);
                val_56 = val_56 + 1;
                mem2[0] = val_49.x;
                mem2[0] = val_49.y;
                UnityEngine.Vector2 val_50 = new UnityEngine.Vector2(x:  0f, y:  0f);
                val_56 = val_56 + 1;
                mem2[0] = val_50.x;
                mem2[0] = val_50.y;
                val_56 = val_56 + 1;
            }
            while((val_56 - 3) < 16);
            
            val_1.uv = val_42;
            tile.MeshFilter.sharedMesh = val_1;
            mem[1152921519755813384] = val_1;
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FlatTerrainStrategy()
        {
        
        }
    
    }

}
