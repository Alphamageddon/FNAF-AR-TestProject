using UnityEngine;

namespace TheGame
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GameDisplayData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.GameDisplayData.DisplayType <currentDisplay>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.GameDisplayData.DisplayType <previousDisplay>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TheGame.GameDisplayData.DisplayType currentDisplay { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TheGame.GameDisplayData.DisplayType previousDisplay { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TheGame.GameDisplayData.DisplayType get_currentDisplay()
        {
            return (DisplayType)this.<currentDisplay>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_currentDisplay(TheGame.GameDisplayData.DisplayType value)
        {
            this.<currentDisplay>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TheGame.GameDisplayData.DisplayType get_previousDisplay()
        {
            return (DisplayType)this.<previousDisplay>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_previousDisplay(TheGame.GameDisplayData.DisplayType value)
        {
            this.<previousDisplay>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameDisplayData()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameDisplayData(TheGame.GameDisplayData state)
        {
            if(state != null)
            {
                    this.<currentDisplay>k__BackingField = state.<currentDisplay>k__BackingField;
            }
            else
            {
                    this.<currentDisplay>k__BackingField = 11993091;
            }
            
            this.<previousDisplay>k__BackingField = state.<previousDisplay>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameDisplayData(TheGame.GameDisplayData.DisplayType mode)
        {
            this.<currentDisplay>k__BackingField = mode;
            this.<previousDisplay>k__BackingField = mode;
        }
    
    }

}
