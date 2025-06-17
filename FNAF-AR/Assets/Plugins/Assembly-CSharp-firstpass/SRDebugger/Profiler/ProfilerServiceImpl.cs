using System.Diagnostics;
using SRDebugger.Services;
using SRF;
using SRF.Service;
using UnityEngine;

namespace SRDebugger.Profiler
{
	[Service(typeof(IProfilerService))]
	public class ProfilerServiceImpl : SRServiceBase<IProfilerService>, IProfilerService
	{
		private const int FrameBufferSize = 400;

		private readonly SRList<ProfilerCameraListener> _cameraListeners = new SRList<ProfilerCameraListener>();

		private readonly CircularBuffer<ProfilerFrame> _frameBuffer = new CircularBuffer<ProfilerFrame>(400);

		private Camera[] _cameraCache = new Camera[6];

		private ProfilerLateUpdateListener _lateUpdateListener;

		private double _renderDuration;

		private int _reportedCameras;

		private Stopwatch _stopwatch = new Stopwatch();

		private double _updateDuration;

		private double _updateToRenderDuration;

		public float AverageFrameTime { get; private set; }

		public float LastFrameTime { get; private set; }

		public CircularBuffer<ProfilerFrame> FrameBuffer => _frameBuffer;

		protected void PushFrame(double totalTime, double updateTime, double renderTime)
		{
			_frameBuffer.PushBack(new ProfilerFrame
			{
				OtherTime = totalTime - updateTime - renderTime,
				UpdateTime = updateTime,
				RenderTime = renderTime
			});
		}

		protected override void Awake()
		{
			base.Awake();
			_lateUpdateListener = base.gameObject.AddComponent<ProfilerLateUpdateListener>();
			_lateUpdateListener.OnLateUpdate = OnLateUpdate;
			base.CachedGameObject.hideFlags = HideFlags.NotEditable;
			base.CachedTransform.SetParent(Hierarchy.Get("SRDebugger"), worldPositionStays: true);
		}

		protected override void Update()
		{
			base.Update();
			if (FrameBuffer.Count > 0)
			{
				ProfilerFrame value = FrameBuffer.Back();
				value.FrameTime = Time.deltaTime;
				FrameBuffer[FrameBuffer.Count - 1] = value;
			}
			LastFrameTime = Time.deltaTime;
			int num = Mathf.Min(20, FrameBuffer.Count);
			double num2 = 0.0;
			for (int i = 0; i < num; i++)
			{
				num2 += FrameBuffer[i].FrameTime;
			}
			AverageFrameTime = (float)num2 / (float)num;
			_ = _reportedCameras;
			_ = _cameraListeners.Count;
			if (_stopwatch.IsRunning)
			{
				_stopwatch.Stop();
				_stopwatch.Reset();
			}
			_updateDuration = (_renderDuration = (_updateToRenderDuration = 0.0));
			_reportedCameras = 0;
			CameraCheck();
			_stopwatch.Start();
		}

		private void OnLateUpdate()
		{
			_updateDuration = _stopwatch.Elapsed.TotalSeconds;
		}

		private void EndFrame()
		{
			if (_stopwatch.IsRunning)
			{
				PushFrame(_stopwatch.Elapsed.TotalSeconds, _updateDuration, _renderDuration);
				_stopwatch.Reset();
				_stopwatch.Start();
			}
		}

		private void CameraDurationCallback(ProfilerCameraListener listener, double duration)
		{
			_reportedCameras++;
			_renderDuration = _stopwatch.Elapsed.TotalSeconds - _updateDuration - _updateToRenderDuration;
			if (_reportedCameras >= GetExpectedCameraCount())
			{
				EndFrame();
			}
		}

		private int GetExpectedCameraCount()
		{
			int num = 0;
			for (int i = 0; i < _cameraListeners.Count; i++)
			{
				if (!(_cameraListeners[i] != null) || (_cameraListeners[i].isActiveAndEnabled && _cameraListeners[i].Camera.isActiveAndEnabled))
				{
					num++;
				}
			}
			return num;
		}

		private void CameraCheck()
		{
			for (int num = _cameraListeners.Count - 1; num >= 0; num--)
			{
				if (_cameraListeners[num] == null)
				{
					_cameraListeners.RemoveAt(num);
				}
			}
			if (Camera.allCamerasCount == _cameraListeners.Count)
			{
				return;
			}
			if (Camera.allCamerasCount > _cameraCache.Length)
			{
				_cameraCache = new Camera[Camera.allCamerasCount];
			}
			int allCameras = Camera.GetAllCameras(_cameraCache);
			for (int i = 0; i < allCameras; i++)
			{
				Camera camera = _cameraCache[i];
				bool flag = false;
				for (int j = 0; j < _cameraListeners.Count; j++)
				{
					if (_cameraListeners[j].Camera == camera)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					ProfilerCameraListener profilerCameraListener = camera.gameObject.AddComponent<ProfilerCameraListener>();
					profilerCameraListener.hideFlags = HideFlags.DontSave | HideFlags.NotEditable;
					profilerCameraListener.RenderDurationCallback = CameraDurationCallback;
					_cameraListeners.Add(profilerCameraListener);
				}
			}
		}
	}
}
