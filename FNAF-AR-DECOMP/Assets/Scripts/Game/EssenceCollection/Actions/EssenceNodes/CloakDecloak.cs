using UnityEngine;

namespace Game.EssenceCollection.Actions.EssenceNodes
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CloakDecloak
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.MasterDataConnector <_masterDataConnector>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.EssenceNodes.EssenceNodes <_essenceNodes>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.Particles.Motes.MoteSpawner <_moteSpawner>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillSpawner <_threatPillSpawner>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera <_mainCamera>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.Miscellaneous.AudioPlayer <_audioPlayer>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.HashSet<Game.EssenceCollection.Data.EssenceNodes.EssenceNode> _oldEssences;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<Game.EssenceCollection.Data.EssenceNodes.EssenceNode, float> _essencesWithInViewTimestamps;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector _masterDataConnector { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.EssenceNodes.EssenceNodes _essenceNodes { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Particles.Motes.MoteSpawner _moteSpawner { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillSpawner _threatPillSpawner { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera _mainCamera { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Miscellaneous.AudioPlayer _audioPlayer { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector get__masterDataConnector()
        {
            return (Game.EssenceCollection.Data.MasterDataConnector)this.<_masterDataConnector>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.EssenceNodes.EssenceNodes get__essenceNodes()
        {
            return (Game.EssenceCollection.Data.EssenceNodes.EssenceNodes)this.<_essenceNodes>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Particles.Motes.MoteSpawner get__moteSpawner()
        {
            return (Game.EssenceCollection.Actions.Particles.Motes.MoteSpawner)this.<_moteSpawner>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillSpawner get__threatPillSpawner()
        {
            return (Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillSpawner)this.<_threatPillSpawner>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera get__mainCamera()
        {
            return (UnityEngine.Camera)this.<_mainCamera>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set__mainCamera(UnityEngine.Camera value)
        {
            this.<_mainCamera>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Miscellaneous.AudioPlayer get__audioPlayer()
        {
            return (Game.EssenceCollection.Actions.Miscellaneous.AudioPlayer)this.<_audioPlayer>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CloakDecloak(Game.EssenceCollection.Data.MasterDataConnector masterDataConnector, Game.EssenceCollection.Data.EssenceNodes.EssenceNodes essenceNodes, Game.EssenceCollection.Actions.Particles.Motes.MoteSpawner moteSpawner, Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillSpawner threatPillSpawner, Master.SceneLookupTableAccess sceneLookupTableAccess, Game.EssenceCollection.Actions.Miscellaneous.AudioPlayer audioPlayer)
        {
            this._oldEssences = new System.Collections.Generic.HashSet<Game.EssenceCollection.Data.EssenceNodes.EssenceNode>();
            this._essencesWithInViewTimestamps = new System.Collections.Generic.Dictionary<Game.EssenceCollection.Data.EssenceNodes.EssenceNode, System.Single>();
            val_3 = new System.Object();
            this.<_masterDataConnector>k__BackingField = masterDataConnector;
            this.<_essenceNodes>k__BackingField = val_3;
            this.<_moteSpawner>k__BackingField = moteSpawner;
            this.<_threatPillSpawner>k__BackingField = threatPillSpawner;
            this.<_audioPlayer>k__BackingField = audioPlayer;
            sceneLookupTableAccess.GetCameraSceneLookupTableAsync(returnCameraSceneLookupTableCallback:  new SceneLookupTableAccess.ReturnCameraSceneLookupTable(object:  this, method:  System.Void Game.EssenceCollection.Actions.EssenceNodes.CloakDecloak::ReturnCameraSceneLookupTableCallback(CameraSceneLookupTable cameraSceneLookupTable)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ReturnCameraSceneLookupTableCallback(CameraSceneLookupTable cameraSceneLookupTable)
        {
            this.<_mainCamera>k__BackingField = cameraSceneLookupTable.ForegroundCamera;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessEssences()
        {
            this.RecordOldEssences();
            this.UpdateEssenceVisibilityTimes();
            this.CleanupOldEssences();
            this.UpdateEssenceDecloaking();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RecordOldEssences()
        {
            var val_7 = this;
            this._oldEssences.Clear();
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = this._essencesWithInViewTimestamps.Keys.GetEnumerator();
            label_6:
            if(((-704992888) & 1) == 0)
            {
                goto label_4;
            }
            
            bool val_4 = this._oldEssences.Add(item:  0.emailUIDataHandler);
            goto label_6;
            label_4:
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525376690568});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateEssencesThatAreInView()
        {
            this.UpdateEssenceVisibilityTimes();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateEssenceVisibilityTimes()
        {
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_31;
            var val_32;
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_25 = 1152921504685174784;
            val_26 = 1152921525349213152;
            val_27 = 1152921525348596192;
            val_28 = this.<_essenceNodes>k__BackingField.CurrentEssences.GetEnumerator();
            label_26:
            var val_28 = 0;
            val_28 = val_28 + 1;
            if(val_28.MoveNext() == false)
            {
                goto label_12;
            }
            
            var val_29 = 0;
            val_29 = val_29 + 1;
            T val_7 = val_28.Current;
            if((this.EssenceIsInView(essenceNode:  val_7)) == false)
            {
                goto label_18;
            }
            
            if((this._essencesWithInViewTimestamps.ContainsKey(key:  val_7)) != true)
            {
                    this._essencesWithInViewTimestamps.Add(key:  val_7, value:  UnityEngine.Time.time);
            }
            
            if((this._oldEssences.Contains(item:  val_7)) == false)
            {
                goto label_26;
            }
            
            bool val_12 = this._oldEssences.Remove(item:  val_7);
            goto label_26;
            label_18:
            this.CloakEssence(essenceNode:  val_7);
            goto label_26;
            label_12:
            val_31 = 0;
            val_32 = 122;
            if(val_28 == null)
            {
                
            }
            else
            {
                    var val_30 = 0;
                val_30 = val_30 + 1;
                val_28.Dispose();
            }
            
            if( == 122)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_28 = ???;
            val_32 = ???;
            val_25 = ???;
            val_26 = ???;
            val_27 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateEssenceDecloaking()
        {
            var val_9 = this;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = this._essencesWithInViewTimestamps.Keys.GetEnumerator();
            do
            {
                label_7:
                if(((-704550280) & 1) == 0)
            {
                    return;
            }
            
                GameUI.EmailUIDataHandler val_3 = 0.emailUIDataHandler;
                float val_5 = UnityEngine.Time.time;
            }
            while((this._essencesWithInViewTimestamps.Item[val_3] + (this.<_masterDataConnector>k__BackingField.CloakDecloak_DecloakDelay)) >= 0);
            
            this.DecloakEssence(essenceNode:  val_3);
            goto label_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DecloakEssence(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            essenceNode.EssenceVisual.NodeVisuals.gameObject.SetActive(value:  true);
            this.<_moteSpawner>k__BackingField.StartSpawningFor(essenceNode:  essenceNode);
            this.<_threatPillSpawner>k__BackingField.StartSpawningFor(essenceNode:  essenceNode);
            this.<_audioPlayer>k__BackingField.TriggerEssenceNodeDecloaked(essenceNode:  essenceNode);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CloakEssence(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            essenceNode.EssenceVisual.NodeVisuals.gameObject.SetActive(value:  false);
            this.<_moteSpawner>k__BackingField.StopSpawningFor(essenceNode:  essenceNode);
            this.<_threatPillSpawner>k__BackingField.StopSpawningFor(essenceNode:  essenceNode);
            this.<_audioPlayer>k__BackingField.TriggerEssenceNodeCloaked(essenceNode:  essenceNode);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool EssenceIsInView(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.<_mainCamera>k__BackingField)) == false)
            {
                    return false;
            }
            
            Game.EssenceCollection.Visuals.EssenceVisual val_2 = essenceNode.EssenceVisual;
            if(val_2 != null)
            {
                    return val_2.InUse;
            }
            
            return val_2.InUse;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CleanupOldEssences()
        {
            var val_6 = this;
            HashSet.Enumerator<T> val_1 = this._oldEssences.GetEnumerator();
            label_4:
            if(((-703922040) & 1) == 0)
            {
                goto label_2;
            }
            
            bool val_3 = this._essencesWithInViewTimestamps.Remove(key:  0.emailUIDataHandler);
            goto label_4;
            label_2:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525377761416});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this.ProcessEssences();
        }
    
    }

}
