using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StoreCellData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<GameUI.StoreCell> OnClickedDelegate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Store.Data.StoreDisplayData displayData;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StoreCellData()
        {
        
        }
    
    }

}
