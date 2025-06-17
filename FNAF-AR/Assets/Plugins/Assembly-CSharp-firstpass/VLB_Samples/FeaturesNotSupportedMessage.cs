using UnityEngine;
using UnityEngine.UI;
using VLB;

namespace VLB_Samples
{
	[RequireComponent(typeof(Text))]
	public class FeaturesNotSupportedMessage : MonoBehaviour
	{
		private void Start()
		{
			GetComponent<Text>().text = (Noise3D.isSupported ? "" : Noise3D.isNotSupportedString);
		}
	}
}
