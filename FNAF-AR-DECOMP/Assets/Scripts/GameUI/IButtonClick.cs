using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IButtonClick
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract UnityEngine.UI.Button button { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool buttonClicked { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract UnityEngine.UI.Button get_button(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void set_button(UnityEngine.UI.Button value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void set_buttonClicked(bool value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool get_buttonClicked(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void ButtonClick(); // 0
    
    }

}
