using UnityEngine;

namespace Game.EssenceCollection.Data.EssenceNodes
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Cooldowns
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.MasterDataConnector <_masterDataConnector>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _eventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, double> _categoryCooldownTimestamps;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double _globalCooldownTimestamp;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double _threatCooldownTimestamp;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector _masterDataConnector { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector get__masterDataConnector()
        {
            return (Game.EssenceCollection.Data.MasterDataConnector)this.<_masterDataConnector>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Cooldowns(Game.EssenceCollection.Data.MasterDataConnector masterDataConnector, Master.EventExposer eventExposer)
        {
            this._categoryCooldownTimestamps = new System.Collections.Generic.Dictionary<System.String, System.Double>();
            val_2 = new System.Object();
            this.<_masterDataConnector>k__BackingField = masterDataConnector;
            this._eventExposer = val_2;
            val_2.add_PlayerEssenceDataUpdated(value:  new System.Action<Game.Server.PlayerEssenceData>(object:  this, method:  System.Void Game.EssenceCollection.Data.EssenceNodes.Cooldowns::OnPlayerEssenceDataUpdated(Game.Server.PlayerEssenceData data)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsCategoryCooledDown(string category)
        {
            var val_9;
            Game.EssenceCollection.Data.MasterDataConnector val_10;
            var val_11;
            val_9 = this;
            val_10 = this.<_masterDataConnector>k__BackingField;
            if((((this.<_masterDataConnector>k__BackingField.<_configDataEntry>k__BackingField) != null) && ((this.<_masterDataConnector>k__BackingField.<_essenceTypesData>k__BackingField) != null)) && (TheGame.ServerTime.IsInitialized() != false))
            {
                    val_10 = this._categoryCooldownTimestamps;
                if((val_10.ContainsKey(key:  category)) != false)
            {
                    val_10 = TheGame.ServerTime.GetCurrentTime();
                val_9 = this.<_masterDataConnector>k__BackingField.<_configDataEntry>k__BackingField.EssenceCollection.Detect;
                double val_7 = val_9.CategoryCooldown;
                val_7 = this._categoryCooldownTimestamps.Item[category] + val_7;
                var val_8 = (val_7 < 0) ? 1 : 0;
                return (bool)val_11;
            }
            
            }
            
            val_11 = 1;
            return (bool)val_11;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsGlobalCooledDown()
        {
            var val_7;
            var val_8;
            val_7 = this;
            if(((this.<_masterDataConnector>k__BackingField.<_configDataEntry>k__BackingField) != null) && ((this.<_masterDataConnector>k__BackingField.<_essenceTypesData>k__BackingField) != null))
            {
                    if(TheGame.ServerTime.IsInitialized() != false)
            {
                    val_7 = TheGame.ServerTime.GetCurrentTime();
                double val_5 = this.<_masterDataConnector>k__BackingField.<_configDataEntry>k__BackingField.EssenceCollection.Detect.GlobalCooldown;
                val_5 = this._globalCooldownTimestamp + val_5;
                var val_6 = (val_5 < 0) ? 1 : 0;
                return (bool)val_8;
            }
            
            }
            
            val_8 = 1;
            return (bool)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsThreatCooledDown()
        {
            var val_7;
            var val_8;
            val_7 = this;
            if(((this.<_masterDataConnector>k__BackingField.<_configDataEntry>k__BackingField) != null) && ((this.<_masterDataConnector>k__BackingField.<_essenceTypesData>k__BackingField) != null))
            {
                    if(TheGame.ServerTime.IsInitialized() != false)
            {
                    val_7 = TheGame.ServerTime.GetCurrentTime();
                double val_5 = this.<_masterDataConnector>k__BackingField.<_configDataEntry>k__BackingField.EssenceCollection.Phantasm.Cooldown;
                val_5 = this._threatCooldownTimestamp + val_5;
                var val_6 = (val_5 < 0) ? 1 : 0;
                return (bool)val_8;
            }
            
            }
            
            val_8 = 1;
            return (bool)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnPlayerEssenceDataUpdated(Game.Server.PlayerEssenceData data)
        {
            this._categoryCooldownTimestamps = data.lastCategoryTriggers;
            this._globalCooldownTimestamp = data.lastGlobalTrigger;
            this._threatCooldownTimestamp = data.lastThreatTrigger;
        }
    
    }

}
