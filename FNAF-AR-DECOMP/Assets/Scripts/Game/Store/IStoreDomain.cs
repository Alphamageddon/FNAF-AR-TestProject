using UnityEngine;

namespace Game.Store
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IStoreDomain
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Game.Store.Container.StoreContainer StoreContainer { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Game.Store.Container.StoreContainer get_StoreContainer(); // 0
    
    }

}
