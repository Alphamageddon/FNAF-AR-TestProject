using System;
using UnityEngine;

public class TouchDetector
{
	private Vector2 _lastPosition;

	private Action<Vector2> _onTouchDetected;

	public TouchDetector(Action<Vector2> onTouchDetected)
	{
		_lastPosition = Vector3.zero;
		_onTouchDetected = onTouchDetected;
	}

	public void Update()
	{
		if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
		{
			if (Input.touchCount <= 0)
			{
				return;
			}
			Touch[] touches = Input.touches;
			for (int i = 0; i < touches.Length; i++)
			{
				Touch touch = touches[i];
				_lastPosition = touch.position;
				if (_onTouchDetected != null && touch.phase == TouchPhase.Began)
				{
					_onTouchDetected(_lastPosition);
				}
			}
		}
		else if ((Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.OSXPlayer) && Input.GetMouseButtonDown(0))
		{
			_lastPosition = Input.mousePosition;
			if (_onTouchDetected != null)
			{
				_onTouchDetected(_lastPosition);
			}
		}
	}
}
