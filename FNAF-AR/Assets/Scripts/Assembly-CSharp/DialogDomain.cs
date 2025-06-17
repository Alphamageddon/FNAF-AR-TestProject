using UnityEngine;

public class DialogDomain
{
	private GenericTemplateQueue<GameDialogConfig> _genericTemplateQueue;

	private DialogSequencer _dialogSequencer;

	public DialogShower _dialogShower;

	public void Setup(GameAudioDomain gameAudioDomain)
	{
		_dialogShower = new DialogShower(gameAudioDomain);
		_dialogSequencer = new DialogSequencer(new DialogSequencerLoadData
		{
			DialogShower = _dialogShower,
			GenericTemplateQueue = _genericTemplateQueue
		});
	}

	public void Update()
	{
		if (_dialogSequencer != null)
		{
			_dialogSequencer.Update();
		}
	}

	public void RequestDialog(GameDialogConfig gameDialogConfig)
	{
		Debug.Log("Dialog domain received dialog request.");
		if (_genericTemplateQueue == null)
		{
			Debug.LogError("Dialog domain generic template queue is null. somehow.");
		}
		else
		{
			_genericTemplateQueue.QueueConfig(gameDialogConfig);
		}
	}

	public void TearDown()
	{
		if (_genericTemplateQueue != null)
		{
			_genericTemplateQueue.TearDown();
		}
		if (_dialogShower != null)
		{
			_dialogShower.TearDown();
		}
		_dialogSequencer = null;
		_dialogShower = null;
		_genericTemplateQueue = null;
	}

	public DialogDomain()
	{
		_genericTemplateQueue = new GenericTemplateQueue<GameDialogConfig>();
	}
}
