using UnityEngine;

namespace Workshop
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class WorkshopDomain
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.ServerDomain _serverDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _eventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Workshop.Inventory _inventory;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.ServerDomain serverDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.EventExposer eventExposer { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Workshop.Inventory Inventory { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.ServerDomain get_serverDomain()
        {
            return (Game.Server.ServerDomain)this._serverDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.EventExposer get_eventExposer()
        {
            return (Master.EventExposer)this._eventExposer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Workshop.Inventory get_Inventory()
        {
            return (Workshop.Inventory)this._inventory;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WorkshopDomain(Master.EventExposer exposer, Utilities.AsyncInterfaceAccess<Game.ItemDefinition.IItemDefinitionDomain> itemDefinitionDomain, Game.Server.ServerDomain serverDomain)
        {
            val_1 = new System.Object();
            this._serverDomain = serverDomain;
            this._eventExposer = exposer;
            this._inventory = new Workshop.Inventory(workshopDomain:  this, itemDefinitionDomain:  Utilities.AsyncInterfaceAccess<Game.ItemDefinition.IItemDefinitionDomain> val_1 = itemDefinitionDomain);
        }
    
    }

}
