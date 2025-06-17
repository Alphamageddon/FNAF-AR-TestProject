using UnityEngine;

public class ResultsUIActions : MonoBehaviour
{
	private MasterDomain _masterDomain;

	private bool alreadyHiding;

	public void HideResultsCanvas()
	{
		if (!alreadyHiding)
		{
			alreadyHiding = true;
			_masterDomain.eventExposer.OnRewardsFlowCompleted();
			_masterDomain.TheGameDomain.gameDisplayChanger.RequestDisplayChange(GameDisplayData.DisplayType.map);
		}
	}

	private void Awake()
	{
		_masterDomain = MasterDomain.GetDomain();
	}
}
