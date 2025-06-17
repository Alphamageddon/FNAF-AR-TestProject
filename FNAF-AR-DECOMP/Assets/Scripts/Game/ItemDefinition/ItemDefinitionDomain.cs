using UnityEngine;

namespace Game.ItemDefinition
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ItemDefinitionDomain : AsyncInterfaceAccess<Game.ItemDefinition.IItemDefinitionDomain>, IItemDefinitionDomain
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.ItemDefinition.Container.ItemDefinitions <ItemDefinitions>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _eventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Data.MasterDataConnector _masterDataConnector;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Container.ItemDefinitions ItemDefinitions { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override bool IsReady { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Game.ItemDefinition.IItemDefinitionDomain GetPublicInterface { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Container.ItemDefinitions get_ItemDefinitions()
        {
            return (Game.ItemDefinition.Container.ItemDefinitions)this.<ItemDefinitions>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override bool get_IsReady()
        {
            Game.ItemDefinition.Data.MasterDataConnector val_2;
            var val_3;
            val_2 = this;
            if((((((((((this._masterDataConnector.<HaveModsLoaded>k__BackingField) != false) && ((this._masterDataConnector.<HaveCpusLoaded>k__BackingField) != false)) && ((this._masterDataConnector.<HavePlushSuitsLoaded>k__BackingField) != false)) && ((this._masterDataConnector.<HasProgressionDataLoaded>k__BackingField) != false)) && ((this._masterDataConnector.<HaveRewardsLoaded>k__BackingField) != false)) && ((this._masterDataConnector.<HasEssenceLoaded>k__BackingField) != false)) && ((this._masterDataConnector.<HaveAttackProfilesLoaded>k__BackingField) != false)) && ((this._masterDataConnector.<HasSeasonDataLoaded>k__BackingField) != false)) && ((this._masterDataConnector.<HasInboxDataLoaded>k__BackingField) != false))
            {
                    val_2 = this._masterDataConnector;
                var val_1 = ((this._masterDataConnector.<HasAlertDataLoaded>k__BackingField) == true) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Game.ItemDefinition.IItemDefinitionDomain get_GetPublicInterface()
        {
            return (Game.ItemDefinition.IItemDefinitionDomain)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ItemDefinitionDomain(Master.EventExposer eventExposer, Game.MasterData.MasterDataDomain masterDataDomain)
        {
            this._eventExposer = eventExposer;
            Game.ItemDefinition.Container.ItemDefinitions val_1 = new Game.ItemDefinition.Container.ItemDefinitions();
            this.<ItemDefinitions>k__BackingField = val_1;
            this._masterDataConnector = new Game.ItemDefinition.Data.MasterDataConnector(masterDataDomain:  masterDataDomain, itemDefinitions:  val_1, callback:  new System.Action(object:  this, method:  System.Void Utilities.AsyncInterfaceAccess<Game.ItemDefinition.IItemDefinitionDomain>::TryToDispatchPublicInterface()));
            this._eventExposer.add_PurchasedSlotsUpdated(value:  new System.Action<System.Int32>(object:  this.<ItemDefinitions>k__BackingField, method:  public System.Void Game.ItemDefinition.Container.ItemDefinitions::SetPurchasedSlots(int slots)));
        }
    
    }

}
