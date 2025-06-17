using UnityEngine;

public class SeasonalAssetReceiver : MonoBehaviour
{
	[SerializeField]
	private string _seasonalKey;

	public string ReceiverId => _seasonalKey;

	private void Awake()
	{
		Request();
	}

	public void Request()
	{
	}
}
