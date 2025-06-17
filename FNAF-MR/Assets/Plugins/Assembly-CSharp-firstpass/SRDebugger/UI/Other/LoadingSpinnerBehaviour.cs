using SRF;
using UnityEngine;

namespace SRDebugger.UI.Other
{
	public class LoadingSpinnerBehaviour : SRMonoBehaviour
	{
		private float _dt;

		public int FrameCount = 12;

		public float SpinDuration = 0.8f;

		private void Update()
		{
			_dt += Time.unscaledDeltaTime;
			Vector3 eulerAngles = base.CachedTransform.localRotation.eulerAngles;
			float num = eulerAngles.z;
			float num2 = SpinDuration / (float)FrameCount;
			bool flag = false;
			while (_dt > num2)
			{
				num -= 360f / (float)FrameCount;
				_dt -= num2;
				flag = true;
			}
			if (flag)
			{
				base.CachedTransform.localRotation = Quaternion.Euler(eulerAngles.x, eulerAngles.y, num);
			}
		}
	}
}
