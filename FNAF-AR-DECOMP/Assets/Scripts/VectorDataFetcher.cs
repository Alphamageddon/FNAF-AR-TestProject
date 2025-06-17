using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class VectorDataFetcher : DataFetcher
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.VectorTile> DataRecieved;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.VectorTile, Mapbox.Map.TileErrorEventArgs> FetchingError;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void FetchVector(Mapbox.Map.CanonicalTileId canonicalTileId, string mapid, Mapbox.Unity.MeshGeneration.Data.UnityTile tile, bool useOptimizedStyle = False, Mapbox.Unity.Map.Style style)
    {
        var val_7;
        string val_8;
        Mapbox.Map.VectorTile val_9;
        VectorDataFetcher.<>c__DisplayClass2_0 val_1 = new VectorDataFetcher.<>c__DisplayClass2_0();
        if(val_1 != null)
        {
                val_7 = val_1;
            .tile = tile;
        }
        else
        {
                val_7 = 16;
            mem[16] = tile;
        }
        
        .<>4__this = this;
        if(useOptimizedStyle == false)
        {
            goto label_3;
        }
        
        if(style == null)
        {
            goto label_4;
        }
        
        val_8 = style.Id;
        goto label_5;
        label_3:
        Mapbox.Map.VectorTile val_2 = null;
        val_9 = val_2;
        val_2 = new Mapbox.Map.VectorTile();
        goto label_6;
        label_4:
        val_8 = 15026800;
        label_5:
        Mapbox.Map.VectorTile val_3 = null;
        val_9 = val_3;
        val_3 = new Mapbox.Map.VectorTile(styleId:  val_8, modifiedDate:  style.Modified);
        label_6:
        .vectorTile = val_9;
        val_7.AddTile(tile:  val_3);
        Mapbox.Map.CanonicalTileId val_4 = mem[16].CanonicalTileId;
        (VectorDataFetcher.<>c__DisplayClass2_0)[1152921519086363216].vectorTile.Initialize(fileSource:  this, canonicalTileId:  new Mapbox.Map.CanonicalTileId() {Z = val_4.Z, X = val_4.X, Y = val_4.Y & 4294967295}, mapId:  mapid, p:  new System.Action(object:  val_1, method:  System.Void VectorDataFetcher.<>c__DisplayClass2_0::<FetchVector>b__0()));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public VectorDataFetcher()
    {
        var val_3;
        System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.VectorTile, Mapbox.Map.TileErrorEventArgs> val_6;
        val_3 = null;
        val_3 = null;
        if((VectorDataFetcher.<>c.<>9__3_0) == null)
        {
            goto label_3;
        }
        
        label_13:
        this.DataRecieved = VectorDataFetcher.<>c.<>9__3_0;
        val_3 = null;
        val_6 = VectorDataFetcher.<>c.<>9__3_1;
        if(val_6 == null)
        {
                System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.VectorTile, Mapbox.Map.TileErrorEventArgs> val_1 = null;
            val_6 = val_1;
            val_1 = new System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.VectorTile, Mapbox.Map.TileErrorEventArgs>(object:  VectorDataFetcher.<>c.__il2cppRuntimeField_static_fields, method:  System.Void VectorDataFetcher.<>c::<.ctor>b__3_1(Mapbox.Unity.MeshGeneration.Data.UnityTile t, Mapbox.Map.VectorTile r, Mapbox.Map.TileErrorEventArgs s));
            VectorDataFetcher.<>c.<>9__3_1 = val_6;
        }
        
        this.FetchingError = val_6;
        return;
        label_3:
        VectorDataFetcher.<>c.<>9__3_0 = new System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.VectorTile>(object:  VectorDataFetcher.<>c.__il2cppRuntimeField_static_fields, method:  System.Void VectorDataFetcher.<>c::<.ctor>b__3_0(Mapbox.Unity.MeshGeneration.Data.UnityTile t, Mapbox.Map.VectorTile s));
        if(this != null)
        {
            goto label_13;
        }
        
        goto label_13;
    }

}
