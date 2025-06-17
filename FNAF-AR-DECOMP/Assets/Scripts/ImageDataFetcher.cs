using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class ImageDataFetcher : DataFetcher
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.RasterTile> DataRecieved;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.RasterTile, Mapbox.Map.TileErrorEventArgs> FetchingError;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void FetchImage(Mapbox.Map.CanonicalTileId canonicalTileId, string mapid, Mapbox.Unity.MeshGeneration.Data.UnityTile tile, bool useRetina = False)
    {
        UnityEngine.Object val_11;
        Mapbox.Map.RasterTile val_12;
        ImageDataFetcher.<>c__DisplayClass2_0 val_1 = new ImageDataFetcher.<>c__DisplayClass2_0();
        if(val_1 != null)
        {
                val_11 = val_1;
            .tile = tile;
        }
        else
        {
                val_11 = 16;
            mem[16] = tile;
        }
        
        .<>4__this = this;
        if((mapid.StartsWith(value:  "mapbox://", comparisonType:  4)) == false)
        {
            goto label_4;
        }
        
        if(useRetina == false)
        {
            goto label_5;
        }
        
        Mapbox.Map.RetinaRasterTile val_3 = null;
        val_12 = val_3;
        val_3 = new Mapbox.Map.RetinaRasterTile();
        goto label_9;
        label_4:
        if(useRetina == false)
        {
            goto label_7;
        }
        
        Mapbox.Map.ClassicRetinaRasterTile val_4 = null;
        val_12 = val_4;
        val_4 = new Mapbox.Map.ClassicRetinaRasterTile();
        goto label_9;
        label_5:
        Mapbox.Map.RasterTile val_5 = null;
        val_12 = val_5;
        val_5 = new Mapbox.Map.RasterTile();
        goto label_9;
        label_7:
        Mapbox.Map.ClassicRasterTile val_6 = null;
        val_12 = val_6;
        val_6 = new Mapbox.Map.ClassicRasterTile();
        label_9:
        .rasterTile = val_12;
        if(val_11 != 0)
        {
                mem[16].AddTile(tile:  (ImageDataFetcher.<>c__DisplayClass2_0)[1152921519083820880].rasterTile);
        }
        
        Mapbox.Map.CanonicalTileId val_8 = mem[16].CanonicalTileId;
        (ImageDataFetcher.<>c__DisplayClass2_0)[1152921519083820880].rasterTile.Initialize(fileSource:  this, canonicalTileId:  new Mapbox.Map.CanonicalTileId() {Z = val_8.Z, X = val_8.X, Y = val_8.Y & 4294967295}, mapId:  mapid, p:  new System.Action(object:  val_1, method:  System.Void ImageDataFetcher.<>c__DisplayClass2_0::<FetchImage>b__0()));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ImageDataFetcher()
    {
        var val_3;
        System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.RasterTile, Mapbox.Map.TileErrorEventArgs> val_6;
        val_3 = null;
        val_3 = null;
        if((ImageDataFetcher.<>c.<>9__3_0) == null)
        {
            goto label_3;
        }
        
        label_13:
        this.DataRecieved = ImageDataFetcher.<>c.<>9__3_0;
        val_3 = null;
        val_6 = ImageDataFetcher.<>c.<>9__3_1;
        if(val_6 == null)
        {
                System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.RasterTile, Mapbox.Map.TileErrorEventArgs> val_1 = null;
            val_6 = val_1;
            val_1 = new System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.RasterTile, Mapbox.Map.TileErrorEventArgs>(object:  ImageDataFetcher.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ImageDataFetcher.<>c::<.ctor>b__3_1(Mapbox.Unity.MeshGeneration.Data.UnityTile t, Mapbox.Map.RasterTile r, Mapbox.Map.TileErrorEventArgs s));
            ImageDataFetcher.<>c.<>9__3_1 = val_6;
        }
        
        this.FetchingError = val_6;
        return;
        label_3:
        ImageDataFetcher.<>c.<>9__3_0 = new System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.RasterTile>(object:  ImageDataFetcher.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ImageDataFetcher.<>c::<.ctor>b__3_0(Mapbox.Unity.MeshGeneration.Data.UnityTile t, Mapbox.Map.RasterTile s));
        if(this != null)
        {
            goto label_13;
        }
        
        goto label_13;
    }

}
