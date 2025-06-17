using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Filters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TypeFilter : FilterBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string[] _types;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.Filters.TypeFilter.TypeFilterType _behaviour;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string Key { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string get_Key()
        {
            return "type";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool Try(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature)
        {
            var val_7;
            var val_8;
            val_7 = 0;
            val_8 = 0;
            goto label_1;
            label_10:
            val_8 = val_8 | (System.String.op_Equality(a:  this._types[0].ToLowerInvariant(), b:  feature.Properties.Item["type"].ToLowerInvariant()));
            val_7 = 1;
            label_1:
            if(val_7 < this._types.Length)
            {
                goto label_10;
            }
            
            var val_5 = (this._behaviour != 0) ? 1 : 0;
            val_5 = val_8 ^ val_5;
            return (bool)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TypeFilter()
        {
        
        }
    
    }

}
