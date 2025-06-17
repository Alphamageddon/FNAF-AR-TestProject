public class DropsObjectsMechanicViewModel : IDropsObjectsMechanicViewModel
{
	public bool IsDroppedObjectActive { get; set; }

	public float CollectionTimeRemaining { get; set; }

	public float CollectionPercentRemaining { get; set; }

	public bool ShouldShowCollectionTimer
	{
		get
		{
			if (!IsDroppedObjectActive)
			{
				return false;
			}
			return CollectionPercentRemaining > -1f;
		}
	}

	public int NumCollected { get; set; }

	public int NumFailed { get; set; }

	public int NumRemaining { get; set; }
}
