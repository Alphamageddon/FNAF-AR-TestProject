using UnityEngine;

namespace Game.ItemDefinition
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IItemDefinitionDomain
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Game.ItemDefinition.Container.ItemDefinitions ItemDefinitions { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Game.ItemDefinition.Container.ItemDefinitions get_ItemDefinitions(); // 0
    
    }

}
