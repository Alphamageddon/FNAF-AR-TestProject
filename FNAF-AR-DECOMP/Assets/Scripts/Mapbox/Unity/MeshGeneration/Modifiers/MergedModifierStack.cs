using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MergedModifierStack : ModifierStackBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<Mapbox.Unity.MeshGeneration.Data.UnityTile, int> _cacheVertexCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<Mapbox.Unity.MeshGeneration.Data.UnityTile, System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.MeshData>> _cached;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<Mapbox.Unity.MeshGeneration.Data.UnityTile, int> _buildingCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<Mapbox.Unity.MeshGeneration.Data.UnityTile, System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.VectorEntity>> _activeObjects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.Data.MeshData _tempMeshData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.MeshFilter _tempMeshFilter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _tempGameObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.Data.VectorEntity _tempVectorEntity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.Data.MeshData _temp2MeshData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.Data.ObjectPool<Mapbox.Unity.MeshGeneration.Data.VectorEntity> _pool;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.Data.ObjectPool<System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.VectorEntity>> _listPool;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.Data.ObjectPool<System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.MeshData>> _meshDataPool;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _counter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _counter2;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void OnEnable()
        {
            var val_8;
            System.Func<System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.VectorEntity>> val_10;
            var val_11;
            System.Func<System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.MeshData>> val_13;
            this._pool = new Mapbox.Unity.MeshGeneration.Data.ObjectPool<Mapbox.Unity.MeshGeneration.Data.VectorEntity>(objectGenerator:  new System.Func<Mapbox.Unity.MeshGeneration.Data.VectorEntity>(object:  this, method:  Mapbox.Unity.MeshGeneration.Data.VectorEntity Mapbox.Unity.MeshGeneration.Modifiers.MergedModifierStack::<OnEnable>b__14_0()));
            val_8 = null;
            val_8 = null;
            val_10 = MergedModifierStack.<>c.<>9__14_1;
            if(val_10 == null)
            {
                    System.Func<System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.VectorEntity>> val_3 = null;
                val_10 = val_3;
                val_3 = new System.Func<System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.VectorEntity>>(object:  MergedModifierStack.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.VectorEntity> MergedModifierStack.<>c::<OnEnable>b__14_1());
                MergedModifierStack.<>c.<>9__14_1 = val_10;
            }
            
            this._listPool = new Mapbox.Unity.MeshGeneration.Data.ObjectPool<System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.VectorEntity>>(objectGenerator:  val_3);
            val_11 = null;
            val_11 = null;
            val_13 = MergedModifierStack.<>c.<>9__14_2;
            if(val_13 == null)
            {
                    System.Func<System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.MeshData>> val_5 = null;
                val_13 = val_5;
                val_5 = new System.Func<System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.MeshData>>(object:  MergedModifierStack.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.MeshData> MergedModifierStack.<>c::<OnEnable>b__14_2());
                MergedModifierStack.<>c.<>9__14_2 = val_13;
            }
            
            this._meshDataPool = new Mapbox.Unity.MeshGeneration.Data.ObjectPool<System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.MeshData>>(objectGenerator:  val_5);
            this._tempMeshData = new Mapbox.Unity.MeshGeneration.Data.MeshData();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void OnUnregisterTile(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            int val_21;
            var val_22;
            if((this._activeObjects.ContainsKey(key:  tile)) == false)
            {
                goto label_2;
            }
            
            val_21 = this._activeObjects.Item[tile].Count;
            this._counter = val_21;
            val_22 = 0;
            goto label_5;
            label_19:
            Mapbox.Unity.MeshGeneration.Data.VectorEntity val_4 = X23.Item[0];
            if(0 != val_4.GameObject)
            {
                    Mapbox.Unity.MeshGeneration.Data.VectorEntity val_7 = this._activeObjects.Item[tile].Item[0];
                val_7.GameObject.SetActive(value:  false);
            }
            
            this._pool.Put(item:  this._activeObjects.Item[tile].Item[0]);
            val_21 = this._counter;
            val_22 = 1;
            label_5:
            if(val_22 < val_21)
            {
                goto label_19;
            }
            
            this._activeObjects.Item[tile].Clear();
            this._listPool.Put(item:  this._activeObjects.Item[tile]);
            bool val_12 = this._activeObjects.Remove(key:  tile);
            label_2:
            if((this._cacheVertexCount.ContainsKey(key:  tile)) != false)
            {
                    bool val_14 = this._cacheVertexCount.Remove(key:  tile);
            }
            
            if((this._cached.ContainsKey(key:  tile)) != false)
            {
                    this._cached.Item[tile].Clear();
                this._meshDataPool.Put(item:  this._cached.Item[tile]);
                bool val_18 = this._cached.Remove(key:  tile);
            }
            
            if((this._buildingCount.ContainsKey(key:  tile)) == false)
            {
                    return;
            }
            
            bool val_20 = this._buildingCount.Remove(key:  tile);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Initialize()
        {
            var val_5 = 1152921519698751616;
            this._cacheVertexCount.Clear();
            this._cached.Clear();
            this._buildingCount.Clear();
            this._pool.Clear();
            int val_1 = this._pool.Count;
            this._counter = val_1;
            if(val_1 >= 1)
            {
                    var val_5 = 0;
                do
            {
                val_5 = Item[0];
                val_5 = val_5 + 1;
            }
            while(val_5 < this._counter);
            
            }
            
            int val_3 = val_5.Count;
            this._counter = val_3;
            if(val_3 < 1)
            {
                    return;
            }
            
            var val_6 = 0;
            do
            {
                val_5 = val_5.Item[0];
                val_6 = val_6 + 1;
            }
            while(val_6 < this._counter);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override UnityEngine.GameObject Execute(Mapbox.Unity.MeshGeneration.Data.UnityTile tile, Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature, Mapbox.Unity.MeshGeneration.Data.MeshData meshData, UnityEngine.GameObject parent, string type = "")
        {
            System.Collections.Generic.Dictionary<Mapbox.Unity.MeshGeneration.Data.UnityTile, System.Int32> val_17;
            UnityEngine.Object val_18;
            int val_19;
            var val_20;
            if((this._cacheVertexCount.ContainsKey(key:  tile)) != false)
            {
                    val_17 = this._buildingCount;
            }
            else
            {
                    this._cacheVertexCount.Add(key:  tile, value:  0);
                this._cached.Add(key:  tile, value:  this._meshDataPool.GetObject());
                val_17 = this;
                this._buildingCount.Add(key:  tile, value:  0);
            }
            
            if(null != null)
            {
                    val_18 = null.Item[tile];
            }
            else
            {
                    val_18 = 0.Item[tile];
            }
            
            null.set_Item(key:  tile, value:  val_18 + 1);
            int val_6 = null.Count;
            this._counter = val_6;
            if(val_6 >= 1)
            {
                    var val_17 = 0;
                do
            {
                val_18 = val_18.Item[0];
                if(val_18 != 0)
            {
                    val_18 = val_18.Item[0];
                if(null != 0)
            {
                    val_18 = val_18.Item[0];
            }
            
            }
            
                val_17 = val_17 + 1;
            }
            while(val_17 < this._counter);
            
            }
            
            this._counter = meshData.Vertices.Count;
            int val_18 = this._counter;
            val_18 = val_18 + this._cacheVertexCount.Item[tile];
            if(val_18 > 64999)
            {
                    return this.End(tile:  tile, parent:  public System.Int32 System.Collections.Generic.Dictionary<Mapbox.Unity.MeshGeneration.Data.UnityTile, System.Int32>::get_Item(Mapbox.Unity.MeshGeneration.Data.UnityTile key), name:  type);
            }
            
            if(this._cacheVertexCount != null)
            {
                    val_19 = this._counter;
                val_20 = this._cacheVertexCount.Item[tile];
            }
            else
            {
                    val_19 = this._counter;
                val_20 = 0.Item[tile];
            }
            
            this._cacheVertexCount.set_Item(key:  tile, value:  val_20 + val_19);
            this._cached.Item[tile].Add(item:  meshData);
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject End(Mapbox.Unity.MeshGeneration.Data.UnityTile tile, UnityEngine.GameObject parent, string name = "")
        {
            Mapbox.Unity.MeshGeneration.Data.MeshData val_43;
            string val_44;
            Mapbox.Unity.MeshGeneration.Data.UnityTile val_45;
            System.Collections.Generic.List<UnityEngine.Vector3> val_46;
            int val_47;
            var val_48;
            int val_49;
            var val_50;
            var val_51;
            UnityEngine.GameObject val_52;
            val_44 = name;
            val_45 = tile;
            if((this._cached.ContainsKey(key:  val_45)) == false)
            {
                goto label_69;
            }
            
            this._tempMeshData.Clear();
            int val_3 = this._cached.Item[val_45].Count;
            this._counter = val_3;
            if(val_3 < 1)
            {
                goto label_6;
            }
            
            val_44 = 1152921519699219328;
            label_66:
            this._temp2MeshData = this._cached.Item[val_45].Item[0];
            val_46 = val_5.Vertices;
            if(val_46.Count < 4)
            {
                goto label_53;
            }
            
            val_46 = this._tempMeshData.Vertices.Count;
            this._tempMeshData.Vertices.AddRange(collection:  this._temp2MeshData.Vertices);
            this._tempMeshData.Normals.AddRange(collection:  this._temp2MeshData.Normals);
            val_47 = this._temp2MeshData.UV.Count;
            if(val_47 >= 1)
            {
                    var val_43 = 0;
                do
            {
                if(this._tempMeshData.UV.Count <= val_43)
            {
                    this._tempMeshData.UV.Add(item:  new System.Collections.Generic.List<UnityEngine.Vector2>(capacity:  this._temp2MeshData.UV.Item[0].Count));
                val_47 = val_47;
            }
            
                val_43 = val_43 + 1;
            }
            while(val_47 != val_43);
            
            }
            
            int val_13 = this._temp2MeshData.UV.Count;
            if(val_13 >= 1)
            {
                    var val_44 = 0;
                do
            {
                val_47 = this._temp2MeshData.UV.Item[0];
                this._tempMeshData.UV.Item[0].AddRange(collection:  val_47);
                val_44 = val_44 + 1;
            }
            while(val_13 != val_44);
            
            }
            
            int val_16 = this._temp2MeshData.Triangles.Count;
            if(val_16 < 1)
            {
                goto label_53;
            }
            
            var val_45 = 0;
            do
            {
                if(this._tempMeshData.Triangles.Count <= val_45)
            {
                    System.Collections.Generic.List<System.Int32> val_20 = null;
                val_47 = val_20;
                val_20 = new System.Collections.Generic.List<System.Int32>(capacity:  this._temp2MeshData.Triangles.Item[0].Count);
                this._tempMeshData.Triangles.Add(item:  val_20);
            }
            
                val_45 = val_45 + 1;
            }
            while(val_16 != val_45);
            
            if(val_16 < 1)
            {
                goto label_53;
            }
            
            var val_46 = 0;
            label_65:
            val_48 = 0;
            goto label_54;
            label_64:
            this._tempMeshData.Triangles.Item[0].Add(item:  this._temp2MeshData.Triangles.Item[0].Item[0] + val_46);
            val_48 = 1;
            label_54:
            val_47 = this._temp2MeshData.Triangles.Item[0];
            if(val_48 < val_47.Count)
            {
                goto label_64;
            }
            
            val_46 = val_46 + 1;
            if(val_46 != val_16)
            {
                goto label_65;
            }
            
            label_53:
            var val_47 = 0;
            val_45 = val_45;
            val_47 = val_47 + 1;
            if(val_47 < this._counter)
            {
                goto label_66;
            }
            
            label_6:
            val_43 = this._tempMeshData;
            if(this._tempMeshData.Vertices.Count < 4)
            {
                goto label_69;
            }
            
            this._cached.Item[val_45].Clear();
            this._cacheVertexCount.set_Item(key:  val_45, value:  0);
            this._tempVectorEntity = 0;
            this._tempVectorEntity = this._pool.GetObject();
            val_29.GameObject.SetActive(value:  true);
            this._tempVectorEntity.Mesh.Clear();
            this._tempVectorEntity.GameObject.name = val_44;
            this._tempVectorEntity.Mesh.subMeshCount = this._tempMeshData.Triangles.Count;
            this._tempVectorEntity.Mesh.SetVertices(inVertices:  this._tempMeshData.Vertices);
            this._tempVectorEntity.Mesh.SetNormals(inNormals:  this._tempMeshData.Normals);
            int val_31 = this._tempMeshData.Triangles.Count;
            this._counter = val_31;
            if(val_31 >= 1)
            {
                    var val_48 = 0;
                do
            {
                this._tempVectorEntity.Mesh.SetTriangles(triangles:  this._tempMeshData.Triangles.Item[0], submesh:  0);
                val_48 = val_48 + 1;
            }
            while(val_48 < this._counter);
            
            }
            
            val_49 = this._tempMeshData.UV.Count;
            this._counter = val_49;
            val_50 = 0;
            goto label_100;
            label_105:
            val_49.SetUVs(channel:  0, uvs:  this._tempMeshData.UV.Item[0]);
            val_49 = this._counter;
            val_50 = 1;
            label_100:
            val_46 = this._tempVectorEntity;
            if(val_50 < val_49)
            {
                goto label_105;
            }
            
            val_51 = 0;
            this._tempVectorEntity.GameObject.transform.SetParent(parent:  val_45.transform, worldPositionStays:  false);
            if((this._activeObjects.ContainsKey(key:  val_45)) != true)
            {
                    val_51 = public System.Void System.Collections.Generic.Dictionary<Mapbox.Unity.MeshGeneration.Data.UnityTile, System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.VectorEntity>>::Add(Mapbox.Unity.MeshGeneration.Data.UnityTile key, System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.VectorEntity> value);
                this._activeObjects.Add(key:  val_45, value:  this._listPool.GetObject());
            }
            
            System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.VectorEntity> val_39 = this._activeObjects.Item[val_45];
            val_39.Add(item:  this._tempVectorEntity);
            int val_40 = this._tempVectorEntity.Count;
            this._counter = val_40;
            if(val_40 >= 1)
            {
                    do
            {
                if((public System.Int32 System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Modifiers.GameObjectModifier>::get_Count()) != 0)
            {
                    val_46 = val_39.Item[0].Item[0];
            }
            
                val_44 = 0 + 1;
            }
            while(val_44 < this._counter);
            
            }
            
            val_43 = this._tempVectorEntity;
            val_52 = this._tempVectorEntity.GameObject;
            return (UnityEngine.GameObject)val_52;
            label_69:
            val_52 = 0;
            return (UnityEngine.GameObject)val_52;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MergedModifierStack()
        {
            this._cacheVertexCount = new System.Collections.Generic.Dictionary<Mapbox.Unity.MeshGeneration.Data.UnityTile, System.Int32>();
            this._cached = new System.Collections.Generic.Dictionary<Mapbox.Unity.MeshGeneration.Data.UnityTile, System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.MeshData>>();
            this._buildingCount = new System.Collections.Generic.Dictionary<Mapbox.Unity.MeshGeneration.Data.UnityTile, System.Int32>();
            this._activeObjects = new System.Collections.Generic.Dictionary<Mapbox.Unity.MeshGeneration.Data.UnityTile, System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.VectorEntity>>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.Data.VectorEntity <OnEnable>b__14_0()
        {
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject();
            this._tempGameObject = val_1;
            UnityEngine.MeshFilter val_2 = val_1.AddComponent<UnityEngine.MeshFilter>();
            this._tempMeshFilter = val_2;
            val_2.mesh.MarkDynamic();
            Mapbox.Unity.MeshGeneration.Data.VectorEntity val_4 = new Mapbox.Unity.MeshGeneration.Data.VectorEntity();
            .GameObject = this._tempGameObject;
            .Transform = this._tempGameObject.transform;
            .MeshFilter = this._tempMeshFilter;
            .MeshRenderer = this._tempGameObject.AddComponent<UnityEngine.MeshRenderer>();
            .Mesh = this._tempMeshFilter.mesh;
            this._tempVectorEntity = val_4;
            return val_4;
        }
    
    }

}
