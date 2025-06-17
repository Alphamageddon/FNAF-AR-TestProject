using UnityEngine;

namespace Game.EssenceCollection.Actions.EssenceNodes
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GeigerCounter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.MasterDataConnector <_masterDataConnector>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.EssenceNodes.EssenceNodes <_essenceNodes>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.Particles.AllMotes <_allMotes>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly TheGame.GameDisplayChanger <_gameDisplay>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.EssenceNodes.EssenceAngleCalculator <_essenceAngleCalculator>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.HashSet<Game.EssenceCollection.Data.EssenceNodes.EssenceNode> _currentEssences;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.HashSet<Game.EssenceCollection.Data.EssenceNodes.EssenceNode> _oldEssences;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<Game.EssenceCollection.Data.EssenceNodes.EssenceNode, float> _geigerCounterAngleTimestamps;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector _masterDataConnector { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.EssenceNodes.EssenceNodes _essenceNodes { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Particles.AllMotes _allMotes { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.GameDisplayChanger _gameDisplay { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.EssenceNodes.EssenceAngleCalculator _essenceAngleCalculator { get; }
        
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
        private Game.EssenceCollection.Data.Particles.AllMotes get__allMotes()
        {
            return (Game.EssenceCollection.Data.Particles.AllMotes)this.<_allMotes>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.GameDisplayChanger get__gameDisplay()
        {
            return (TheGame.GameDisplayChanger)this.<_gameDisplay>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.EssenceNodes.EssenceAngleCalculator get__essenceAngleCalculator()
        {
            return (Game.EssenceCollection.Actions.EssenceNodes.EssenceAngleCalculator)this.<_essenceAngleCalculator>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GeigerCounter(Game.EssenceCollection.Data.MasterDataConnector masterDataConnector, Game.EssenceCollection.Data.EssenceNodes.EssenceNodes essenceNodes, Game.EssenceCollection.Data.Particles.AllMotes allMotes, TheGame.GameDisplayChanger gameDisplay, Game.EssenceCollection.Actions.EssenceNodes.EssenceAngleCalculator essenceAngleCalculator)
        {
            this._currentEssences = new System.Collections.Generic.HashSet<Game.EssenceCollection.Data.EssenceNodes.EssenceNode>();
            this._oldEssences = new System.Collections.Generic.HashSet<Game.EssenceCollection.Data.EssenceNodes.EssenceNode>();
            this._geigerCounterAngleTimestamps = new System.Collections.Generic.Dictionary<Game.EssenceCollection.Data.EssenceNodes.EssenceNode, System.Single>();
            val_4 = new System.Object();
            this.<_masterDataConnector>k__BackingField = masterDataConnector;
            this.<_essenceNodes>k__BackingField = val_4;
            this.<_allMotes>k__BackingField = allMotes;
            this.<_gameDisplay>k__BackingField = gameDisplay;
            this.<_essenceAngleCalculator>k__BackingField = essenceAngleCalculator;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessNewEssences(System.Collections.Generic.IEnumerable<Game.EssenceCollection.Data.EssenceNodes.EssenceNode> newEssences)
        {
            this.RecordOldEssences();
            this.UpdateEssencesGeigerTicks(currentEssences:  newEssences);
            this.CleanupOldEssences();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RecordOldEssences()
        {
            var val_6 = this;
            this._oldEssences.Clear();
            HashSet.Enumerator<T> val_1 = this._currentEssences.GetEnumerator();
            label_5:
            if(((-696829848) & 1) == 0)
            {
                goto label_3;
            }
            
            bool val_3 = this._oldEssences.Add(item:  0.emailUIDataHandler);
            goto label_5;
            label_3:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525384853608});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CleanupOldEssences()
        {
            var val_7 = this;
            HashSet.Enumerator<T> val_1 = this._oldEssences.GetEnumerator();
            label_5:
            if(((-696676904) & 1) == 0)
            {
                goto label_2;
            }
            
            GameUI.EmailUIDataHandler val_2 = 0.emailUIDataHandler;
            bool val_3 = this._currentEssences.Remove(item:  val_2);
            bool val_4 = this._geigerCounterAngleTimestamps.Remove(key:  val_2);
            goto label_5;
            label_2:
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525385006552});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EnsureCurrentEssence(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            if((this._currentEssences.Contains(item:  essenceNode)) != true)
            {
                    bool val_2 = this._currentEssences.Add(item:  essenceNode);
            }
            
            if((this._geigerCounterAngleTimestamps.ContainsKey(key:  essenceNode)) != false)
            {
                    return;
            }
            
            this._geigerCounterAngleTimestamps.Add(key:  essenceNode, value:  UnityEngine.Time.time);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateEssencesGeigerTicks(System.Collections.Generic.IEnumerable<Game.EssenceCollection.Data.EssenceNodes.EssenceNode> currentEssences)
        {
            var val_19;
            var val_20;
            var val_21;
            var val_24;
            var val_25;
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_19 = 1152921504685174784;
            val_20 = 1152921525358005504;
            val_21 = currentEssences.GetEnumerator();
            label_21:
            var val_22 = 0;
            val_22 = val_22 + 1;
            if(val_21.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_23 = 0;
            val_23 = val_23 + 1;
            T val_6 = val_21.Current;
            if((this.DoMotesExistForEssenceNode(essenceNode:  val_6)) == false)
            {
                goto label_21;
            }
            
            this.EnsureCurrentEssence(essenceNode:  val_6);
            this.ProcessGeigerAngleTick(essenceNode:  val_6);
            if((this._oldEssences.Contains(item:  val_6)) == false)
            {
                goto label_21;
            }
            
            bool val_9 = this._oldEssences.Remove(item:  val_6);
            goto label_21;
            label_11:
            val_24 = 0;
            val_25 = 86;
            if(val_21 == null)
            {
                
            }
            else
            {
                    var val_24 = 0;
                val_24 = val_24 + 1;
                val_21.Dispose();
            }
            
            if( == 86)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_21 = ???;
            val_25 = ???;
            val_19 = ???;
            val_20 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool DoMotesExistForEssenceNode(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            var val_8;
            if(essenceNode.EssenceTypesEntry.NodeType.HasMote != false)
            {
                    if(essenceNode.NumRemainingMotes <= 0)
            {
                    if(essenceNode.NumInitialMotesToSpawn <= 0)
            {
                goto label_7;
            }
            
            }
            
                val_8 = 1;
                return (bool)val_8;
            }
            
            val_8 = 0;
            return (bool)val_8;
            label_7:
            MoteSpawnInfo[] val_6 = this.<_allMotes>k__BackingField.GetAllMotesForEssence(essenceNode:  essenceNode);
            var val_7 = (val_6.Length != 0) ? 1 : 0;
            return (bool)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessGeigerTick(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            this.ProcessGeigerAngleTick(essenceNode:  essenceNode);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessGeigerAngleTick(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            if(((this.GetGeigerTickTimeForAngleToEssence(essenceNode:  essenceNode)) + this._geigerCounterAngleTimestamps.Item[essenceNode]) > UnityEngine.Time.time)
            {
                    return;
            }
            
            if(this.CanDoTicks() != false)
            {
                    if(VibrationSettings.VibrationIsEnabled() != false)
            {
                    MoreMountains.NiceVibrations.MMVibrationManager.Haptic(type:  4, defaultToRegularVibrate:  true);
            }
            
            }
            
            this._geigerCounterAngleTimestamps.set_Item(key:  essenceNode, value:  UnityEngine.Time.time);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float GetGeigerTickTimeForAngleToEssence(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            if((this.<_masterDataConnector>k__BackingField) != null)
            {
                    return UnityEngine.Mathf.Lerp(a:  this.<_masterDataConnector>k__BackingField.GeigerCounter_MinTickInSeconds, b:  this.<_masterDataConnector>k__BackingField.GeigerCounter_MaxTickInSeconds, t:  this.<_essenceAngleCalculator>k__BackingField.GetAngleMagnitudeToEssence(essenceNode:  essenceNode));
            }
            
            this.<_masterDataConnector>k__BackingField = this.<_masterDataConnector>k__BackingField;
            if((this.<_masterDataConnector>k__BackingField) != null)
            {
                    return UnityEngine.Mathf.Lerp(a:  this.<_masterDataConnector>k__BackingField.GeigerCounter_MinTickInSeconds, b:  this.<_masterDataConnector>k__BackingField.GeigerCounter_MaxTickInSeconds, t:  this.<_essenceAngleCalculator>k__BackingField.GetAngleMagnitudeToEssence(essenceNode:  essenceNode));
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool CanDoTicks()
        {
            return (bool)((this.<_gameDisplay>k__BackingField.GetDisplayType()) == 1) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this.ProcessNewEssences(newEssences:  this.<_essenceNodes>k__BackingField.CurrentEssences);
        }
    
    }

}
