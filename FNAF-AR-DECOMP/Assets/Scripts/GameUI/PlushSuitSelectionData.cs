using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class PlushSuitSelectionData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<GameUI.PlushSuitCell> cells;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlushSuitSelectionData()
        {
            this.cells = new System.Collections.Generic.List<GameUI.PlushSuitCell>();
        }
    
    }

}
