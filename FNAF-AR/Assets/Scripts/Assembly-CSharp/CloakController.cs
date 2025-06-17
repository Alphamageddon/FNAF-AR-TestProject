using System;
using UnityEngine;

public class CloakController
{
	private readonly CloakSettings _settings;

	private float _distance;

	private Vector3 _direction;

	private CloakGroup _bodyCloak;

	private CloakGroup _eyeCloak;

	private bool _hasOpenedShockWindow;

	public event Action OnShockWindowOpened;

	public void SetCloakState(bool cloakEnabled)
	{
		_bodyCloak.BeginTime = -1f;
		_bodyCloak.Percent = ((!cloakEnabled) ? 0f : 1f);
	}

	public bool BodyFullyCloaked()
	{
		return _bodyCloak.Percent >= 1f;
	}

	public bool EyesFullyCloaked()
	{
		return _eyeCloak.Percent >= 1f;
	}

	public void BeginCloak()
	{
		_bodyCloak.BeginTime = Time.time;
		_bodyCloak.IsCloaking = true;
		_hasOpenedShockWindow = false;
		if (_settings.ShouldUpdateEveryTime)
		{
			CalculateDirectionAndDistance();
		}
	}

	public void BeginDecloak(bool shouldOpenShock = true)
	{
		_bodyCloak.BeginTime = Time.time;
		_bodyCloak.IsCloaking = false;
		_hasOpenedShockWindow = !shouldOpenShock;
		if (_settings.ShouldUpdateEveryTime)
		{
			CalculateDirectionAndDistance();
		}
	}

	public Vector3 GetCloakPlanePosition()
	{
		UpdateCloakPercent();
		return CalculateCloakPlanePosition();
	}

	public void SetEyeCloakState(bool eyeCloakEnabled)
	{
		_eyeCloak.BeginTime = -1f;
		_eyeCloak.Percent = ((!eyeCloakEnabled) ? 0f : 1f);
	}

	public void BeginEyeCloak()
	{
		_eyeCloak.BeginTime = Time.time;
		_eyeCloak.IsCloaking = true;
		if (_settings.ShouldUpdateEveryTime)
		{
			CalculateDirectionAndDistance();
		}
	}

	public void BeginEyeDecloak()
	{
		_eyeCloak.BeginTime = Time.time;
		_eyeCloak.IsCloaking = false;
		if (_settings.ShouldUpdateEveryTime)
		{
			CalculateDirectionAndDistance();
		}
	}

	public Vector3 GetEyeCloakPlanePosition()
	{
		return CalculateEyeCloakPlanePosition();
	}

	private void CalculateDirectionAndDistance()
	{
		Vector3 vector = _settings.CloakedRevealPlanePosition - _settings.DecloakedRevealPlanePosition;
		_distance = vector.magnitude;
		_direction = vector / _distance;
	}

	private void UpdateCloakPercent()
	{
		if (_settings.ShouldHideEyes)
		{
			BeginEyeCloak();
			_settings.ShouldHideEyes = false;
		}
		if (_settings.ShouldShowEyes)
		{
			BeginEyeDecloak();
			_settings.ShouldShowEyes = false;
		}
		if (_settings.ShouldCloak)
		{
			BeginCloak();
			_settings.ShouldCloak = false;
		}
		if (_settings.ShouldDecloak)
		{
			BeginDecloak();
			_settings.ShouldDecloak = false;
		}
		UpdateBodyCloak();
		UpdateEyeCloak();
	}

	private void UpdateBodyCloak()
	{
		if (_bodyCloak.BeginTime < 0f)
		{
			return;
		}
		float num = (_bodyCloak.IsCloaking ? _settings.CloakTime : _settings.DecloakTime);
		if (num == 0f)
		{
			CompleteCloakOrDecloak(_bodyCloak);
			return;
		}
		if (!_bodyCloak.IsCloaking && !_hasOpenedShockWindow && Time.time - _bodyCloak.BeginTime >= _settings.ShockWindowOpenTime)
		{
			_hasOpenedShockWindow = true;
			Debug.Log("Shock window is opened!");
			this.OnShockWindowOpened?.Invoke();
		}
		float num2 = Time.time - _bodyCloak.BeginTime;
		_bodyCloak.Percent = num2 / num;
		Mathf.Clamp(_bodyCloak.Percent, 0f, 1f);
		if (_bodyCloak.Percent >= 1f)
		{
			Debug.Log("Fully cloaked/decloaked boss!");
			CompleteCloakOrDecloak(_bodyCloak);
		}
		else if (!_bodyCloak.IsCloaking)
		{
			_bodyCloak.Percent = 1f - _bodyCloak.Percent;
		}
	}

	private void UpdateEyeCloak()
	{
		if (_eyeCloak.BeginTime < 0f)
		{
			return;
		}
		float num = (_eyeCloak.IsCloaking ? _settings.CloakTime : _settings.DecloakTime);
		if (num == 0f)
		{
			CompleteCloakOrDecloak(_eyeCloak);
			return;
		}
		float num2 = Time.time - _eyeCloak.BeginTime;
		_eyeCloak.Percent = num2 / num;
		Mathf.Clamp(_eyeCloak.Percent, 0f, 1f);
		if (_eyeCloak.Percent >= 1f)
		{
			CompleteCloakOrDecloak(_eyeCloak);
		}
		else if (!_eyeCloak.IsCloaking)
		{
			_eyeCloak.Percent = 1f - _eyeCloak.Percent;
		}
	}

	private static void CompleteCloakOrDecloak(CloakGroup cloakGroup)
	{
		cloakGroup.BeginTime = -1f;
		cloakGroup.Percent = (cloakGroup.IsCloaking ? 1f : 0f);
	}

	private Vector3 CalculateEyeCloakPlanePosition()
	{
		Vector3 vector = _direction * _distance * _eyeCloak.Percent;
		return _settings.DecloakedRevealPlanePosition + vector;
	}

	private Vector3 CalculateCloakPlanePosition()
	{
		Vector3 vector = _direction * _distance * _bodyCloak.Percent;
		return _settings.DecloakedRevealPlanePosition + vector;
	}

	public CloakController(CloakSettings settings)
	{
		_bodyCloak = new CloakGroup();
		_eyeCloak = new CloakGroup();
		_settings = settings;
		_bodyCloak.Percent = 0f;
		_bodyCloak.BeginTime = -1f;
		_eyeCloak.Percent = 0f;
		_eyeCloak.BeginTime = -1f;
		CalculateDirectionAndDistance();
	}
}
