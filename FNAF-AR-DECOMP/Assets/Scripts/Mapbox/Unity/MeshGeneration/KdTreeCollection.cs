using UnityEngine;

namespace Mapbox.Unity.MeshGeneration
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class KdTreeCollection : FeatureCollectionBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private KDTree.KDTree<Mapbox.Unity.MeshGeneration.Data.VectorEntity> _entities;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Count;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Initialize()
        {
            this.Initialize();
            this._entities = new KDTree.KDTree<Mapbox.Unity.MeshGeneration.Data.VectorEntity>(iDimensions:  2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void AddFeature(double[] position, Mapbox.Unity.MeshGeneration.Data.VectorEntity ve)
        {
            this._entities.AddPoint(tPoint:  position, kValue:  ve);
            this.Count = this._entities.Size;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public KDTree.NearestNeighbour<Mapbox.Unity.MeshGeneration.Data.VectorEntity> NearestNeighbors(double[] v, int maxCount, float range)
        {
            if(this._entities != null)
            {
                    return this._entities.NearestNeighbors(tSearchPoint:  v, iMaxReturned:  maxCount, fDistance:  (double)range);
            }
            
            return this._entities.NearestNeighbors(tSearchPoint:  v, iMaxReturned:  maxCount, fDistance:  (double)range);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public KdTreeCollection()
        {
        
        }
    
    }

}
