using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PrefabModifier : GameObjectModifier
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<UnityEngine.GameObject, UnityEngine.GameObject> _objects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.SpawnPrefabOptions _options;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.GameObject> _prefabList;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Initialize()
        {
            if(this._objects != null)
            {
                    return;
            }
            
            this._objects = new System.Collections.Generic.Dictionary<UnityEngine.GameObject, UnityEngine.GameObject>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SetProperties(Mapbox.Unity.MeshGeneration.Modifiers.ModifierProperties properties)
        {
            Mapbox.Unity.MeshGeneration.Modifiers.ModifierProperties val_3 = properties;
            if(val_3 != null)
            {
                    val_3 = 0;
            }
            
            this._options = val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Run(Mapbox.Unity.MeshGeneration.Data.VectorEntity ve, Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            UnityEngine.GameObject val_6;
            UnityEngine.GameObject val_7;
            Mapbox.Unity.Map.SpawnPrefabOptions val_8;
            if((this._objects.ContainsKey(key:  ve.GameObject)) != false)
            {
                    val_6 = ve.GameObject;
                val_7 = this._objects.Item[val_6];
                val_8 = this._options;
            }
            else
            {
                    val_8 = this;
                val_7 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this._options.prefab);
                this._prefabList.Add(item:  val_7);
                this._objects.Add(key:  ve.GameObject, value:  val_7);
                val_6 = val_7.transform;
                val_6.SetParent(parent:  ve.GameObject.transform, worldPositionStays:  false);
            }
            
            this.PositionScaleRectTransform(ve:  ve, tile:  tile, go:  val_7);
            if(this._options.AllPrefabsInstatiated == null)
            {
                    return;
            }
            
            this._options.AllPrefabsInstatiated.Invoke(obj:  this._prefabList);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PositionScaleRectTransform(Mapbox.Unity.MeshGeneration.Data.VectorEntity ve, Mapbox.Unity.MeshGeneration.Data.UnityTile tile, UnityEngine.GameObject go)
        {
            var val_4;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_27;
            Mapbox.Unity.Map.SpawnPrefabOptions val_28;
            float val_29;
            float val_30;
            float val_31;
            var val_32;
            var val_33;
            float val_34;
            float val_35;
            UnityEngine.Object val_36;
            var val_37;
            float val_41;
            val_27 = ve;
            val_28 = 1152921518939926848;
            List.Enumerator<T> val_2 = ve.Feature.Points.Item[0].GetEnumerator();
            val_29 = 0f;
            val_30 = 0f;
            val_31 = 0f;
            goto label_5;
            label_8:
            UnityEngine.Vector3 val_5 = val_4.position;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_31, y = val_30, z = val_29}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            val_29 = val_6.z;
            val_30 = val_6.y;
            val_31 = val_6.x;
            label_5:
            if(((-2091317200) & 1) != 0)
            {
                goto label_8;
            }
            
            val_32 = 0;
            val_33 = 1;
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519695398960});
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_31, y = val_30, z = val_29}, d:  (float)ve.Feature.Points.Item[0].Count);
            val_34 = val_10.x;
            val_35 = val_10.y;
            string val_12 = ve.Feature.Data.Id.ToString();
            if(go != null)
            {
                    go.name = val_12;
            }
            else
            {
                    0.name = val_12;
            }
            
            val_36 = go.GetComponent<UnityEngine.RectTransform>();
            val_37 = 0;
            if(val_36 != 0)
            {
                goto label_26;
            }
            
            go.transform.localPosition = new UnityEngine.Vector3() {x = val_34, y = val_35, z = val_10.z};
            val_36 = this._options;
            if(this._options.scaleDownWithWorld == false)
            {
                goto label_42;
            }
            
            val_36 = this._options.prefab.transform;
            UnityEngine.Vector3 val_18 = val_36.localScale;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, d:  tile.TileScale);
            val_35 = val_20.x;
            val_41 = val_20.y;
            val_34 = val_20.z;
            if(go.transform != null)
            {
                goto label_39;
            }
            
            goto label_39;
            label_26:
            val_36.anchoredPosition3D = new UnityEngine.Vector3() {x = val_34, y = val_35, z = val_10.z};
            val_28 = this._options;
            if(this._options.scaleDownWithWorld == false)
            {
                goto label_42;
            }
            
            UnityEngine.Vector3 val_22 = this._options.prefab.transform.localScale;
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, d:  tile.TileScale);
            val_35 = val_24.x;
            val_41 = val_24.y;
            val_34 = val_24.z;
            label_39:
            val_36.localScale = new UnityEngine.Vector3() {x = val_35, y = val_41, z = val_34};
            label_42:
            Mapbox.Unity.MeshGeneration.Interfaces.IFeaturePropertySettable val_25 = go.GetComponent<Mapbox.Unity.MeshGeneration.Interfaces.IFeaturePropertySettable>();
            if(val_25 == null)
            {
                    return;
            }
            
            val_27 = ve.Feature.Properties;
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_37 = 0;
            val_25.Set(props:  val_27);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PrefabModifier()
        {
            this._prefabList = new System.Collections.Generic.List<UnityEngine.GameObject>();
            mem[1152921519695633752] = 1;
            this = new UnityEngine.ScriptableObject();
        }
    
    }

}
