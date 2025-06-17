using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIGestureHandler : MonoBehaviour, IDragHandler, IEventSystemHandler, IBeginDragHandler
{
	public enum Mode
	{
		None = 0,
		Drag = 1,
		Pinch = 2,
		Rotate = 3
	}

	public enum Touches
	{
		One = 1,
		Two = 2
	}

	private const float DEFAULT_MOVE_SPEED = 0.25f;

	private const float DEFAULT_SCALE_SPEED = 0.5f;

	private const float DEFAULT_MIN_ROTATE_GESTUREANGLE = 6f;

	[SerializeField]
	private List<Mode> _modes;

	[SerializeField]
	private float _moveSpeed = 0.25f;

	[SerializeField]
	private float _scaleSpeed;

	[SerializeField]
	private float _minRotateGestureAngle = 6f;

	private MasterDomain _masterDomain;

	private readonly List<Vector2> _prevTouchesList;

	private readonly List<Vector2> _currTouchesList;

	private Mode _currTouchMode;

	public List<Mode> Modes => _modes;

	public float MoveSpeed => _moveSpeed;

	public float ScaleSpeed => _scaleSpeed;

	private void Start()
	{
		_masterDomain = MasterDomain.GetDomain();
		_masterDomain.eventExposer.add_GestureResetEvent(GestureResetEventHandler);
	}

	private void OnDestroy()
	{
		_masterDomain.eventExposer.remove_GestureResetEvent(GestureResetEventHandler);
	}

	private void Update()
	{
		if (Input.touchCount < 1)
		{
			_currTouchMode = Mode.None;
		}
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		new List<Vector2>();
		_prevTouchesList.Clear();
		Touch[] touches = Input.touches;
		foreach (Touch touch in touches)
		{
			_prevTouchesList.Add(touch.position);
		}
	}

	public void OnDrag(PointerEventData eventData)
	{
		List<Vector2> list = new List<Vector2>();
		Touch[] touches = Input.touches;
		foreach (Touch touch in touches)
		{
			list.Add(touch.position);
		}
		if (list.Count == 1)
		{
			_currTouchesList.Clear();
			_currTouchesList.Add(list[0]);
			_masterDomain.eventExposer.OnGestureTouchEvent(_prevTouchesList, _currTouchesList);
			_prevTouchesList.Clear();
			_prevTouchesList.Add(_currTouchesList[0]);
		}
		else if (list.Count == 0)
		{
			_currTouchesList.Clear();
			_currTouchesList.Add(Input.mousePosition);
			_masterDomain.eventExposer.OnGestureTouchEvent(_prevTouchesList, _currTouchesList);
			_prevTouchesList.Clear();
			_prevTouchesList.Add(_currTouchesList[0]);
		}
		else if (list.Count == 2)
		{
			_currTouchesList.Clear();
			_currTouchesList.Add(list[0]);
			_currTouchesList.Add(list[1]);
			_masterDomain.eventExposer.OnGestureTouchEvent(_prevTouchesList, _currTouchesList);
			_prevTouchesList.Clear();
			_prevTouchesList.Add(_currTouchesList[0]);
			_prevTouchesList.Add(_currTouchesList[1]);
		}
	}

	private void ResetTouchMode()
	{
		_currTouchMode = Mode.None;
	}

	private void ClearTouches()
	{
		_currTouchesList.Clear();
		_prevTouchesList.Clear();
	}

	private void GestureResetEventHandler()
	{
		_currTouchMode = Mode.None;
		ClearTouches();
	}

	public UIGestureHandler()
	{
		_modes = new List<Mode>();
		_moveSpeed = 1f;
		_scaleSpeed = 0.5f;
		_minRotateGestureAngle = 6f;
		_prevTouchesList = new List<Vector2>();
		_currTouchesList = new List<Vector2>();
	}
}
