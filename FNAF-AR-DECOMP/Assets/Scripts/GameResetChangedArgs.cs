using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class GameResetter.GameResetChangedArgs
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TheGame.GameDisplayData.DisplayType startingGameDisplay;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GameResetter.GameResetChangedArgs(TheGame.GameDisplayData.DisplayType startingGameDisplay)
    {
        this.startingGameDisplay = startingGameDisplay;
    }

}
