using System;

public struct ExitAttackSequenceDialogData
{
	public string titleText;

	public string bodyText;

	public string stayButtonText;

	public string leaveButtonText;

	public bool shouldJammerBeInteractable;

	public string jammerButtonText;

	public string jammerButtonCost;

	public Action jammerCallback;

	public Action leaveCallback;
}
