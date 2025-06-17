using System;
using UnityEngine;
using UnityEngine.UI;

public class FlashlightUIComponent : EncounterHUDComponent
{
	private Image _flashlightOn;

	private Image _flashlightCooldown;

	private Button _flashlighButton;

	private Animator _flashlighAnimator;

	private AttackSequenceDomain _attackSequenceDomain;

	private IFlashlight _flashlight;

	private bool _allowed;

	public FlashlightUIComponent(GameObject mainCanvas)
		: base(mainCanvas)
	{
	}

	public void Setup(CameraStateUIActions actions, AttackSequenceDomain attackSequenceDomain, IFlashlight flashlight)
	{
		_flashlighButton.onClick.RemoveAllListeners();
		_flashlighButton.onClick.AddListener(actions.FlashlightButtonTriggered);
		_attackSequenceDomain = attackSequenceDomain;
		_flashlight = flashlight;
		_allowed = true;
	}

	public void Setup(ScavengingStateUIActions actions, AttackSequenceDomain attackSequenceDomain, IFlashlight flashlight)
	{
		_flashlighButton.onClick.RemoveAllListeners();
		_flashlighButton.onClick.AddListener(actions.FlashlightButtonTriggered);
		_attackSequenceDomain = attackSequenceDomain;
		_flashlight = flashlight;
		_allowed = true;
	}

	protected override void CacheAndPopulateComponents()
	{
		_components = new ComponentContainer();
		Type[] onlyCacheTypes = new Type[2]
		{
			typeof(Image),
			typeof(Button)
		};
		_components.CacheComponents(_root, onlyCacheTypes);
		_flashlightOn = _components.TryGetComponent<Image>("FlashlightOn");
		_flashlightCooldown = _components.TryGetComponent<Image>("Fill");
		_flashlighButton = _components.TryGetComponent<Button>("Button_Flashlight");
		_flashlighAnimator = _flashlighButton.GetComponent<Animator>();
	}

	public override void Update()
	{
		if (!_root.activeSelf)
		{
			return;
		}
		_flashlightOn.gameObject.SetActive(_flashlight.IsOn);
		_flashlighAnimator.SetBool("IsOn", _flashlight.IsOn);
		if (_flashlightCooldown != null)
		{
			if (_flashlight.HasEnoughBatteryToActivate())
			{
				_flashlightCooldown.fillAmount = _flashlight.GetCooldownPercent();
			}
			else
			{
				_flashlightCooldown.fillAmount = 0f;
			}
		}
		if (!_flashlight.IsOn && !_flashlight.CanTurnOn())
		{
			if (_flashlighButton != null)
			{
				_flashlighButton.interactable = false;
			}
			return;
		}
		if (_flashlighButton != null)
		{
			_flashlighButton.interactable = !_attackSequenceDomain.IsDisruptionFullyActive();
		}
		if (_flashlighButton.interactable && (Input.GetKeyDown(KeyCode.LeftControl) || Input.GetMouseButtonDown(1)))
		{
			_flashlighButton.onClick.Invoke();
		}
	}

	public override void UpdateVisibility(bool isMaskFullyOff)
	{
		if (!_flashlight.IsFlashlightAvailable)
		{
			_root.SetActive(value: false);
			return;
		}
		bool flag = _attackSequenceDomain.GetEncounterUIConfig() != null && _attackSequenceDomain.GetEncounterUIConfig().UseFlashlight;
		_root.SetActive(flag && isMaskFullyOff);
	}
}
