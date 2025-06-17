using SRDebugger.UI.Other;
using SRF;
using UnityEngine;

namespace SRDebugger.UI.Tabs
{
	public class BugReportTabController : SRMonoBehaviourEx, IEnableTab
	{
		[RequiredField]
		public BugReportSheetController BugReportSheetPrefab;

		[RequiredField]
		public RectTransform Container;

		public bool IsEnabled => Settings.Instance.EnableBugReporter;

		protected override void Start()
		{
			base.Start();
			BugReportSheetController bugReportSheetController = SRInstantiate.Instantiate(BugReportSheetPrefab);
			bugReportSheetController.IsCancelButtonEnabled = false;
			bugReportSheetController.TakingScreenshot = TakingScreenshot;
			bugReportSheetController.ScreenshotComplete = ScreenshotComplete;
			bugReportSheetController.CachedTransform.SetParent(Container, worldPositionStays: false);
		}

		private void TakingScreenshot()
		{
			SRDebug.Instance.HideDebugPanel();
		}

		private void ScreenshotComplete()
		{
			SRDebug.Instance.ShowDebugPanel(requireEntryCode: false);
		}
	}
}
