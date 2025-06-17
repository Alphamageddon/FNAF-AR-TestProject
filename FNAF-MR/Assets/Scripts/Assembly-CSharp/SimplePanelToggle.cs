using UnityEngine;
using UnityEngine.UI;

public class SimplePanelToggle : MonoBehaviour
{
	[SerializeField]
	private Button _toggleOnButton;

	[SerializeField]
	private Button _toggleOffButton;

	[SerializeField]
	private GameObject _togglePanel;

	private void ToggleOn()
	{
		if (!(_togglePanel == null))
		{
			_togglePanel.SetActive(value: true);
		}
	}

	private void ToggleOff()
	{
		if (!(_togglePanel == null))
		{
			_togglePanel.SetActive(value: false);
		}
	}

	private void Awake()
	{
		if (_toggleOnButton != null)
		{
			_toggleOnButton.onClick.AddListener(ToggleOn);
		}
		if (!(_toggleOffButton == null))
		{
			_toggleOffButton.onClick.AddListener(ToggleOff);
		}
	}

	private void OnDisable()
	{
		if (!(_togglePanel == null))
		{
			_togglePanel.SetActive(value: false);
		}
	}

	private void OnDestroy()
	{
		if (_toggleOnButton != null)
		{
			_toggleOnButton.onClick.RemoveListener(ToggleOn);
		}
		if (!(_toggleOffButton == null))
		{
			_toggleOffButton.onClick.RemoveListener(ToggleOff);
		}
	}
}
