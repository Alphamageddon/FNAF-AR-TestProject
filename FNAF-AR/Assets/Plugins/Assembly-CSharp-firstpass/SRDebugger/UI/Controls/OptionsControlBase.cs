using SRDebugger.Internal;
using SRF;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls
{
	public abstract class OptionsControlBase : SRMonoBehaviourEx
	{
		private bool _selectionModeEnabled;

		[RequiredField]
		public Toggle SelectionModeToggle;

		public OptionDefinition Option;

		public bool SelectionModeEnabled
		{
			get
			{
				return _selectionModeEnabled;
			}
			set
			{
				if (value != _selectionModeEnabled)
				{
					_selectionModeEnabled = value;
					SelectionModeToggle.gameObject.SetActive(_selectionModeEnabled);
					if (SelectionModeToggle.graphic != null)
					{
						SelectionModeToggle.graphic.CrossFadeAlpha((!IsSelected) ? 0f : (_selectionModeEnabled ? 1f : 0.2f), 0f, ignoreTimeScale: true);
					}
				}
			}
		}

		public bool IsSelected
		{
			get
			{
				return SelectionModeToggle.isOn;
			}
			set
			{
				SelectionModeToggle.isOn = value;
				if (SelectionModeToggle.graphic != null)
				{
					SelectionModeToggle.graphic.CrossFadeAlpha((!value) ? 0f : (_selectionModeEnabled ? 1f : 0.2f), 0f, ignoreTimeScale: true);
				}
			}
		}

		protected override void Awake()
		{
			base.Awake();
			IsSelected = false;
			SelectionModeToggle.gameObject.SetActive(value: false);
		}

		protected override void OnEnable()
		{
			base.OnEnable();
			if (SelectionModeToggle.graphic != null)
			{
				SelectionModeToggle.graphic.CrossFadeAlpha((!IsSelected) ? 0f : (_selectionModeEnabled ? 1f : 0.2f), 0f, ignoreTimeScale: true);
			}
		}

		public virtual void Refresh()
		{
		}
	}
}
