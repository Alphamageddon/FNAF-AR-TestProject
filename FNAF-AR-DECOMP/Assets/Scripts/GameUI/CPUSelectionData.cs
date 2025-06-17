using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class CPUSelectionData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<GameUI.CPUCell> cells;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CPUSelectionData()
        {
            this.cells = new System.Collections.Generic.List<GameUI.CPUCell>();
        }
    
    }

}
