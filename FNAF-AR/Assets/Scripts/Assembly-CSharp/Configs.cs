using UnityEngine;

public class Configs : MonoBehaviour
{
	[SerializeField]
	private AnimatronicEntityConfig _animatronicEntityConfig;

	public AnimatronicEntityConfig AnimatronicEntityConfig => _animatronicEntityConfig;
}
