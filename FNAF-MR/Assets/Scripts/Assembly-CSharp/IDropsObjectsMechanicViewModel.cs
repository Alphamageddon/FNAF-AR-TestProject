public interface IDropsObjectsMechanicViewModel
{
	bool IsDroppedObjectActive { get; }

	float CollectionTimeRemaining { get; }

	float CollectionPercentRemaining { get; }

	bool ShouldShowCollectionTimer { get; }

	int NumRemaining { get; }

	int NumCollected { get; }

	int NumFailed { get; }
}
