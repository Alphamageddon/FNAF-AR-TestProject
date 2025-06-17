using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IxStatTrackers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxMeshBlockTracker
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<UnityEngine.Vector3, SharedTechAssets.Scripts.IllumixEngine.IxStatTrackers.IxMeshBlockTracker.MeshBlockData> _data;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.IllumixEngine.IxStatTrackers.IxMeshBlockTracker_SROptions _srOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long lastOutputTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int sumVertices;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int sumTriangles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int sumBlocks;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxMeshBlockTracker()
        {
            IntPtr val_6;
            this._data = new System.Collections.Generic.Dictionary<UnityEngine.Vector3, MeshBlockData>();
            IllumixSurfaceManager.SurfaceMeshBlockUpdate val_2 = null;
            val_6 = System.Void SharedTechAssets.Scripts.IllumixEngine.IxStatTrackers.IxMeshBlockTracker::MeshBlockUpdatedEvent(IllumixMeshBlock obj);
            val_2 = new IllumixSurfaceManager.SurfaceMeshBlockUpdate(object:  this, method:  val_6);
            IllumixSurfaceManager.add_SurfaceMeshBlockUpdatedEvent(value:  val_2);
            ._tracker = this;
            this._srOptions = new SharedTechAssets.Scripts.IllumixEngine.IxStatTrackers.IxMeshBlockTracker_SROptions();
            SRDebugger.Services.IDebugService val_4 = SRDebug.Instance;
            if(val_4 == null)
            {
                    return;
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_6 = 12;
            val_4.AddOptionContainer(container:  this._srOptions);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MeshBlockUpdatedEvent(IllumixMeshBlock obj)
        {
            System.Collections.Generic.Dictionary<UnityEngine.Vector3, MeshBlockData> val_5;
            System.Collections.Generic.Dictionary<UnityEngine.Vector3, MeshBlockData> val_6;
            val_5 = this;
            if((this._data.TryGetValue(key:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, value: out  new MeshBlockData())) == false)
            {
                goto label_3;
            }
            
            if(obj.triangles.Length == 0)
            {
                goto label_5;
            }
            
            val_6 = this._data;
            val_6.set_Item(key:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, value:  new MeshBlockData() {numVertices = obj.vertices.Length, numTriangles = obj.triangles.Length});
            int val_5 = this.sumVertices;
            int val_6 = this.sumTriangles;
            val_5 = val_5 + obj.vertices.Length;
            val_6 = val_6 + obj.triangles.Length;
            val_5 = val_5 - 0;
            val_6 = val_6 - 0;
            this.sumVertices = val_5;
            this.sumTriangles = val_6;
            return;
            label_3:
            val_6 = this._data;
            val_6.set_Item(key:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, value:  new MeshBlockData() {numVertices = obj.vertices.Length, numTriangles = obj.triangles.Length});
            int val_7 = this.sumVertices;
            int val_8 = this.sumTriangles;
            int val_10 = 0;
            int val_9 = this.sumBlocks;
            val_7 = val_7 + obj.vertices.Length;
            val_8 = val_8 + obj.triangles.Length;
            val_9 = val_9 + 1;
            val_7 = val_7 - 0;
            val_10 = val_8 - val_10;
            this.sumVertices = val_7;
            this.sumTriangles = val_10;
            this.sumBlocks = val_9;
            return;
            label_5:
            val_6 = this._data;
            if((val_6.TryGetValue(key:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, value: out  new MeshBlockData())) != false)
            {
                    int val_11 = 0;
                int val_12 = 0;
                val_11 = this.sumVertices - val_11;
                val_12 = this.sumTriangles - val_12;
                this.sumVertices = val_11;
                this.sumTriangles = val_12;
                this.sumBlocks = this.sumBlocks - 1;
            }
            
            val_5 = this._data;
            bool val_4 = val_5.Remove(key:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PrintStats()
        {
        
        }
    
    }

}
