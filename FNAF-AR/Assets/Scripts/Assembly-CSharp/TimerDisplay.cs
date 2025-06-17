using TMPro;
using UnityEngine;

public class TimerDisplay : MonoBehaviour
{
	public enum TimerDisplayState
	{
		Active = 0,
		Inactive = 1,
		Hidden = 2,
		Flashing = 3
	}

	[SerializeField]
	[Header("Settings")]
	[Tooltip("Hide text or will continue flashing red")]
	public bool HideWhenZero;

	[SerializeField]
	[Tooltip("In Seconds")]
	public float TimeToStartFlashing;

	[SerializeField]
	public float FlashInterval;

	[SerializeField]
	public bool FlashWhenComplete = true;

	[SerializeField]
	[Header("Hookups")]
	public GameObject HideTimerObject;

	[SerializeField]
	public TextMeshProUGUI DisplayTimeText;

	[HideInInspector]
	public long EndTime;

	[HideInInspector]
	public TimerDisplayState CurrentState;

	private EventExposer _eventExposer;

	private void Awake()
	{
		_eventExposer = MasterDomain.GetDomain().eventExposer;
	}

	private void OnDestroy()
	{
		_ = _eventExposer;
		_eventExposer = null;
	}

	public TimerDisplay()
	{
		TimeToStartFlashing = 3.190147E+38f;
		FlashInterval = 0.5f;
		FlashWhenComplete = true;
	}
}
