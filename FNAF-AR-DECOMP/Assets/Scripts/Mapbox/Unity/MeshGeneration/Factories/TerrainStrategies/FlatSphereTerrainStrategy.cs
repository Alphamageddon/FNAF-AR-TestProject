using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Factories.TerrainStrategies
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FlatSphereTerrainStrategy : TerrainStrategy
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Radius { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Radius()
        {
            if((X19 + 48) != 0)
            {
                    return (float)X19 + 48 + 24;
            }
            
            return (float)X19 + 48 + 24;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Initialize(Mapbox.Unity.Map.ElevationLayerProperties elOptions)
        {
            mem[1152921519754353984] = elOptions;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void RegisterTile(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            var val_4 = mem[X21 + 56];
            val_4 = X21 + 56;
            if((X21 + 56 + 16) != 0)
            {
                    val_4 = tile.gameObject.layer;
                if(val_4 != (X22 + 56 + 20))
            {
                    val_4 = tile.gameObject;
                val_4.layer = X22 + 56 + 56 + 20;
            }
            
            }
            
            this.GenerateTerrainMesh(tile:  tile);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GenerateTerrainMesh(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            float val_38;
            var val_39;
            int val_40;
            var val_41;
            System.Collections.Generic.List<UnityEngine.Vector3> val_1 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            if((mem[69738544] + 16) > 0)
            {
                    var val_2 = (mem[69738544] + 16) - 1;
                do
            {
                float val_43 = 0f;
                do
            {
                Mapbox.Utils.Vector2d val_4 = tile.<Rect>k__BackingField.<Min>k__BackingField.Min;
                Mapbox.Utils.Vector2d val_5 = tile.<Rect>k__BackingField.<Min>k__BackingField.Min;
                Mapbox.Utils.Vector2d val_6 = tile.<Rect>k__BackingField.<Min>k__BackingField.Max;
                float val_38 = (float)val_5.x;
                val_38 = val_38 + (float)val_6.x;
                Mapbox.Utils.Vector2d val_8 = tile.<Rect>k__BackingField.<Min>k__BackingField.Min;
                Mapbox.Utils.Vector2d val_9 = tile.<Rect>k__BackingField.<Min>k__BackingField.Min;
                Mapbox.Utils.Vector2d val_10 = tile.<Rect>k__BackingField.<Min>k__BackingField.Max;
                float val_39 = (float)val_10.y;
                val_39 = (float)val_9.y + val_39;
                float val_40 = (float)val_2;
                val_40 = val_43 / val_40;
                Mapbox.Utils.Vector2d val_12 = new Mapbox.Utils.Vector2d(x:  (double)UnityEngine.Mathf.Lerp(a:  (float)val_4.x, b:  val_38, t:  0f / (float)val_2), y:  (double)UnityEngine.Mathf.Lerp(a:  (float)val_8.y, b:  val_39, t:  val_40));
                Mapbox.Utils.Vector2d val_13 = Mapbox.Unity.Utilities.Conversions.MetersToLatLon(m:  new Mapbox.Utils.Vector2d() {x = val_12.x, y = val_12.y});
                val_13.x = val_13.x * 0.0174532923847437;
                val_13.y = val_13.y * 0.0174532923847437;
                float val_42 = (float)val_13.y;
                float val_41 = (float)val_13.x;
                val_41 = ((mem[69738544] + 24) * val_41) * val_42;
                val_42 = ((mem[69738544] + 24) * (float)val_13.x) * val_42;
                float val_16 = (mem[69738544] + 24) * (float)val_13.x;
                val_38 = 0f;
                val_1.Add(item:  new UnityEngine.Vector3() {x = val_38, y = 0f, z = 0f});
                val_43 = val_43 + 1f;
            }
            while(val_43 < 0);
            
                float val_44 = 0f;
                val_44 = val_44 + 1f;
            }
            while(val_44 < 0);
            
                val_39 = val_2;
            }
            else
            {
                    val_39 = (mem[69738544] + 16) - 1;
            }
            
            System.Collections.Generic.List<System.Int32> val_17 = new System.Collections.Generic.List<System.Int32>();
            if(val_39 >= 1)
            {
                    var val_46 = 0;
                do
            {
                var val_45 = 0;
                do
            {
                if(val_17 != null)
            {
                    val_40 = val_45 + (0 * (mem[69738544] + 16));
                val_17.Add(item:  val_46 + val_45);
            }
            else
            {
                    val_40 = val_46 + val_45;
                val_17.Add(item:  val_40);
            }
            
                int val_20 = val_40 + (mem[69738544] + 16);
                int val_21 = val_20 + 1;
                val_17.Add(item:  val_21);
                if(val_17 != null)
            {
                    val_17.Add(item:  val_20);
                val_17.Add(item:  val_40);
                val_17.Add(item:  val_40 + 1);
            }
            else
            {
                    val_17.Add(item:  val_20);
                val_17.Add(item:  val_40);
                val_17.Add(item:  val_40 + 1);
            }
            
                val_39 = val_39;
                val_17.Add(item:  val_21);
                val_45 = val_45 + 1;
            }
            while(val_39 != val_45);
            
                val_46 = val_46 + (mem[69738544] + 16);
            }
            while(1 != val_39);
            
            }
            
            System.Collections.Generic.List<UnityEngine.Vector2> val_24 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            if((mem[69738544] + 16) >= 1)
            {
                    float val_47 = 1f;
                var val_49 = 0;
                val_38 = val_47 / (float)val_39;
                do
            {
                var val_48 = 0;
                do
            {
                val_47 = val_38 * 0f;
                UnityEngine.Vector2 val_26 = new UnityEngine.Vector2(x:  val_38 * 0f, y:  val_47);
                val_24.Add(item:  new UnityEngine.Vector2() {x = val_26.x, y = val_26.y});
                val_48 = val_48 + 1;
            }
            while((mem[69738544] + 16) != val_48);
            
                val_49 = val_49 + 1;
            }
            while(val_49 != (mem[69738544] + 16));
            
            }
            
            tile.MeshFilter.mesh.SetVertices(inVertices:  val_1);
            tile.MeshFilter.mesh.SetTriangles(triangles:  val_17, submesh:  0);
            tile.MeshFilter.mesh.SetUVs(channel:  0, uvs:  val_24);
            tile.MeshFilter.mesh.RecalculateBounds();
            tile.MeshFilter.mesh.RecalculateNormals();
            val_41 = null;
            val_41 = null;
            tile.transform.localPosition = new UnityEngine.Vector3() {x = Constants.Math.Vector3Zero, y = Constants.Math.Vector3Zero.__il2cppRuntimeField_4, z = Constants.Math.Vector3Zero.__il2cppRuntimeField_8};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void UnregisterTile(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FlatSphereTerrainStrategy()
        {
        
        }
    
    }

}
