using System;
using UnityEngine;

public class MaskController : MonoBehaviour
{
	private enum EventCode
	{
		MaskForcedOff = 1,
		MaskOnBegin = 2,
		MaskOnEnd = 3,
		MaskOffBegin = 4,
		MaskOffEnd = 5
	}

	public GameObject maskCamera;

	public GameObject mask;

	public Animator animator;

	public AnimationEventListener listener;

	private bool _isMaskEnabled;

	private bool _shouldMaskBeOn;

	private bool _isMaskGoingOn;

	private bool _isMaskInTransition;

	private Action<MaskStatusChange> OnMaskStatusChanged;

	private const string MaskOn = "MaskOn";

	private const string MaskOff = "MaskOff";

	private static readonly int IsMaskOnId;

	private static readonly int ForceMaskOffId;

	private void add_OnMaskStatusChanged(Action<MaskStatusChange> value)
	{
		OnMaskStatusChanged = (Action<MaskStatusChange>)Delegate.Combine(OnMaskStatusChanged, value);
	}

	private void remove_OnMaskStatusChanged(Action<MaskStatusChange> value)
	{
		OnMaskStatusChanged = (Action<MaskStatusChange>)Delegate.Remove(OnMaskStatusChanged, value);
	}

	public void SetStatusCallback(Action<MaskStatusChange> maskStatusChanged)
	{
		add_OnMaskStatusChanged(maskStatusChanged);
	}

	public bool IsMaskFullyOn()
	{
		if (_isMaskEnabled && animator.gameObject.activeInHierarchy && _isMaskGoingOn)
		{
			return !_isMaskInTransition;
		}
		return false;
	}

	public bool IsMaskFullyOff()
	{
		if (!_isMaskEnabled || !animator.gameObject.activeInHierarchy)
		{
			return true;
		}
		if (!_isMaskGoingOn)
		{
			return !_isMaskInTransition;
		}
		return false;
	}

	public bool IsMaskInTransition()
	{
		if (_isMaskEnabled && animator.gameObject.activeInHierarchy)
		{
			return _isMaskInTransition;
		}
		return false;
	}

	public bool IsMaskInRaiseTransition()
	{
		if (_isMaskEnabled && animator.gameObject.activeInHierarchy)
		{
			if (_isMaskInTransition)
			{
				return !_isMaskGoingOn;
			}
			return false;
		}
		return false;
	}

	public void SetMaskAvailable(bool shouldMaskBeAvailable)
	{
		if (!shouldMaskBeAvailable)
		{
			ForceMaskOff();
		}
		_isMaskEnabled = shouldMaskBeAvailable;
	}

	public void ForceMaskOff()
	{
		_shouldMaskBeOn = false;
		animator.SetBool(IsMaskOnId, value: false);
		animator.SetTrigger(ForceMaskOffId);
	}

	public void SetDesiredMaskState(bool desiredMaskState)
	{
		if (_isMaskEnabled)
		{
			_shouldMaskBeOn = desiredMaskState;
			animator.SetBool(IsMaskOnId, _shouldMaskBeOn);
		}
	}

	private void Start()
	{
		listener.OnAnimationEventReceived += MaskAnimationEvent;
	}

	private void MaskAnimationEvent(AnimationEvent animationEvent)
	{
		switch (animationEvent.intParameter)
		{
		case 1:
			_isMaskGoingOn = false;
			_isMaskInTransition = false;
			if (OnMaskStatusChanged != null)
			{
				MaskStatusChange maskStatusChange2 = new MaskStatusChange();
				maskStatusChange2.IsMaskGoingOn = false;
				maskStatusChange2.IsTransitionBeginning = false;
				maskStatusChange2.WasTransitionForced = true;
				OnMaskStatusChanged(maskStatusChange2);
			}
			break;
		case 2:
			_isMaskGoingOn = true;
			_isMaskInTransition = true;
			if (OnMaskStatusChanged != null)
			{
				MaskStatusChange maskStatusChange4 = new MaskStatusChange();
				maskStatusChange4.IsMaskGoingOn = true;
				maskStatusChange4.IsTransitionBeginning = true;
				maskStatusChange4.WasTransitionForced = false;
				OnMaskStatusChanged(maskStatusChange4);
			}
			break;
		case 3:
			_isMaskGoingOn = true;
			_isMaskInTransition = false;
			if (OnMaskStatusChanged != null)
			{
				MaskStatusChange maskStatusChange5 = new MaskStatusChange();
				maskStatusChange5.IsMaskGoingOn = true;
				maskStatusChange5.IsTransitionBeginning = false;
				maskStatusChange5.WasTransitionForced = false;
				OnMaskStatusChanged(maskStatusChange5);
			}
			break;
		case 4:
			_isMaskGoingOn = false;
			_isMaskInTransition = true;
			if (OnMaskStatusChanged != null)
			{
				MaskStatusChange maskStatusChange3 = new MaskStatusChange();
				maskStatusChange3.IsMaskGoingOn = false;
				maskStatusChange3.IsTransitionBeginning = true;
				maskStatusChange3.WasTransitionForced = false;
				OnMaskStatusChanged(maskStatusChange3);
			}
			break;
		case 5:
			_isMaskGoingOn = false;
			_isMaskInTransition = false;
			if (OnMaskStatusChanged != null)
			{
				MaskStatusChange maskStatusChange = new MaskStatusChange();
				maskStatusChange.IsMaskGoingOn = false;
				maskStatusChange.IsTransitionBeginning = false;
				maskStatusChange.WasTransitionForced = false;
				OnMaskStatusChanged(maskStatusChange);
			}
			break;
		}
	}

	static MaskController()
	{
		IsMaskOnId = Animator.StringToHash("IsMaskOn");
		ForceMaskOffId = Animator.StringToHash("ForceMaskOff");
		IsMaskOnId = Animator.StringToHash("IsMaskOn");
		ForceMaskOffId = Animator.StringToHash("ForceMaskOff");
	}
}
