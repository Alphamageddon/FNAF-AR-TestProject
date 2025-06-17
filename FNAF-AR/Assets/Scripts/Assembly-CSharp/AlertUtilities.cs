using System;
using PaperPlaneTools;

public static class AlertUtilities
{
	public static void ShowAlertWithAndroidBackButtonAction(Alert alert, Action backButtonAction)
	{
		int backButtonActionId = 0;
		Action oldOnDismiss = alert.OnDismiss;
		alert.SetOnDismiss(delegate
		{
			if (backButtonActionId >= 1)
			{
				backButtonActionId = 0;
			}
			alert.SetOnDismiss(oldOnDismiss);
			oldOnDismiss?.Invoke();
		});
		alert.Show();
	}

	public static void ShowAlertWithAndroidBackButtonPause(Alert alert)
	{
		int pauseId = 0;
		Action oldOnDismiss = alert.OnDismiss;
		alert.SetOnDismiss(delegate
		{
			if (pauseId >= 1)
			{
				pauseId = 0;
			}
			alert.SetOnDismiss(oldOnDismiss);
			oldOnDismiss?.Invoke();
		});
		alert.Show();
	}
}
