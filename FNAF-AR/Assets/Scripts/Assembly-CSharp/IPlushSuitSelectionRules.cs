public interface IPlushSuitSelectionRules
{
	bool IsValid(string plushSuitId);

	string GetInitialSelectionId();
}
