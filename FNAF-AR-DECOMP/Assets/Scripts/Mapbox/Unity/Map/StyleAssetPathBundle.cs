using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StyleAssetPathBundle
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string topMaterialPath;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string sideMaterialPath;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string atlasPath;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string palettePath;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StyleAssetPathBundle(string styleName, string path, string samplePaletteName = "")
        {
            val_1 = new System.Object();
            if((System.String.op_Equality(a:  styleName, b:  "Simple")) != true)
            {
                    samplePaletteName = System.String.Format(format:  "{0}{1}", arg0:  styleName, arg1:  "Palette");
            }
            
            string val_7 = System.IO.Path.Combine(path1:  string val_1 = path, path2:  "Materials");
            this.topMaterialPath = System.IO.Path.Combine(path1:  val_7, path2:  System.String.Format(format:  "{0}{1}", arg0:  styleName, arg1:  "TopMaterial"));
            this.sideMaterialPath = System.IO.Path.Combine(path1:  val_7, path2:  System.String.Format(format:  "{0}{1}", arg0:  styleName, arg1:  "SideMaterial"));
            this.atlasPath = System.IO.Path.Combine(path1:  System.IO.Path.Combine(path1:  val_1, path2:  "Atlas"), path2:  System.String.Format(format:  "{0}{1}", arg0:  styleName, arg1:  "AtlasInfo"));
            this.palettePath = System.IO.Path.Combine(path1:  System.IO.Path.Combine(path1:  val_1, path2:  "Palettes"), path2:  samplePaletteName);
        }
    
    }

}
