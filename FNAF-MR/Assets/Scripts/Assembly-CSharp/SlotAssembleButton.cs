using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SlotAssembleButton : MonoBehaviour, ICellInterface<SlotAssembleButtonLoadData>
{
	[SerializeField]
	private Button _button;

	[SerializeField]
	private GameObject _imagesParent;

	[SerializeField]
	private Image _modImage;

	[SerializeField]
	private Image _plushImage;

	[SerializeField]
	private Image _cpuImage;

	[SerializeField]
	private GameObject _lockedSlotParent;

	[SerializeField]
	private GameObject _emptySlotParent;

	[SerializeField]
	private GameObject _activeSlotParent;

	[SerializeField]
	private StarDisplay _starDisplay;

	[SerializeField]
	private TextMeshProUGUI _lockedText;

	[SerializeField]
	private TextMeshProUGUI _emptyText;

	[SerializeField]
	private TextMeshProUGUI _streakText;

	private SlotAssembleButtonLoadData _data;

	private SlotState _slotState;

	private EventExposer _eventExposer;

	private void ButtonClicked()
	{
		if (_eventExposer != null)
		{
			_eventExposer.OnWorkshopModifyAssemblyButtonPressed(new AssemblyButtonPressedPayload
			{
				ButtonType = _data.SlotType,
				Index = _data.Index,
				SlotState = _data.SlotState
			});
		}
	}

	private void UpdateDisplayState()
	{
		_lockedSlotParent.SetActive(_data.SlotState == SlotState.Locked);
		_emptySlotParent.SetActive(_data.SlotState == SlotState.Empty);
		_activeSlotParent.SetActive(_data.SlotState == SlotState.Active);
		_modImage.gameObject.SetActive(_data.SlotType == SlotDisplayButtonType.Mod);
		_plushImage.gameObject.SetActive(_data.SlotType == SlotDisplayButtonType.Plushsuit);
		_cpuImage.gameObject.SetActive(_data.SlotType == SlotDisplayButtonType.Cpu);
		_starDisplay.gameObject.SetActive(_data.NumStars > 0);
		_starDisplay.SetStars(_data.NumStars);
	}

	private void UpdateButtonText()
	{
		if (_streakText != null && _data.StreakText != null)
		{
			_streakText.text = _data.StreakText;
		}
		if (_emptyText != null && _data.EmptyText != null)
		{
			_emptyText.text = _data.EmptyText;
		}
		if (_lockedText != null && _data.LockedText != null)
		{
			_lockedText.text = _data.LockedText;
		}
	}

	public void SetData(SlotAssembleButtonLoadData data)
	{
		_data = data;
		UpdateButtonText();
		UpdateDisplayState();
	}

	public void SetSprite(Sprite sprite)
	{
		_imagesParent.SetActive(sprite != null);
		_plushImage.overrideSprite = sprite;
		_cpuImage.overrideSprite = sprite;
		_modImage.overrideSprite = sprite;
	}

	private void Awake()
	{
		MasterDomain domain = MasterDomain.GetDomain();
		if (domain != null)
		{
			_eventExposer = domain.eventExposer;
			_button.onClick.RemoveListener(ButtonClicked);
			_button.onClick.AddListener(ButtonClicked);
		}
	}
}
