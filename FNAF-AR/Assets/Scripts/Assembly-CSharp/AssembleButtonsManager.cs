public class AssembleButtonsManager
{
	private readonly AssembleButtonsManagerLoadData _data;

	private readonly RemnantAssemblyButtonHandler _remnantAssemblyButtonHandler;

	private ModAssemblyButtonHandler _modAssemblyButtonHandler;

	private PlushSuitAssemblyButtonHandler _plushSuitAssemblyButtonHandler;

	private CpuAssemblyButtonHandler _cpuAssemblyButtonHandler;

	private IconLookup _iconLookup;

	private Localization _localization;

	public AssembleButtonsManager(AssembleButtonsManagerLoadData data)
	{
		_data = data;
		_remnantAssemblyButtonHandler = new RemnantAssemblyButtonHandler(new RemnantAssemblyButtonHandlerLoadData
		{
			WorkshopSlotDataModel = _data.WorkshopSlotDataModel,
			EssenceSlotTotalDisplayText = _data.EssenceSlotTotalDisplayText,
			EssenceButton = data.EssenceAssemblyButton,
			EventExposer = _data.EventExposer
		});
		data.GameAssetManagementDomain.IconLookupAccess.GetInterfaceAsync(IconsReady);
		LocalizationDomain.Instance.Localization.GetInterfaceAsync(LocalizationReady);
	}

	private void LocalizationReady(Localization obj)
	{
		_localization = obj;
		TryInitHandlers();
	}

	private void IconsReady(IconLookup obj)
	{
		_iconLookup = obj;
		TryInitHandlers();
	}

	private void TryInitHandlers()
	{
		if (_iconLookup != null)
		{
			if (_plushSuitAssemblyButtonHandler == null)
			{
				_plushSuitAssemblyButtonHandler = new PlushSuitAssemblyButtonHandler(new PlushSuitAssemblyButtonHandlerLoadData
				{
					IconLookup = _iconLookup,
					WorkshopSlotDataModel = _data.WorkshopSlotDataModel,
					ItemDefinitions = _data.ItemDefinitions,
					EventExposer = _data.EventExposer,
					PlushAssemblyButton = _data.PlushAssemblyButton
				});
			}
			if (_cpuAssemblyButtonHandler == null)
			{
				_cpuAssemblyButtonHandler = new CpuAssemblyButtonHandler(new CpuAssemblyButtonHandlerLoadData
				{
					IconLookup = _iconLookup,
					ItemDefinitions = _data.ItemDefinitions,
					EventExposer = _data.EventExposer,
					WorkshopSlotDataModel = _data.WorkshopSlotDataModel,
					CpuAssemblyButton = _data.CpuAssemblyButton
				});
			}
			if (_localization != null && _modAssemblyButtonHandler == null)
			{
				_modAssemblyButtonHandler = new ModAssemblyButtonHandler(new ModAssemblyButtonHandlerLoadData
				{
					ItemDefinitions = _data.ItemDefinitions,
					IconLookup = _iconLookup,
					Localization = _localization,
					WorkshopSlotDataModel = _data.WorkshopSlotDataModel,
					EventExposer = _data.EventExposer,
					ModAssembleButtons = _data.ModAssembleButtons,
					ServerGameUiDataModel = _data.ServerGameUiDataModel
				});
			}
		}
	}

	public void Update()
	{
		if (_plushSuitAssemblyButtonHandler != null)
		{
			_plushSuitAssemblyButtonHandler.Update();
		}
		if (_cpuAssemblyButtonHandler != null)
		{
			_cpuAssemblyButtonHandler.Update();
		}
		if (_modAssemblyButtonHandler != null)
		{
			_modAssemblyButtonHandler.Update();
		}
		if (_remnantAssemblyButtonHandler != null)
		{
			_remnantAssemblyButtonHandler.Update();
		}
	}
}
