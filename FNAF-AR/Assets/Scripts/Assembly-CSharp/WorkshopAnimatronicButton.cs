using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WorkshopAnimatronicButton : MonoBehaviour, IWorkshopSlotButton
{
	[SerializeField]
	[Header("Local Hookups")]
	private TextMeshProUGUI _buttonStatusText;

	[SerializeField]
	private HighlightToggle _highlightToggle;

	[SerializeField]
	private TextMeshProUGUI _costText;

	[SerializeField]
	private Image _image;

	[SerializeField]
	private GameObject _statusIconObject;

	[SerializeField]
	private Button _button;

	[SerializeField]
	private GameObject _timerPanel;

	[SerializeField]
	private GameObject _overlay;

	[SerializeField]
	private GameObject _collectImageParent;

	private WorkshopAnimatronicButtonData _data;

	private string _availableText = "AVAILABLE";

	private string _deliveringText = "DELIVERING";

	private string _returningText = "RETURNING";

	private string _scavengingText = "SALVAGING";

	private string _attackingText = "ATTACKING";

	private string _brokenText;

	private string _collectText = "COLLECT";

	[SpecialName]
	GameObject IWorkshopSlotButton.gameObject => base.gameObject;

	private void OnSelectButton()
	{
		if (_data.SelectButton != null)
		{
			_data.SelectButton(this);
		}
	}

	private void SetStatusText(string newText)
	{
		if (!(_buttonStatusText == null))
		{
			_buttonStatusText.text = newText;
		}
	}

	private void UpdateWearAndTearText()
	{
		if (_data.workshopSlotData != null && _data.workshopSlotData.workshopEntry != null)
		{
			_costText.text = _data.workshopSlotData.workshopEntry.health + "%";
		}
	}

	private void UpdateAvailableText()
	{
		if (_data.workshopSlotData == null || _buttonStatusText == null)
		{
			return;
		}
		if (_data.workshopSlotData.workshopEntry.health <= 0)
		{
			_buttonStatusText.text = _brokenText;
		}
		else
		{
			string text = _data.workshopSlotData.workshopEntry.status switch
			{
				WorkshopEntry.Status.Available => _availableText, 
				WorkshopEntry.Status.Scavenging => _scavengingText, 
				WorkshopEntry.Status.Sent => _deliveringText, 
				WorkshopEntry.Status.Returning => _returningText, 
				WorkshopEntry.Status.Attacking => _attackingText, 
				WorkshopEntry.Status.ScavengeAppointment => _scavengingText, 
				WorkshopEntry.Status.LoadScavenging => _collectText, 
				_ => _deliveringText, 
			};
			_buttonStatusText.text = text;
			if (_data.workshopSlotData.workshopEntry.status == WorkshopEntry.Status.ScavengeAppointment)
			{
				return;
			}
		}
		_statusIconObject.SetActive(value: false);
		_timerPanel.SetActive(value: false);
	}

	private void UpdateIcon(Sprite icon)
	{
		if (!(_image.overrideSprite == icon))
		{
			_image.overrideSprite = icon;
		}
	}

	public bool IsReadyToCollect()
	{
		return false;
	}

	public void SetSelectedUI(bool value)
	{
		_highlightToggle.SetHighlightAndOtherCellsHighlightState(value);
	}

	public void Initialize(WorkshopAnimatronicButtonData data)
	{
		_data = data;
		_image.overrideSprite = _data.workshopSlotData.sprite;
		if (_data.workshopSlotData != null)
		{
			_data.workshopSlotData.IconUpdated = UpdateIcon;
		}
	}

	private void Awake()
	{
		Debug.Log("new slot!");
		_button.onClick.RemoveListener(OnSelectButton);
		_button.onClick.AddListener(OnSelectButton);
		FetchLocalization();
	}

	private void Start()
	{
		UpdateDisplay();
	}

	private void FetchLocalization()
	{
		LocalizationDomain.Instance.Localization.GetInterfaceAsync(FetchLocalizationb__29_0);
	}

	private void FetchLocalizationb__29_0(Localization localization)
	{
		_returningText = LocalizationDomain.Instance.ILocalization.GetLocalizedString("ui_workshop_main_page_interface_status_recalling_text", _returningText);
		_availableText = LocalizationDomain.Instance.ILocalization.GetLocalizedString("ui_workshop_main_page_interface_status_available_text", _availableText);
		_scavengingText = LocalizationDomain.Instance.ILocalization.GetLocalizedString("ui_workshop_main_page_interface_status_scavenging_text", _scavengingText);
		_deliveringText = LocalizationDomain.Instance.ILocalization.GetLocalizedString("ui_workshop_main_page_interface_status_delivering_text", _deliveringText);
		_attackingText = LocalizationDomain.Instance.ILocalization.GetLocalizedString("ui_workshop_main_page_interface_status_attacking_text", _attackingText);
		_brokenText = LocalizationDomain.Instance.ILocalization.GetLocalizedString("ui_workshop_main_page_interface_status_broken_text", _brokenText);
		_collectText = LocalizationDomain.Instance.ILocalization.GetLocalizedString("ui_workshop_main_page_interface_status_collect_text", _collectText);
	}

	private void Update()
	{
		UpdateDisplay();
	}

	private void UpdateDisplay()
	{
		UpdateAvailableText();
		UpdateWearAndTearText();
		UpdateOverlays();
	}

	private void UpdateOverlays()
	{
		bool active = _data.workshopSlotData.workshopEntry.status == WorkshopEntry.Status.ScavengeAppointment && IsReadyToCollect();
		_collectImageParent.SetActive(active);
		_overlay.SetActive(_data.workshopSlotData.workshopEntry.status != WorkshopEntry.Status.Available);
	}

	public int GetSortWeight()
	{
		return _data.index;
	}

	public WorkshopSlotData GetWorkshopSlotData()
	{
		return _data.workshopSlotData;
	}

	public void OverrideSlotDataState(WorkshopEntry.Status newStatus)
	{
		_data.eventExposer.OnWorkshopButtonStateOverride(_data.workshopSlotData, _data.workshopSlotData.workshopEntry.status, newStatus);
		_data.workshopSlotData.workshopEntry.status = newStatus;
	}

	public void TearDown()
	{
		Debug.Log("tearing down portrait button!");
		if (_data.workshopSlotData != null && _data.workshopSlotData.IconUpdated != null)
		{
			_data.workshopSlotData.IconUpdated = null;
		}
		if (!(this == null) && base.gameObject != null)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void OnDestroy()
	{
	}

	public WorkshopAnimatronicButton()
	{
		_availableText = "AVAILABLE";
		_deliveringText = "DELIVERING";
		_returningText = "RETURNING";
		_scavengingText = "SALVAGING";
		_attackingText = "ATTACKING";
		_brokenText = "BROKEN";
		_collectText = "COLLECT";
	}
}
