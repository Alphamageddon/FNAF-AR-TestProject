using UnityEngine;

public class WorkshopSceneLookupTable : MonoBehaviour
{
	[SerializeField]
	private GameObject _displayParent;

	[SerializeField]
	private WorkshopStageView _workshopStage;

	[SerializeField]
	private GameObject _audioListenerParent;

	public GameObject DisplayParent => _displayParent;

	public WorkshopStageView WorkshopStage => _workshopStage;

	public GameObject AudioListenerParent => _audioListenerParent;
}
