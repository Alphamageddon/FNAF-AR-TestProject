using System;
using System.Collections;
using SRDebugger.Internal;
using SRDebugger.UI.Other;
using SRF;
using SRF.Service;
using UnityEngine;

namespace SRDebugger.Services.Implementation
{
	[Service(typeof(BugReportPopoverService))]
	public class BugReportPopoverService : SRServiceBase<BugReportPopoverService>
	{
		private BugReportCompleteCallback _callback;

		private bool _isVisible;

		private BugReportPopoverRoot _popover;

		private BugReportSheetController _sheet;

		public bool IsShowingPopover => _isVisible;

		public void ShowBugReporter(BugReportCompleteCallback callback, bool takeScreenshotFirst = true, string descriptionText = null)
		{
			if (_isVisible)
			{
				throw new InvalidOperationException("Bug report popover is already visible.");
			}
			if (_popover == null)
			{
				Load();
			}
			if (_popover == null)
			{
				Debug.LogWarning("[SRDebugger] Bug report popover failed loading, executing callback with fail result");
				callback(didSucceed: false, "Resource load failed");
				return;
			}
			_callback = callback;
			_isVisible = true;
			SRDebuggerUtil.EnsureEventSystemExists();
			StartCoroutine(OpenCo(takeScreenshotFirst, descriptionText));
		}

		private IEnumerator OpenCo(bool takeScreenshot, string descriptionText)
		{
			if (takeScreenshot)
			{
				yield return StartCoroutine(BugReportScreenshotUtil.ScreenshotCaptureCo());
			}
			_popover.CachedGameObject.SetActive(value: true);
			yield return new WaitForEndOfFrame();
			if (!string.IsNullOrEmpty(descriptionText))
			{
				_sheet.DescriptionField.text = descriptionText;
			}
		}

		private void SubmitComplete(bool didSucceed, string errorMessage)
		{
			OnComplete(didSucceed, errorMessage, close: false);
		}

		private void CancelPressed()
		{
			OnComplete(success: false, "User Cancelled", close: true);
		}

		private void OnComplete(bool success, string errorMessage, bool close)
		{
			if (!_isVisible)
			{
				Debug.LogWarning("[SRDebugger] Received callback at unexpected time. ???");
			}
			else if (success || close)
			{
				_isVisible = false;
				_popover.gameObject.SetActive(value: false);
				UnityEngine.Object.Destroy(_popover.gameObject);
				_popover = null;
				_sheet = null;
				BugReportScreenshotUtil.ScreenshotData = null;
				_callback(success, errorMessage);
			}
		}

		private void TakingScreenshot()
		{
			if (!IsShowingPopover)
			{
				Debug.LogWarning("[SRDebugger] Received callback at unexpected time. ???");
			}
			else
			{
				_popover.CanvasGroup.alpha = 0f;
			}
		}

		private void ScreenshotComplete()
		{
			if (!IsShowingPopover)
			{
				Debug.LogWarning("[SRDebugger] Received callback at unexpected time. ???");
			}
			else
			{
				_popover.CanvasGroup.alpha = 1f;
			}
		}

		protected override void Awake()
		{
			base.Awake();
			base.CachedTransform.SetParent(Hierarchy.Get("SRDebugger"));
		}

		private void Load()
		{
			BugReportPopoverRoot bugReportPopoverRoot = Resources.Load<BugReportPopoverRoot>("SRDebugger/UI/Prefabs/BugReportPopover");
			BugReportSheetController bugReportSheetController = Resources.Load<BugReportSheetController>("SRDebugger/UI/Prefabs/BugReportSheet");
			if (bugReportPopoverRoot == null)
			{
				Debug.LogError("[SRDebugger] Unable to load bug report popover prefab");
				return;
			}
			if (bugReportSheetController == null)
			{
				Debug.LogError("[SRDebugger] Unable to load bug report sheet prefab");
				return;
			}
			_popover = SRInstantiate.Instantiate(bugReportPopoverRoot);
			_popover.CachedTransform.SetParent(base.CachedTransform, worldPositionStays: false);
			_sheet = SRInstantiate.Instantiate(bugReportSheetController);
			_sheet.CachedTransform.SetParent(_popover.Container, worldPositionStays: false);
			_sheet.SubmitComplete = SubmitComplete;
			_sheet.CancelPressed = CancelPressed;
			_sheet.TakingScreenshot = TakingScreenshot;
			_sheet.ScreenshotComplete = ScreenshotComplete;
			_popover.CachedGameObject.SetActive(value: false);
		}
	}
}
