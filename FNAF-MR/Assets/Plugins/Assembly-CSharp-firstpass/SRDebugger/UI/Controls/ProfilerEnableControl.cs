using SRDebugger.Internal;
using SRF;
using UnityEngine;
using UnityEngine.Profiling;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls
{
	public class ProfilerEnableControl : SRMonoBehaviourEx
	{
		private bool _previousState;

		[RequiredField]
		public Text ButtonText;

		[RequiredField]
		public Button EnableButton;

		[RequiredField]
		public Text Text;

		protected override void Start()
		{
			base.Start();
			if (!UnityEngine.Profiling.Profiler.supported)
			{
				Text.text = SRDebugStrings.Current.Profiler_NotSupported;
				EnableButton.gameObject.SetActive(value: false);
				base.enabled = false;
			}
			else if (!Application.HasProLicense())
			{
				Text.text = SRDebugStrings.Current.Profiler_NoProInfo;
				EnableButton.gameObject.SetActive(value: false);
				base.enabled = false;
			}
			else
			{
				UpdateLabels();
			}
		}

		protected void UpdateLabels()
		{
			if (!UnityEngine.Profiling.Profiler.enabled)
			{
				Text.text = SRDebugStrings.Current.Profiler_EnableProfilerInfo;
				ButtonText.text = "Enable";
			}
			else
			{
				Text.text = SRDebugStrings.Current.Profiler_DisableProfilerInfo;
				ButtonText.text = "Disable";
			}
			_previousState = UnityEngine.Profiling.Profiler.enabled;
		}

		protected override void Update()
		{
			base.Update();
			if (UnityEngine.Profiling.Profiler.enabled != _previousState)
			{
				UpdateLabels();
			}
		}

		public void ToggleProfiler()
		{
			Debug.Log("Toggle Profiler");
			UnityEngine.Profiling.Profiler.enabled = !UnityEngine.Profiling.Profiler.enabled;
		}
	}
}
