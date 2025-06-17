using SRDebugger.Internal;
using SRDebugger.Services;
using SRDebugger.UI.Controls;
using SRF;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SRDebugger.UI.Other
{
	public class DockConsoleController : SRMonoBehaviourEx, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		public const float NonFocusOpacity = 0.65f;

		private bool _isDirty;

		private bool _isDragging;

		private int _pointersOver;

		[RequiredField]
		public GameObject BottomHandle;

		[RequiredField]
		public CanvasGroup CanvasGroup;

		[RequiredField]
		public ConsoleLogControl Console;

		[RequiredField]
		public GameObject Dropdown;

		[RequiredField]
		public Image DropdownToggleSprite;

		[RequiredField]
		public Text TextErrors;

		[RequiredField]
		public Text TextInfo;

		[RequiredField]
		public Text TextWarnings;

		[RequiredField]
		public Toggle ToggleErrors;

		[RequiredField]
		public Toggle ToggleInfo;

		[RequiredField]
		public Toggle ToggleWarnings;

		[RequiredField]
		public GameObject TopBar;

		[RequiredField]
		public GameObject TopHandle;

		public bool IsVisible
		{
			get
			{
				return base.CachedGameObject.activeSelf;
			}
			set
			{
				base.CachedGameObject.SetActive(value);
			}
		}

		protected override void Start()
		{
			base.Start();
			Service.Console.Updated += ConsoleOnUpdated;
			Refresh();
			RefreshAlpha();
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();
			if (Service.Console != null)
			{
				Service.Console.Updated -= ConsoleOnUpdated;
			}
		}

		protected override void OnEnable()
		{
			base.OnEnable();
			_pointersOver = 0;
			_isDragging = false;
			RefreshAlpha();
		}

		protected override void OnDisable()
		{
			base.OnDisable();
			_pointersOver = 0;
		}

		protected override void Update()
		{
			base.Update();
			if (_isDirty)
			{
				Refresh();
			}
		}

		private void ConsoleOnUpdated(IConsoleService console)
		{
			_isDirty = true;
		}

		public void SetDropdownVisibility(bool visible)
		{
			Dropdown.SetActive(visible);
			DropdownToggleSprite.rectTransform.localRotation = Quaternion.Euler(0f, 0f, visible ? 0f : 180f);
		}

		public void SetAlignmentMode(ConsoleAlignment alignment)
		{
			switch (alignment)
			{
			case ConsoleAlignment.Top:
				TopBar.transform.SetSiblingIndex(0);
				Dropdown.transform.SetSiblingIndex(2);
				TopHandle.SetActive(value: false);
				BottomHandle.SetActive(value: true);
				base.transform.SetSiblingIndex(0);
				DropdownToggleSprite.rectTransform.parent.localRotation = Quaternion.Euler(0f, 0f, 0f);
				break;
			case ConsoleAlignment.Bottom:
				Dropdown.transform.SetSiblingIndex(0);
				TopBar.transform.SetSiblingIndex(2);
				TopHandle.SetActive(value: true);
				BottomHandle.SetActive(value: false);
				base.transform.SetSiblingIndex(1);
				DropdownToggleSprite.rectTransform.parent.localRotation = Quaternion.Euler(0f, 0f, 180f);
				break;
			}
		}

		private void Refresh()
		{
			TextInfo.text = SRDebuggerUtil.GetNumberString(Service.Console.InfoCount, 999, "999+");
			TextWarnings.text = SRDebuggerUtil.GetNumberString(Service.Console.WarningCount, 999, "999+");
			TextErrors.text = SRDebuggerUtil.GetNumberString(Service.Console.ErrorCount, 999, "999+");
			_isDirty = false;
		}

		private void RefreshAlpha()
		{
			if (_isDragging || _pointersOver > 0)
			{
				CanvasGroup.alpha = 1f;
			}
			else
			{
				CanvasGroup.alpha = 0.65f;
			}
		}

		public void ToggleDropdownVisible()
		{
			SetDropdownVisibility(!Dropdown.activeSelf);
		}

		public void MenuButtonPressed()
		{
			SRDebug.Instance.ShowDebugPanel(DefaultTabs.Console);
		}

		public void ClearButtonPressed()
		{
			Service.Console.Clear();
		}

		public void TogglesUpdated()
		{
			Console.ShowErrors = ToggleErrors.isOn;
			Console.ShowWarnings = ToggleWarnings.isOn;
			Console.ShowInfo = ToggleInfo.isOn;
			SetDropdownVisibility(visible: true);
		}

		public void OnPointerEnter(PointerEventData e)
		{
			_pointersOver = 1;
			RefreshAlpha();
		}

		public void OnPointerExit(PointerEventData e)
		{
			_pointersOver = 0;
			RefreshAlpha();
		}

		public void OnBeginDrag()
		{
			_isDragging = true;
			RefreshAlpha();
		}

		public void OnEndDrag()
		{
			_isDragging = false;
			_pointersOver = 0;
			RefreshAlpha();
		}
	}
}
