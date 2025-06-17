using UnityEngine;

namespace Mapbox.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class HighlightBuildings : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.KdTreeCollection Collection;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int MaxCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Range;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Ray ray;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Plane groundPlane;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 pos;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float rayDistance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private KDTree.NearestNeighbour<Mapbox.Unity.MeshGeneration.Data.VectorEntity> pIter;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            var val_5;
            UnityEngine.Ray val_6;
            float val_13;
            int val_14;
            KDTree.NearestNeighbour<Mapbox.Unity.MeshGeneration.Data.VectorEntity> val_15;
            if((UnityEngine.Input.GetMouseButton(button:  0)) == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_3 = UnityEngine.Input.mousePosition;
            val_13 = val_3.x;
            UnityEngine.Ray val_4 = UnityEngine.Camera.main.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = val_13, y = val_3.y, z = val_3.z});
            mem[1152921519840179528] = val_5;
            this.ray = val_6;
            if((this.groundPlane & 1) == 0)
            {
                    return;
            }
            
            this.pos = this.rayDistance;
            mem[1152921519840179556] = val_3.y;
            mem[1152921519840179560] = val_3.z;
            double[] val_7 = new double[2];
            val_14 = val_7.Length;
            if(val_14 == 0)
            {
                    val_14 = val_7.Length;
            }
            
            val_7[0] = (double)this.pos;
            val_7[1] = (double)this.rayDistance;
            val_13 = this.Range;
            val_15 = this.Collection.NearestNeighbors(v:  val_7, maxCount:  this.MaxCount, range:  val_13);
            this.pIter = val_15;
            goto label_8;
            label_15:
            Mapbox.Unity.MeshGeneration.Data.VectorEntity val_9 = this.pIter.Current;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            val_13 = val_10.x;
            val_9.Transform.localScale = new UnityEngine.Vector3() {x = val_13, y = val_10.y, z = val_10.z};
            val_15 = this.pIter;
            label_8:
            if(val_15.MoveNext() == true)
            {
                goto label_15;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public HighlightBuildings()
        {
            this.MaxCount = 100;
            this.Range = 10f;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.groundPlane = 0;
            mem[1152921519840328388] = 0;
            mem[1152921519840328396] = 0;
        }
    
    }

}
