using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GeometryMaterialOptions : ModifierProperties
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.StyleTypes style;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.UvMapType texturingType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Modifiers.MaterialList[] materials;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Data.AtlasInfo atlasInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float lightStyleOpacity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float darkStyleOpacity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Color colorStyleColor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.SamplePalettes samplePalettes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ScriptablePalette colorPalette;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override System.Type ModifierType { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override System.Type get_ModifierType()
        {
            return System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GeometryMaterialOptions()
        {
            this.materials = new Mapbox.Unity.MeshGeneration.Modifiers.MaterialList[2];
            this.lightStyleOpacity = 1f;
            this.darkStyleOpacity = 1f;
            UnityEngine.Color val_2 = UnityEngine.Color.white;
            this.colorStyleColor = val_2;
            mem[1152921519799206884] = val_2.g;
            mem[1152921519799206888] = val_2.b;
            mem[1152921519799206892] = val_2.a;
            Mapbox.Unity.MeshGeneration.Modifiers.MaterialList[] val_3 = new Mapbox.Unity.MeshGeneration.Modifiers.MaterialList[2];
            this.materials = val_3;
            Mapbox.Unity.MeshGeneration.Modifiers.MaterialList val_4 = new Mapbox.Unity.MeshGeneration.Modifiers.MaterialList();
            if(val_3 == null)
            {
                goto label_1;
            }
            
            if(val_4 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_4 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_3[0] = val_4;
            Mapbox.Unity.MeshGeneration.Modifiers.MaterialList val_5 = new Mapbox.Unity.MeshGeneration.Modifiers.MaterialList();
            if(this.materials == null)
            {
                goto label_7;
            }
            
            if(val_5 != null)
            {
                goto label_8;
            }
            
            goto label_11;
            label_7:
            if(val_5 == null)
            {
                goto label_11;
            }
            
            label_8:
            label_11:
            this.materials[1] = val_5;
        }
    
    }

}
