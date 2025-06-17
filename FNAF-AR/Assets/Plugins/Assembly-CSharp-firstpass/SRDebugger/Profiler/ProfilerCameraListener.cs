using System;
using System.Diagnostics;
using UnityEngine;

namespace SRDebugger.Profiler
{
	[RequireComponent(typeof(Camera))]
	public class ProfilerCameraListener : MonoBehaviour
	{
		private Camera _camera;

		private Stopwatch _stopwatch;

		public Action<ProfilerCameraListener, double> RenderDurationCallback;

		protected Stopwatch Stopwatch
		{
			get
			{
				if (_stopwatch == null)
				{
					_stopwatch = new Stopwatch();
				}
				return _stopwatch;
			}
		}

		public Camera Camera
		{
			get
			{
				if (_camera == null)
				{
					_camera = GetComponent<Camera>();
				}
				return _camera;
			}
		}

		private void OnPreCull()
		{
			if (base.isActiveAndEnabled)
			{
				Stopwatch.Start();
			}
		}

		private void OnPostRender()
		{
			if (base.isActiveAndEnabled)
			{
				double totalSeconds = _stopwatch.Elapsed.TotalSeconds;
				Stopwatch.Stop();
				Stopwatch.Reset();
				if (RenderDurationCallback == null)
				{
					UnityEngine.Object.Destroy(this);
				}
				else
				{
					RenderDurationCallback(this, totalSeconds);
				}
			}
		}
	}
}
