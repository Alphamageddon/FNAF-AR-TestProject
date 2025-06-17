using PaperPlaneTools;
using UnityEngine;

public class DialogHandler_Results : MonoBehaviour
{
	[SerializeField]
	[Header("Hookups")]
	private ResultsUIActions resultsUIActions;

	[SerializeField]
	[Header("Dialog GameObjects")]
	private GameObject dialogRewardsWin;

	[SerializeField]
	private GameObject dialogRewardsLose;

	[SerializeField]
	private AlertUnityUIAdapter dialogResultsPlayerWin;

	[SerializeField]
	private ResultsPlayerWinUIView resultsPlayerWinView;

	[SerializeField]
	private AlertUnityUIAdapter dialogResultsPlayerLose;

	[SerializeField]
	private AlertUnityUIAdapter dialogResultsTutorialEnd;

	private Alert dialogRewardsAlertWin;

	private Alert dialogRewardsAlertLose;

	private Alert dialogResultsAlertPlayerWin;

	private Alert dialogResultsAlertPlayerLose;

	private Alert dialogResultsAlertTutorialEnd;

	public void ShowRewardsWin()
	{
	}

	public void ShowRewardsLose()
	{
	}

	public void ShowResultsPlayerWin()
	{
		LocalizationDomain.Instance.Localization.GetInterfaceAsync(ShowResultsPlayerWinb__14_0);
	}

	public void ShowResultsPlayerLose()
	{
		dialogResultsAlertPlayerLose.Show();
	}

	public void ShowResultsTutorialEnd()
	{
	}

	private void Awake()
	{
		dialogResultsAlertPlayerWin = new Alert();
		dialogResultsAlertPlayerLose = new Alert();
		dialogResultsAlertPlayerWin.SetAdapter(dialogResultsPlayerWin);
		dialogResultsAlertPlayerLose.SetAdapter(dialogResultsPlayerLose);
		string localizedString = LocalizationDomain.Instance.Localization.GetLocalizedString("ui_results_display_return_button_win", "RETURN");
		dialogResultsAlertPlayerWin.SetPositiveButton((localizedString == null) ? "RETURN" : localizedString, resultsUIActions.HideResultsCanvas);
		string localizedString2 = LocalizationDomain.Instance.Localization.GetLocalizedString("ui_results_display_return_button_loss", "RETURN");
		dialogResultsAlertPlayerLose.SetPositiveButton((localizedString2 == null) ? "RETURN" : localizedString2, resultsUIActions.HideResultsCanvas);
	}

	private void OnDestroy()
	{
		if (dialogRewardsAlertWin != null)
		{
			dialogRewardsAlertWin.Dismiss();
		}
		dialogRewardsAlertWin = null;
		if (dialogRewardsAlertLose != null)
		{
			dialogRewardsAlertLose.Dismiss();
		}
		dialogRewardsAlertLose = null;
		if (dialogResultsAlertPlayerWin != null)
		{
			dialogResultsAlertPlayerWin.Dismiss();
		}
		dialogResultsAlertPlayerWin = null;
		if (dialogResultsAlertPlayerLose != null)
		{
			dialogResultsAlertPlayerLose.Dismiss();
		}
		dialogResultsAlertPlayerLose = null;
		if (dialogResultsAlertTutorialEnd != null)
		{
			dialogResultsAlertTutorialEnd.Dismiss();
		}
		dialogResultsAlertTutorialEnd = null;
	}

	private void ShowResultsPlayerWinb__14_0(Localization localization)
	{
		Debug.Log("Showing win UI");
		resultsPlayerWinView.Show(localization.GetLocalizedString("ui_results_display_return_button_win", "RETURN"), resultsUIActions.HideResultsCanvas);
	}

	private void Awakeb__17_0(Localization localization)
	{
		dialogRewardsAlertWin.SetPositiveButton(localization.GetLocalizedString("ui_results_display_return_button_win", "RETURN"), resultsUIActions.HideResultsCanvas);
	}

	private void Awakeb__17_1(Localization localization)
	{
		dialogRewardsAlertLose.SetPositiveButton(localization.GetLocalizedString("ui_results_display_return_button_loss", "RETURN"), resultsUIActions.HideResultsCanvas);
	}
}
