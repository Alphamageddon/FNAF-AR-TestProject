using UnityEngine;

namespace Animatronics.Animatronic3d.PrefabManagement
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PrefabCache
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ClassName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Assets.IAssetCache _assetCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, Animatronics.Animatronic3d.PrefabManagement.AnimatronicModelContainer> _animatronicModelContainers;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, Animatronics.Animatronic3d.PrefabManagement.MapIconContainer> _mapIconContainers;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RequestAnimatronicModelContainer(AnimatronicEntity.AnimatronicConfigData configData, System.Action<Animatronics.Animatronic3d.PrefabManagement.AnimatronicModelContainer> onSuccess, System.Action<string> onFailure)
        {
            Game.ItemDefinition.Data.DataDefinitions.PlushSuitData val_1 = configData.PlushSuitData;
            if((this._animatronicModelContainers.ContainsKey(key:  val_1.Id)) != true)
            {
                    Animatronics.Animatronic3d.PrefabManagement.AnimatronicModelContainer val_3 = new Animatronics.Animatronic3d.PrefabManagement.AnimatronicModelContainer();
                val_3.Setup(configData:  configData);
                this._animatronicModelContainers.Add(key:  val_1.Id, value:  val_3);
            }
            
            this._animatronicModelContainers.Item[val_1.Id].GetAnimatronicPrefab(assetCache:  this._assetCache, onSuccess:  onSuccess, onFailure:  onFailure);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RequestMapIconContainer(AnimatronicEntity.AnimatronicConfigData configData, System.Action<Animatronics.Animatronic3d.PrefabManagement.MapIconContainer> onSuccess, System.Action<string> onFailure)
        {
            Game.ItemDefinition.Data.DataDefinitions.PlushSuitData val_1 = configData.PlushSuitData;
            if((this._mapIconContainers.ContainsKey(key:  val_1.Id)) != true)
            {
                    Animatronics.Animatronic3d.PrefabManagement.MapIconContainer val_3 = new Animatronics.Animatronic3d.PrefabManagement.MapIconContainer();
                val_3.Setup(configData:  configData);
                this._mapIconContainers.Add(key:  val_1.Id, value:  val_3);
            }
            
            this._mapIconContainers.Item[val_1.Id].GetMapIconPrefab(assetCache:  this._assetCache, onSuccess:  onSuccess, onFailure:  onFailure);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AnimatronicEntityAdded(object sender, AnimatronicEntity.Container.EntityAddedRemovedArgs args)
        {
            var val_6;
            Game.ItemDefinition.Data.DataDefinitions.PlushSuitData val_2 = args.entity.animatronicConfigData.PlushSuitData;
            if((this._animatronicModelContainers.ContainsKey(key:  val_2.Id)) != false)
            {
                    val_4.<AnimatronicEntityExists>k__BackingField = true;
                this._animatronicModelContainers.Item[val_2.Id].LoadAnimatronicPrefab(assetCache:  this._assetCache);
                return;
            }
            
            val_6 = null;
            val_6 = null;
            ConsoleLogger.LogError(className:  Animatronics.Animatronic3d.PrefabManagement.PrefabCache.ClassName, functionName:  "AnimatronicEntityAdded", logString:  "Unknown entity \'" + val_2.Id + "\' added. Can\'t load animatronic model for it");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AnimatronicEntityRemoved(object sender, AnimatronicEntity.Container.EntityAddedRemovedArgs args)
        {
            var val_6;
            Game.ItemDefinition.Data.DataDefinitions.PlushSuitData val_2 = args.entity.animatronicConfigData.PlushSuitData;
            if((this._animatronicModelContainers.ContainsKey(key:  val_2.Id)) != false)
            {
                    Animatronics.Animatronic3d.PrefabManagement.AnimatronicModelContainer val_4 = this._animatronicModelContainers.Item[val_2.Id];
                val_4.<AnimatronicEntityExists>k__BackingField = false;
                return;
            }
            
            val_6 = null;
            val_6 = null;
            ConsoleLogger.LogError(className:  Animatronics.Animatronic3d.PrefabManagement.PrefabCache.ClassName, functionName:  "AnimatronicEntityRemoved", logString:  "Unknown entity \'" + val_2.Id + "\' removed");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Systems.AssetManagement.Assets.IAssetCache assetCache)
        {
            this._assetCache = assetCache;
            this._animatronicModelContainers = new System.Collections.Generic.Dictionary<System.String, Animatronics.Animatronic3d.PrefabManagement.AnimatronicModelContainer>();
            this._mapIconContainers = new System.Collections.Generic.Dictionary<System.String, Animatronics.Animatronic3d.PrefabManagement.MapIconContainer>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddContainerForConfig(AnimatronicEntity.AnimatronicConfigData configData)
        {
            Animatronics.Animatronic3d.PrefabManagement.AnimatronicModelContainer val_1 = new Animatronics.Animatronic3d.PrefabManagement.AnimatronicModelContainer();
            val_1.Setup(configData:  configData);
            Game.ItemDefinition.Data.DataDefinitions.PlushSuitData val_2 = configData.PlushSuitData;
            this._animatronicModelContainers.Add(key:  val_2.Id, value:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessPreExistingAnimatronicEntity(AnimatronicEntity.AnimatronicEntity entity)
        {
            .entity = entity;
            this.AnimatronicEntityAdded(sender:  0, args:  new Container.EntityAddedRemovedArgs());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this._animatronicModelContainers.Values.GetEnumerator();
            label_5:
            if(((-1015355816) & 1) == 0)
            {
                goto label_3;
            }
            
            if(0.emailUIDataHandler != null)
            {
                goto label_5;
            }
            
            goto label_5;
            label_3:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525066327640});
            this._animatronicModelContainers.Clear();
            this._animatronicModelContainers = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PrefabCache()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PrefabCache()
        {
            Animatronics.Animatronic3d.PrefabManagement.PrefabCache.ClassName = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
    
    }

}
