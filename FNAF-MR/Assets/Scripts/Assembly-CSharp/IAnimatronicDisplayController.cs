public interface IAnimatronicDisplayController
{
	void PreSetup(IEntityAnimatronicDisplay target);

	void OnSetup(IEntityAnimatronicDisplay target, float alertDelay);

	void OnFullScreenClicked();

	void OnJammerClicked();

	void OnCloseClicked();
}
