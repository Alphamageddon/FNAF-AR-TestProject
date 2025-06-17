using System;

public class ShutdownHandler
{
	private ShutdownParameters _data;

	public void Setup(ShutdownParameters shutdownData)
	{
		_data = shutdownData;
	}

	public void Teardown()
	{
		_data = null;
	}

	public void ShutdownGame()
	{
		TeardownSingletons();
		TeardownDomains();
		foreach (Action registeredTeardownCallback in _data.RegisteredTeardownCallbacks)
		{
			registeredTeardownCallback();
		}
		_data.RegisteredTeardownCallbacks.Clear();
		ClearDomains();
	}

	private void TeardownSingletons()
	{
	}

	private void TeardownDomains()
	{
		MasterDomain masterDomain = _data.MasterDomainGetter();
		masterDomain.Animatronic3DDomain.Teardown();
		masterDomain.AnimatronicEntityDomain.Teardown();
		masterDomain.AttackSequenceDomain.Teardown();
		masterDomain.CameraEquipmentDomain.Teardown();
		masterDomain.DialogDomain.TearDown();
		masterDomain.GameAudioDomain.Teardown();
		masterDomain.GameUIDomain.Teardown();
		masterDomain.ItemDefinitionDomain.Teardown();
		masterDomain.LocalizationDomain.Teardown();
		masterDomain.LootDomain.Teardown();
		masterDomain.MapEntityDomain.Teardown();
		masterDomain.MasterDataDomain.Teardown();
		masterDomain.PlayerAvatarDomain.Teardown();
		masterDomain.ServerDomain.Teardown();
		masterDomain.StoreDomain.Teardown();
		masterDomain.TheGameDomain.Teardown();
		masterDomain.WorkshopDomain.Teardown();
		masterDomain.GameAssetManagementDomain.Teardown();
		masterDomain.ScavengingEntityDomain.Teardown();
	}

	private void ClearDomains()
	{
		_data.MasterDomainGetter().LootDomain = null;
	}
}
