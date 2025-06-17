using System;
using SRF;
using UnityEngine;
using UnityEngine.Profiling;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls
{
	public class ProfilerMonoBlock : SRMonoBehaviourEx
	{
		private float _lastRefresh;

		[RequiredField]
		public Text CurrentUsedText;

		[RequiredField]
		public GameObject NotSupportedMessage;

		[RequiredField]
		public Slider Slider;

		[RequiredField]
		public Text TotalAllocatedText;

		private bool _isSupported;

		protected override void OnEnable()
		{
			base.OnEnable();
			_isSupported = UnityEngine.Profiling.Profiler.GetMonoUsedSizeLong() > 0;
			NotSupportedMessage.SetActive(!_isSupported);
			CurrentUsedText.gameObject.SetActive(_isSupported);
			TriggerRefresh();
		}

		protected override void Update()
		{
			base.Update();
			if (SRDebug.Instance.IsDebugPanelVisible && Time.realtimeSinceStartup - _lastRefresh > 1f)
			{
				TriggerRefresh();
				_lastRefresh = Time.realtimeSinceStartup;
			}
		}

		public void TriggerRefresh()
		{
			long num = (_isSupported ? UnityEngine.Profiling.Profiler.GetMonoHeapSizeLong() : GC.GetTotalMemory(forceFullCollection: false));
			long monoUsedSizeLong = UnityEngine.Profiling.Profiler.GetMonoUsedSizeLong();
			long num2 = num >> 10;
			num2 /= 1024;
			long num3 = monoUsedSizeLong >> 10;
			num3 /= 1024;
			Slider.maxValue = num2;
			Slider.value = num3;
			TotalAllocatedText.text = "Total: <color=#FFFFFF>{0}</color>MB".Fmt(num2);
			if (num3 > 0)
			{
				CurrentUsedText.text = "<color=#FFFFFF>{0}</color>MB".Fmt(num3);
			}
		}

		public void TriggerCollection()
		{
			GC.Collect();
			TriggerRefresh();
		}
	}
}
