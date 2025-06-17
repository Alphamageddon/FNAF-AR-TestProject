using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Filters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class LayerFilter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Key;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string KeyDescription;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PropertyValue;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Min;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Max;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Filters.LayerFilterOperationType filterOperator;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private char[] _delimiters;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LayerFilter(Mapbox.Unity.MeshGeneration.Filters.LayerFilterOperationType filterOperation)
        {
            this.PropertyValue = System.String.alignConst;
            char[] val_1 = new char[1];
            val_1[0] = ',';
            this._delimiters = val_1;
            this.filterOperator = filterOperation;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer GetFilterComparer()
        {
            if(this._delimiters == null)
            {
                    char[] val_1 = new char[1];
                val_1[0] = ',';
                this._delimiters = val_1;
            }
            
            if(this.filterOperator > 4)
            {
                    return (Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer)new Mapbox.Unity.MeshGeneration.Filters.LayerFilterComparer();
            }
            
            var val_10 = 52956664 + (this.filterOperator) << 2;
            val_10 = val_10 + 52956664;
            goto (52956664 + (this.filterOperator) << 2 + 52956664);
        }
    
    }

}
