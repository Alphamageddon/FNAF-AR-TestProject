using UnityEngine;

public class MaskState : IMask
{
	public delegate void StateChanged(bool isMaskGoingOn, bool isMaskTransitionBeginning);

	private EventExposer _masterEventExposer;

	private MaskController _maskController;

	public bool IsMaskAvailable { get; set; }

	public MaskState(EventExposer masterEventExposer)
	{
		_masterEventExposer = masterEventExposer;
	}

	public void SetFxController(MaskController maskController)
	{
		_maskController = maskController;
		maskController.SetStatusCallback(MaskStatusChanged);
	}

	public bool IsMaskFullyOn()
	{
		if (_maskController == null)
		{
			return false;
		}
		return _maskController.IsMaskFullyOn();
	}

	public bool IsMaskFullyOff()
	{
		if (_maskController == null)
		{
			return true;
		}
		return _maskController.IsMaskFullyOff();
	}

	public bool IsMaskInTransition()
	{
		if (_maskController == null)
		{
			return false;
		}
		return _maskController.IsMaskInTransition();
	}

	public bool IsMaskInRaiseTransition()
	{
		if (_maskController == null)
		{
			return false;
		}
		return _maskController.IsMaskInRaiseTransition();
	}

	public void SetMaskAvailable(bool shouldMaskBeAvailable)
	{
		if (!(_maskController == null))
		{
			IsMaskAvailable = shouldMaskBeAvailable;
			_maskController.SetMaskAvailable(shouldMaskBeAvailable);
		}
	}

	public void SetDesiredMaskState(bool desiredMaskState)
	{
		if (!(_maskController == null))
		{
			_maskController.SetDesiredMaskState(desiredMaskState);
		}
	}

	private void MaskStatusChanged(MaskStatusChange change)
	{
		if (change.WasTransitionForced)
		{
			if (!change.IsMaskGoingOn)
			{
				_masterEventExposer.OnMaskForcedOff();
			}
		}
		else
		{
			Debug.Log("calling event exposer mask state changed " + change.IsMaskGoingOn + " - " + change.IsTransitionBeginning);
			_masterEventExposer.OnMaskStateChanged(change.IsMaskGoingOn, change.IsTransitionBeginning);
		}
	}
}
