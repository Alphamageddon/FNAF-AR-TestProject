using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class HoldableButton : Button
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsPressed { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsPressed()
        {
            return this.IsPressed();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public HoldableButton()
        {
        
        }
    
    }

}
