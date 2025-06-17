using UnityEngine;

public class VisibilityAlterEffect
{
	private EventExposer _masterEventExposer;

	private AttackAnimatronicExternalSystems _systems;

	private VisibilityAlterEffectData _settings;

	private Animatronic3D _animatronic;

	private GameObject _fakeEndoEffect;

	private bool _isActive;

	public bool ShouldBeActiveWhileCircling => _settings.WhileCircling;

	public bool ShouldBeActiveWhilePaused => _settings.WhilePaused;

	public void StartSystem(VisibilityAlterEffectData settings, Animatronic3D animatronic)
	{
		if (!(animatronic == null))
		{
			_animatronic = animatronic;
			GameObject gameObject = Resources.Load("FakeEndo/EndoCard_Visible") as GameObject;
			if (gameObject != null)
			{
				_fakeEndoEffect = Object.Instantiate(gameObject);
				_fakeEndoEffect.SetActive(value: false);
				_animatronic.ReparentUnderAnimatronic(_fakeEndoEffect.transform);
			}
			_settings = settings;
		}
	}

	public void StopSystem()
	{
		_settings = null;
		if (_fakeEndoEffect != null)
		{
			Object.Destroy(_fakeEndoEffect);
		}
		_fakeEndoEffect = null;
	}

	public void StartEffect()
	{
		_isActive = true;
	}

	public void StopEffect()
	{
		_isActive = false;
	}

	public VisibilityAlterEffect(EventExposer masterEventExposer)
	{
		_masterEventExposer = masterEventExposer;
	}

	public void Setup(AttackAnimatronicExternalSystems systems)
	{
		_systems = systems;
	}

	public void Update()
	{
		if (_fakeEndoEffect == null)
		{
			return;
		}
		_fakeEndoEffect.SetActive(_isActive);
		if (_isActive)
		{
			if (_systems.CameraStableTransform == null)
			{
				Debug.Log("CameraStableTransform NULLLLL");
				return;
			}
			Debug.Log("Updating Position!");
			Vector3 vector = _animatronic.GetPosition() - _systems.CameraStableTransform.position;
			Vector3 position = _systems.CameraStableTransform.position + vector.normalized * _settings.Distance + Vector3.up * _settings.YOffset;
			_fakeEndoEffect.transform.position = position;
			_fakeEndoEffect.transform.LookAt(_systems.CameraStableTransform.position);
		}
	}

	public void Teardown()
	{
		_masterEventExposer = null;
		_animatronic = null;
		_fakeEndoEffect = null;
	}
}
