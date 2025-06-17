using System.Collections.Generic;
using UnityEngine;

public class EncounterEnvironment : MonoBehaviour
{
	public List<Transform> droppablePositions = new List<Transform>();

	public List<Light> haywireLights = new List<Light>();

	public void SetLightColorMode(Color lightColor)
	{
		foreach (Light haywireLight in haywireLights)
		{
			haywireLight.color = lightColor;
		}
	}
}
