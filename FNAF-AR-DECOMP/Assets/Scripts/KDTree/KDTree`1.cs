using UnityEngine;

namespace KDTree
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class KDTree<T> : KDNode<T>
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public KDTree<T>(int iDimensions)
        {
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public KDTree<T>(int iDimensions, int iBucketCapacity)
        {
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public KDTree.NearestNeighbour<T> NearestNeighbors(double[] tSearchPoint, int iMaxReturned, double fDistance = -1)
        {
            KDTree.SquareEuclideanDistanceFunction val_1 = new KDTree.SquareEuclideanDistanceFunction();
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public KDTree.NearestNeighbour<T> NearestNeighbors(double[] tSearchPoint, KDTree.DistanceFunctions kDistanceFunction, int iMaxReturned, double fDistance)
        {
            if(((__RuntimeMethodHiddenParam + 24 + 192 + 24 + 294) & 1) != 0)
            {
                    return (KDTree.NearestNeighbour<T>)__RuntimeMethodHiddenParam + 24 + 192 + 24;
            }
            
            return (KDTree.NearestNeighbour<T>)__RuntimeMethodHiddenParam + 24 + 192 + 24;
        }
    
    }

}
