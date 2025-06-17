using UnityEngine;

public class DialogShower
{
	private class ShownDialog
	{
		public GameDialogConfig gameDialogConfig;

		public PrefabInstance prefabInstance;

		public ShownDialog(GameDialogConfig gameDialogConfig, PrefabInstance prefabInstance)
		{
			this.gameDialogConfig = gameDialogConfig;
			this.prefabInstance = prefabInstance;
		}

		public void TearDown()
		{
			prefabInstance.Clear();
			prefabInstance = null;
		}
	}

	private readonly DialogConfigurer _dialogConfigurer;

	private ShownDialog _shownDialog;

	private AudioPlayer _audioPlayer;

	private int _backButtonId;

	public DialogShower(GameAudioDomain gameAudioDomain)
	{
		_dialogConfigurer = new DialogConfigurer();
		if (gameAudioDomain != null)
		{
			b__5_0(gameAudioDomain.AudioPlayer);
		}
	}

	private void CloseDialog()
	{
		Debug.LogWarning("DialogShower is closing dialog");
		if (_shownDialog == null)
		{
			Debug.LogWarning("DialogShower ShownDialog is null");
			return;
		}
		if (_shownDialog.gameDialogConfig.OnDismissCallback != null)
		{
			_shownDialog.gameDialogConfig.OnDismissCallback();
		}
		ClearShownDialog();
	}

	private void ClearShownDialog()
	{
		_shownDialog.TearDown();
		_shownDialog = null;
	}

	public void ShowDialog(GameDialogConfig gameDialogConfig)
	{
		PrefabInstance prefabInstance = null;
		if (PrefabBuilder.BuildPrefab(out prefabInstance, gameDialogConfig.ResourcePath, gameDialogConfig.AttachParentName))
		{
			_dialogConfigurer.ConfigureDialog(prefabInstance, gameDialogConfig, CloseDialog);
			prefabInstance.add_RequestClose(CloseDialog);
			_shownDialog = new ShownDialog(gameDialogConfig, prefabInstance);
			if (gameDialogConfig.PlayAudioOnShow && _audioPlayer != null)
			{
				_audioPlayer.RaiseGameEventForMode(gameDialogConfig.AudioEventName, gameDialogConfig.AudioMode);
			}
			_ = gameDialogConfig.EnableAndroidBackButton;
		}
	}

	public bool IsShowingDialog()
	{
		return _shownDialog != null;
	}

	public void TearDown()
	{
		if (_shownDialog != null)
		{
			ClearShownDialog();
		}
	}

	private void b__5_0(AudioPlayer audioPlayer)
	{
		_audioPlayer = audioPlayer;
	}
}
