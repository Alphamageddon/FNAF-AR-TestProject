public interface IUISequence
{
	void StartSequence(UISequenceData data);

	void UpdateSequence();

	bool IsSequenceDone();

	void TeardownSequence();
}
