using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ReplaceFeatureCollectionModifier : GameObjectModifier, IReplacementCriteria
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Modifiers.FeatureBundle> features;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Modifiers.ReplaceFeatureModifier> _replaceFeatureModifiers;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnValidate()
        {
            var val_7;
            string val_8;
            val_7 = 0;
            goto label_1;
            label_15:
            Mapbox.Unity.MeshGeneration.Modifiers.FeatureBundle val_1 = this.features.Item[0];
            Mapbox.Unity.MeshGeneration.Modifiers.FeatureBundle val_2 = this.features.Item[0];
            if(val_2.prefab != 0)
            {
                goto label_7;
            }
            
            val_8 = "Feature";
            if(val_1 != null)
            {
                goto label_13;
            }
            
            goto label_9;
            label_7:
            Mapbox.Unity.MeshGeneration.Modifiers.FeatureBundle val_4 = this.features.Item[0];
            val_8 = val_4.prefab.name;
            if(val_1 != null)
            {
                goto label_13;
            }
            
            label_9:
            label_13:
            val_7 = 1;
            val_1.Name = val_8;
            label_1:
            if(val_7 < this.features.Count)
            {
                goto label_15;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Initialize()
        {
            var val_4;
            var val_12;
            System.Collections.Generic.List<System.String> val_13;
            val_12 = this;
            this._replaceFeatureModifiers = new System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Modifiers.ReplaceFeatureModifier>();
            List.Enumerator<T> val_2 = this.features.GetEnumerator();
            label_8:
            if(((-2077767424) & 1) == 0)
            {
                    return;
            }
            
            GameUI.EmailUIDataHandler val_5 = val_4.emailUIDataHandler;
            mem2[0] = val_5._serverGameUIDataModel;
            new Mapbox.Unity.Map.SpawnPrefabOptions() = new Mapbox.Unity.Map.SpawnPrefabOptions();
            if(new Mapbox.Unity.Map.SpawnPrefabOptions() != null)
            {
                    .prefab = val_5._emailDatas;
                val_13 = val_5._emailIdsToBeDeletedOnServer;
            }
            else
            {
                    mem[16] = val_5._emailDatas;
                val_13 = val_5._emailIdsToBeDeletedOnServer;
            }
            
            .scaleDownWithWorld = val_13;
            val_6._options = new Mapbox.Unity.Map.SpawnPrefabOptions();
            System.Collections.Generic.List<System.String> val_8 = new System.Collections.Generic.List<System.String>(collection:  val_5._emailIdsToBeSetToReadOnServer);
            val_6._prefabLocations = null;
            System.Collections.Generic.List<System.String> val_9 = new System.Collections.Generic.List<System.String>(collection:  val_5._itemDefinitions);
            val_6._explicitlyBlockedFeatureIds = null;
            this._replaceFeatureModifiers.Add(item:  UnityEngine.ScriptableObject.CreateInstance<Mapbox.Unity.MeshGeneration.Modifiers.ReplaceFeatureModifier>());
            goto label_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void FeaturePreProcess(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature)
        {
            Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity val_6 = feature;
            List.Enumerator<T> val_1 = this._replaceFeatureModifiers.GetEnumerator();
            label_7:
            if(((-2077573464) & 1) == 0)
            {
                goto label_2;
            }
            
            GameUI.EmailUIDataHandler val_2 = 0.emailUIDataHandler;
            if((val_2 == 0) || (val_2 != null))
            {
                goto label_7;
            }
            
            goto label_7;
            label_2:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519709142696});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SetProperties(Mapbox.Unity.MeshGeneration.Modifiers.ModifierProperties properties)
        {
            Mapbox.Unity.MeshGeneration.Modifiers.ModifierProperties val_6 = properties;
            List.Enumerator<T> val_1 = this._replaceFeatureModifiers.GetEnumerator();
            label_7:
            if(((-2077428696) & 1) == 0)
            {
                goto label_2;
            }
            
            GameUI.EmailUIDataHandler val_2 = 0.emailUIDataHandler;
            if((val_2 == 0) || (val_2 != null))
            {
                goto label_7;
            }
            
            goto label_7;
            label_2:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519709287464});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShouldReplaceFeature(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature)
        {
            Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity val_8;
            var val_9;
            val_8 = feature;
            List.Enumerator<T> val_1 = this._replaceFeatureModifiers.GetEnumerator();
            label_7:
            if(((-2077283928) & 1) == 0)
            {
                goto label_2;
            }
            
            GameUI.EmailUIDataHandler val_2 = 0.emailUIDataHandler;
            if((val_2 == 0) || ((val_2.ShouldReplaceFeature(feature:  val_8)) == false))
            {
                goto label_7;
            }
            
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519709432232});
            val_9 = 1;
            return (bool)val_9;
            label_2:
            long val_6 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519709432232});
            val_9 = 0;
            return (bool)val_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Run(Mapbox.Unity.MeshGeneration.Data.VectorEntity ve, Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            Mapbox.Unity.MeshGeneration.Data.UnityTile val_5 = tile;
            List.Enumerator<T> val_1 = this._replaceFeatureModifiers.GetEnumerator();
            label_4:
            if(((-2077135064) & 1) == 0)
            {
                goto label_2;
            }
            
            if(0.emailUIDataHandler != null)
            {
                goto label_4;
            }
            
            goto label_4;
            label_2:
            long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519709581096});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void OnPoolItem(Mapbox.Unity.MeshGeneration.Data.VectorEntity vectorEntity)
        {
            Mapbox.Unity.MeshGeneration.Data.VectorEntity val_5 = vectorEntity;
            List.Enumerator<T> val_1 = this._replaceFeatureModifiers.GetEnumerator();
            label_4:
            if(((-2076986184) & 1) == 0)
            {
                goto label_2;
            }
            
            if(0.emailUIDataHandler != null)
            {
                goto label_4;
            }
            
            goto label_4;
            label_2:
            long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519709729976});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ReplaceFeatureCollectionModifier()
        {
            this.features = new System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Modifiers.FeatureBundle>();
            mem[1152921519709875576] = 1;
            this = new UnityEngine.ScriptableObject();
        }
    
    }

}
