using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SpawnInsideModifier : GameObjectModifier
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _spawnRateInSquareMeters;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _maxSpawn;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject[] _prefabs;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.LayerMask _layerMask;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _scaleDownWithWorld;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _randomizeScale;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _randomizeRotation;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _spawnedCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<UnityEngine.GameObject, System.Collections.Generic.List<UnityEngine.GameObject>> _objects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Queue<UnityEngine.GameObject> _pool;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Initialize()
        {
            if(this._objects != null)
            {
                    if(this._pool != null)
            {
                    return;
            }
            
            }
            
            this._objects = new System.Collections.Generic.Dictionary<UnityEngine.GameObject, System.Collections.Generic.List<UnityEngine.GameObject>>();
            this._pool = new System.Collections.Generic.Queue<UnityEngine.GameObject>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Run(Mapbox.Unity.MeshGeneration.Data.VectorEntity ve, Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            var val_3;
            float val_4;
            float val_24;
            int val_25;
            float val_26;
            float val_27;
            float val_28;
            float val_29;
            this._spawnedCount = 0;
            UnityEngine.Bounds val_2 = ve.GameObject.GetComponent<UnityEngine.Collider>().bounds;
            float val_23 = val_4;
            val_24 = val_23;
            val_25 = this._spawnRateInSquareMeters;
            val_23 = val_24 * V2.16B;
            int val_6 = UnityEngine.Mathf.Min(a:  (int)val_23 / val_25, b:  this._maxSpawn);
            if(this._spawnedCount >= val_6)
            {
                    return;
            }
            
            val_24 = 100f;
            do
            {
                float val_7 = UnityEngine.Random.Range(min:  -0.02490234f, max:  180f);
                val_26 = V2.16B;
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = UnityEngine.Random.Range(min:  -V2.16B, max:  V2.16B), y = val_26, z = V2.16B}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.down;
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  2000f);
                val_3 = 0;
                val_4 = 0;
                if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  150f, layerMask:  UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this._layerMask}))) != false)
            {
                    val_25 = this.GetObject(index:  UnityEngine.Random.Range(min:  0, max:  this._prefabs.Length), go:  ve.GameObject).transform;
                val_26 = val_9.y;
                val_27 = 150f;
                val_28 = val_26;
                val_29 = val_9.z;
                val_25.position = new UnityEngine.Vector3() {x = 150f, y = val_28, z = val_29};
                if(this._randomizeRotation != false)
            {
                    float val_17 = UnityEngine.Random.Range(min:  -180f, max:  180f);
                val_4 = 0;
                val_27 = 0f;
                val_28 = 0f;
                val_29 = 0f;
                val_25.localEulerAngles = new UnityEngine.Vector3() {x = val_27, y = val_28, z = val_29};
            }
            
                if(this._scaleDownWithWorld != true)
            {
                    UnityEngine.Vector3 val_18 = UnityEngine.Vector3.one;
                UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, d:  tile.TileScale);
                val_26 = val_20.y;
                val_27 = val_20.x;
                val_28 = val_26;
                val_29 = val_20.z;
                val_25.localScale = new UnityEngine.Vector3() {x = val_27, y = val_28, z = val_29};
            }
            
                if(this._randomizeScale != false)
            {
                    UnityEngine.Vector3 val_21 = val_25.localScale;
                val_26 = val_21.z;
                float val_24 = 0.7f;
                val_24 = val_21.y * val_24;
                val_21.y = val_21.y * 1.3f;
                val_25.localScale = new UnityEngine.Vector3() {x = val_21.x, y = UnityEngine.Random.Range(min:  val_24, max:  val_21.y), z = val_26};
            }
            
            }
            
                int val_25 = this._spawnedCount;
                val_25 = val_25 + 1;
                this._spawnedCount = val_25;
            }
            while(val_25 < val_6);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void OnPoolItem(Mapbox.Unity.MeshGeneration.Data.VectorEntity vectorEntity)
        {
            UnityEngine.GameObject val_9;
            System.Collections.Generic.Dictionary<UnityEngine.GameObject, System.Collections.Generic.List<UnityEngine.GameObject>> val_10;
            val_9 = vectorEntity;
            val_10 = this._objects;
            if((val_10.ContainsKey(key:  vectorEntity.GameObject)) == false)
            {
                    return;
            }
            
            List.Enumerator<T> val_3 = this._objects.Item[vectorEntity.GameObject].GetEnumerator();
            label_9:
            if(((-2090512840) & 1) == 0)
            {
                goto label_6;
            }
            
            GameUI.EmailUIDataHandler val_4 = 0.emailUIDataHandler;
            val_4.SetActive(value:  false);
            this._pool.Enqueue(item:  val_4);
            goto label_9;
            label_6:
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519696203320});
            val_10 = this._objects.Item[vectorEntity.GameObject];
            val_10.Clear();
            val_9 = vectorEntity.GameObject;
            bool val_8 = this._objects.Remove(key:  val_9);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject GetObject(int index, UnityEngine.GameObject go)
        {
            UnityEngine.GameObject val_10;
            UnityEngine.GameObject val_11;
            val_10 = go;
            if(this._pool.Count < 1)
            {
                goto label_2;
            }
            
            val_11 = this._pool.Dequeue();
            if(val_11 == null)
            {
                goto label_4;
            }
            
            val_11.SetActive(value:  true);
            goto label_5;
            label_2:
            val_11 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this._prefabs[(long)index], parent:  val_10.transform, worldPositionStays:  false);
            goto label_11;
            label_4:
            val_11.SetActive(value:  true);
            label_5:
            val_11.transform.SetParent(p:  val_10.transform);
            label_11:
            if((this._objects.ContainsKey(key:  val_10)) != false)
            {
                    val_10 = this._objects.Item[val_10];
                val_10.Add(item:  val_11);
                return val_11;
            }
            
            System.Collections.Generic.List<UnityEngine.GameObject> val_9 = new System.Collections.Generic.List<UnityEngine.GameObject>();
            val_9.Add(item:  val_11);
            this._objects.Add(key:  val_10, value:  val_9);
            return val_11;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SpawnInsideModifier()
        {
            this._maxSpawn = 1000;
            mem[1152921519696681112] = 1;
            val_1 = new UnityEngine.ScriptableObject();
        }
    
    }

}
