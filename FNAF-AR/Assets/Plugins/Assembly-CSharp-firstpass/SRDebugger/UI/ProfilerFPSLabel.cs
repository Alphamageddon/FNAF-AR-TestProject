using SRDebugger.Services;
using SRF;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI
{
	public class ProfilerFPSLabel : SRMonoBehaviourEx
	{
		private float _nextUpdate;

		[Import]
		private IProfilerService _profilerService;

		public float UpdateFrequency = 1f;

		[RequiredField]
		[SerializeField]
		private Text _text;

		protected override void Update()
		{
			base.Update();
			if (Time.realtimeSinceStartup > _nextUpdate)
			{
				Refresh();
			}
		}

		private void Refresh()
		{
			_text.text = "FPS: {0:0.00}".Fmt(1f / _profilerService.AverageFrameTime);
			_nextUpdate = Time.realtimeSinceStartup + UpdateFrequency;
		}
	}
}
