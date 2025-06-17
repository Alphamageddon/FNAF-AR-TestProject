using System;
using System.Collections.Generic;
using System.Linq;
using SRDebugger.Internal;
using SRDebugger.UI.Controls;
using SRF;
using SRF.Service;
using UnityEngine;

namespace SRDebugger.Services.Implementation
{
	[Service(typeof(IPinEntryService))]
	public class PinEntryServiceImpl : SRServiceBase<IPinEntryService>, IPinEntryService
	{
		private PinEntryCompleteCallback _callback;

		private bool _isVisible;

		private PinEntryControl _pinControl;

		private List<int> _requiredPin = new List<int>(4);

		public bool IsShowingKeypad => _isVisible;

		public void ShowPinEntry(IList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool allowCancel = true)
		{
			if (_isVisible)
			{
				throw new InvalidOperationException("Pin entry is already in progress");
			}
			VerifyPin(requiredPin);
			if (_pinControl == null)
			{
				Load();
			}
			if (_pinControl == null)
			{
				Debug.LogWarning("[PinEntry] Pin entry failed loading, executing callback with fail result");
				callback(validPinEntered: false);
				return;
			}
			_pinControl.Clear();
			_pinControl.PromptText.text = message;
			_pinControl.CanCancel = allowCancel;
			_callback = callback;
			_requiredPin.Clear();
			_requiredPin.AddRange(requiredPin);
			_pinControl.Show();
			_isVisible = true;
			SRDebuggerUtil.EnsureEventSystemExists();
		}

		[Obsolete]
		public void ShowPinEntry(IList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool blockInput, bool allowCancel)
		{
			ShowPinEntry(requiredPin, message, callback, allowCancel);
		}

		protected override void Awake()
		{
			base.Awake();
			base.CachedTransform.SetParent(Hierarchy.Get("SRDebugger"));
		}

		private void Load()
		{
			PinEntryControl pinEntryControl = Resources.Load<PinEntryControl>("SRDebugger/UI/Prefabs/PinEntry");
			if (pinEntryControl == null)
			{
				Debug.LogError("[PinEntry] Unable to load pin entry prefab");
				return;
			}
			_pinControl = SRInstantiate.Instantiate(pinEntryControl);
			_pinControl.CachedTransform.SetParent(base.CachedTransform, worldPositionStays: false);
			_pinControl.Hide();
			_pinControl.Complete += PinControlOnComplete;
		}

		private void PinControlOnComplete(IList<int> result, bool didCancel)
		{
			bool flag = _requiredPin.SequenceEqual(result);
			if (!didCancel && !flag)
			{
				_pinControl.Clear();
				_pinControl.PlayInvalidCodeAnimation();
				return;
			}
			_isVisible = false;
			_pinControl.Hide();
			if (didCancel)
			{
				_callback(validPinEntered: false);
			}
			else
			{
				_callback(flag);
			}
		}

		private void VerifyPin(IList<int> pin)
		{
			if (pin.Count != 4)
			{
				throw new ArgumentException("Pin list must have 4 elements");
			}
			for (int i = 0; i < pin.Count; i++)
			{
				if (pin[i] < 0 || pin[i] > 9)
				{
					throw new ArgumentException("Pin numbers must be >= 0 && <= 9");
				}
			}
		}
	}
}
