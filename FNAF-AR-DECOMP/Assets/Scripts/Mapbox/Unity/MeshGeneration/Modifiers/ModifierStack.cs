using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ModifierStack : ModifierStackBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Modifiers.PositionTargetType moveFeaturePositionTo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int vertexIndex;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<Mapbox.Unity.MeshGeneration.Data.UnityTile, System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.VectorEntity>> _activeObjects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.Data.ObjectPool<Mapbox.Unity.MeshGeneration.Data.VectorEntity> _pool;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _tempPoint;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.Data.VectorEntity _tempVectorEntity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.Data.ObjectPool<System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.VectorEntity>> _listPool;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _counter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _secondCounter;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void OnEnable()
        {
            var val_6;
            System.Func<System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.VectorEntity>> val_8;
            this._pool = new Mapbox.Unity.MeshGeneration.Data.ObjectPool<Mapbox.Unity.MeshGeneration.Data.VectorEntity>(objectGenerator:  new System.Func<Mapbox.Unity.MeshGeneration.Data.VectorEntity>(object:  this, method:  Mapbox.Unity.MeshGeneration.Data.VectorEntity Mapbox.Unity.MeshGeneration.Modifiers.ModifierStack::<OnEnable>b__9_0()));
            val_6 = null;
            val_6 = null;
            val_8 = ModifierStack.<>c.<>9__9_1;
            if(val_8 == null)
            {
                    System.Func<System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.VectorEntity>> val_3 = null;
                val_8 = val_3;
                val_3 = new System.Func<System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.VectorEntity>>(object:  ModifierStack.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.VectorEntity> ModifierStack.<>c::<OnEnable>b__9_1());
                ModifierStack.<>c.<>9__9_1 = val_8;
            }
            
            this._listPool = new Mapbox.Unity.MeshGeneration.Data.ObjectPool<System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.VectorEntity>>(objectGenerator:  val_3);
            this._activeObjects = new System.Collections.Generic.Dictionary<Mapbox.Unity.MeshGeneration.Data.UnityTile, System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.VectorEntity>>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void OnUnregisterTile(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            var val_6;
            System.Collections.Generic.Dictionary<Mapbox.Unity.MeshGeneration.Data.UnityTile, System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.VectorEntity>> val_23;
            var val_24;
            UnityEngine.GameObject val_25;
            val_23 = this._activeObjects;
            if((val_23.ContainsKey(key:  tile)) == false)
            {
                    return;
            }
            
            int val_3 = this._activeObjects.Item[tile].Count;
            this._counter = val_3;
            if(val_3 < 1)
            {
                goto label_5;
            }
            
            var val_22 = 0;
            val_24 = 0;
            label_33:
            List.Enumerator<T> val_4 = X23.GetEnumerator();
            label_11:
            if(((-2070928688) & 1) == 0)
            {
                goto label_12;
            }
            
            Mapbox.Unity.MeshGeneration.Data.VectorEntity val_9 = this._activeObjects.Item[tile].Item[0];
            if(val_6.emailUIDataHandler != null)
            {
                goto label_11;
            }
            
            goto label_11;
            label_12:
            long val_10 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519715787472});
            if(((116 == 0) ? 116 : 116) == 116)
            {
                
            }
            
            Mapbox.Unity.MeshGeneration.Data.VectorEntity val_13 = this._activeObjects.Item[tile].Item[0];
            val_25 = val_13.GameObject;
            if(0 != val_25)
            {
                    Mapbox.Unity.MeshGeneration.Data.VectorEntity val_16 = this._activeObjects.Item[tile].Item[0];
                val_25 = val_16.GameObject;
                val_25.SetActive(value:  false);
            }
            
            this._pool.Put(item:  this._activeObjects.Item[tile].Item[0]);
            val_22 = val_22 + 1;
            if(val_22 < this._counter)
            {
                goto label_33;
            }
            
            label_5:
            this._activeObjects.Item[tile].Clear();
            val_23 = this._listPool;
            val_23.Put(item:  this._activeObjects.Item[tile]);
            bool val_21 = this._activeObjects.Remove(key:  tile);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Initialize()
        {
            var val_5;
            int val_1 = Count;
            this._counter = val_1;
            if(val_1 >= 1)
            {
                    var val_5 = 0;
                do
            {
                val_5 = X21.Item[0];
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
            var val_41;
            Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity val_42;
            Mapbox.Unity.MeshGeneration.Data.UnityTile val_43;
            Mapbox.Unity.MeshGeneration.Modifiers.PositionTargetType val_44;
            var val_45;
            UnityEngine.Vector3 val_46;
            var val_47;
            var val_48;
            UnityEngine.Vector3 val_52;
            var val_55;
            var val_56;
            UnityEngine.Vector3 val_60;
            float val_61;
            float val_62;
            int val_63;
            UnityEngine.Object val_64;
            float val_65;
            UnityEngine.Vector3 val_66;
            UnityEngine.GameObject val_67;
            int val_68;
            var val_69;
            var val_70;
            val_41 = meshData;
            val_42 = feature;
            val_43 = tile;
            val_44 = this.moveFeaturePositionTo;
            this._counter = feature.Points.Count;
            this._secondCounter = 0;
            if(val_44 == 0)
            {
                goto label_3;
            }
            
            val_45 = null;
            val_45 = null;
            val_44 = this.moveFeaturePositionTo;
            val_46 = Constants.Math.Vector3Zero;
            this._tempPoint = val_46;
            mem[1152921519716450676] = Constants.Math.Vector3Zero.__il2cppRuntimeField_4;
            mem[1152921519716450680] = Constants.Math.Vector3Zero.__il2cppRuntimeField_8;
            if(val_44 == 2)
            {
                goto label_6;
            }
            
            if(val_44 != 1)
            {
                goto label_7;
            }
            
            UnityEngine.Vector3 val_3 = feature.Points.Item[0].Item[0];
            goto label_10;
            label_3:
            val_52 = this._tempPoint;
            if(val_41 == null)
            {
                goto label_105;
            }
            
            val_55 = 0;
            goto label_105;
            label_6:
            val_56 = 1152921518939926848;
            UnityEngine.Vector3 val_5 = feature.Points.Item[0].Item[0];
            val_60 = val_5.x;
            val_61 = val_5.y;
            val_62 = val_5.z;
            val_63 = 1;
            this._tempPoint = val_5;
            mem[1152921519716450676] = val_61;
            mem[1152921519716450680] = val_62;
            this.vertexIndex = val_63;
            if(this._counter >= 1)
            {
                    var val_42 = 0;
                do
            {
                val_64 = feature.Points.Item[0];
                int val_7 = val_64.Count;
                this._secondCounter = val_7;
                if(val_7 >= 1)
            {
                    do
            {
                UnityEngine.Vector3 val_9 = feature.Points.Item[0].Item[0];
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this._tempPoint, y = val_61, z = val_62}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
                int val_41 = this.vertexIndex;
                val_64 = 0 + 1;
                val_65 = val_10.y;
                val_41 = val_41 + 1;
                this._tempPoint = val_10;
                mem[1152921519716450676] = val_65;
                mem[1152921519716450680] = val_10.z;
                this.vertexIndex = val_41;
            }
            while(val_64 < this._secondCounter);
            
            }
            
                val_42 = val_42 + 1;
            }
            while(val_42 < this._counter);
            
                val_60 = this._tempPoint;
                val_63 = this.vertexIndex;
            }
            
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_60, y = val_65, z = val_10.z}, d:  (float)val_63);
            label_10:
            val_46 = val_11.x;
            val_47 = val_11.y;
            val_48 = val_11.z;
            this._tempPoint = val_11;
            mem[1152921519716450676] = val_11.y;
            mem[1152921519716450680] = val_11.z;
            label_7:
            if(this._counter >= 1)
            {
                    var val_43 = 0;
                do
            {
                val_64 = feature.Points.Item[0];
                int val_13 = val_64.Count;
                this._secondCounter = val_13;
                if(val_13 >= 1)
            {
                    do
            {
                UnityEngine.Vector3 val_16 = feature.Points.Item[0].Item[0];
                val_66 = this._tempPoint;
                val_60 = val_16.x;
                val_56 = feature.Points.Item[0];
                UnityEngine.Vector3 val_18 = val_56.Item[0];
                float val_19 = val_60 - val_66;
                val_18.z = val_18.z - val_18.y;
                feature.Points.Item[0].set_Item(index:  0, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_64 = 0 + 1;
            }
            while(val_64 < this._secondCounter);
            
            }
            
                val_43 = val_43 + 1;
            }
            while(val_43 < this._counter);
            
                val_46 = this._tempPoint;
            }
            
            meshData.PositionInTile = val_46;
            mem2[0] = 1152921518724786432;
            mem2[0] = val_43;
            val_52 = this._tempPoint;
            val_43 = val_43;
            var val_20 = (val_41 == 0) ? 1 : 0;
            label_105:
            meshData.PositionInTile = val_52;
            mem2[0] = 1152921518724786432;
            mem2[0] = val_43;
            int val_21 = val_43.Count;
            this._counter = val_21;
            if(val_21 >= 1)
            {
                    val_52 = 1152921519698768000;
                var val_44 = 0;
                do
            {
                val_64 = val_64.Item[0];
                if(val_64 != 0)
            {
                    val_64 = val_64.Item[0];
                if(null != 0)
            {
                    val_64 = val_64.Item[0];
            }
            
            }
            
                val_44 = val_44 + 1;
            }
            while(val_44 < this._counter);
            
            }
            
            this._tempVectorEntity = this._pool.GetObject();
            val_67 = 0;
            if(val_26.GameObject == 0)
            {
                    return val_67;
            }
            
            this._tempVectorEntity.GameObject.SetActive(value:  true);
            this._tempVectorEntity.Mesh.Clear();
            this._tempVectorEntity.Feature = val_42;
            this._tempVectorEntity.Mesh.subMeshCount = meshData.Triangles.Count;
            this._tempVectorEntity.Mesh.SetVertices(inVertices:  meshData.Vertices);
            this._tempVectorEntity.Mesh.SetNormals(inNormals:  meshData.Normals);
            if(meshData.Tangents.Count >= 1)
            {
                    this._tempVectorEntity.Mesh.SetTangents(inTangents:  meshData.Tangents);
            }
            
            int val_30 = meshData.Triangles.Count;
            this._counter = val_30;
            if(val_30 >= 1)
            {
                    var val_45 = 0;
                do
            {
                val_64 = meshData.Triangles.Item[0];
                this._tempVectorEntity.Mesh.SetTriangles(triangles:  val_64, submesh:  0);
                val_45 = val_45 + 1;
            }
            while(val_45 < this._counter);
            
            }
            
            val_68 = meshData.UV.Count;
            this._counter = val_68;
            val_69 = 0;
            goto label_81;
            label_85:
            val_64 = meshData.UV.Item[0];
            this._tempVectorEntity.Mesh.SetUVs(channel:  0, uvs:  val_64);
            val_68 = this._counter;
            val_69 = 1;
            label_81:
            if(val_69 < val_68)
            {
                goto label_85;
            }
            
            val_70 = 0;
            this._tempVectorEntity.Transform.SetParent(parent:  parent.transform, worldPositionStays:  false);
            if((this._activeObjects.ContainsKey(key:  val_43)) != true)
            {
                    val_70 = public System.Void System.Collections.Generic.Dictionary<Mapbox.Unity.MeshGeneration.Data.UnityTile, System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.VectorEntity>>::Add(Mapbox.Unity.MeshGeneration.Data.UnityTile key, System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.VectorEntity> value);
                this._activeObjects.Add(key:  val_43, value:  this._listPool.GetObject());
            }
            
            val_42 = this._activeObjects.Item[val_43];
            val_42.Add(item:  this._tempVectorEntity);
            val_60 = meshData.PositionInTile;
            this._tempVectorEntity.Transform.localPosition = new UnityEngine.Vector3() {x = val_60, y = val_66, z = val_10.z};
            int val_38 = val_41.Count;
            this._counter = val_38;
            if(val_38 >= 1)
            {
                    do
            {
                if((public System.Int32 System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Modifiers.GameObjectModifier>::get_Count()) != 0)
            {
                    val_42 = this._tempVectorEntity.Transform.Item[0].Item[0];
            }
            
                val_41 = 0 + 1;
            }
            while(val_41 < this._counter);
            
            }
            
            val_52 = this._tempVectorEntity;
            val_67 = this._tempVectorEntity.GameObject;
            return val_67;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ModifierStack()
        {
            this.vertexIndex = 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.Data.VectorEntity <OnEnable>b__9_0()
        {
            UnityEngine.MeshFilter val_8;
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject();
            if(val_1 != null)
            {
                    val_8 = val_1.AddComponent<UnityEngine.MeshFilter>();
            }
            else
            {
                    val_8 = val_1.AddComponent<UnityEngine.MeshFilter>();
            }
            
            Mapbox.Unity.MeshGeneration.Data.VectorEntity val_5 = new Mapbox.Unity.MeshGeneration.Data.VectorEntity();
            .GameObject = val_1;
            .Transform = val_1.transform;
            .MeshFilter = val_8;
            .MeshRenderer = val_1.AddComponent<UnityEngine.MeshRenderer>();
            .Mesh = val_8.mesh;
            this._tempVectorEntity = val_5;
            return val_5;
        }
    
    }

}
