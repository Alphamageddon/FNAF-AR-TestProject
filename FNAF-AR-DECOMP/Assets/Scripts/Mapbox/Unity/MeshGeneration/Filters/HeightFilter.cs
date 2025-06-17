using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Filters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class HeightFilter : FilterBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _height;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.Filters.HeightFilter.HeightFilterOptions _type;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string Key { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string get_Key()
        {
            return "height";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool Try(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature)
        {
            var val_3;
            float val_2 = System.Convert.ToSingle(value:  feature.Properties.Item[this]);
            if(this._type == 1)
            {
                goto label_5;
            }
            
            if((this._type != 0) || (val_2 <= this._height))
            {
                goto label_7;
            }
            
            label_9:
            val_3 = 1;
            return (bool)val_3;
            label_5:
            if(val_2 < 0)
            {
                goto label_9;
            }
            
            label_7:
            val_3 = 0;
            return (bool)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public HeightFilter()
        {
            val_1 = new System.Object();
        }
    
    }

}
