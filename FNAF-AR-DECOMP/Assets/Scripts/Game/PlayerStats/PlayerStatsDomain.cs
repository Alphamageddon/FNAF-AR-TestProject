using UnityEngine;

namespace Game.PlayerStats
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayerStatsDomain : AsyncInterfaceAccess<Game.PlayerStats.IPlayerStatsDomain>, IPlayerStatsDomain
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _eventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.ServerDomain _serverDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.PlayerStats.PlayerStatsContainer <PlayerStats>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.PlayerStats.PlayerStatsContainer PlayerStats { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override bool IsReady { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Game.PlayerStats.IPlayerStatsDomain GetPublicInterface { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.PlayerStats.PlayerStatsContainer get_PlayerStats()
        {
            return (Game.PlayerStats.PlayerStatsContainer)this.<PlayerStats>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override bool get_IsReady()
        {
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Game.PlayerStats.IPlayerStatsDomain get_GetPublicInterface()
        {
            return (Game.PlayerStats.IPlayerStatsDomain)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayerStatsDomain(Master.EventExposer exposer, Game.ItemDefinition.Container.ItemDefinitions itemDefinitions, Game.Server.ServerDomain serverDomain)
        {
            this._eventExposer = exposer;
            this._serverDomain = serverDomain;
            ._data = Game.PlayerStats.Data.PlayerStatsData.CreateEmpty();
            ._itemDefinitions = itemDefinitions;
            this.<PlayerStats>k__BackingField = new Game.PlayerStats.PlayerStatsContainer();
            this.SetupCallbacks();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetupCallbacks()
        {
            System.Action val_5;
            this._eventExposer.add_PlayerStatsUpdated(value:  new System.Action<Game.PlayerStats.Data.PlayerStatsData>(object:  this.<PlayerStats>k__BackingField, method:  public System.Void Game.PlayerStats.PlayerStatsContainer::UpdatePlayerStatsData(Game.PlayerStats.Data.PlayerStatsData data)));
            val_5 = System.Delegate.Combine(a:  this.<PlayerStats>k__BackingField.RemnantLevelUp, b:  new System.Action(object:  this, method:  public System.Void Game.PlayerStats.PlayerStatsDomain::SendLevelUpMessage()));
            if((this.<PlayerStats>k__BackingField) == null)
            {
                goto label_3;
            }
            
            if(val_5 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_5 == null)
            {
                goto label_7;
            }
            
            label_4:
            if(null != null)
            {
                    val_5 = 0;
            }
            
            label_7:
            this.<PlayerStats>k__BackingField.RemnantLevelUp = val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendLevelUpMessage()
        {
            this._serverDomain.remnantLevelUpAlertRequester.SendMessage();
        }
    
    }

}
