using System;
using System.Collections;
using UnityEngine;

public class PhantomFxController : MonoBehaviour
{
	public enum States
	{
		Null = 0,
		Pause = 1,
		Manifest = 2,
		Walking = 3,
		Burning = 4,
		Overload = 5,
		OverloadExit = 6,
		Reposition = 7,
		Shutdown = 8,
		Jumpscare = 9,
		Haywire = 10
	}

	[Header("Visual Effects")]
	public GameObject manifestVfx;

	public GameObject burnVfx;

	public GameObject repositionVfx;

	public GameObject shutdownVfx;

	public GameObject burnDistortion;

	[Header("Animatronic")]
	public GameObject mesh;

	public Animator animator;

	[Header("VFX Duration")]
	public ParticleSystemDuration manifestVfxDuration;

	public ParticleSystemDuration repositionVfxDuration;

	public ParticleSystemDuration shutdownVfxDuration;

	[SerializeField]
	[Header("Debug Controls")]
	private bool editorMode;

	[SerializeField]
	private States editorState;

	private States _state;

	private bool _burning;

	private bool _reposition;

	private float _targetWeight;

	private float _smoothTime;

	private float _animSpeed;

	private float _emissionRate;

	private ParticleSystem _burnParticleSystem;

	private ParticleSystem.EmissionModule _burnParticleEmission;

	private float _currentAnimLayerWeight;

	private float _animLayerBlendVelocity;

	private static readonly int HitReact;

	private static readonly int Shutdown;

	private static readonly int Jumpscare;

	private static readonly int Overload;

	private static readonly int OverloadEnd;

	private Action OnMeshToggled;

	private void add_OnMeshToggled(Action value)
	{
		OnMeshToggled = (Action)Delegate.Combine(OnMeshToggled, value);
	}

	private void remove_OnMeshToggled(Action value)
	{
		OnMeshToggled = (Action)Delegate.Remove(OnMeshToggled, value);
	}

	public void RegisterForMeshToggle(Action callback)
	{
		add_OnMeshToggled(callback);
	}

	public void UnregisterForMeshToggle(Action callback)
	{
		remove_OnMeshToggled(callback);
	}

	public float GetAnimationSpeedModifier()
	{
		return _animSpeed;
	}

	public void SetState(States newState)
	{
		_state = newState;
		ResetFx();
		switch (newState)
		{
		case States.Pause:
			_burning = false;
			_reposition = false;
			_targetWeight = 0f;
			_smoothTime = 0f;
			_animSpeed = 1f;
			_emissionRate = 0f;
			break;
		case States.Manifest:
			_burning = false;
			_reposition = false;
			_targetWeight = 0f;
			_smoothTime = 0f;
			_animSpeed = 1f;
			_emissionRate = 0f;
			break;
		case States.Walking:
			_burning = false;
			_reposition = false;
			_targetWeight = 0f;
			_smoothTime = 1f;
			_animSpeed = 1f;
			_emissionRate = 0f;
			break;
		case States.Burning:
			_burning = true;
			_reposition = false;
			_targetWeight = 1f;
			_smoothTime = 1f;
			_animSpeed = 0.5f;
			_emissionRate = 3f;
			break;
		case States.Overload:
			_burning = false;
			_reposition = false;
			_targetWeight = 0f;
			_smoothTime = 0f;
			_animSpeed = 1f;
			_emissionRate = 0f;
			break;
		case States.OverloadExit:
			_burning = false;
			_reposition = false;
			_targetWeight = 0f;
			_smoothTime = 0f;
			_animSpeed = 1f;
			_emissionRate = 0f;
			break;
		case States.Reposition:
			_burning = false;
			_reposition = true;
			_targetWeight = 0f;
			_smoothTime = 0f;
			_animSpeed = 1f;
			_emissionRate = 0f;
			break;
		case States.Shutdown:
			_burning = false;
			_reposition = false;
			_targetWeight = 0f;
			_smoothTime = 0f;
			_animSpeed = 1f;
			_emissionRate = 0f;
			break;
		case States.Jumpscare:
			_burning = false;
			_reposition = false;
			_targetWeight = 0f;
			_smoothTime = 0f;
			_animSpeed = 1f;
			_emissionRate = 0f;
			break;
		default:
			ResetFx();
			break;
		}
		ExecuteFx();
		ExecuteStateOnEnter();
	}

	private void ResetFx()
	{
		_burning = false;
		_reposition = false;
		_targetWeight = 0f;
		_smoothTime = 0f;
		_animSpeed = 1f;
		_emissionRate = 0f;
	}

	private void SetStateFxConfig()
	{
	}

	private void ExecuteStateOnEnter()
	{
		switch (_state)
		{
		case States.Pause:
			mesh.SetActive(value: false);
			manifestVfx.SetActive(value: false);
			repositionVfx.SetActive(value: false);
			shutdownVfx.SetActive(value: false);
			burnVfx.SetActive(value: false);
			break;
		case States.Manifest:
			animator.ResetTrigger("shutdown");
			animator.ResetTrigger("jumpscare");
			animator.gameObject.SetActive(value: false);
			mesh.SetActive(value: false);
			manifestVfx.SetActive(value: true);
			StartCoroutine(ToggleAnimator(status: true, 1f));
			StartCoroutine(ToggleMesh(status: true, 1f));
			StartCoroutine(TurnOffManifestVfx(2f));
			break;
		case States.Walking:
			animator.ResetTrigger("hitReact");
			break;
		case States.Burning:
			animator.SetTrigger("hitReact");
			break;
		case States.Overload:
			animator.ResetTrigger("haywire");
			animator.gameObject.SetActive(value: true);
			mesh.SetActive(value: true);
			animator.SetTrigger("overload");
			break;
		case States.OverloadExit:
			animator.gameObject.SetActive(value: true);
			mesh.SetActive(value: true);
			animator.SetTrigger("overloadEnd");
			break;
		case States.Reposition:
			animator.ResetTrigger("overload");
			animator.ResetTrigger("overloadEnd");
			StartCoroutine(ToggleMesh(status: false, 0.1f));
			StartCoroutine(ToggleAnimator(status: false, 0.1f));
			break;
		case States.Shutdown:
			animator.gameObject.SetActive(value: true);
			mesh.SetActive(value: true);
			animator.SetTrigger("shutdown");
			StartCoroutine(TurnOnShutdownVfx(3f));
			StartCoroutine(ToggleMesh(status: false, 3f));
			break;
		case States.Jumpscare:
			animator.ResetTrigger("haywire");
			animator.SetTrigger("jumpscare");
			mesh.SetActive(value: true);
			animator.gameObject.SetActive(value: true);
			break;
		case States.Haywire:
			animator.SetTrigger("haywire");
			animator.gameObject.SetActive(value: true);
			mesh.SetActive(value: true);
			break;
		default:
			animator.gameObject.SetActive(value: true);
			mesh.SetActive(value: true);
			shutdownVfx.SetActive(value: false);
			break;
		}
	}

	private void ExecuteFx()
	{
		burnDistortion.SetActive(_burning);
		burnVfx.SetActive(_burning);
		repositionVfx.SetActive(_reposition);
		animator.speed = _animSpeed;
		_burnParticleEmission.rateOverTime = _emissionRate;
	}

	private void Start()
	{
		editorMode = false;
		editorState = States.Pause;
		_burnParticleSystem = burnVfx.GetComponent<ParticleSystem>();
		_burnParticleEmission = _burnParticleSystem.emission;
		_state = States.Pause;
		ResetFx();
		ExecuteFx();
		ExecuteStateOnEnter();
	}

	private void Update()
	{
		if (editorMode && _state != editorState)
		{
			SetState(editorState);
		}
		animator.SetLayerWeight(1, GetLayerBlendWeight(_targetWeight, _smoothTime));
	}

	private IEnumerator TurnOffManifestVfx(float seconds)
	{
		yield return new WaitForSeconds(seconds);
		manifestVfx.SetActive(value: false);
		yield return null;
	}

	private IEnumerator TurnOnShutdownVfx(float seconds)
	{
		yield return new WaitForSeconds(seconds);
		shutdownVfx.SetActive(value: true);
		_burnParticleEmission.rateOverTime = _emissionRate;
		yield return null;
	}

	private IEnumerator ToggleAnimator(bool status, float seconds)
	{
		Debug.Log("toggled animator for status " + status + " and seconds " + seconds);
		yield return new WaitForSeconds(seconds);
		animator.gameObject.SetActive(status);
		yield return null;
	}

	private IEnumerator ToggleMesh(bool status, float seconds)
	{
		yield return new WaitForSeconds(seconds);
		mesh.SetActive(status);
		if (OnMeshToggled != null)
		{
			OnMeshToggled();
		}
		_burnParticleEmission.rateOverTime = _emissionRate;
	}

	private float GetLayerBlendWeight(float targetWeight, float smoothTime)
	{
		return Mathf.SmoothDamp(animator.GetLayerWeight(1), targetWeight, ref _animLayerBlendVelocity, smoothTime);
	}

	static PhantomFxController()
	{
		HitReact = Animator.StringToHash("hitReact");
		Shutdown = Animator.StringToHash("shutdown");
		Jumpscare = Animator.StringToHash("jumpscare");
		Overload = Animator.StringToHash("overload");
		OverloadEnd = Animator.StringToHash("overloadEnd");
		HitReact = Animator.StringToHash("hitReact");
		Shutdown = Animator.StringToHash("shutdown");
		Jumpscare = Animator.StringToHash("jumpscare");
		Overload = Animator.StringToHash("overload");
		OverloadEnd = Animator.StringToHash("overloadEnd");
	}
}
