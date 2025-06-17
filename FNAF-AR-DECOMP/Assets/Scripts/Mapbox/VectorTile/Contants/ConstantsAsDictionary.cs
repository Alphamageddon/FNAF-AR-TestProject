using UnityEngine;

namespace Mapbox.VectorTile.Contants
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class ConstantsAsDictionary
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly System.Collections.Generic.Dictionary<int, string> TileType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly System.Collections.Generic.Dictionary<int, string> LayerType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly System.Collections.Generic.Dictionary<int, string> FeatureType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly System.Collections.Generic.Dictionary<int, string> GeomType;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static ConstantsAsDictionary()
        {
            System.Collections.Generic.Dictionary<System.Int32, System.String> val_1 = new System.Collections.Generic.Dictionary<System.Int32, System.String>();
            val_1.Add(key:  3, value:  "Layers");
            Mapbox.VectorTile.Contants.ConstantsAsDictionary.TileType = val_1;
            System.Collections.Generic.Dictionary<System.Int32, System.String> val_2 = new System.Collections.Generic.Dictionary<System.Int32, System.String>();
            if(val_2 != null)
            {
                    val_2.Add(key:  15, value:  "Version");
            }
            else
            {
                    val_2.Add(key:  15, value:  "Version");
            }
            
            val_2.Add(key:  1, value:  "Name");
            if(val_2 != null)
            {
                    val_2.Add(key:  2, value:  "Features");
            }
            else
            {
                    val_2.Add(key:  2, value:  "Features");
            }
            
            val_2.Add(key:  3, value:  "Keys");
            if(val_2 != null)
            {
                    val_2.Add(key:  4, value:  "Values");
            }
            else
            {
                    val_2.Add(key:  4, value:  "Values");
            }
            
            val_2.Add(key:  5, value:  "Extent");
            Mapbox.VectorTile.Contants.ConstantsAsDictionary.LayerType = val_2;
            System.Collections.Generic.Dictionary<System.Int32, System.String> val_3 = new System.Collections.Generic.Dictionary<System.Int32, System.String>();
            if(val_3 != null)
            {
                    val_3.Add(key:  1, value:  "Id");
            }
            else
            {
                    val_3.Add(key:  1, value:  "Id");
            }
            
            val_3.Add(key:  2, value:  "Tags");
            if(val_3 != null)
            {
                    val_3.Add(key:  3, value:  "Type");
            }
            else
            {
                    val_3.Add(key:  3, value:  "Type");
            }
            
            val_3.Add(key:  4, value:  "Geometry");
            val_3.Add(key:  5, value:  "Raster");
            Mapbox.VectorTile.Contants.ConstantsAsDictionary.FeatureType = val_3;
            System.Collections.Generic.Dictionary<System.Int32, System.String> val_4 = new System.Collections.Generic.Dictionary<System.Int32, System.String>();
            if(val_4 != null)
            {
                    val_4.Add(key:  0, value:  "Unknown");
            }
            else
            {
                    val_4.Add(key:  0, value:  "Unknown");
            }
            
            val_4.Add(key:  1, value:  "Point");
            if(val_4 != null)
            {
                    val_4.Add(key:  2, value:  "LineString");
            }
            else
            {
                    val_4.Add(key:  2, value:  "LineString");
            }
            
            val_4.Add(key:  3, value:  "Polygon");
            Mapbox.VectorTile.Contants.ConstantsAsDictionary.GeomType = val_4;
        }
    
    }

}
