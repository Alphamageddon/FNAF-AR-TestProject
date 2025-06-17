using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class TerrainDataFetcher : DataFetcher
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.RawPngRasterTile> DataRecieved;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.RawPngRasterTile, Mapbox.Map.TileErrorEventArgs> FetchingError;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void FetchTerrain(Mapbox.Map.CanonicalTileId canonicalTileId, string mapid, Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
    {
        Mapbox.Map.RawPngRasterTile val_4;
        TerrainDataFetcher.<>c__DisplayClass2_0 val_1 = new TerrainDataFetcher.<>c__DisplayClass2_0();
        if(val_1 != null)
        {
                .tile = tile;
            .<>4__this = this;
        }
        else
        {
                mem[16] = tile;
            mem[32] = this;
        }
        
        .canonicalTileId = canonicalTileId;
        mem[1152921519085214336] = canonicalTileId.Y;
        Mapbox.Map.RawPngRasterTile val_2 = null;
        val_4 = val_2;
        val_2 = new Mapbox.Map.RawPngRasterTile();
        if(val_1 != null)
        {
                .pngRasterTile = val_4;
        }
        else
        {
                mem[24] = val_4;
            val_4 = mem[24];
        }
        
        val_2.Initialize(fileSource:  this, canonicalTileId:  new Mapbox.Map.CanonicalTileId() {Z = (TerrainDataFetcher.<>c__DisplayClass2_0)[1152921519085214288].canonicalTileId, X = (TerrainDataFetcher.<>c__DisplayClass2_0)[1152921519085214288].canonicalTileId, Y = 24}, mapId:  mapid, p:  new System.Action(object:  val_1, method:  System.Void TerrainDataFetcher.<>c__DisplayClass2_0::<FetchTerrain>b__0()));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TerrainDataFetcher()
    {
        var val_3;
        System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.RawPngRasterTile, Mapbox.Map.TileErrorEventArgs> val_6;
        val_3 = null;
        val_3 = null;
        if((TerrainDataFetcher.<>c.<>9__3_0) == null)
        {
            goto label_3;
        }
        
        label_13:
        this.DataRecieved = TerrainDataFetcher.<>c.<>9__3_0;
        val_3 = null;
        val_6 = TerrainDataFetcher.<>c.<>9__3_1;
        if(val_6 == null)
        {
                System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.RawPngRasterTile, Mapbox.Map.TileErrorEventArgs> val_1 = null;
            val_6 = val_1;
            val_1 = new System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.RawPngRasterTile, Mapbox.Map.TileErrorEventArgs>(object:  TerrainDataFetcher.<>c.__il2cppRuntimeField_static_fields, method:  System.Void TerrainDataFetcher.<>c::<.ctor>b__3_1(Mapbox.Unity.MeshGeneration.Data.UnityTile t, Mapbox.Map.RawPngRasterTile r, Mapbox.Map.TileErrorEventArgs s));
            TerrainDataFetcher.<>c.<>9__3_1 = val_6;
        }
        
        this.FetchingError = val_6;
        return;
        label_3:
        TerrainDataFetcher.<>c.<>9__3_0 = new System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.RawPngRasterTile>(object:  TerrainDataFetcher.<>c.__il2cppRuntimeField_static_fields, method:  System.Void TerrainDataFetcher.<>c::<.ctor>b__3_0(Mapbox.Unity.MeshGeneration.Data.UnityTile t, Mapbox.Map.RawPngRasterTile s));
        if(this != null)
        {
            goto label_13;
        }
        
        goto label_13;
    }

}
