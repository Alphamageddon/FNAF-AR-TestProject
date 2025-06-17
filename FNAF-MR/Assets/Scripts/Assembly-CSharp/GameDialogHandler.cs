public class GameDialogHandler
{
	private DialogDomain _dialogDomain;

	private GameDialogAdapter _gameDialogAdapter;

	public GameDialogHandler(DialogDomain dialogDomain, EventExposer eventExposer)
	{
		_dialogDomain = dialogDomain;
		_gameDialogAdapter = new GameDialogAdapter(eventExposer);
		_gameDialogAdapter.add_OnConfigGenerated(OnConfigGenerated);
	}

	public void TearDown()
	{
		_gameDialogAdapter.remove_OnConfigGenerated(OnConfigGenerated);
		_gameDialogAdapter.Teardown();
	}

	private void OnConfigGenerated(GameDialogConfig config)
	{
		_dialogDomain.RequestDialog(config);
	}
}
