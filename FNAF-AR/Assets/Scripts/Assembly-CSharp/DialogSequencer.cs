using PaperPlaneTools;

public class DialogSequencer
{
	private readonly DialogSequencerLoadData _loadData;

	private void TryShowDialog()
	{
		if (_loadData.GenericTemplateQueue.HasContext() && !AlertManager.Instance.IsShowingAlert())
		{
			_loadData.DialogShower.ShowDialog(_loadData.GenericTemplateQueue.DequeueNextContext());
		}
	}

	public DialogSequencer(DialogSequencerLoadData dialogSequencerLoadData)
	{
		_loadData = dialogSequencerLoadData;
	}

	public void Update()
	{
		TryShowDialog();
	}
}
