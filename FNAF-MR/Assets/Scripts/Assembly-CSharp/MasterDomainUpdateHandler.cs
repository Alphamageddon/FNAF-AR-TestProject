public class MasterDomainUpdateHandler
{
	private MasterDomain _masterDomain;

	public void Setup(MasterDomain masterDomain)
	{
		_masterDomain = masterDomain;
	}

	public void Teardown()
	{
		_masterDomain = null;
	}

	public void OnUnityFrameUpdate(float dt)
	{
		UpdateAlways();
		UpdateAlwaysDt(dt);
		if (IsLoading())
		{
			UpdateLoading();
		}
		else
		{
			UpdatePostLoading(dt);
		}
		_masterDomain.eventExposer.OnUnityFrameUpdate(dt);
	}

	private bool IsLoading()
	{
		return false;
	}

	private void UpdateAlways()
	{
		_masterDomain.GameAssetManagementDomain.Update();
		_masterDomain.ServerDomain.Update();
		_masterDomain.GameUIDomain.Update();
		_masterDomain.TheGameDomain.Update();
		_masterDomain.DialogDomain.Update();
	}

	private void UpdateAlwaysDt(float time)
	{
		_masterDomain.ServerDomain.Update(time);
	}

	private void UpdateLoading()
	{
	}

	private void UpdatePostLoading(float dt)
	{
		_masterDomain.AnimatronicEntityDomain.Update();
		_masterDomain.CameraEquipmentDomain.Update();
		_masterDomain.AttackSequenceDomain.Update();
	}
}
