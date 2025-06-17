using UnityEngine;

namespace Workshop
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Inventory
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.Data.WorkshopData _workshopData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Workshop.WorkshopDomain _workshopDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Workshop.Data.ModInventory _modInventory;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.TheGame.Data.CPUInventory _cpuInventory;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Workshop.Container.CurrencyContainer _currencyContainer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Container.ItemDefinitions _itemDefinitions;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.Data.WorkshopData WorkshopData { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Workshop.Data.ModInventory ModInventory { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.TheGame.Data.CPUInventory CpuInventory { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Workshop.Container.CurrencyContainer CurrencyContainer { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.Data.WorkshopData get_WorkshopData()
        {
            return (AnimatronicEntity.Data.WorkshopData)this._workshopData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Workshop.Data.ModInventory get_ModInventory()
        {
            return (Game.Workshop.Data.ModInventory)this._modInventory;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.TheGame.Data.CPUInventory get_CpuInventory()
        {
            return (Game.TheGame.Data.CPUInventory)this._cpuInventory;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Workshop.Container.CurrencyContainer get_CurrencyContainer()
        {
            return (Game.Workshop.Container.CurrencyContainer)this._currencyContainer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Inventory(Workshop.WorkshopDomain workshopDomain, Utilities.AsyncInterfaceAccess<Game.ItemDefinition.IItemDefinitionDomain> itemDefinitionDomain)
        {
            val_1 = new System.Object();
            this._workshopDomain = workshopDomain;
            this._currencyContainer = new Game.Workshop.Container.CurrencyContainer();
            this._workshopDomain.eventExposer.add_WorkshopDataV2Updated(value:  new System.Action<AnimatronicEntity.Data.WorkshopData>(object:  this, method:  System.Void Workshop.Inventory::OnWorkshopDataUpdated(AnimatronicEntity.Data.WorkshopData data)));
            this._workshopDomain.eventExposer.add_ModInventoryUpdated(value:  new System.Action<Game.Workshop.Data.ModInventory>(object:  this, method:  System.Void Workshop.Inventory::OnModInventoryUpdated(Game.Workshop.Data.ModInventory obj)));
            this._workshopDomain.eventExposer.add_CPUInventoryUpdated(value:  new System.Action<Game.TheGame.Data.CPUInventory>(object:  this, method:  System.Void Workshop.Inventory::OnCPUInventoryUpdated(Game.TheGame.Data.CPUInventory data)));
            this._workshopDomain.eventExposer.add_PlayerCurrencyRefreshed(value:  new System.Action<System.Collections.Generic.Dictionary<System.String, System.Int32>>(object:  this, method:  System.Void Workshop.Inventory::OnCurrencyRefreshed(System.Collections.Generic.Dictionary<string, int> currencies)));
            val_1.GetInterfaceAsync(callback:  new System.Action<Game.ItemDefinition.IItemDefinitionDomain>(object:  this, method:  System.Void Workshop.Inventory::Callback(Game.ItemDefinition.IItemDefinitionDomain itemDefinitionDomain)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Callback(Game.ItemDefinition.IItemDefinitionDomain itemDefinitionDomain)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            Game.ItemDefinition.Container.ItemDefinitions val_2 = itemDefinitionDomain.ItemDefinitions;
            this._itemDefinitions = val_2;
            if(val_2 == null)
            {
                    return;
            }
            
            if(this._modInventory == null)
            {
                    return;
            }
            
            this._modInventory.UpdateFromLookup(itemDefinitions:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnModInventoryUpdated(Game.Workshop.Data.ModInventory obj)
        {
            this._modInventory = obj;
            if(obj == null)
            {
                    return;
            }
            
            if(this._itemDefinitions == null)
            {
                    return;
            }
            
            obj.UpdateFromLookup(itemDefinitions:  this._itemDefinitions);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateModInventory()
        {
            if(this._itemDefinitions == null)
            {
                    return;
            }
            
            if(this._modInventory == null)
            {
                    return;
            }
            
            this._modInventory.UpdateFromLookup(itemDefinitions:  this._itemDefinitions);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnWorkshopDataUpdated(AnimatronicEntity.Data.WorkshopData data)
        {
            this._workshopData = data;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnCPUInventoryUpdated(Game.TheGame.Data.CPUInventory data)
        {
            this._cpuInventory = data;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnCurrencyRefreshed(System.Collections.Generic.Dictionary<string, int> currencies)
        {
            this._currencyContainer.SetFazTokens(amount:  currencies.Item["FAZ_TOKENS"]);
            this._currencyContainer.SetParts(amount:  currencies.Item["PARTS"]);
            this._currencyContainer.SetEssence(amount:  currencies.Item["ESSENCE"]);
        }
    
    }

}
