using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ModSelectionCellData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.Actions.GatherModsForEquipping.ModContext context;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<GameUI.ModCell> SelectModCell;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<GameUI.ModCell> DisplaySellDialog;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ModSelectionCellData()
        {
        
        }
    
    }

}
