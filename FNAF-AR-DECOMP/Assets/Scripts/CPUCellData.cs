using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class CPUCell.CPUCellData
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool playerOwned;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Game.ItemDefinition.Data.DataDefinitions.CPUData serverData;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Action<GameUI.CPUCell, bool> SelectFunction;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CPUCell.CPUCellData()
    {
    
    }

}
