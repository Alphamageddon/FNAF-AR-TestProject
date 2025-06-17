using SRF;
using UnityEngine;

namespace SRDebugger
{
	[AddComponentMenu("SRDebugger Init")]
	public class SRDebuggerInit : SRMonoBehaviourEx
	{
		protected override void Awake()
		{
			base.Awake();
			if (Settings.Instance.IsEnabled)
			{
				SRDebug.Init();
			}
		}

		protected override void Start()
		{
			base.Start();
			Object.Destroy(base.CachedGameObject);
		}
	}
}
