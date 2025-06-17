using UnityEngine;

public class NetworkAvailabilityChecker
{
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public string connectionMsg;

		public string connectionTitleKey;

		public NetworkAvailabilityChecker _003C_003E4__this;

		internal void _003CPopupDialogIfNecessary_003Eb__0(Localization localization)
		{
			_ = connectionMsg;
			if (_003C_003E4__this._dialog == null)
			{
				if (localization != null)
				{
					_003C_003E4__this._dialog = new GenericDialogData();
					_003C_003E4__this._dialog.title = localization.GetLocalizedString(connectionTitleKey, connectionTitleKey);
					_003C_003E4__this._dialog.message = localization.GetLocalizedString(connectionMsg, connectionMsg);
					_003C_003E4__this._dialog.negativeButtonText = localization.GetLocalizedString("ui_generic_ok", "ui_generic_ok");
					_003C_003E4__this._dialog.negativeButtonAction = Application.Quit;
				}
				else
				{
					_003C_003E4__this._dialog = new GenericDialogData();
					_003C_003E4__this._dialog.title = "CONNECTION LOST!";
					_003C_003E4__this._dialog.message = "SHIT!";
					_003C_003E4__this._dialog.negativeButtonText = "OKIE DOKE.";
					_003C_003E4__this._dialog.negativeButtonAction = Application.Quit;
				}
			}
			_003C_003E4__this._eventExposer.OnNetworkDialogRequestReceived(_003C_003E4__this._dialog);
		}
	}

	private EventExposer _eventExposer;

	private GenericDialogData _dialog;

	private SimpleTimer _checkReconnectStatusDelayTimer;

	private bool _loadingDone;

	private bool _dialogVisible;

	private bool connectionStatus;

	private const float DelayBeforeRecheck = 2f;

	private const string CONNECTION_LOST_MSG_KEY = "ui_dialog_connection_lost_message";

	private const string CONNECTION_LOST_TITLE_KEY = "ui_dialog_connection_lost_title";

	private void OnLoadingDone()
	{
		_loadingDone = true;
	}

	private bool IsServerAvailable()
	{
		return true;
	}

	private void DelayOnFocus(bool isFocus)
	{
		if (isFocus)
		{
			_checkReconnectStatusDelayTimer.StartTimer(2f);
		}
	}

	public void UpdatedConnection(bool connection)
	{
		connectionStatus = connection;
	}

	private void OnYes()
	{
		_dialogVisible = false;
		_checkReconnectStatusDelayTimer.StartTimer(2f);
	}

	private bool DelayTimerIsInProgress()
	{
		if (!_checkReconnectStatusDelayTimer.Started)
		{
			return false;
		}
		if (!_checkReconnectStatusDelayTimer.IsExpired())
		{
			return true;
		}
		_checkReconnectStatusDelayTimer.Reset();
		return false;
	}

	private void PopupDialogIfNecessary(string DebugMessage)
	{
		if (!_dialogVisible)
		{
			_dialogVisible = true;
			_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
			_003C_003Ec__DisplayClass15_._003C_003E4__this = this;
			_003C_003Ec__DisplayClass15_.connectionMsg = "ui_dialog_connection_lost_message";
			_003C_003Ec__DisplayClass15_.connectionTitleKey = "ui_dialog_connection_lost_title";
			if (_loadingDone)
			{
				LocalizationDomain.Instance.Localization.GetInterfaceAsync(_003C_003Ec__DisplayClass15_._003CPopupDialogIfNecessary_003Eb__0);
				return;
			}
			_dialog = new GenericDialogData();
			_dialog.title = "CONNECTION LOST!";
			_dialog.message = "SHIT!";
			_dialog.negativeButtonText = "OKIE DOKE.";
			_dialog.negativeButtonAction = Application.Quit;
			_eventExposer.OnNetworkDialogRequestReceived(_dialog);
		}
	}

	public NetworkAvailabilityChecker(EventExposer eventExposer)
	{
		connectionStatus = true;
		_eventExposer = eventExposer;
		_eventExposer.add_AllOrtonBundlesDownloaded(OnLoadingDone);
		_eventExposer.add_HandleApplicationFocus(DelayOnFocus);
		_checkReconnectStatusDelayTimer = new SimpleTimer();
	}

	public void Update()
	{
		if (DelayTimerIsInProgress())
		{
			return;
		}
		if (Application.internetReachability != NetworkReachability.NotReachable && connectionStatus && IsServerAvailable())
		{
			if (_dialogVisible)
			{
				_eventExposer.OnNetworkDialogRequestRemoved();
				_dialogVisible = false;
			}
		}
		else
		{
			PopupDialogIfNecessary(null);
		}
	}
}
