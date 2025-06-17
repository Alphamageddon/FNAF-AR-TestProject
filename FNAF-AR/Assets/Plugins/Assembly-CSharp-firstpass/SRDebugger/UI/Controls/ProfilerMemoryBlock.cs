using System;
using System.Collections;
using SRF;
using UnityEngine;
using UnityEngine.Profiling;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls
{
	public class ProfilerMemoryBlock : SRMonoBehaviourEx
	{
		private float _lastRefresh;

		[RequiredField]
		public Text CurrentUsedText;

		[RequiredField]
		public Slider Slider;

		[RequiredField]
		public Text TotalAllocatedText;

		protected override void OnEnable()
		{
			base.OnEnable();
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
			long totalReservedMemoryLong = UnityEngine.Profiling.Profiler.GetTotalReservedMemoryLong();
			long totalAllocatedMemoryLong = UnityEngine.Profiling.Profiler.GetTotalAllocatedMemoryLong();
			long num = totalReservedMemoryLong >> 10;
			num /= 1024;
			long num2 = totalAllocatedMemoryLong >> 10;
			num2 /= 1024;
			Slider.maxValue = num;
			Slider.value = num2;
			TotalAllocatedText.text = "Reserved: <color=#FFFFFF>{0}</color>MB".Fmt(num);
			CurrentUsedText.text = "<color=#FFFFFF>{0}</color>MB".Fmt(num2);
		}

		public void TriggerCleanup()
		{
			StartCoroutine(CleanUp());
		}

		private IEnumerator CleanUp()
		{
			GC.Collect();
			yield return Resources.UnloadUnusedAssets();
			GC.Collect();
			TriggerRefresh();
		}
	}
}
