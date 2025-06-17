using System;
using System.Collections;
using System.Linq;
using SRDebugger.Internal;
using SRDebugger.Services;
using SRF;
using SRF.Service;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SRDebugger.UI.Other
{
	public class BugReportSheetController : SRMonoBehaviourEx
	{
		[RequiredField]
		public GameObject ButtonContainer;

		[RequiredField]
		public Text ButtonText;

		[RequiredField]
		public Button CancelButton;

		public Action CancelPressed;

		[RequiredField]
		public InputField DescriptionField;

		[RequiredField]
		public InputField EmailField;

		[RequiredField]
		public Slider ProgressBar;

		[RequiredField]
		public Text ResultMessageText;

		public Action ScreenshotComplete;

		[RequiredField]
		public Button SubmitButton;

		public Action<bool, string> SubmitComplete;

		public Action TakingScreenshot;

		public bool IsCancelButtonEnabled
		{
			get
			{
				return CancelButton.gameObject.activeSelf;
			}
			set
			{
				CancelButton.gameObject.SetActive(value);
			}
		}

		protected override void Start()
		{
			base.Start();
			SetLoadingSpinnerVisible(visible: false);
			ClearErrorMessage();
			ClearForm();
		}

		public void Submit()
		{
			EventSystem.current.SetSelectedGameObject(null);
			ProgressBar.value = 0f;
			ClearErrorMessage();
			SetLoadingSpinnerVisible(visible: true);
			SetFormEnabled(e: false);
			if (!string.IsNullOrEmpty(EmailField.text))
			{
				SetDefaultEmailFieldContents(EmailField.text);
			}
			StartCoroutine(SubmitCo());
		}

		public void Cancel()
		{
			if (CancelPressed != null)
			{
				CancelPressed();
			}
		}

		private IEnumerator SubmitCo()
		{
			if (BugReportScreenshotUtil.ScreenshotData == null)
			{
				if (TakingScreenshot != null)
				{
					TakingScreenshot();
				}
				yield return new WaitForEndOfFrame();
				yield return StartCoroutine(BugReportScreenshotUtil.ScreenshotCaptureCo());
				if (ScreenshotComplete != null)
				{
					ScreenshotComplete();
				}
			}
			IBugReportService service = SRServiceManager.GetService<IBugReportService>();
			BugReport report = new BugReport
			{
				Email = EmailField.text,
				UserDescription = DescriptionField.text,
				ConsoleLog = Service.Console.AllEntries.ToList(),
				SystemInformation = SRServiceManager.GetService<ISystemInformationService>().CreateReport(),
				ScreenshotData = BugReportScreenshotUtil.ScreenshotData
			};
			BugReportScreenshotUtil.ScreenshotData = null;
			service.SendBugReport(report, OnBugReportComplete, OnBugReportProgress);
		}

		private void OnBugReportProgress(float progress)
		{
			ProgressBar.value = progress;
		}

		private void OnBugReportComplete(bool didSucceed, string errorMessage)
		{
			if (!didSucceed)
			{
				ShowErrorMessage("Error sending bug report", errorMessage);
			}
			else
			{
				ClearForm();
				ShowErrorMessage("Bug report submitted successfully");
			}
			SetLoadingSpinnerVisible(visible: false);
			SetFormEnabled(e: true);
			if (SubmitComplete != null)
			{
				SubmitComplete(didSucceed, errorMessage);
			}
		}

		protected void SetLoadingSpinnerVisible(bool visible)
		{
			ProgressBar.gameObject.SetActive(visible);
			ButtonContainer.SetActive(!visible);
		}

		protected void ClearForm()
		{
			EmailField.text = GetDefaultEmailFieldContents();
			DescriptionField.text = "";
		}

		protected void ShowErrorMessage(string userMessage, string serverMessage = null)
		{
			string text = userMessage;
			if (!string.IsNullOrEmpty(serverMessage))
			{
				text += " (<b>{0}</b>)".Fmt(serverMessage);
			}
			ResultMessageText.text = text;
			ResultMessageText.gameObject.SetActive(value: true);
		}

		protected void ClearErrorMessage()
		{
			ResultMessageText.text = "";
			ResultMessageText.gameObject.SetActive(value: false);
		}

		protected void SetFormEnabled(bool e)
		{
			SubmitButton.interactable = e;
			CancelButton.interactable = e;
			EmailField.interactable = e;
			DescriptionField.interactable = e;
		}

		private string GetDefaultEmailFieldContents()
		{
			return PlayerPrefs.GetString("SRDEBUGGER_BUG_REPORT_LAST_EMAIL", "");
		}

		private void SetDefaultEmailFieldContents(string value)
		{
			PlayerPrefs.SetString("SRDEBUGGER_BUG_REPORT_LAST_EMAIL", value);
			PlayerPrefs.Save();
		}
	}
}
