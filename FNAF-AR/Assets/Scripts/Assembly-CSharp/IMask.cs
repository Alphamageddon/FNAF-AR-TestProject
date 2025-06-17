public interface IMask
{
	bool IsMaskAvailable { get; }

	bool IsMaskFullyOn();

	bool IsMaskFullyOff();

	bool IsMaskInTransition();

	bool IsMaskInRaiseTransition();

	void SetMaskAvailable(bool shouldMaskBeAvailable);

	void SetDesiredMaskState(bool desiredMaskState);
}
