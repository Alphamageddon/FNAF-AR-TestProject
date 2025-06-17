using System;

public class ModSelectionCellData
{
	public GatherModsForEquipping.ModContext context;

	public Action<ModCell> SelectModCell;

	public Action<ModCell> DisplaySellDialog;
}
