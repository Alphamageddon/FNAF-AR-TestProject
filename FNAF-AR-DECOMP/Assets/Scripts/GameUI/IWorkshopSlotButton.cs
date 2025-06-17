using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IWorkshopSlotButton
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Game.Store.Data.StoreDisplayData GetStoreDisplayData(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract GameUI.WorkshopSlotData GetWorkshopSlotData(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetSelectedUI(bool value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int GetSortWeight(); // 0
    
    }

}
