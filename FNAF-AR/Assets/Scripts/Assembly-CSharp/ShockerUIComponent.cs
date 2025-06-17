using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShockerUIComponent : EncounterHUDComponent
{
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public CameraStateUIActions actions;

		internal void _003CSetup_003Eb__0(BaseEventData listener)
		{
			actions.ShockButtonTriggered();
		}

		internal void _003CSetup_003Eb__1(BaseEventData listener)
		{
			actions.ShockButtonReleased();
		}
	}

	private sealed class _003C_003Ec__DisplayClass10_0Scavenge
	{
		public ScavengingStateUIActions actions;

		internal void _003CSetup_003Eb__0(BaseEventData listener)
		{
			actions.ShockButtonTriggered();
		}

		internal void _003CSetup_003Eb__1(BaseEventData listener)
		{
			actions.ShockButtonReleased();
		}
	}

	private static readonly Vector3 NEW_HUD_OFFSET;

	private Image _shockerCooldown;

	private Button _shockerButton;

	private Animator _shockerAnimator;

	private AttackSequenceDomain _attackSequenceDomain;

	private IShocker _shocker;

	private Transform _shockerBoostVFX;

	private Transform _shockerCooldownVFX;

	private Transform _ultimateShockVFX;

	private bool _allowed;

	private CameraStateUIActions UIActions;

	private ScavengingStateUIActions ScavengeUIActions;

	public ShockerUIComponent(GameObject mainCanvas)
		: base(mainCanvas)
	{
	}

	public void Setup(CameraStateUIActions actions, AttackSequenceDomain attackSequenceDomain, IShocker shocker)
	{
		_attackSequenceDomain = attackSequenceDomain;
		_shocker = shocker;
		UIActions = actions;
		ScavengeUIActions = null;
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
		_003C_003Ec__DisplayClass10_.actions = actions;
		EventTrigger eventTrigger = _shockerButton.gameObject.AddComponent<EventTrigger>();
		EventTrigger.Entry entry = new EventTrigger.Entry();
		entry.eventID = EventTriggerType.PointerDown;
		entry.callback.AddListener(_003C_003Ec__DisplayClass10_._003CSetup_003Eb__0);
		EventTrigger.Entry entry2 = new EventTrigger.Entry();
		entry2.eventID = EventTriggerType.PointerUp;
		entry2.callback.AddListener(_003C_003Ec__DisplayClass10_._003CSetup_003Eb__1);
		eventTrigger.triggers.Add(entry);
		eventTrigger.triggers.Add(entry2);
		_allowed = true;
		if (!_attackSequenceDomain.IsLegacyAnimatronic())
		{
			_shocker.SetShockerOffset(Vector3.zero);
		}
	}

	public void Setup(ScavengingStateUIActions actions, AttackSequenceDomain attackSequenceDomain, IShocker shocker)
	{
		_attackSequenceDomain = attackSequenceDomain;
		_shocker = shocker;
		UIActions = null;
		ScavengeUIActions = actions;
		_003C_003Ec__DisplayClass10_0Scavenge _003C_003Ec__DisplayClass10_0Scavenge = new _003C_003Ec__DisplayClass10_0Scavenge();
		_003C_003Ec__DisplayClass10_0Scavenge.actions = actions;
		EventTrigger eventTrigger = _shockerButton.gameObject.AddComponent<EventTrigger>();
		EventTrigger.Entry entry = new EventTrigger.Entry();
		entry.eventID = EventTriggerType.PointerDown;
		entry.callback.AddListener(_003C_003Ec__DisplayClass10_0Scavenge._003CSetup_003Eb__0);
		EventTrigger.Entry entry2 = new EventTrigger.Entry();
		entry2.eventID = EventTriggerType.PointerUp;
		entry2.callback.AddListener(_003C_003Ec__DisplayClass10_0Scavenge._003CSetup_003Eb__1);
		eventTrigger.triggers.Add(entry);
		eventTrigger.triggers.Add(entry2);
		_allowed = true;
		if (!_attackSequenceDomain.IsLegacyAnimatronic())
		{
			_shocker.SetShockerOffset(Vector3.zero);
		}
	}

	protected override void CacheAndPopulateComponents()
	{
		_components = new ComponentContainer();
		Type[] onlyCacheTypes = new Type[3]
		{
			typeof(Transform),
			typeof(Image),
			typeof(Button)
		};
		_components.CacheComponents(_root, onlyCacheTypes);
		_shockerCooldown = _components.TryGetComponent<Image>("Fill");
		_shockerButton = _components.TryGetComponent<Button>("Button_Shocker");
		_shockerAnimator = _shockerButton.gameObject.GetComponent<Animator>();
	}

	public override void Update()
	{
		if (!_root.activeSelf)
		{
			return;
		}
		if (_shockerButton != null && _shocker != null)
		{
			if (_shocker.GetStatus() == ShockerStatus.ReadyToShock)
			{
				_shockerButton.interactable = !_attackSequenceDomain.IsDisruptionFullyActive();
			}
			else
			{
				_shockerButton.interactable = false;
			}
		}
		if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
		{
			_shockerAnimator.SetTrigger("Pressed");
			if (UIActions != null)
			{
				UIActions.ShockButtonTriggered();
			}
			else
			{
				ScavengeUIActions.ShockButtonTriggered();
			}
		}
		if (Input.GetKeyUp(KeyCode.Space) || Input.GetMouseButtonUp(0))
		{
			if (UIActions != null)
			{
				UIActions.ShockButtonReleased();
			}
			else
			{
				ScavengeUIActions.ShockButtonReleased();
			}
		}
		if (_shockerCooldown != null)
		{
			if (_shocker != null && _shocker.GetStatus() != ShockerStatus.NotEnoughBattery)
			{
				_shockerCooldown.fillAmount = _shocker.GetCooldownPercent();
			}
			else
			{
				_shockerCooldown.fillAmount = 0f;
			}
		}
	}

	public override void UpdateVisibility(bool isMaskFullyOff)
	{
		if (_attackSequenceDomain.GetEncounterUIConfig() == null)
		{
			_root.SetActive(value: false);
		}
		else if (!isMaskFullyOff)
		{
			_root.SetActive(value: false);
		}
		else if (MasterDomain.GetDomain().AttackSequenceDomain.GetEncounterDropsObjectsViewModel().IsDroppedObjectActive)
		{
			_root.SetActive(value: false);
		}
		else if (MasterDomain.GetDomain().DialogDomain._dialogShower.IsShowingDialog())
		{
			_root.SetActive(value: false);
		}
		else
		{
			_root.SetActive(_attackSequenceDomain.GetEncounterUIConfig().ShowShocker & _attackSequenceDomain.IsInEncounter());
		}
	}
}
