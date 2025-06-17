using UnityEngine;

namespace Game.EssenceCollection.Visuals
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EssenceVisualsParent : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.LineRenderer LineRendererPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.MeshFilter CubePrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Assets.IAssetCache <_assetCache>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Miscellaneous.AudioPlayer <_audioPlayer>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, System.Collections.Generic.Queue<Game.EssenceCollection.Visuals.EssenceVisual>> _essencesByType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Queue<UnityEngine.GameObject> _moteParents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<Game.EssenceCollection.Visuals.MoteVisual, System.Collections.Generic.Queue<Game.EssenceCollection.Visuals.MoteVisual>> _motesByType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Queue<UnityEngine.GameObject> _threatPillParents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<Game.EssenceCollection.Visuals.ThreatPillVisual, System.Collections.Generic.Queue<Game.EssenceCollection.Visuals.ThreatPillVisual>> _threatPillsByType;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Assets.IAssetCache _assetCache { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Miscellaneous.AudioPlayer _audioPlayer { get; set; }
        
        // Methods
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
        private void set__audioPlayer(Game.EssenceCollection.Actions.Miscellaneous.AudioPlayer value)
        {
            this.<_audioPlayer>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GiveAssetManagementDomain(Systems.AssetManagement.Assets.IAssetCache assetCache)
        {
            this.<_assetCache>k__BackingField = assetCache;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GiveAudioPlayer(Game.EssenceCollection.Actions.Miscellaneous.AudioPlayer audioPlayer)
        {
            this.<_audioPlayer>k__BackingField = audioPlayer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ObtainAvailableEssence(string type, System.Action<Game.EssenceCollection.Visuals.EssenceVisual> essenceVisualCallback)
        {
            if(((this._essencesByType.ContainsKey(key:  type)) == false) || (this._essencesByType.Item[type].Count < 1))
            {
                goto label_5;
            }
            
            Game.EssenceCollection.Visuals.EssenceVisual val_5 = this._essencesByType.Item[type].Dequeue();
            if(val_5 == null)
            {
                goto label_8;
            }
            
            val_5._inUse = true;
            goto label_9;
            label_5:
            this.CreateNewEssence(type:  type, essenceVisualCallback:  essenceVisualCallback);
            return;
            label_8:
            mem[64] = 1;
            label_9:
            val_5.gameObject.SetActive(value:  true);
            if(essenceVisualCallback == null)
            {
                    return;
            }
            
            essenceVisualCallback.Invoke(obj:  val_5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateNewEssence(string type, System.Action<Game.EssenceCollection.Visuals.EssenceVisual> essenceVisualCallback)
        {
            string val_6;
            EssenceVisualsParent.<>c__DisplayClass18_0 val_1 = new EssenceVisualsParent.<>c__DisplayClass18_0();
            if(val_1 != null)
            {
                    val_6 = val_1;
                .type = type;
                mem[1152921525320659136] = this;
            }
            else
            {
                    mem[16] = this;
                val_6 = 24;
                mem[24] = type;
            }
            
            .essenceVisualCallback = essenceVisualCallback;
            if((this.<_assetCache>k__BackingField) != null)
            {
                    string val_2 = val_6 + "Essence";
                System.Action<UnityEngine.GameObject> val_3 = new System.Action<UnityEngine.GameObject>(object:  val_1, method:  System.Void EssenceVisualsParent.<>c__DisplayClass18_0::<CreateNewEssence>b__0(UnityEngine.GameObject essenceVisualPrefab));
                System.Action val_4 = new System.Action(object:  val_1, method:  System.Void EssenceVisualsParent.<>c__DisplayClass18_0::<CreateNewEssence>b__1());
                var val_6 = 0;
                val_6 = val_6 + 1;
            }
            else
            {
                    ConsoleLogger.LogError(className:  "EssenceVisualsParent", functionName:  "CreateNewEssence", logString:  "AssetManagementDomain not available yet");
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EssenceLoadSuccess(string type, UnityEngine.GameObject essenceVisualPrefab, System.Action<Game.EssenceCollection.Visuals.EssenceVisual> essenceVisualCallback)
        {
            Game.EssenceCollection.Visuals.EssenceVisual val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  essenceVisualPrefab, parent:  this.transform).GetComponent<Game.EssenceCollection.Visuals.EssenceVisual>();
            if(val_3 != null)
            {
                    val_3.<EssenceType>k__BackingField = type;
                val_3._inUse = true;
            }
            else
            {
                    mem[56] = type;
                mem[64] = 1;
            }
            
            val_3.gameObject.SetActive(value:  true);
            this.<_audioPlayer>k__BackingField.SetEmitterAudioMode(emitter:  val_3._akAudioEmitter);
            if(essenceVisualCallback == null)
            {
                    return;
            }
            
            essenceVisualCallback.Invoke(obj:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EssenceLoadFailure(string type)
        {
            ConsoleLogger.LogError(className:  "EssenceVisualsParent", functionName:  "EssenceLoadFailure", logString:  "Failed to load essence of type:"("Failed to load essence of type:") + type);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ReturnEssence(Game.EssenceCollection.Visuals.EssenceVisual essenceVisual)
        {
            if(essenceVisual != null)
            {
                    essenceVisual._inUse = false;
            }
            else
            {
                    mem[64] = 0;
            }
            
            essenceVisual.gameObject.SetActive(value:  false);
            if((this._essencesByType.ContainsKey(key:  essenceVisual.<EssenceType>k__BackingField)) != true)
            {
                    this._essencesByType.Add(key:  essenceVisual.<EssenceType>k__BackingField, value:  new System.Collections.Generic.Queue<Game.EssenceCollection.Visuals.EssenceVisual>());
            }
            
            this._essencesByType.Item[essenceVisual.<EssenceType>k__BackingField].Enqueue(item:  essenceVisual);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject ObtainAvailableMoteParent()
        {
            if(this._moteParents.Count < 1)
            {
                    return this.CreateNewMoteParent();
            }
            
            UnityEngine.GameObject val_2 = this._moteParents.Dequeue();
            val_2.SetActive(value:  true);
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject CreateNewMoteParent()
        {
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject();
            val_1.transform.parent = this.transform;
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ReturnMoteParent(UnityEngine.GameObject moteParent)
        {
            moteParent.SetActive(value:  false);
            this._moteParents.Enqueue(item:  moteParent);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.EssenceCollection.Visuals.MoteVisual ObtainAvailableMoteOfType(Game.EssenceCollection.Visuals.MoteVisual motePrefab)
        {
            System.Collections.Generic.Dictionary<Game.EssenceCollection.Visuals.MoteVisual, System.Collections.Generic.Queue<Game.EssenceCollection.Visuals.MoteVisual>> val_7 = this._motesByType;
            if((val_7.ContainsKey(key:  motePrefab)) == false)
            {
                    return this.CreateNewMote(motePrefab:  motePrefab);
            }
            
            val_7 = this._motesByType.Item[motePrefab];
            if(val_7.Count < 1)
            {
                    return this.CreateNewMote(motePrefab:  motePrefab);
            }
            
            Game.EssenceCollection.Visuals.MoteVisual val_5 = this._motesByType.Item[motePrefab].Dequeue();
            val_5.gameObject.SetActive(value:  true);
            val_5.Sanitize();
            return val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Visuals.MoteVisual CreateNewMote(Game.EssenceCollection.Visuals.MoteVisual motePrefab)
        {
            val_2.<prefabCreatedFrom>k__BackingField = motePrefab;
            return (Game.EssenceCollection.Visuals.MoteVisual)UnityEngine.Object.Instantiate<Game.EssenceCollection.Visuals.MoteVisual>(original:  motePrefab, parent:  this.transform);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ReturnMote(Game.EssenceCollection.Visuals.MoteVisual mote)
        {
            mote.gameObject.SetActive(value:  false);
            if((this._motesByType.ContainsKey(key:  mote.<prefabCreatedFrom>k__BackingField)) != true)
            {
                    this._motesByType.Add(key:  mote.<prefabCreatedFrom>k__BackingField, value:  new System.Collections.Generic.Queue<Game.EssenceCollection.Visuals.MoteVisual>());
            }
            
            this._motesByType.Item[mote.<prefabCreatedFrom>k__BackingField].Enqueue(item:  mote);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject ObtainAvailableThreatPillParent()
        {
            if(this._threatPillParents.Count < 1)
            {
                    return this.CreateNewThreatPillParent();
            }
            
            UnityEngine.GameObject val_2 = this._threatPillParents.Dequeue();
            val_2.SetActive(value:  true);
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject CreateNewThreatPillParent()
        {
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject();
            val_1.transform.parent = this.transform;
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ReturnThreatPillParent(UnityEngine.GameObject threatPillParent)
        {
            threatPillParent.SetActive(value:  false);
            this._threatPillParents.Enqueue(item:  threatPillParent);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.EssenceCollection.Visuals.ThreatPillVisual ObtainAvailableThreatPillOfType(Game.EssenceCollection.Visuals.ThreatPillVisual threatPillPrefab)
        {
            System.Collections.Generic.Dictionary<Game.EssenceCollection.Visuals.ThreatPillVisual, System.Collections.Generic.Queue<Game.EssenceCollection.Visuals.ThreatPillVisual>> val_7 = this._threatPillsByType;
            if((val_7.ContainsKey(key:  threatPillPrefab)) == false)
            {
                    return this.CreateNewThreatPill(threatPillPrefab:  threatPillPrefab);
            }
            
            val_7 = this._threatPillsByType.Item[threatPillPrefab];
            if(val_7.Count < 1)
            {
                    return this.CreateNewThreatPill(threatPillPrefab:  threatPillPrefab);
            }
            
            Game.EssenceCollection.Visuals.ThreatPillVisual val_5 = this._threatPillsByType.Item[threatPillPrefab].Dequeue();
            val_5.gameObject.SetActive(value:  true);
            val_5.Sanitize();
            return val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Visuals.ThreatPillVisual CreateNewThreatPill(Game.EssenceCollection.Visuals.ThreatPillVisual threatPillPrefab)
        {
            val_2.<prefabCreatedFrom>k__BackingField = threatPillPrefab;
            return (Game.EssenceCollection.Visuals.ThreatPillVisual)UnityEngine.Object.Instantiate<Game.EssenceCollection.Visuals.ThreatPillVisual>(original:  threatPillPrefab, parent:  this.transform);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ReturnThreatPill(Game.EssenceCollection.Visuals.ThreatPillVisual threatPill)
        {
            threatPill.gameObject.SetActive(value:  false);
            if((this._threatPillsByType.ContainsKey(key:  threatPill.<prefabCreatedFrom>k__BackingField)) != true)
            {
                    this._threatPillsByType.Add(key:  threatPill.<prefabCreatedFrom>k__BackingField, value:  new System.Collections.Generic.Queue<Game.EssenceCollection.Visuals.ThreatPillVisual>());
            }
            
            this._threatPillsByType.Item[threatPill.<prefabCreatedFrom>k__BackingField].Enqueue(item:  threatPill);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EssenceVisualsParent()
        {
            this._essencesByType = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Queue<Game.EssenceCollection.Visuals.EssenceVisual>>();
            this._moteParents = new System.Collections.Generic.Queue<UnityEngine.GameObject>();
            this._motesByType = new System.Collections.Generic.Dictionary<Game.EssenceCollection.Visuals.MoteVisual, System.Collections.Generic.Queue<Game.EssenceCollection.Visuals.MoteVisual>>();
            this._threatPillParents = new System.Collections.Generic.Queue<UnityEngine.GameObject>();
            this._threatPillsByType = new System.Collections.Generic.Dictionary<Game.EssenceCollection.Visuals.ThreatPillVisual, System.Collections.Generic.Queue<Game.EssenceCollection.Visuals.ThreatPillVisual>>();
        }
    
    }

}
