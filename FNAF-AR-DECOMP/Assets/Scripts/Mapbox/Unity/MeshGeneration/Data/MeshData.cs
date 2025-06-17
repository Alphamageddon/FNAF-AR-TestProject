using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MeshData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 PositionInTile;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<int> Edges;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector2 MercatorCenter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.RectD TileRect;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<UnityEngine.Vector3> Vertices;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<UnityEngine.Vector3> Normals;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<UnityEngine.Vector4> Tangents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<System.Collections.Generic.List<int>> Triangles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>> UV;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MeshData()
        {
            this.Edges = new System.Collections.Generic.List<System.Int32>();
            this.Vertices = new System.Collections.Generic.List<UnityEngine.Vector3>();
            this.Normals = new System.Collections.Generic.List<UnityEngine.Vector3>();
            this.Tangents = new System.Collections.Generic.List<UnityEngine.Vector4>();
            this.Triangles = new System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>();
            System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>> val_6 = new System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>>();
            this.UV = val_6;
            val_6.Add(item:  new System.Collections.Generic.List<UnityEngine.Vector2>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void Clear()
        {
            System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>> val_9;
            this.Edges.Clear();
            this.Vertices.Clear();
            this.Normals.Clear();
            this.Tangents.Clear();
            List.Enumerator<T> val_1 = this.Triangles.GetEnumerator();
            label_8:
            if(((-2025683560) & 1) == 0)
            {
                goto label_6;
            }
            
            0.emailUIDataHandler.Clear();
            goto label_8;
            label_6:
            long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519761032600});
            val_9 = this.UV;
            List.Enumerator<T> val_5 = val_9.GetEnumerator();
            label_16:
            if(( & 1) == 0)
            {
                goto label_14;
            }
            
            0.emailUIDataHandler.Clear();
            goto label_16;
            label_14:
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {});
        }
    
    }

}
