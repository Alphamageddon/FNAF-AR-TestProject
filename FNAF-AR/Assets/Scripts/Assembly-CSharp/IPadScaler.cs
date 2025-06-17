using UnityEngine;
using UnityEngine.UI;

public class IPadScaler : MonoBehaviour
{
	private void Awake()
	{
		if (SystemInfo.deviceModel.ToLower().Contains("ipad"))
		{
			base.gameObject.GetComponent<CanvasScaler>().matchWidthOrHeight = 0.4f;
		}
	}
}
