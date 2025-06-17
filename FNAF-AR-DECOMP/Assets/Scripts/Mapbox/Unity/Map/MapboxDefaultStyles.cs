using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class MapboxDefaultStyles
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.Map.GeometryMaterialOptions GetGeometryMaterialOptions(Mapbox.Unity.Map.GeometryMaterialOptions geometryMaterialOptionsRef)
        {
            var val_16;
            var val_17;
            Mapbox.Unity.Map.GeometryMaterialOptions val_18;
            var val_19;
            float val_20;
            float val_21;
            float val_22;
            float val_23;
            Mapbox.Unity.MeshGeneration.Modifiers.MaterialList[] val_28;
            float val_29;
            var val_32;
            val_16 = geometryMaterialOptionsRef;
            if(geometryMaterialOptionsRef.style == 0)
            {
                goto label_2;
            }
            
            string val_1 = geometryMaterialOptionsRef + 16.ToString();
            geometryMaterialOptionsRef.style = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = geometryMaterialOptionsRef + 16});
            mem2[0] = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = geometryMaterialOptionsRef.samplePalettes});
            val_17 = null;
            val_17 = null;
            Mapbox.Unity.Map.StyleAssetPathBundle val_7 = new Mapbox.Unity.Map.StyleAssetPathBundle(styleName:  val_1, path:  System.IO.Path.Combine(path1:  Constants.Path.MAP_FEATURE_STYLES_SAMPLES, path2:  System.IO.Path.Combine(path1:  val_1, path2:  "Assets")), samplePaletteName:  geometryMaterialOptionsRef.samplePalettes.ToString());
            Mapbox.Unity.Map.GeometryMaterialOptions val_8 = null;
            val_18 = val_8;
            val_8 = new Mapbox.Unity.Map.GeometryMaterialOptions();
            Mapbox.Unity.Map.GeometryMaterialOptions val_9 = Mapbox.Unity.Map.MapboxDefaultStyles.AssignAssets(geometryMaterialOptions:  val_8, styleAssetPathBundle:  val_7);
            if(val_18 == null)
            {
                goto label_11;
            }
            
            val_16 = val_18;
            .style = geometryMaterialOptionsRef + 16;
            val_19 = 1152921519833497432;
            mem[1152921519833497432] = geometryMaterialOptionsRef.lightStyleOpacity;
            val_20 = geometryMaterialOptionsRef.darkStyleOpacity;
            goto label_12;
            label_2:
            val_18 = geometryMaterialOptionsRef;
            return val_18;
            label_11:
            val_16 = 16;
            mem[16] = geometryMaterialOptionsRef + 16;
            val_19 = 40;
            mem[40] = geometryMaterialOptionsRef.lightStyleOpacity;
            val_20 = geometryMaterialOptionsRef.darkStyleOpacity;
            label_12:
            .darkStyleOpacity = val_20;
            .colorStyleColor = geometryMaterialOptionsRef.colorStyleColor;
            mem[1152921519833497444] = val_7;
            mem[1152921519833497448] = ???;
            mem[1152921519833497452] = geometryMaterialOptionsRef;
            if(val_16 == 7)
            {
                goto label_16;
            }
            
            if(val_16 == 3)
            {
                goto label_17;
            }
            
            if(val_16 != 2)
            {
                goto label_18;
            }
            
            Mapbox.Unity.MeshGeneration.Modifiers.MaterialList val_16 = (Mapbox.Unity.Map.GeometryMaterialOptions)[1152921519833497392].materials[0];
            UnityEngine.Color val_10 = (Mapbox.Unity.Map.GeometryMaterialOptions)[1152921519833497392].materials[0].Materials[0].color;
            Mapbox.Unity.MeshGeneration.Modifiers.MaterialList val_18 = (Mapbox.Unity.Map.GeometryMaterialOptions)[1152921519833497392].materials[0];
            val_21 = val_10.r;
            val_22 = val_10.g;
            val_23 = val_10.b;
            (Mapbox.Unity.Map.GeometryMaterialOptions)[1152921519833497392].materials[0].Materials[0].color = new UnityEngine.Color() {r = val_21, g = val_22, b = val_23, a = mem[40]};
            Mapbox.Unity.MeshGeneration.Modifiers.MaterialList val_20 = (Mapbox.Unity.Map.GeometryMaterialOptions)[1152921519833497392].materials[1];
            UnityEngine.Color val_11 = (Mapbox.Unity.Map.GeometryMaterialOptions)[1152921519833497392].materials[1].Materials[0].color;
            val_28 = (Mapbox.Unity.Map.GeometryMaterialOptions)[1152921519833497392].materials;
            val_29 = mem[40];
            goto label_38;
            label_16:
            if(val_18 == null)
            {
                goto label_39;
            }
            
            val_20 = (Mapbox.Unity.Map.GeometryMaterialOptions)[1152921519833497392].colorStyleColor;
            goto label_40;
            label_17:
            Mapbox.Unity.MeshGeneration.Modifiers.MaterialList val_22 = (Mapbox.Unity.Map.GeometryMaterialOptions)[1152921519833497392].materials[0];
            UnityEngine.Color val_12 = (Mapbox.Unity.Map.GeometryMaterialOptions)[1152921519833497392].materials[0].Materials[0].color;
            Mapbox.Unity.MeshGeneration.Modifiers.MaterialList val_24 = (Mapbox.Unity.Map.GeometryMaterialOptions)[1152921519833497392].materials[0];
            val_21 = val_12.r;
            val_22 = val_12.g;
            val_23 = val_12.b;
            (Mapbox.Unity.Map.GeometryMaterialOptions)[1152921519833497392].materials[0].Materials[0].color = new UnityEngine.Color() {r = val_21, g = val_22, b = val_23, a = (Mapbox.Unity.Map.GeometryMaterialOptions)[1152921519833497392].darkStyleOpacity};
            Mapbox.Unity.MeshGeneration.Modifiers.MaterialList val_26 = (Mapbox.Unity.Map.GeometryMaterialOptions)[1152921519833497392].materials[1];
            UnityEngine.Color val_13 = (Mapbox.Unity.Map.GeometryMaterialOptions)[1152921519833497392].materials[1].Materials[0].color;
            val_28 = (Mapbox.Unity.Map.GeometryMaterialOptions)[1152921519833497392].materials;
            val_29 = (Mapbox.Unity.Map.GeometryMaterialOptions)[1152921519833497392].darkStyleOpacity;
            label_38:
            val_20 = val_13.r;
            Mapbox.Unity.MeshGeneration.Modifiers.MaterialList val_28 = val_28[1];
            if((Mapbox.Unity.Map.GeometryMaterialOptions)[1152921519833497392].materials[1].Materials[0] != null)
            {
                goto label_66;
            }
            
            goto label_66;
            label_39:
            val_20 = (Mapbox.Unity.Map.GeometryMaterialOptions)[1152921519833497392].colorStyleColor;
            label_40:
            Mapbox.Unity.MeshGeneration.Modifiers.MaterialList val_30 = (Mapbox.Unity.Map.GeometryMaterialOptions)[1152921519833497392].materials[0];
            (Mapbox.Unity.Map.GeometryMaterialOptions)[1152921519833497392].materials[0].Materials[0].color = new UnityEngine.Color() {r = val_20, g = V9.16B, b = V10.16B, a = V11.16B};
            Mapbox.Unity.MeshGeneration.Modifiers.MaterialList val_32 = (Mapbox.Unity.Map.GeometryMaterialOptions)[1152921519833497392].materials[1];
            label_66:
            (Mapbox.Unity.Map.GeometryMaterialOptions)[1152921519833497392].materials[1].Materials[0].color = new UnityEngine.Color() {r = val_20, g = V9.16B, b = V10.16B, a = V11.16B};
            label_18:
            if(val_18 != null)
            {
                    var val_34 = mem[16];
                val_34 = (val_34 == 6) ? 0 : ((val_34 == 1) ? (2 + 1) : 2);
            }
            else
            {
                    if(mem[16] == 6)
            {
                    val_32 = 0;
            }
            
            }
            
            .texturingType = (mem[16] == 1) ? (2 + 1) : 2;
            return val_18;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.Map.GeometryMaterialOptions AssignAssets(Mapbox.Unity.Map.GeometryMaterialOptions geometryMaterialOptions, Mapbox.Unity.Map.StyleAssetPathBundle styleAssetPathBundle)
        {
            var val_13;
            var val_14;
            var val_15;
            UnityEngine.Object val_2 = UnityEngine.Resources.Load(path:  styleAssetPathBundle.topMaterialPath, systemTypeInstance:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_13 = 0;
            UnityEngine.Object val_5 = UnityEngine.Resources.Load(path:  styleAssetPathBundle.sideMaterialPath, systemTypeInstance:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_14 = 0;
            UnityEngine.Object val_7 = UnityEngine.Resources.Load(path:  styleAssetPathBundle.atlasPath, systemTypeInstance:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_15 = 0;
            UnityEngine.Object val_9 = UnityEngine.Resources.Load(path:  styleAssetPathBundle.palettePath, systemTypeInstance:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            Mapbox.Unity.MeshGeneration.Modifiers.MaterialList val_15 = geometryMaterialOptions.materials[0];
            UnityEngine.Material val_10 = new UnityEngine.Material(source:  null);
            if(geometryMaterialOptions.materials[0].Materials == null)
            {
                goto label_19;
            }
            
            if(val_10 != null)
            {
                goto label_20;
            }
            
            goto label_23;
            label_19:
            if(val_10 == null)
            {
                goto label_23;
            }
            
            label_20:
            label_23:
            geometryMaterialOptions.materials[0].Materials[0] = val_10;
            Mapbox.Unity.MeshGeneration.Modifiers.MaterialList val_16 = geometryMaterialOptions.materials[1];
            UnityEngine.Material val_11 = new UnityEngine.Material(source:  null);
            if(geometryMaterialOptions.materials[1].Materials == null)
            {
                goto label_28;
            }
            
            if(val_11 != null)
            {
                goto label_29;
            }
            
            goto label_32;
            label_28:
            if(val_11 == null)
            {
                goto label_32;
            }
            
            label_29:
            label_32:
            geometryMaterialOptions.materials[1].Materials[0] = val_11;
            geometryMaterialOptions.atlasInfo = ;
            geometryMaterialOptions.colorPalette = 0;
            return (Mapbox.Unity.Map.GeometryMaterialOptions)geometryMaterialOptions;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.Map.GeometryMaterialOptions GetDefaultAssets()
        {
            null = null;
            .texturingType = 2;
            return Mapbox.Unity.Map.MapboxDefaultStyles.AssignAssets(geometryMaterialOptions:  new Mapbox.Unity.Map.GeometryMaterialOptions(), styleAssetPathBundle:  new Mapbox.Unity.Map.StyleAssetPathBundle(styleName:  "Default", path:  Constants.Path.MAP_FEATURE_STYLES_DEFAULT_STYLE_ASSETS, samplePaletteName:  ""));
        }
    
    }

}
