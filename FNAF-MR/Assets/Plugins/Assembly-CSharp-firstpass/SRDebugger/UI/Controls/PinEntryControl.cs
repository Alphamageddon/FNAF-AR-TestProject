using System.Collections.Generic;
using System.Collections.ObjectModel;
using SRF;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls
{
	public class PinEntryControl : SRMonoBehaviourEx
	{
		private bool _isVisible = true;

		private List<int> _numbers = new List<int>(4);

		[RequiredField]
		public Image Background;

		public bool CanCancel = true;

		[RequiredField]
		public Button CancelButton;

		[RequiredField]
		public Text CancelButtonText;

		[RequiredField]
		public CanvasGroup CanvasGroup;

		[RequiredField]
		public Animator DotAnimator;

		public Button[] NumberButtons;

		public Toggle[] NumberDots;

		[RequiredField]
		public Text PromptText;

		public event PinEntryControlCallback Complete;

		protected override void Awake()
		{
			base.Awake();
			for (int i = 0; i < NumberButtons.Length; i++)
			{
				int number = i;
				NumberButtons[i].onClick.AddListener(delegate
				{
					PushNumber(number);
				});
			}
			CancelButton.onClick.AddListener(CancelButtonPressed);
			RefreshState();
		}

		protected override void Update()
		{
			base.Update();
			if (!_isVisible)
			{
				return;
			}
			if (_numbers.Count > 0 && (Input.GetKeyDown(KeyCode.Backspace) || Input.GetKeyDown(KeyCode.Delete)))
			{
				_numbers.PopLast();
				RefreshState();
			}
			string inputString = Input.inputString;
			for (int i = 0; i < inputString.Length; i++)
			{
				if (char.IsNumber(inputString, i))
				{
					int num = (int)char.GetNumericValue(inputString, i);
					if (num <= 9 && num >= 0)
					{
						PushNumber(num);
					}
				}
			}
		}

		public void Show()
		{
			CanvasGroup.alpha = 1f;
			CanvasGroup canvasGroup = CanvasGroup;
			bool blocksRaycasts = (CanvasGroup.interactable = true);
			canvasGroup.blocksRaycasts = blocksRaycasts;
			_isVisible = true;
		}

		public void Hide()
		{
			CanvasGroup.alpha = 0f;
			CanvasGroup canvasGroup = CanvasGroup;
			bool blocksRaycasts = (CanvasGroup.interactable = false);
			canvasGroup.blocksRaycasts = blocksRaycasts;
			_isVisible = false;
		}

		public void Clear()
		{
			_numbers.Clear();
			RefreshState();
		}

		public void PlayInvalidCodeAnimation()
		{
			DotAnimator.SetTrigger("Invalid");
		}

		protected void OnComplete()
		{
			if (this.Complete != null)
			{
				this.Complete(new ReadOnlyCollection<int>(_numbers), didCancel: false);
			}
		}

		protected void OnCancel()
		{
			if (this.Complete != null)
			{
				this.Complete(new int[0], didCancel: true);
			}
		}

		private void CancelButtonPressed()
		{
			if (_numbers.Count > 0)
			{
				_numbers.PopLast();
			}
			else
			{
				OnCancel();
			}
			RefreshState();
		}

		public void PushNumber(int number)
		{
			if (_numbers.Count >= 4)
			{
				Debug.LogWarning("[PinEntry] Expected 4 numbers");
				return;
			}
			_numbers.Add(number);
			if (_numbers.Count >= 4)
			{
				OnComplete();
			}
			RefreshState();
		}

		private void RefreshState()
		{
			for (int i = 0; i < NumberDots.Length; i++)
			{
				NumberDots[i].isOn = i < _numbers.Count;
			}
			if (_numbers.Count > 0)
			{
				CancelButtonText.text = "Delete";
			}
			else
			{
				CancelButtonText.text = (CanCancel ? "Cancel" : "");
			}
		}
	}
}
