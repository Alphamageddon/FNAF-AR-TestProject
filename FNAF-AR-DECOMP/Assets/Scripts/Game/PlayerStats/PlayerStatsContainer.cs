using UnityEngine;

namespace Game.PlayerStats
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayerStatsContainer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.PlayerStats.Data.PlayerStatsData _data;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Container.ItemDefinitions _itemDefinitions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action PlayerStatsUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action RemnantLevelUp;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.PlayerStats.Data.PlayerStatsData Data { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.PlayerStats.Data.PlayerStatsData get_Data()
        {
            return (Game.PlayerStats.Data.PlayerStatsData)this._data;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayerStatsContainer(Game.ItemDefinition.Container.ItemDefinitions itemDefinitions)
        {
            this._data = Game.PlayerStats.Data.PlayerStatsData.CreateEmpty();
            this._itemDefinitions = itemDefinitions;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdatePlayerStatsData(Game.PlayerStats.Data.PlayerStatsData data)
        {
            this._data.TotalRemant = data.TotalRemant;
            this.UpdateDebuffEntry();
            if(this.PlayerStatsUpdated == null)
            {
                    return;
            }
            
            this.PlayerStatsUpdated.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateDebuffEntry()
        {
            if(((this._data.RemnantDebuffInfo != null) && (val_1.ShockWindowIncrease > this._data.RemnantDebuffInfo.ShockWindowIncrease)) && (this.RemnantLevelUp != null))
            {
                    this.RemnantLevelUp.Invoke();
            }
            
            this._data.RemnantDebuffInfo = this._itemDefinitions.GetEntryForRemnant(remnant:  this._data.TotalRemant);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetTotalRemnant()
        {
            if(this._data != null)
            {
                    return (int)this._data.TotalRemant;
            }
            
            return (int)this._data.TotalRemant;
        }
    
    }

}
