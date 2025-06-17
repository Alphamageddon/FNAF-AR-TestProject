using System;
using System.Collections.Generic;
using UnityEngine;

public class WorkshopStage
{
	private EventExposer _masterEventExposer;

	private Animatronic3DDomain _animatronic3DDomain;

	private ItemDefinitionDomain _itemDefinitionDomain;

	private Transform _stageRootTransform;

	private Action<string> _spawnCompleteCallback;

	private WorkshopEntry _requestedAnimatronic;

	private Animatronic3D _spawnedAnimatronic;

	private WorkshopSlotDataModel _workshopSlotDataModel;

	private CreationRequest _currentRequest;

	public WorkshopStage(EventExposer masterEventExposer, Animatronic3DDomain animatronic3DAccess, ItemDefinitionDomain itemDefinitionAccess, Transform stageRootTransform, Action<string> spawnCompleteCallback, WorkshopSlotDataModel workshopSlotDataModel)
	{
		_masterEventExposer = masterEventExposer;
		_stageRootTransform = stageRootTransform;
		_spawnCompleteCallback = spawnCompleteCallback;
		_workshopSlotDataModel = workshopSlotDataModel;
		_masterEventExposer.add_WorkshopCpuChanged(WorkshopCpuChanged);
		_masterEventExposer.add_WorkshopModifyTabClosed(MasterEventExposerOnWorkshopModifyTabClosed);
		_masterEventExposer.add_WorkshopModifyTabOpened(MasterEventExposerOnWorkshopModifyTabOpened);
		_masterEventExposer.add_WorkshopRepairSuccess(WorkshopRepairSuccess);
		_masterEventExposer.add_WorkshopSlotDataUpdated(OnWorkshopSlotDataUpdated);
		Animatronic3DDomainReady(animatronic3DAccess);
		ItemDefinitionDomainReady(itemDefinitionAccess);
	}

	private void MasterEventExposerOnWorkshopModifyTabOpened(SlotDisplayButtonType slotDisplayButtonType)
	{
		switch (slotDisplayButtonType)
		{
		case SlotDisplayButtonType.Cpu:
			WorkshopCpuMenuOpened();
			break;
		case SlotDisplayButtonType.Mod:
			WorkshopModMenuOpened();
			break;
		}
	}

	private void MasterEventExposerOnWorkshopModifyTabClosed(SlotDisplayButtonType slotDisplayButtonType)
	{
		Debug.Log("Closed" + slotDisplayButtonType);
		switch (slotDisplayButtonType)
		{
		case SlotDisplayButtonType.Cpu:
			WorkshopCpuMenuClosed();
			break;
		case SlotDisplayButtonType.Mod:
			WorkshopModMenuClosed();
			break;
		}
	}

	private void Animatronic3DDomainReady(Animatronic3DDomain animatronic3DDomain)
	{
		_animatronic3DDomain = animatronic3DDomain;
		TryToSpawnAnimatronic();
	}

	private void ItemDefinitionDomainReady(ItemDefinitionDomain itemDefinitionDomain)
	{
		_itemDefinitionDomain = itemDefinitionDomain;
		TryToSpawnAnimatronic();
	}

	public void Teardown()
	{
		_masterEventExposer.remove_WorkshopRepairSuccess(WorkshopRepairSuccess);
		_masterEventExposer.remove_WorkshopModifyTabClosed(MasterEventExposerOnWorkshopModifyTabClosed);
		_masterEventExposer.remove_WorkshopModifyTabOpened(MasterEventExposerOnWorkshopModifyTabOpened);
		_masterEventExposer.remove_WorkshopCpuChanged(WorkshopCpuChanged);
		_masterEventExposer.remove_WorkshopSlotDataUpdated(OnWorkshopSlotDataUpdated);
		ClearStage();
		_masterEventExposer = null;
		_currentRequest = null;
		_stageRootTransform = null;
		_spawnCompleteCallback = null;
		_itemDefinitionDomain = null;
	}

	public void ClearStage()
	{
		if (!(_spawnedAnimatronic == null))
		{
			_animatronic3DDomain.ReleaseAnimatronic3D(_spawnedAnimatronic);
			_spawnedAnimatronic.Teardown();
			_spawnedAnimatronic = null;
		}
	}

	public void RequestAnimatronicSpawn(WorkshopEntry workshopEntry)
	{
		_requestedAnimatronic = workshopEntry;
		TryToSpawnAnimatronic();
	}

	private void EvalUpdateStageAnimatronicWearAndTear(List<WorkshopSlotData> datas)
	{
		if (!(_spawnedAnimatronic == null) && _workshopSlotDataModel != null && _workshopSlotDataModel.GetSelectedSlotData() != null)
		{
			_spawnedAnimatronic.SetWearAndTear(_workshopSlotDataModel.GetSelectedSlotData().workshopEntry.GetWearAndTearPercentage());
		}
	}

	private void OnWorkshopSlotDataUpdated(List<WorkshopSlotData> datas)
	{
		EvalUpdateStageAnimatronicWearAndTear(datas);
	}

	private void WorkshopCpuChanged()
	{
		if (!(_spawnedAnimatronic == null))
		{
			_spawnedAnimatronic.SetAnimationTrigger(AnimationTrigger.Lurch, shouldSet: true);
		}
	}

	private void WorkshopCpuMenuClosed()
	{
		if (!(_spawnedAnimatronic == null))
		{
			_spawnedAnimatronic.SetAnimationTrigger(AnimationTrigger.Lurch, shouldSet: false);
			_spawnedAnimatronic.SetAnimationBool(AnimationBool.IsChangingCpu, value: false);
		}
	}

	private void WorkshopCpuMenuOpened()
	{
		if (!(_spawnedAnimatronic == null))
		{
			_spawnedAnimatronic.RaiseAudioEventFromPlushSuit(AudioEventName.WorkshopIdleStop);
			_spawnedAnimatronic.SetAnimationBool(AnimationBool.IsChangingCpu, value: true);
		}
	}

	private void WorkshopModMenuClosed()
	{
		if (!(_spawnedAnimatronic == null))
		{
			_spawnedAnimatronic.SetAudioMute(shouldMute: false);
		}
	}

	private void WorkshopModMenuOpened()
	{
		if (!(_spawnedAnimatronic == null))
		{
			_spawnedAnimatronic.SetAudioMute(shouldMute: true);
		}
	}

	private void WorkshopRepairSuccess()
	{
		_spawnedAnimatronic.TriggerRepairInterpolation();
	}

	private void TryToSpawnAnimatronic()
	{
		if (_animatronic3DDomain != null && _itemDefinitionDomain != null && _requestedAnimatronic != null)
		{
			if (_currentRequest != null)
			{
				_currentRequest.CancelRequest();
			}
			_currentRequest = new CreationRequest(new AnimatronicConfigData(_itemDefinitionDomain.ItemDefinitions.GetCPUById(_requestedAnimatronic.endoskeleton.cpu), _itemDefinitionDomain.ItemDefinitions.GetPlushSuitById(_requestedAnimatronic.endoskeleton.plushSuit), null), _stageRootTransform);
			_currentRequest.OnRequestComplete += AnimatronicSpawnComplete;
			ClearStage();
			_animatronic3DDomain.CreateAnimatronic3D(_currentRequest);
		}
	}

	private void AnimatronicSpawnComplete(CreationRequest request)
	{
		if (request == null)
		{
			return;
		}
		if (request.IsCancelled())
		{
			if (request.Animatronic3D != null)
			{
				_animatronic3DDomain.ReleaseAnimatronic3D(request.Animatronic3D);
			}
			return;
		}
		ClearStage();
		if (request.Animatronic3D == null)
		{
			Debug.LogError("WorkshopStage AnimatronicSpawnComplete - Workshop model for stage didn't load");
			_currentRequest = null;
			_requestedAnimatronic = null;
			_spawnCompleteCallback?.Invoke(request.ConfigData.PlushSuitData.Id);
			return;
		}
		_spawnedAnimatronic = request.Animatronic3D;
		Debug.Log("Doing setup for workshop.");
		_spawnedAnimatronic.Setup(request.ConfigData, AudioMode.Workshop, null);
		_spawnedAnimatronic.SetAnimationMode(AnimationMode.Workshop);
		_spawnedAnimatronic.SetTransformOverrideMode(TransformOverrider.Mode.Workshop);
		_spawnedAnimatronic.SetAnimationTrigger(AnimationTrigger.Idle, shouldSet: true);
		_spawnedAnimatronic.SetWearAndTear(_requestedAnimatronic.GetWearAndTearPercentage());
		_currentRequest = null;
		_requestedAnimatronic = null;
		_spawnCompleteCallback?.Invoke(request.ConfigData.PlushSuitData.Id);
	}

	public void RotateAnimatronic(Vector2 prev, Vector2 curr)
	{
		if (!(_spawnedAnimatronic == null))
		{
			_spawnedAnimatronic.RotateFacingInWorkshop(prev, curr);
		}
	}

	public void ResetAniamtronicRotation()
	{
		if (_spawnedAnimatronic != null)
		{
			_spawnedAnimatronic.ResetFacing();
		}
	}
}
