using UnityEngine;

namespace Game.EssenceCollection.Data.EssenceNodes
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EssenceNodes
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.EssenceCollection.Data.EssenceNodes.EssenceNode> EssenceNodeSpawned;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.EssenceCollection.Data.EssenceNodes.EssenceNode> EssenceNodeDespawned;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Master.EventExposer <_masterEventExposer>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Master.SceneLookupTableAccess <_sceneLookupTableAccess>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.MasterDataConnector <_masterDataConnector>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Visuals.EssenceVisualsParent <_essenceVisualsParent>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Assets.IAssetCache <_assetCache>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.Miscellaneous.AudioPlayer <_audioPlayer>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<Game.EssenceCollection.Data.EssenceNodes.EssenceNode, float> _essencesOnDeck;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<Game.EssenceCollection.Data.EssenceNodes.EssenceNode, float> _essencesWithBeginTimes;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IEnumerable<Game.EssenceCollection.Data.EssenceNodes.EssenceNode> CurrentEssences { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.SceneLookupTableAccess _sceneLookupTableAccess { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector _masterDataConnector { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Visuals.EssenceVisualsParent _essenceVisualsParent { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Assets.IAssetCache _assetCache { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Miscellaneous.AudioPlayer _audioPlayer { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IEnumerable<Game.EssenceCollection.Data.EssenceNodes.EssenceNode> get_CurrentEssences()
        {
            if(this._essencesWithBeginTimes != null)
            {
                    return this._essencesWithBeginTimes.Keys;
            }
            
            return this._essencesWithBeginTimes.Keys;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_EssenceNodeSpawned(System.Action<Game.EssenceCollection.Data.EssenceNodes.EssenceNode> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.EssenceNodeSpawned, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EssenceNodeSpawned != 1152921525334502464);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_EssenceNodeSpawned(System.Action<Game.EssenceCollection.Data.EssenceNodes.EssenceNode> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.EssenceNodeSpawned, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EssenceNodeSpawned != 1152921525334639040);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_EssenceNodeDespawned(System.Action<Game.EssenceCollection.Data.EssenceNodes.EssenceNode> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.EssenceNodeDespawned, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EssenceNodeDespawned != 1152921525334775624);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_EssenceNodeDespawned(System.Action<Game.EssenceCollection.Data.EssenceNodes.EssenceNode> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.EssenceNodeDespawned, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EssenceNodeDespawned != 1152921525334912200);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer get__masterEventExposer()
        {
            return (Master.EventExposer)this.<_masterEventExposer>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.SceneLookupTableAccess get__sceneLookupTableAccess()
        {
            return (Master.SceneLookupTableAccess)this.<_sceneLookupTableAccess>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector get__masterDataConnector()
        {
            return (Game.EssenceCollection.Data.MasterDataConnector)this.<_masterDataConnector>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Visuals.EssenceVisualsParent get__essenceVisualsParent()
        {
            return (Game.EssenceCollection.Visuals.EssenceVisualsParent)this.<_essenceVisualsParent>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set__essenceVisualsParent(Game.EssenceCollection.Visuals.EssenceVisualsParent value)
        {
            this.<_essenceVisualsParent>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Assets.IAssetCache get__assetCache()
        {
            return (Systems.AssetManagement.Assets.IAssetCache)this.<_assetCache>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set__assetCache(Systems.AssetManagement.Assets.IAssetCache value)
        {
            this.<_assetCache>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Miscellaneous.AudioPlayer get__audioPlayer()
        {
            return (Game.EssenceCollection.Actions.Miscellaneous.AudioPlayer)this.<_audioPlayer>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EssenceNodes(Master.EventExposer masterEventExposer, Master.SceneLookupTableAccess sceneLookupTableAccess, Game.EssenceCollection.Data.MasterDataConnector masterDataConnector, Utilities.AsyncInterfaceAccess<Systems.AssetManagement.Assets.IAssetCache> assetCacheAccess, Game.EssenceCollection.Actions.Miscellaneous.AudioPlayer audioPlayer)
        {
            this._essencesOnDeck = new System.Collections.Generic.Dictionary<Game.EssenceCollection.Data.EssenceNodes.EssenceNode, System.Single>();
            this._essencesWithBeginTimes = new System.Collections.Generic.Dictionary<Game.EssenceCollection.Data.EssenceNodes.EssenceNode, System.Single>();
            val_3 = new System.Object();
            this.<_masterEventExposer>k__BackingField = masterEventExposer;
            this.<_sceneLookupTableAccess>k__BackingField = sceneLookupTableAccess;
            this.<_masterDataConnector>k__BackingField = val_3;
            this.<_audioPlayer>k__BackingField = audioPlayer;
            assetCacheAccess.GetInterfaceAsync(callback:  new System.Action<Systems.AssetManagement.Assets.IAssetCache>(object:  this, method:  System.Void Game.EssenceCollection.Data.EssenceNodes.EssenceNodes::ReturnAssetCacheCallback(Systems.AssetManagement.Assets.IAssetCache assetCache)));
            this.<_sceneLookupTableAccess>k__BackingField.GetCameraSceneLookupTableAsync(returnCameraSceneLookupTableCallback:  new SceneLookupTableAccess.ReturnCameraSceneLookupTable(object:  this, method:  System.Void Game.EssenceCollection.Data.EssenceNodes.EssenceNodes::ReturnCameraSceneLookupTableCallback(CameraSceneLookupTable cameraScenelookuptable)));
            this.<_masterEventExposer>k__BackingField.add_EssenceNodeSelected(value:  new System.Action<TrackerSessionPackage, System.Collections.Generic.List<Game.Server.EssenceNodeEntry>>(object:  this, method:  System.Void Game.EssenceCollection.Data.EssenceNodes.EssenceNodes::MakeEssencesForDetectedObjects(Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder.TrackerSessionPackage trackerSessionPackage, System.Collections.Generic.List<Game.Server.EssenceNodeEntry> nodes)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ReturnAssetCacheCallback(Systems.AssetManagement.Assets.IAssetCache assetCache)
        {
            this.<_assetCache>k__BackingField = assetCache;
            this.HookupAssetManagementDomain();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ReturnCameraSceneLookupTableCallback(CameraSceneLookupTable cameraScenelookuptable)
        {
            this.<_essenceVisualsParent>k__BackingField = cameraScenelookuptable.EssenceVisualsParent;
            this.HookupAudioPlayer();
            this.HookupAssetManagementDomain();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HookupAudioPlayer()
        {
            if((this.<_essenceVisualsParent>k__BackingField) == 0)
            {
                    return;
            }
            
            this = this.<_audioPlayer>k__BackingField;
            this.<_essenceVisualsParent>k__BackingField.<_audioPlayer>k__BackingField = this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HookupAssetManagementDomain()
        {
            if((this.<_assetCache>k__BackingField) == null)
            {
                    return;
            }
            
            if((this.<_essenceVisualsParent>k__BackingField) == 0)
            {
                    return;
            }
            
            this = this.<_assetCache>k__BackingField;
            this.<_essenceVisualsParent>k__BackingField.<_assetCache>k__BackingField = this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MakeEssencesForDetectedObjects(Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder.TrackerSessionPackage trackerSessionPackage, System.Collections.Generic.List<Game.Server.EssenceNodeEntry> nodes)
        {
            var val_6;
            System.Predicate<T> val_7;
            if((UnityEngine.Object.op_Implicit(exists:  this.<_essenceVisualsParent>k__BackingField)) == false)
            {
                    return;
            }
            
            if(trackerSessionPackage.cameraInfoFrames.Length == 0)
            {
                    return;
            }
            
            val_6 = 0;
            goto label_6;
            label_14:
            SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection val_6 = trackerSessionPackage.detectedObjects[0];
            .category = val_6;
            System.Predicate<Game.Server.EssenceNodeEntry> val_3 = null;
            val_7 = val_3;
            val_3 = new System.Predicate<Game.Server.EssenceNodeEntry>(object:  new EssenceNodes.<>c__DisplayClass35_0(), method:  System.Boolean EssenceNodes.<>c__DisplayClass35_0::<MakeEssencesForDetectedObjects>b__0(Game.Server.EssenceNodeEntry x));
            Game.Server.EssenceNodeEntry val_4 = nodes.Find(match:  val_3);
            if(val_4 != null)
            {
                    val_7 = trackerSessionPackage.cameraInfoFrames;
                this.MakeEssenceForDetectedObject(cameraInfoFrame:  new CameraInfoFrame() {cameraPosition = new UnityEngine.Vector3(), cameraRotation = new UnityEngine.Quaternion(), upperLeftProjectedPoint = new UnityEngine.Vector3(), upperRightProjectedPoint = new UnityEngine.Vector3(), lowerLeftProjectedPoint = new UnityEngine.Vector3(), lowerRightProjectedPoint = new UnityEngine.Vector3()}, detectedObject:  new SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection() {objectType = val_6, minX = trackerSessionPackage.detectedObjects[0], minY = trackerSessionPackage.detectedObjects[0], maxX = trackerSessionPackage.detectedObjects[0], maxY = trackerSessionPackage.detectedObjects[0], conf = trackerSessionPackage.detectedObjects[0]}, entry:  val_4);
            }
            
            val_6 = 1;
            label_6:
            if(val_6 < trackerSessionPackage.detectedObjects.Length)
            {
                goto label_14;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MakeEssenceForDetectedObject(Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder.CameraInfoFrame cameraInfoFrame, SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection detectedObject, Game.Server.EssenceNodeEntry entry)
        {
            string val_12;
            EssenceNodes.<>c__DisplayClass36_0 val_1 = new EssenceNodes.<>c__DisplayClass36_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            if(val_1 != null)
            {
                    mem[1152921525337253512] = detectedObject.maxX;
                .detectedObject = detectedObject.objectType;
            }
            else
            {
                    mem[120] = detectedObject.maxX;
                mem[104] = detectedObject.objectType;
            }
            
            .entry = entry;
            if((UnityEngine.Object.op_Implicit(exists:  this.<_essenceVisualsParent>k__BackingField)) == false)
            {
                    return;
            }
            
            ENTRY val_3 = this.<_masterDataConnector>k__BackingField.GetEssenceTypesDataForType(essenceType:  (EssenceNodes.<>c__DisplayClass36_0)[1152921525337253392].entry.type);
            if((System.String.IsNullOrWhiteSpace(value:  val_3.NodeType.Prefab)) != false)
            {
                    val_12 = (EssenceNodes.<>c__DisplayClass36_0)[1152921525337253392].entry.type;
            }
            else
            {
                    val_12 = val_3.NodeType.Prefab;
            }
            
            this.<_essenceVisualsParent>k__BackingField.ObtainAvailableEssence(type:  val_12, essenceVisualCallback:  new System.Action<Game.EssenceCollection.Visuals.EssenceVisual>(object:  val_1, method:  System.Void EssenceNodes.<>c__DisplayClass36_0::<MakeEssenceForDetectedObject>b__0(Game.EssenceCollection.Visuals.EssenceVisual essenceVisual)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void InstantiateEssenceVisual(Game.EssenceCollection.Visuals.EssenceVisual essenceVisual, Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder.CameraInfoFrame cameraInfoFrame, SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection detectedObject, Game.Server.EssenceNodeEntry entry)
        {
            essenceVisual._nodeVisuals.gameObject.SetActive(value:  false);
            float val_21 = detectedObject.minX;
            float val_22 = detectedObject.minY;
            val_21 = val_21 + detectedObject.maxX;
            val_22 = val_22 + detectedObject.maxY;
            val_21 = val_21 * 0.5f;
            val_22 = val_22 * 0.5f;
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  val_21, y:  val_22);
            UnityEngine.Vector3 val_3 = Game.EssenceCollection.EssenceUtilities.ProjectPointBetweenCorners(cameraInfoFrame:  new CameraInfoFrame() {cameraPosition = new UnityEngine.Vector3(), cameraRotation = new UnityEngine.Quaternion(), upperLeftProjectedPoint = new UnityEngine.Vector3(), upperRightProjectedPoint = new UnityEngine.Vector3(), lowerLeftProjectedPoint = new UnityEngine.Vector3(), lowerRightProjectedPoint = new UnityEngine.Vector3()}, point:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            DampenYOfDetectedObject(objectPosition: ref  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, cameraPosition:  new UnityEngine.Vector3() {x = cameraInfoFrame.cameraPosition.x, y = cameraInfoFrame.cameraPosition.y, z = cameraInfoFrame.cameraPosition.z});
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  detectedObject.minX, y:  detectedObject.minY);
            UnityEngine.Vector3 val_5 = Game.EssenceCollection.EssenceUtilities.ProjectPointBetweenCorners(cameraInfoFrame:  new CameraInfoFrame() {cameraPosition = new UnityEngine.Vector3(), cameraRotation = new UnityEngine.Quaternion(), upperLeftProjectedPoint = new UnityEngine.Vector3(), upperRightProjectedPoint = new UnityEngine.Vector3(), lowerLeftProjectedPoint = new UnityEngine.Vector3(), lowerRightProjectedPoint = new UnityEngine.Vector3()}, point:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  detectedObject.minX, y:  detectedObject.maxY);
            UnityEngine.Vector3 val_7 = Game.EssenceCollection.EssenceUtilities.ProjectPointBetweenCorners(cameraInfoFrame:  new CameraInfoFrame() {cameraPosition = new UnityEngine.Vector3(), cameraRotation = new UnityEngine.Quaternion(), upperLeftProjectedPoint = new UnityEngine.Vector3(), upperRightProjectedPoint = new UnityEngine.Vector3(), lowerLeftProjectedPoint = new UnityEngine.Vector3(), lowerRightProjectedPoint = new UnityEngine.Vector3()}, point:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
            UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  detectedObject.maxX, y:  detectedObject.maxY);
            UnityEngine.Vector3 val_9 = Game.EssenceCollection.EssenceUtilities.ProjectPointBetweenCorners(cameraInfoFrame:  new CameraInfoFrame() {cameraPosition = new UnityEngine.Vector3(), cameraRotation = new UnityEngine.Quaternion(), upperLeftProjectedPoint = new UnityEngine.Vector3(), upperRightProjectedPoint = new UnityEngine.Vector3(), lowerLeftProjectedPoint = new UnityEngine.Vector3(), lowerRightProjectedPoint = new UnityEngine.Vector3()}, point:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            float val_14 = UnityEngine.Mathf.Min(a:  UnityEngine.Mathf.Max(a:  0.01f, b:  val_10.x), b:  UnityEngine.Mathf.Max(a:  0.01f, b:  val_12.x));
            essenceVisual.gameObject.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            essenceVisual.gameObject.transform.rotation = new UnityEngine.Quaternion() {x = cameraInfoFrame.cameraRotation.x, y = cameraInfoFrame.cameraRotation.y, z = cameraInfoFrame.cameraRotation.z, w = cameraInfoFrame.cameraRotation.w};
            essenceVisual.gameObject.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.SpawnEssenceNode(essenceVisual:  essenceVisual, entry:  entry);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DampenYOfDetectedObject(ref UnityEngine.Vector3 objectPosition, UnityEngine.Vector3 cameraPosition)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = objectPosition.x, y = objectPosition.y, z = objectPosition.z}, b:  new UnityEngine.Vector3() {x = cameraPosition.x, y = cameraPosition.y, z = cameraPosition.z});
            float val_2 = UnityEngine.Mathf.Lerp(a:  cameraPosition.y, b:  objectPosition.y, t:  0.33f);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = cameraPosition.x, y = cameraPosition.y, z = cameraPosition.z});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  val_1.x);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = cameraPosition.x, y = cameraPosition.y, z = cameraPosition.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            objectPosition.x = val_5.x;
            objectPosition.y = val_5.y;
            objectPosition.z = val_5.z;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SpawnEssenceNode(Game.EssenceCollection.Visuals.EssenceVisual essenceVisual, Game.Server.EssenceNodeEntry entry)
        {
            ENTRY val_1 = this.<_masterDataConnector>k__BackingField.GetEssenceTypesDataForType(essenceType:  entry.type);
            if(val_1 != null)
            {
                    Game.EssenceCollection.Data.EssenceNodes.EssenceNode val_2 = new Game.EssenceCollection.Data.EssenceNodes.EssenceNode(essenceVisual:  essenceVisual, essenceTypesEntry:  val_1, id:  entry.id, type:  entry.type, moteIds:  entry.motes);
                this._essencesOnDeck.Add(key:  val_2, value:  UnityEngine.Time.time);
                this.<_audioPlayer>k__BackingField.TriggerEssenceNodeSpawned(essenceNode:  val_2);
                if(this.EssenceNodeSpawned == null)
            {
                    return;
            }
            
                this.EssenceNodeSpawned.Invoke(obj:  val_2);
                return;
            }
            
            ConsoleLogger.LogError(className:  "EssenceNodes", functionName:  "SpawnEssenceNode", logString:  "Cannot find entry in ESSENCE_TYPES_DATA for essence type " + entry.type);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RemoveExpiredEssences()
        {
            var val_5;
            var val_17;
            var val_18;
            val_17 = this;
            System.Collections.Generic.List<Game.EssenceCollection.Data.EssenceNodes.EssenceNode> val_1 = new System.Collections.Generic.List<Game.EssenceCollection.Data.EssenceNodes.EssenceNode>();
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = this._essencesWithBeginTimes.Keys.GetEnumerator();
            label_10:
            if(((-743688384) & 1) == 0)
            {
                goto label_3;
            }
            
            GameUI.EmailUIDataHandler val_6 = val_5.emailUIDataHandler;
            double val_17 = (double)this._essencesWithBeginTimes.Item[val_6];
            val_17 = val_6._masterDomain.NodeType.NodeLifetime + val_17;
            if(val_17 > (double)UnityEngine.Time.time)
            {
                goto label_10;
            }
            
            val_1.Add(item:  val_6);
            goto label_10;
            label_3:
            long val_11 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525337995072});
            val_18 = 0;
            List.Enumerator<T> val_13 = val_1.GetEnumerator();
            label_23:
            if(((-743688408) & 1) == 0)
            {
                goto label_22;
            }
            
            this.DespawnEssenceNode(essenceNode:  0.emailUIDataHandler);
            goto label_23;
            label_22:
            long val_15 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525337995048});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DespawnEssenceNode(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.<_essenceVisualsParent>k__BackingField)) == false)
            {
                    return;
            }
            
            bool val_2 = this._essencesWithBeginTimes.Remove(key:  essenceNode);
            this.<_essenceVisualsParent>k__BackingField.ReturnEssence(essenceVisual:  essenceNode.<_essenceVisual>k__BackingField);
            if(this.EssenceNodeDespawned != null)
            {
                    this.EssenceNodeDespawned.Invoke(obj:  essenceNode);
            }
            
            this.<_audioPlayer>k__BackingField.TriggerEssenceNodeDespawned(essenceNode:  essenceNode);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessOnDeckEssences()
        {
            var val_5;
            var val_18;
            var val_19;
            val_18 = this;
            System.Collections.Generic.List<Game.EssenceCollection.Data.EssenceNodes.EssenceNode> val_1 = new System.Collections.Generic.List<Game.EssenceCollection.Data.EssenceNodes.EssenceNode>();
            val_19 = this._essencesOnDeck.Keys;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = val_19.GetEnumerator();
            label_9:
            if(((-743328208) & 1) == 0)
            {
                goto label_3;
            }
            
            GameUI.EmailUIDataHandler val_6 = val_5.emailUIDataHandler;
            if((this._essencesOnDeck.Item[val_6] + (this.<_masterDataConnector>k__BackingField.Detect_ARObjectToEssenceDelay)) > UnityEngine.Time.time)
            {
                goto label_9;
            }
            
            val_1.Add(item:  val_6);
            this._essencesWithBeginTimes.Add(key:  val_6, value:  UnityEngine.Time.time);
            goto label_9;
            label_3:
            List.Enumerator<T> val_13 = val_1.GetEnumerator();
            label_23:
            if(((-743328232) & 1) == 0)
            {
                goto label_21;
            }
            
            bool val_15 = this._essencesOnDeck.Remove(key:  0.emailUIDataHandler);
            goto label_23;
            label_21:
            long val_16 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525338355224});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this.ProcessOnDeckEssences();
            this.RemoveExpiredEssences();
        }
    
    }

}
