using SRF;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls
{
	[RequireComponent(typeof(RectTransform))]
	public class ProfilerGraphAxisLabel : SRMonoBehaviourEx
	{
		private float _prevFrameTime;

		private float? _queuedFrameTime;

		private float _yPosition;

		[RequiredField]
		public Text Text;

		protected override void Update()
		{
			base.Update();
			if (_queuedFrameTime.HasValue)
			{
				SetValueInternal(_queuedFrameTime.Value);
				_queuedFrameTime = null;
			}
		}

		public void SetValue(float frameTime, float yPosition)
		{
			if (_prevFrameTime != frameTime || _yPosition != yPosition)
			{
				_queuedFrameTime = frameTime;
				_yPosition = yPosition;
			}
		}

		private void SetValueInternal(float frameTime)
		{
			_prevFrameTime = frameTime;
			int num = Mathf.FloorToInt(frameTime * 1000f);
			int num2 = Mathf.RoundToInt(1f / frameTime);
			Text.text = "{0}ms ({1}FPS)".Fmt(num, num2);
			RectTransform obj = (RectTransform)base.CachedTransform;
			obj.anchoredPosition = new Vector2(obj.rect.width * 0.5f + 10f, _yPosition);
		}
	}
}
