using System.Collections;
using UnityEngine;

public class Minireena : MonoBehaviour
{
	public enum Orientation
	{
		Left = 0,
		Right = 1
	}

	public bool editorMode;

	public Camera targetCamera;

	public Orientation orientation;

	public float verticalOffset;

	public float horizontalOffset;

	public float distanceOffset;

	public float timeTillJumpscare;

	private Vector3 _worldPoint;

	private Animator _animator;

	private static readonly int ClimbId = Animator.StringToHash("Climb");

	private static readonly int FallId = Animator.StringToHash("Fall");

	private static readonly int JumpscareId = Animator.StringToHash("Jumpscare");

	private static readonly int HideId = Animator.StringToHash("Hide");

	private const string JumpscareCoroutine = "TimeTillJumpscare";

	private bool _initialized;

	private float _climbSpeed;

	private bool _isHidden;

	private int _pixelWidth;

	private int _pixelHeight;

	[Header("Debug Toggles")]
	public bool DoClimb;

	public bool DoFall;

	public float SpawnTime { get; set; }

	public float ShakeTolerance { get; set; }

	public float CurrentToleranceModifier { get; set; }

	public float PreviousToleranceModifier { get; set; }

	private void Init()
	{
		_pixelWidth = targetCamera.pixelWidth;
		_pixelHeight = targetCamera.pixelHeight;
		MoveToEdge();
		_animator = GetComponent<Animator>();
		_initialized = true;
	}

	private void Update()
	{
		if (editorMode)
		{
			MoveToEdge();
		}
		if (DoClimb)
		{
			DoClimb = false;
			Climb();
		}
		if (DoFall)
		{
			DoFall = false;
			Fall();
		}
	}

	public void Climb()
	{
		if (!_initialized)
		{
			Init();
		}
		base.gameObject.SetActive(value: false);
		MoveToEdge();
		base.gameObject.SetActive(value: true);
		_animator.speed = _climbSpeed;
		_animator.ResetTrigger(FallId);
		_animator.ResetTrigger(ClimbId);
		_animator.ResetTrigger(JumpscareId);
		_animator.SetTrigger(ClimbId);
		_isHidden = false;
		base.gameObject.SetActive(value: true);
		SpawnTime = Time.time;
		StartCoroutine("TimeTillJumpscare", timeTillJumpscare);
	}

	public void Fall()
	{
		StopCoroutine("TimeTillJumpscare");
		_animator.speed = 1f;
		_animator.ResetTrigger(ClimbId);
		_animator.ResetTrigger(JumpscareId);
		_animator.SetTrigger(FallId);
		_isHidden = true;
	}

	public void Jumpscare()
	{
		ResetPosition();
		_animator.speed = 1f;
		_animator.ResetTrigger(ClimbId);
		_animator.SetTrigger(JumpscareId);
	}

	public void Hide()
	{
		if (_initialized)
		{
			StopCoroutine("TimeTillJumpscare");
			MoveToEdge();
			_animator.speed = 1f;
			_animator.ResetTrigger(JumpscareId);
			_animator.ResetTrigger(ClimbId);
			_animator.ResetTrigger(FallId);
			_animator.SetTrigger(HideId);
			_isHidden = true;
			base.gameObject.SetActive(value: false);
		}
	}

	public void SetClimbSpeed(float speed)
	{
		_climbSpeed = speed;
	}

	private void MoveToEdge()
	{
		float x = ((orientation == Orientation.Left) ? 0f : ((float)_pixelWidth + horizontalOffset * (float)_pixelWidth));
		float y = verticalOffset * (float)_pixelHeight;
		_worldPoint = targetCamera.ScreenToWorldPoint(new Vector3(x, y, distanceOffset));
		base.transform.position = _worldPoint;
	}

	private void ResetPosition()
	{
		base.transform.localPosition = Vector3.zero;
	}

	private IEnumerator TimeTillJumpscare(float time)
	{
		yield return new WaitForSeconds(time);
		Jumpscare();
	}

	public bool IsHidden()
	{
		return _isHidden;
	}

	public float TimeSinceSpawn()
	{
		return SpawnTime - Time.time;
	}

	public Minireena()
	{
		timeTillJumpscare = 4f;
		_climbSpeed = 1f;
		_isHidden = true;
	}
}
