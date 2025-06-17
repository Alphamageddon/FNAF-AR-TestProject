public class MapEntityInteractionMutex
{
	private const float TIMEOUT = 4f;

	private EventExposer _eventExposer;

	private bool _allowNewInteractions = true;

	private float _timeoutTicker;

	public bool AllowNewInteractions => _allowNewInteractions;

	public void Setup(EventExposer eventExposer)
	{
		_eventExposer = eventExposer;
		eventExposer.add_UnityFrameUpdate(EventExposer_OnFrame);
	}

	public void Teardown()
	{
		_eventExposer.remove_UnityFrameUpdate(EventExposer_OnFrame);
	}

	public void EventExposer_OnFrame(float dt)
	{
		if (!_allowNewInteractions)
		{
			_timeoutTicker -= dt;
			if (!(_timeoutTicker > 0f))
			{
				_allowNewInteractions = true;
				_timeoutTicker = 0f;
			}
		}
	}

	public void OnInteractionDisplayClosed()
	{
		_allowNewInteractions = true;
		_timeoutTicker = 0f;
	}

	public void OnInteractionDisplayWillOpen()
	{
		_allowNewInteractions = false;
		_timeoutTicker = 4f;
	}
}
