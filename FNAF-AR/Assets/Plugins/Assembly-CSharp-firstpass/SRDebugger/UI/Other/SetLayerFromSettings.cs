using SRF;

namespace SRDebugger.UI.Other
{
	public class SetLayerFromSettings : SRMonoBehaviour
	{
		private void Start()
		{
			base.gameObject.SetLayerRecursive(Settings.Instance.DebugLayer);
		}
	}
}
